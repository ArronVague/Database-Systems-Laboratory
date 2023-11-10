using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab11_case0604
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter username!");
                txt_UserName.Focus();
                return;
            }

            if (txt_Password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter password!");
                txt_Password.Focus();
                return;
            }
            
            List<string> config = DatabaseConfig.GetConfig();
            string connectStr = string.Format("server={0}; database={1}; UID={2}; PWD={3}; port={4}", config[0], config[1], config[2], config[3], config[4]);

            string username = txt_UserName.Text.Trim();

            string query = string.Format("SELECT * FROM user_info WHERE UserName='{0}'", username);
            
            MySqlConnection conn = new MySqlConnection(connectStr);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Username does not exist!");
                return;
            }

            string password = txt_Password.Text.Trim();
            if (dt.Rows[0]["password"].ToString() != password)
            {
                MessageBox.Show("Wrong password!");
                return;
            }

            this.Hide();
            Frm_Main frm = new Frm_Main();
            frm.Show();
        }
    }
}
