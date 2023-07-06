using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PortChecker
{
    internal class Checker
    {
        private String openMsg;
        private String closeMsg;

        public void CheckPortWasOpen(String ipAddress,int port)
        {
            openMsg = $"ポート　{port}　は開いています。";
            closeMsg = $"ポート {port} は閉じています。";

            try
            {
                // TCPクライアントを作成し、サーバーに接続を試みる
                TcpClient tcpClient = new TcpClient();
                tcpClient.ReceiveTimeout = 2;
                tcpClient.Connect(ipAddress, port);

                // 接続が成功した場合
                MessageBox.Show(openMsg, "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 接続を閉じる
                tcpClient.Close();
            }
            catch (SocketException e)
            {   
                Console.WriteLine(e.ToString());

                // 接続に失敗した場合
                MessageBox.Show(closeMsg, "完了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
