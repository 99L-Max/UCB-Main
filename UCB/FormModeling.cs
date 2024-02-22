using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using UCB.Properties;

namespace UCB
{
    partial class FormModeling : Form
    {
        private readonly List<Thread> runningThreads = new List<Thread>();
        private readonly Stopwatch stopWatch = new Stopwatch();
        private readonly Font fontTable = new Font("", 14);

        private Bandit[] bandits;
        private Queue<Thread> threads;
        private DataTable dataTable = null;
        private bool isPaused = false;
        private int countProcessedBandits;
        private int countProcessedPoints;
        private int totalCountPoints;

        public delegate void EventStateChanged();
        public event EventStateChanged BuildChart;
        public event EventStateChanged ClearChart;

        public FormModeling()
        {
            InitializeComponent();

            dataGridView.BackgroundColor = FormControl.BackColorForm;
            cmbDistribution.SelectedIndex = cmbTypeBernStrategy.SelectedIndex = 0;
            btnPause.Enabled = btnCancel.Enabled = btnSave.Enabled = false;

            DeviationChanged(numDeviationExp0, EventArgs.Empty);
        }

        private string Time => $"{stopWatch.Elapsed.Hours:d2}:{stopWatch.Elapsed.Minutes:d2}:{stopWatch.Elapsed.Seconds:d2}";

        public bool IsFinished { private set; get; } = true;

        public bool IsSaved { private set; get; } = true;

        public int IndexBestBandit { private set; get; }

        public double[] Parameters => bandits.Select(b => b.Parameter).ToArray();

        public double[,] Regrets
        {
            get
            {
                double[,] regrets = new double[Bandit.NumberDeviations, bandits.Length];

                for (int row = 0; row < regrets.GetLength(0); row++)
                    for (int col = 0; col < regrets.GetLength(1); col++)
                        regrets[row, col] = bandits[col].GetRegrets(row);

                return regrets;
            }
        }

        private bool ControlsEnabled
        {
            set
            {
                grpTypeBandit.Enabled = value;
                grpGeneralParameters.Enabled = value;
                grpBordersDeviationExp.Enabled = value;
                grpHorizon.Enabled = value;
                grpParameter.Enabled = value;
                grpSimulationSettings.Enabled = value;
                dataGridView.CurrentCell.Selected = value;

                for (int i = 1; i < dataGridView.ColumnCount; i++)
                {
                    try
                    {
                        dataGridView.Columns[i].ReadOnly = !value;
                    }
                    catch (InvalidOperationException) { }
                }
                dataGridView.DefaultCellStyle.SelectionBackColor = value ? SystemColors.Highlight : Color.Transparent;
            }
        }

        private bool ButtonsEnabled
        {
            set
            {
                btnNew.Enabled = value;
                btnOpen.Enabled = value;

                btnPause.Enabled = !value;
                btnCancel.Enabled = !value;
                progressBar.Visible = !value;
            }
        }

        private void UpdateCounterPoints()
        {
            progressBar.Value = ++countProcessedPoints * progressBar.Maximum / totalCountPoints;
        }

        private void StartNextThread()
        {
            countProcessedBandits++;

            for (int i = 0; i < runningThreads.Count; i++)
            {
                if (!runningThreads[i].IsAlive)
                {
                    runningThreads.RemoveAt(i);

                    if (threads.Count > 0)
                    {
                        runningThreads.Add(threads.Dequeue());
                        runningThreads[runningThreads.Count - 1].Start();
                    }

                    return;
                }
            }
        }

