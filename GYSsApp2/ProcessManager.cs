using System.Runtime.InteropServices;

namespace GYSsApp2
{
    /// <summary>
    /// 流程管理器，
    /// 纯后台控制类，
    /// 负责爱心动画、文字雨、全局流程控制
    /// </summary>
    public class ProcessManager
    {
        private readonly Random random = new();
        private bool isRunning = true;

        // 构造方法
        public ProcessManager()
        {
            // 注册全局ESC退出
            RegisterGlobalEscapeKey();

            //启动流程
            _ = StartAllProcesses();
        }

        // 启动所有流程（替代原来的Form_Load）
        public async Task StartAllProcesses()
        {
            if(Program.NeedHeart)
                await DrawHeartAnimation();
            if(Program.NeedRain)
                await DrawRainAnimation();
        }

        // 全局ESC退出：只有当前焦点是【Message】且【CanBeClose=true】才关闭
        private void RegisterGlobalEscapeKey()
        {
            _ = Task.Run(async () =>
            {
                while (isRunning)
                {
                    await Task.Delay(10);

                    if (IsKeyPressed(Keys.Escape))
                    {
                        // 1. 获取当前激活的窗口
                        IntPtr handle = GetForegroundWindow();
                        Form? activeForm = Form.FromHandle(handle) as Form;

                        // 2. 判断是不是 Message 窗口
                        if (activeForm is Message msgForm)
                        {
                            // 3. 只有 Message.CanBeClose == true 才关闭
                            if (msgForm.CanBeColse) // 注意：你写的是 CanBeColse（l没写错）
                            {
                                isRunning = false;
                                Application.Exit();
                            }
                        }
                    }
                }
            });
        }

        // 系统API：获取当前激活窗口
        [DllImport("user32.dll")] private static extern IntPtr GetForegroundWindow();

        // 系统API：判断按键是否按下
        [DllImport("user32.dll")]private static extern short GetAsyncKeyState(Keys vKey);
        private static bool IsKeyPressed(Keys key)
        {
            return (GetAsyncKeyState(key) & 0x8000) != 0;
        }

        //绘制红心
        private async Task DrawHeartAnimation()
        {
            if (Screen.PrimaryScreen == null)
            {
                return;
            }

            List<Point> heartPoints = GetHeartPoints();
            Point center = GetScreenCenter();
            List<Message> heartWindows = [];

            const int heartWidth = 320;
            const int heartHeight = 260;

            for (int i = 0; i<=((Math.PI*2)/0.03) && isRunning; i++)
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

        //获取屏幕中心点
        private static Point GetScreenCenter()
        {
            if (Screen.PrimaryScreen == null)
            {
                return Point.Empty;
            }

            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            return new Point(area.Width / 2, area.Height / 2);
        }

        //弹窗雨
        private async Task DrawRainAnimation()
        {
            while (isRunning)
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

        /// <summary>
        /// 获取笛卡尔心形曲线的坐标点集合
        /// 使用经典数学公式生成完美的爱心形状
        /// </summary>
        /// <returns>心形坐标点列表</returns>
        private static List<Point> GetHeartPoints()
        {
            // 初始化一个列表，用于存储计算出来的所有心形坐标点
            List<Point> points = [];

            // t 是参数方程的参数，从 0 循环到 2π（一个完整的圆周）
            // t += 0.03 控制采样密度，数值越小点越多、心形越细腻
            for (double t = 0; t < Math.PI * 2; t += 0.03)
            {
                // ==============================
                // 笛卡尔心形参数方程（数学公式）
                // ==============================

                // 计算 X 轴坐标：x = 16 * sin³(t)
                double x = 16 * Math.Pow(Math.Sin(t), 3);

                // 计算 Y 轴坐标：y = 13cos(t) - 5cos(2t) - 2cos(3t) - cos(4t)
                // 前面加负号是因为 Windows 窗体坐标系 Y 轴向下为正，需要翻转
                double y = -((13 * Math.Cos(t)) - (5 * Math.Cos(2 * t)) - (2 * Math.Cos(3 * t)) - Math.Cos(4 * t));

                // ==============================
                // 坐标转换与缩放
                // ==============================
                // 1. 公式计算出来的值很小，需要 * 20 放大心形尺寸
                // 2. 强转 int 适配窗体的 Point 坐标（整数）
                points.Add(new Point((int)(x * 20), (int)(y * 20)));
            }

            // 返回完整的爱心坐标点集合
            return points;
        }
    }
}