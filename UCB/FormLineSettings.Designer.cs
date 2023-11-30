
namespace UCB
{
    partial class FormLineSettings
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
            this.numericUpDownNumberLine = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeLine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelCurrentColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownG = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumberLine
            // 
            this.numericUpDownNumberLine.Location = new System.Drawing.Point(165, 9);
            this.numericUpDownNumberLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberLine.Name = "numericUpDownNumberLine";
            this.numericUpDownNumberLine.Size = new System.Drawing.Size(56, 26);
            this.numericUpDownNumberLine.TabIndex = 3;
            this.numericUpDownNumberLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberLine.ValueChanged += new System.EventHandler(this.NumericUpDownNumberLine_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер графика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип линии:";
            // 
            // comboBoxTypeLine
            // 
            this.comboBoxTypeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeLine.FormattingEnabled = true;
            this.comboBoxTypeLine.Items.AddRange(new object[] {
            "Сплошная",
            "Пунктир"});
            this.comboBoxTypeLine.Location = new System.Drawing.Point(103, 73);
            this.comboBoxTypeLine.Name = "comboBoxTypeLine";
            this.comboBoxTypeLine.Size = new System.Drawing.Size(118, 28);
            this.comboBoxTypeLine.TabIndex = 6;
            this.comboBoxTypeLine.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeLine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Толщина:";
            // 
            // numericUpDownBorderWidth
            // 
            this.numericUpDownBorderWidth.Location = new System.Drawing.Point(165, 41);
            this.numericUpDownBorderWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBorderWidth.Name = "numericUpDownBorderWidth";
            this.numericUpDownBorderWidth.Size = new System.Drawing.Size(56, 26);
            this.numericUpDownBorderWidth.TabIndex = 11;
            this.numericUpDownBorderWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBorderWidth.ValueChanged += new System.EventHandler(this.NumericUpDownBorderWidth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(150, 114);
            this.label4.MinimumSize = new System.Drawing.Size(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 32;
            this.label4.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(186, 114);
            this.label6.MinimumSize = new System.Drawing.Size(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 30);
            this.label6.TabIndex = 33;
            this.label6.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(258, 114);
            this.label7.MinimumSize = new System.Drawing.Size(30, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 30);
            this.label7.TabIndex = 35;
            this.label7.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(222, 114);
            this.label8.MinimumSize = new System.Drawing.Size(30, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 30);
            this.label8.TabIndex = 34;
            this.label8.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(294, 114);
            this.label9.MinimumSize = new System.Drawing.Size(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 30);
            this.label9.TabIndex = 36;
            this.label9.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Maroon;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(114, 114);
            this.label10.MinimumSize = new System.Drawing.Size(30, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 30);
            this.label10.TabIndex = 41;
            this.label10.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(78, 114);
            this.label11.MinimumSize = new System.Drawing.Size(30, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 30);
            this.label11.TabIndex = 40;
            this.label11.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(42, 114);
            this.label12.MinimumSize = new System.Drawing.Size(30, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 30);
            this.label12.TabIndex = 39;
            this.label12.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Purple;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(366, 114);
            this.label13.MinimumSize = new System.Drawing.Size(30, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 30);
            this.label13.TabIndex = 38;
            this.label13.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Blue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(330, 114);
            this.label14.MinimumSize = new System.Drawing.Size(30, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 30);
            this.label14.TabIndex = 37;
            this.label14.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Peru;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(114, 153);
            this.label15.MinimumSize = new System.Drawing.Size(30, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 30);
            this.label15.TabIndex = 51;
            this.label15.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(78, 153);
            this.label16.MinimumSize = new System.Drawing.Size(30, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 30);
            this.label16.TabIndex = 50;
            this.label16.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(42, 153);
            this.label17.MinimumSize = new System.Drawing.Size(30, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 30);
            this.label17.TabIndex = 49;
            this.label17.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.MediumOrchid;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(366, 153);
            this.label18.MinimumSize = new System.Drawing.Size(30, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 30);
            this.label18.TabIndex = 48;
            this.label18.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(330, 153);
            this.label19.MinimumSize = new System.Drawing.Size(30, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 30);
            this.label19.TabIndex = 47;
            this.label19.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Cyan;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(294, 153);
            this.label20.MinimumSize = new System.Drawing.Size(30, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 30);
            this.label20.TabIndex = 46;
            this.label20.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Lime;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(258, 153);
            this.label21.MinimumSize = new System.Drawing.Size(30, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 30);
            this.label21.TabIndex = 45;
            this.label21.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.LemonChiffon;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(222, 153);
            this.label22.MinimumSize = new System.Drawing.Size(30, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 30);
            this.label22.TabIndex = 44;
            this.label22.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Gold;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(186, 153);
            this.label23.MinimumSize = new System.Drawing.Size(30, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 30);
            this.label23.TabIndex = 43;
            this.label23.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Fuchsia;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(150, 153);
            this.label24.MinimumSize = new System.Drawing.Size(30, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 30);
            this.label24.TabIndex = 42;
            this.label24.Click += new System.EventHandler(this.LabelColor_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(150, 186);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 35);
            this.buttonOK.TabIndex = 62;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelCurrentColor
            // 
            this.labelCurrentColor.AutoSize = true;
            this.labelCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentColor.Location = new System.Drawing.Point(234, 9);
            this.labelCurrentColor.MinimumSize = new System.Drawing.Size(95, 95);
            this.labelCurrentColor.Name = "labelCurrentColor";
            this.labelCurrentColor.Size = new System.Drawing.Size(95, 95);
            this.labelCurrentColor.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "R:";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownR.Location = new System.Drawing.Point(366, 11);
            this.numericUpDownR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownR.Name = "numericUpDownRed";
            this.numericUpDownR.Size = new System.Drawing.Size(57, 26);
            this.numericUpDownR.TabIndex = 65;
            this.numericUpDownR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownR.ValueChanged += new System.EventHandler(this.NumericUpDownRGB_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownG.Location = new System.Drawing.Point(366, 43);
            this.numericUpDownG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownG.Name = "numericUpDownGreen";
            this.numericUpDownG.Size = new System.Drawing.Size(57, 26);
            this.numericUpDownG.TabIndex = 67;
            this.numericUpDownG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownG.ValueChanged += new System.EventHandler(this.NumericUpDownRGB_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(334, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 20);
            this.label25.TabIndex = 66;
            this.label25.Text = "G:";
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(366, 75);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownBlue";
            this.numericUpDownB.Size = new System.Drawing.Size(57, 26);
            this.numericUpDownB.TabIndex = 69;
            this.numericUpDownB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.NumericUpDownRGB_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(337, 77);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 20);
            this.label26.TabIndex = 68;
            this.label26.Text = "B:";
            // 
            // FormLineSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(438, 230);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.numericUpDownG);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.numericUpDownR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrentColor);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownBorderWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTypeLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNumberLine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLineSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки линии";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownNumberLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelCurrentColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.NumericUpDown numericUpDownG;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label label26;
    }
}