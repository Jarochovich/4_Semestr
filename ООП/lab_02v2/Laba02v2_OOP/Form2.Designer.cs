namespace Laba02v2_OOP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox4 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            trackBar1 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox5 = new GroupBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox5.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(31, 68);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(291, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите тип компьютера: ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(18, 95);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Сервер";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 61);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ноутбук";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 29);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(148, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Рабочая станция";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 240);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(374, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 216);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 4;
            label1.Text = "Выберите процессор";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(31, 291);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(322, 72);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите тип видеокарты:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(164, 35);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(111, 24);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "Дискретная";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(17, 35);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(112, 24);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Встроенная";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(radioButton10);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Location = new Point(328, 68);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(229, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите тип ОЗУ:";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(18, 35);
            radioButton10.Margin = new Padding(3, 4, 3, 4);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(69, 24);
            radioButton10.TabIndex = 4;
            radioButton10.TabStop = true;
            radioButton10.Text = "DDR3";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(18, 99);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(69, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "DDR5";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(18, 67);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(69, 24);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "DDR4";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(192, 255, 192);
            groupBox4.Controls.Add(radioButton8);
            groupBox4.Controls.Add(radioButton9);
            groupBox4.Location = new Point(601, 68);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(353, 101);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Выберите тип жесткого диска:";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(18, 61);
            radioButton8.Margin = new Padding(3, 4, 3, 4);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(63, 24);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "HDD";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(18, 29);
            radioButton9.Margin = new Padding(3, 4, 3, 4);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(57, 24);
            radioButton9.TabIndex = 0;
            radioButton9.TabStop = true;
            radioButton9.Text = "SSD";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(192, 255, 192);
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(381, 307);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 128;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(198, 56);
            trackBar1.SmallChange = 10;
            trackBar1.TabIndex = 6;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 283);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 7;
            label2.Text = "Выберите размер ОЗУ:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 192);
            label3.Name = "label3";
            label3.Size = new Size(247, 20);
            label3.TabIndex = 8;
            label3.Text = "Выберите размер жесткого диска:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown1.Location = new Point(601, 216);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 12800, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.ForeColor = Color.Green;
            button1.Location = new Point(18, 20);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 56);
            button1.TabIndex = 10;
            button1.Text = "Сохранить в JSON";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(206, 33);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 11;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(140, 75);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(107, 31);
            button3.TabIndex = 15;
            button3.Text = "Рассчитать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(192, 255, 192);
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(601, 251);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(353, 115);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Стоимость компьютеров в лаборатории:";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(505, 414);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(449, 28);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 390);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 14;
            label5.Text = "Выберите компьютер";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 480);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(968, 26);
            statusStrip1.TabIndex = 22;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(151, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(151, 20);
            toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(968, 27);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(91, 24);
            toolStripButton1.Text = "Процессор";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.ForeColor = Color.Black;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(56, 24);
            toolStripButton2.Text = "Поиск";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(96, 24);
            toolStripButton3.Text = "Сортировка";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(108, 24);
            toolStripButton4.Text = "О программе";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(122, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 80);
            panel1.TabIndex = 24;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 506);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox5);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox5.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private GroupBox groupBox4;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private TrackBar trackBar1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox5;
        private ComboBox comboBox2;
        private Label label5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private Panel panel1;
        private RadioButton radioButton10;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
    }
}