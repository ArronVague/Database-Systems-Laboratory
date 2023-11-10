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
            string filePath = "../../../config.ini";

            List<string> config = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string value = parts[1];
                        config.Add(value);
                    }
                }
            }
  
            string server = config[0];
            string database = config[1];
            string UID = config[2];
            string PWD = config[3];
            string port = config[4];
            string connectStr = string.Format("server={0}; database={1}; UID={2}; PWD={3}; port={4}", server, database, UID, PWD, port);

            string query = "select * from User_Info";
            
            MySqlConnection conn = new MySqlConnection(connectStr);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
