using lab15_library_management_system.Administrator;
using lab15_library_management_system.Reader;
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
            // 管理员身份不属于读者类别，但是需要显示在下拉框中
            dt.Rows.Add(0, "administrator");
            Cb_Category.DataSource = dt;
            Cb_Category.DisplayMember = "name";
            Cb_Category.ValueMember = "Cid";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Databind_Category();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter ID!");
                Txt_ID.Focus();
                return;
            }

            if (Txt_Password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter password!");
                Txt_Password.Focus();
                return;
            }

            // 确认下拉框身份，来决定从哪张表中查询
            string category = Cb_Category.Text.Trim();
            string table;
            string table_id;

            if (category == "administrator")
            {
                table = "administrator_information";
                table_id = "Aid";
            }
            else
            {
                table = "reader_information";
                table_id = "Rid";
            }

            string ID = Txt_ID.Text.Trim();

            string query = string.Format("SELECT * FROM {0} WHERE {1}='{2}'", table, table_id, ID);

            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("ID does not exist!");
                return;
            }

            string password = Txt_Password.Text.Trim();
            if (dt.Rows[0]["password"].ToString() != password)
            {
                MessageBox.Show("Wrong password!");
                return;
            }

            this.Hide();
            
            if (category == "administrator")
            {
                Administrator_Main administrator_Main = new Administrator_Main();
                administrator_Main.Show();
            }
            else
            {
                Reader_Main reader_Main = new Reader_Main();
                reader_Main.Show();
            }
        }
    }
}
