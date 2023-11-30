using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCB
{
    partial class FormChart : Form
    {
        private readonly double[] parameters;
        private readonly double[,] regrets;
        private readonly int indexBestBandit;

        private static readonly ReadOnlyCollection<Color> colorsDefault;

        static FormChart()
        {
            List<Color> list = new List<Color>()
            {
                Color.Red, Color.Green, Color.Blue,
                Color.Orange, Color.Purple, Color.Black,
                Color.Maroon, Color.DarkGreen, Color.Cyan,
                Color.Gold, Color.Indigo, Color.DimGray
            };

            colorsDefault = new ReadOnlyCollection<Color>(list);
        }

        public FormChart()
        {
            InitializeComponent();

            groupBoxAxis.Enabled = false;
            groupBoxNumerics.Enabled = false;
            groupBoxOther.Enabled = false;
            buttonLineSettings.Enabled = false;
            buttonSaveData.Enabled = false;
            buttonSaveGraph.Enabled = false;

            buttonLineSettings.BackColor = Color.Gray;
            buttonSaveData.BackColor = Color.Gray;
            buttonSaveGraph.BackColor = Color.Gray;
        }

        public FormChart(double[,] regrets, double[] parameters, int indexBestBandit)
        {
            InitializeComponent();

            if (indexBestBandit < 0 || indexBestBandit >= regrets.GetLength(0))
                throw new IndexOutOfRangeException("Недопустимый индекс графика.");

            if (regrets.GetLength(1) != Bandit.NumberDeviations)
                throw new ArgumentException("Неверный размер данных.");

            this.regrets = regrets;
            this.indexBestBandit = indexBestBandit;
            this.parameters = parameters;

            radioButtonOneGraph.Checked = true;
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            comboBoxSize.SelectedIndex = 0;
            comboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;

            NumericUpDownDecimalPlaces_ValueChanged(null, null);
        }

        private void AddSeries(int indexObject, Color color)
        {
            Series series = new Series
            {
                BorderWidth = 3,//По умолчанию
                ChartType = SeriesChartType.Spline,//По умолчанию
                Color = color
            };

            chart.Series.Add(series);

            int indexSeries = chart.Series.Count - 1;

            for (int i = 0; i < Bandit.NumberDeviations; i++)
                chart.Series[indexSeries].Points.AddXY(Bandit.GetDeviation(i), regrets[indexObject, i]);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            double yMax = double.MinValue;
            chart.Series.Clear();

            if (radioButtonOneGraph.Checked)
            {
                AddSeries(indexBestBandit, Color.Blue);//По умолчанию

                for (int col = 0; col < regrets.GetLength(1); col++)
                    if (yMax < regrets[indexBestBandit, col])
                        yMax = regrets[indexBestBandit, col];
            }
            else
            {
                for (int i = 0; i < regrets.GetLength(0); i++)
                {
                    AddSeries(i, colorsDefault[i % colorsDefault.Count]);

                    foreach (var reg in regrets)
                        if (yMax < reg)
                            yMax = reg;
                }
            }

            yMax = Math.Ceiling(yMax);

            numericUpDownXMin.Value = (decimal)Bandit.GetDeviation(0);
            numericUpDownXMax.Value = (decimal)Bandit.GetDeviation(Bandit.NumberDeviations - 1);
            numericUpDownYMin.Value = 0m;
            numericUpDownYMax.Value = (decimal)(yMax == 0d ? 1d : 2d);

            //По умолчанию делим каждую ось на 5 отрезков
            numericUpDownXInterval.Value = (numericUpDownXMax.Value - numericUpDownXMin.Value) / 5m;
            numericUpDownYInterval.Value = (numericUpDownYMax.Value - numericUpDownYMin.Value) / 5m;
        }

        private void ButtonLineSettings_Click(object sender, EventArgs e)
        {
            new FormLineSettings(chart.Series).ShowDialog();
        }

        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы|*.txt"
            };

            DialogResult dr = SVDialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            try
            {
                using (StreamWriter writer = new StreamWriter(SVDialog.FileName))
                {
                    writer.Write("d");

                    foreach (var a in parameters)
                        writer.Write(" " + a);

                    writer.WriteLine();

                    for (int row = 0; row < regrets.GetLength(0); row++)
                    {
                        writer.Write(Bandit.GetDeviation(row));

                        for (int col = 0; col < regrets.GetLength(1); col++)
                            writer.Write(" " + regrets[row, col]);

                        writer.WriteLine();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSaveGraph_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVDialog = new SaveFileDialog
            {
                Filter = "Изображения|*.png"
            };

            DialogResult dr = SVDialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            chart.SaveImage(SVDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void ComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] size = comboBoxSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            chart.Height = chart.Width * size[1] / size[0];
        }

        private void NumericUpDownDecimalPlaces_ValueChanged(object sender, EventArgs e)
        {
            int decimalPlaces = (int)numericUpDownDecimalPlaces.Value;
            decimal increment = (decimal)Math.Pow(10, -(int)numericUpDownDecimalPlaces.Value);

            numericUpDownXMin.DecimalPlaces = decimalPlaces;
            numericUpDownXMax.DecimalPlaces = decimalPlaces;
            numericUpDownYMin.DecimalPlaces = decimalPlaces;
            numericUpDownYMax.DecimalPlaces = decimalPlaces;
            numericUpDownYInterval.DecimalPlaces = decimalPlaces;
            numericUpDownXInterval.DecimalPlaces = decimalPlaces;

            numericUpDownXMin.Increment = increment;
            numericUpDownXMax.Increment = increment;
            numericUpDownYMin.Increment = increment;
            numericUpDownYMax.Increment = increment;
            numericUpDownYInterval.Increment = increment;
            numericUpDownXInterval.Increment = increment;
            numericUpDownXInterval.Minimum = increment;
            numericUpDownYInterval.Minimum = increment;
        }

        private void NumericUpDownXMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownXMax.Minimum = numericUpDownXMin.Value;
            chart.ChartAreas[0].AxisX.Minimum = (double)numericUpDownXMin.Value;
        }

        private void NumericUpDownXMax_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownXMin.Maximum = numericUpDownXMax.Value;
            chart.ChartAreas[0].AxisX.Maximum = (double)numericUpDownXMax.Value;
        }

        private void NumericUpDownYMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownYMax.Minimum = numericUpDownYMin.Value;
            chart.ChartAreas[0].AxisY.Minimum = (double)numericUpDownYMin.Value;
        }

        private void NumericUpDownYMax_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownYMin.Maximum = numericUpDownYMax.Value;
            chart.ChartAreas[0].AxisY.Maximum = (double)numericUpDownYMax.Value;
        }

        private void NumericUpDownXInterval_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Interval = (double)numericUpDownXInterval.Value;
        }

        private void NumericUpDownYInterval_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Interval = (double)numericUpDownYInterval.Value;
        }

        private void SetFontAxis(object sender, EventArgs e)
        {
            Font labelFont = new Font("", (int)numericUpDownFontSize.Value);
            Font axisFont = new Font("", (int)numericUpDownFontSize.Value, checkBoxItalics.Checked ? FontStyle.Italic : FontStyle.Regular);

            chart.ChartAreas[0].AxisX.Title = textBoxNameX.Text;
            chart.ChartAreas[0].AxisY.Title = textBoxNameY.Text;

            chart.ChartAreas[0].AxisX.LabelStyle.Font = labelFont;
            chart.ChartAreas[0].AxisY.LabelStyle.Font = labelFont;

            chart.ChartAreas[0].AxisX.TitleFont = axisFont;
            chart.ChartAreas[0].AxisY.TitleFont = axisFont;
        }
    }
}
