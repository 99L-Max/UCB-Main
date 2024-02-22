using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
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

            grpBoxAxis.Enabled = false;
            grpBoxNumerics.Enabled = false;
            grpBoxOther.Enabled = false;
            btnLineSettings.Enabled = false;
            btnSaveData.Enabled = false;
            btnSaveGraph.Enabled = false;

            btnLineSettings.BackColor = Color.Gray;
            btnSaveData.BackColor = Color.Gray;
            btnSaveGraph.BackColor = Color.Gray;
        }

        public FormChart(double[,] regrets, double[] parameters, int indexBestBandit)
        {
            InitializeComponent();

            if (indexBestBandit < 0 || indexBestBandit >= regrets.GetLength(1))
                throw new IndexOutOfRangeException("Недопустимый индекс графика.");

            if (regrets.GetLength(0) != Bandit.NumberDeviations)
                throw new ArgumentException("Неверный размер данных.");

            this.regrets = regrets;
            this.indexBestBandit = indexBestBandit;
            this.parameters = parameters;

            rbOneGraph.Checked = true;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            cmbSize.SelectedIndex = 0;
            cmbSize.SelectedIndexChanged += OnComboBoxSizeChanged;

            OnDecimalPlacesChanged(numDecimalPlaces, EventArgs.Empty);
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
                chart.Series[indexSeries].Points.AddXY(Bandit.GetDeviation(i), regrets[i, indexObject]);
        }

        private void OnRadioButtonChanged(object sender, EventArgs e)
        {
            double yMax = double.MinValue;

            chart.Series.ToList().ForEach(s => s.Dispose());
            chart.Series.Clear();

            if (rbOneGraph.Checked)
            {
                AddSeries(indexBestBandit, Color.Blue);//По умолчанию
                yMax = regrets.Cast<double>().Where((x, i) => (i % regrets.GetLength(1) == indexBestBandit)).Max();
            }
            else
            {
                for (int i = 0; i < regrets.GetLength(0); i++)
                    AddSeries(i, colorsDefault[i % colorsDefault.Count]);

                yMax = regrets.Cast<double>().Max();
            }

            yMax = Math.Ceiling(yMax);

            numXMin.Value = (decimal)Bandit.GetDeviation(0);
            numXMax.Value = (decimal)Bandit.GetDeviation(Bandit.NumberDeviations - 1);
            numYMin.Value = 0m;
            numYMax.Value = (decimal)(yMax == 0d ? 1d : yMax);

            //По умолчанию делим каждую ось на 5 отрезков
            numXInterval.Value = (numXMax.Value - numXMin.Value) / 5m;
            numYInterval.Value = (numYMax.Value - numYMin.Value) / 5m;
        }

        private void OnLineSettingsClick(object sender, EventArgs e)
        {
            new FormLineSettings(chart.Series).ShowDialog();
        }

        private void OnSaveDataClick(object sender, EventArgs e)
        {
            using (SaveFileDialog SVDialog = new SaveFileDialog())
            {
                SVDialog.Filter = "Текстовые файлы|*.txt";

                if (SVDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(SVDialog.FileName))
                    {
                        writer.Write("d");

                        parameters.ToList().ForEach(a => writer.Write($" {a}"));

                        writer.WriteLine();

                        for (int row = 0; row < regrets.GetLength(0); row++)
                        {
                            writer.Write(Bandit.GetDeviation(row));

                            for (int col = 0; col < regrets.GetLength(1); col++)
                                writer.Write($" {regrets[row, col]}");

                            writer.WriteLine();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnSaveGraphClick(object sender, EventArgs e)
        {
            using (SaveFileDialog SVDialog = new SaveFileDialog())
            {
                SVDialog.Filter = "Изображения|*.png";

                if (SVDialog.ShowDialog() != DialogResult.OK)
                    return;

                chart.SaveImage(SVDialog.FileName, ImageFormat.Png);
            }
        }

        private void OnComboBoxSizeChanged(object sender, EventArgs e)
        {
            int[] size = cmbSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            chart.Height = chart.Width * size[1] / size[0];
        }

        private void OnDecimalPlacesChanged(object sender, EventArgs e)
        {
            int decimalPlaces = (int)numDecimalPlaces.Value;
            decimal increment = (decimal)Math.Pow(10, -(int)numDecimalPlaces.Value);

            numXMin.DecimalPlaces = decimalPlaces;
            numXMax.DecimalPlaces = decimalPlaces;
            numYMin.DecimalPlaces = decimalPlaces;
            numYMax.DecimalPlaces = decimalPlaces;
            numYInterval.DecimalPlaces = decimalPlaces;
            numXInterval.DecimalPlaces = decimalPlaces;

            numXMin.Increment = increment;
            numXMax.Increment = increment;
            numYMin.Increment = increment;
            numYMax.Increment = increment;
            numYInterval.Increment = increment;
            numXInterval.Increment = increment;
            numXInterval.Minimum = increment;
            numYInterval.Minimum = increment;
        }

        private void XMinChanged(object sender, EventArgs e)
        {
            numXMax.Minimum = numXMin.Value;
            chart.ChartAreas[0].AxisX.Minimum = (double)numXMin.Value;
        }

        private void XMaxChanged(object sender, EventArgs e)
        {
            numXMin.Maximum = numXMax.Value;
            chart.ChartAreas[0].AxisX.Maximum = (double)numXMax.Value;
        }

        private void YMinChanged(object sender, EventArgs e)
        {
            numYMax.Minimum = numYMin.Value;
            chart.ChartAreas[0].AxisY.Minimum = (double)numYMin.Value;
        }

        private void YMaxChanged(object sender, EventArgs e)
        {
            numYMin.Maximum = numYMax.Value;
            chart.ChartAreas[0].AxisY.Maximum = (double)numYMax.Value;
        }

        private void XIntervalChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Interval = (double)numXInterval.Value;
        }

        private void YIntervalChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Interval = (double)numYInterval.Value;
        }

        private void SetFontAxis(object sender, EventArgs e)
        {
            Font labelFont = new Font("", (int)numFontSize.Value);
            Font axisFont = new Font("", (int)numFontSize.Value, chkItalics.Checked ? FontStyle.Italic : FontStyle.Regular);

            chart.ChartAreas[0].AxisX.Title = txtNameX.Text;
            chart.ChartAreas[0].AxisY.Title = txtNameY.Text;

            chart.ChartAreas[0].AxisX.LabelStyle.Font = labelFont;
            chart.ChartAreas[0].AxisY.LabelStyle.Font = labelFont;

            chart.ChartAreas[0].AxisX.TitleFont = axisFont;
            chart.ChartAreas[0].AxisY.TitleFont = axisFont;
        }
    }
}
