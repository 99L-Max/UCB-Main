
namespace UCB
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.lbl8 = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.chkItalics = new System.Windows.Forms.CheckBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.txtNameY = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.txtNameX = new System.Windows.Forms.TextBox();
            this.btnLineSettings = new System.Windows.Forms.Button();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.grpBoxAxis = new System.Windows.Forms.GroupBox();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.numYMin = new System.Windows.Forms.NumericUpDown();
            this.numYMax = new System.Windows.Forms.NumericUpDown();
            this.numYInterval = new System.Windows.Forms.NumericUpDown();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.numXInterval = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.numXMin = new System.Windows.Forms.NumericUpDown();
            this.numXMax = new System.Windows.Forms.NumericUpDown();
            this.numDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.lbl5 = new System.Windows.Forms.Label();
            this.grpBoxNumerics = new System.Windows.Forms.GroupBox();
            this.grpBoxOther = new System.Windows.Forms.GroupBox();
            this.rbAllGraph = new System.Windows.Forms.RadioButton();
            this.rbOneGraph = new System.Windows.Forms.RadioButton();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.grpBoxAxis.SuspendLayout();
            this.grpBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYInterval)).BeginInit();
            this.grpBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalPlaces)).BeginInit();
            this.grpBoxNumerics.SuspendLayout();
            this.grpBoxOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveGraph.BackColor = System.Drawing.Color.White;
            this.btnSaveGraph.ForeColor = System.Drawing.Color.Black;
            this.btnSaveGraph.Location = new System.Drawing.Point(787, 815);
            this.btnSaveGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(192, 44);
            this.btnSaveGraph.TabIndex = 2;
            this.btnSaveGraph.Text = "Сохранить график";
            this.btnSaveGraph.UseVisualStyleBackColor = false;
            this.btnSaveGraph.Click += new System.EventHandler(this.OnSaveGraphClick);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(21, 38);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(64, 20);
            this.lbl8.TabIndex = 15;
            this.lbl8.Text = "Шрифт";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(86, 36);
            this.numFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(78, 26);
            this.numFontSize.TabIndex = 17;
            this.numFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // chkItalics
            // 
            this.chkItalics.AutoSize = true;
            this.chkItalics.Location = new System.Drawing.Point(83, 138);
            this.chkItalics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkItalics.Name = "chkItalics";
            this.chkItalics.Size = new System.Drawing.Size(80, 24);
            this.chkItalics.TabIndex = 22;
            this.chkItalics.Text = "Курсив";
            this.chkItalics.UseVisualStyleBackColor = true;
            this.chkItalics.CheckedChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(51, 108);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(28, 20);
            this.lbl10.TabIndex = 21;
            this.lbl10.Text = "Oy";
            // 
            // txtNameY
            // 
            this.txtNameY.Location = new System.Drawing.Point(86, 104);
            this.txtNameY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameY.Name = "txtNameY";
            this.txtNameY.Size = new System.Drawing.Size(78, 26);
            this.txtNameY.TabIndex = 20;
            this.txtNameY.Leave += new System.EventHandler(this.SetFontAxis);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(51, 72);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(28, 20);
            this.lbl9.TabIndex = 19;
            this.lbl9.Text = "Ox";
            // 
            // txtNameX
            // 
            this.txtNameX.Location = new System.Drawing.Point(86, 70);
            this.txtNameX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameX.Name = "txtNameX";
            this.txtNameX.Size = new System.Drawing.Size(78, 26);
            this.txtNameX.TabIndex = 18;
            this.txtNameX.Leave += new System.EventHandler(this.SetFontAxis);
            // 
            // btnLineSettings
            // 
            this.btnLineSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLineSettings.BackColor = System.Drawing.Color.White;
            this.btnLineSettings.ForeColor = System.Drawing.Color.Black;
            this.btnLineSettings.Location = new System.Drawing.Point(787, 719);
            this.btnLineSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLineSettings.Name = "btnLineSettings";
            this.btnLineSettings.Size = new System.Drawing.Size(192, 44);
            this.btnLineSettings.TabIndex = 19;
            this.btnLineSettings.Text = "Настройки линий";
            this.btnLineSettings.UseVisualStyleBackColor = false;
            this.btnLineSettings.Click += new System.EventHandler(this.OnLineSettingsClick);
            // 
            // cmbSize
            // 
            this.cmbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSize.BackColor = System.Drawing.Color.White;
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.ForeColor = System.Drawing.Color.Black;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "16:9",
            "16:10",
            "4:3",
            "3:2"});
            this.cmbSize.Location = new System.Drawing.Point(15, 38);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(165, 28);
            this.cmbSize.TabIndex = 20;
            // 
            // grpBoxAxis
            // 
            this.grpBoxAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxAxis.Controls.Add(this.chkItalics);
            this.grpBoxAxis.Controls.Add(this.numFontSize);
            this.grpBoxAxis.Controls.Add(this.lbl10);
            this.grpBoxAxis.Controls.Add(this.lbl8);
            this.grpBoxAxis.Controls.Add(this.txtNameY);
            this.grpBoxAxis.Controls.Add(this.txtNameX);
            this.grpBoxAxis.Controls.Add(this.lbl9);
            this.grpBoxAxis.ForeColor = System.Drawing.Color.White;
            this.grpBoxAxis.Location = new System.Drawing.Point(787, 329);
            this.grpBoxAxis.Name = "grpBoxAxis";
            this.grpBoxAxis.Size = new System.Drawing.Size(192, 173);
            this.grpBoxAxis.TabIndex = 23;
            this.grpBoxAxis.TabStop = false;
            this.grpBoxAxis.Text = "Подписи";
            // 
            // grpBox3
            // 
            this.grpBox3.Controls.Add(this.lbl11);
            this.grpBox3.Controls.Add(this.lbl12);
            this.grpBox3.Controls.Add(this.lbl13);
            this.grpBox3.Controls.Add(this.numYMin);
            this.grpBox3.Controls.Add(this.numYMax);
            this.grpBox3.Controls.Add(this.numYInterval);
            this.grpBox3.ForeColor = System.Drawing.Color.White;
            this.grpBox3.Location = new System.Drawing.Point(10, 180);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Size = new System.Drawing.Size(170, 122);
            this.grpBox3.TabIndex = 22;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = "Ось Oy";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(12, 56);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(42, 20);
            this.lbl11.TabIndex = 12;
            this.lbl11.Text = "Max:";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(12, 86);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(42, 20);
            this.lbl12.TabIndex = 5;
            this.lbl12.Text = "Шаг:";
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(16, 26);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(38, 20);
            this.lbl13.TabIndex = 3;
            this.lbl13.Text = "Min:";
            // 
            // numYMin
            // 
            this.numYMin.Location = new System.Drawing.Point(60, 24);
            this.numYMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numYMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numYMin.Name = "numYMin";
            this.numYMin.Size = new System.Drawing.Size(92, 26);
            this.numYMin.TabIndex = 12;
            this.numYMin.ValueChanged += new System.EventHandler(this.YMinChanged);
            // 
            // numYMax
            // 
            this.numYMax.Location = new System.Drawing.Point(60, 54);
            this.numYMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numYMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numYMax.Name = "numYMax";
            this.numYMax.Size = new System.Drawing.Size(92, 26);
            this.numYMax.TabIndex = 13;
            this.numYMax.ValueChanged += new System.EventHandler(this.YMaxChanged);
            // 
            // numYInterval
            // 
            this.numYInterval.Location = new System.Drawing.Point(60, 86);
            this.numYInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numYInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numYInterval.Name = "numYInterval";
            this.numYInterval.Size = new System.Drawing.Size(92, 26);
            this.numYInterval.TabIndex = 14;
            this.numYInterval.ValueChanged += new System.EventHandler(this.YIntervalChanged);
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.lbl3);
            this.grpBox2.Controls.Add(this.lbl2);
            this.grpBox2.Controls.Add(this.numXInterval);
            this.grpBox2.Controls.Add(this.lbl1);
            this.grpBox2.Controls.Add(this.numXMin);
            this.grpBox2.Controls.Add(this.numXMax);
            this.grpBox2.ForeColor = System.Drawing.Color.White;
            this.grpBox2.Location = new System.Drawing.Point(10, 52);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(170, 122);
            this.grpBox2.TabIndex = 21;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Ось Ox";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(14, 86);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(42, 20);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Шаг:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(14, 56);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 20);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Max:";
            // 
            // numXInterval
            // 
            this.numXInterval.Location = new System.Drawing.Point(62, 84);
            this.numXInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numXInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numXInterval.Name = "numXInterval";
            this.numXInterval.Size = new System.Drawing.Size(92, 26);
            this.numXInterval.TabIndex = 11;
            this.numXInterval.ValueChanged += new System.EventHandler(this.XIntervalChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(18, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Min:";
            // 
            // numXMin
            // 
            this.numXMin.Location = new System.Drawing.Point(62, 24);
            this.numXMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numXMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numXMin.Name = "numXMin";
            this.numXMin.Size = new System.Drawing.Size(92, 26);
            this.numXMin.TabIndex = 9;
            this.numXMin.ValueChanged += new System.EventHandler(this.XMinChanged);
            // 
            // numXMax
            // 
            this.numXMax.Location = new System.Drawing.Point(62, 54);
            this.numXMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numXMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numXMax.Name = "numXMax";
            this.numXMax.Size = new System.Drawing.Size(92, 26);
            this.numXMax.TabIndex = 10;
            this.numXMax.ValueChanged += new System.EventHandler(this.XMaxChanged);
            // 
            // numDecimalPlaces
            // 
            this.numDecimalPlaces.Location = new System.Drawing.Point(125, 20);
            this.numDecimalPlaces.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDecimalPlaces.Name = "numDecimalPlaces";
            this.numDecimalPlaces.Size = new System.Drawing.Size(55, 26);
            this.numDecimalPlaces.TabIndex = 13;
            this.numDecimalPlaces.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDecimalPlaces.ValueChanged += new System.EventHandler(this.OnDecimalPlacesChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 22);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(113, 20);
            this.lbl5.TabIndex = 14;
            this.lbl5.Text = "Число знаков";
            // 
            // grpBoxNumerics
            // 
            this.grpBoxNumerics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxNumerics.Controls.Add(this.lbl5);
            this.grpBoxNumerics.Controls.Add(this.numDecimalPlaces);
            this.grpBoxNumerics.Controls.Add(this.grpBox2);
            this.grpBoxNumerics.Controls.Add(this.grpBox3);
            this.grpBoxNumerics.ForeColor = System.Drawing.Color.White;
            this.grpBoxNumerics.Location = new System.Drawing.Point(787, 12);
            this.grpBoxNumerics.Name = "grpBoxNumerics";
            this.grpBoxNumerics.Size = new System.Drawing.Size(192, 311);
            this.grpBoxNumerics.TabIndex = 24;
            this.grpBoxNumerics.TabStop = false;
            this.grpBoxNumerics.Text = "Настройки осей";
            // 
            // grpBoxOther
            // 
            this.grpBoxOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxOther.Controls.Add(this.rbAllGraph);
            this.grpBoxOther.Controls.Add(this.cmbSize);
            this.grpBoxOther.Controls.Add(this.rbOneGraph);
            this.grpBoxOther.ForeColor = System.Drawing.Color.White;
            this.grpBoxOther.Location = new System.Drawing.Point(787, 508);
            this.grpBoxOther.Name = "grpBoxOther";
            this.grpBoxOther.Size = new System.Drawing.Size(192, 139);
            this.grpBoxOther.TabIndex = 24;
            this.grpBoxOther.TabStop = false;
            this.grpBoxOther.Text = "Прочее";
            // 
            // rbAllGraph
            // 
            this.rbAllGraph.AutoSize = true;
            this.rbAllGraph.Location = new System.Drawing.Point(15, 103);
            this.rbAllGraph.Name = "rbAllGraph";
            this.rbAllGraph.Size = new System.Drawing.Size(125, 24);
            this.rbAllGraph.TabIndex = 21;
            this.rbAllGraph.TabStop = true;
            this.rbAllGraph.Text = "Все графики";
            this.rbAllGraph.UseVisualStyleBackColor = true;
            // 
            // rbOneGraph
            // 
            this.rbOneGraph.AutoSize = true;
            this.rbOneGraph.Location = new System.Drawing.Point(15, 73);
            this.rbOneGraph.Name = "rbOneGraph";
            this.rbOneGraph.Size = new System.Drawing.Size(147, 24);
            this.rbOneGraph.TabIndex = 22;
            this.rbOneGraph.TabStop = true;
            this.rbOneGraph.Text = "Лучший график";
            this.rbOneGraph.UseVisualStyleBackColor = true;
            this.rbOneGraph.CheckedChanged += new System.EventHandler(this.OnRadioButtonChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveData.BackColor = System.Drawing.Color.White;
            this.btnSaveData.ForeColor = System.Drawing.Color.Black;
            this.btnSaveData.Location = new System.Drawing.Point(787, 767);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(192, 44);
            this.btnSaveData.TabIndex = 25;
            this.btnSaveData.Text = "Сохранить данные";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.OnSaveDataClick);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 2.5D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 7.5D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.Interval = 0.2D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(14, 14);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(767, 701);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(990, 870);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.grpBoxOther);
            this.Controls.Add(this.grpBoxNumerics);
            this.Controls.Add(this.btnLineSettings);
            this.Controls.Add(this.btnSaveGraph);
            this.Controls.Add(this.grpBoxAxis);
            this.Controls.Add(this.chart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.grpBoxAxis.ResumeLayout(false);
            this.grpBoxAxis.PerformLayout();
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYInterval)).EndInit();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalPlaces)).EndInit();
            this.grpBoxNumerics.ResumeLayout(false);
            this.grpBoxNumerics.PerformLayout();
            this.grpBoxOther.ResumeLayout(false);
            this.grpBoxOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.Button btnLineSettings;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.CheckBox chkItalics;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox txtNameY;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox txtNameX;
        private System.Windows.Forms.GroupBox grpBoxAxis;
        private System.Windows.Forms.GroupBox grpBox3;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.NumericUpDown numYMin;
        private System.Windows.Forms.NumericUpDown numYMax;
        private System.Windows.Forms.NumericUpDown numYInterval;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown numXInterval;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NumericUpDown numXMin;
        private System.Windows.Forms.NumericUpDown numXMax;
        private System.Windows.Forms.NumericUpDown numDecimalPlaces;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.GroupBox grpBoxNumerics;
        private System.Windows.Forms.GroupBox grpBoxOther;
        private System.Windows.Forms.RadioButton rbAllGraph;
        private System.Windows.Forms.RadioButton rbOneGraph;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
