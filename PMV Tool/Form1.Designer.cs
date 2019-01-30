namespace PMV_Tool
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingTypologyLabelcomboBox = new System.Windows.Forms.ComboBox();
            this.buildingTypologyLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.Cat2radioButton = new System.Windows.Forms.RadioButton();
            this.structComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.Cat4radioButton = new System.Windows.Forms.RadioButton();
            this.Cat3radioButton = new System.Windows.Forms.RadioButton();
            this.cat1radioButton = new System.Windows.Forms.RadioButton();
            this.questStrucCompLabel = new System.Windows.Forms.Label();
            this.questStrucCompComboBox = new System.Windows.Forms.ComboBox();
            this.chooseMaterialLabel2 = new System.Windows.Forms.Label();
            this.chooseMaterialComboBox1 = new System.Windows.Forms.ComboBox();
            this.Cat1groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cat1dradioButton1 = new System.Windows.Forms.RadioButton();
            this.Cat1cRadioButton = new System.Windows.Forms.RadioButton();
            this.Cat1bRadioButton10 = new System.Windows.Forms.RadioButton();
            this.Cat1aRadioButton9 = new System.Windows.Forms.RadioButton();
            this.Cat3groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cat3gradioButton21 = new System.Windows.Forms.RadioButton();
            this.Cat3fradioButton20 = new System.Windows.Forms.RadioButton();
            this.Cat3eradioButton19 = new System.Windows.Forms.RadioButton();
            this.Cat3dradioButton18 = new System.Windows.Forms.RadioButton();
            this.Cat3cradioButton15 = new System.Windows.Forms.RadioButton();
            this.Cat3bradioButton16 = new System.Windows.Forms.RadioButton();
            this.Cat3aradioButton17 = new System.Windows.Forms.RadioButton();
            this.Cat2groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cat2aRadioButton = new System.Windows.Forms.RadioButton();
            this.specifylabel2 = new System.Windows.Forms.Label();
            this.specifyTextBox1 = new System.Windows.Forms.TextBox();
            this.Cat5checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Cat6checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Cat7ChBox = new System.Windows.Forms.CheckedListBox();
            this.PMVtxtBox = new System.Windows.Forms.TextBox();
            this.finalPMVLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.nonStructuralLabel = new System.Windows.Forms.Label();
            this.nonStructuralDropdown = new System.Windows.Forms.ComboBox();
            this.nonStructuralChBox = new System.Windows.Forms.CheckedListBox();
            this.saveResultsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.structComponentsGroupBox.SuspendLayout();
            this.Cat1groupBox1.SuspendLayout();
            this.Cat3groupBox3.SuspendLayout();
            this.Cat2groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMV_Tool.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(1491, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculating Pre-Manufactured Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buildingTypologyLabelcomboBox
            // 
            this.buildingTypologyLabelcomboBox.FormattingEnabled = true;
            this.buildingTypologyLabelcomboBox.Items.AddRange(new object[] {
            "Houses",
            "Low rise apartments (<5 storeys)",
            "Mid rise apartments (6 - 9 storeys)",
            "High risk residential buildings (HRRB) (10 storeys & above)"});
            this.buildingTypologyLabelcomboBox.Location = new System.Drawing.Point(430, 155);
            this.buildingTypologyLabelcomboBox.Margin = new System.Windows.Forms.Padding(6);
            this.buildingTypologyLabelcomboBox.Name = "buildingTypologyLabelcomboBox";
            this.buildingTypologyLabelcomboBox.Size = new System.Drawing.Size(630, 33);
            this.buildingTypologyLabelcomboBox.TabIndex = 4;
            this.buildingTypologyLabelcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buildingTypologyLabel
            // 
            this.buildingTypologyLabel.AutoSize = true;
            this.buildingTypologyLabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingTypologyLabel.ForeColor = System.Drawing.Color.White;
            this.buildingTypologyLabel.Location = new System.Drawing.Point(44, 155);
            this.buildingTypologyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buildingTypologyLabel.Name = "buildingTypologyLabel";
            this.buildingTypologyLabel.Size = new System.Drawing.Size(333, 39);
            this.buildingTypologyLabel.TabIndex = 5;
            this.buildingTypologyLabel.Text = "Select building typology:";
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1.5D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Maximum = 60D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1356, 325);
            this.chart1.Margin = new System.Windows.Forms.Padding(6);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(990, 613);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(1864, 979);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(178, 77);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate PMV";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Cat2radioButton
            // 
            this.Cat2radioButton.AutoSize = true;
            this.Cat2radioButton.Location = new System.Drawing.Point(12, 81);
            this.Cat2radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.Cat2radioButton.Name = "Cat2radioButton";
            this.Cat2radioButton.Size = new System.Drawing.Size(601, 29);
            this.Cat2radioButton.TabIndex = 13;
            this.Cat2radioButton.TabStop = true;
            this.Cat2radioButton.Text = "2. PRE-MANUFACTURING - 2D STRUCTURAL SYSTEMS";
            this.Cat2radioButton.UseVisualStyleBackColor = true;
            this.Cat2radioButton.CheckedChanged += new System.EventHandler(this.Cat2radioButton_CheckedChanged);
            // 
            // structComponentsGroupBox
            // 
            this.structComponentsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.structComponentsGroupBox.Controls.Add(this.Cat4radioButton);
            this.structComponentsGroupBox.Controls.Add(this.Cat3radioButton);
            this.structComponentsGroupBox.Controls.Add(this.cat1radioButton);
            this.structComponentsGroupBox.Controls.Add(this.Cat2radioButton);
            this.structComponentsGroupBox.Location = new System.Drawing.Point(54, 405);
            this.structComponentsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.structComponentsGroupBox.Name = "structComponentsGroupBox";
            this.structComponentsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.structComponentsGroupBox.Size = new System.Drawing.Size(1010, 248);
            this.structComponentsGroupBox.TabIndex = 14;
            this.structComponentsGroupBox.TabStop = false;
            this.structComponentsGroupBox.Text = "Structural Components";
            this.structComponentsGroupBox.Enter += new System.EventHandler(this.structComponentsGroupBox_Enter);
            // 
            // Cat4radioButton
            // 
            this.Cat4radioButton.AutoSize = true;
            this.Cat4radioButton.Location = new System.Drawing.Point(14, 173);
            this.Cat4radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.Cat4radioButton.Name = "Cat4radioButton";
            this.Cat4radioButton.Size = new System.Drawing.Size(523, 29);
            this.Cat4radioButton.TabIndex = 16;
            this.Cat4radioButton.TabStop = true;
            this.Cat4radioButton.Text = "4a. ADDITIVE MANUFACTURING - STRUCTURAL";
            this.Cat4radioButton.UseVisualStyleBackColor = true;
            this.Cat4radioButton.CheckedChanged += new System.EventHandler(this.Cat4radioButton_CheckedChanged);
            // 
            // Cat3radioButton
            // 
            this.Cat3radioButton.AutoSize = true;
            this.Cat3radioButton.Location = new System.Drawing.Point(14, 127);
            this.Cat3radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3radioButton.Name = "Cat3radioButton";
            this.Cat3radioButton.Size = new System.Drawing.Size(838, 29);
            this.Cat3radioButton.TabIndex = 15;
            this.Cat3radioButton.TabStop = true;
            this.Cat3radioButton.Text = "3. PRE-MANUFACTRUING - STRUCTURAL ASSEMBLIES AND SUB-ASSEMBLIES";
            this.Cat3radioButton.UseVisualStyleBackColor = true;
            this.Cat3radioButton.CheckedChanged += new System.EventHandler(this.Cat3radioButton_CheckedChanged);
            // 
            // cat1radioButton
            // 
            this.cat1radioButton.AutoSize = true;
            this.cat1radioButton.Location = new System.Drawing.Point(14, 37);
            this.cat1radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.cat1radioButton.Name = "cat1radioButton";
            this.cat1radioButton.Size = new System.Drawing.Size(601, 29);
            this.cat1radioButton.TabIndex = 14;
            this.cat1radioButton.TabStop = true;
            this.cat1radioButton.Text = "1. PRE-MANUFACTURING - 3D STRUCTURAL SYSTEMS";
            this.cat1radioButton.UseVisualStyleBackColor = true;
            this.cat1radioButton.CheckedChanged += new System.EventHandler(this.cat1radioButton_CheckedChanged);
            // 
            // questStrucCompLabel
            // 
            this.questStrucCompLabel.AutoSize = true;
            this.questStrucCompLabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questStrucCompLabel.ForeColor = System.Drawing.Color.White;
            this.questStrucCompLabel.Location = new System.Drawing.Point(40, 211);
            this.questStrucCompLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.questStrucCompLabel.Name = "questStrucCompLabel";
            this.questStrucCompLabel.Size = new System.Drawing.Size(754, 39);
            this.questStrucCompLabel.TabIndex = 16;
            this.questStrucCompLabel.Text = "Are you using pre-manufactured STRUCTURAL methods? ";
            this.questStrucCompLabel.Click += new System.EventHandler(this.questStrucCompLabel_Click);
            // 
            // questStrucCompComboBox
            // 
            this.questStrucCompComboBox.FormattingEnabled = true;
            this.questStrucCompComboBox.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.questStrucCompComboBox.Location = new System.Drawing.Point(932, 213);
            this.questStrucCompComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.questStrucCompComboBox.Name = "questStrucCompComboBox";
            this.questStrucCompComboBox.Size = new System.Drawing.Size(130, 33);
            this.questStrucCompComboBox.TabIndex = 17;
            this.questStrucCompComboBox.SelectedIndexChanged += new System.EventHandler(this.questStrucCompComboBox_SelectedIndexChanged);
            // 
            // chooseMaterialLabel2
            // 
            this.chooseMaterialLabel2.AutoSize = true;
            this.chooseMaterialLabel2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMaterialLabel2.ForeColor = System.Drawing.Color.White;
            this.chooseMaterialLabel2.Location = new System.Drawing.Point(40, 319);
            this.chooseMaterialLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.chooseMaterialLabel2.Name = "chooseMaterialLabel2";
            this.chooseMaterialLabel2.Size = new System.Drawing.Size(543, 39);
            this.chooseMaterialLabel2.TabIndex = 18;
            this.chooseMaterialLabel2.Text = "Choose primary structural material used:";
            this.chooseMaterialLabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chooseMaterialComboBox1
            // 
            this.chooseMaterialComboBox1.FormattingEnabled = true;
            this.chooseMaterialComboBox1.Items.AddRange(new object[] {
            "MASS ENGINEERED TIMBER (MET)",
            "TIMBER FRAMED (TF)",
            "LIGHT GAUGE STEEL FRAMED (LGS)",
            "HOT ROLLED FABRICATED STEEL (HRS)",
            "HOT ROLLED / LIGHT GAUGE STEEL COMBINATION (SC) ",
            "CONCRETE & CEMENT DERIVED ( C )",
            "TIMBER FRAMED / CONCRETE COMBINATION (TFC)"});
            this.chooseMaterialComboBox1.Location = new System.Drawing.Point(604, 324);
            this.chooseMaterialComboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.chooseMaterialComboBox1.Name = "chooseMaterialComboBox1";
            this.chooseMaterialComboBox1.Size = new System.Drawing.Size(458, 33);
            this.chooseMaterialComboBox1.TabIndex = 19;
            this.chooseMaterialComboBox1.SelectedIndexChanged += new System.EventHandler(this.chooseMaterialComboBox1_SelectedIndexChanged);
            // 
            // Cat1groupBox1
            // 
            this.Cat1groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cat1groupBox1.Controls.Add(this.Cat1dradioButton1);
            this.Cat1groupBox1.Controls.Add(this.Cat1cRadioButton);
            this.Cat1groupBox1.Controls.Add(this.Cat1bRadioButton10);
            this.Cat1groupBox1.Controls.Add(this.Cat1aRadioButton9);
            this.Cat1groupBox1.Location = new System.Drawing.Point(54, 669);
            this.Cat1groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.Cat1groupBox1.Name = "Cat1groupBox1";
            this.Cat1groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.Cat1groupBox1.Size = new System.Drawing.Size(798, 269);
            this.Cat1groupBox1.TabIndex = 20;
            this.Cat1groupBox1.TabStop = false;
            this.Cat1groupBox1.Enter += new System.EventHandler(this.Cat1groupBox1_Enter);
            // 
            // Cat1dradioButton1
            // 
            this.Cat1dradioButton1.Location = new System.Drawing.Point(8, 192);
            this.Cat1dradioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.Cat1dradioButton1.Name = "Cat1dradioButton1";
            this.Cat1dradioButton1.Size = new System.Drawing.Size(754, 81);
            this.Cat1dradioButton1.TabIndex = 3;
            this.Cat1dradioButton1.TabStop = true;
            this.Cat1dradioButton1.Text = "1d. Structural chassis and internal fit out - \'podded\' room assemblies - bathroom" +
    "s / kitchens etc";
            this.Cat1dradioButton1.UseVisualStyleBackColor = true;
            this.Cat1dradioButton1.CheckedChanged += new System.EventHandler(this.Cat1dradioButton1_CheckedChanged);
            // 
            // Cat1cRadioButton
            // 
            this.Cat1cRadioButton.Location = new System.Drawing.Point(12, 125);
            this.Cat1cRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.Cat1cRadioButton.Name = "Cat1cRadioButton";
            this.Cat1cRadioButton.Size = new System.Drawing.Size(728, 81);
            this.Cat1cRadioButton.TabIndex = 2;
            this.Cat1cRadioButton.TabStop = true;
            this.Cat1cRadioButton.Text = "1c. Structural chassis, fit out and external cladding / roofing complete";
            this.Cat1cRadioButton.UseVisualStyleBackColor = true;
            this.Cat1cRadioButton.CheckedChanged += new System.EventHandler(this.Cat1cRadioButton_CheckedChanged_1);
            // 
            // Cat1bRadioButton10
            // 
            this.Cat1bRadioButton10.AutoSize = true;
            this.Cat1bRadioButton10.Location = new System.Drawing.Point(12, 88);
            this.Cat1bRadioButton10.Margin = new System.Windows.Forms.Padding(6);
            this.Cat1bRadioButton10.Name = "Cat1bRadioButton10";
            this.Cat1bRadioButton10.Size = new System.Drawing.Size(428, 29);
            this.Cat1bRadioButton10.TabIndex = 1;
            this.Cat1bRadioButton10.TabStop = true;
            this.Cat1bRadioButton10.Text = "1b. Structural chassis and internal fit out";
            this.Cat1bRadioButton10.UseVisualStyleBackColor = true;
            this.Cat1bRadioButton10.CheckedChanged += new System.EventHandler(this.Cat1bRadioButton10_CheckedChanged_1);
            // 
            // Cat1aRadioButton9
            // 
            this.Cat1aRadioButton9.AutoSize = true;
            this.Cat1aRadioButton9.Location = new System.Drawing.Point(14, 37);
            this.Cat1aRadioButton9.Margin = new System.Windows.Forms.Padding(6);
            this.Cat1aRadioButton9.Name = "Cat1aRadioButton9";
            this.Cat1aRadioButton9.Size = new System.Drawing.Size(434, 29);
            this.Cat1aRadioButton9.TabIndex = 0;
            this.Cat1aRadioButton9.TabStop = true;
            this.Cat1aRadioButton9.Text = "1a. Structural chassis only - not fitted out";
            this.Cat1aRadioButton9.UseVisualStyleBackColor = true;
            this.Cat1aRadioButton9.CheckedChanged += new System.EventHandler(this.Cat1aRadioButton9_CheckedChanged_1);
            // 
            // Cat3groupBox3
            // 
            this.Cat3groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cat3groupBox3.Controls.Add(this.Cat3gradioButton21);
            this.Cat3groupBox3.Controls.Add(this.Cat3fradioButton20);
            this.Cat3groupBox3.Controls.Add(this.Cat3eradioButton19);
            this.Cat3groupBox3.Controls.Add(this.Cat3dradioButton18);
            this.Cat3groupBox3.Controls.Add(this.Cat3cradioButton15);
            this.Cat3groupBox3.Controls.Add(this.Cat3bradioButton16);
            this.Cat3groupBox3.Controls.Add(this.Cat3aradioButton17);
            this.Cat3groupBox3.Location = new System.Drawing.Point(56, 680);
            this.Cat3groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3groupBox3.Name = "Cat3groupBox3";
            this.Cat3groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.Cat3groupBox3.Size = new System.Drawing.Size(734, 212);
            this.Cat3groupBox3.TabIndex = 22;
            this.Cat3groupBox3.TabStop = false;
            this.Cat3groupBox3.Enter += new System.EventHandler(this.Cat3groupBox3_Enter);
            // 
            // Cat3gradioButton21
            // 
            this.Cat3gradioButton21.Location = new System.Drawing.Point(306, 125);
            this.Cat3gradioButton21.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3gradioButton21.Name = "Cat3gradioButton21";
            this.Cat3gradioButton21.Size = new System.Drawing.Size(416, 60);
            this.Cat3gradioButton21.TabIndex = 6;
            this.Cat3gradioButton21.TabStop = true;
            this.Cat3gradioButton21.Text = "3g. Roof structure - trusses / spandrels";
            this.Cat3gradioButton21.UseVisualStyleBackColor = true;
            this.Cat3gradioButton21.CheckedChanged += new System.EventHandler(this.Cat3gradioButton21_CheckedChanged);
            // 
            // Cat3fradioButton20
            // 
            this.Cat3fradioButton20.Location = new System.Drawing.Point(306, 87);
            this.Cat3fradioButton20.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3fradioButton20.Name = "Cat3fradioButton20";
            this.Cat3fradioButton20.Size = new System.Drawing.Size(406, 40);
            this.Cat3fradioButton20.TabIndex = 5;
            this.Cat3fradioButton20.TabStop = true;
            this.Cat3fradioButton20.Text = "3f. Staircases";
            this.Cat3fradioButton20.UseVisualStyleBackColor = true;
            this.Cat3fradioButton20.CheckedChanged += new System.EventHandler(this.Cat3fradioButton20_CheckedChanged_1);
            // 
            // Cat3eradioButton19
            // 
            this.Cat3eradioButton19.Location = new System.Drawing.Point(306, 29);
            this.Cat3eradioButton19.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3eradioButton19.Name = "Cat3eradioButton19";
            this.Cat3eradioButton19.Size = new System.Drawing.Size(382, 67);
            this.Cat3eradioButton19.TabIndex = 4;
            this.Cat3eradioButton19.TabStop = true;
            this.Cat3eradioButton19.Text = "3e. Integrated columns & floor slabs";
            this.Cat3eradioButton19.UseVisualStyleBackColor = true;
            this.Cat3eradioButton19.CheckedChanged += new System.EventHandler(this.Cat3eradioButton19_CheckedChanged_1);
            // 
            // Cat3dradioButton18
            // 
            this.Cat3dradioButton18.Location = new System.Drawing.Point(12, 131);
            this.Cat3dradioButton18.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3dradioButton18.Name = "Cat3dradioButton18";
            this.Cat3dradioButton18.Size = new System.Drawing.Size(222, 40);
            this.Cat3dradioButton18.TabIndex = 3;
            this.Cat3dradioButton18.TabStop = true;
            this.Cat3dradioButton18.Text = "3d. Floor slabs";
            this.Cat3dradioButton18.UseVisualStyleBackColor = true;
            this.Cat3dradioButton18.CheckedChanged += new System.EventHandler(this.Cat3dradioButton18_CheckedChanged_1);
            // 
            // Cat3cradioButton15
            // 
            this.Cat3cradioButton15.Location = new System.Drawing.Point(12, 98);
            this.Cat3cradioButton15.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3cradioButton15.Name = "Cat3cradioButton15";
            this.Cat3cradioButton15.Size = new System.Drawing.Size(296, 40);
            this.Cat3cradioButton15.TabIndex = 2;
            this.Cat3cradioButton15.TabStop = true;
            this.Cat3cradioButton15.Text = "3c. Columns / Shear walls";
            this.Cat3cradioButton15.UseVisualStyleBackColor = true;
            this.Cat3cradioButton15.CheckedChanged += new System.EventHandler(this.Cat3cradioButton15_CheckedChanged_1);
            // 
            // Cat3bradioButton16
            // 
            this.Cat3bradioButton16.AutoSize = true;
            this.Cat3bradioButton16.Location = new System.Drawing.Point(12, 70);
            this.Cat3bradioButton16.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3bradioButton16.Name = "Cat3bradioButton16";
            this.Cat3bradioButton16.Size = new System.Drawing.Size(291, 29);
            this.Cat3bradioButton16.TabIndex = 1;
            this.Cat3bradioButton16.TabStop = true;
            this.Cat3bradioButton16.Text = "3b. Pile caps / ring beams";
            this.Cat3bradioButton16.UseVisualStyleBackColor = true;
            this.Cat3bradioButton16.CheckedChanged += new System.EventHandler(this.Cat3bradioButton16_CheckedChanged_1);
            // 
            // Cat3aradioButton17
            // 
            this.Cat3aradioButton17.Location = new System.Drawing.Point(12, 14);
            this.Cat3aradioButton17.Margin = new System.Windows.Forms.Padding(6);
            this.Cat3aradioButton17.Name = "Cat3aradioButton17";
            this.Cat3aradioButton17.Size = new System.Drawing.Size(164, 62);
            this.Cat3aradioButton17.TabIndex = 0;
            this.Cat3aradioButton17.TabStop = true;
            this.Cat3aradioButton17.Text = "3a. Piling";
            this.Cat3aradioButton17.UseVisualStyleBackColor = true;
            this.Cat3aradioButton17.CheckedChanged += new System.EventHandler(this.Cat3aradioButton17_CheckedChanged_1);
            // 
            // Cat2groupBox
            // 
            this.Cat2groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cat2groupBox.Controls.Add(this.radioButton1);
            this.Cat2groupBox.Controls.Add(this.radioButton2);
            this.Cat2groupBox.Controls.Add(this.cat2aRadioButton);
            this.Cat2groupBox.Location = new System.Drawing.Point(55, 666);
            this.Cat2groupBox.Margin = new System.Windows.Forms.Padding(6);
            this.Cat2groupBox.Name = "Cat2groupBox";
            this.Cat2groupBox.Padding = new System.Windows.Forms.Padding(6);
            this.Cat2groupBox.Size = new System.Drawing.Size(648, 238);
            this.Cat2groupBox.TabIndex = 21;
            this.Cat2groupBox.TabStop = false;
            this.Cat2groupBox.Enter += new System.EventHandler(this.Cat2groupBox2_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(12, 124);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(600, 75);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2c. Further enhanced consolidation - insulation, linings, external cladding, roof" +
    "ing, doors, windows";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 90);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(606, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2b. Enhanced consolidation - insulation, internal linings etc";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // cat2aRadioButton
            // 
            this.cat2aRadioButton.Location = new System.Drawing.Point(12, 23);
            this.cat2aRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.cat2aRadioButton.Name = "cat2aRadioButton";
            this.cat2aRadioButton.Size = new System.Drawing.Size(600, 68);
            this.cat2aRadioButton.TabIndex = 0;
            this.cat2aRadioButton.TabStop = true;
            this.cat2aRadioButton.Text = "2a. Basic framing only incl walls, floors, stairs and roof";
            this.cat2aRadioButton.UseVisualStyleBackColor = true;
            this.cat2aRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // specifylabel2
            // 
            this.specifylabel2.AutoSize = true;
            this.specifylabel2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifylabel2.ForeColor = System.Drawing.Color.White;
            this.specifylabel2.Location = new System.Drawing.Point(55, 1455);
            this.specifylabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.specifylabel2.Name = "specifylabel2";
            this.specifylabel2.Size = new System.Drawing.Size(266, 39);
            this.specifylabel2.TabIndex = 23;
            this.specifylabel2.Text = "Could you specify? ";
            this.specifylabel2.Click += new System.EventHandler(this.specifylabel2_Click_1);
            // 
            // specifyTextBox1
            // 
            this.specifyTextBox1.Location = new System.Drawing.Point(384, 1462);
            this.specifyTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.specifyTextBox1.Name = "specifyTextBox1";
            this.specifyTextBox1.Size = new System.Drawing.Size(460, 31);
            this.specifyTextBox1.TabIndex = 24;
            this.specifyTextBox1.TextChanged += new System.EventHandler(this.specifyTextBox1_TextChanged_1);
            // 
            // Cat5checkedListBox1
            // 
            this.Cat5checkedListBox1.BackColor = System.Drawing.Color.Silver;
            this.Cat5checkedListBox1.FormattingEnabled = true;
            this.Cat5checkedListBox1.HorizontalScrollbar = true;
            this.Cat5checkedListBox1.Items.AddRange(new object[] {
            "5a. whole bathroom assemblies (including enclosing structure)",
            "5b. kitchen assemblies (including enclosing / supporting structure)",
            "5c. bathroom / kitchen combined assemblies (including enclosing / supporting stru" +
                "cture)",
            "5d. in unit M&E central equipment assemblies (utility cupboards etc) Panelised / " +
                "linear  assemblies",
            "5e. façade assemblies (non structural) incl glazing, solid cladding, metalwork",
            "5f. roof assemblies / cassettes  -pre-finished roof sections (incl structure to s" +
                "upport own weight)",
            "5g. in unit M&E distribution assemblies",
            "5h. infrastructure M&E assemblies - vertical risers / main distribution",
            "5i. infrastructure M&E assemblies - central plant & equipment",
            "5j. floor cassettes with horizontal services / finishes added",
            "5k. Partition cassettes -with horizontal & vertical  services / finishes added",
            "5l. doorsets (pre-hung, finished with ironmongery)",
            "5z. others?"});
            this.Cat5checkedListBox1.Location = new System.Drawing.Point(50, 1169);
            this.Cat5checkedListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.Cat5checkedListBox1.Name = "Cat5checkedListBox1";
            this.Cat5checkedListBox1.Size = new System.Drawing.Size(816, 264);
            this.Cat5checkedListBox1.TabIndex = 26;
            this.Cat5checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.Cat5checkedListBox1_SelectedIndexChanged);
            // 
            // Cat6checkedListBox1
            // 
            this.Cat6checkedListBox1.BackColor = System.Drawing.Color.Silver;
            this.Cat6checkedListBox1.FormattingEnabled = true;
            this.Cat6checkedListBox1.HorizontalScrollbar = true;
            this.Cat6checkedListBox1.Items.AddRange(new object[] {
            "6a. large format walling products - external walls",
            "6b. large format walling products - internal walls",
            "6c. large format roofing finishes",
            "6d. pre-sized and cut to measure traditional materials - component level systemis" +
                "ation",
            "6e. easy site install / joiniting / interfacing features - brick slips, modular w" +
                "iring, flexible pipework",
            "6z. others?"});
            this.Cat6checkedListBox1.Location = new System.Drawing.Point(892, 1169);
            this.Cat6checkedListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.Cat6checkedListBox1.Name = "Cat6checkedListBox1";
            this.Cat6checkedListBox1.Size = new System.Drawing.Size(664, 264);
            this.Cat6checkedListBox1.TabIndex = 27;
            this.Cat6checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.Cat6checkedListBox1_SelectedIndexChanged);
            // 
            // Cat7ChBox
            // 
            this.Cat7ChBox.BackColor = System.Drawing.Color.Silver;
            this.Cat7ChBox.FormattingEnabled = true;
            this.Cat7ChBox.Items.AddRange(new object[] {
            "7a. site encapsulation measures - weatherproof & environmentally controlled enclo" +
                "sures",
            "7b. use of standardised or sacrifical  temporary works - modular scaffold, tunnel" +
                " form in-situ concrete, insulated concrete formwork ",
            "7c. use of BIM connected lean delivery framework - digitally enabled workflow pla" +
                "nning",
            "7d. site worker augmentation - visual (ie AR/VR )",
            "7e. site worker augmentation - physical (ie exoskeletons, assisted materials dist" +
                "ribution etc)",
            "7f. site worker productivity planning tools (GPS, wearables etc)",
            "7g. site process robotics & drones (rebar, masonry, plastering, decorating, surve" +
                "ying etc)",
            "7h. autonomous plant & equipment & drones (driverless cranes, diggers etc)",
            "7i. digital site verification tools (photogrammetry, site worker video, LIDAR sca" +
                "nning etc)",
            "7z. others?"});
            this.Cat7ChBox.Location = new System.Drawing.Point(1584, 1169);
            this.Cat7ChBox.Margin = new System.Windows.Forms.Padding(6);
            this.Cat7ChBox.Name = "Cat7ChBox";
            this.Cat7ChBox.Size = new System.Drawing.Size(739, 264);
            this.Cat7ChBox.TabIndex = 28;
            this.Cat7ChBox.SelectedIndexChanged += new System.EventHandler(this.Cat7ChBox_SelectedIndexChanged);
            // 
            // PMVtxtBox
            // 
            this.PMVtxtBox.Location = new System.Drawing.Point(14, 58);
            this.PMVtxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.PMVtxtBox.Name = "PMVtxtBox";
            this.PMVtxtBox.Size = new System.Drawing.Size(136, 31);
            this.PMVtxtBox.TabIndex = 29;
            this.PMVtxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // finalPMVLabel
            // 
            this.finalPMVLabel.AutoSize = true;
            this.finalPMVLabel.BackColor = System.Drawing.Color.White;
            this.finalPMVLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPMVLabel.Location = new System.Drawing.Point(6, 6);
            this.finalPMVLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.finalPMVLabel.Name = "finalPMVLabel";
            this.finalPMVLabel.Size = new System.Drawing.Size(191, 46);
            this.finalPMVLabel.TabIndex = 30;
            this.finalPMVLabel.Text = "Total PMV: ";
            this.finalPMVLabel.Click += new System.EventHandler(this.finalPMVLabel_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.BackColor = System.Drawing.Color.White;
            this.percentLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(156, 52);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(47, 46);
            this.percentLabel.TabIndex = 31;
            this.percentLabel.Text = "%";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1356, 979);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(178, 77);
            this.clearButton.TabIndex = 32;
            this.clearButton.Text = "Clear selection";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nonStructuralLabel
            // 
            this.nonStructuralLabel.AutoSize = true;
            this.nonStructuralLabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonStructuralLabel.ForeColor = System.Drawing.Color.White;
            this.nonStructuralLabel.Location = new System.Drawing.Point(41, 267);
            this.nonStructuralLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nonStructuralLabel.Name = "nonStructuralLabel";
            this.nonStructuralLabel.Size = new System.Drawing.Size(822, 39);
            this.nonStructuralLabel.TabIndex = 33;
            this.nonStructuralLabel.Text = "Are you using pre-manufactured NON STRUCTURAL methods? ";
            this.nonStructuralLabel.Click += new System.EventHandler(this.nonStructuralLabel_Click);
            // 
            // nonStructuralDropdown
            // 
            this.nonStructuralDropdown.FormattingEnabled = true;
            this.nonStructuralDropdown.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.nonStructuralDropdown.Location = new System.Drawing.Point(930, 272);
            this.nonStructuralDropdown.Margin = new System.Windows.Forms.Padding(6);
            this.nonStructuralDropdown.Name = "nonStructuralDropdown";
            this.nonStructuralDropdown.Size = new System.Drawing.Size(130, 33);
            this.nonStructuralDropdown.TabIndex = 34;
            this.nonStructuralDropdown.SelectedIndexChanged += new System.EventHandler(this.nonStructuralDropdown_SelectedIndexChanged);
            // 
            // nonStructuralChBox
            // 
            this.nonStructuralChBox.BackColor = System.Drawing.Color.Silver;
            this.nonStructuralChBox.FormattingEnabled = true;
            this.nonStructuralChBox.HorizontalScrollbar = true;
            this.nonStructuralChBox.Items.AddRange(new object[] {
            "4b. ADDITIVE MANUFACTURING - STRUCTURAL & NON STRUCTURAL",
            "5. PRE-MANUFACTURING - NON STRUCTURAL ASSEMBLIES & SUB ASSEMBLIES ",
            "6. TRADITIONAL BUILDING PRODUCT LED SITE LABOUR REDUCTION / PRODUCTIVITY IMPROVEM" +
                "ENTS",
            "7. SITE PROCESS LED SITE LABOUR REDUCTION / PRODUCTIVITY / ASSURANCE IMPROVEMENTS" +
                ""});
            this.nonStructuralChBox.Location = new System.Drawing.Point(53, 1006);
            this.nonStructuralChBox.Margin = new System.Windows.Forms.Padding(6);
            this.nonStructuralChBox.Name = "nonStructuralChBox";
            this.nonStructuralChBox.Size = new System.Drawing.Size(1182, 134);
            this.nonStructuralChBox.TabIndex = 36;
            this.nonStructuralChBox.SelectedIndexChanged += new System.EventHandler(this.nonStructuralChBox_SelectedIndexChanged);
            // 
            // saveResultsButton
            // 
            this.saveResultsButton.Location = new System.Drawing.Point(1556, 979);
            this.saveResultsButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveResultsButton.Name = "saveResultsButton";
            this.saveResultsButton.Size = new System.Drawing.Size(178, 77);
            this.saveResultsButton.TabIndex = 37;
            this.saveResultsButton.Text = "Save results";
            this.saveResultsButton.UseVisualStyleBackColor = true;
            this.saveResultsButton.Click += new System.EventHandler(this.saveResultsButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.percentLabel);
            this.panel1.Controls.Add(this.PMVtxtBox);
            this.panel1.Controls.Add(this.finalPMVLabel);
            this.panel1.Location = new System.Drawing.Point(2120, 964);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 106);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(16)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(2514, 1529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveResultsButton);
            this.Controls.Add(this.nonStructuralChBox);
            this.Controls.Add(this.nonStructuralDropdown);
            this.Controls.Add(this.Cat3groupBox3);
            this.Controls.Add(this.Cat2groupBox);
            this.Controls.Add(this.nonStructuralLabel);
            this.Controls.Add(this.Cat1groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Cat6checkedListBox1);
            this.Controls.Add(this.Cat7ChBox);
            this.Controls.Add(this.Cat5checkedListBox1);
            this.Controls.Add(this.specifyTextBox1);
            this.Controls.Add(this.specifylabel2);
            this.Controls.Add(this.chooseMaterialComboBox1);
            this.Controls.Add(this.chooseMaterialLabel2);
            this.Controls.Add(this.questStrucCompComboBox);
            this.Controls.Add(this.questStrucCompLabel);
            this.Controls.Add(this.structComponentsGroupBox);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buildingTypologyLabelcomboBox);
            this.Controls.Add(this.buildingTypologyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.structComponentsGroupBox.ResumeLayout(false);
            this.structComponentsGroupBox.PerformLayout();
            this.Cat1groupBox1.ResumeLayout(false);
            this.Cat1groupBox1.PerformLayout();
            this.Cat3groupBox3.ResumeLayout(false);
            this.Cat3groupBox3.PerformLayout();
            this.Cat2groupBox.ResumeLayout(false);
            this.Cat2groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buildingTypologyLabelcomboBox;
        private System.Windows.Forms.Label buildingTypologyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RadioButton Cat2radioButton;
        private System.Windows.Forms.GroupBox structComponentsGroupBox;
        private System.Windows.Forms.RadioButton Cat4radioButton;
        private System.Windows.Forms.RadioButton Cat3radioButton;
        private System.Windows.Forms.RadioButton cat1radioButton;
        private System.Windows.Forms.Label questStrucCompLabel;
        private System.Windows.Forms.ComboBox questStrucCompComboBox;
        private System.Windows.Forms.Label chooseMaterialLabel2;
        private System.Windows.Forms.ComboBox chooseMaterialComboBox1;
        private System.Windows.Forms.GroupBox Cat1groupBox1;
        private System.Windows.Forms.RadioButton Cat1cRadioButton;
        private System.Windows.Forms.RadioButton Cat1bRadioButton10;
        private System.Windows.Forms.RadioButton Cat1aRadioButton9;
        private System.Windows.Forms.GroupBox Cat3groupBox3;
        private System.Windows.Forms.RadioButton Cat3gradioButton21;
        private System.Windows.Forms.RadioButton Cat3fradioButton20;
        private System.Windows.Forms.RadioButton Cat3eradioButton19;
        private System.Windows.Forms.RadioButton Cat3dradioButton18;
        private System.Windows.Forms.RadioButton Cat3cradioButton15;
        private System.Windows.Forms.RadioButton Cat3bradioButton16;
        private System.Windows.Forms.RadioButton Cat3aradioButton17;
        private System.Windows.Forms.Label specifylabel2;
        private System.Windows.Forms.CheckedListBox Cat5checkedListBox1;
        private System.Windows.Forms.CheckedListBox Cat6checkedListBox1;
        private System.Windows.Forms.CheckedListBox Cat7ChBox;
        private System.Windows.Forms.TextBox PMVtxtBox;
        private System.Windows.Forms.Label finalPMVLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton Cat1dradioButton1;
        public System.Windows.Forms.TextBox specifyTextBox1;
        private System.Windows.Forms.Label nonStructuralLabel;
        private System.Windows.Forms.ComboBox nonStructuralDropdown;
        private System.Windows.Forms.CheckedListBox nonStructuralChBox;
        private System.Windows.Forms.GroupBox Cat2groupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton cat2aRadioButton;
        private System.Windows.Forms.Button saveResultsButton;
        private System.Windows.Forms.Panel panel1;
    }
}

