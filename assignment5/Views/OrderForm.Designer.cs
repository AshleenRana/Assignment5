namespace assignment5
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemCompGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditonDataFinalLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.GPUDataLabel = new System.Windows.Forms.Label();
            this.WebCamDataLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.LCDDataLabel = new System.Windows.Forms.Label();
            this.CostGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SalesTaxDataLabel = new System.Windows.Forms.Label();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.TotalDataLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SystemCompGroupBox.SuspendLayout();
            this.CostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCtrlOToolStripMenuItem,
            this.saveCtrlSToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.openCtrlOToolStripMenuItem.Text = "Open";
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.saveCtrlSToolStripMenuItem.Text = "Save                   ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SystemCompGroupBox
            // 
            this.SystemCompGroupBox.Controls.Add(this.LCDDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.MemoryDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.WebCamDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.GPUDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.OSDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.HDDDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.CPUTypeDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.CPUBrandDataLabel);
            this.SystemCompGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemCompGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemCompGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemCompGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemCompGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemCompGroupBox.Controls.Add(this.HDDLabel);
            this.SystemCompGroupBox.Controls.Add(this.OSLabel);
            this.SystemCompGroupBox.Controls.Add(this.GPULabel);
            this.SystemCompGroupBox.Controls.Add(this.label3);
            this.SystemCompGroupBox.Controls.Add(this.label2);
            this.SystemCompGroupBox.Controls.Add(this.label1);
            this.SystemCompGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemCompGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemCompGroupBox.Controls.Add(this.ModelLabel);
            this.SystemCompGroupBox.Controls.Add(this.ConditonDataFinalLabel);
            this.SystemCompGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemCompGroupBox.Location = new System.Drawing.Point(12, 31);
            this.SystemCompGroupBox.Name = "SystemCompGroupBox";
            this.SystemCompGroupBox.Size = new System.Drawing.Size(542, 533);
            this.SystemCompGroupBox.TabIndex = 2;
            this.SystemCompGroupBox.TabStop = false;
            this.SystemCompGroupBox.Text = "System Components";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(6, 60);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(118, 34);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // ConditonDataFinalLabel
            // 
            this.ConditonDataFinalLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConditonDataFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditonDataFinalLabel.Location = new System.Drawing.Point(120, 60);
            this.ConditonDataFinalLabel.Name = "ConditonDataFinalLabel";
            this.ConditonDataFinalLabel.Size = new System.Drawing.Size(139, 25);
            this.ConditonDataFinalLabel.TabIndex = 1;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(275, 104);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(118, 34);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(275, 60);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(118, 34);
            this.PlatformLabel.TabIndex = 3;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 104);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(118, 34);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufac.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 7;
            // 
            // GPULabel
            // 
            this.GPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPULabel.Location = new System.Drawing.Point(6, 437);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(118, 34);
            this.GPULabel.TabIndex = 8;
            this.GPULabel.Text = "GPU";
            // 
            // OSLabel
            // 
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(6, 393);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(118, 34);
            this.OSLabel.TabIndex = 9;
            this.OSLabel.Text = "OS";
            // 
            // HDDLabel
            // 
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(6, 344);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(118, 34);
            this.HDDLabel.TabIndex = 10;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(6, 294);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(133, 34);
            this.CPUTypeLabel.TabIndex = 11;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 250);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(133, 34);
            this.CPUBrandLabel.TabIndex = 12;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(6, 206);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(118, 34);
            this.MemoryLabel.TabIndex = 13;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(6, 162);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(118, 34);
            this.LCDSizeLabel.TabIndex = 14;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(6, 487);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(118, 34);
            this.WebCamLabel.TabIndex = 15;
            this.WebCamLabel.Text = "WebCam";
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CPUBrandDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(175, 250);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(139, 25);
            this.CPUBrandDataLabel.TabIndex = 16;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CPUTypeDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(175, 303);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(139, 25);
            this.CPUTypeDataLabel.TabIndex = 17;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HDDDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDDataLabel.Location = new System.Drawing.Point(175, 344);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(139, 25);
            this.HDDDataLabel.TabIndex = 18;
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OSDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSDataLabel.Location = new System.Drawing.Point(175, 393);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(139, 25);
            this.OSDataLabel.TabIndex = 19;
            // 
            // GPUDataLabel
            // 
            this.GPUDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GPUDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUDataLabel.Location = new System.Drawing.Point(175, 437);
            this.GPUDataLabel.Name = "GPUDataLabel";
            this.GPUDataLabel.Size = new System.Drawing.Size(139, 25);
            this.GPUDataLabel.TabIndex = 20;
            // 
            // WebCamDataLabel
            // 
            this.WebCamDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WebCamDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamDataLabel.Location = new System.Drawing.Point(175, 487);
            this.WebCamDataLabel.Name = "WebCamDataLabel";
            this.WebCamDataLabel.Size = new System.Drawing.Size(139, 25);
            this.WebCamDataLabel.TabIndex = 21;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MemoryDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryDataLabel.Location = new System.Drawing.Point(175, 206);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(139, 25);
            this.MemoryDataLabel.TabIndex = 22;
            // 
            // LCDDataLabel
            // 
            this.LCDDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LCDDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDDataLabel.Location = new System.Drawing.Point(175, 162);
            this.LCDDataLabel.Name = "LCDDataLabel";
            this.LCDDataLabel.Size = new System.Drawing.Size(139, 25);
            this.LCDDataLabel.TabIndex = 23;
            // 
            // CostGroupBox
            // 
            this.CostGroupBox.Controls.Add(this.TotalDataLabel);
            this.CostGroupBox.Controls.Add(this.PriceDataLabel);
            this.CostGroupBox.Controls.Add(this.SalesTaxDataLabel);
            this.CostGroupBox.Controls.Add(this.PriceLabel);
            this.CostGroupBox.Controls.Add(this.SalesTaxLabel);
            this.CostGroupBox.Controls.Add(this.TotalLabel);
            this.CostGroupBox.Location = new System.Drawing.Point(576, 50);
            this.CostGroupBox.Name = "CostGroupBox";
            this.CostGroupBox.Size = new System.Drawing.Size(332, 244);
            this.CostGroupBox.TabIndex = 3;
            this.CostGroupBox.TabStop = false;
            this.CostGroupBox.Text = "Your Price";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(6, 200);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(133, 34);
            this.TotalLabel.TabIndex = 13;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(6, 128);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(192, 34);
            this.SalesTaxLabel.TabIndex = 14;
            this.SalesTaxLabel.Text = "Sales Tax (15%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(6, 75);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(133, 34);
            this.PriceLabel.TabIndex = 15;
            this.PriceLabel.Text = "Price";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(560, 502);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(107, 41);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(814, 502);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(107, 41);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(679, 502);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(129, 41);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SalesTaxDataLabel
            // 
            this.SalesTaxDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SalesTaxDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxDataLabel.Location = new System.Drawing.Point(169, 128);
            this.SalesTaxDataLabel.Name = "SalesTaxDataLabel";
            this.SalesTaxDataLabel.Size = new System.Drawing.Size(139, 25);
            this.SalesTaxDataLabel.TabIndex = 18;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PriceDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceDataLabel.Location = new System.Drawing.Point(169, 75);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(139, 25);
            this.PriceDataLabel.TabIndex = 19;
            // 
            // TotalDataLabel
            // 
            this.TotalDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDataLabel.Location = new System.Drawing.Point(169, 200);
            this.TotalDataLabel.Name = "TotalDataLabel";
            this.TotalDataLabel.Size = new System.Drawing.Size(139, 25);
            this.TotalDataLabel.TabIndex = 20;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 561);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CostGroupBox);
            this.Controls.Add(this.SystemCompGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SystemCompGroupBox.ResumeLayout(false);
            this.CostGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemCompGroupBox;
        private System.Windows.Forms.Label ConditonDataFinalLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label LCDDataLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label WebCamDataLabel;
        private System.Windows.Forms.Label GPUDataLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.GroupBox CostGroupBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TotalDataLabel;
        private System.Windows.Forms.Label PriceDataLabel;
        private System.Windows.Forms.Label SalesTaxDataLabel;
    }
}