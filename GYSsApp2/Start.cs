// 项目命名空间：GYSsApp2（整个程序的容器）
namespace GYSsApp2
{
    /// <summary>
    /// 启动警告窗口
    /// 功能：显示程序提示，提供【启动】和【退出】两个选项
    /// 这是程序的入口界面，也是整个程序唯一的逻辑分支
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

            // 创建主程序窗口实例
            Form1 form1 = new();

            // 显示主程序窗口，开始执行浪漫动画效果
            form1.Show();

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
            // 强制安全退出程序
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextChanger textChanger = new();
            _ = textChanger.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About about = new();
            _ = about.ShowDialog();
        }
    }
}