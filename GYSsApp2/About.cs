namespace GYSsApp2
{
    /// <summary>
    /// 这个类是一个简单的关于窗口，
    /// 只有介绍该程序和引导至该项目GITHUB仓库的功能。
    /// </summary>
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }//初始化

        private void button1_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/TisLiu/GYSsApp") { UseShellExecute = true });
        }//引导至该项目的GITHUB仓库 https://github.com/TisLiu/GYSsApp
    }
}
