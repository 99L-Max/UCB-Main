using System.Windows.Forms;

namespace UCB
{
    partial class FormInfo : Form
    {
        public FormInfo(string text)
        {
            InitializeComponent();
            textBox.BackColor = FormControl.BackColorForm;
            textBox.Text = text.Replace("/t/", "\t");
        }
    }
}
