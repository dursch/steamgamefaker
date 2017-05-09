using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamGameFaker
{
    public partial class TradingCardBot : Form
    {
        bool first = true;
        string HTMLBadgeCode;
        string BadgeURL = string.Empty;
        App[] Apps = new App[0];
        App CurrentApp;
        Form Sender;
        string KEY;
        IniFile Settings;
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern long DeleteUrlCacheEntry(string lpszUrlName);
        public TradingCardBot(object sender, string kEY, IniFile settings)
        {
            Settings = settings;
            Sender = (Form)sender;
            KEY = kEY;
            InitializeComponent();
        }

        private void TradingCardBot_Load(object sender, EventArgs e)
        {
            Browser.Navigate("https://steamcommunity.com/login/home/?goto=home");
            tConsoleWriteLine("Please login below...");
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (first)
            {
                if (BadgeURL != string.Empty)
                {
                    tConsoleWriteLine("Ready to farm Trading Cards.");
                    first = false;
                    tmrMainLoop.Start();
                    tConsoleWriteLine("Loop started...");
                }
                else if (Browser.Document.Body.OuterHtml.Replace('"', "'"[0]).ToLower().Contains("<a class='menuitem supernav username' href='http://steamcommunity.com/id/"))
                {
                    Browser.Hide();
                    BadgeURL = Browser.Document.Body.OuterHtml.Replace('"', "'"[0]).ToLower();
                    BadgeURL = BadgeURL.Substring(BadgeURL.IndexOf("<a class='menuitem supernav username' href='http://steamcommunity.com/id/") + "<a class='menuitem supernav username' href='".Length);
                    BadgeURL = BadgeURL.Substring(0, BadgeURL.IndexOf("/home"));
                    BadgeURL += "/badges/";
                    tConsoleWriteLine("Found everything!");
                    Browser.Navigate(BadgeURL);
                }
                else
                    tConsoleWriteLine("Something went wrong?");
            }
            else
            {
                HTMLBadgeCode = Browser.Document.Body.OuterHtml;
                getAppsFromHTML();
                if (Apps.Length > 0)
                {
                    if (CurrentApp.Started && Apps[0].ID == CurrentApp.ID)
                    {
                        CurrentApp = Apps[0];
                        CurrentApp.Started = true;
                    }
                    else
                        CurrentApp = Apps[0];
                    if (CurrentApp.Started)
                        tConsoleWriteLine(CurrentApp.GameTitle + " has " + CurrentApp.RemainingCards.ToString() + " drops left | ID: " + CurrentApp.ID);
                    else
                    {
                        KillIlders();
                        StartIdler(CurrentApp.ID, CurrentApp.GameTitle);
                        CurrentApp.Started = true;
                    }
                }
                else
                {
                    tConsoleWriteLine("No Trading Cards left!");
                    tmrMainLoop.Stop();
                    tConsoleWriteLine("If this message is showing wrong to you, try to login to Steam in browser, then type in 'Set BadgeURL http://steamcommunity.com/id/USERNAME/badges/' and then type in'Loop Start'.");
                }
            }
        }

        public struct App //Structure of a Game
        {
            public string ID;
            public int RemainingCards;
            public string GameTitle;
            public bool Started;
            public App(string id, int remainingCards, string gameTitle, bool started = false)
            {
                Started = started;
                ID = id;
                RemainingCards = remainingCards;
                GameTitle = gameTitle;
            }
        }

        private void getAppsFromHTML()
        {
            Apps = new App[0];
            string s = HTMLBadgeCode.Replace('"', "'"[0]);
            while (s.Contains("<DIV class='badge_row is_link'>"))
            {
                string ID;
                int RemainingCards = 0;
                string GameTitle;
                string Helper;
                s = s.Substring(s.IndexOf("<DIV class='badge_row is_link'>") + "<DIV class='badge_row is_link'>".Length);
                Helper = s.Substring(s.IndexOf("gamecards/") + "gamecards/".Length);
                Helper = Helper.Substring(0, Helper.IndexOf('/'));
                ID = Helper;
                Helper = s.Substring(0, s.IndexOf("<DIV style='CLEAR: both'></DIV></DIV></DIV></DIV>"));
                if (Helper.Contains("<SPAN class=progress_info_bold>"))
                {
                    Helper = Helper.Substring(Helper.IndexOf("<SPAN class=progress_info_bold>") + "<SPAN class=progress_info_bold>".Length);
                    Helper = Helper.Substring(0, Helper.ToLower().IndexOf("</span>"));
                    if (Helper.Contains("Keine"))
                        RemainingCards = 0;
                    else
                    {
                        Helper = Helper.Substring(0, Helper.IndexOf(' '));
                        if (!int.TryParse(Helper, out RemainingCards))
                            RemainingCards = 0;
                    }
                    if (RemainingCards > 0)
                    {
                        string Setting = Settings.Read("Block");
                        if (!Setting.StartsWith(ID + "|") && !Setting.Contains("|" + ID + "|"))
                        {
                            Helper = s.Substring(s.IndexOf("<DIV class=badge_title>") + "<DIV class=badge_title>".Length);
                            Helper = Helper.Substring(0, Helper.IndexOf("&nbsp;"));
                            GameTitle = Helper;
                            Array.Resize(ref Apps, Apps.Length + 1);
                            Apps[Apps.Length - 1] = new App(ID, RemainingCards, GameTitle);
                        }
                        else
                        {
                            tConsoleWriteLine("Blocked ID: " + ID);
                            Helper = s.Substring(s.IndexOf("<DIV class=badge_title>") + "<DIV class=badge_title>".Length);
                            Helper = Helper.Substring(0, Helper.IndexOf("&nbsp;"));
                            GameTitle = Helper;
                        }
                    }
                }
            }
        }

        private void tConsoleWriteLine(string txt)
        {
            tConsole.AppendText(txt + Environment.NewLine);
            tConsole.Select();
        }

        private void tmrMainLoop_Tick(object sender, EventArgs e)
        {
            tmrMainLoop.Interval = 60000;
            DeleteUrlCacheEntry(BadgeURL);
            Browser.Navigate(BadgeURL);
        }

        private void KillIlders()
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.ToLower().Contains("gamedummy"))
                    p.Kill();
            }
        }

        private void StartIdler(string ID, string Name)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "GameDummy.exe";
            proc.StartInfo.Arguments = ID;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            proc.Start();
            proc.PriorityClass = ProcessPriorityClass.Idle;
            tConsoleWriteLine("Idling " + Name + " (" + ID + ")");
        }

        private void TradingCardBot_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sender.Show();
            KillIlders();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tConsoleWriteLine(txtInput.Text);
            string[] arr = txtInput.Text.ToLower().Split(' ');
            switch (arr[0])
            {
                case "":
                    tConsoleWriteLine("Error: Empty input command");
                    break;
                case "clear":
                    tConsole.Clear();
                    break;
                case "hide":
                    if (arr.Length == 2)
                    {
                        switch (arr[1])
                        {
                            case "form":
                                this.Hide();
                                break;
                            case "sgf":
                                Sender.Hide();
                                break;
                            case "browser":
                                Browser.Hide();
                                break;
                            case "console":
                                tConsole.Hide();
                                break;
                            case "input":
                                txtInput.Hide();
                                btnSend.Hide();
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "show":
                    if (arr.Length == 2)
                    {
                        switch (arr[1])
                        {
                            case "form":
                                this.Show();
                                break;
                            case "sgf":
                            case "main":
                                Sender.Show();
                                break;
                            case "browser":
                                Browser.Show();
                                break;
                            case "console":
                                tConsole.Show();
                                break;
                            case "input":
                                txtInput.Show();
                                break;
                            case "licence":
                                tConsoleWriteLine("Active licence: " + KEY);
                                break;
                            case "url":
                                tConsoleWriteLine("Current Browser URL: " + Browser.Url.ToString());
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "exit":
                case "terminate":
                case "close":
                    if (arr.Length == 2)
                    {
                        switch (arr[1])
                        {
                            case "form":
                                Sender.Show();
                                Close();
                                break;
                            case "sgf":
                            case "main":
                                Environment.Exit(0);
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "min":
                    if (arr.Length == 2)
                    {
                        switch (arr[1])
                        {
                            case "form":
                                WindowState = FormWindowState.Minimized;
                                break;
                            case "sgf":
                            case "main":
                                Sender.WindowState = FormWindowState.Minimized;
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "restart":
                    if (arr.Length == 2)
                    {
                        switch (arr[1])
                        {
                            case "form":
                                new TradingCardBot(Sender, KEY, Settings).Show();
                                Close();
                                break;
                            case "sgf":
                            case "main":
                                Process.Start("SteamGameFaker.exe");
                                Environment.Exit(0);
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "loop":
                    if (arr.Length == 2)
                    {
                        switch (arr[1])
                        {
                            case "start":
                                tmrMainLoop.Start();
                                break;
                            case "stop":
                                tmrMainLoop.Stop();
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "startgame":
                    if (arr.Length == 2)
                        StartIdler(arr[1], arr[1]);
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "closeallgames":
                    KillIlders();
                    break;
                case "reload":
                    if (arr.Length == 2)
                        switch(arr[1])
                        {
                            case "tradingcards":
                                Browser.Navigate(BadgeURL);
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    else
                        tConsoleWriteLine("Error: Empty input object");
                    break;
                case "set":
                    if (arr.Length == 3)
                    {
                        switch (arr[1])
                        {
                            case "badgeurl":
                                BadgeURL = arr[2];
                                break;
                            default:
                                tConsoleWriteLine("Error: Unknown object: " + arr[1]);
                                break;
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Wrong amount of input objects");
                    break;
                case "block":
                    if (arr.Length == 2)
                    {
                        string Setting = Settings.Read("Block");
                        if (Setting.Contains(arr[1]))
                            tConsoleWriteLine(arr[1] + " is already in blocklist");
                        else
                        {
                            Settings.Write("Block", Setting + arr[1] + "|");
                            tConsoleWriteLine(arr[1] + " added to blocklist");
                        }
                    }
                    else
                        tConsoleWriteLine("Error: Wrong amount of input objects");
                    break;
                case "unblock":
                    if (arr.Length == 2)
                    {
                        string Setting = Settings.Read("Block");
                        if (Setting.Contains(arr[1]))
                        {
                            Settings.Write("Block", Setting.Replace(arr[1] + "|", string.Empty));
                            tConsoleWriteLine(arr[1] + " has been unblocked");
                        }
                        else
                            tConsoleWriteLine(arr[1] + " was not found in blocklist");
                    }
                    else
                        tConsoleWriteLine("Error: Wrong amount of input objects");
                    break;
                case "help":
                case "commands":
                default:
                    tConsoleWriteLine("Commands:");
                    for (int i = 0; i < txtInput.AutoCompleteCustomSource.Count; i++)
                    {
                        tConsoleWriteLine("     " + txtInput.AutoCompleteCustomSource[i]);
                    }
                    break;
            }
        }
    }
}
