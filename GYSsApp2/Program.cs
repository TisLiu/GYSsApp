// 项目命名空间：统一管理所有类

namespace GYSsApp2
{
    /// <summary>
    /// 程序入口类
    /// 作用：整个应用程序的启动入口，负责初始化并打开第一个窗口
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// 程序【主入口点】
        /// 整个程序从这里开始运行
        /// [STAThread]：Windows 桌面程序必需的线程特性
        /// </summary>
        [STAThread]
        private static void Main()
        {
            SaveHelper.LoadAll();
            // 初始化应用程序的系统配置
            ApplicationConfiguration.Initialize();

            // 启动程序，打开【启动警告窗口】Start
            Application.Run(new Start());
        }

        internal static string name = "无名氏";
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
        };
        internal static Color[] Colors =
        {
            Color.LightPink, Color.Pink, Color.HotPink, Color.Lavender,
            Color.Plum, Color.Violet, Color.LightSalmon, Color.PeachPuff, Color.IndianRed
        };
        internal static Font defaultFont = new("微软雅黑", 42, FontStyle.Bold);
        internal static AnimationMethod animationMethod = AnimationMethod.direct;
        internal static int delaytime = 80;
        internal static bool NeedHeart = true;
        internal static bool NeedRain = true;
        internal static int MessageLifeCycle = 0;
        internal static int AppLifeCycle = 0;

        internal enum AnimationMethod
        {
            direct,
            gentle,
            cool,
            NoFloat
        }
    }
}