namespace COMP123_S2019_Assignment_5_Anurag
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDDataLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostDataLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManufactureDataLabel = new System.Windows.Forms.Label();
            this.ManufactureLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.SpecificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamDataLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductInfoFormMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SpecificationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoFormMenuStrip
            // 
            this.ProductInfoFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProductInfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoFormMenuStrip.Name = "ProductInfoFormMenuStrip";
            this.ProductInfoFormMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.ProductInfoFormMenuStrip.Size = new System.Drawing.Size(992, 28);
            this.ProductInfoFormMenuStrip.TabIndex = 0;
            this.ProductInfoFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(213, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Application_Exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.Select_Another_Product_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(669, 596);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 49);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Application_Exit_Click);
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(527, 544);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(115, 101);
            this.SelectAnotherProductButton.TabIndex = 2;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.Select_Another_Product_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(798, 544);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(115, 101);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Location = new System.Drawing.Point(13, 45);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(142, 31);
            this.ProductIDLabel.TabIndex = 4;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // ProductIDDataLabel
            // 
            this.ProductIDDataLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIDDataLabel.Location = new System.Drawing.Point(161, 45);
            this.ProductIDDataLabel.Name = "ProductIDDataLabel";
            this.ProductIDDataLabel.Size = new System.Drawing.Size(142, 31);
            this.ProductIDDataLabel.TabIndex = 4;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(323, 45);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(142, 31);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition:";
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionDataLabel.Location = new System.Drawing.Point(471, 45);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(142, 31);
            this.ConditionDataLabel.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.Location = new System.Drawing.Point(623, 46);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(142, 31);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost:";
            // 
            // CostDataLabel
            // 
            this.CostDataLabel.BackColor = System.Drawing.Color.White;
            this.CostDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostDataLabel.Location = new System.Drawing.Point(714, 46);
            this.CostDataLabel.Name = "CostDataLabel";
            this.CostDataLabel.Size = new System.Drawing.Size(142, 31);
            this.CostDataLabel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModelDataLabel);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Controls.Add(this.OSDataLabel);
            this.groupBox1.Controls.Add(this.OSLabel);
            this.groupBox1.Controls.Add(this.ManufactureDataLabel);
            this.groupBox1.Controls.Add(this.ManufactureLabel);
            this.groupBox1.Controls.Add(this.PlatformDataLabel);
            this.groupBox1.Controls.Add(this.PlatformLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.ModelDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelDataLabel.Location = new System.Drawing.Point(490, 88);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(142, 31);
            this.ModelDataLabel.TabIndex = 12;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(342, 88);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(142, 31);
            this.ModelLabel.TabIndex = 13;
            this.ModelLabel.Text = "Model:";
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.BackColor = System.Drawing.Color.White;
            this.OSDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OSDataLabel.Location = new System.Drawing.Point(490, 36);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(142, 31);
            this.OSDataLabel.TabIndex = 10;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(342, 36);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(142, 31);
            this.OSLabel.TabIndex = 11;
            this.OSLabel.Text = "OS:";
            // 
            // ManufactureDataLabel
            // 
            this.ManufactureDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufactureDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufactureDataLabel.Location = new System.Drawing.Point(164, 88);
            this.ManufactureDataLabel.Name = "ManufactureDataLabel";
            this.ManufactureDataLabel.Size = new System.Drawing.Size(142, 31);
            this.ManufactureDataLabel.TabIndex = 8;
            // 
            // ManufactureLabel
            // 
            this.ManufactureLabel.Location = new System.Drawing.Point(16, 88);
            this.ManufactureLabel.Name = "ManufactureLabel";
            this.ManufactureLabel.Size = new System.Drawing.Size(142, 31);
            this.ManufactureLabel.TabIndex = 9;
            this.ManufactureLabel.Text = "Manufacture:";
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlatformDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatformDataLabel.Location = new System.Drawing.Point(164, 35);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(142, 31);
            this.PlatformDataLabel.TabIndex = 6;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(16, 35);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(142, 31);
            this.PlatformLabel.TabIndex = 7;
            this.PlatformLabel.Text = "Platform:";
            // 
            // SpecificationsGroupBox
            // 
            this.SpecificationsGroupBox.Controls.Add(this.WebcamDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.WebcamLabel);
            this.SpecificationsGroupBox.Controls.Add(this.GPUTypeDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SpecificationsGroupBox.Controls.Add(this.HDDDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.HDDLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUSpeedDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUTypeDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUNumberDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SpecificationsGroupBox.Controls.Add(this.LCDSizeDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUBrandDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SpecificationsGroupBox.Controls.Add(this.MemoryDataLabel);
            this.SpecificationsGroupBox.Controls.Add(this.MemoryLabel);
            this.SpecificationsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificationsGroupBox.Location = new System.Drawing.Point(12, 246);
            this.SpecificationsGroupBox.Name = "SpecificationsGroupBox";
            this.SpecificationsGroupBox.Size = new System.Drawing.Size(968, 270);
            this.SpecificationsGroupBox.TabIndex = 14;
            this.SpecificationsGroupBox.TabStop = false;
            this.SpecificationsGroupBox.Text = "Specifications";
            // 
            // WebcamDataLabel
            // 
            this.WebcamDataLabel.BackColor = System.Drawing.Color.White;
            this.WebcamDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebcamDataLabel.Location = new System.Drawing.Point(800, 219);
            this.WebcamDataLabel.Name = "WebcamDataLabel";
            this.WebcamDataLabel.Size = new System.Drawing.Size(142, 31);
            this.WebcamDataLabel.TabIndex = 23;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.Location = new System.Drawing.Point(652, 219);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(142, 31);
            this.WebcamLabel.TabIndex = 24;
            this.WebcamLabel.Text = "Webcam:";
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(800, 128);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(142, 31);
            this.GPUTypeDataLabel.TabIndex = 21;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Location = new System.Drawing.Point(652, 128);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(142, 31);
            this.GPUTypeLabel.TabIndex = 22;
            this.GPUTypeLabel.Text = "GPU Type:";
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.HDDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDDDataLabel.Location = new System.Drawing.Point(800, 37);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(142, 31);
            this.HDDDataLabel.TabIndex = 19;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(652, 37);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(142, 31);
            this.HDDLabel.TabIndex = 20;
            this.HDDLabel.Text = "HDD:";
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(490, 218);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUSpeedDataLabel.TabIndex = 17;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(342, 218);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUSpeedLabel.TabIndex = 18;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(164, 217);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUTypeDataLabel.TabIndex = 15;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(490, 127);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUNumberDataLabel.TabIndex = 12;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(16, 217);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUTypeLabel.TabIndex = 16;
            this.CPUTypeLabel.Text = "CPU Type:";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Location = new System.Drawing.Point(342, 127);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUNumberLabel.TabIndex = 13;
            this.CPUNumberLabel.Text = "CPU Number:";
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(490, 36);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(142, 31);
            this.LCDSizeDataLabel.TabIndex = 10;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(342, 36);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(142, 31);
            this.LCDSizeLabel.TabIndex = 11;
            this.LCDSizeLabel.Text = "LCD Size:";
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(164, 126);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUBrandDataLabel.TabIndex = 8;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(16, 126);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(142, 31);
            this.CPUBrandLabel.TabIndex = 9;
            this.CPUBrandLabel.Text = "CPU Brand:";
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.BackColor = System.Drawing.Color.White;
            this.MemoryDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoryDataLabel.Location = new System.Drawing.Point(164, 35);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(142, 31);
            this.MemoryDataLabel.TabIndex = 6;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(16, 35);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(142, 31);
            this.MemoryLabel.TabIndex = 7;
            this.MemoryLabel.Text = "Memory:";
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 657);
            this.ControlBox = false;
            this.Controls.Add(this.SpecificationsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CostDataLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionDataLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDDataLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductInfoFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.ProductInfoFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoFormMenuStrip.ResumeLayout(false);
            this.ProductInfoFormMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.SpecificationsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductIDDataLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CostDataLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufactureDataLabel;
        private System.Windows.Forms.Label ManufactureLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox SpecificationsGroupBox;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label WebcamDataLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductSaveFileDialog;
    }
}