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
            numericUpDownNumberLine.Maximum = this.series.Count;

            NumericUpDownNumberLine_ValueChanged(null, null);
        }

        private void SetColorLineOnForm()
        {
            labelCurrentColor.BackColor = series[selectedIndex].Color;

            isUserChangeValue = false;

            numericUpDownR.Value = labelCurrentColor.BackColor.R;
            numericUpDownG.Value = labelCurrentColor.BackColor.G;
            numericUpDownB.Value = labelCurrentColor.BackColor.B;

            isUserChangeValue = true;
        }

        private void NumericUpDownNumberLine_ValueChanged(object sender, EventArgs e)
        {
            selectedIndex = (int)numericUpDownNumberLine.Value - 1;
            numericUpDownBorderWidth.Value = series[selectedIndex].BorderWidth;
            comboBoxTypeLine.SelectedIndex = Convert.ToInt32(series[selectedIndex].BorderDashStyle != ChartDashStyle.Solid);

            SetColorLineOnForm();
        }

        private void ComboBoxTypeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            series[selectedIndex].BorderDashStyle = comboBoxTypeLine.SelectedIndex == 0 ? ChartDashStyle.Solid : ChartDashStyle.Dash;
        }

        private void NumericUpDownBorderWidth_ValueChanged(object sender, EventArgs e)
        {
            series[selectedIndex].BorderWidth = (int)numericUpDownBorderWidth.Value;
        }

        private void LabelColor_Click(object sender, EventArgs e)
        {
            series[selectedIndex].Color = (sender as Label).BackColor;
            SetColorLineOnForm();
        }

        private void NumericUpDownRGB_ValueChanged(object sender, EventArgs e)
        {
            if (isUserChangeValue)
            {
                labelCurrentColor.BackColor = Color.FromArgb((int)numericUpDownR.Value, (int)numericUpDownG.Value, (int)numericUpDownB.Value);
                series[selectedIndex].Color = labelCurrentColor.BackColor;
            }
        }
    }
}
