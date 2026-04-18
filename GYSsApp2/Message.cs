namespace GYSsApp2
{
    public partial class Message : Form
    {
        internal Color MyBackcolor { get; set; }
        private string? _myText;
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
            }
        }
        internal Program.AnimationMethod? Animate { get; set; }
        internal Font? MyFont { get; set; }
        internal bool CanBeColse { get; set; }
        internal bool IsAutoClose { get; set; }

        private bool isClosing = false;

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
        }

        public Message()
        {
            InitializeComponent();
            Opacity = 0.01f;
            DoubleBuffered = true;
        }

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
            catch { }
        }

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
        }

        private void ApplyWindowSettings()
        {
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
        }

        private void ApplyFont()
        {
            label1.Font = MyFont ?? Program.defaultFont;
        }

        private void ApplyBackgroundColor()
        {
            if (Program.Colors.Length > 0)
            {
                BackColor = Program.Colors[new Random().Next(Program.Colors.Length)];
            }
        }

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
        }

        private Color GetContrastColor()
        {
            return Color.FromArgb(255, 255 - BackColor.R, 255 - BackColor.G, 255 - BackColor.B);
        }

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
        }

        private async Task An_Direct()
        {
            Opacity = 1;
            await Task.CompletedTask;
        }

        private async Task An_Gentle()
        {
            while (Opacity < 1 && !isClosing)
            {
                Opacity += 0.05f;
                Location = new Point(Location.X, Location.Y - 1);
                await Task.Delay(16);
            }
        }

        private async Task An_Cool()
        {
            while (Opacity < 1 && !isClosing)
            {
                Opacity += 0.12f;
                Location = new Point(Location.X, Location.Y - 2);
                await Task.Delay(16);
            }
        }

        private async Task An_NoFloat()
        {
            while (Opacity < 1 && !isClosing)
            {
                Opacity += 0.12f;
                await Task.Delay(16);
            }
        }

        private void Message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && CanBeColse)
            {
                isClosing = true;
                Close();
                Application.Exit();
            }
        }
    }
}