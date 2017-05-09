using System;
using System.Windows.Forms;
using System.IO;

namespace License
{
    public partial class Login : Form
    {
        const string Tool = "steam_game_faker",
            Ver = "Version 2.1.1 - Final Release";
        SteamGameFaker.Main mainForm = new SteamGameFaker.Main(Ver, "guest", "guest");
        public Login()
        {
            if (File.Exists("Updater.exe"))
                File.Delete("Updater.exe");
            InitializeComponent();
            Text += " " + Ver;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            chkLic();
        }

        private void chkLic()
        {
            Hide();
            mainForm.Show();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
                chkLic();
        }
    }
}
