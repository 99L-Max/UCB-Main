using System;
using System.Drawing;
using System.Windows.Forms;
using UCB.Properties;

namespace UCB
{
    partial class FormControl : Form
    {
        private readonly FormModeling formModeling = new FormModeling();

        private bool isDrag = false;
        private bool isResize = false;
        private Point startPoint;
        private Form activeForm;
        private FormChart formChart = new FormChart();

        public static readonly Color BackColorForm = Color.SlateBlue;

        public FormControl()
        {
            InitializeComponent();

            formModeling.BuildChart += BuildChart;
            formModeling.ClearChart += ClearChart;

            MainToolStripMenuItem_Click(null, null);
        }

        private void OpenChildForm(Form childform)
        {
            if (!(activeForm is FormModeling || activeForm is FormChart))
                activeForm?.Close();

            activeForm = childform;

            childform.BackColor = BackColor;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;

            panelDesctopPanel.Controls.Clear();
            panelDesctopPanel.Controls.Add(panelResize);
            panelDesctopPanel.Controls.Add(childform);

            childform.Show();
        }

        private void BuildChart()
        {
            formChart = new FormChart(formModeling.Regrets, formModeling.Parameters, formModeling.IndexBestBandit);

            if (activeForm is FormChart)
                OpenChildForm(formChart);
        }

        private void ClearChart()
        {
            formChart = new FormChart();
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name != ExitToolStripMenuItem.Name)
                labelTitle.Text = e.ClickedItem.Text;
        }

        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain());
        }

        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(formModeling);
        }

        private void GraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(formChart);
        }

        private void StrategyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInfo(Resources.AboutStrategy));
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInfo(Resources.AboutProgram));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                buttonResize.BackgroundImage = Resources.Resize_Min;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                buttonResize.BackgroundImage = Resources.Resize_Max;
            }

            panelResize.Visible = !panelResize.Visible;
        }

        private void ButtonMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelFrame_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void PanelFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
        private void PanelFrame_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void PanelResize_MouseDown(object sender, MouseEventArgs e)
        {
            isResize = true;
        }

        private void PanelResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResize)
                Size = new Size(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
        }

        private void PanelResize_MouseUp(object sender, MouseEventArgs e)
        {
            isResize = false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formModeling.IsFinished && formModeling.IsSaved)
                return;

            if (!formModeling.IsFinished)
            {
                MessageBox.Show($"Процесс не завершён.{Environment.NewLine}Дождитесь завершения процесса или отмените его.", "Закрытие невозможно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }

            if (MessageBox.Show($"Несохранённые данные будут удалены.{Environment.NewLine}Продолжить?", "Данные не сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
