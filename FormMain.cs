using IniParser.Model;
using IniParser;
using System;
using System.Windows.Forms;
using System.IO;

namespace PortChecker
{
    public partial class FormMain : Form
    {
        private String iniFilePath;

        public FormMain()
        {
            InitializeComponent();

            // exeファイルのパスを取得
            string exeFilePath = Application.ExecutablePath;

            // exeファイルと同じディレクトリのパスを取得
            string exeDirectory = Path.GetDirectoryName(exeFilePath);

            // Settings.iniファイルのパスを作成
            this.iniFilePath = Path.Combine(exeDirectory, "Settings.ini");

            loadInfo();
        }

        private void BtnChecking_Click(object sender, EventArgs e)
        {
            // iniFileに書き込み
            saveInfo();

            //検索
            Checker checker = new Checker();
            checker.CheckPortStatus(this.TextIPAddres.Text,int.Parse(this.TextPort.Text));
        }
           
        private void loadInfo()
        {
            // Ini読み込み
            var parser = new FileIniDataParser();
            IniData iniData = parser.ReadFile(this.iniFilePath);

            this.TextIPAddres.Text = iniData["INFO"]["ipaddress"];
            this.TextPort.Text = iniData["INFO"]["port"];
        }

        private void saveInfo()
        {
            // iniFileに書き込み
            FileIniDataParser parser = new FileIniDataParser();
            IniData iniData = parser.ReadFile(iniFilePath);

            // ini形式を用意する
            // MultiUnit
            iniData["INFO"]["ipaddress"] = this.TextIPAddres.Text;
            iniData["INFO"]["port"] = this.TextPort.Text;

            // 書き込み
            parser.WriteFile(iniFilePath, iniData);
        }
    }

}
