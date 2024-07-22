using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCB
{
    partial class FormLineSettings : Form
    {
        private readonly SeriesCollection _series;

        private int _selectedIndex = 0;
        private bool _isUserChangeValue = true;

        public FormLineSettings(SeriesCollection series)
        {
            InitializeComponent();

            _series = series;
            _numNumberLine.Maximum = _series.Count;

            OnLineChanged(_numNumberLine, EventArgs.Empty);
        }

        private void SetColorLineOnForm()
        {
            _lblCurrentColor.BackColor = _series[_selectedIndex].Color;

            _isUserChangeValue = false;

            _numR.Value = _lblCurrentColor.BackColor.R;
            _numG.Value = _lblCurrentColor.BackColor.G;
            _numB.Value = _lblCurrentColor.BackColor.B;

            _isUserChangeValue = true;
        }

        private void OnLineChanged(object sender, EventArgs e)
        {
            _selectedIndex = (int)_numNumberLine.Value - 1;
            _numBorderWidth.Value = _series[_selectedIndex].BorderWidth;
            _cmbTypeLine.SelectedIndex = Convert.ToInt32(_series[_selectedIndex].BorderDashStyle != ChartDashStyle.Solid);

            SetColorLineOnForm();
        }

        private void OnTypeLineChanged(object sender, EventArgs e) =>
            _series[_selectedIndex].BorderDashStyle = _cmbTypeLine.SelectedIndex == 0 ? ChartDashStyle.Solid : ChartDashStyle.Dash;

        private void OnBorderWidthChanged(object sender, EventArgs e) =>
            _series[_selectedIndex].BorderWidth = (int)_numBorderWidth.Value;

        private void OnColorClick(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                _series[_selectedIndex].Color = label.BackColor;
                SetColorLineOnForm();
            }
        }

        private void OnRGBChanged(object sender, EventArgs e)
        {
            if (_isUserChangeValue)
            {
                _lblCurrentColor.BackColor = Color.FromArgb((int)_numR.Value, (int)_numG.Value, (int)_numB.Value);
                _series[_selectedIndex].Color = _lblCurrentColor.BackColor;
            }
        }
    }
}
