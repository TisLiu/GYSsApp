namespace GYSsApp2
{
    partial class TextChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextChanger));
            NameBox = new TextBox();
            LoveWordsLabel = new Label();
            LoveWordsBox = new TextBox();
            colorDialog1 = new ColorDialog();
            colorListBox = new ListBox();
            AddBox = new Button();
            DeleteBox = new Button();
            button1 = new Button();
            FontLabel = new Label();
            label1 = new Label();
            button2 = new Button();
            fontDialog1 = new FontDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            groupBox6 = new GroupBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox7 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox8 = new GroupBox();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            numericUpDown3 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(6, 27);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(229, 28);
            NameBox.TabIndex = 1;
            NameBox.TextChanged += textBox1_TextChanged;
            // 
            // LoveWordsLabel
            // 
            LoveWordsLabel.AutoSize = true;
            LoveWordsLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LoveWordsLabel.Location = new Point(12, 78);
            LoveWordsLabel.Name = "LoveWordsLabel";
            LoveWordsLabel.Size = new Size(0, 21);
            LoveWordsLabel.TabIndex = 2;
            // 
            // LoveWordsBox
            // 
            LoveWordsBox.Location = new Point(6, 27);
            LoveWordsBox.Multiline = true;
            LoveWordsBox.Name = "LoveWordsBox";
            LoveWordsBox.ScrollBars = ScrollBars.Both;
            LoveWordsBox.Size = new Size(228, 235);
            LoveWordsBox.TabIndex = 3;
            LoveWordsBox.TextChanged += LoveWordsBox_TextChanged;
            // 
            // colorListBox
            // 
            colorListBox.FormattingEnabled = true;
            colorListBox.ItemHeight = 21;
            colorListBox.Location = new Point(6, 49);
            colorListBox.Name = "colorListBox";
            colorListBox.Size = new Size(228, 88);
            colorListBox.TabIndex = 5;
            colorListBox.Click += colorListBox_Click;
            colorListBox.DataContextChanged += colorListBox_Click;
            // 
            // AddBox
            // 
            AddBox.BackColor = SystemColors.ActiveCaption;
            AddBox.ForeColor = Color.Lime;
            AddBox.Location = new Point(238, 22);
            AddBox.Name = "AddBox";
            AddBox.Size = new Size(28, 28);
            AddBox.TabIndex = 6;
            AddBox.Text = "+";
            AddBox.UseVisualStyleBackColor = false;
            AddBox.Click += btnAddColor_Click;
            // 
            // DeleteBox
            // 
            DeleteBox.BackColor = SystemColors.ActiveCaption;
            DeleteBox.Enabled = false;
            DeleteBox.ForeColor = Color.FromArgb(192, 0, 0);
            DeleteBox.Location = new Point(238, 50);
            DeleteBox.Name = "DeleteBox";
            DeleteBox.Size = new Size(28, 28);
            DeleteBox.TabIndex = 7;
            DeleteBox.Text = "×";
            DeleteBox.UseVisualStyleBackColor = false;
            DeleteBox.Click += btnDelColor_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(18, 515);
            button1.Name = "button1";
            button1.Size = new Size(82, 43);
            button1.TabIndex = 8;
            button1.Text = "回到默认";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FontLabel
            // 
            FontLabel.AutoSize = true;
            FontLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FontLabel.Location = new Point(13, 485);
            FontLabel.Name = "FontLabel";
            FontLabel.Size = new Size(45, 21);
            FontLabel.TabIndex = 9;
            FontLabel.Text = "Font";
            // 
            // label1
            // 
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(250, 281);
            label1.TabIndex = 10;
            label1.Text = "快狐跨懒狗";
            // 
            // button2
            // 
            button2.Location = new Point(6, 22);
            button2.Name = "button2";
            button2.Size = new Size(85, 33);
            button2.TabIndex = 11;
            button2.Text = "字体……";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(NameBox);
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 63);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "其名";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDark;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(LoveWordsBox);
            groupBox2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(12, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 273);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "情话(换行以分隔)";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.ForeColor = Color.Yellow;
            button4.Location = new Point(238, 27);
            button4.Name = "button4";
            button4.Size = new Size(28, 28);
            button4.TabIndex = 8;
            button4.Text = "？";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlDark;
            groupBox3.Controls.Add(DeleteBox);
            groupBox3.Controls.Add(AddBox);
            groupBox3.Controls.Add(colorListBox);
            groupBox3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox3.Location = new Point(12, 360);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 149);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "颜色";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlDark;
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox4.Location = new Point(291, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(262, 342);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "字体";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ControlDark;
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox5.Location = new Point(291, 360);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(262, 149);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "动画方法";
            // 
            // button3
            // 
            button3.Location = new Point(6, 83);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 1;
            button3.Text = "预览";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "direct", "gentle", "cool" });
            comboBox1.Location = new Point(6, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "direct";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ControlDark;
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(numericUpDown1);
            groupBox6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox6.Location = new Point(559, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(223, 87);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "延迟";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 37);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 1;
            label2.Text = "ms";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 35);
            numericUpDown1.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 28);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.ControlDark;
            groupBox7.Controls.Add(checkBox2);
            groupBox7.Controls.Add(checkBox1);
            groupBox7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox7.Location = new Point(559, 108);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(223, 115);
            groupBox7.TabIndex = 17;
            groupBox7.TabStop = false;
            groupBox7.Text = "流程";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(6, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "弹窗雨";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(6, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "爱心";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = SystemColors.ControlDark;
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(label6);
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(label8);
            groupBox8.Controls.Add(numericUpDown3);
            groupBox8.Controls.Add(label5);
            groupBox8.Controls.Add(label4);
            groupBox8.Controls.Add(label3);
            groupBox8.Controls.Add(numericUpDown2);
            groupBox8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox8.Location = new Point(559, 229);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(223, 280);
            groupBox8.TabIndex = 18;
            groupBox8.TabStop = false;
            groupBox8.Text = "生命周期";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 134);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(6, 214);
            label9.Name = "label9";
            label9.Size = new Size(115, 21);
            label9.TabIndex = 9;
            label9.Text = "设为0时为无尽";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 130);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 8;
            label6.Text = "应用程序";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(6, 185);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 7;
            label7.Text = "点击“开始”时计时";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 161);
            label8.Name = "label8";
            label8.Size = new Size(32, 21);
            label8.TabIndex = 5;
            label8.Text = "ms";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(6, 154);
            numericUpDown3.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 28);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 40);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 4;
            label5.Text = "弹窗";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 134);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(6, 95);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 3;
            label4.Text = "设为0时为无尽";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 71);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 2;
            label3.Text = "ms";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(6, 64);
            numericUpDown2.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 28);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // TextChanger
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(794, 569);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(FontLabel);
            Controls.Add(button1);
            Controls.Add(LoveWordsLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TextChanger";
            Text = "自定义";
            FormClosing += TextChanger_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameBox;
        private Label LoveWordsLabel;
        private TextBox LoveWordsBox;
        private ColorDialog colorDialog1;
        private ListBox colorListBox;
        private Button AddBox;
        private Button DeleteBox;
        private Button button1;
        private Label FontLabel;
        private Label label1;
        private Button button2;
        private FontDialog fontDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button3;
        private ComboBox comboBox1;
        private GroupBox groupBox6;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox7;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox8;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown3;
        private Button button4;
        private Label label9;
    }
}