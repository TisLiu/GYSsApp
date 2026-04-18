namespace GYSsApp2
{
    public partial class Form1 : Form
    {
        private readonly Random random = new();
        private bool isRunning = true;

        public Form1()
        {
            InitializeComponent();
            Hide();
            KeyPreview = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                isRunning = false;
                Environment.Exit(0);
            }
            base.OnKeyDown(e);
        }//关闭

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DrawHeartAnimationAsync();
            await StartPopupLoopAsync();
        }

        #region 拆分爱心逻辑
        private async Task DrawHeartAnimationAsync()
        {
            if (Screen.PrimaryScreen == null || !Program.NeedHeart)
            {
                return;
            }

            List<Point> heartPoints = GetHeartPoints();
            Point center = GetScreenCenter();
            List<Message> heartWindows = [];

            const int heartWidth = 320;
            const int heartHeight = 260;

            for (int i = 0; i < Math.Min(211, heartPoints.Count) && isRunning; i++)
            {
                Point p = heartPoints[i];
                Point pos = new(
                    center.X + p.X - (heartWidth / 2),
                    center.Y + p.Y - (heartHeight / 2)
                );

                Message msg = new()
                {
                    Mytext = Program.name,
                    MyFont = Program.defaultFont,
                    StartPosition = FormStartPosition.Manual,
                    Location = pos,
                    Size = new Size(36, 12),
                    Animate = Program.AnimationMethod.NoFloat,
                    CanBeColse = true,
                    IsAutoClose = false,
                };

                heartWindows.Add(msg);
                msg.Show();
                await Task.Delay(5);
            }

            await Task.Delay(3000);

            foreach (Message msg in heartWindows)
            {
                msg.Close();
            }
        }

        private Point GetScreenCenter()
        {
            if (Screen.PrimaryScreen == null)
            {
                return Point.Empty;
            }

            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            return new Point(area.Width / 2, area.Height / 2);
        }
        #endregion

        #region 拆分弹幕循环
        private async Task StartPopupLoopAsync()
        {
            while (isRunning && Program.NeedRain)
            {
                int x = random.Next(-200, Screen.AllScreens[0].WorkingArea.Width);
                int y = random.Next(-200, Screen.AllScreens[0].WorkingArea.Height);

                Message msg = new()
                {
                    Mytext = Program.LoveWords[random.Next(Program.LoveWords.Length)],
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(x, y),
                    MyFont = Program.defaultFont,
                    Animate = Program.animationMethod,
                    CanBeColse = true,
                    IsAutoClose = true,
                };

                msg.Show();
                await Task.Delay(Program.delaytime);
            }
        }
        #endregion

        private List<Point> GetHeartPoints()
        {
            List<Point> points = [];
            for (double t = 0; t < Math.PI * 2; t += 0.03)
            {
                double x = 16 * Math.Pow(Math.Sin(t), 3);
                double y = -((13 * Math.Cos(t)) - (5 * Math.Cos(2 * t)) - (2 * Math.Cos(3 * t)) - Math.Cos(4 * t));
                points.Add(new Point((int)(x * 20), (int)(y * 20)));
            }
            return points;
        }
    }
}