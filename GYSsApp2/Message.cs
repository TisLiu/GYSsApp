namespace GYSsApp2
{
    /// <summary>
    /// 这个类是弹出的弹窗的类，
    /// 其拥有一系列复杂的属性和私有方法。
    /// </summary>
    public partial class Message : Form
    {
        internal Color MyBackcolor { get; set; }//背景色属性
        private string? _myText;//临时的字段
        internal string? Mytext
        {
            get => _myText;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _myText = value;
                    return;
                }

                DateTime now = DateTime.Now;

                // 日期格式
                string cnDate = now.ToString("yyyy年MM月dd日");
                string enDate = now.ToString("yyyy,MM,dd");
                string jpDate = now.ToString("yyyy年MM月dd日");
                string koDate = now.ToString("yyyy.MM.dd");

                // 全部替换
                string result = value
                    .Replace("{NAME}", Program.name)
                    .Replace("{TIME}", now.ToString("HH:mm:ss"))
                    .Replace("{DAY}", GetWeekDay())
                    .Replace("{DATE:CN}", cnDate)
                    .Replace("{DATE:EN}", enDate)
                    .Replace("{DATE:JP}", jpDate)
                    .Replace("{DATE:KO}", koDate);

                _myText = result;
            }//核心替换字符串逻辑
        }//设置Label显示的文字，并且带插入字符串
        internal Program.AnimationMethod? Animate { get; set; }//动画方法
        internal Font? MyFont { get; set; }//Label字体属性
        internal bool CanBeColse { get; set; }//手动关闭先决条件
        internal bool IsAutoClose { get; set; }//是否是自动关闭的Message

        private bool isClosing = false;//是否正在关闭

        private string GetWeekDay()
        {
            return DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "星期一",
                DayOfWeek.Tuesday => "星期二",
                DayOfWeek.Wednesday => "星期三",
                DayOfWeek.Thursday => "星期四",
                DayOfWeek.Friday => "星期五",
                DayOfWeek.Saturday => "星期六",
                DayOfWeek.Sunday => "星期日",
                _ => ""
            };
        }//获取星期

        public Message()
        {
            InitializeComponent();
            Opacity = 0.01f;
            DoubleBuffered = true;
        }//构造方法

        private async void KillSelf()
        {
            if (!IsAutoClose)
            {
                return;
            }

            if (Program.MessageLifeCycle <= 0)
            {
                return;
            }

            try
            {
                await Task.Delay(Program.MessageLifeCycle);

                if (!IsDisposed && !Disposing && CanBeColse)
                {
                    isClosing = true;
                    Close();
                }
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine($"KillSelf 异常: {ex.Message}"); }
        }//生命周期终结

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                KillSelf();
                ApplyWindowSettings();
                ApplyFont();
                ApplyBackgroundColor();
                ApplyText();
                await RunAnimation();
            }
            catch { }
        }//尝试设置this的样式

        private void ApplyWindowSettings()
        {
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
        }//设置为无边框，并且不在任务栏中显示

        private void ApplyFont()
        {
            label1.Font = MyFont ?? Program.defaultFont;
        }//设置字体样式

        private void ApplyBackgroundColor()
        {
            if (Program.Colors.Length > 0)
            {
                BackColor = Program.Colors[new Random().Next(Program.Colors.Length)];
            }
        }//设置背景色

        private void ApplyText()
        {
            if (string.IsNullOrWhiteSpace(Mytext))
            {
                Size = new Size(12, 12);
                label1.Visible = false;
                return;
            }

            label1.Visible = true;
            label1.AutoSize = true;
            label1.Text = Mytext;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.ForeColor = GetContrastColor();

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }//设置文字的显示

        private Color GetContrastColor()
        {
            return Color.FromArgb(255, 255 - BackColor.R, 255 - BackColor.G, 255 - BackColor.B);
        }//获取反向于背景色的颜色

        private async Task RunAnimation()
        {
            Program.AnimationMethod anim = Animate ?? Program.AnimationMethod.gentle;

            switch (anim)
            {
                case Program.AnimationMethod.direct:
                    await An_Direct();
                    break;
                case Program.AnimationMethod.gentle:
                    await An_Gentle();
                    break;
                case Program.AnimationMethod.cool:
                    await An_Cool();
                    break;
                case Program.AnimationMethod.NoFloat:
                    await An_NoFloat();
                    break;
            }
        }//选择动画

        private async Task An_Direct()
        {
            Opacity = 1;
            await Task.CompletedTask;
        }//动画——直接的

        private async Task An_Gentle()
        {
            while (Opacity < 1 && !isClosing)
            {
                Opacity += 0.05f;
                Location = new Point(Location.X, Location.Y - 1);
                await Task.Delay(16);
            }
        }//动画——轻柔的

        private async Task An_Cool()
        {
            while (Opacity < 1 && !isClosing)
            {
                Opacity += 0.12f;
                Location = new Point(Location.X, Location.Y - 2);
                await Task.Delay(16);
            }
        }//动画——酷的

        private async Task An_NoFloat()
        {
            while (Opacity < 1 && !isClosing)
            {
                Opacity += 0.12f;
                await Task.Delay(16);
            }
        }//动画——不漂浮的
    }
}