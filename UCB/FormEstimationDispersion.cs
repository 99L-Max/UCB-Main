using System.Windows.Forms;

namespace UCB
{
    partial class FormEstimationDispersion : Form
    {
        private readonly Label labelInfo;

        public FormEstimationDispersion(Label labelInfo)
        {
            InitializeComponent();

            foreach (var ctrl in Controls)
                if (ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;

                    if (BatchProcessing.EstimationDispersion == (EstimationDispersion)radio.Tag)
                    {
                        radio.Checked = true;
                        break;
                    }
                }

            this.labelInfo = labelInfo;
        }

        private void RadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            BatchProcessing.EstimationDispersion = (EstimationDispersion)(sender as RadioButton).Tag;
        }

        private void FormEstimationDispersion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BatchProcessing.EstimationDispersion == EstimationDispersion.Never)
                labelInfo.Text = "Дисперсии известны";
            else
                labelInfo.Text = "Дисперсии неизвестны";
        }
    }
}