        private void CreateTable(Distribution distribution)
        {
            dataTable?.Dispose();
            dataTable = new DataTable("Bandit");
            dataGridView.DataSource = dataTable;

            dataTable.Columns.Add(new DataColumn("NumberRow", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Arms", typeof(int)));

            DataColumn horizonColumn = new DataColumn("Horizon", typeof(int));

            if (distribution == Distribution.Bernuolli)
            {
                dataTable.Columns.Add(new DataColumn("NumberBatches", typeof(int)));
                dataTable.Columns.Add(new DataColumn("BatchSize", typeof(int)));
                dataTable.Columns.Add(new DataColumn("InitialDataSize", typeof(int)));

                dataGridView.Columns["NumberBatches"].HeaderText = "Число пакетов K";
                dataGridView.Columns["BatchSize"].HeaderText = "Размер пакета M";
                dataGridView.Columns["InitialDataSize"].HeaderText = "Нач. даннные M0";

                horizonColumn.Expression = "NumberBatches * BatchSize";
            }

            dataTable.Columns.Add(horizonColumn);
            dataTable.Columns.Add(new DataColumn("Parameter", typeof(double)));

            dataGridView.Columns["NumberRow"].HeaderText = "№";
            dataGridView.Columns["Arms"].HeaderText = "Число рук J";
            dataGridView.Columns["Horizon"].HeaderText = "Горизонт N";
            dataGridView.Columns["Parameter"].HeaderText = "Параметр стратегии a";

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView.Columns[i].HeaderCell.Style.Font = fontTable;
                dataGridView.Columns[i].DefaultCellStyle.Font = fontTable;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].HeaderCell.Style.ForeColor = Color.White;

                if (i == 0)
                    dataGridView.Columns[i].Width = 50;
                else
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView.Columns["NumberRow"].ReadOnly = true;
            dataGridView.Columns["Parameter"].DefaultCellStyle.Format = "f2";
        }

        private void ShowResult(string time)
        {
            double minMaxRegrets = bandits.Select(b => b.MaxRegrets).Min();
            IndexBestBandit = bandits.Select((item, ind) => new { Item = item, Index = ind }).FirstOrDefault(x => x.Item.MaxRegrets == minMaxRegrets).Index;

            BuildChart.Invoke();

            lblDialog.Text =
                $"a = {bandits[IndexBestBandit].Parameter:f2}{Environment.NewLine}" +
                $"l_max = {bandits[IndexBestBandit].MaxRegrets:f2}{Environment.NewLine}" +
                $"d_max = {bandits[IndexBestBandit].MaxDeviation:f1}{Environment.NewLine}" +
                $"Время {time}";
        }

        private void OnEstimationDispersionClick(object sender, EventArgs e)
        {
            new FormEstimationDispersion(lblStateDispersion).Show();
        }

        private void ClearBandits()
        {
            foreach (var b in bandits)
            {
                b.PointProcessed -= UpdateCounterPoints;
                b.SimulationFinished -= StartNextThread;
            }
        }

        private void OnNewClick(object sender, EventArgs e)
        {
            if (!IsSaved && MessageBox.Show($"Несохранённые данные будут удалены.{Environment.NewLine}Продолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            ClearBandits();
            ClearChart.Invoke();
            IsSaved = ControlsEnabled = btnStart.Enabled = true;
            btnSave.Enabled = false;
            lblDialog.Text = string.Empty;
        }

        private void OnStartClick(object sender, EventArgs e)
        {
            ControlsEnabled = IsFinished = IsSaved = false;
            ButtonsEnabled = btnStart.Enabled = false;

            Bandit.Distribution = (Distribution)cmbDistribution.SelectedIndex;

            if (Bandit.Distribution == Distribution.Bernuolli)
                BatchProcessing.TypeProcessingData = (TypeProcessingData)cmbTypeBernStrategy.SelectedIndex;

            Bandit.Expectation = (double)numMathExp.Value;
            Bandit.MaxDispersion = (double)numMaxDispersion.Value;
            Bandit.NumberSimulations = (int)numNumberSimulations.Value;
            Bandit.SetDeviations((double)numDeviationExp0.Value, (double)numDeviationExpDelta.Value, (int)numDeviationExpCount.Value);

            try
            {
                bandits = new Bandit[dataGridView.Rows.Count];

                //Бандит с распределением Гаусса
                if (Bandit.Distribution == Distribution.Gauss)
                {
                    for (int i = 0; i < bandits.Length; i++)
                    {
                        bandits[i] = new BanditGauss(
                            Convert.ToInt32(dataGridView.Rows[i].Cells["Arms"].Value),
                            Convert.ToInt32(dataGridView.Rows[i].Cells["Horizon"].Value),
                            Math.Round(Convert.ToDouble(dataGridView.Rows[i].Cells["Parameter"].Value), 2));
                    }
                }
                //Бандит с распределением Бернулли
                else
                {
                    for (int i = 0; i < bandits.Length; i++)
                    {
                        bandits[i] = new BatchProcessing(
                            Convert.ToInt32(dataGridView.Rows[i].Cells["Arms"].Value),
                            Convert.ToInt32(dataGridView.Rows[i].Cells["NumberBatches"].Value),
                            Convert.ToInt32(dataGridView.Rows[i].Cells["BatchSize"].Value),
                            Convert.ToInt32(dataGridView.Rows[i].Cells["InitialDataSize"].Value),
                            Math.Round(Convert.ToDouble(dataGridView.Rows[i].Cells["Parameter"].Value), 2));
                    }
                }

                foreach (var b in bandits)
                {
                    b.PointProcessed += UpdateCounterPoints;
                    b.SimulationFinished += StartNextThread;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

                bandits = null;
                ControlsEnabled = IsFinished = IsSaved = true;
                ButtonsEnabled = btnStart.Enabled = true;

                return;
            }

            threads = new Queue<Thread>(bandits.Select(b => new Thread(b.RunSimulation)));

            countProcessedBandits = countProcessedPoints = 0;
            totalCountPoints = Bandit.NumberDeviations * bandits.Length;

            int maxCountThreads = Math.Min((int)numCountThreads.Value, threads.Count);

            while (maxCountThreads-- > 0)
            {
                runningThreads.Add(threads.Dequeue());
                runningThreads[runningThreads.Count - 1].Start();
            }

            stopWatch.Restart();

            OnTimerTick(timer, EventArgs.Empty);

            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (countProcessedBandits < bandits.Length)
            {
                lblDialog.Text =
                    $"Обработано {countProcessedBandits} / {bandits.Length}{Environment.NewLine}" +
                    $"Выполнено {progressBar.Value}%{Environment.NewLine}" +
                    $"Время {Time}";
            }
            else
            {
                Finish(true);
            }
        }

        [Obsolete]
        private void OnCancelClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить вычисления?", "Отмена операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (isPaused)
                OnPauseClick(btnPause, EventArgs.Empty);

            runningThreads.ForEach(t => t.Abort());

            Finish(false);
        }

        private void Finish(bool isCorrect)
        {
            timer.Stop();
            stopWatch.Stop();

            threads.Clear();
            runningThreads.Clear();

            progressBar.Value = progressBar.Minimum;

            ButtonsEnabled = IsFinished = true;

            btnSave.Enabled = isCorrect;
            btnStart.Enabled = ControlsEnabled = IsSaved = !isCorrect;

            if (isCorrect)
            {
                ShowResult(Time);
                OnCheckBoxCheckedChanged(chkSoundPlay, EventArgs.Empty);
            }
            else
            {
                ClearBandits();
                lblDialog.Text = string.Empty;
            }
        }

        [Obsolete]
        private void OnPauseClick(object sender, EventArgs e)
        {
            if (isPaused)
            {
                runningThreads.ForEach(t => { if (t.IsAlive) t.Resume(); });

                btnPause.Text = "Пауза";
                stopWatch.Start();
                timer.Start();

                ModifyProgressBarColor.SetState(progressBar, 1);
            }
            else
            {
                runningThreads.ForEach(t => { if (t.IsAlive) t.Suspend(); });

                btnPause.Text = "Продолжить";
                stopWatch.Stop();
                timer.Stop();

                ModifyProgressBarColor.SetState(progressBar, 2);
            }

            isPaused = !isPaused;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            if (!IsSaved && MessageBox.Show($"Несохранённые данные будут удалены.{Environment.NewLine}Продолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файлы Json|*.json";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    JObject jObj = JObject.Parse(File.ReadAllText(openFileDialog.FileName));

                    Bandit.Distribution = (Distribution)jObj["Distribution"].Value<int>();
                    BatchProcessing.TypeProcessingData = (TypeProcessingData)jObj["TypeProcessingData"].Value<int>();
                    Bandit.Expectation = jObj["Expectation"].Value<double>();
                    Bandit.MaxDispersion = jObj["MaxDispersion"].Value<double>();
                    BatchProcessing.EstimationDispersion = (EstimationDispersion)jObj["EstimationDispersion"].Value<int>();

                    Bandit.SetDeviations(
                        jObj["InitialDeviation"].Value<double>(),
                        jObj["StepDevition"].Value<double>(),
                        jObj["NumberDeviations"].Value<int>());

                    Bandit.NumberSimulations = jObj["NumberSimulations"].Value<int>();

                    JArray jArr = JArray.Parse(JToken.FromObject(jObj.SelectToken("banditsData")).ToString());

                    if (Bandit.Distribution == Distribution.Gauss)
                    {
                        bandits = jArr.Select(b => new BanditGauss(
                            b["CountArms"].Value<int>(),
                            b["Horizon"].Value<int>(),
                            b["Parameter"].Value<double>(),
                            b["Regrets"].ToObject<double[]>())).ToArray();
                    }
                    else
                    {
                        bandits = jArr.Select(b => new BatchProcessing(
                            b["CountArms"].Value<int>(),
                            b["NumberBatches"].Value<int>(),
                            b["BatchSize"].Value<int>(),
                            b["InitialDataSize"].Value<int>(),
                            b["Parameter"].Value<double>(),
                            b["Regrets"].ToObject<double[]>())).ToArray();
                    }

                    cmbDistribution.SelectedIndexChanged -= DistributionChanged;
                    numBanditsCount.ValueChanged -= BanditsCountChanged;

                    cmbDistribution.SelectedIndex = (int)Bandit.Distribution;
                    cmbTypeBernStrategy.SelectedIndex = (int)BatchProcessing.TypeProcessingData;
                    numBanditsCount.Value = bandits.Length;
                    numMathExp.Value = (decimal)Bandit.Expectation;
                    numMaxDispersion.Value = (decimal)Bandit.MaxDispersion;
                    numNumberSimulations.Value = Bandit.NumberSimulations;
                    numDeviationExp0.Value = (decimal)jObj["InitialDeviation"].Value<double>();
                    numDeviationExpDelta.Value = (decimal)jObj["StepDevition"].Value<double>();
                    numDeviationExpCount.Value = (decimal)jObj["NumberDeviations"].Value<double>();
                    lblStateDispersion.Text = BatchProcessing.EstimationDispersion == EstimationDispersion.Never ? "Дисперсии известны" : "Дисперсии неизвестны";

                    cmbDistribution.SelectedIndexChanged += DistributionChanged;
                    numBanditsCount.ValueChanged += BanditsCountChanged;

                    CreateTable(Bandit.Distribution);

                    int num = 0;

                    if (Bandit.Distribution == Distribution.Gauss)
                        foreach (var b in bandits)
                            dataTable.Rows.Add(++num, b.CountArms, b.Horizon, b.Parameter);
                    else
                        foreach (var b in bandits.Select(b => b as BatchProcessing).ToList())
                            dataTable.Rows.Add(++num, b.CountArms, b.NumberBatches, b.BatchSize, b.InitialDataSize, b.Horizon, b.Parameter);

                    ControlsEnabled = false;
                    IsSaved = btnSave.Enabled = true;

                    ShowResult(jObj["Time"].Value<string>());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Файлы Json|*.json";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    IEnumerable banditsData;

                    if (Bandit.Distribution == Distribution.Gauss)
                    {
                        banditsData = bandits.Select(b => new
                        {
                            b.CountArms,
                            b.Horizon,
                            b.Parameter,
                            b.Regrets
                        });
                    }
                    else
                    {
                        banditsData = bandits.Select(b => b as BatchProcessing).Select(b => new
                        {
                            b.CountArms,
                            b.NumberBatches,
                            b.BatchSize,
                            b.InitialDataSize,
                            b.Parameter,
                            b.Regrets
                        });
                    }

                    string data = JsonConvert.SerializeObject(new
                    {
                        Bandit.Distribution,
                        BatchProcessing.TypeProcessingData,
                        Bandit.Expectation,
                        Bandit.MaxDispersion,
                        BatchProcessing.EstimationDispersion,
                        InitialDeviation = Bandit.GetDeviation(0),
                        Bandit.StepDevition,
                        Bandit.NumberDeviations,
                        Bandit.NumberSimulations,
                        Time,
                        banditsData
                    });

                    File.WriteAllText(saveFileDialog.FileName, data);
                    IsSaved = true;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DistributionChanged(object sender, EventArgs e)
        {
            Distribution dist = (Distribution)cmbDistribution.SelectedIndex;
            bool isGauss = dist == Distribution.Gauss;

            btnEstimationDispersion.Enabled = !isGauss;
            cmbTypeBernStrategy.Enabled = !isGauss;
            numNumberBatches.Enabled = !isGauss;
            numBatchSize.Enabled = !isGauss;
            numInitialDataSize.Enabled = !isGauss;
            numHorizon.Enabled = isGauss;

            CreateTable(dist);
            BanditsCountChanged(numBanditsCount, EventArgs.Empty);
            ChangeParameters(numParameter0, EventArgs.Empty);

            if (dist == Distribution.Gauss)
            {
                BatchProcessing.EstimationDispersion = EstimationDispersion.Never;

                lblStateDispersion.Text = "Дисперсии известны";

                numMathExp.Minimum = decimal.MinValue;
                numMathExp.Maximum = decimal.MaxValue;
                numMaxDispersion.Maximum = decimal.MaxValue;
                numMathExp.Value = 0m;
                numMaxDispersion.Value = 1m;

                labelMathExp.Text = "Мат. ожидание m:";
            }
            else
            {
                numMathExp.Minimum = 0m;
                numMathExp.Maximum = 1m;
                numMaxDispersion.Maximum = 0.25m;
                numMathExp.Value = 0.5m;
                numMaxDispersion.Value = 0.25m;

                labelMathExp.Text = "Мат. ожидание p:";
            }
        }

        private void BanditArmsChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells["Arms"].Value = (int)numBanditArms.Value;
        }

        private void HorizonChanged(object sender, EventArgs e)
        {
            if (cmbDistribution.SelectedIndex == 0)
                foreach (DataGridViewRow row in dataGridView.Rows)
                    row.Cells["Horizon"].Value = (int)numHorizon.Value;
        }

        private void InitialDataSizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells["InitialDataSize"].Value = (int)numInitialDataSize.Value;
        }

        private void NumberBatchesChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells["NumberBatches"].Value = (int)numNumberBatches.Value;
        }

        private void BatchSizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells["BatchSize"].Value = (int)numBatchSize.Value;
        }

        private void DeviationChanged(object sender, EventArgs e)
        {
            txtFinalDeviation.Text = $"{(numDeviationExp0.Value + numDeviationExpDelta.Value * (numDeviationExpCount.Value - 1)):f1}";
        }

        private void ChangeParameters(object sender, EventArgs e)
        {
            double a = (double)numParameter0.Value;
            double da = (double)numParameterDelta.Value;

            dataGridView.Rows[0].Cells["Parameter"].Value = a;

            for (int i = 1; i < dataGridView.RowCount; i++)
            {
                a += da;
                dataGridView.Rows[i].Cells["Parameter"].Value = a;
            }
        }

        private void BanditsCountChanged(object sender, EventArgs e)
        {
            int delta = (int)numBanditsCount.Value - dataGridView.RowCount;

            if (delta > 0)
            {
                int numberRow = dataGridView.RowCount;
                int banditArms = (int)numBanditArms.Value;

                if (cmbDistribution.SelectedIndex == 0)
                {
                    int horizon = (int)numHorizon.Value;
                    while (delta-- > 0)
                        dataTable.Rows.Add(++numberRow, banditArms, horizon, 0);
                }
                else
                {
                    int numberBatches = (int)numNumberBatches.Value;
                    int batchSize = (int)numBatchSize.Value;
                    int initialDataSize = (int)numInitialDataSize.Value;
                    int horizon = numberBatches * batchSize;

                    while (delta-- > 0)
                        dataTable.Rows.Add(++numberRow, banditArms, numberBatches, batchSize, initialDataSize, horizon, 0);
                }
            }
            else
            {
                while (delta++ < 0)
                    dataGridView.Rows.RemoveAt(dataGridView.RowCount - 1);
            }
        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (chkSoundPlay.Checked)
                using (MemoryStream fileOut = new MemoryStream(Resources.SoundDone))
                using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                    new SoundPlayer(gz).Play();
        }

        private void OnButtonEnabledChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.Enabled ? Color.White : Color.Gray;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string[] lines = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int rowIndex = dataGridView.CurrentCell.RowIndex;
                int colIndex = dataGridView.Columns.IndexOf(dataGridView.CurrentCell.OwningColumn);

                if (dataGridView.Columns[colIndex].Name == "NumberRow")
                    return;

                foreach (var line in lines)
                {
                    if (rowIndex < dataGridView.RowCount && line.Length > 0)
                    {
                        string[] cells = line.Split('\t');

                        for (int i = 0; i < cells.Length; ++i)
                            if (colIndex + i < dataGridView.ColumnCount)
                                dataGridView[colIndex + i, rowIndex].Value = cells[i];

                        rowIndex++;
                    }
                }
            }
        }

        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                string nameCollumn = dataGridView.Columns[e.ColumnIndex].Name;

                switch (nameCollumn)
                {
                    case "Arms":
                        if (Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Arms"].Value) < Bandit.MinBanditArms)
                        {
                            dataGridView.Rows[e.RowIndex].Cells["Arms"].Value = Bandit.MinBanditArms;
                            throw new ArgumentException($"Число рук J должно быть не меньше {Bandit.MinBanditArms}.");
                        }
                        break;

                    case "NumberBatches":
                    case "BatchSize":
                    case "InitialDataSize":
                    case "Horizon":
                        if (Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[nameCollumn].Value) < 1)
                        {
                            dataGridView.Rows[e.RowIndex].Cells[nameCollumn].Value = 1;
                            throw new ArgumentException($"Значение \"{dataGridView.Columns[nameCollumn].HeaderText}\" должно быть положительным.");
                        }
                        break;

                    case "Parameter":
                        if (Convert.ToDouble(dataGridView.Rows[e.RowIndex].Cells["Parameter"].Value) < 0)
                        {
                            dataGridView.Rows[e.RowIndex].Cells["Parameter"].Value = numParameter0.Value;
                            throw new ArgumentException("Параметр стратегии \"а\" не может быть отрицательным.");
                        }
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}