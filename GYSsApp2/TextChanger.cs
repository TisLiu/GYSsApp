namespace GYSsApp2
{
    public partial class TextChanger : Form
    {
        public TextChanger()
        {
            InitializeComponent();

            // 强制开启自定义绘制
            colorListBox.DrawMode = DrawMode.OwnerDrawFixed;
            colorListBox.ItemHeight = 26;

            NameBox.Text = Program.name;
            LoveWordsBox.Lines = Program.LoveWords;
            RefreshColorList();
            fontDialog1.Font = Program.defaultFont;
            label1.Font = fontDialog1.Font;
            comboBox1.DataSource = Enum.GetValues(typeof(Program.AnimationMethod));
            comboBox1.SelectedItem = Program.animationMethod;
            numericUpDown1.Value = Program.delaytime;
            numericUpDown2.Value = Program.MessageLifeCycle;
            numericUpDown3.Value = Program.AppLifeCycle;
            checkBox1.Checked = Program.NeedHeart;
            checkBox2.Checked = Program.NeedRain;
        }

        private void RefreshColorList()
        {
            colorListBox.Items.Clear();
            foreach (Color c in Program.Colors)
            {
                _ = colorListBox.Items.Add(c);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.name = NameBox.Text;
        }

        private void LoveWordsBox_TextChanged(object sender, EventArgs e)
        {
            Program.LoveWords = LoveWordsBox.Lines
                                 .Where(line => !string.IsNullOrWhiteSpace(line))
                                 .ToArray();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.Colors = Program.Colors.Append(colorDialog1.Color).ToArray();
                RefreshColorList();
            }
        }

        private void btnDelColor_Click(object sender, EventArgs e)
        {
            if (colorListBox.SelectedItem is Color selectColor)
            {
                Program.Colors = Program.Colors.Where(c => c != selectColor).ToArray();
                RefreshColorList();
            }
        }

        // ✅ 修复：安全绘制，永不崩溃，颜色正常显示
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            colorListBox.DrawItem += (s, ev) =>
            {
                // 核心修复：判断索引无效直接跳过，解决 -1 报错
                if (ev.Index < 0 || ev.Index >= colorListBox.Items.Count)
                {
                    ev.DrawBackground();
                    ev.DrawFocusRectangle();
                    return;
                }

                // 安全获取颜色
                Color col = (Color)colorListBox.Items[ev.Index];

                // 绘制颜色块
                using (SolidBrush br = new(col))
                {
                    ev.Graphics.FillRectangle(br, ev.Bounds);
                }

                using (Pen borderPen = new(Color.DarkGray, 1))
                {
                    // 边框向内缩1像素，不会贴边溢出
                    Rectangle borderRect = new(
                        ev.Bounds.X + 1,
                        ev.Bounds.Y + 1,
                        ev.Bounds.Width - 2,
                        ev.Bounds.Height - 2
                    );
                    ev.Graphics.DrawRectangle(borderPen, borderRect);
                }

                ev.DrawFocusRectangle();
            };
        }

        private void colorListBox_Click(object sender, EventArgs e)
        {
            DeleteBox.Enabled = colorListBox.SelectedIndex != -1;
        }

        private void TextChanger_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveHelper.SaveAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //显示对话框
            DialogResult dr = MessageBox.Show("是否将设定恢复到默认？", "GYSsApp", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //名字
                Program.name = "无名氏";

                //情话
                Program.LoveWords =
                [
                    "早点休息呀",
                    "我很在意你",
                    "记得多穿衣",
                    "我一直在的",
                    "今天累不累",
                    "好好吃饭呀",
                    "别太苛责自己",
                    "慢点走，不急",
                    "我陪你聊聊",
                    "你不用逞强",
                    "路上注意安全",
                    "忙完回我就好",
                    "多喝水，保重",
                    "永远支持你",
                    "今天开心吗",
                    "也请照顾自己",
                    "我在等你消息",
                    "别一个人扛",
                    "新的一天加油",
                    "我真的很想你"
                ];

                //颜色库
                Program.Colors =
                [
                    Color.LightPink,
                    Color.Pink,
                    Color.HotPink,
                    Color.Lavender,
                    Color.Plum,
                    Color.Violet,
                    Color.LightSalmon,
                    Color.PeachPuff,
                    Color.IndianRed
                ];
                //字体更新
                Program.defaultFont = new Font("微软雅黑", 42, FontStyle.Bold);

                //动画更新
                Program.animationMethod = Program.AnimationMethod.direct;

                //延迟时间更新
                Program.delaytime = 80;

                //Message生命周期更新
                Program.MessageLifeCycle = 0;

                //App生命周期更新
                Program.AppLifeCycle = 0;



                //界面更新
                NameBox.Text = Program.name;
                LoveWordsBox.Lines = Program.LoveWords;
                RefreshColorList();
                fontDialog1.Font = Program.defaultFont;
                label1.Font = fontDialog1.Font;
                comboBox1.DataSource = Enum.GetValues(typeof(Program.AnimationMethod));
                comboBox1.SelectedItem = Program.animationMethod;
                numericUpDown1.Value = Program.delaytime;
                numericUpDown2.Value = Program.MessageLifeCycle;
                numericUpDown3.Value = Program.AppLifeCycle;
                checkBox1.Checked = Program.NeedHeart;
                checkBox2.Checked = Program.NeedRain;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ = fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
            Program.defaultFont = fontDialog1.Font;
        }

        //预览
        private async void button3_Click(object sender, EventArgs e)
        {
            Random random = new();

            Message message = new()
            {
                Mytext = Program.LoveWords[random.Next(Program.LoveWords.Length)],
                StartPosition = FormStartPosition.CenterScreen,
                MyFont = Program.defaultFont,
                Animate = Program.animationMethod
            };
            message.Show();
            await Task.Delay(5000);
            message.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
#pragma warning disable CS8605 // 取消装箱可能为 null 的值。
            Program.animationMethod = (Program.AnimationMethod)comboBox1.SelectedItem;
#pragma warning restore CS8605 // 取消装箱可能为 null 的值。
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.delaytime = Convert.ToInt32(numericUpDown1.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.NeedHeart = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Program.NeedRain = checkBox2.Checked;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Program.MessageLifeCycle = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Program.AppLifeCycle = Convert.ToInt32(numericUpDown3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("@\"=======================\r\n【变量替换使用教程】\r\n=======================\r\n在 Love Words 里可以直接使用以下变量：\r\n\r\n{NAME}        → 替换成你设置的昵称\r\n{TIME}         → 替换成当前时间\r\n{DAY}          → 替换成星期几\r\n\r\n{DATE:CN}   → 中文日期（2025年12月22日）\r\n{DATE:EN}   → 英文日期（2025,12,22）\r\n{DATE:JP}   → 日文日期（2025年12月22日）\r\n{DATE:KO}   → 韩文日期（2025.12.22）\r\n\r\n=======================\r\n使用例子：\r\n{NAME}，现在是 {TIME}\r\n今天是 {DATE:CN} {DAY}\r\n=======================\";", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}