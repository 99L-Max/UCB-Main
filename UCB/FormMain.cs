using System;
using System.Windows.Forms;

namespace UCB
{
    partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            labelDate.Text = DateTime.Now.ToString("dddd") + Environment.NewLine + DateTime.Now.ToString("D");
            Timer_Tick(null, null);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
