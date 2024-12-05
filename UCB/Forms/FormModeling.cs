using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UCB
{
    partial class FormModeling : Form
    {
        private Player _player;
        private DataTable _dataTable = null;

        public event Action ResultChanged;
        public event Action ClearChart;

        public FormModeling(Color backColor)
        {
            InitializeComponent();
            CreateTable();

            _dataGridView.BackgroundColor = backColor;
            _cmbDistribution.SelectedIndex = _cmbTypeProcessingData.SelectedIndex = 0;
            _btnPause.Enabled = _btnCancel.Enabled = _btnSave.Enabled = false;

            OnDeviationChanged(_numDeviationStart, EventArgs.Empty);
        }

        public bool IsSimulationFinished { get; private set; } = true;

        public bool IsDataSaved { get; private set; } = true;

        public RegretTable RegretTable =>
            _player.RegretTable;

        private bool ControlsEnabled
        {
            set
            {
                _grpTypeBandit.Enabled = value;
                _grpGeneralParameters.Enabled = value;
                _grpBordersDeviationExp.Enabled = value;
                _grpHorizon.Enabled = value;
                _grpParameter.Enabled = value;
                _grpSimulationSettings.Enabled = value;
                _dataGridView.CurrentCell.Selected = value;
                _dataGridView.DefaultCellStyle.SelectionBackColor = value ? SystemColors.Highlight : Color.Transparent;

                for (int i = 1; i < _dataGridView.ColumnCount; i++)
                    try { _dataGridView.Columns[i].ReadOnly = !value; }
                    catch (InvalidOperationException) { }
            }
        }

        private bool ButtonsEnabled
        {
            set
            {
                _btnNew.Enabled = value;
                _btnOpen.Enabled = value;

                _btnPause.Enabled = !value;
                _btnCancel.Enabled = !value;
                _progressBar.Visible = !value;
            }
        }

        private void CreateTable()
        {
            _dataTable?.Dispose();
            _dataTable = new DataTable("Bandits");
            _dataGridView.DataSource = _dataTable;

            _dataTable.Columns.Add(new DataColumn("NumberRow", typeof(int)));
            _dataTable.Columns.Add(new DataColumn("Arms", typeof(int)));
            _dataTable.Columns.Add(new DataColumn("NumberBatches", typeof(int)));
            _dataTable.Columns.Add(new DataColumn("BatchSize", typeof(int)));
            _dataTable.Columns.Add(new DataColumn("Horizon", typeof(int)));
            _dataTable.Columns.Add(new DataColumn("Parameter", typeof(double)));

            _dataGridView.Columns["NumberRow"].HeaderText = "№";
            _dataGridView.Columns["Arms"].HeaderText = "Число рук J";
            _dataGridView.Columns["NumberBatches"].HeaderText = "Число пакетов K";
            _dataGridView.Columns["BatchSize"].HeaderText = "Размер пакета M";
            _dataGridView.Columns["Horizon"].HeaderText = "Горизонт N";
            _dataGridView.Columns["Parameter"].HeaderText = "Параметр стратегии a";

            _dataTable.Columns["Horizon"].Expression = "NumberBatches * BatchSize";
            _dataGridView.Columns["NumberRow"].ReadOnly = true;
            _dataGridView.Columns["Parameter"].DefaultCellStyle.Format = "f2";

            Font fontTable = new Font("", 14);

            for (int i = 0; i < _dataGridView.Columns.Count; i++)
            {
                _dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                _dataGridView.Columns[i].HeaderCell.Style.Font = fontTable;
                _dataGridView.Columns[i].DefaultCellStyle.Font = fontTable;
                _dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                _dataGridView.Columns[i].HeaderCell.Style.ForeColor = Color.White;

                if (i == 0)
                    _dataGridView.Columns[i].Width = 50;
                else
                    _dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            OnBanditsCountChanged(null, EventArgs.Empty);
            OnCountArmsChanged(null, EventArgs.Empty);
            OnNumberBatchesChanged(null, EventArgs.Empty);
            OnBatchSizeChanged(null, EventArgs.Empty);
            OnParametersChanged(null, EventArgs.Empty);
        }

        private void ShowResult()
        {
            ResultChanged?.Invoke();
            _lblDialog.Text = _player.GameResult;
        }

        private void UpdateProgressBar() =>
            _progressBar.Value = _player.PercentProgress;

        private void FinishSimulation(bool isCorrect)
        {
            _timer.Stop();

            if (_player != null)
                _player.ProgressChanged -= UpdateProgressBar;

            if (isCorrect)
            {
                ShowResult();
                OnChkPlaySoundCheckedChanged(_chkSoundPlay, EventArgs.Empty);
            }
            else
            {
                _lblDialog.Text = string.Empty;
            }

            _progressBar.Value = _progressBar.Minimum;
            _btnSave.Enabled = isCorrect;
            _btnStart.Enabled = ControlsEnabled = IsDataSaved = !isCorrect;

            ButtonsEnabled = IsSimulationFinished = true;
        }

        private void DisposePlayer()
        {
            if (_player != null)
            {
                _player.ProgressChanged -= UpdateProgressBar;
                _player.Dispose();
            }
        }

        private T[] GetColumn<T>(string nameColumn)
        {
            T[] arr = new T[_dataGridView.Rows.Count];

            for (int i = 0; i < _dataGridView.Rows.Count; i++)
                try
                {
                    arr[i] = (T)Convert.ChangeType(_dataGridView.Rows[i].Cells[nameColumn].Value, typeof(T));
                }
                catch (InvalidCastException)
                {
                    arr[i] = default;
                }

            return arr;
        }

        private void SetColumn<T>(string nameColumn, T value)
        {
            foreach (DataGridViewRow row in _dataGridView.Rows)
                row.Cells[nameColumn].Value = value;
        }

        private void SetColumn<T>(string nameColumn, T[] value)
        {
            var i = 0;
            foreach (DataGridViewRow row in _dataGridView.Rows)
                row.Cells[nameColumn].Value = value[i++];
        }

        private void OnNewClick(object sender, EventArgs e)
        {
            if (!IsDataSaved && DialogResult.No == MessageBox.Show($"Несохранённые данные будут удалены.\nПродолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            ClearChart?.Invoke();
            DisposePlayer();

            _lblDialog.Text = string.Empty;
            _btnSave.Enabled = false;

            IsDataSaved = ControlsEnabled = _btnStart.Enabled = true;
        }

        [Obsolete]
        private void OnStartClick(object sender, EventArgs e)
        {
            DisposePlayer();
            ControlsEnabled = ButtonsEnabled = IsSimulationFinished = IsDataSaved = _btnStart.Enabled = false;

            var distribution = (Distribution)_cmbDistribution.SelectedIndex;
            var expectation = (double)_numExpectation.Value;
            var maxVariance = (double)_numMaxVariance.Value;
            var deviationStart = (double)_numDeviationStart.Value;
            var deviationStep = (double)_numDeviationDelta.Value;
            var deviationCount = (int)_numDeviationCount.Value;
            var typeProcessingData = (TypeProcessingData)_cmbTypeProcessingData.SelectedIndex;
            var variancesKnown = !_chkVariancesKnown.Checked;

            var countArms = GetColumn<int>("Arms");
            var numberBatches = GetColumn<int>("NumberBatches");
            var batchSize = GetColumn<int>("BatchSize");
            var parameters = GetColumn<double>("Parameter");

            var deviations = CollectionHandler.CreateArray(deviationStart, deviationStep, deviationCount, 1);
            var countGames = (int)_numNumberSimulations.Value;
            var countThreads = (int)_numCountThreads.Value;

            _player = new Player(expectation, maxVariance, distribution, typeProcessingData, variancesKnown, countArms, numberBatches, batchSize, parameters);
            _player.ProgressChanged += UpdateProgressBar;
            _player.Play(deviations, countGames, countThreads);
            _timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (_player.IsPlaying)
                _lblDialog.Text = _player.GameInformation;
            else
                FinishSimulation(true);
        }

        [Obsolete]
        private void OnCancelClick(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Вы действительно хотите отменить вычисления?", "Отмена операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            if (_player.IsPaused)
                OnPauseClick(_btnPause, EventArgs.Empty);

            _player.CancelGame();

            FinishSimulation(false);
        }

        [Obsolete]
        private void OnPauseClick(object sender, EventArgs e)
        {
            if (_player.IsPaused)
            {
                _btnPause.Text = "Пауза";
                _timer.Start();

                ModifyProgressBarColor.SetState(_progressBar, 1);
            }
            else
            {
                _btnPause.Text = "Продолжить";
                _timer.Stop();

                ModifyProgressBarColor.SetState(_progressBar, 2);
            }

            _player.ChangePause();
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            if (!IsDataSaved && DialogResult.No == MessageBox.Show($"Несохранённые данные будут удалены.\nПродолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            Player player = FileHandler.Open();

            if (player == null)
                return;

            DisposePlayer();

            _player = player;

            var deviations = _player.Deviations;

            _numBanditsCount.Value = _player.BanditsCount;
            _cmbDistribution.SelectedIndex = (int)_player.Distribution;
            _cmbTypeProcessingData.SelectedIndex = (int)_player.TypeProcessingData;
            _numDeviationStart.Value = (decimal)deviations[0];
            _numDeviationDelta.Value = (decimal)(deviations.Length > 1 ? deviations[1] - deviations[0] : 0.3d);
            _numDeviationCount.Value = deviations.Length;
            _numExpectation.Value = (decimal)_player.Expectation;
            _numMaxVariance.Value = (decimal)_player.MaxVariance;
            _numNumberSimulations.Value = _player.GamesCount;
            _chkVariancesKnown.Checked = _player.VariancesKnown;

            SetColumn("Arms", _player.CountArms);
            SetColumn("NumberBatches", _player.NumbersBatches);
            SetColumn("BatchSize", _player.BatchSizes);
            SetColumn("Parameter", _player.Parameters);

            ShowResult();
            IsDataSaved = true;
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            FileHandler.Save(_player, out bool isSaved);
            IsDataSaved = isSaved;
        }

        private void OnDistributionChanged(object sender, EventArgs e)
        {
            if ((Distribution)_cmbDistribution.SelectedIndex == Distribution.Gaussian)
            {
                _numExpectation.Minimum = decimal.MinValue;
                _numExpectation.Maximum = decimal.MaxValue;

                _numMaxVariance.Minimum = decimal.MinValue;
                _numMaxVariance.Maximum = decimal.MaxValue;

                _numExpectation.Value = 0m;
                _numMaxVariance.Value = 1m;

                _numNumberBatches.Value = 100m;
                _numBatchSize.Value = 1m;
            }
            else
            {
                _numExpectation.Minimum = 0m;
                _numExpectation.Maximum = 1m;

                _numMaxVariance.Minimum = 0m;
                _numMaxVariance.Maximum = 0.25m;

                _numExpectation.Value = 0.5m;
                _numMaxVariance.Value = 0.25m;

                _numNumberBatches.Value = 50m;
                _numBatchSize.Value = 100m;
            }
        }

        private void OnCountArmsChanged(object sender, EventArgs e) =>
            SetColumn("Arms", (int)_numBanditArms.Value);

        private void OnNumberBatchesChanged(object sender, EventArgs e) =>
            SetColumn("NumberBatches", (int)_numNumberBatches.Value);

        private void OnBatchSizeChanged(object sender, EventArgs e) =>
            SetColumn("BatchSize", (int)_numBatchSize.Value);

        private void OnDeviationChanged(object sender, EventArgs e) =>
            _txtFinalDeviation.Text = $"{_numDeviationStart.Value + _numDeviationDelta.Value * (_numDeviationCount.Value - 1):f1}";

        private void OnParametersChanged(object sender, EventArgs e)
        {
            var start = (double)_numParameterStart.Value;
            var step = (double)numParameterDelta.Value;
            var count = _dataGridView.RowCount;
            var array = CollectionHandler.CreateArray(start, step, count, 2);

            for (int i = 0; i < count; i++)
                _dataGridView.Rows[i].Cells["Parameter"].Value = array[i];
        }

        private void OnBanditsCountChanged(object sender, EventArgs e)
        {
            int delta = (int)_numBanditsCount.Value - _dataGridView.RowCount;

            if (delta > 0)
            {
                int numberRow = _dataGridView.RowCount;
                int banditArms = (int)_numBanditArms.Value;
                int numberBatches = (int)_numNumberBatches.Value;
                int batchSize = (int)_numBatchSize.Value;
                int horizon = numberBatches * batchSize;

                while (delta-- > 0)
                    _dataTable.Rows.Add(++numberRow, banditArms, numberBatches, batchSize, horizon, 0d);
            }
            else
            {
                while (delta++ < 0)
                    _dataGridView.Rows.RemoveAt(_dataGridView.RowCount - 1);
            }
        }

        private void OnChkPlaySoundCheckedChanged(object sender, EventArgs e)
        {
            if (_chkSoundPlay.Checked)
                Sound.Play(Properties.Resources.SoundDone);
        }

        private void OnButtonEnabledChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = btn.Enabled ? Color.White : Color.Gray;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                var lines = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                var rowIndex = _dataGridView.CurrentCell.RowIndex;
                var colIndex = _dataGridView.Columns.IndexOf(_dataGridView.CurrentCell.OwningColumn);

                if (_dataGridView.Columns[colIndex].Name == "NumberRow")
                    return;

                foreach (var line in lines)
                    if (rowIndex < _dataGridView.RowCount && line.Length > 0)
                    {
                        string[] cells = line.Split('\t');

                        for (int i = 0; i < cells.Length; ++i)
                            if (colIndex + i < _dataGridView.ColumnCount)
                                _dataGridView[colIndex + i, rowIndex].Value = cells[i];

                        rowIndex++;
                    }
            }
        }

        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                string nameColumn = _dataGridView.Columns[e.ColumnIndex].Name;

                switch (nameColumn)
                {
                    case "Arms":
                        if (Convert.ToInt32(_dataGridView.Rows[e.RowIndex].Cells["Arms"].Value) < Bandit.MinCountArms)
                        {
                            _dataGridView.Rows[e.RowIndex].Cells["Arms"].Value = Bandit.MinCountArms;
                            throw new ArgumentException($"Число рук J должно быть не меньше {Bandit.MinCountArms}.");
                        }
                        break;

                    case "NumberBatches":
                    case "BatchSize":
                    case "Horizon":
                        if (Convert.ToInt32(_dataGridView.Rows[e.RowIndex].Cells[nameColumn].Value) < 1)
                        {
                            _dataGridView.Rows[e.RowIndex].Cells[nameColumn].Value = 1;
                            throw new ArgumentException($"Значение \"{_dataGridView.Columns[nameColumn].HeaderText}\" должно быть положительным.");
                        }
                        break;

                    case "Parameter":
                        if (Convert.ToDouble(_dataGridView.Rows[e.RowIndex].Cells["Parameter"].Value) < 0)
                        {
                            _dataGridView.Rows[e.RowIndex].Cells["Parameter"].Value = _numParameterStart.Value;
                            throw new ArgumentException("Параметр стратегии \"а\" не может быть отрицательным.");
                        }
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDataError(object sender, DataGridViewDataErrorEventArgs e) =>
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}