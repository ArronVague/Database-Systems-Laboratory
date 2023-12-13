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
            Databind_Book_ID();
            Databind_Reader_ID();
            Databind_Overdue();
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
                    myitem.SubItems.Add(DateTime.Parse(dr["return_time"].ToString()).ToString("yyyy/MM/dd"));
                }
                myitem.SubItems.Add(dr["overdue"].ToString() == "True" ? "Yes" : "No");
                myitem.SubItems.Add(dr["loss"].ToString() == "True" ? "Yes" : "No");

                lv_Customer.Items.Add(myitem);
            }
        }

        protected void Databind_Book_ID()
        {
            string sql = "select * from book_collection_information";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Cb_Book_ID.DataSource = dt;
            Cb_Book_ID.DisplayMember = "BCid";
            Cb_Book_ID.ValueMember = "BCid";
        }

        protected void Databind_Reader_ID()
        {
            string sql = "select * from reader_information";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Cb_Reader_ID.DataSource = dt;
            Cb_Reader_ID.DisplayMember = "Rid";
            Cb_Reader_ID.ValueMember = "Rid";
        }

        protected void Databind_Overdue()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add(0, "No");
            dt.Rows.Add(1, "Yes");
            Cb_Overdue.DataSource = dt;
            Cb_Overdue.DisplayMember = dt.Columns[1].ColumnName;
            Cb_Overdue.ValueMember = dt.Columns[0].ColumnName;
        }

        protected void Databind_Loss()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add(0, "No");
            dt.Rows.Add(1, "Yes");
            Cb_Loss.DataSource = dt;
            Cb_Loss.DisplayMember = dt.Columns[1].ColumnName;
            Cb_Loss.ValueMember = dt.Columns[0].ColumnName;
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
            Lbl_Show_ID.Text = "";
            Cb_Book_ID.SelectedIndex = 0;
            Cb_Reader_ID.SelectedIndex = 0;
            Lbl_Admin_Borrow_ID.Text = "";
            Lbl_Admin_return_ID.Text = "";
            Txt_Borrowing_time.Clear();
            Txt_Due_Time.Clear();  
            Nudown_Renewals.Value = 0;
            Txt_Return_Time.Clear();
            Cb_Overdue.SelectedIndex = 0;
            Cb_Loss.SelectedIndex = 0;

            Lbl_Status.Text = "Add";
            record_id = "";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            /*string ID = Txt_ID.Text.Trim();
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
            string remark = Txt_Remark.Text.Trim();*/
            string book_id = Cb_Book_ID.SelectedValue.ToString();
            string reader_id = Cb_Reader_ID.SelectedValue.ToString();
            string administrator_borrow_id;
            string administrator_return_id;
            string borrowing_time = Txt_Borrowing_time.Text.Trim();
            string renewals = Nudown_Renewals.Value.ToString();
            string due_time = DateTime.Now.AddMonths(1 * (int.Parse(renewals) + 1)).ToString("yyyy/MM/dd");
            string return_time = Txt_Return_Time.Text.Trim();
            string overdue = Cb_Overdue.SelectedValue.ToString();
            string loss = Cb_Loss.SelectedValue.ToString();

            if (Lbl_Status.Text == "Add")
            {
                administrator_borrow_id = administrator_id;
            }
            else
            {
                administrator_borrow_id = Lbl_Admin_Borrow_ID.Text;
            }

            if (borrowing_time.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The borrowing time cannot be empty!";
                Txt_Borrowing_time.Focus();
                return;
            }

            if (return_time.Length == 0)
            {
                return_time = "NULL";
                administrator_return_id = "NULL";
            }
            else
            {
                if (DateTime.Parse(return_time) > DateTime.Parse(due_time))
                {
                    overdue = "1";
                }
                return_time = "'" + return_time + "'";
                administrator_return_id = administrator_id;
                // return_time比due_time晚，overdue为1
                
            }

            /*INSERT INTO
                book_borrowing_records
            VALUES
                (
                    NULL,
                    203,
                    1,
                    2,
                    1,
                    '2021-01-01',
                    '2021-01-01',
                    1,
                    '2021-01-01',
                    0,
                    0
                );*/

            if (Lbl_Status.Text == "Add")
            {
                
                string query = string.Format("INSERT INTO book_borrowing_records VALUES (NULL, {0}, {1}, {2}, {3}, '{4}', '{5}', {6}, {7}, {8}, {9})", book_id, reader_id, administrator_borrow_id, administrator_return_id, borrowing_time, due_time, renewals, return_time, overdue, loss);
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
                string query = string.Format(string.Format("UPDATE book_borrowing_records SET BCid={0}, Rid={1}, BAid={2}, RAid={3}, borrowing_time='{4}', due_time='{5}', renewals={6}, return_time={7}, overdue={8}, loss={9} WHERE BBid={10}", book_id, reader_id, administrator_borrow_id, administrator_return_id, borrowing_time, due_time, renewals, return_time, overdue, loss, record_id));
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
            }
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Customer.SelectedItems[0];
                record_id = item.SubItems[0].Text;
                Lbl_Show_ID.Text = item.SubItems[0].Text;
                Cb_Book_ID.SelectedValue = item.SubItems[1].Text;
                Cb_Reader_ID.SelectedValue = item.SubItems[2].Text;
                Lbl_Admin_Borrow_ID.Text = item.SubItems[3].Text;
                Lbl_Admin_return_ID.Text = item.SubItems[4].Text;
                Txt_Borrowing_time.Text = item.SubItems[5].Text;
                Txt_Due_Time.Text = item.SubItems[6].Text;
                Nudown_Renewals.Value = int.Parse(item.SubItems[7].Text);
                Txt_Return_Time.Text = item.SubItems[8].Text;
                Cb_Overdue.SelectedValue = item.SubItems[9].Text == "Yes" ? "1" : "0";
                Cb_Loss.SelectedValue = item.SubItems[10].Text == "Yes" ? "1" : "0";

                Lbl_Status.Text = "Modify";
            }
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
            if (record_id == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format(Name = "DELETE FROM book_borrowing_records WHERE BBid={0}", record_id);
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
            }
        }
    }
}
