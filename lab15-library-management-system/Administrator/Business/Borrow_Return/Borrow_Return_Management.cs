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

namespace lab15_library_management_system.Administrator.Business.Borrow_Return
{
    public partial class Borrow_Return_Management : Form
    {
        public string administrator_id;
        private string record_id;

        public Borrow_Return_Management()
        {
            InitializeComponent();
        }

        private void Borrow_Return_Management_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
            Databind_Category();
            Databind_Loss();
            ClearTextBox();
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void DataBind_Customer()
        {
            /*
             SELECT
    *
FROM
    book_borrowing_records;
             */
            string query = "SELECT * FROM book_borrowing_records";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            lv_Customer.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["BBid"].ToString());
                myitem.SubItems.Add(dr["BCid"].ToString());
                myitem.SubItems.Add(dr["Rid"].ToString());
                myitem.SubItems.Add(dr["BAid"].ToString());
                myitem.SubItems.Add(dr["RAid"].ToString());
                myitem.SubItems.Add(DateTime.Parse(dr["borrowing_time"].ToString()).ToString("yyyy/MM/dd"));
                // 日期格式为yyyy/MM/dd
                myitem.SubItems.Add(DateTime.Parse(dr["due_time"].ToString()).ToString("yyyy/MM/dd"));
                myitem.SubItems.Add(dr["renewals"].ToString());
                if (dr["return_time"].ToString() == "")
                {
                    myitem.SubItems.Add("");
                }
                else
                {
                    // 日期格式为yyyy/MM/dd
                    myitem.SubItems.Add(DateTime.Parse(dr["valid"].ToString()).ToString("yyyy/MM/dd"));
                }
                myitem.SubItems.Add(dr["overdue"].ToString() == "1" ? "Yes" : "No");
                myitem.SubItems.Add(dr["loss"].ToString() == "1" ? "Yes" : "No");

