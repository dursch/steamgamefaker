using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace LizenzSys_Client_Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            Visible = false;
            WindowState = FormWindowState.Minimized;
            WebClient wClient = new WebClient();
            string[] files = new string[0];
            string ToolPath = string.Empty;
            try
            {
                        files = wClient.DownloadString("http://domain.tld/getFiles.php?t=steam_game_faker").Split('|');
                        if (File.Exists("CSteamworks.dll"))
                            File.Delete("CSteamworks.dll");
                        ToolPath = "SteamGameFaker.exe";
            }
            catch
            {
                MessageBox.Show("Server Offline", Text);
                Environment.Exit(0);
            }
            foreach (string file in files)
            {
                if (file.Contains("."))
                {
                    if (File.Exists(file))
                        File.Delete(file);
                    wClient.DownloadFile("http://domain.tld/rls/" + file, file);
                }
            }
            Process.Start(ToolPath);
            Environment.Exit(0);
        }
    }
}
