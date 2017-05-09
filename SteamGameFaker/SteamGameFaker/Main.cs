using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Threading;

namespace SteamGameFaker
{
    public partial class Main : Form
    {
        IniFile Settings = new IniFile("Settings.cfg");
        bool loaded = false,
            lang_us = true;
        int ActiveIdlers = 0,
            cActiveIdlers = 0;
        App[] ActiveGames = new App[0];
        string KEY, HWID;
        const string Tool = "steam_game_faker";
        public Main(string VER, string key, string hwid)
        {
            InitializeComponent();
            Text += " " + VER;
            KEY = key;
            HWID = hwid;
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            string games_chl = File.ReadAllText("games.chl");
            games_chl += Environment.NewLine + txtGameName.Text + '	' + txtGameID.Text + '	' + "true";
            File.WriteAllText("games.chl", games_chl);
            string[] arr = new string[] {
            txtGameName.Text,
            txtGameID.Text
            };
            ListViewItem itm;
            itm = new ListViewItem(arr);
            gameList.Items.Add(itm);
            gameList.Items[gameList.Items.Count - 1].Checked = true;
            Main_Resize(sender, e);
        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameList.FocusedItem == null)
                return;
            lblSelectedGame.Text = gameList.FocusedItem.SubItems[0].Text;
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (gameList.FocusedItem == null)
                return;
            string output = "";
            using (StreamReader sr = new StreamReader("games.chl"))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(gameList.FocusedItem.SubItems[0].Text + '	') && !String.IsNullOrEmpty(line))
                        output += line + Environment.NewLine;
                }
            }
            File.WriteAllText("games.chl", output);
            gameList.FocusedItem.Remove();
        }

        private void btnSingleStart_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "GameDummy.exe";
            proc.StartInfo.Arguments = gameList.FocusedItem.SubItems[1].Text;
            proc.StartInfo.WindowStyle = rbStartHidden.Checked ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Minimized;
            proc.Start();
            proc.PriorityClass = ProcessPriorityClass.Idle;
            ActiveIdlers++;
            if (lang_us)
                lblActiveIdlers.Text = "Active games: " + cActiveIdlers.ToString() + "/" + ActiveIdlers.ToString();
            else
                lblActiveIdlers.Text = "Aktive Spiele: " + cActiveIdlers.ToString() + "/" + ActiveIdlers.ToString();
            tmrChkActiveIdlers.Start();
            Array.Resize(ref ActiveGames, ActiveGames.Length + 1);
            ActiveGames[ActiveGames.Length - 1] = new App(gameList.FocusedItem.SubItems[1].Text, gameList.FocusedItem.SubItems[0].Text, proc);
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gameList.Items.Count; i++)
            {
                if (gameList.Items[i].Checked)
                {
                    if (chkBeta.Checked)
                        Thread.Sleep(250);
                    Process proc = new Process();
                    proc.StartInfo.FileName = "GameDummy.exe";
                    proc.StartInfo.Arguments = gameList.Items[i].SubItems[1].Text;
                    proc.StartInfo.WindowStyle = rbStartHidden.Checked ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Minimized;
                    proc.Start();
                    proc.PriorityClass = ProcessPriorityClass.Idle;
                    Array.Resize(ref ActiveGames, ActiveGames.Length + 1);
                    ActiveGames[ActiveGames.Length - 1] = new App(gameList.Items[i].SubItems[1].Text, gameList.Items[i].SubItems[0].Text, proc);
                    ActiveIdlers++;
                    if (lang_us)
                        lblActiveIdlers.Text = "Active games: " + cActiveIdlers.ToString() + "/" + ActiveIdlers.ToString();
                    else
                        lblActiveIdlers.Text = "Aktive Spiele: " + cActiveIdlers.ToString() + "/" + ActiveIdlers.ToString();
                    Update();
                }
            }
            tmrChkActiveIdlers.Start();
        }

        private void btnFillListFromSteamCommunity_Click(object sender, EventArgs e)
        {
            string SCGamesHTML;
            if (txtSteamLink.Text.EndsWith("/"))
                SCGamesHTML = new WebClient().DownloadString(txtSteamLink.Text + "games/?tab=all");
            else
                SCGamesHTML = new WebClient().DownloadString(txtSteamLink.Text + "/games/?tab=all");
            try
            {
                SCGamesHTML = SCGamesHTML.Substring(SCGamesHTML.IndexOf("var rgGames = [") + "var rgGames = [".Length);
                SCGamesHTML = SCGamesHTML.Replace("appid", Environment.NewLine).Replace(@"""", string.Empty).Replace(":", string.Empty);
                string[] Output = SCGamesHTML.Split(Environment.NewLine.ToCharArray());
                string output = "";
                for (int i = 0; i < Output.Length; i++)
                {
                    //Update 25.07.2015 -> Steam HTML-Code updated and parsed wrong
                    if (Output[i].Contains("name") && Output[i].Contains("logohttp"))
                        //Update 25.07.2015 -> "Counter-Strike Global Offensiv"-Bug fixed
                        output += Output[i].Substring(Output[i].IndexOf(",name") + ",name".Length, Output[i].IndexOf(",logohttp") - ",logohttp".Length + 1) + "	" + Output[i].Substring(0, Output[i].IndexOf(",name")) + "	true" + Environment.NewLine;
                }
                //Update 25.07.2015 -> \u2122 = ™ , \u2019 = ’
                output = output.Replace(",	", "	").Replace(",l	", "	").Replace(",lo	", "	").Replace(@"\u2122", "™").Replace(@"\u2019", "’");
                //Update 25.07.2015 -> Private profiles will give an error again
                if (String.IsNullOrEmpty(output))
                    throw new ArgumentNullException();
                File.WriteAllText("games.chl", output);
                loaded = false;
                gameList.Items.Clear();
                using (StreamReader sr = new StreamReader("games.chl"))
                {
                    string[] arr;
                    ListViewItem itm;
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        arr = line.Split('	');
                        itm = new ListViewItem(new string[] { arr[0], arr[1] });
                        gameList.Items.Add(itm);
                        //gameList.Items[gameList.Items.Count - 1].Checked = arr[arr.Length - 1].ToLower() == "true" ? true : false;
                    }
                }
                tickAllGamesToolStripMenuItem_Click(sender, e);
                loaded = true;
                if (cbSorting.Text.ToLower().Contains("alphabet"))
                {
                    gameList.Sorting = SortOrder.Ascending;
                    gameList.Sort();
                }
                Main_Resize(sender, e);
            }

            catch (Exception ex)
            {
                if (!loaded)
                    loaded = true;
                if (!lang_us)
                    MessageBox.Show("Profil ist nicht öffentlich zugänglich, besitzt keine Spiele oder existiert nicht!" + Environment.NewLine + "Fehler:" + Environment.NewLine + ex.Message, Text);
                else
                    MessageBox.Show("Profile is not public, hasn't got any games or it doesn't exist!" + Environment.NewLine + "Error:" + Environment.NewLine + ex.Message, Text);
            }
        }

        private void btnKillIdlers_Click(object sender, EventArgs e)
        {
            ActiveGames = new App[0];
            ActiveIdlers = 0;
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.ToLower().Contains("gamedummy"))
                {
                    p.Kill();
                }
            }
        }

        private void gameList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (loaded)
            {
                string[] games_chl;
                try
                {
                    games_chl = File.ReadAllLines("games.chl");
                }
                catch
                {
                    return;
                }
                string output = "";
                for (int i = 0; i < games_chl.Length; i++)
                {
                    if (games_chl[i].Contains(e.Item.SubItems[1].Text))
                        output += e.Item.SubItems[0].Text + "	" + e.Item.SubItems[1].Text + "	" + e.Item.Checked.ToString() + Environment.NewLine;
                    else if (games_chl[i] != string.Empty)
                        output += games_chl[i] + Environment.NewLine;
                }
                File.WriteAllText("games.chl", output);
            }
        }

        private void rb_chkchg(object sender, EventArgs e)
        {
            Settings.Write(rbStartHidden.Name, rbStartHidden.Checked.ToString());
        }

        private void txtSteamLink_TextChanged(object sender, EventArgs e)
        {
            Settings.Write(txtSteamLink.Name, txtSteamLink.Text);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit((int)e.CloseReason);
        }

        private void lblActiveIdlers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveGamesShower ags = new ActiveGamesShower(ActiveGames, lang_us, this);
            ags.Show();
        }

        private void tmrChkActiveIdlers_Tick(object sender, EventArgs e)
        {
            cActiveIdlers = 0;
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.ToLower().Contains("gamedummy"))
                    cActiveIdlers++;
            }
            if (lang_us)
                lblActiveIdlers.Text = "Active games: " + cActiveIdlers.ToString() + "/" + ActiveIdlers.ToString();
            else
                lblActiveIdlers.Text = "Aktive Spiele: " + cActiveIdlers.ToString() + "/" + ActiveIdlers.ToString();
        }

        public struct App
        {
            public string ID,
                Name;
            public Process Proc;
            //public Uri HeaderUrl;
            public App(string id, string name, Process proc)
            {
                ID = id;
                Name = name;
                Proc = proc;
                //HeaderUrl = new Uri("http://cdn.akamai.steamstatic.com/steam/apps/[APPID]/header_292x136.jpg?t=1379353458".Replace("[APPID]", id));
            }
        }

        private void pb_lang_us_Click(object sender, EventArgs e)
        {
            if (lang_us)
            {
                lang_us = false;
                pb_lang_de.BorderStyle = BorderStyle.FixedSingle;
                pb_lang_us.BorderStyle = BorderStyle.None;
            }
            else
            {
                lang_us = true;
                pb_lang_us.BorderStyle = BorderStyle.FixedSingle;
                pb_lang_de.BorderStyle = BorderStyle.None;
            }
            Settings.Write("lang_eng", lang_us.ToString());
            loaded = false;
            SetLang(lang_us);
            gameList.Items.Clear();
            using (StreamReader sr = new StreamReader("games.chl"))
            {
                string[] arr;
                ListViewItem itm;
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    arr = line.Split('	');
                    itm = new ListViewItem(new string[] { arr[0], arr[1] });
                    gameList.Items.Add(itm);
                    gameList.Items[gameList.Items.Count - 1].Checked = arr[arr.Length - 1].ToLower() == "true" ? true : false;
                }
            }
            loaded = true;
            if (cbSorting.Text.ToLower().Contains("alphabet"))
            {
                gameList.Sorting = SortOrder.Ascending;
                gameList.Sort();
            }
        }

        private void SetLang(bool us)
        {
            if (us)
            {
                btnAddGame.Text = "Add to list";
                btnDelItem.Text = "Delete";
                lblSelectedGame.Text = "None";
                btnStartAll.Text = @"Start all Games" + Environment.NewLine + "Close all Idlers before you start.";
                btnKillIdlers.Text = "Kill all idlers";
                btnFillListFromSteamCommunity.Text = "Fill list from Steamcommunity";
                rbStartHidden.Text = "Start hidden";
                rbStartMin.Text = "Start minimized";
                if (Settings.Read(cbSorting.Name.ToString()).Contains("alphabet"))
                    cbSorting.Text = "Sort by alphabet";
                else
                    cbSorting.Text = "Sort by hours";
                cbSorting.Items.Clear();
                cbSorting.Items.Add("Sort by alphabet");
                cbSorting.Items.Add("Sort by hours");
                gbAddGame.Text = "Add single game";
                gbSettings.Text = "Settings";
                gbSelectedGame.Text = "Selected game:";
                btnSingleStart.Text = "Start game";
                chkBeta.Text = "Safe start (Start all games)";
                tickAllGamesToolStripMenuItem.Text = "Tick all games";
                untickAllGamesToolStripMenuItem.Text = "Untick all games";
                btnHelp.Text = "Help";
                btnTradingCardBot.Text = "Trading Cards";
            }
            else
            {
                btnAddGame.Text = "Zur Liste hinzufügen";
                btnDelItem.Text = "Löschen";
                lblSelectedGame.Text = "Kein Spiel ausgewählt";
                btnStartAll.Text = @"Alle Spiele starten";
                btnKillIdlers.Text = "Alle Spiele schließen";
                btnFillListFromSteamCommunity.Text = "Liste aus Steamcommunity füllen";
                rbStartHidden.Text = "Versteckt starten";
                rbStartMin.Text = "Minimiert starten";
                if (Settings.Read(cbSorting.Name.ToString()).Contains("alphabet"))
                    cbSorting.Text = "Nach Alphabet sortieren";
                else
                    cbSorting.Text = "Nach Stunden sortieren";
                cbSorting.Items.Clear();
                cbSorting.Items.Add("Nach Alphabet sortieren");
                cbSorting.Items.Add("Nach Stunden sortieren");
                gbAddGame.Text = "Einzelnes Spiel hinzufügen";
                gbSettings.Text = "Einstellungen";
                gbSelectedGame.Text = "Ausgewähltes Spiel:";
                btnSingleStart.Text = "Spiel starten";
                chkBeta.Text = "Sicherer Start (Alle Spiele starten)";
                tickAllGamesToolStripMenuItem.Text = "Alle Spiele markieren";
                untickAllGamesToolStripMenuItem.Text = "Markierung bei allen Spielen entfernen";
                btnHelp.Text = "Hilfe";
                btnTradingCardBot.Text = "Sammelkarten";
            }
        }

        private void cbSorting_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                loaded = false;
                if (cbSorting.Text == "Sort by alphabet" || cbSorting.Text == "Nach Alphabet sortieren")
                {
                    gameList.Sorting = SortOrder.Ascending;
                    gameList.Sort();
                    Settings.Write(cbSorting.Name.ToString(), "alphabet");
                }
                else
                {
                    gameList.Sorting = SortOrder.None;
                    Settings.Write(cbSorting.Name.ToString(), "None");
                    gameList.Items.Clear();
                    using (StreamReader sr = new StreamReader("games.chl"))
                    {
                        string[] arr;
                        ListViewItem itm;
                        string line;
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            arr = line.Split('	');
                            itm = new ListViewItem(new string[] { arr[0], arr[1] });
                            gameList.Items.Add(itm);
                            gameList.Items[gameList.Items.Count - 1].Checked = arr[arr.Length - 1].ToLower() == "true" ? true : false;
                        }
                    }
                }
                loaded = true;
            }
        }

        private void tickAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaded = false;
            for (int i = 0; i < gameList.Items.Count; i++)
            {
                gameList.Items[i].Checked = true;
            }
            string[] games_chl = File.ReadAllLines("games.chl");
            string output = "";
            for (int i = 0; i < games_chl.Length; i++)
            {
                output += games_chl[i].Replace("	False", "	true").Replace("	false", "	true") + Environment.NewLine;
            }
            File.WriteAllText("games.chl", output);
            loaded = true;
        }

        private void untickAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaded = false;
            for (int i = 0; i < gameList.Items.Count; i++)
            {
                gameList.Items[i].Checked = false;
            }
            string[] games_chl = File.ReadAllLines("games.chl");
            string output = "";
            for (int i = 0; i < games_chl.Length; i++)
            {
                output += games_chl[i].Replace("	True", "	false").Replace("	true", "	false") + Environment.NewLine;
            }
            File.WriteAllText("games.chl", output);
            loaded = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            getHelp helper = new getHelp(lang_us);
            helper.Show();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            tmrLoad.Start();
        }

        public void tmrLoad_Tick(object sender, EventArgs e)
        {
            tmrLoad.Stop();
            tmrLic.Interval = 1000;
            tmrLic.Start();
            loaded = false;
            try
            {
                if (Settings.Read(rbStartHidden.Name).ToLower().Contains("true"))
                    rbStartHidden.Checked = true;
                else
                    rbStartMin.Checked = true;
                txtSteamLink.Text = Settings.Read(txtSteamLink.Name);
                if (Settings.Read("lang_eng").ToLower().Contains("false"))
                {
                    lang_us = false;
                    pb_lang_us.BorderStyle = BorderStyle.None;
                    pb_lang_de.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch { }
            gameList.Items.Clear();
            gameList.View = View.Details;
            gameList.GridLines = true;
            gameList.FullRowSelect = true;
            if (lang_us)
                gameList.Columns.Add("Game", 298);
            else
                gameList.Columns.Add("Spiel", 298);
            gameList.Columns.Add("App-ID", 55);
            using (StreamReader sr = new StreamReader("games.chl"))
            {
                string[] arr;
                ListViewItem itm;
                string line;
                while (!sr.EndOfStream)
                {
                    bool shouldAdd = true;
                    line = sr.ReadLine();
                    arr = line.Split('	');
                    foreach (ListViewItem I in gameList.Items)
                    {
                        if (I.SubItems[1].Text == arr[1])
                        {
                            shouldAdd = false;
                            break;
                        }
                    }
                    if (shouldAdd)
                    {
                        itm = new ListViewItem(new string[] { arr[0], arr[1] });
                        gameList.Items.Add(itm);
                        gameList.Items[gameList.Items.Count - 1].Checked = arr[arr.Length - 1].ToLower() == "true" ? true : false;
                    }
                }
            }
            SetLang(lang_us);
            if (!txtSteamLink.Text.StartsWith("http"))
                txtSteamLink.Text = "http://steamcommunity.com/id/chiller1o1/";
            if (rbStartHidden.Checked && rbStartMin.Checked || !rbStartHidden.Checked && !rbStartMin.Checked)
                rbStartHidden.Checked = true;
            Main_Resize(sender, e);
            loaded = true;
            if (cbSorting.Text.ToLower().Contains("alphabet"))
            {
                gameList.Sorting = SortOrder.Ascending;
                gameList.Sort();
            }
        }

        private void tmrLic_Tick(object sender, EventArgs e)
        {
            tmrLic.Interval = 1200000;

            tmrLic.Stop();
            /*
             * 
             * 
             * 
             * 
             */ if (lang_us)
                lblState.Text = "Success: Connected to Steam!";
            else
                lblState.Text = "Erfolgreich: Verbindung zu Steam aktiv!";
        }

        private void All_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnDelItem.PerformClick();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            gbAddGame.SetBounds(12, 7, Width - gbSelectedGame.Width - 45, gbAddGame.Height);
            gbSelectedGame.SetBounds(gbAddGame.Right + 7, 7, gbSelectedGame.Width, gbSelectedGame.Height);
            gbSteamcommunity.SetBounds(12, 90, Width - gbSettings.Width - 45, gbSteamcommunity.Height);
            gbSettings.SetBounds(gbSteamcommunity.Right + 7, 90, gbSettings.Width, gbSettings.Height);
            btnStartAll.SetBounds(Width - btnStartAll.Width - 30, 185, btnStartAll.Width, btnStartAll.Height);
            btnKillIdlers.SetBounds(Width - btnKillIdlers.Width - 30, 273, btnKillIdlers.Width, btnKillIdlers.Height);
            lblActiveIdlers.SetBounds(Width - btnKillIdlers.Width - 30, 345, lblActiveIdlers.Width, lblActiveIdlers.Height);
            lblState.SetBounds(12, Height - 60, lblState.Width, lblState.Height);
            btnTradingCardBot.SetBounds(btnTradingCardBot.Bounds.X, Height - 63, btnTradingCardBot.Width, btnTradingCardBot.Height);
            try
            {
                gameList.SetBounds(12, 185, Width - btnStartAll.Width - 45, Height - gameList.Top - lblState.Height - 50);
                gameList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                gameList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch { }
            btnAddGame.SetBounds(gbAddGame.Left - 5, gbAddGame.Bottom - btnAddGame.Height - 15, gbAddGame.Width - 15, btnAddGame.Height);
            txtGameName.SetBounds(6, 17, gbAddGame.Width - 175, txtGameName.Height);
            lblsglGameName.SetBounds(txtGameName.Right, lblsglGameName.Bounds.Y, lblsglGameName.Width, lblsglGameName.Height);
            txtGameID.SetBounds(lblsglGameName.Right + 5, txtGameID.Bounds.Y, txtGameID.Width, txtGameID.Height);
            lblsglGameID.SetBounds(txtGameID.Right, lblsglGameID.Bounds.Y, lblsglGameID.Width, lblsglGameID.Height);
            txtSteamLink.SetBounds(txtSteamLink.Bounds.X, txtSteamLink.Bounds.Y, gbSteamcommunity.Width - 13, txtSteamLink.Height);
            btnFillListFromSteamCommunity.SetBounds(btnFillListFromSteamCommunity.Bounds.X, btnFillListFromSteamCommunity.Bounds.Y, gbSteamcommunity.Width - 13, btnFillListFromSteamCommunity.Height);
            
        }

        private void btnTradingCardBot_Click(object sender, EventArgs e)
        {
            TradingCardBot n = new TradingCardBot(this, KEY, Settings);
            n.Show();
            Hide();
        }

        private void cbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSorting.Text.ToLower().Contains("alphabet"))
            {
                Settings.Write(cbSorting.Name, "alphabet");
                gameList.Sorting = SortOrder.Ascending;
                gameList.Sort();
            }
            else
            {
                Settings.Write(cbSorting.Name, "hours");
                gameList.Sorting = SortOrder.None;
                gameList.Sort();
            }
        }
    }
}
