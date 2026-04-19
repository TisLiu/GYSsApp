using System.Text.Json;

namespace GYSsApp2
{
    // 这个类用来“打包”所有要保存的数据
    internal class AppConfig
    {
        public string? Name { get; set; }
        public string[]? LoveWords { get; set; }
        public ColorData[]? Colors { get; set; }
        public FontData? DefaultFont { get; set; }
        public Program.AnimationMethod AnimationMethon { get; set; }
        public int delaytime { get; set; }
        public bool NHeart { get; set; }
        public bool NRain { get; set; }
        public int LifeCycel { get; set; }
        public int AppLifeCycel { get; set; }
    }

    // 颜色不能直接序列化，所以存 R/G/B
    public class ColorData
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

    // 字体不能直接序列化，存关键信息
    public class FontData
    {
        public required string FontName { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }
    }

    /// <summary>
    /// 提供应用程序全局配置的 JSON 持久化功能。
    /// </summary>
    /// <remarks>
    /// 配置文件使用 <see cref="System.Text.Json.JsonSerializer"/> 序列化，
    /// 保存于应用程序启动目录下的 "GYSconfig.json" 文件中。
    /// 若文件不存在，加载时将静默跳过，保留当前内存中的默认值。
    /// </remarks>
    public static class SaveHelper
    {
        private static readonly string path = Path.Combine(Application.StartupPath, "GYSconfig.json");//保存位置和文件名

        // 保存：打包 → 转 JSON → 写文件
        public static void SaveAll()
        {
            AppConfig config = new()
            {
                Name = Program.name,
                LoveWords = Program.LoveWords,

                // 颜色转成可保存的格式
                Colors = Array.ConvertAll(Program.Colors, c => new ColorData
                {
                    R = c.R,
                    G = c.G,
                    B = c.B
                }),

                // 字体转成可保存的格式
                DefaultFont = new FontData
                {
                    FontName = Program.defaultFont.FontFamily.Name,
                    Size = Program.defaultFont.Size,
                    Style = Program.defaultFont.Style
                },

                //动画保存
                AnimationMethon = Program.animationMethod,

                //延迟时间保存
                delaytime = Program.delaytime,

                //是否需要心保存
                NHeart = Program.NeedHeart,

                //是否需要雨保存
                NRain = Program.NeedRain,

                //生命周期保存
                LifeCycel = Program.MessageLifeCycle,

                //程序生命周期保存
                AppLifeCycel = Program.AppLifeCycle,
            };//config实例

            // 一句话保存
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        // 加载：读文件 → JSON 自动解析 → 赋值回去
        public static void LoadAll()
        {
            if (!File.Exists(path))
            {
                return;
            }//文件如果不存在，就不加载

            // 一句话加载
            string json = File.ReadAllText(path);
            AppConfig? config = JsonSerializer.Deserialize<AppConfig>(json);

            // 恢复数据
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS8602 // 解引用可能出现空引用。
            Program.name = config.Name;
#pragma warning restore CS8602 // 解引用可能出现空引用。
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
            Program.LoveWords = config.LoveWords;
#pragma warning restore CS8601 // 引用类型赋值可能为 null。

            // 恢复颜色
#pragma warning disable CS8604 // 引用类型参数可能为 null。
            Program.Colors = Array.ConvertAll(config.Colors, c => Color.FromArgb(c.R, c.G, c.B));
#pragma warning restore CS8604 // 引用类型参数可能为 null。

            // 恢复字体
#pragma warning disable CS8602 // 解引用可能出现空引用。
            Program.defaultFont = new Font(config.DefaultFont.FontName, config.DefaultFont.Size, config.DefaultFont.Style);
#pragma warning restore CS8602 // 解引用可能出现空引用。

            //恢复动画
            Program.animationMethod = config.AnimationMethon;

            //恢复延迟时间
            Program.delaytime = config.delaytime;

            //恢复是否需要心
            Program.NeedHeart = config.NHeart;

            //恢复是否需要雨
            Program.NeedRain = config.NRain;

            //生命周期恢复
            Program.MessageLifeCycle = config.LifeCycel;

            //程序生命周期恢复
            Program.AppLifeCycle = config.AppLifeCycel;
        }
    }
}