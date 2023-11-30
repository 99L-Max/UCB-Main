
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
            this.radioButtonNever = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyOnInitialStage = new System.Windows.Forms.RadioButton();
            this.radioButtonAlways = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonNever
            // 
            this.radioButtonNever.AutoSize = true;
            this.radioButtonNever.ForeColor = System.Drawing.Color.Black;
            this.radioButtonNever.Location = new System.Drawing.Point(13, 14);
            this.radioButtonNever.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonNever.Name = "radioButtonNever";
            this.radioButtonNever.Size = new System.Drawing.Size(364, 24);
            this.radioButtonNever.TabIndex = 0;
            this.radioButtonNever.TabStop = true;
            this.radioButtonNever.Tag = UCB.EstimationDispersion.Never;
            this.radioButtonNever.Text = "Дисперсии известны и равны максимальной";
            this.radioButtonNever.UseVisualStyleBackColor = true;
            this.radioButtonNever.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonOnlyOnInitialStage
            // 
            this.radioButtonOnlyOnInitialStage.AutoSize = true;
            this.radioButtonOnlyOnInitialStage.ForeColor = System.Drawing.Color.Black;
            this.radioButtonOnlyOnInitialStage.Location = new System.Drawing.Point(13, 48);
            this.radioButtonOnlyOnInitialStage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOnlyOnInitialStage.Name = "radioButtonOnlyOnInitialStage";
            this.radioButtonOnlyOnInitialStage.Size = new System.Drawing.Size(413, 24);
            this.radioButtonOnlyOnInitialStage.TabIndex = 1;
            this.radioButtonOnlyOnInitialStage.TabStop = true;
            this.radioButtonOnlyOnInitialStage.Tag = UCB.EstimationDispersion.OnlyOnInitialStage;
            this.radioButtonOnlyOnInitialStage.Text = "Оценивать дисперсии только на начальном этапе";
            this.radioButtonOnlyOnInitialStage.UseVisualStyleBackColor = true;
            this.radioButtonOnlyOnInitialStage.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonAlways
            // 
            this.radioButtonAlways.AutoSize = true;
            this.radioButtonAlways.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAlways.Location = new System.Drawing.Point(13, 82);
            this.radioButtonAlways.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonAlways.Name = "radioButtonAlways";
            this.radioButtonAlways.Size = new System.Drawing.Size(434, 24);
            this.radioButtonAlways.TabIndex = 2;
            this.radioButtonAlways.TabStop = true;
            this.radioButtonAlways.Tag = UCB.EstimationDispersion.Always;
            this.radioButtonAlways.Text = "Оценивать дисперсии на всём горизонте управления";
            this.radioButtonAlways.UseVisualStyleBackColor = true;
            this.radioButtonAlways.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // FormEstimationDispersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 123);
            this.Controls.Add(this.radioButtonAlways);
            this.Controls.Add(this.radioButtonOnlyOnInitialStage);
            this.Controls.Add(this.radioButtonNever);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstimationDispersion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценка диспесрии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstimationDispersion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNever;
        private System.Windows.Forms.RadioButton radioButtonOnlyOnInitialStage;
        private System.Windows.Forms.RadioButton radioButtonAlways;
    }
}