using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCB
{
    partial class FormChart : Form
    {
        private readonly RegretTable _regrets;

        private Font _fontLabel;
        private Font _fontTitle;

        private static readonly ReadOnlyCollection<Color> s_colorsDefault;

        static FormChart()
        {
            List<Color> list = new List<Color>()
            {
                Color.Red, Color.Green, Color.Blue,
                Color.Orange, Color.Purple, Color.Black,
                Color.Maroon, Color.DarkGreen, Color.Cyan,
                Color.Gold, Color.Indigo, Color.DimGray
            };

            s_colorsDefault = new ReadOnlyCollection<Color>(list);
        }

        public FormChart()
        {
            InitializeComponent();

            _grpBoxAxis.Enabled = false;
            _grpBox_numerics.Enabled = false;
            _grpBoxOther.Enabled = false;
            _btnLineSettings.Enabled = false;
            _btnSaveData.Enabled = false;
            _btnSaveGraph.Enabled = false;

            _btnLineSettings.BackColor = Color.Gray;
            _btnSaveData.BackColor = Color.Gray;
            _btnSaveGraph.BackColor = Color.Gray;
        }

        public FormChart(RegretTable regrets)
        {
            InitializeComponent();

            _regrets = regrets;
            _fontLabel = _chart.ChartAreas[0].AxisX.LabelStyle.Font;
            _fontTitle = _chart.ChartAreas[0].AxisX.TitleFont;

            _rbOneGraph.Checked = true;
        }

        private void AddSeries(Dictionary<double, double> pointsXY, Color color)
        {
            var series = new Series
            {
                BorderWidth = 3,//По умолчанию
                ChartType = SeriesChartType.Spline,//По умолчанию
                Color = color
            };

            _chart.Series.Add(series);

            var indexSeries = _chart.Series.Count - 1;

            foreach (var pair in pointsXY)
                _chart.Series[indexSeries].Points.AddXY(pair.Key, pair.Value);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            _cmbSize.SelectedIndex = 0;
            _cmbSize.SelectedIndexChanged += OnSizeChanged;

            OnDecimalPlacesChanged(_numDecimalPlaces, EventArgs.Empty);
        }

        private void OnRadioButtonChanged(object sender, EventArgs e)
        {
            Dictionary<double, double> points;
            double yMax = double.MinValue;

            _chart.Series.Clear();

            if (_rbOneGraph.Checked)
            {
                points = _regrets.GetRegrets(_regrets.IndexMinMax);
                yMax = points.Values.Max();

                AddSeries(points, Color.Blue);//По умолчанию
            }
            else
            {
                for (int i = 0; i < _regrets.CountColumns; i++)
                {
                    points = _regrets.GetRegrets(_regrets.IndexMinMax);
                    yMax = Math.Max(points.Values.Max(), yMax);

                    AddSeries(points, s_colorsDefault[i % s_colorsDefault.Count]);
                }
            }

            yMax = Math.Ceiling(yMax);

            _numXMin.Value = (decimal)_regrets.GetDeviation(0);
            _numXMax.Value = (decimal)_regrets.GetDeviation(_regrets.CountRows - 1);
            _numYMax.Value = (decimal)(yMax == 0d ? 1d : yMax);
            _numYMin.Value = 0m;

            //По умолчанию делим каждую ось на 5 отрезков
            _numXInterval.Value = (_numXMax.Value - _numXMin.Value) / 5m;
            _numYInterval.Value = (_numYMax.Value - _numYMin.Value) / 5m;
        }

        private void OnLineSettingsClick(object sender, EventArgs e) =>
            new FormLineSettings(_chart.Series).ShowDialog();

        private void OnSaveDataClick(object sender, EventArgs e) =>
            FileHandler.Save(_regrets);

        private void OnSaveGraphClick(object sender, EventArgs e) =>
            FileHandler.Save(_chart);

        private void OnSizeChanged(object sender, EventArgs e)
        {
            var size = _cmbSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            _chart.Height = _chart.Width * size[1] / size[0];
        }

        private void OnDecimalPlacesChanged(object sender, EventArgs e)
        {
            var decimalPlaces = (int)_numDecimalPlaces.Value;
            var increment = (decimal)Math.Pow(10, -(int)_numDecimalPlaces.Value);
            var numericUpDowns = new NumericUpDown[] { _numXMin, _numYMin, _numXMax, _numYMax, _numXInterval, _numYInterval };

            foreach (var ctrl in numericUpDowns)
            {
                ctrl.DecimalPlaces = decimalPlaces;
                ctrl.Increment = increment;
            }
        }

        private void OnXMinChanged(object sender, EventArgs e)
        {
            _numXMax.Minimum = _numXMin.Value;
            _chart.ChartAreas[0].AxisX.Minimum = (double)_numXMin.Value;
        }

        private void OnXMaxChanged(object sender, EventArgs e)
        {
            _numXMin.Maximum = _numXMax.Value;
            _chart.ChartAreas[0].AxisX.Maximum = (double)_numXMax.Value;
        }

        private void OnYMinChanged(object sender, EventArgs e)
        {
            _numYMax.Minimum = _numYMin.Value;
            _chart.ChartAreas[0].AxisY.Minimum = (double)_numYMin.Value;
        }

        private void OnYMaxChanged(object sender, EventArgs e)
        {
            _numYMin.Maximum = _numYMax.Value;
            _chart.ChartAreas[0].AxisY.Maximum = (double)_numYMax.Value;
        }

        private void OnXIntervalChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisX.Interval = (double)_numXInterval.Value;

        private void OnYIntervalChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisY.Interval = (double)_numYInterval.Value;

        private void OnAxisXTextChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisX.Title = _txtNameX.Text;

        private void OnAxisYTextChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisY.Title = _txtNameY.Text;

        private void OnFontAxisChanged(object sender, EventArgs e)
        {
            Font labelFont = new Font("", (int)_numFontSize.Value);
            Font axisFont = new Font("", (int)_numFontSize.Value, _chkItalics.Checked ? FontStyle.Italic : FontStyle.Regular);

            _chart.ChartAreas[0].AxisX.LabelStyle.Font = labelFont;
            _chart.ChartAreas[0].AxisY.LabelStyle.Font = labelFont;

            _chart.ChartAreas[0].AxisX.TitleFont = axisFont;
            _chart.ChartAreas[0].AxisY.TitleFont = axisFont;

            _fontLabel.Dispose();
            _fontTitle.Dispose();

            _fontLabel = labelFont;
            _fontTitle = axisFont;
        }
    }
}
