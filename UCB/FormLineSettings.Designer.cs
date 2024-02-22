
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
            this.numNumberLine = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbTypeLine = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.numBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl17 = new System.Windows.Forms.Label();
            this.lbl18 = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCurrentColor = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.lbl25 = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.lbl26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumberLine
            // 
            this.numNumberLine.Location = new System.Drawing.Point(165, 9);
            this.numNumberLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberLine.Name = "numNumberLine";
            this.numNumberLine.Size = new System.Drawing.Size(56, 26);
            this.numNumberLine.TabIndex = 3;
            this.numNumberLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberLine.ValueChanged += new System.EventHandler(this.LineChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(26, 11);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(133, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Номер графика:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(7, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(90, 20);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Тип линии:";
            // 
            // cmbTypeLine
            // 
            this.cmbTypeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeLine.FormattingEnabled = true;
            this.cmbTypeLine.Items.AddRange(new object[] {
            "Сплошная",
            "Пунктир"});
            this.cmbTypeLine.Location = new System.Drawing.Point(103, 73);
            this.cmbTypeLine.Name = "cmbTypeLine";
            this.cmbTypeLine.Size = new System.Drawing.Size(118, 28);
            this.cmbTypeLine.TabIndex = 6;
            this.cmbTypeLine.SelectedIndexChanged += new System.EventHandler(this.TypeLineChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(78, 43);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(81, 20);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Толщина:";
            // 
            // numBorderWidth
            // 
            this.numBorderWidth.Location = new System.Drawing.Point(165, 41);
            this.numBorderWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBorderWidth.Name = "numBorderWidth";
            this.numBorderWidth.Size = new System.Drawing.Size(56, 26);
            this.numBorderWidth.TabIndex = 11;
            this.numBorderWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBorderWidth.ValueChanged += new System.EventHandler(this.BorderWidthChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Red;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Location = new System.Drawing.Point(150, 114);
            this.lbl4.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(30, 30);
            this.lbl4.TabIndex = 32;
            this.lbl4.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6.Location = new System.Drawing.Point(186, 114);
            this.lbl6.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(30, 30);
            this.lbl6.TabIndex = 33;
            this.lbl6.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.Green;
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl7.Location = new System.Drawing.Point(258, 114);
            this.lbl7.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(30, 30);
            this.lbl7.TabIndex = 35;
            this.lbl7.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Yellow;
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8.Location = new System.Drawing.Point(222, 114);
            this.lbl8.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(30, 30);
            this.lbl8.TabIndex = 34;
            this.lbl8.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl9.Location = new System.Drawing.Point(294, 114);
            this.lbl9.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(30, 30);
            this.lbl9.TabIndex = 36;
            this.lbl9.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Maroon;
            this.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl10.Location = new System.Drawing.Point(114, 114);
            this.lbl10.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(30, 30);
            this.lbl10.TabIndex = 41;
            this.lbl10.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Gray;
            this.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl11.Location = new System.Drawing.Point(78, 114);
            this.lbl11.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(30, 30);
            this.lbl11.TabIndex = 40;
            this.lbl11.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Black;
            this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12.Location = new System.Drawing.Point(42, 114);
            this.lbl12.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(30, 30);
            this.lbl12.TabIndex = 39;
            this.lbl12.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.BackColor = System.Drawing.Color.Purple;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl13.Location = new System.Drawing.Point(366, 114);
            this.lbl13.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(30, 30);
            this.lbl13.TabIndex = 38;
            this.lbl13.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.BackColor = System.Drawing.Color.Blue;
            this.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl14.Location = new System.Drawing.Point(330, 114);
            this.lbl14.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(30, 30);
            this.lbl14.TabIndex = 37;
            this.lbl14.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.BackColor = System.Drawing.Color.Peru;
            this.lbl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl15.Location = new System.Drawing.Point(114, 153);
            this.lbl15.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(30, 30);
            this.lbl15.TabIndex = 51;
            this.lbl15.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl16.Location = new System.Drawing.Point(78, 153);
            this.lbl16.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(30, 30);
            this.lbl16.TabIndex = 50;
            this.lbl16.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl17
            // 
            this.lbl17.AutoSize = true;
            this.lbl17.BackColor = System.Drawing.Color.White;
            this.lbl17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl17.Location = new System.Drawing.Point(42, 153);
            this.lbl17.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(30, 30);
            this.lbl17.TabIndex = 49;
            this.lbl17.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl18
            // 
            this.lbl18.AutoSize = true;
            this.lbl18.BackColor = System.Drawing.Color.MediumOrchid;
            this.lbl18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl18.Location = new System.Drawing.Point(366, 153);
            this.lbl18.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl18.Name = "lbl18";
            this.lbl18.Size = new System.Drawing.Size(30, 30);
            this.lbl18.TabIndex = 48;
            this.lbl18.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl19
            // 
            this.lbl19.AutoSize = true;
            this.lbl19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl19.Location = new System.Drawing.Point(330, 153);
            this.lbl19.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(30, 30);
            this.lbl19.TabIndex = 47;
            this.lbl19.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.BackColor = System.Drawing.Color.Cyan;
            this.lbl20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl20.Location = new System.Drawing.Point(294, 153);
            this.lbl20.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(30, 30);
            this.lbl20.TabIndex = 46;
            this.lbl20.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.BackColor = System.Drawing.Color.Lime;
            this.lbl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl21.Location = new System.Drawing.Point(258, 153);
            this.lbl21.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(30, 30);
            this.lbl21.TabIndex = 45;
            this.lbl21.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl22.Location = new System.Drawing.Point(222, 153);
            this.lbl22.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(30, 30);
            this.lbl22.TabIndex = 44;
            this.lbl22.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.BackColor = System.Drawing.Color.Gold;
            this.lbl23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl23.Location = new System.Drawing.Point(186, 153);
            this.lbl23.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(30, 30);
            this.lbl23.TabIndex = 43;
            this.lbl23.Click += new System.EventHandler(this.OnColorClick);
            // 
            // lbl24
            // 
            this.lbl24.AutoSize = true;
            this.lbl24.BackColor = System.Drawing.Color.Fuchsia;
            this.lbl24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl24.Location = new System.Drawing.Point(150, 153);
            this.lbl24.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(30, 30);
            this.lbl24.TabIndex = 42;
            this.lbl24.Click += new System.EventHandler(this.OnColorClick);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(150, 186);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 35);
            this.btnOK.TabIndex = 62;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblCurrentColor
            // 
            this.lblCurrentColor.AutoSize = true;
            this.lblCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentColor.Location = new System.Drawing.Point(234, 9);
            this.lblCurrentColor.MinimumSize = new System.Drawing.Size(95, 95);
            this.lblCurrentColor.Name = "lblCurrentColor";
            this.lblCurrentColor.Size = new System.Drawing.Size(95, 95);
            this.lblCurrentColor.TabIndex = 63;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(335, 13);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 20);
            this.lbl3.TabIndex = 64;
            this.lbl3.Text = "R:";
            // 
            // numRed
            // 
            this.numR.Location = new System.Drawing.Point(366, 11);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numRed";
            this.numR.Size = new System.Drawing.Size(57, 26);
            this.numR.TabIndex = 65;
            this.numR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.ValueChanged += new System.EventHandler(this.OnRGBChanged);
            // 
            // numGreen
            // 
            this.numG.Location = new System.Drawing.Point(366, 43);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numGreen";
            this.numG.Size = new System.Drawing.Size(57, 26);
            this.numG.TabIndex = 67;
            this.numG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.ValueChanged += new System.EventHandler(this.OnRGBChanged);
            // 
            // lbl25
            // 
            this.lbl25.AutoSize = true;
            this.lbl25.Location = new System.Drawing.Point(334, 45);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(26, 20);
            this.lbl25.TabIndex = 66;
            this.lbl25.Text = "G:";
            // 
            // numBlue
            // 
            this.numB.Location = new System.Drawing.Point(366, 75);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numBlue";
            this.numB.Size = new System.Drawing.Size(57, 26);
            this.numB.TabIndex = 69;
            this.numB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.ValueChanged += new System.EventHandler(this.OnRGBChanged);
            // 
            // lbl26
            // 
            this.lbl26.AutoSize = true;
            this.lbl26.Location = new System.Drawing.Point(337, 77);
            this.lbl26.Name = "lbl26";
            this.lbl26.Size = new System.Drawing.Size(24, 20);
            this.lbl26.TabIndex = 68;
            this.lbl26.Text = "B:";
            // 
            // FormLineSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(438, 230);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.lbl26);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.lbl25);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblCurrentColor);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.lbl16);
            this.Controls.Add(this.lbl17);
            this.Controls.Add(this.lbl18);
            this.Controls.Add(this.lbl19);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl23);
            this.Controls.Add(this.lbl24);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.lbl14);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.numBorderWidth);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.cmbTypeLine);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numNumberLine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLineSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки линии";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numNumberLine;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbTypeLine;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.NumericUpDown numBorderWidth;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl17;
        private System.Windows.Forms.Label lbl18;
        private System.Windows.Forms.Label lbl19;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCurrentColor;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.Label lbl25;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label lbl26;
    }
}