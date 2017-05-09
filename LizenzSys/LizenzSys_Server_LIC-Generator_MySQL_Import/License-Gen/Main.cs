using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using MySql.Data;
//using MySql.Data.MySqlClient;

namespace Licence_Gen
{
    public partial class Main : Form
    {
        double val = 0;
        //const string Connection = "SERVER=localhost;DATABASE=testlicence;UID=root;PASSWORD=passwort";
        Random rnd;
        public Main()
        {
            InitializeComponent();
        }

        private string getPKey(int Length)
        {
            string ret = string.Empty;
            System.Text.StringBuilder SB = new System.Text.StringBuilder();
            string Content = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw";
            for (int i = 0; i < Length; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            return SB.ToString();
        }

        private void getKey()
        {
            txtPKey0.Text = getPKey(5);
            txtPKey1.Text = getPKey(5);
            txtPKey2.Text = getPKey(5);
            txtPKey3.Text = getPKey(5);
            txtPKey4.Text = getPKey(5);
            txtKey.Text = txtPKey0.Text + '-' + txtPKey1.Text + '-' + txtPKey2.Text + '-' + txtPKey3.Text + '-' + txtPKey4.Text;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            getKey();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            getKey();
        }

        private void txtPKey_TextChanged(object sender, EventArgs e)
        {
            txtKey.Text = txtPKey0.Text + '-' + txtPKey1.Text + '-' + txtPKey2.Text + '-' + txtPKey3.Text + '-' + txtPKey4.Text;
        }

        private void btnMySQLSaveKey_Click(object sender, EventArgs e)
        {
            /*
            MySqlConnection myConnection = new MySqlConnection(Connection);
            string myInsertQuery = "INSERT INTO licence (mkey, time) Values('" + txtKey.Text + "', '" + val.ToString() + "')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
            */
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val = Convert.ToInt32(txtTime.Text);
                val *= 86400;
            }
            catch
            {
                val = 0;
            }
        }
    }
}