                lv_Customer.Items.Add(myitem);
            }
        }

        protected void Databind_Category()
        {
/*            string sql = "select * from reader_category";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Cb_Category.DataSource = dt;
            Cb_Category.DisplayMember = "name";
            Cb_Category.ValueMember = "Cid";
*/

        }

        protected void Databind_Loss()
        {
/*            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add(0, "No");
            dt.Rows.Add(1, "Yes");
            Cb_Loss.DataSource = dt;
            Cb_Loss.DisplayMember = dt.Columns[1].ColumnName;
            Cb_Loss.ValueMember = dt.Columns[0].ColumnName;*/
        }

        /*
         ListViewItem myitem = new ListViewItem(dr["Rid"].ToString());
                        myitem.SubItems.Add(dr["PASSWORD"].ToString());
                        myitem.SubItems.Add(dr["category"].ToString());
                        myitem.SubItems.Add(dr["name"].ToString());
                        myitem.SubItems.Add(dr["gender"].ToString());
                        myitem.SubItems.Add(dr["number"].ToString());
                        myitem.SubItems.Add(dr["registration"].ToString());
                        myitem.SubItems.Add(dr["valid"].ToString());
                        myitem.SubItems.Add(dr["currently"].ToString());
                        myitem.SubItems.Add(dr["cumulative"].ToString());
                        myitem.SubItems.Add(dr["loss"].ToString() == "True" ? "Yes" : "No");
                        myitem.SubItems.Add(dr["violations"].ToString());
                        myitem.SubItems.Add(dr["remark"].ToString());*/

        private void ClearTextBox()
        {
/*            Txt_ID.Clear();
            Txt_Password.Clear();
            Cb_Category.SelectedIndex = 0;
            Txt_Name.Clear();
            Txt_Gender.Clear();
            Txt_Number.Clear();
            Txt_Registration.Clear();
            Txt_Valid.Clear();
            Nudown_Currently.Value = 0;
            Nudown_Cumulative.Value = 0;
            Cb_Loss.SelectedIndex = 0;
            Nudown_Violations.Value = 0;
            Txt_Remark.Clear();
            Lbl_Status.Text = "Add";
            reader_id = "";*/

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
 /*           string ID = Txt_ID.Text.Trim();
            string password = Txt_Password.Text.Trim();
            string category = Cb_Category.SelectedValue.ToString();
            string name = Txt_Name.Text.Trim();
            string gender = Txt_Gender.Text.Trim();
            string number = Txt_Number.Text.Trim();
            string registration = Txt_Registration.Text.Trim();
            string valid = Txt_Valid.Text.Trim();
            string currently = Nudown_Currently.Value.ToString();
            string cumulative = Nudown_Cumulative.Value.ToString();
            string loss = Cb_Loss.SelectedValue.ToString();
            string violations = Nudown_Violations.Value.ToString();
            string remark = Txt_Remark.Text.Trim();

            if (ID.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The ID cannot be empty!";
                Txt_ID.Focus();
                return;
            }

            if (registration.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The registration cannot be empty!";
                Txt_Registration.Focus();
                return;
            }

            if (valid.Length == 0)
            {
                valid = "NULL";
            }
            else
            {
                valid = "'" + valid + "'";
            }

            if (Lbl_Status.Text == "Add")
            {
                string query = string.Format("INSERT INTO reader_information VALUES ({0},'{1}',{2},'{3}','{4}','{5}','{6}',{7},{8},{9},{10},{11},'{12}')", ID, password, category, name, gender, number, registration, valid, currently, cumulative, loss, violations, remark);
                MySqlConnection conn = Database.GetMySqlConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    lbl_Note.ForeColor = Color.Blue;
                    lbl_Note.Text = "Added successfully!";
                    ClearTextBox();
                    DataBind_Customer();
                }
                else
                {
                    lbl_Note.ForeColor = Color.Red;
                    lbl_Note.Text = "Add failed!";
                }
                return;
            }

            if (Lbl_Status.Text == "Modify")
            {
                string query = string.Format("UPDATE reader_information SET `Rid` = {0}, `Password` = '{1}', `Cid` = {2}, `name` = '{3}', `gender` = '{4}', `number` = '{5}', `registration` = '{6}', `valid` = {7}, `currently` = {8}, `cumulative` = {9}, `loss` = {10}, `violations` = {11}, `remark` = '{12}' WHERE `Rid` = {13}", ID, password, category, name, gender, number, registration, valid, currently, cumulative, loss, violations, remark, ID);
                MySqlConnection conn = Database.GetMySqlConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    lbl_Note.ForeColor = Color.Blue;
                    lbl_Note.Text = "Modified successfully!";
                    ClearTextBox();
                    DataBind_Customer();
                }
                else
                {
                    lbl_Note.ForeColor = Color.Red;
                    lbl_Note.Text = "Modify failed!";
                }
                return;
            }*/
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];

                Txt_ID.Text = myitem.SubItems[0].Text;
                reader_id = Txt_ID.Text;
                Txt_Password.Text = myitem.SubItems[1].Text;
                Cb_Category.Text = myitem.SubItems[2].Text;
                Txt_Name.Text = myitem.SubItems[3].Text;
                Txt_Gender.Text = myitem.SubItems[4].Text;
                Txt_Number.Text = myitem.SubItems[5].Text;
                Txt_Registration.Text = myitem.SubItems[6].Text;
                Txt_Valid.Text = myitem.SubItems[7].Text;
                Nudown_Currently.Value = decimal.Parse(myitem.SubItems[8].Text);
                Nudown_Cumulative.Value = decimal.Parse(myitem.SubItems[9].Text);
                Cb_Loss.Text = myitem.SubItems[10].Text;
                Nudown_Violations.Value = decimal.Parse(myitem.SubItems[11].Text);
                Txt_Remark.Text = myitem.SubItems[12].Text;
                Lbl_Status.Text = "Modify";
            }*/
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Note.Text = "";
        }

        private void Btn_Category_Management_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            /*if (reader_id == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format("DELETE FROM reader_information WHERE Rid={0}", reader_id);
                MySqlConnection conn = Database.GetMySqlConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    lbl_Note.ForeColor = Color.Blue;
                    lbl_Note.Text = "Deleted successfully!";
                    ClearTextBox();
                    DataBind_Customer();
                }
                else
                {
                    lbl_Note.ForeColor = Color.Red;
                    lbl_Note.Text = "Delete failed!";
                }
            }*/
        }
    }
}
