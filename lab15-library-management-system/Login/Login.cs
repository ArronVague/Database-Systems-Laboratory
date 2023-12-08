using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15_library_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected void Databind_Category()
        {
            string sql = "select * from reader_category";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Cb_Category.DataSource = dt;
            Cb_Category.DisplayMember = "name";
            Cb_Category.ValueMember = "Cid";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Databind_Category();
        }
    }
}
