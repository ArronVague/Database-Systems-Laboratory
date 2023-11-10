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

namespace lab11_case0604
{
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
/*            rbtn_Sex1.Checked = true;
            rbtn_Sex2.Checked = !rbtn_Sex1.Checked;*/
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // check whether username is null
            if (txt_Username.Text.Trim().Length == 0)
            {
                txt_Username.Focus();
                return;
            }

            if (txt_Password.Text.Trim().Length == 0)
            {
                txt_Password.Focus(); 
                return;
            }

            if (txt_RePassword.Text.Trim().Length == 0)
            {
                txt_RePassword.Focus();
                return;
            }

            if (txt_Password.Text.Trim() != txt_RePassword.Text.Trim())
            {
                MessageBox.Show("The passwords are different!");
                txt_RePassword.Focus();
                return;
            }

            if (!rbtn_Sex1.Checked && !rbtn_Sex2.Checked)
            {
                MessageBox.Show("Please select your sex!");
                return;
            }

            // check if the username has been used before 
            string username = txt_Username.Text.Trim();
            string query = string.Format("SELECT * FROM user_info WHERE UserName='{0}'", username);
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This username exists!");
                txt_Username.Focus();
                return;
            }

            string password = txt_Password.Text.Trim();
            int sex = rbtn_Sex1.Checked ? 1 : 2;
            string age = nudown_Age.Value.ToString();

            query = string.Format("INSERT INTO user_info VALUES(NULL, '{0}', '{1}', {2}, {3})", username, password, age, sex);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int affected = cmd.ExecuteNonQuery();
            conn.Close();

            if (affected > 0)
            {
                MessageBox.Show("Register successfully!");
                this.Close();
                Frm_Main frm = new Frm_Main();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Fail!");
            }
            return;
        }
    }
}
