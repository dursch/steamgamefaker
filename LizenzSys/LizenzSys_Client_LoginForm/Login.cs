using System;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace License
{
    public partial class Login : Form
    {
        RegistryKey rk = Registry.CurrentUser.CreateSubKey("Software\\steam_game_faker");
        string HWID = WindowsIdentity.GetCurrent().User.Value.Replace("-", "");
        const string Tool = "steam_game_faker",
            Ver = "1.2.0_OBT_2";
        bool r = false;
        public Login()
        {
            if (File.Exists("Updater.exe"))
                File.Delete("Updater.exe");
            InitializeComponent();
            try
            {
                if (License.u(Tool, Ver) != "e3a760e31e115af748a077ade7be1a8e")
                {
                    new WebClient().DownloadFile("http://domain.tld/Updater.exe", "Updater.exe");
                    Process.Start("Updater.exe", Tool);
                    Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("Server Offline", Text);
                Environment.Exit(0);
            }
        }

        private void txtPKey_TextChanged(object sender, EventArgs e)
        {
            txtKey.Text = txtPKey0.Text + '-' + txtPKey1.Text + '-' + txtPKey2.Text + '-' + txtPKey3.Text + '-' + txtPKey4.Text;
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtKey.Text.Split('-');
                txtPKey0.Text = parts[0];
                txtPKey1.Text = parts[1];
                txtPKey2.Text = parts[2];
                txtPKey3.Text = parts[3];
                txtPKey4.Text = parts[4];
            }
            catch { }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                License.r(txtKey.Text, HWID, Tool);
                chkLic();
            }
            catch
            {
                MessageBox.Show("Server offline!");
                Environment.Exit(0);
            }
        }

        private void chkLic()
        {
            try
            {
                string ans = License.b(txtKey.Text, HWID, Tool);
                if (ans == "e3a760e31e115af748a077ade7be1a8e")
                {
                    r = true;
                    Hide();
                    rk.SetValue("LIC", txtKey.Text);
                    SteamGameFaker.Main mainForm = new SteamGameFaker.Main(Ver);
                    mainForm.Show();
                }
                else if (ans == "52fef60b81d3cb71a41467155f9948cb")
                {
                    txtError.Show();
                    txtError.Text = "Die Lizenz wurde auf einem anderen System eingelöst.";
                }
                else if (ans == "14eddb1ed548833eb26b0325f17b967e")
                {
                    txtError.Show();
                    txtError.Text = "Ungültige Lizenz.";
                }
                else if (ans == "5d96895af4f86324762c9520d5ae6322")
                {
                    txtError.Show();
                    txtError.Text = "Deine Lizenz wurde gesperrt.";
                }
                else
                {
                    txtError.Show();
                    txtError.Text = "Some Error with Lic";
                }
            }
            catch
            {
                MessageBox.Show("Server offline!");
                Environment.Exit(0);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                txtKey.Text = rk.GetValue("LIC").ToString();
            }
            catch { }
            chkLic();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (r)
                Hide();
        }
    }
}
