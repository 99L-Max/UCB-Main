
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
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.checkBoxItalics = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNameY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameX = new System.Windows.Forms.TextBox();
            this.buttonLineSettings = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.groupBoxAxis = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownYMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownXInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownXMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxNumerics = new System.Windows.Forms.GroupBox();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.radioButtonAllGraph = new System.Windows.Forms.RadioButton();
            this.radioButtonOneGraph = new System.Windows.Forms.RadioButton();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.groupBoxAxis.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecimalPlaces)).BeginInit();
            this.groupBoxNumerics.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveGraph.BackColor = System.Drawing.Color.White;
            this.buttonSaveGraph.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveGraph.Location = new System.Drawing.Point(787, 815);
            this.buttonSaveGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(192, 44);
            this.buttonSaveGraph.TabIndex = 2;
            this.buttonSaveGraph.Text = "Сохранить график";
            this.buttonSaveGraph.UseVisualStyleBackColor = false;
            this.buttonSaveGraph.Click += new System.EventHandler(this.ButtonSaveGraph_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Шрифт";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(86, 36);
            this.numericUpDownFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(78, 26);
            this.numericUpDownFontSize.TabIndex = 17;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // checkBoxItalics
            // 
            this.checkBoxItalics.AutoSize = true;
            this.checkBoxItalics.Location = new System.Drawing.Point(83, 138);
            this.checkBoxItalics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxItalics.Name = "checkBoxItalics";
            this.checkBoxItalics.Size = new System.Drawing.Size(80, 24);
            this.checkBoxItalics.TabIndex = 22;
            this.checkBoxItalics.Text = "Курсив";
            this.checkBoxItalics.UseVisualStyleBackColor = true;
            this.checkBoxItalics.CheckedChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Oy";
            // 
            // textBoxNameY
            // 
            this.textBoxNameY.Location = new System.Drawing.Point(86, 104);
            this.textBoxNameY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNameY.Name = "textBoxNameY";
            this.textBoxNameY.Size = new System.Drawing.Size(78, 26);
            this.textBoxNameY.TabIndex = 20;
            this.textBoxNameY.Leave += new System.EventHandler(this.SetFontAxis);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ox";
            // 
            // textBoxNameX
            // 
            this.textBoxNameX.Location = new System.Drawing.Point(86, 70);
            this.textBoxNameX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNameX.Name = "textBoxNameX";
            this.textBoxNameX.Size = new System.Drawing.Size(78, 26);
            this.textBoxNameX.TabIndex = 18;
            this.textBoxNameX.Leave += new System.EventHandler(this.SetFontAxis);
            // 
            // buttonLineSettings
            // 
            this.buttonLineSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLineSettings.BackColor = System.Drawing.Color.White;
            this.buttonLineSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonLineSettings.Location = new System.Drawing.Point(787, 719);
            this.buttonLineSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLineSettings.Name = "buttonLineSettings";
            this.buttonLineSettings.Size = new System.Drawing.Size(192, 44);
            this.buttonLineSettings.TabIndex = 19;
            this.buttonLineSettings.Text = "Настройки линий";
            this.buttonLineSettings.UseVisualStyleBackColor = false;
            this.buttonLineSettings.Click += new System.EventHandler(this.ButtonLineSettings_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSize.BackColor = System.Drawing.Color.White;
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "16:9",
            "16:10",
            "4:3",
            "3:2"});
            this.comboBoxSize.Location = new System.Drawing.Point(15, 38);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(165, 28);
            this.comboBoxSize.TabIndex = 20;
            // 
            // groupBoxAxis
            // 
            this.groupBoxAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAxis.Controls.Add(this.checkBoxItalics);
            this.groupBoxAxis.Controls.Add(this.numericUpDownFontSize);
            this.groupBoxAxis.Controls.Add(this.label10);
            this.groupBoxAxis.Controls.Add(this.label8);
            this.groupBoxAxis.Controls.Add(this.textBoxNameY);
            this.groupBoxAxis.Controls.Add(this.textBoxNameX);
            this.groupBoxAxis.Controls.Add(this.label9);
            this.groupBoxAxis.ForeColor = System.Drawing.Color.White;
            this.groupBoxAxis.Location = new System.Drawing.Point(787, 329);
            this.groupBoxAxis.Name = "groupBoxAxis";
            this.groupBoxAxis.Size = new System.Drawing.Size(192, 173);
            this.groupBoxAxis.TabIndex = 23;
            this.groupBoxAxis.TabStop = false;
            this.groupBoxAxis.Text = "Подписи";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.numericUpDownYMin);
            this.groupBox3.Controls.Add(this.numericUpDownYMax);
            this.groupBox3.Controls.Add(this.numericUpDownYInterval);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 122);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ось Oy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Max:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Шаг:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Min:";
            // 
            // numericUpDownYMin
            // 
            this.numericUpDownYMin.Location = new System.Drawing.Point(60, 24);
            this.numericUpDownYMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownYMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownYMin.Name = "numericUpDownYMin";
            this.numericUpDownYMin.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownYMin.TabIndex = 12;
            this.numericUpDownYMin.ValueChanged += new System.EventHandler(this.NumericUpDownYMin_ValueChanged);
            // 
            // numericUpDownYMax
            // 
            this.numericUpDownYMax.Location = new System.Drawing.Point(60, 54);
            this.numericUpDownYMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownYMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownYMax.Name = "numericUpDownYMax";
            this.numericUpDownYMax.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownYMax.TabIndex = 13;
            this.numericUpDownYMax.ValueChanged += new System.EventHandler(this.NumericUpDownYMax_ValueChanged);
            // 
            // numericUpDownYInterval
            // 
            this.numericUpDownYInterval.Location = new System.Drawing.Point(60, 86);
            this.numericUpDownYInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownYInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownYInterval.Name = "numericUpDownYInterval";
            this.numericUpDownYInterval.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownYInterval.TabIndex = 14;
            this.numericUpDownYInterval.ValueChanged += new System.EventHandler(this.NumericUpDownYInterval_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownXInterval);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownXMin);
            this.groupBox2.Controls.Add(this.numericUpDownXMax);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 122);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ось Ox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шаг:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Max:";
            // 
            // numericUpDownXInterval
            // 
            this.numericUpDownXInterval.Location = new System.Drawing.Point(62, 84);
            this.numericUpDownXInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownXInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXInterval.Name = "numericUpDownXInterval";
            this.numericUpDownXInterval.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownXInterval.TabIndex = 11;
            this.numericUpDownXInterval.ValueChanged += new System.EventHandler(this.NumericUpDownXInterval_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min:";
            // 
            // numericUpDownXMin
            // 
            this.numericUpDownXMin.Location = new System.Drawing.Point(62, 24);
            this.numericUpDownXMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownXMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXMin.Name = "numericUpDownXMin";
            this.numericUpDownXMin.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownXMin.TabIndex = 9;
            this.numericUpDownXMin.ValueChanged += new System.EventHandler(this.NumericUpDownXMin_ValueChanged);
            // 
            // numericUpDownXMax
            // 
            this.numericUpDownXMax.Location = new System.Drawing.Point(62, 54);
            this.numericUpDownXMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownXMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXMax.Name = "numericUpDownXMax";
            this.numericUpDownXMax.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownXMax.TabIndex = 10;
            this.numericUpDownXMax.ValueChanged += new System.EventHandler(this.NumericUpDownXMax_ValueChanged);
            // 
            // numericUpDownDecimalPlaces
            // 
            this.numericUpDownDecimalPlaces.Location = new System.Drawing.Point(125, 20);
            this.numericUpDownDecimalPlaces.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDecimalPlaces.Name = "numericUpDownDecimalPlaces";
            this.numericUpDownDecimalPlaces.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownDecimalPlaces.TabIndex = 13;
            this.numericUpDownDecimalPlaces.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDecimalPlaces.ValueChanged += new System.EventHandler(this.NumericUpDownDecimalPlaces_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Число знаков";
            // 
            // groupBoxNumerics
            // 
            this.groupBoxNumerics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNumerics.Controls.Add(this.label5);
            this.groupBoxNumerics.Controls.Add(this.numericUpDownDecimalPlaces);
            this.groupBoxNumerics.Controls.Add(this.groupBox2);
            this.groupBoxNumerics.Controls.Add(this.groupBox3);
            this.groupBoxNumerics.ForeColor = System.Drawing.Color.White;
            this.groupBoxNumerics.Location = new System.Drawing.Point(787, 12);
            this.groupBoxNumerics.Name = "groupBoxNumerics";
            this.groupBoxNumerics.Size = new System.Drawing.Size(192, 311);
            this.groupBoxNumerics.TabIndex = 24;
            this.groupBoxNumerics.TabStop = false;
            this.groupBoxNumerics.Text = "Настройки осей";
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOther.Controls.Add(this.radioButtonAllGraph);
            this.groupBoxOther.Controls.Add(this.comboBoxSize);
            this.groupBoxOther.Controls.Add(this.radioButtonOneGraph);
            this.groupBoxOther.ForeColor = System.Drawing.Color.White;
            this.groupBoxOther.Location = new System.Drawing.Point(787, 508);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(192, 139);
            this.groupBoxOther.TabIndex = 24;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "Прочее";
            // 
            // radioButtonAllGraph
            // 
            this.radioButtonAllGraph.AutoSize = true;
            this.radioButtonAllGraph.Location = new System.Drawing.Point(15, 103);
            this.radioButtonAllGraph.Name = "radioButtonAllGraph";
            this.radioButtonAllGraph.Size = new System.Drawing.Size(125, 24);
            this.radioButtonAllGraph.TabIndex = 21;
            this.radioButtonAllGraph.TabStop = true;
            this.radioButtonAllGraph.Text = "Все графики";
            this.radioButtonAllGraph.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneGraph
            // 
            this.radioButtonOneGraph.AutoSize = true;
            this.radioButtonOneGraph.Location = new System.Drawing.Point(15, 73);
            this.radioButtonOneGraph.Name = "radioButtonOneGraph";
            this.radioButtonOneGraph.Size = new System.Drawing.Size(147, 24);
            this.radioButtonOneGraph.TabIndex = 22;
            this.radioButtonOneGraph.TabStop = true;
            this.radioButtonOneGraph.Text = "Лучший график";
            this.radioButtonOneGraph.UseVisualStyleBackColor = true;
            this.radioButtonOneGraph.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveData.BackColor = System.Drawing.Color.White;
            this.buttonSaveData.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveData.Location = new System.Drawing.Point(787, 767);
            this.buttonSaveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(192, 44);
            this.buttonSaveData.TabIndex = 25;
            this.buttonSaveData.Text = "Сохранить данные";
            this.buttonSaveData.UseVisualStyleBackColor = false;
            this.buttonSaveData.Click += new System.EventHandler(this.ButtonSaveData_Click);
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
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.groupBoxNumerics);
            this.Controls.Add(this.buttonLineSettings);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.groupBoxAxis);
            this.Controls.Add(this.chart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.groupBoxAxis.ResumeLayout(false);
            this.groupBoxAxis.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecimalPlaces)).EndInit();
            this.groupBoxNumerics.ResumeLayout(false);
            this.groupBoxNumerics.PerformLayout();
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Button buttonLineSettings;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxItalics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNameX;
        private System.Windows.Forms.GroupBox groupBoxAxis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownYMin;
        private System.Windows.Forms.NumericUpDown numericUpDownYMax;
        private System.Windows.Forms.NumericUpDown numericUpDownYInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownXInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownXMin;
        private System.Windows.Forms.NumericUpDown numericUpDownXMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDecimalPlaces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxNumerics;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.RadioButton radioButtonAllGraph;
        private System.Windows.Forms.RadioButton radioButtonOneGraph;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
