
namespace UCB
{
    partial class FormModeling
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this._grpTypeBandit = new System.Windows.Forms.GroupBox();
            this._lbl25 = new System.Windows.Forms.Label();
            this._cmbTypeProcessingData = new System.Windows.Forms.ComboBox();
            this._lbl17 = new System.Windows.Forms.Label();
            this._cmbDistribution = new System.Windows.Forms.ComboBox();
            this._lbl24 = new System.Windows.Forms.Label();
            this._lbl20 = new System.Windows.Forms.Label();
            this._numBanditArms = new System.Windows.Forms.NumericUpDown();
            this._numMaxVariance = new System.Windows.Forms.NumericUpDown();
            this._lbl4 = new System.Windows.Forms.Label();
            this._lblMathExp = new System.Windows.Forms.Label();
            this._numExpectation = new System.Windows.Forms.NumericUpDown();
            this._numNumberSimulations = new System.Windows.Forms.NumericUpDown();
            this._numBatchSize = new System.Windows.Forms.NumericUpDown();
            this._lbl5 = new System.Windows.Forms.Label();
            this._numNumberBatches = new System.Windows.Forms.NumericUpDown();
            this._lbl3 = new System.Windows.Forms.Label();
            this._grpBordersDeviationExp = new System.Windows.Forms.GroupBox();
            this._numDeviationCount = new System.Windows.Forms.NumericUpDown();
            this._lbl8 = new System.Windows.Forms.Label();
            this._numDeviationDelta = new System.Windows.Forms.NumericUpDown();
            this._lbl9 = new System.Windows.Forms.Label();
            this._numDeviationStart = new System.Windows.Forms.NumericUpDown();
            this._lbl10 = new System.Windows.Forms.Label();
            this._txtFinalDeviation = new System.Windows.Forms.TextBox();
            this._lbl11 = new System.Windows.Forms.Label();
            this._grpParameter = new System.Windows.Forms.GroupBox();
            this._numParameterStart = new System.Windows.Forms.NumericUpDown();
            this.numParameterDelta = new System.Windows.Forms.NumericUpDown();
            this._lbl12 = new System.Windows.Forms.Label();
            this._lbl13 = new System.Windows.Forms.Label();
            this._lbl14 = new System.Windows.Forms.Label();
            this._numBanditsCount = new System.Windows.Forms.NumericUpDown();
            this._numCountThreads = new System.Windows.Forms.NumericUpDown();
            this._lbl16 = new System.Windows.Forms.Label();
            this._btnStart = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._grpButtons = new System.Windows.Forms.GroupBox();
            this._btnNew = new System.Windows.Forms.Button();
            this._btnOpen = new System.Windows.Forms.Button();
            this._btnPause = new System.Windows.Forms.Button();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._chkSoundPlay = new System.Windows.Forms.CheckBox();
            this._grpGeneralParameters = new System.Windows.Forms.GroupBox();
            this._chkVariancesKnown = new System.Windows.Forms.CheckBox();
            this._grpHorizon = new System.Windows.Forms.GroupBox();
            this._grpSimulationSettings = new System.Windows.Forms.GroupBox();
            this._lblDialog = new System.Windows.Forms.Label();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._grpTypeBandit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numBanditArms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numMaxVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numExpectation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNumberSimulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBatchSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNumberBatches)).BeginInit();
            this._grpBordersDeviationExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDeviationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDeviationDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDeviationStart)).BeginInit();
            this._grpParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numParameterStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParameterDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBanditsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numCountThreads)).BeginInit();
            this._grpButtons.SuspendLayout();
            this._grpGeneralParameters.SuspendLayout();
            this._grpHorizon.SuspendLayout();
            this._grpSimulationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _grpTypeBandit
            // 
            this._grpTypeBandit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grpTypeBandit.Controls.Add(this._lbl25);
            this._grpTypeBandit.Controls.Add(this._cmbTypeProcessingData);
            this._grpTypeBandit.Controls.Add(this._lbl17);
            this._grpTypeBandit.Controls.Add(this._cmbDistribution);
            this._grpTypeBandit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpTypeBandit.ForeColor = System.Drawing.Color.White;
            this._grpTypeBandit.Location = new System.Drawing.Point(557, 11);
            this._grpTypeBandit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._grpTypeBandit.Name = "_grpTypeBandit";
            this._grpTypeBandit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._grpTypeBandit.Size = new System.Drawing.Size(531, 94);
            this._grpTypeBandit.TabIndex = 0;
            this._grpTypeBandit.TabStop = false;
            this._grpTypeBandit.Text = "Тип бандита";
            // 
            // _lbl25
            // 
            this._lbl25.AutoSize = true;
            this._lbl25.Location = new System.Drawing.Point(131, 58);
            this._lbl25.Name = "_lbl25";
            this._lbl25.Size = new System.Drawing.Size(124, 20);
            this._lbl25.TabIndex = 34;
            this._lbl25.Text = "Тип обработки:";
            // 
            // _cmbTypeProcessingData
            // 
            this._cmbTypeProcessingData.BackColor = System.Drawing.Color.White;
            this._cmbTypeProcessingData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbTypeProcessingData.Items.AddRange(new object[] {
            "Число данных",
            "Размер пакета"});
            this._cmbTypeProcessingData.Location = new System.Drawing.Point(267, 55);
            this._cmbTypeProcessingData.Name = "_cmbTypeProcessingData";
            this._cmbTypeProcessingData.Size = new System.Drawing.Size(146, 28);
            this._cmbTypeProcessingData.TabIndex = 28;
            // 
            // _lbl17
            // 
            this._lbl17.AutoSize = true;
            this._lbl17.Location = new System.Drawing.Point(122, 23);
            this._lbl17.Name = "_lbl17";
            this._lbl17.Size = new System.Drawing.Size(133, 20);
            this._lbl17.TabIndex = 13;
            this._lbl17.Text = "Распределение:";
            // 
            // _cmbDistribution
            // 
            this._cmbDistribution.BackColor = System.Drawing.Color.White;
            this._cmbDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbDistribution.Items.AddRange(new object[] {
            "Гаусса",
            "Бернулли"});
            this._cmbDistribution.Location = new System.Drawing.Point(267, 20);
            this._cmbDistribution.Name = "_cmbDistribution";
            this._cmbDistribution.Size = new System.Drawing.Size(146, 28);
            this._cmbDistribution.TabIndex = 2;
            this._cmbDistribution.SelectedIndexChanged += new System.EventHandler(this.OnDistributionChanged);
            // 
            // _lbl24
            // 
            this._lbl24.AutoSize = true;
            this._lbl24.Location = new System.Drawing.Point(18, 83);
            this._lbl24.Name = "_lbl24";
            this._lbl24.Size = new System.Drawing.Size(160, 20);
            this._lbl24.TabIndex = 32;
            this._lbl24.Text = "Макс.  дисперсия D:";
            // 
            // _lbl20
            // 
            this._lbl20.AutoSize = true;
            this._lbl20.Location = new System.Drawing.Point(77, 23);
            this._lbl20.Name = "_lbl20";
            this._lbl20.Size = new System.Drawing.Size(101, 20);
            this._lbl20.TabIndex = 29;
            this._lbl20.Text = "Число рук J:";
            // 
            // _numBanditArms
            // 
            this._numBanditArms.Location = new System.Drawing.Point(184, 21);
            this._numBanditArms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numBanditArms.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._numBanditArms.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numBanditArms.Name = "_numBanditArms";
            this._numBanditArms.Size = new System.Drawing.Size(65, 26);
            this._numBanditArms.TabIndex = 30;
            this._numBanditArms.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numBanditArms.ValueChanged += new System.EventHandler(this.OnBanditArmsChanged);
            // 
            // _numMaxVariance
            // 
            this._numMaxVariance.DecimalPlaces = 2;
            this._numMaxVariance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numMaxVariance.Location = new System.Drawing.Point(184, 81);
            this._numMaxVariance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numMaxVariance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numMaxVariance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numMaxVariance.Name = "_numMaxVariance";
            this._numMaxVariance.Size = new System.Drawing.Size(65, 26);
            this._numMaxVariance.TabIndex = 33;
            this._numMaxVariance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _lbl4
            // 
            this._lbl4.AutoSize = true;
            this._lbl4.Location = new System.Drawing.Point(38, 19);
            this._lbl4.Name = "_lbl4";
            this._lbl4.Size = new System.Drawing.Size(141, 20);
            this._lbl4.TabIndex = 7;
            this._lbl4.Text = "Число пакетов K:";
            // 
            // _lblMathExp
            // 
            this._lblMathExp.AutoSize = true;
            this._lblMathExp.Location = new System.Drawing.Point(33, 53);
            this._lblMathExp.Name = "_lblMathExp";
            this._lblMathExp.Size = new System.Drawing.Size(145, 20);
            this._lblMathExp.TabIndex = 1;
            this._lblMathExp.Text = "Мат. ожидание m:";
            // 
            // _numMathExp
            // 
            this._numExpectation.DecimalPlaces = 2;
            this._numExpectation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numExpectation.Location = new System.Drawing.Point(184, 51);
            this._numExpectation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numExpectation.Name = "_numMathExp";
            this._numExpectation.Size = new System.Drawing.Size(65, 26);
            this._numExpectation.TabIndex = 2;
            // 
            // _numNumberSimulations
            // 
            this._numNumberSimulations.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this._numNumberSimulations.Location = new System.Drawing.Point(171, 81);
            this._numNumberSimulations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numNumberSimulations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._numNumberSimulations.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this._numNumberSimulations.Name = "_numNumberSimulations";
            this._numNumberSimulations.ReadOnly = true;
            this._numNumberSimulations.Size = new System.Drawing.Size(87, 26);
            this._numNumberSimulations.TabIndex = 6;
            this._numNumberSimulations.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // _numBatchSize
            // 
            this._numBatchSize.Location = new System.Drawing.Point(184, 48);
            this._numBatchSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numBatchSize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._numBatchSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numBatchSize.Name = "_numBatchSize";
            this._numBatchSize.Size = new System.Drawing.Size(65, 26);
            this._numBatchSize.TabIndex = 8;
            this._numBatchSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._numBatchSize.ValueChanged += new System.EventHandler(this.OnBatchSizeChanged);
            // 
            // _lbl5
            // 
            this._lbl5.AutoSize = true;
            this._lbl5.Location = new System.Drawing.Point(35, 50);
            this._lbl5.Name = "_lbl5";
            this._lbl5.Size = new System.Drawing.Size(143, 20);
            this._lbl5.TabIndex = 9;
            this._lbl5.Text = "Размер пакета M:";
            // 
            // _numNumberBatches
            // 
            this._numNumberBatches.Location = new System.Drawing.Point(184, 17);
            this._numNumberBatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numNumberBatches.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._numNumberBatches.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._numNumberBatches.Name = "_numNumberBatches";
            this._numNumberBatches.Size = new System.Drawing.Size(65, 26);
            this._numNumberBatches.TabIndex = 7;
            this._numNumberBatches.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numNumberBatches.ValueChanged += new System.EventHandler(this.OnNumberBatchesChanged);
            // 
            // _lbl3
            // 
            this._lbl3.AutoSize = true;
            this._lbl3.Location = new System.Drawing.Point(18, 83);
            this._lbl3.Name = "_lbl3";
            this._lbl3.Size = new System.Drawing.Size(146, 20);
            this._lbl3.TabIndex = 5;
            this._lbl3.Text = "Число симуляций:";
            // 
            // _grpBordersDeviationExp
            // 
            this._grpBordersDeviationExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grpBordersDeviationExp.Controls.Add(this._numDeviationCount);
            this._grpBordersDeviationExp.Controls.Add(this._lbl8);
            this._grpBordersDeviationExp.Controls.Add(this._numDeviationDelta);
            this._grpBordersDeviationExp.Controls.Add(this._lbl9);
            this._grpBordersDeviationExp.Controls.Add(this._numDeviationStart);
            this._grpBordersDeviationExp.Controls.Add(this._lbl10);
            this._grpBordersDeviationExp.Controls.Add(this._txtFinalDeviation);
            this._grpBordersDeviationExp.Controls.Add(this._lbl11);
            this._grpBordersDeviationExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpBordersDeviationExp.ForeColor = System.Drawing.Color.White;
            this._grpBordersDeviationExp.Location = new System.Drawing.Point(824, 110);
            this._grpBordersDeviationExp.Name = "_grpBordersDeviationExp";
            this._grpBordersDeviationExp.Size = new System.Drawing.Size(264, 151);
            this._grpBordersDeviationExp.TabIndex = 2;
            this._grpBordersDeviationExp.TabStop = false;
            this._grpBordersDeviationExp.Text = "Откл. от мат. ождидания d";
            // 
            // _numDeviationCount
            // 
            this._numDeviationCount.Location = new System.Drawing.Point(193, 81);
            this._numDeviationCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numDeviationCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._numDeviationCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numDeviationCount.Name = "_numDeviationCount";
            this._numDeviationCount.Size = new System.Drawing.Size(65, 26);
            this._numDeviationCount.TabIndex = 15;
            this._numDeviationCount.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this._numDeviationCount.ValueChanged += new System.EventHandler(this.OnDeviationChanged);
            // 
            // _lbl8
            // 
            this._lbl8.AutoSize = true;
            this._lbl8.Location = new System.Drawing.Point(14, 23);
            this._lbl8.Name = "_lbl8";
            this._lbl8.Size = new System.Drawing.Size(173, 20);
            this._lbl8.TabIndex = 7;
            this._lbl8.Text = "Начальное значение:";
            // 
            // _numDeviationDelta
            // 
            this._numDeviationDelta.DecimalPlaces = 1;
            this._numDeviationDelta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._numDeviationDelta.Location = new System.Drawing.Point(193, 51);
            this._numDeviationDelta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numDeviationDelta.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numDeviationDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._numDeviationDelta.Name = "_numDeviationDelta";
            this._numDeviationDelta.Size = new System.Drawing.Size(65, 26);
            this._numDeviationDelta.TabIndex = 14;
            this._numDeviationDelta.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this._numDeviationDelta.ValueChanged += new System.EventHandler(this.OnDeviationChanged);
            // 
            // _lbl9
            // 
            this._lbl9.AutoSize = true;
            this._lbl9.Location = new System.Drawing.Point(59, 52);
            this._lbl9.Name = "_lbl9";
            this._lbl9.Size = new System.Drawing.Size(128, 20);
            this._lbl9.TabIndex = 8;
            this._lbl9.Text = "Шаг изменения:";
            // 
            // _numDeviationStart
            // 
            this._numDeviationStart.DecimalPlaces = 1;
            this._numDeviationStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._numDeviationStart.Location = new System.Drawing.Point(193, 21);
            this._numDeviationStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numDeviationStart.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this._numDeviationStart.Name = "_numDeviationStart";
            this._numDeviationStart.Size = new System.Drawing.Size(65, 26);
            this._numDeviationStart.TabIndex = 13;
            this._numDeviationStart.ValueChanged += new System.EventHandler(this.OnDeviationChanged);
            // 
            // _lbl10
            // 
            this._lbl10.AutoSize = true;
            this._lbl10.Location = new System.Drawing.Point(78, 83);
            this._lbl10.Name = "_lbl10";
            this._lbl10.Size = new System.Drawing.Size(109, 20);
            this._lbl10.TabIndex = 9;
            this._lbl10.Text = "Число точек:";
            // 
            // _txtFinalDeviation
            // 
            this._txtFinalDeviation.Location = new System.Drawing.Point(193, 112);
            this._txtFinalDeviation.Name = "_txtFinalDeviation";
            this._txtFinalDeviation.ReadOnly = true;
            this._txtFinalDeviation.Size = new System.Drawing.Size(65, 26);
            this._txtFinalDeviation.TabIndex = 13;
            // 
            // _lbl11
            // 
            this._lbl11.AutoSize = true;
            this._lbl11.Location = new System.Drawing.Point(26, 115);
            this._lbl11.Name = "_lbl11";
            this._lbl11.Size = new System.Drawing.Size(161, 20);
            this._lbl11.TabIndex = 10;
            this._lbl11.Text = "Конечное значение:";
            // 
            // _grpParameter
            // 
            this._grpParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grpParameter.Controls.Add(this._numParameterStart);
            this._grpParameter.Controls.Add(this.numParameterDelta);
            this._grpParameter.Controls.Add(this._lbl12);
            this._grpParameter.Controls.Add(this._lbl13);
            this._grpParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpParameter.ForeColor = System.Drawing.Color.White;
            this._grpParameter.Location = new System.Drawing.Point(557, 359);
            this._grpParameter.Name = "_grpParameter";
            this._grpParameter.Size = new System.Drawing.Size(255, 94);
            this._grpParameter.TabIndex = 3;
            this._grpParameter.TabStop = false;
            this._grpParameter.Text = "Параметр стратегии а";
            // 
            // _numParameterStart
            // 
            this._numParameterStart.DecimalPlaces = 2;
            this._numParameterStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numParameterStart.Location = new System.Drawing.Point(184, 24);
            this._numParameterStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numParameterStart.Name = "_numParameterStart";
            this._numParameterStart.Size = new System.Drawing.Size(65, 26);
            this._numParameterStart.TabIndex = 20;
            this._numParameterStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numParameterStart.ValueChanged += new System.EventHandler(this.OnParametersChanged);
            // 
            // numParameterDelta
            // 
            this.numParameterDelta.DecimalPlaces = 2;
            this.numParameterDelta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numParameterDelta.Location = new System.Drawing.Point(184, 56);
            this.numParameterDelta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numParameterDelta.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numParameterDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numParameterDelta.Name = "numParameterDelta";
            this.numParameterDelta.Size = new System.Drawing.Size(65, 26);
            this.numParameterDelta.TabIndex = 22;
            this.numParameterDelta.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numParameterDelta.ValueChanged += new System.EventHandler(this.OnParametersChanged);
            // 
            // _lbl12
            // 
            this._lbl12.AutoSize = true;
            this._lbl12.Location = new System.Drawing.Point(6, 26);
            this._lbl12.Name = "_lbl12";
            this._lbl12.Size = new System.Drawing.Size(173, 20);
            this._lbl12.TabIndex = 16;
            this._lbl12.Text = "Начальное значение:";
            // 
            // _lbl13
            // 
            this._lbl13.AutoSize = true;
            this._lbl13.Location = new System.Drawing.Point(50, 58);
            this._lbl13.Name = "_lbl13";
            this._lbl13.Size = new System.Drawing.Size(128, 20);
            this._lbl13.TabIndex = 17;
            this._lbl13.Text = "Шаг изменения:";
            // 
            // _lbl14
            // 
            this._lbl14.AutoSize = true;
            this._lbl14.Location = new System.Drawing.Point(26, 23);
            this._lbl14.Name = "_lbl14";
            this._lbl14.Size = new System.Drawing.Size(139, 20);
            this._lbl14.TabIndex = 18;
            this._lbl14.Text = "Число бандитов:";
            // 
            // _numBanditsCount
            // 
            this._numBanditsCount.Location = new System.Drawing.Point(171, 21);
            this._numBanditsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numBanditsCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._numBanditsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numBanditsCount.Name = "_numBanditsCount";
            this._numBanditsCount.Size = new System.Drawing.Size(87, 26);
            this._numBanditsCount.TabIndex = 23;
            this._numBanditsCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._numBanditsCount.ValueChanged += new System.EventHandler(this.OnBanditsCountChanged);
            // 
            // _numCountThreads
            // 
            this._numCountThreads.Location = new System.Drawing.Point(171, 51);
            this._numCountThreads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numCountThreads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numCountThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numCountThreads.Name = "_numCountThreads";
            this._numCountThreads.Size = new System.Drawing.Size(87, 26);
            this._numCountThreads.TabIndex = 25;
            this._numCountThreads.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _lbl16
            // 
            this._lbl16.AutoSize = true;
            this._lbl16.Location = new System.Drawing.Point(37, 53);
            this._lbl16.Name = "_lbl16";
            this._lbl16.Size = new System.Drawing.Size(127, 20);
            this._lbl16.TabIndex = 24;
            this._lbl16.Text = "Число потоков:";
            // 
            // _btnStart
            // 
            this._btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnStart.BackColor = System.Drawing.Color.White;
            this._btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._btnStart.ForeColor = System.Drawing.Color.Black;
            this._btnStart.Location = new System.Drawing.Point(21, 78);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(222, 45);
            this._btnStart.TabIndex = 4;
            this._btnStart.Text = "Запуск";
            this._btnStart.UseVisualStyleBackColor = false;
            this._btnStart.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnStart.Click += new System.EventHandler(this.OnStartClick);
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnSave.BackColor = System.Drawing.Color.White;
            this._btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._btnSave.ForeColor = System.Drawing.Color.Black;
            this._btnSave.Location = new System.Drawing.Point(21, 278);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(222, 45);
            this._btnSave.TabIndex = 7;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnCancel.BackColor = System.Drawing.Color.White;
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._btnCancel.ForeColor = System.Drawing.Color.Black;
            this._btnCancel.Location = new System.Drawing.Point(21, 178);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(222, 45);
            this._btnCancel.TabIndex = 6;
            this._btnCancel.Text = "Отмена";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // _grpButtons
            // 
            this._grpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpButtons.Controls.Add(this._btnNew);
            this._grpButtons.Controls.Add(this._btnOpen);
            this._grpButtons.Controls.Add(this._btnPause);
            this._grpButtons.Controls.Add(this._btnStart);
            this._grpButtons.Controls.Add(this._btnCancel);
            this._grpButtons.Controls.Add(this._btnSave);
            this._grpButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpButtons.ForeColor = System.Drawing.Color.White;
            this._grpButtons.Location = new System.Drawing.Point(824, 424);
            this._grpButtons.Name = "_grpButtons";
            this._grpButtons.Size = new System.Drawing.Size(264, 335);
            this._grpButtons.TabIndex = 8;
            this._grpButtons.TabStop = false;
            this._grpButtons.Text = "Управление";
            // 
            // _btnNew
            // 
            this._btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnNew.BackColor = System.Drawing.Color.White;
            this._btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._btnNew.ForeColor = System.Drawing.Color.Black;
            this._btnNew.Location = new System.Drawing.Point(21, 28);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(222, 45);
            this._btnNew.TabIndex = 47;
            this._btnNew.Text = "Новый";
            this._btnNew.UseVisualStyleBackColor = false;
            this._btnNew.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnNew.Click += new System.EventHandler(this.OnNewClick);
            // 
            // _btnOpen
            // 
            this._btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnOpen.BackColor = System.Drawing.Color.White;
            this._btnOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._btnOpen.ForeColor = System.Drawing.Color.Black;
            this._btnOpen.Location = new System.Drawing.Point(21, 228);
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.Size = new System.Drawing.Size(222, 45);
            this._btnOpen.TabIndex = 46;
            this._btnOpen.Text = "Открыть";
            this._btnOpen.UseVisualStyleBackColor = false;
            this._btnOpen.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnOpen.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // _btnPause
            // 
            this._btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnPause.BackColor = System.Drawing.Color.White;
            this._btnPause.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this._btnPause.ForeColor = System.Drawing.Color.Black;
            this._btnPause.Location = new System.Drawing.Point(21, 128);
            this._btnPause.Name = "_btnPause";
            this._btnPause.Size = new System.Drawing.Size(222, 45);
            this._btnPause.TabIndex = 45;
            this._btnPause.Text = "Пауза";
            this._btnPause.UseVisualStyleBackColor = false;
            this._btnPause.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnPause.Click += new System.EventHandler(this.OnPauseClick);
            // 
            // _progressBar
            // 
            this._progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._progressBar.Location = new System.Drawing.Point(12, 771);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(1081, 23);
            this._progressBar.TabIndex = 10;
            this._progressBar.Visible = false;
            // 
            // _chkSoundPlay
            // 
            this._chkSoundPlay.AutoSize = true;
            this._chkSoundPlay.Checked = true;
            this._chkSoundPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkSoundPlay.Location = new System.Drawing.Point(78, 114);
            this._chkSoundPlay.Name = "_chkSoundPlay";
            this._chkSoundPlay.Size = new System.Drawing.Size(180, 24);
            this._chkSoundPlay.TabIndex = 0;
            this._chkSoundPlay.Text = "Сигнал завершения";
            this._chkSoundPlay.UseVisualStyleBackColor = false;
            this._chkSoundPlay.CheckedChanged += new System.EventHandler(this.OnChkPlaySoundCheckedChanged);
            // 
            // _grpGeneralParameters
            // 
            this._grpGeneralParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grpGeneralParameters.Controls.Add(this._chkVariancesKnown);
            this._grpGeneralParameters.Controls.Add(this._numBanditArms);
            this._grpGeneralParameters.Controls.Add(this._numExpectation);
            this._grpGeneralParameters.Controls.Add(this._lbl24);
            this._grpGeneralParameters.Controls.Add(this._lblMathExp);
            this._grpGeneralParameters.Controls.Add(this._numMaxVariance);
            this._grpGeneralParameters.Controls.Add(this._lbl20);
            this._grpGeneralParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpGeneralParameters.ForeColor = System.Drawing.Color.White;
            this._grpGeneralParameters.Location = new System.Drawing.Point(557, 110);
            this._grpGeneralParameters.Name = "_grpGeneralParameters";
            this._grpGeneralParameters.Size = new System.Drawing.Size(255, 151);
            this._grpGeneralParameters.TabIndex = 42;
            this._grpGeneralParameters.TabStop = false;
            this._grpGeneralParameters.Text = "Общие параметры";
            // 
            // _chkVariancesKnown
            // 
            this._chkVariancesKnown.AutoSize = true;
            this._chkVariancesKnown.Checked = true;
            this._chkVariancesKnown.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkVariancesKnown.Location = new System.Drawing.Point(63, 115);
            this._chkVariancesKnown.Name = "_chkVariancesKnown";
            this._chkVariancesKnown.Size = new System.Drawing.Size(186, 24);
            this._chkVariancesKnown.TabIndex = 34;
            this._chkVariancesKnown.Text = "Дисперсии известны";
            this._chkVariancesKnown.UseVisualStyleBackColor = true;
            // 
            // _grpHorizon
            // 
            this._grpHorizon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grpHorizon.Controls.Add(this._numNumberBatches);
            this._grpHorizon.Controls.Add(this._lbl5);
            this._grpHorizon.Controls.Add(this._numBatchSize);
            this._grpHorizon.Controls.Add(this._lbl4);
            this._grpHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpHorizon.ForeColor = System.Drawing.Color.White;
            this._grpHorizon.Location = new System.Drawing.Point(557, 267);
            this._grpHorizon.Name = "_grpHorizon";
            this._grpHorizon.Size = new System.Drawing.Size(255, 86);
            this._grpHorizon.TabIndex = 43;
            this._grpHorizon.TabStop = false;
            this._grpHorizon.Text = "Горизонт";
            // 
            // _grpSimulationSettings
            // 
            this._grpSimulationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grpSimulationSettings.Controls.Add(this._chkSoundPlay);
            this._grpSimulationSettings.Controls.Add(this._numCountThreads);
            this._grpSimulationSettings.Controls.Add(this._lbl3);
            this._grpSimulationSettings.Controls.Add(this._numNumberSimulations);
            this._grpSimulationSettings.Controls.Add(this._lbl14);
            this._grpSimulationSettings.Controls.Add(this._lbl16);
            this._grpSimulationSettings.Controls.Add(this._numBanditsCount);
            this._grpSimulationSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._grpSimulationSettings.ForeColor = System.Drawing.Color.White;
            this._grpSimulationSettings.Location = new System.Drawing.Point(824, 267);
            this._grpSimulationSettings.Name = "_grpSimulationSettings";
            this._grpSimulationSettings.Size = new System.Drawing.Size(264, 151);
            this._grpSimulationSettings.TabIndex = 44;
            this._grpSimulationSettings.TabStop = false;
            this._grpSimulationSettings.Text = "Настройки симуляций";
            // 
            // _lblDialog
            // 
            this._lblDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblDialog.BackColor = System.Drawing.Color.White;
            this._lblDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this._lblDialog.ForeColor = System.Drawing.Color.Black;
            this._lblDialog.Location = new System.Drawing.Point(557, 456);
            this._lblDialog.Name = "_lblDialog";
            this._lblDialog.Size = new System.Drawing.Size(255, 300);
            this._lblDialog.TabIndex = 47;
            this._lblDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToResizeColumns = false;
            this._dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            this._dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this._dataGridView.EnableHeadersVisualStyles = false;
            this._dataGridView.Location = new System.Drawing.Point(12, 12);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BlueViolet;
            this._dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridView.RowTemplate.Height = 30;
            this._dataGridView.Size = new System.Drawing.Size(539, 747);
            this._dataGridView.TabIndex = 48;
            this._dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            this._dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OnDataError);
            this._dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // FormModeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1100, 808);
            this.Controls.Add(this._lblDialog);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._grpSimulationSettings);
            this.Controls.Add(this._grpHorizon);
            this.Controls.Add(this._grpGeneralParameters);
            this.Controls.Add(this._grpButtons);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._grpParameter);
            this.Controls.Add(this._grpBordersDeviationExp);
            this.Controls.Add(this._grpTypeBandit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormModeling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCB";
            this._grpTypeBandit.ResumeLayout(false);
            this._grpTypeBandit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numBanditArms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numMaxVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numExpectation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNumberSimulations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBatchSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNumberBatches)).EndInit();
            this._grpBordersDeviationExp.ResumeLayout(false);
            this._grpBordersDeviationExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDeviationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDeviationDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDeviationStart)).EndInit();
            this._grpParameter.ResumeLayout(false);
            this._grpParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numParameterStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParameterDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBanditsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numCountThreads)).EndInit();
            this._grpButtons.ResumeLayout(false);
            this._grpGeneralParameters.ResumeLayout(false);
            this._grpGeneralParameters.PerformLayout();
            this._grpHorizon.ResumeLayout(false);
            this._grpHorizon.PerformLayout();
            this._grpSimulationSettings.ResumeLayout(false);
            this._grpSimulationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _grpTypeBandit;
        private System.Windows.Forms.Label _lblMathExp;
        private System.Windows.Forms.NumericUpDown _numExpectation;
        private System.Windows.Forms.Label _lbl3;
        private System.Windows.Forms.NumericUpDown _numNumberSimulations;
        private System.Windows.Forms.ComboBox _cmbDistribution;
        private System.Windows.Forms.Label _lbl4;
        private System.Windows.Forms.NumericUpDown _numNumberBatches;
        private System.Windows.Forms.NumericUpDown _numBatchSize;
        private System.Windows.Forms.Label _lbl5;
        private System.Windows.Forms.GroupBox _grpBordersDeviationExp;
        private System.Windows.Forms.Label _lbl8;
        private System.Windows.Forms.Label _lbl9;
        private System.Windows.Forms.Label _lbl10;
        private System.Windows.Forms.Label _lbl11;
        private System.Windows.Forms.TextBox _txtFinalDeviation;
        private System.Windows.Forms.NumericUpDown _numDeviationStart;
        private System.Windows.Forms.NumericUpDown _numDeviationDelta;
        private System.Windows.Forms.NumericUpDown _numDeviationCount;
        private System.Windows.Forms.GroupBox _grpParameter;
        private System.Windows.Forms.NumericUpDown _numBanditsCount;
        private System.Windows.Forms.Label _lbl12;
        private System.Windows.Forms.NumericUpDown numParameterDelta;
        private System.Windows.Forms.Label _lbl13;
        private System.Windows.Forms.NumericUpDown _numParameterStart;
        private System.Windows.Forms.Label _lbl14;
        private System.Windows.Forms.NumericUpDown _numCountThreads;
        private System.Windows.Forms.Label _lbl16;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.GroupBox _grpButtons;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Label _lbl17;
        private System.Windows.Forms.CheckBox _chkSoundPlay;
        private System.Windows.Forms.ComboBox _cmbTypeProcessingData;
        private System.Windows.Forms.Label _lbl20;
        private System.Windows.Forms.NumericUpDown _numBanditArms;
        private System.Windows.Forms.Label _lbl24;
        private System.Windows.Forms.NumericUpDown _numMaxVariance;
        private System.Windows.Forms.Label _lbl25;
        private System.Windows.Forms.GroupBox _grpGeneralParameters;
        private System.Windows.Forms.GroupBox _grpHorizon;
        private System.Windows.Forms.GroupBox _grpSimulationSettings;
        private System.Windows.Forms.Button _btnPause;
        private System.Windows.Forms.Label _lblDialog;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Button _btnOpen;
        private System.Windows.Forms.Button _btnNew;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.CheckBox _chkVariancesKnown;
    }
}

