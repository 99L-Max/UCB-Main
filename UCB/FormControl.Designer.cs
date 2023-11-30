
namespace UCB
{
    partial class FormControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDesctopPanel = new System.Windows.Forms.Panel();
            this.panelResize = new System.Windows.Forms.Panel();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.buttonMinimaze = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panelDesctopPanel.SuspendLayout();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem,
            this.CalculateToolStripMenuItem,
            this.GraphToolStripMenuItem,
            this.StrategyToolStripMenuItem,
            this.AboutProgramToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(205, 521);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.MainToolStripMenuItem.Image = global::UCB.Properties.Resources.Main;
            this.MainToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(192, 61);
            this.MainToolStripMenuItem.Text = "Главная";
            this.MainToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolStripMenuItem.Click += new System.EventHandler(this.MainToolStripMenuItem_Click);
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CalculateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CalculateToolStripMenuItem.Image = global::UCB.Properties.Resources.Calculate;
            this.CalculateToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(192, 61);
            this.CalculateToolStripMenuItem.Text = "Моделирование";
            this.CalculateToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateToolStripMenuItem_Click);
            // 
            // GraphToolStripMenuItem
            // 
            this.GraphToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.GraphToolStripMenuItem.Image = global::UCB.Properties.Resources.Graph;
            this.GraphToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphToolStripMenuItem.Name = "GraphToolStripMenuItem";
            this.GraphToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.GraphToolStripMenuItem.Size = new System.Drawing.Size(192, 61);
            this.GraphToolStripMenuItem.Text = "График";
            this.GraphToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphToolStripMenuItem.Click += new System.EventHandler(this.GraphToolStripMenuItem_Click);
            // 
            // StrategyToolStripMenuItem
            // 
            this.StrategyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.StrategyToolStripMenuItem.Image = global::UCB.Properties.Resources.Strategy;
            this.StrategyToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StrategyToolStripMenuItem.Name = "StrategyToolStripMenuItem";
            this.StrategyToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.StrategyToolStripMenuItem.Size = new System.Drawing.Size(192, 61);
            this.StrategyToolStripMenuItem.Text = "Стратегия";
            this.StrategyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StrategyToolStripMenuItem.Click += new System.EventHandler(this.StrategyToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AboutProgramToolStripMenuItem.Image = global::UCB.Properties.Resources.AboutProgramm;
            this.AboutProgramToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(192, 61);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExitToolStripMenuItem.Image = global::UCB.Properties.Resources.Exit;
            this.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panelDesctopPanel
            // 
            this.panelDesctopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesctopPanel.Controls.Add(this.panelResize);
            this.panelDesctopPanel.Location = new System.Drawing.Point(205, 70);
            this.panelDesctopPanel.Name = "panelDesctopPanel";
            this.panelDesctopPanel.Padding = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.panelDesctopPanel.Size = new System.Drawing.Size(583, 451);
            this.panelDesctopPanel.TabIndex = 1;
            // 
            // panelResize
            // 
            this.panelResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResize.BackgroundImage = global::UCB.Properties.Resources.Resize;
            this.panelResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelResize.Location = new System.Drawing.Point(548, 416);
            this.panelResize.Name = "panelResize";
            this.panelResize.Size = new System.Drawing.Size(35, 35);
            this.panelResize.TabIndex = 0;
            this.panelResize.Visible = false;
            this.panelResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseDown);
            this.panelResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseMove);
            this.panelResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseUp);
            // 
            // panelFrame
            // 
            this.panelFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrame.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelFrame.Controls.Add(this.buttonMinimaze);
            this.panelFrame.Controls.Add(this.buttonResize);
            this.panelFrame.Controls.Add(this.buttonClose);
            this.panelFrame.Controls.Add(this.labelTitle);
            this.panelFrame.Location = new System.Drawing.Point(205, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(583, 70);
            this.panelFrame.TabIndex = 3;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelFrame_MouseUp);
            // 
            // buttonMinimaze
            // 
            this.buttonMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimaze.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMinimaze.BackgroundImage = global::UCB.Properties.Resources.Minimize;
            this.buttonMinimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimaze.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimaze.Location = new System.Drawing.Point(463, 3);
            this.buttonMinimaze.Name = "buttonMinimaze";
            this.buttonMinimaze.Size = new System.Drawing.Size(35, 35);
            this.buttonMinimaze.TabIndex = 3;
            this.buttonMinimaze.UseVisualStyleBackColor = false;
            this.buttonMinimaze.Click += new System.EventHandler(this.ButtonMinimaze_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResize.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonResize.BackgroundImage = global::UCB.Properties.Resources.Resize_Min;
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResize.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.Location = new System.Drawing.Point(504, 3);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(35, 35);
            this.buttonResize.TabIndex = 2;
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.ButtonResize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonClose.BackgroundImage = global::UCB.Properties.Resources.Close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(545, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(23, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(118, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Главная";
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(788, 521);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.panelDesctopPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(105, 35);
            this.Name = "FormControl";
            this.Text = "UCB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelDesctopPanel.ResumeLayout(false);
            this.panelFrame.ResumeLayout(false);
            this.panelFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.Panel panelDesctopPanel;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StrategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimaze;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Panel panelResize;
    }
}

