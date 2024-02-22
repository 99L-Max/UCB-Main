using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCB
{
    partial class FormLineSettings : Form
    {
        private readonly SeriesCollection series;

        private int selectedIndex = 0;
        private bool isUserChangeValue = true;

        public FormLineSettings(SeriesCollection series)
        {
            InitializeComponent();

            this.series = series;
            numNumberLine.Maximum = this.series.Count;

            LineChanged(numNumberLine, EventArgs.Empty);
        }

        private void SetColorLineOnForm()
        {
            lblCurrentColor.BackColor = series[selectedIndex].Color;

            isUserChangeValue = false;

            numR.Value = lblCurrentColor.BackColor.R;
            numG.Value = lblCurrentColor.BackColor.G;
            numB.Value = lblCurrentColor.BackColor.B;

            isUserChangeValue = true;
        }

        private void LineChanged(object sender, EventArgs e)
        {
            selectedIndex = (int)numNumberLine.Value - 1;
            numBorderWidth.Value = series[selectedIndex].BorderWidth;
            cmbTypeLine.SelectedIndex = Convert.ToInt32(series[selectedIndex].BorderDashStyle != ChartDashStyle.Solid);

            SetColorLineOnForm();
        }

        private void TypeLineChanged(object sender, EventArgs e)
        {
            series[selectedIndex].BorderDashStyle = cmbTypeLine.SelectedIndex == 0 ? ChartDashStyle.Solid : ChartDashStyle.Dash;
        }

        private void BorderWidthChanged(object sender, EventArgs e)
        {
            series[selectedIndex].BorderWidth = (int)numBorderWidth.Value;
        }

        private void OnColorClick(object sender, EventArgs e)
        {
            series[selectedIndex].Color = (sender as Label).BackColor;
            SetColorLineOnForm();
        }

        private void OnRGBChanged(object sender, EventArgs e)
        {
            if (isUserChangeValue)
            {
                lblCurrentColor.BackColor = Color.FromArgb((int)numR.Value, (int)numG.Value, (int)numB.Value);
                series[selectedIndex].Color = lblCurrentColor.BackColor;
            }
        }
    }
}
