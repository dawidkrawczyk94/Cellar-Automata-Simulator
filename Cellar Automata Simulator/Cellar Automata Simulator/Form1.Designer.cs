namespace Cellar_Automata_Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.neighboors_cbox = new System.Windows.Forms.ComboBox();
            this.phopt_cbox = new System.Windows.Forms.ComboBox();
            this.start_bt = new System.Windows.Forms.Button();
            this.step_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.main_pct = new System.Windows.Forms.PictureBox();
            this.current_color_pct = new System.Windows.Forms.PictureBox();
            this.inclusion_pct = new System.Windows.Forms.PictureBox();
            this.clr_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GBCcheck_box = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exportBt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.seedsCount = new System.Windows.Forms.NumericUpDown();
            this.inclusionsCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maxR = new System.Windows.Forms.NumericUpDown();
            this.minR = new System.Windows.Forms.NumericUpDown();
            this.xPropability = new System.Windows.Forms.NumericUpDown();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.select_bt = new System.Windows.Forms.Button();
            this.selected_label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.phase_bt = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lenght_lab = new System.Windows.Forms.Label();
            this.mark_bdr_bt = new System.Windows.Forms.Button();
            this.mean_size_lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.main_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_color_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclusion_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPropability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Neighboors";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pentagonal/Hexagonal options";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // neighboors_cbox
            // 
            this.neighboors_cbox.FormattingEnabled = true;
            this.neighboors_cbox.Items.AddRange(new object[] {
            "von Neumanna",
            "Moore’a",
            "Hexagonal",
            "Pentagonal"});
            this.neighboors_cbox.Location = new System.Drawing.Point(243, 37);
            this.neighboors_cbox.Name = "neighboors_cbox";
            this.neighboors_cbox.Size = new System.Drawing.Size(121, 23);
            this.neighboors_cbox.TabIndex = 2;
            this.neighboors_cbox.SelectedIndexChanged += new System.EventHandler(this.neighboors_cbox_SelectedIndexChanged);
            // 
            // phopt_cbox
            // 
            this.phopt_cbox.FormattingEnabled = true;
            this.phopt_cbox.Location = new System.Drawing.Point(383, 37);
            this.phopt_cbox.Name = "phopt_cbox";
            this.phopt_cbox.Size = new System.Drawing.Size(121, 23);
            this.phopt_cbox.TabIndex = 2;
            // 
            // start_bt
            // 
            this.start_bt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.start_bt.Location = new System.Drawing.Point(816, 37);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(75, 23);
            this.start_bt.TabIndex = 3;
            this.start_bt.Text = "Start";
            this.start_bt.UseVisualStyleBackColor = false;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // step_bt
            // 
            this.step_bt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.step_bt.Location = new System.Drawing.Point(911, 36);
            this.step_bt.Name = "step_bt";
            this.step_bt.Size = new System.Drawing.Size(75, 23);
            this.step_bt.TabIndex = 3;
            this.step_bt.Text = "Step";
            this.step_bt.UseVisualStyleBackColor = false;
            this.step_bt.Click += new System.EventHandler(this.step_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(890, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seeds";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(898, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Inclusion";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(984, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "r=";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_pct
            // 
            this.main_pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_pct.Location = new System.Drawing.Point(19, 66);
            this.main_pct.Name = "main_pct";
            this.main_pct.Size = new System.Drawing.Size(500, 500);
            this.main_pct.TabIndex = 4;
            this.main_pct.TabStop = false;
            this.main_pct.Click += new System.EventHandler(this.main_pct_Click);
            // 
            // current_color_pct
            // 
            this.current_color_pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_color_pct.Location = new System.Drawing.Point(1004, 131);
            this.current_color_pct.Name = "current_color_pct";
            this.current_color_pct.Size = new System.Drawing.Size(51, 52);
            this.current_color_pct.TabIndex = 4;
            this.current_color_pct.TabStop = false;
            this.current_color_pct.Click += new System.EventHandler(this.current_color_pct_Click);
            // 
            // inclusion_pct
            // 
            this.inclusion_pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inclusion_pct.Location = new System.Drawing.Point(1004, 402);
            this.inclusion_pct.Name = "inclusion_pct";
            this.inclusion_pct.Size = new System.Drawing.Size(70, 70);
            this.inclusion_pct.TabIndex = 4;
            this.inclusion_pct.TabStop = false;
            this.inclusion_pct.Click += new System.EventHandler(this.inclusion_pct_Click);
            // 
            // clr_bt
            // 
            this.clr_bt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clr_bt.Location = new System.Drawing.Point(816, 66);
            this.clr_bt.Name = "clr_bt";
            this.clr_bt.Size = new System.Drawing.Size(75, 23);
            this.clr_bt.TabIndex = 5;
            this.clr_bt.Text = "Clear";
            this.clr_bt.UseVisualStyleBackColor = false;
            this.clr_bt.Click += new System.EventHandler(this.clr_bt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(911, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GBCcheck_box
            // 
            this.GBCcheck_box.AutoSize = true;
            this.GBCcheck_box.Location = new System.Drawing.Point(572, 10);
            this.GBCcheck_box.Name = "GBCcheck_box";
            this.GBCcheck_box.Size = new System.Drawing.Size(163, 19);
            this.GBCcheck_box.TabIndex = 7;
            this.GBCcheck_box.Text = "Grain Boundary Curvature";
            this.GBCcheck_box.UseVisualStyleBackColor = true;
            this.GBCcheck_box.CheckedChanged += new System.EventHandler(this.GBCcheck_box_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Neighboors";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "X - probability of change [%]";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // exportBt
            // 
            this.exportBt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.exportBt.Location = new System.Drawing.Point(992, 36);
            this.exportBt.Name = "exportBt";
            this.exportBt.Size = new System.Drawing.Size(116, 23);
            this.exportBt.TabIndex = 10;
            this.exportBt.Text = "Export Bitmap";
            this.exportBt.UseVisualStyleBackColor = false;
            this.exportBt.Click += new System.EventHandler(this.exportBt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(992, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Import Bitmap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Location = new System.Drawing.Point(860, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add seeds";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Location = new System.Drawing.Point(860, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Add inclusions";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(823, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Count=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(843, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Count=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1212, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "r=";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1212, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "r=";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(860, 421);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Max. r=";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1332, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Min. r=";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // seedsCount
            // 
            this.seedsCount.Location = new System.Drawing.Point(877, 143);
            this.seedsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seedsCount.Name = "seedsCount";
            this.seedsCount.Size = new System.Drawing.Size(63, 23);
            this.seedsCount.TabIndex = 18;
            // 
            // inclusionsCount
            // 
            this.inclusionsCount.Location = new System.Drawing.Point(890, 360);
            this.inclusionsCount.Name = "inclusionsCount";
            this.inclusionsCount.Size = new System.Drawing.Size(63, 23);
            this.inclusionsCount.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1288, 512);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 23);
            this.numericUpDown1.TabIndex = 18;
            // 
            // maxR
            // 
            this.maxR.Location = new System.Drawing.Point(907, 419);
            this.maxR.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maxR.Name = "maxR";
            this.maxR.Size = new System.Drawing.Size(63, 23);
            this.maxR.TabIndex = 18;
            // 
            // minR
            // 
            this.minR.Location = new System.Drawing.Point(907, 389);
            this.minR.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.minR.Name = "minR";
            this.minR.Size = new System.Drawing.Size(63, 23);
            this.minR.TabIndex = 18;
            // 
            // xPropability
            // 
            this.xPropability.Location = new System.Drawing.Point(572, 39);
            this.xPropability.Name = "xPropability";
            this.xPropability.Size = new System.Drawing.Size(41, 23);
            this.xPropability.TabIndex = 19;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(1004, 360);
            this.R.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(63, 23);
            this.R.TabIndex = 18;
            this.R.ValueChanged += new System.EventHandler(this.R_ValueChanged);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(19, 36);
            this.widthBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(91, 23);
            this.widthBox.TabIndex = 20;
            this.widthBox.ValueChanged += new System.EventHandler(this.widthBox_ValueChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(129, 36);
            this.heightBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(87, 23);
            this.heightBox.TabIndex = 21;
            this.heightBox.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // select_bt
            // 
            this.select_bt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.select_bt.Location = new System.Drawing.Point(612, 91);
            this.select_bt.Name = "select_bt";
            this.select_bt.Size = new System.Drawing.Size(96, 23);
            this.select_bt.TabIndex = 22;
            this.select_bt.Text = "Select grain";
            this.select_bt.UseVisualStyleBackColor = false;
            this.select_bt.Click += new System.EventHandler(this.select_bt_Click);
            // 
            // selected_label
            // 
            this.selected_label.AutoSize = true;
            this.selected_label.Location = new System.Drawing.Point(612, 151);
            this.selected_label.Name = "selected_label";
            this.selected_label.Size = new System.Drawing.Size(44, 15);
            this.selected_label.TabIndex = 23;
            this.selected_label.Text = "label16";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button6.Location = new System.Drawing.Point(612, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Clear selected color list";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button7.Location = new System.Drawing.Point(612, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Remove not selected";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // phase_bt
            // 
            this.phase_bt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phase_bt.Location = new System.Drawing.Point(612, 221);
            this.phase_bt.Name = "phase_bt";
            this.phase_bt.Size = new System.Drawing.Size(135, 23);
            this.phase_bt.TabIndex = 26;
            this.phase_bt.Text = "Mark as phase";
            this.phase_bt.UseVisualStyleBackColor = false;
            this.phase_bt.Click += new System.EventHandler(this.button5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(860, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Min. r=";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // lenght_lab
            // 
            this.lenght_lab.AutoSize = true;
            this.lenght_lab.Location = new System.Drawing.Point(612, 272);
            this.lenght_lab.Name = "lenght_lab";
            this.lenght_lab.Size = new System.Drawing.Size(44, 15);
            this.lenght_lab.TabIndex = 23;
            this.lenght_lab.Text = "label16";
            // 
            // mark_bdr_bt
            // 
            this.mark_bdr_bt.Location = new System.Drawing.Point(612, 310);
            this.mark_bdr_bt.Name = "mark_bdr_bt";
            this.mark_bdr_bt.Size = new System.Drawing.Size(123, 23);
            this.mark_bdr_bt.TabIndex = 27;
            this.mark_bdr_bt.Text = "Mark boundaries";
            this.mark_bdr_bt.UseVisualStyleBackColor = true;
            this.mark_bdr_bt.Click += new System.EventHandler(this.mark_bdr_bt_Click);
            // 
            // mean_size_lab
            // 
            this.mean_size_lab.AutoSize = true;
            this.mean_size_lab.Location = new System.Drawing.Point(612, 292);
            this.mean_size_lab.Name = "mean_size_lab";
            this.mean_size_lab.Size = new System.Drawing.Size(44, 15);
            this.mean_size_lab.TabIndex = 23;
            this.mean_size_lab.Text = "label16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 614);
            this.Controls.Add(this.mark_bdr_bt);
            this.Controls.Add(this.phase_bt);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.selected_label);
            this.Controls.Add(this.select_bt);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.xPropability);
            this.Controls.Add(this.seedsCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exportBt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GBCcheck_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clr_bt);
            this.Controls.Add(this.main_pct);
            this.Controls.Add(this.start_bt);
            this.Controls.Add(this.neighboors_cbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phopt_cbox);
            this.Controls.Add(this.step_bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.current_color_pct);
            this.Controls.Add(this.inclusion_pct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.inclusionsCount);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.maxR);
            this.Controls.Add(this.minR);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lenght_lab);
            this.Controls.Add(this.mean_size_lab);
            this.Name = "Form1";
            this.Text = "Cellar Automata";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_color_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclusion_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPropability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox neighboors_cbox;
        private System.Windows.Forms.ComboBox phopt_cbox;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Button step_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox main_pct;
        private System.Windows.Forms.PictureBox current_color_pct;
        private System.Windows.Forms.PictureBox inclusion_pct;
        private System.Windows.Forms.Button clr_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox GBCcheck_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exportBt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown seedsCount;
        private System.Windows.Forms.NumericUpDown inclusionsCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown maxR;
        private System.Windows.Forms.NumericUpDown minR;
        private System.Windows.Forms.NumericUpDown xPropability;
        private System.Windows.Forms.NumericUpDown R;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.Button select_bt;
        private System.Windows.Forms.Label selected_label;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button phase_bt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lenght_lab;
        private System.Windows.Forms.Button mark_bdr_bt;
        private System.Windows.Forms.Label mean_size_lab;
    }
}

