namespace GYSsApp2
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            label1 = new Label();
            label2 = new Label();
            GO_button = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 62);
            label1.TabIndex = 0;
            label1.Text = "警告";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(322, 125);
            label2.TabIndex = 1;
            label2.Text = "该程序会无限弹出大量窗体，\r\n会占用大量内存，\r\n也可能导致程序无法关闭。\r\n请牢记，按下Escape可以关闭程序，\r\n别怪我没提醒过你 : )";
            // 
            // GO_button
            // 
            GO_button.Location = new Point(12, 213);
            GO_button.Name = "GO_button";
            GO_button.Size = new Size(75, 23);
            GO_button.TabIndex = 2;
            GO_button.Text = "开始";
            GO_button.UseVisualStyleBackColor = true;
            GO_button.Click += Go_button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(253, 213);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "退出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(253, 12);
            button1.Name = "button1";
            button1.Size = new Size(72, 42);
            button1.TabIndex = 4;
            button1.Text = "自定义……";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(148, 12);
            button3.Name = "button3";
            button3.Size = new Size(99, 42);
            button3.TabIndex = 5;
            button3.Text = "关于……";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 248);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(GO_button);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "警告";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button GO_button;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}