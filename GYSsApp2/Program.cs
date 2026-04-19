namespace GYSsApp2
{
    /// <summary>
    /// 这个类创建了入口方法Main，
    /// 以及一些全局的配置，比如name 和 LoveWords，
    /// 还声明了动画方法的枚举值。
    /// </summary>
    internal static class Program
    {
        [STAThread]// 强制主线程为 STA 模式
        private static void Main()
        {
            //初始化保存的配置
            SaveHelper.LoadAll();
            
            // 初始化应用程序的系统配置
            ApplicationConfiguration.Initialize();

            // 启动程序，打开【启动警告窗口】Start
            Application.Run(new Start());
        }//程序入口

        internal static string name = "无名氏";//默认名称
        internal static string[] LoveWords =
#pragma warning disable IDE0300 // 简化集合初始化
        {
#pragma warning restore IDE0300 // 简化集合初始化
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
        };//默认情话库
        internal static Color[] Colors =
        {
            Color.LightPink, Color.Pink, Color.HotPink, Color.Lavender,
            Color.Plum, Color.Violet, Color.LightSalmon, Color.PeachPuff, Color.IndianRed
        };//默认颜色库
        internal static Font defaultFont = new("微软雅黑", 42, FontStyle.Bold);//默认字体
        internal static AnimationMethod animationMethod = AnimationMethod.direct;//默认动画方法
        internal static int delaytime = 80;//默认每次弹窗的间隔
        internal static bool NeedHeart = true;//默认是否开启绘制心型
        internal static bool NeedRain = true;//默认是否开启弹窗雨
        internal static int MessageLifeCycle = 0;//默认弹窗生命周期
        internal static int AppLifeCycle = 0;//默认App生命周期

        internal enum AnimationMethod
        {
            direct,
            gentle,
            cool,
            NoFloat
        }//动画方法枚举
    }
}