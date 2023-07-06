using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortChecker
{
    internal static class Program
    {
        private static string settingsFilePath = "Settings.ini";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists(settingsFilePath))
            {
                CreateSettingsFile(); // 設定ファイルの生成
            }

            Application.Run(new FormMain());
        }

        private static void CreateSettingsFile()
        {
            using (StreamWriter writer = File.CreateText(settingsFilePath))
            {
                // 初期の設定項目を書き込む
                writer.WriteLine("[INFO]");
                writer.WriteLine("ipaddress = ");
                writer.WriteLine("port = ");

                writer.Flush();
            }
        }
    }
}
