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
            this.width_tbox = new System.Windows.Forms.TextBox();
            this.height_tbox = new System.Windows.Forms.TextBox();
            this.neighboors_cbox = new System.Windows.Forms.ComboBox();
            this.phopt_cbox = new System.Windows.Forms.ComboBox();
            this.start_bt = new System.Windows.Forms.Button();
            this.step_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.main_pct = new System.Windows.Forms.PictureBox();
            this.current_color_pct = new System.Windows.Forms.PictureBox();
            this.red_pct = new System.Windows.Forms.PictureBox();
            this.green_pct = new System.Windows.Forms.PictureBox();
            this.yellow_pct = new System.Windows.Forms.PictureBox();
            this.blue_pct = new System.Windows.Forms.PictureBox();
            this.pink_pct = new System.Windows.Forms.PictureBox();
            this.brown_pct = new System.Windows.Forms.PictureBox();
            this.orange_pct = new System.Windows.Forms.PictureBox();
            this.gray_pct = new System.Windows.Forms.PictureBox();
            this.inclusion_pct = new System.Windows.Forms.PictureBox();
            this.clr_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GBCcheck_box = new System.Windows.Forms.CheckBox();
            this.propability_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exportBt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_color_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brown_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray_pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclusion_pct)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Heigh";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Neighboors";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pentagonal/Hexagonal options";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // width_tbox
            // 
            this.width_tbox.Location = new System.Drawing.Point(13, 37);
            this.width_tbox.Name = "width_tbox";
            this.width_tbox.Size = new System.Drawing.Size(100, 23);
            this.width_tbox.TabIndex = 1;
            this.width_tbox.TextChanged += new System.EventHandler(this.width_tbox_TextChanged);
            // 
            // height_tbox
            // 
            this.height_tbox.Location = new System.Drawing.Point(129, 37);
            this.height_tbox.Name = "height_tbox";
            this.height_tbox.Size = new System.Drawing.Size(100, 23);
            this.height_tbox.TabIndex = 1;
            this.height_tbox.TextChanged += new System.EventHandler(this.height_tbox_TextChanged);
            // 
            // neighboors_cbox
            // 
            this.neighboors_cbox.FormattingEnabled = true;
            this.neighboors_cbox.Items.AddRange(new object[] {
            "von Neumanna",
            "Moore’a",
            "Hexagonal",
            "Pentagonal"});
            this.neighboors_cbox.Location = new System.Drawing.Point(257, 37);
            this.neighboors_cbox.Name = "neighboors_cbox";
            this.neighboors_cbox.Size = new System.Drawing.Size(121, 23);
            this.neighboors_cbox.TabIndex = 2;
            this.neighboors_cbox.SelectedIndexChanged += new System.EventHandler(this.neighboors_cbox_SelectedIndexChanged);
            // 
            // phopt_cbox
            // 
            this.phopt_cbox.FormattingEnabled = true;
            this.phopt_cbox.Location = new System.Drawing.Point(430, 37);
            this.phopt_cbox.Name = "phopt_cbox";
            this.phopt_cbox.Size = new System.Drawing.Size(121, 23);
            this.phopt_cbox.TabIndex = 2;
            // 
            // start_bt
            // 
            this.start_bt.Location = new System.Drawing.Point(816, 37);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(75, 23);
            this.start_bt.TabIndex = 3;
            this.start_bt.Text = "Start";
            this.start_bt.UseVisualStyleBackColor = true;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // step_bt
            // 
            this.step_bt.Location = new System.Drawing.Point(911, 36);
            this.step_bt.Name = "step_bt";
            this.step_bt.Size = new System.Drawing.Size(75, 23);
            this.step_bt.TabIndex = 3;
            this.step_bt.Text = "Step";
            this.step_bt.UseVisualStyleBackColor = true;
            this.step_bt.Click += new System.EventHandler(this.step_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grain color";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(911, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Inclusion";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(891, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "r=";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(911, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // main_pct
            // 
            this.main_pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_pct.Location = new System.Drawing.Point(13, 79);
            this.main_pct.Name = "main_pct";
            this.main_pct.Size = new System.Drawing.Size(500, 500);
            this.main_pct.TabIndex = 4;
            this.main_pct.TabStop = false;
            this.main_pct.Click += new System.EventHandler(this.main_pct_Click);
            // 
            // current_color_pct
            // 
            this.current_color_pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_color_pct.Location = new System.Drawing.Point(840, 154);
            this.current_color_pct.Name = "current_color_pct";
            this.current_color_pct.Size = new System.Drawing.Size(70, 70);
            this.current_color_pct.TabIndex = 4;
            this.current_color_pct.TabStop = false;
            this.current_color_pct.Click += new System.EventHandler(this.current_color_pct_Click);
            // 
            // red_pct
            // 
            this.red_pct.Location = new System.Drawing.Point(933, 154);
            this.red_pct.Name = "red_pct";
            this.red_pct.Size = new System.Drawing.Size(30, 30);
            this.red_pct.TabIndex = 4;
            this.red_pct.TabStop = false;
            this.red_pct.Click += new System.EventHandler(this.red_pct_Click);
            // 
            // green_pct
            // 
            this.green_pct.Location = new System.Drawing.Point(969, 154);
            this.green_pct.Name = "green_pct";
            this.green_pct.Size = new System.Drawing.Size(30, 30);
            this.green_pct.TabIndex = 4;
            this.green_pct.TabStop = false;
            this.green_pct.Click += new System.EventHandler(this.green_pct_Click);
            // 
            // yellow_pct
            // 
            this.yellow_pct.Location = new System.Drawing.Point(969, 190);
            this.yellow_pct.Name = "yellow_pct";
            this.yellow_pct.Size = new System.Drawing.Size(30, 30);
            this.yellow_pct.TabIndex = 4;
            this.yellow_pct.TabStop = false;
            this.yellow_pct.Click += new System.EventHandler(this.yellow_pct_Click);
            // 
            // blue_pct
            // 
            this.blue_pct.Location = new System.Drawing.Point(933, 190);
            this.blue_pct.Name = "blue_pct";
            this.blue_pct.Size = new System.Drawing.Size(30, 30);
            this.blue_pct.TabIndex = 4;
            this.blue_pct.TabStop = false;
            this.blue_pct.Click += new System.EventHandler(this.blue_pct_Click);
            // 
            // pink_pct
            // 
            this.pink_pct.Location = new System.Drawing.Point(969, 226);
            this.pink_pct.Name = "pink_pct";
            this.pink_pct.Size = new System.Drawing.Size(30, 30);
            this.pink_pct.TabIndex = 4;
            this.pink_pct.TabStop = false;
            this.pink_pct.Click += new System.EventHandler(this.pink_pct_Click);
            // 
            // brown_pct
            // 
            this.brown_pct.Location = new System.Drawing.Point(933, 226);
            this.brown_pct.Name = "brown_pct";
            this.brown_pct.Size = new System.Drawing.Size(30, 30);
            this.brown_pct.TabIndex = 4;
            this.brown_pct.TabStop = false;
            this.brown_pct.Click += new System.EventHandler(this.brown_pct_Click);
            // 
            // orange_pct
            // 
            this.orange_pct.Location = new System.Drawing.Point(933, 262);
            this.orange_pct.Name = "orange_pct";
            this.orange_pct.Size = new System.Drawing.Size(30, 30);
            this.orange_pct.TabIndex = 4;
            this.orange_pct.TabStop = false;
            this.orange_pct.Click += new System.EventHandler(this.orange_pct_Click);
            // 
            // gray_pct
            // 
            this.gray_pct.Location = new System.Drawing.Point(969, 262);
            this.gray_pct.Name = "gray_pct";
            this.gray_pct.Size = new System.Drawing.Size(30, 30);
            this.gray_pct.TabIndex = 4;
            this.gray_pct.TabStop = false;
            this.gray_pct.Click += new System.EventHandler(this.black_pct_Click);
            // 
            // inclusion_pct
            // 
            this.inclusion_pct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inclusion_pct.Location = new System.Drawing.Point(906, 408);
            this.inclusion_pct.Name = "inclusion_pct";
            this.inclusion_pct.Size = new System.Drawing.Size(70, 70);
            this.inclusion_pct.TabIndex = 4;
            this.inclusion_pct.TabStop = false;
            this.inclusion_pct.Click += new System.EventHandler(this.inclusion_pct_Click);
            // 
            // clr_bt
            // 
            this.clr_bt.Location = new System.Drawing.Point(816, 66);
            this.clr_bt.Name = "clr_bt";
            this.clr_bt.Size = new System.Drawing.Size(75, 23);
            this.clr_bt.TabIndex = 5;
            this.clr_bt.Text = "Clear";
            this.clr_bt.UseVisualStyleBackColor = true;
            this.clr_bt.Click += new System.EventHandler(this.clr_bt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GBCcheck_box
            // 
            this.GBCcheck_box.AutoSize = true;
            this.GBCcheck_box.Location = new System.Drawing.Point(589, 37);
            this.GBCcheck_box.Name = "GBCcheck_box";
            this.GBCcheck_box.Size = new System.Drawing.Size(163, 19);
            this.GBCcheck_box.TabIndex = 7;
            this.GBCcheck_box.Text = "Grain Boundary Curvature";
            this.GBCcheck_box.UseVisualStyleBackColor = true;
            this.GBCcheck_box.CheckedChanged += new System.EventHandler(this.GBCcheck_box_CheckedChanged);
            // 
            // propability_tbox
            // 
            this.propability_tbox.Location = new System.Drawing.Point(589, 62);
            this.propability_tbox.Name = "propability_tbox";
            this.propability_tbox.Size = new System.Drawing.Size(41, 23);
            this.propability_tbox.TabIndex = 8;
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
            this.label9.Location = new System.Drawing.Point(636, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "X - probability of change [%]";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // exportBt
            // 
            this.exportBt.Location = new System.Drawing.Point(992, 36);
            this.exportBt.Name = "exportBt";
            this.exportBt.Size = new System.Drawing.Size(116, 23);
            this.exportBt.TabIndex = 10;
            this.exportBt.Text = "Export to BMP";
            this.exportBt.UseVisualStyleBackColor = true;
            this.exportBt.Click += new System.EventHandler(this.exportBt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(992, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Import from BMP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exportBt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.propability_tbox);
            this.Controls.Add(this.GBCcheck_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clr_bt);
            this.Controls.Add(this.main_pct);
            this.Controls.Add(this.start_bt);
            this.Controls.Add(this.neighboors_cbox);
            this.Controls.Add(this.width_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.height_tbox);
            this.Controls.Add(this.phopt_cbox);
            this.Controls.Add(this.step_bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.current_color_pct);
            this.Controls.Add(this.red_pct);
            this.Controls.Add(this.green_pct);
            this.Controls.Add(this.yellow_pct);
            this.Controls.Add(this.blue_pct);
            this.Controls.Add(this.pink_pct);
            this.Controls.Add(this.brown_pct);
            this.Controls.Add(this.orange_pct);
            this.Controls.Add(this.gray_pct);
            this.Controls.Add(this.inclusion_pct);
            this.Name = "Form1";
            this.Text = "Cellar Automata";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_color_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brown_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray_pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclusion_pct)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox width_tbox;
        private System.Windows.Forms.TextBox height_tbox;
        private System.Windows.Forms.ComboBox neighboors_cbox;
        private System.Windows.Forms.ComboBox phopt_cbox;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Button step_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox main_pct;
        private System.Windows.Forms.PictureBox current_color_pct;
        private System.Windows.Forms.PictureBox red_pct;
        private System.Windows.Forms.PictureBox green_pct;
        private System.Windows.Forms.PictureBox yellow_pct;
        private System.Windows.Forms.PictureBox blue_pct;
        private System.Windows.Forms.PictureBox pink_pct;
        private System.Windows.Forms.PictureBox brown_pct;
        private System.Windows.Forms.PictureBox orange_pct;
        private System.Windows.Forms.PictureBox gray_pct;
        private System.Windows.Forms.PictureBox inclusion_pct;
        private System.Windows.Forms.Button clr_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox GBCcheck_box;
        private System.Windows.Forms.TextBox propability_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exportBt;
        private System.Windows.Forms.Button button2;
    }
}

