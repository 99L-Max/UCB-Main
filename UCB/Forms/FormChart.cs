﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCB
{
    partial class FormChart : Form
    {
        private readonly Size _aspectRatioChart = new Size(16, 9);

        private RegretTable _regretTable;
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
            OnDecimalPlacesChanged(_numDecimalPlaces, EventArgs.Empty);

            _fontLabel = _chart.ChartAreas[0].AxisX.LabelStyle.Font;
            _fontTitle = _chart.ChartAreas[0].AxisX.TitleFont;
        }

        public void BuildChart(RegretTable regrets)
        {
            _regretTable = regrets;
            Enabled = _rbOneGraph.Checked = true;
        }

        public void ClearChart()
        {
            _chart.Series.Clear();
            _regretTable = null;
            Enabled = false;
        }

        private void AddSeries(Dictionary<double, double> pointsXY, Color color)
        {
            var series = new Series
            {
                BorderWidth = 3,//По умолчанию
                ChartType = SeriesChartType.Spline,
                Color = color
            };

            _chart.Series.Add(series);

            var indexSeries = _chart.Series.Count - 1;

            foreach (var pair in pointsXY)
                _chart.Series[indexSeries].Points.AddXY(pair.Key, pair.Value);
        }

        private void OnRadioButtonChanged(object sender, EventArgs e)
        {
            Dictionary<double, double> points;
            double yMax = double.MinValue;

            _chart.Series.Clear();

            if (_rbOneGraph.Checked)
            {
                points = _regretTable.GetRegrets(_regretTable.IndexMinMax);
                yMax = points.Values.Max();

                AddSeries(points, Color.Blue);//По умолчанию
            }
            else
            {
                for (int i = 0; i < _regretTable.CountColumns; i++)
                {
                    points = _regretTable.GetRegrets(_regretTable.IndexMinMax);
                    yMax = Math.Max(points.Values.Max(), yMax);

                    AddSeries(points, s_colorsDefault[i % s_colorsDefault.Count]);
                }
            }

            yMax = Math.Ceiling(yMax);

            _numXMin.Value = (decimal)_regretTable.GetDeviation(0);
            _numXMax.Value = (decimal)_regretTable.GetDeviation(_regretTable.CountRows - 1);
            _numYMax.Value = (decimal)(yMax == 0d ? 1d : yMax);
            _numYMin.Value = 0m;

            //По умолчанию делим каждую ось на 5 отрезков
            _numXInterval.Value = (_numXMax.Value - _numXMin.Value) / 5m;
            _numYInterval.Value = (_numYMax.Value - _numYMin.Value) / 5m;
        }

        private void OnLineSettingsClick(object sender, EventArgs e) =>
            new FormLineSettings(_chart.Series).ShowDialog();

        private void OnSaveDataClick(object sender, EventArgs e) =>
            FileHandler.Save(_regretTable);

        private void OnSaveGraphClick(object sender, EventArgs e) =>
            FileHandler.Save(_chart);

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

        private void OnButtonEnabledChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = btn.Enabled ? Color.White : Color.Gray;
        }

        private void OnResizeEnd(object sender, EventArgs e) =>
            _chart.Height = _chart.Width * _aspectRatioChart.Height / _aspectRatioChart.Width;
    }
}
