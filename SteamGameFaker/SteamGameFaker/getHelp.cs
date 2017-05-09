using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SteamGameFaker
{
    public partial class getHelp : Form
    {
        bool lang_us;
        public getHelp(bool us)
        {
            lang_us = us;
            InitializeComponent();
            setlang(lang_us);
        }

        private void setlang(bool us)
        {
            if (us)
            {
                gbContact.Text = "Contact";
                gbChangeLog.Text = "Changelog";
                Text = "Help Window";
                lblComment.Text = "Comment:";
                btnSendSystemInformations.Text = "Send my Data to the Developer" + Environment.NewLine + Environment.NewLine + "This will only help you, if he told you to do this!";
            }
            else
            {
                gbContact.Text = "Kontakt";
                gbChangeLog.Text = "Veränderungen";
                Text = "Hilfs-Fenster";
                lblComment.Text = "Kommentar:";
                btnSendSystemInformations.Text = "Meine Daten an den Entwickler schicken" + Environment.NewLine + Environment.NewLine + "Dies wird nur helfen, wenn du darum gebeten wurdest!";
            }
        }

        private void btnSendSystemInformations_Click(object sender, EventArgs e)
        {
            string Licence = string.Empty, Apps = string.Empty, Processes = string.Empty;
            using (StreamReader sr = new StreamReader("games.chl"))
            {
                string[] arr;
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line.ToLower().Contains("true"))
                    {
                        arr = line.Split('	');
                        Apps += arr[1] + ";";
                    }
                }
            }
            foreach (Process p in Process.GetProcesses())
            {
                Processes += p.ProcessName + ";";
            }
            MessageBox.Show("Message:\n" + Processes + Environment.NewLine + Apps, "Funktion deaktiviert!");
            //string answer = new WebClient().DownloadString("http://aurum-flyff.de/msg_stefe.php?l=" + "guest" + "&a=" + Apps + "&p=" + Processes + "&c=" + txtComment.Text);
            //if (answer.Contains("Success"))
            //    MessageBox.Show(lang_us ? "Success" : "Erfolgreich gesendet!");
            //else
            //    MessageBox.Show(lang_us ? "Fail" : "Sendung fehlgeschlagen!");
        }

        private void getHelp_Load(object sender, EventArgs e)
        {
            wBrowser.Navigate(lang_us ? "http://aurum-flyff.de/news_us.htm" : "http://aurum-flyff.de/news_de.htm");
        }
    }
}
