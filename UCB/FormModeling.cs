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
            comboBoxTypeBandit.SelectedIndex = comboBoxTypeBernStrategy.SelectedIndex = 0;
            buttonPause.Enabled = buttonCancel.Enabled = buttonSave.Enabled = false;

            NumericUpDownDeviationExp_ValueChanged(null, null);

            CustomPanel.RoundBounds(panelInformation, 35);
        }

        public bool IsFinished { private set; get; } = true;

        public bool IsSaved { private set; get; } = true;

        public int IndexBestBandit { private set; get; }

        public double[] Parameters => bandits.Select(b => b.Parameter).ToArray();

        public double[,] Regrets
        {
            get
            {
                double[,] regrets = new double[bandits.Length, Bandit.NumberDeviations];

                for (int row = 0; row < regrets.GetLength(0); row++)
                    for (int col = 0; col < regrets.GetLength(1); col++)
                        regrets[row, col] = bandits[row].GetRegrets(col);

                return regrets;
            }
        }

        private bool ControlsEnabled
        {
            set
            {
                groupBoxTypeBandit.Enabled = value;
                groupBoxGeneralParameters.Enabled = value;
                groupBoxBordersDeviationExp.Enabled = value;
                groupBoxHorizon.Enabled = value;
                groupBoxParameter.Enabled = value;
                groupBoxSimulationSettings.Enabled = value;
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
                buttonNew.Enabled = value;
                buttonOpen.Enabled = value;

                buttonPause.Enabled = !value;
                buttonCancel.Enabled = !value;
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

        private void CreateTable(TypeBandit type)
        {
            dataTable = new DataTable("Bandit");
            dataGridView.DataSource = dataTable;

            dataTable.Columns.Add(new DataColumn("NumberRow", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Arms", typeof(int)));

            DataColumn horizonColumn = new DataColumn("Horizon", typeof(int));

            if (type == TypeBandit.Bernuolli)
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

        private void ShowResult()
        {
            double minMaxRegrets = bandits[0].MaxRegrets;
            IndexBestBandit = 0;

            for (int i = 1; i < bandits.Length; i++)
                if (minMaxRegrets > bandits[i].MaxRegrets)
                {
                    minMaxRegrets = bandits[i].MaxRegrets;
                    IndexBestBandit = i;
                }

            BuildChart.Invoke();

            labelInfo.Text =
                $"a = {bandits[IndexBestBandit].Parameter:f2}{Environment.NewLine}" +
                $"l_max = {bandits[IndexBestBandit].MaxRegrets:f2}{Environment.NewLine}" +
                $"d_max = {bandits[IndexBestBandit].MaxDeviation:f1}";
        }

        private void ButtonSettingsEstimationDispersion_Click(object sender, EventArgs e)
        {
            new FormEstimationDispersion(labelStateDispersion).Show();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            if (!IsSaved && MessageBox.Show($"Несохранённые данные будут удалены.{Environment.NewLine}Продолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            bandits = null;
            ClearChart.Invoke();
            IsSaved = ControlsEnabled = buttonStart.Enabled = true;
            buttonSave.Enabled = false;
            labelInfo.Text = string.Empty;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ControlsEnabled = IsFinished = IsSaved = false;
            ButtonsEnabled = buttonStart.Enabled = false;

            Bandit.TypeBandit = (TypeBandit)comboBoxTypeBandit.SelectedIndex;

            if (Bandit.TypeBandit == TypeBandit.Bernuolli)
                BatchProcessing.TypeProcessingData = (TypeProcessingData)comboBoxTypeBernStrategy.SelectedIndex;

            Bandit.Expectation = (double)numericUpDownMathExp.Value;
            Bandit.MaxDispersion = (double)numericUpDownMaxDispersion.Value;
            Bandit.NumberSimulations = (int)numericUpDownNumberSimulations.Value;
            Bandit.SetDeviations((double)numericUpDownDeviationExp0.Value, (double)numericUpDownDeviationExpDelta.Value, (int)numericUpDownDeviationExpCount.Value);

            try
            {
                bandits = new Bandit[dataGridView.Rows.Count];

                //Бандит с распределением Гаусса
                if (Bandit.TypeBandit == TypeBandit.Gauss)
                {
                    for (int i = 0; i < bandits.Length; i++)
                    {
                        bandits[i] = new BanditGauss(
                            Convert.ToInt32(dataGridView.Rows[i].Cells["Arms"].Value),
                            Convert.ToInt32(dataGridView.Rows[i].Cells["Horizon"].Value),
                            Math.Round(Convert.ToDouble(dataGridView.Rows[i].Cells["Parameter"].Value), 2)
                            );
                    }
                }
                //Бандит с распределением Бернулли
                else
                {
                    int[] batchSize = new int[bandits.Length];
                    int[] initialDataSize = new int[bandits.Length];

                    for (int i = 0; i < bandits.Length; i++)
                    {
                        batchSize[i] = Convert.ToInt32(dataGridView.Rows[i].Cells["BatchSize"].Value);
                        initialDataSize[i] = Convert.ToInt32(dataGridView.Rows[i].Cells["InitialDataSize"].Value);

                        bandits[i] = new BatchProcessing(
                            Convert.ToInt32(dataGridView.Rows[i].Cells["Arms"].Value),
                            Convert.ToInt32(dataGridView.Rows[i].Cells["NumberBatches"].Value),
                            batchSize[i],
                            initialDataSize[i],
                            Math.Round(Convert.ToDouble(dataGridView.Rows[i].Cells["Parameter"].Value), 2)
                            );
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
                ButtonsEnabled = buttonStart.Enabled = true;

                return;
            }

            threads = new Queue<Thread>(bandits.Select(b => new Thread(b.RunSimulation)));

            countProcessedBandits = countProcessedPoints = 0;
            totalCountPoints = Bandit.NumberDeviations * bandits.Length;

            int maxCountThreads = Math.Min((int)numericUpDownCountThreads.Value, threads.Count);

            while (maxCountThreads-- > 0)
            {
                runningThreads.Add(threads.Dequeue());
                runningThreads[runningThreads.Count - 1].Start();
            }

            stopWatch.Restart();

            Timer_Tick(null, null);

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countProcessedBandits < bandits.Length)
            {
                labelInfo.Text =
                    $"Обработано {countProcessedBandits} / {bandits.Length}{Environment.NewLine}" +
                    $"Выполнено {progressBar.Value}%{Environment.NewLine}" +
                    $"Время {stopWatch.Elapsed.Hours:d2}:{stopWatch.Elapsed.Minutes:d2}:{stopWatch.Elapsed.Seconds:d2}";
            }
            else
            {
                Finish(true);
            }
        }

        [Obsolete]
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить вычисления?", "Отмена операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (isPaused)
                ButtonPause_Click(null, null);

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

            buttonSave.Enabled = isCorrect;
            buttonStart.Enabled = ControlsEnabled = IsSaved = !isCorrect;

            if (isCorrect)
            {
                ShowResult();
                CheckBoxSoundPlay_CheckedChanged(null, null);
            }
            else
            {
                bandits = null;
                labelInfo.Text = string.Empty;
            }
        }

        [Obsolete]
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                runningThreads.ForEach(t => { if (t.IsAlive) t.Resume(); });

                buttonPause.Text = "Пауза";
                stopWatch.Start();
                timer.Start();

                ModifyProgressBarColor.SetState(progressBar, 1);
            }
            else
            {
                runningThreads.ForEach(t => { if (t.IsAlive) t.Suspend(); });

                buttonPause.Text = "Продолжить";
                stopWatch.Stop();
                timer.Stop();

                ModifyProgressBarColor.SetState(progressBar, 2);
            }

            isPaused = !isPaused;
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (!IsSaved && MessageBox.Show($"Несохранённые данные будут удалены.{Environment.NewLine}Продолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы Json|*.json"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string jsonStr = File.ReadAllText(openFileDialog.FileName);
                JObject jObj = JObject.Parse(jsonStr);

                Bandit.TypeBandit = (TypeBandit)jObj["TypeBandit"].Value<int>();
                BatchProcessing.TypeProcessingData = (TypeProcessingData)jObj["TypeProcessingData"].Value<int>();
                Bandit.Expectation = jObj["Expectation"].Value<double>();
                Bandit.MaxDispersion = jObj["MaxDispersion"].Value<double>();
                BatchProcessing.EstimationDispersion = (EstimationDispersion)jObj["EstimationDispersion"].Value<int>();

                Bandit.SetDeviations(
                    jObj["InitialDeviation"].Value<double>(),
                    jObj["StepDevition"].Value<double>(),
                    jObj["NumberDeviations"].Value<int>()
                );

                Bandit.NumberSimulations = jObj["NumberSimulations"].Value<int>();

                JArray jArr = JArray.Parse(JToken.FromObject(jObj.SelectToken("banditsData")).ToString());
                List<Bandit> banditsList = new List<Bandit>();

                if (Bandit.TypeBandit == TypeBandit.Gauss)
                {
                    foreach (JObject jBandit in jArr)
                    {
                        banditsList.Add(new BanditGauss(
                            jBandit["Arms"].Value<int>(),
                            jBandit["Horizon"].Value<int>(),
                            jBandit["Parameter"].Value<double>(),
                            jBandit["Regrets"].ToObject<double[]>()
                            ));
                    }
                }
                else
                {
                    foreach (JObject jBandit in jArr)
                    {
                        banditsList.Add(new BatchProcessing(
                            jBandit["Arms"].Value<int>(),
                            jBandit["NumberBatches"].Value<int>(),
                            jBandit["BatchSize"].Value<int>(),
                            jBandit["InitialDataSize"].Value<int>(),
                            jBandit["Parameter"].Value<double>(),
                            jBandit["Regrets"].ToObject<double[]>()
                            ));
                    }
                }

                bandits = banditsList.ToArray();

                CreateTable(Bandit.TypeBandit);

                if (Bandit.TypeBandit == TypeBandit.Gauss)
                {
                    for (int i = 0; i < bandits.Length; i++)
                        dataTable.Rows.Add(i + 1, bandits[i].CountArms, bandits[i].Horizon, bandits[i].Parameter);
                }
                else
                {
                    BatchProcessing batchProcessing;

                    for (int i = 0; i < bandits.Length; i++)
                    {
                        batchProcessing = bandits[i] as BatchProcessing;
                        dataTable.Rows.Add(i + 1, batchProcessing.CountArms, batchProcessing.NumberBatches, batchProcessing.BatchSize, batchProcessing.InitialDataSize, batchProcessing.Horizon, batchProcessing.Parameter);
                    }
                }

                comboBoxTypeBandit.SelectedIndex = (int)Bandit.TypeBandit;
                comboBoxTypeBernStrategy.SelectedIndex = (int)BatchProcessing.TypeProcessingData;
                numericUpDownMathExp.Value = (decimal)Bandit.Expectation;
                numericUpDownMaxDispersion.Value = (decimal)Bandit.MaxDispersion;
                numericUpDownNumberSimulations.Value = Bandit.NumberSimulations;
                numericUpDownDeviationExp0.Value = (decimal)jObj["InitialDeviation"].Value<double>();
                numericUpDownDeviationExpDelta.Value = (decimal)jObj["StepDevition"].Value<double>();
                numericUpDownDeviationExpCount.Value = (decimal)jObj["NumberDeviations"].Value<double>();
                labelStateDispersion.Text = BatchProcessing.EstimationDispersion == EstimationDispersion.Never ? "Дисперсии известны" : "Дисперсии неизвестны";

                ControlsEnabled = false;
                IsSaved = buttonSave.Enabled = true;

                ShowResult();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы Json|*.json"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                IEnumerable banditsData;

                if (Bandit.TypeBandit == TypeBandit.Gauss)
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
                    banditsData = bandits.Select(b => new
                    {
                        b.CountArms,
                        (b as BatchProcessing).NumberBatches,
                        (b as BatchProcessing).BatchSize,
                        (b as BatchProcessing).InitialDataSize,
                        b.Parameter,
                        b.Regrets
                    });
                }

                string data = JsonConvert.SerializeObject(new
                {
                    Bandit.TypeBandit,
                    BatchProcessing.TypeProcessingData,
                    Bandit.Expectation,
                    Bandit.MaxDispersion,
                    BatchProcessing.EstimationDispersion,
                    InitialDeviation = Bandit.GetDeviation(0),
                    Bandit.StepDevition,
                    Bandit.NumberDeviations,
                    Bandit.NumberSimulations,
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

        private void ComboBoxTagBandit_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBandit type = (TypeBandit)comboBoxTypeBandit.SelectedIndex;
            bool isGauss = type == TypeBandit.Gauss;

            buttonSettingsEstimationDispersion.Enabled = !isGauss;
            comboBoxTypeBernStrategy.Enabled = !isGauss;
            numericUpDownNumberBatches.Enabled = !isGauss;
            numericUpDownBatchSize.Enabled = !isGauss;
            numericUpDownInitialDataSize.Enabled = !isGauss;
            numericUpDownHorizon.Enabled = isGauss;

            CreateTable(type);
            NumericUpDownBanditsCount_ValueChanged(null, null);
            NumericUpDownParameter_ValueChanged(null, null);

            if (type == TypeBandit.Gauss)
            {
                BatchProcessing.EstimationDispersion = EstimationDispersion.Never;

                labelStateDispersion.Text = "Дисперсии известны";

                numericUpDownMathExp.Minimum = decimal.MinValue;
                numericUpDownMathExp.Maximum = decimal.MaxValue;
                numericUpDownMaxDispersion.Maximum = decimal.MaxValue;
                numericUpDownMathExp.Value = 0m;
                numericUpDownMaxDispersion.Value = 1m;

                labelMathExp.Text = "Мат. ожидание m:";
            }
            else
            {
                numericUpDownMathExp.Minimum = 0m;
                numericUpDownMathExp.Maximum = 1m;
                numericUpDownMaxDispersion.Maximum = 0.25m;
                numericUpDownMathExp.Value = 0.5m;
                numericUpDownMaxDispersion.Value = 0.25m;

                labelMathExp.Text = "Мат. ожидание p:";
            }
        }

        private void NumericUpDownBanditArms_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["Arms"].Value = (int)numericUpDownBanditArms.Value;
        }

        private void NumericUpDownHorizon_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeBandit.SelectedIndex == 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows[i].Cells["Horizon"].Value = (int)numericUpDownHorizon.Value;
        }

        private void NumericUpDownInitialDataSize_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["InitialDataSize"].Value = (int)numericUpDownInitialDataSize.Value;
        }

        private void NumericUpDownNumberBatches_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["NumberBatches"].Value = (int)numericUpDownNumberBatches.Value;
        }

        private void NumericUpDownBatchSize_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["BatchSize"].Value = (int)numericUpDownBatchSize.Value;
        }

        private void NumericUpDownDeviationExp_ValueChanged(object sender, EventArgs e)
        {
            textBoxFinalDeviation.Text = $"{(numericUpDownDeviationExp0.Value + numericUpDownDeviationExpDelta.Value * (numericUpDownDeviationExpCount.Value - 1)):f1}";
        }

        private void NumericUpDownParameter_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)numericUpDownParameter0.Value;
            double da = (double)numericUpDownParameterDelta.Value;

            dataGridView.Rows[0].Cells["Parameter"].Value = a;

            for (int i = 1; i < dataGridView.RowCount; i++)
            {
                a += da;
                dataGridView.Rows[i].Cells["Parameter"].Value = a;
            }
        }

        private void NumericUpDownBanditsCount_ValueChanged(object sender, EventArgs e)
        {
            int delta = (int)numericUpDownBanditsCount.Value - dataGridView.RowCount;

            if (delta > 0)
            {
                int numberRow = dataGridView.RowCount;
                int banditArms = (int)numericUpDownBanditArms.Value;

                if (comboBoxTypeBandit.SelectedIndex == 0)
                {
                    int horizon = (int)numericUpDownHorizon.Value;
                    while (delta-- > 0)
                        dataTable.Rows.Add(++numberRow, banditArms, horizon, 0);
                }
                else
                {
                    int numberBatches = (int)numericUpDownNumberBatches.Value;
                    int batchSize = (int)numericUpDownBatchSize.Value;
                    int initialDataSize = (int)numericUpDownInitialDataSize.Value;
                    int horizon = numberBatches * batchSize;

                    while (delta-- > 0)
                        dataTable.Rows.Add(++numberRow, banditArms, numberBatches, batchSize, initialDataSize, horizon, 0);
                }
            }
            else
            {
                int indexRow = dataGridView.RowCount - 1;

                while (delta++ < 0)
                    dataGridView.Rows.RemoveAt(indexRow--);
            }
        }

        private void CheckBoxSoundPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSoundPlay.Checked)
                using (MemoryStream fileOut = new MemoryStream(Resources.SoundDone))
                using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                    new SoundPlayer(gz).Play();
        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = button.Enabled ? Color.White : Color.Gray;
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
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

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                            dataGridView.Rows[e.RowIndex].Cells["Parameter"].Value = numericUpDownParameter0.Value;
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

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}