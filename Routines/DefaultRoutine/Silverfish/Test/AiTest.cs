using System;
using System.IO;
using System.Text;
namespace HREngine.Bots
{
    public class AiTest : TestBase
    {
        public void Test()
        {
            Settings.Instance.test = true;
            string mainPath = @"C:\Users\xiaohei\Desktop\Hearthbuddy_SimTemplate\Hearthbuddy_SimTemplate\Routines\DefaultRoutine\Silverfish\"; // 确保此路径正确
            Settings.Instance.mainPath = mainPath;

            var testFilePath = Path.Combine(mainPath, @"Test\Data\对局记录\日期2025-06-08\03-13-14-WARRIOR-DEATHKNIGHT\1法力水晶 第2回合 第0步操作.txt");
            var data = File.ReadAllText(testFilePath);
            Settings.Instance.logpath = Path.Combine(mainPath, @"Test\Data\");
            Settings.Instance.path = Path.Combine(mainPath, @"data\"); // 用于CardDB类构造，读取CardDefs.xml
            InitSetting();

            Ai ai = Ai.Instance;
            ai.botBase = new Behavior丨通用丨不设惩罚();  //根据卡组选择合适的策略

            ai.autoTester(true, data, 0);// 0：全做 1:只斩杀 2：正常
            Console.WriteLine("测试完毕，请去Logg.txt文件末尾查看Ai操作");
        }

        public static void Main(string[] args)  //如果单独Run这个程序，main->Main
        {
            AiTest test = new AiTest();
            test.Test();
        }
    }
}