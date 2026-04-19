namespace GYSsApp2
{
    /// <summary>
    /// 这个类是第一个打开的窗口，
    /// 允许让用户选择是
    /// 打开自定义窗口、
    /// 打开关于窗口、
    /// 开始运行程序、
    /// 还是退出程序。
    /// </summary>
    public partial class Start : Form
    {
        /// <summary>
        /// 构造函数：初始化窗口组件
        /// </summary>
        public Start()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 【启动程序】按钮点击事件
        /// 功能：隐藏当前启动窗口，打开主程序窗口（爱心动画 + 情话弹窗）
        /// </summary>
        private async void Go_button_Click(object sender, EventArgs e)
        {
            // 隐藏当前启动警告窗口
            Hide();

            // 创建进程管理实例
            ProcessManager form1 = new();

            //程序生命周期
            if (Program.AppLifeCycle <= 0)
            {
                return;
            }

            await Task.Delay(Program.AppLifeCycle);
            Application.Exit();
        }

        /// <summary>
        /// 【退出程序】按钮点击事件
        /// 功能：直接终止整个程序，不运行任何动画
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //弹出自定义窗口
        private void button1_Click(object sender, EventArgs e)
        {
            TextChanger textChanger = new();
            _ = textChanger.ShowDialog();
        }

        //弹出关于窗口
        private void button3_Click(object sender, EventArgs e)
        {
            About about = new();
            _ = about.ShowDialog();
        }
    }
}