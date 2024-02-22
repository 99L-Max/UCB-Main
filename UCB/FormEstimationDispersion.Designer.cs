
namespace UCB
{
    partial class FormEstimationDispersion
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
            this.rbNever = new System.Windows.Forms.RadioButton();
            this.rbOnlyOnInitialStage = new System.Windows.Forms.RadioButton();
            this.rbAlways = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbNever
            // 
            this.rbNever.AutoSize = true;
            this.rbNever.ForeColor = System.Drawing.Color.Black;
            this.rbNever.Location = new System.Drawing.Point(13, 14);
            this.rbNever.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNever.Name = "rbNever";
            this.rbNever.Size = new System.Drawing.Size(364, 24);
            this.rbNever.TabIndex = 0;
            this.rbNever.TabStop = true;
            this.rbNever.Tag = UCB.EstimationDispersion.Never;
            this.rbNever.Text = "Дисперсии известны и равны максимальной";
            this.rbNever.UseVisualStyleBackColor = true;
            this.rbNever.CheckedChanged += new System.EventHandler(this.OnRadioButtonChanged);
            // 
            // rbOnlyOnInitialStage
            // 
            this.rbOnlyOnInitialStage.AutoSize = true;
            this.rbOnlyOnInitialStage.ForeColor = System.Drawing.Color.Black;
            this.rbOnlyOnInitialStage.Location = new System.Drawing.Point(13, 48);
            this.rbOnlyOnInitialStage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOnlyOnInitialStage.Name = "rbOnlyOnInitialStage";
            this.rbOnlyOnInitialStage.Size = new System.Drawing.Size(413, 24);
            this.rbOnlyOnInitialStage.TabIndex = 1;
            this.rbOnlyOnInitialStage.TabStop = true;
            this.rbOnlyOnInitialStage.Tag = UCB.EstimationDispersion.OnlyOnInitialStage;
            this.rbOnlyOnInitialStage.Text = "Оценивать дисперсии только на начальном этапе";
            this.rbOnlyOnInitialStage.UseVisualStyleBackColor = true;
            this.rbOnlyOnInitialStage.CheckedChanged += new System.EventHandler(this.OnRadioButtonChanged);
            // 
            // rbAlways
            // 
            this.rbAlways.AutoSize = true;
            this.rbAlways.ForeColor = System.Drawing.Color.Black;
            this.rbAlways.Location = new System.Drawing.Point(13, 82);
            this.rbAlways.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAlways.Name = "rbAlways";
            this.rbAlways.Size = new System.Drawing.Size(434, 24);
            this.rbAlways.TabIndex = 2;
            this.rbAlways.TabStop = true;
            this.rbAlways.Tag = UCB.EstimationDispersion.Always;
            this.rbAlways.Text = "Оценивать дисперсии на всём горизонте управления";
            this.rbAlways.UseVisualStyleBackColor = true;
            this.rbAlways.CheckedChanged += new System.EventHandler(this.OnRadioButtonChanged);
            // 
            // FormEstimationDispersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 123);
            this.Controls.Add(this.rbAlways);
            this.Controls.Add(this.rbOnlyOnInitialStage);
            this.Controls.Add(this.rbNever);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstimationDispersion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценка диспесрии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNever;
        private System.Windows.Forms.RadioButton rbOnlyOnInitialStage;
        private System.Windows.Forms.RadioButton rbAlways;
    }
}