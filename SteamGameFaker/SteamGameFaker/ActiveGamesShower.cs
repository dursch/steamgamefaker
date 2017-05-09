using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace SteamGameFaker
{
    public partial class ActiveGamesShower : Form
    {
        bool lang_us;
        Main.App[] ActiveGames;
        Main Sender;
        public ActiveGamesShower(Main.App[] activeGames, bool us, Main sender)
        {
            lang_us = us;
            ActiveGames = activeGames;
            Sender = sender;
            InitializeComponent();
            /*WebClient wClient = new WebClient();
            wClient.DownloadFile(ActiveGames[0].HeaderUrl.AbsoluteUri, ActiveGames[0].ID + ".png");
            Image fuck = Image.FromFile(ActiveGames[0].ID + ".png");
            ImageList iL = new ImageList();
            iL.Images.Add(fuck);
            activeGameList.SmallImageList = iL;*/
            if (lang_us)
            {
                Text = "Active Games";
                activeGameList.Columns.Add("Game", 234);
                activeGameList.Columns.Add("App-ID", 55);
                activeGameList.Columns.Add("Active", 55);
                chkRefresh.Text = "Refresh List";
                ActiveGameListMenu.Items[0].Text = "Delete Game from SteamGameFaker";
                ActiveGameListMenu.Items[1].Text = "Kill Game";
            }
            else
            {
                Text = "Aktive Spiele";
                activeGameList.Columns.Add("Spiel", 234);
                activeGameList.Columns.Add("App-ID", 55);
                activeGameList.Columns.Add("Aktiv", 55);
                chkRefresh.Text = "Liste aktualisieren";
                ActiveGameListMenu.Items[0].Text = "Spiel aus SteamGameFaker löschen";
                ActiveGameListMenu.Items[1].Text = "Spiel schließen";
            }
            activeGameList.View = View.Details;
            activeGameList.GridLines = true;
            activeGameList.FullRowSelect = true;
        }

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            if (new Rectangle(Cursor.Position, new Size(10, 10)).IntersectsWith(new Rectangle(Location, activeGameList.Size)) && activeGameList.Items.Count > 0)
                return;
            if (chkRefresh.Checked)
            {
                activeGameList.Items.Clear();
                foreach (Main.App app in ActiveGames)
                {
                    string procEnd;
                    if (lang_us)
                        procEnd = app.Proc.HasExited ? "Inactive" : "Active";
                    else
                        procEnd = app.Proc.HasExited ? "Inaktiv" : "Aktiv";
                    ListViewItem lvi = new ListViewItem(
                        new string[] {
                            app.Name,
                            app.ID,
                            procEnd
                        }
                    );
                    activeGameList.Items.Add(lvi);
                }
            }
        }

        private void dELFROMLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeGameList.FocusedItem == null)
                return;
            string output = "";
            using (StreamReader sr = new StreamReader("games.chl"))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(activeGameList.FocusedItem.SubItems[0].Text + '	') && !String.IsNullOrEmpty(line))
                        output += line + Environment.NewLine;
                }
            }
            File.WriteAllText("games.chl", output);
            activeGameList.FocusedItem.Remove();
            ActiveGames = Array.FindAll(ActiveGames,needsToBeKicked).ToArray();
            Sender.tmrLoad_Tick(sender, e);
        }

        private bool needsToBeKicked(Main.App app)
        {
            bool ret = false;
            foreach (ListViewItem lvi in activeGameList.Items)
            {
                if (lvi.SubItems[1].Text == app.ID)
                    ret = true;
            }
            return ret;
        }
        private void kILLIDLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeGameList.FocusedItem == null)
                return;
            string ID = activeGameList.FocusedItem.SubItems[1].Text;
            foreach (Main.App app in ActiveGames)
            {
                if (app.ID == ID)
                    app.Proc.Kill();
            }
        }

        private void ActiveGamesShower_Load(object sender, EventArgs e)
        {
            tmRefresh_Tick(sender, e);
        }
    }
}
