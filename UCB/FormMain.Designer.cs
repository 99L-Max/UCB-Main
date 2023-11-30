
namespace UCB
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.BackgroundImage = global::UCB.Properties.Resources.Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(273, 87);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(223, 345);
            this.labelDate.MaximumSize = new System.Drawing.Size(260, 65);
            this.labelDate.MinimumSize = new System.Drawing.Size(260, 65);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(260, 65);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Понедельник\n01 Января 0000 г.";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(204, 280);
            this.labelTime.MaximumSize = new System.Drawing.Size(300, 65);
            this.labelTime.MinimumSize = new System.Drawing.Size(300, 65);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(300, 65);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(223, 250);
            this.labelTitle.MaximumSize = new System.Drawing.Size(260, 30);
            this.labelTitle.MinimumSize = new System.Drawing.Size(260, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 30);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Стратегия UCB";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(707, 482);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Timer timer;
    }
}