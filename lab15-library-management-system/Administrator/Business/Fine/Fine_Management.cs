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

namespace lab15_library_management_system.Administrator.Business.Fine
{
    public partial class Fine_Management : Form
    {
        public string administrator_id;
        public string fine_id;

        public Fine_Management()
        {
            InitializeComponent();
        }

        private void Fine_Management_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
            Databind_Record_ID();

            Databind_Paid();
            ClearTextBox();
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void DataBind_Customer()
        {
            string query = "SELECT * FROM overdue_fine";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            lv_Customer.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["id"].ToString());
                myitem.SubItems.Add(dr["BBid"].ToString());
                myitem.SubItems.Add(dr["Aid"].ToString());
                myitem.SubItems.Add(dr["penalty"].ToString());
                myitem.SubItems.Add(dr["pay"].ToString() == "True" ? "Yes" : "No");
                myitem.SubItems.Add(DateTime.Parse(dr["fine_date"].ToString()).ToString("yyyy/MM/dd"));
                // 日期格式为yyyy/MM/dd
                myitem.SubItems.Add(dr["remark"].ToString());

                lv_Customer.Items.Add(myitem);
            }
        }

        protected void Databind_Record_ID()
        {
            string sql = "select * from book_borrowing_records";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Cb_Record_ID.DataSource = dt;
            Cb_Record_ID.DisplayMember = "BBid";
            Cb_Record_ID.ValueMember = "BBid";
        }


        protected void Databind_Paid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add(0, "No");
            dt.Rows.Add(1, "Yes");
            Cb_Paid.DataSource = dt;
            Cb_Paid.DisplayMember = dt.Columns[1].ColumnName;
            Cb_Paid.ValueMember = dt.Columns[0].ColumnName;
        }

        private void ClearTextBox()
        {
            /*Lbl_Show_ID.Text = "";
            Cb_Book_ID.SelectedIndex = 0;
            Cb_Reader_ID.SelectedIndex = 0;
            Lbl_Admin_Borrow_ID.Text = "";
            Lbl_Admin_return_ID.Text = "";
            Txt_Borrowing_time.Clear();
            Txt_Due_Time.Clear();
            Nudown_Renewals.Value = 0;
            Txt_Return_Time.Clear();
            Cb_Overdue.SelectedIndex = 0;
            Cb_Loss.SelectedIndex = 0;*/
            Lbl_Show_ID.Text = "";
            Cb_Record_ID.SelectedIndex = 0;
            Lbl_Show_Administrator_ID.Text = "";
            Txt_Penalty.Clear();
            Cb_Paid.SelectedIndex = 0;
            Txt_Fine_time.Clear();
            Txt_Remark.Clear();


            Lbl_Status.Text = "Add";
            fine_id = "";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            /*string book_id = Cb_Book_ID.SelectedValue.ToString();
            string reader_id = Cb_Reader_ID.SelectedValue.ToString();
            string administrator_borrow_id;
            string administrator_return_id;
            string borrowing_time = Txt_Borrowing_time.Text.Trim();
            string renewals = Nudown_Renewals.Value.ToString();
            string due_time = DateTime.Now.AddMonths(1 * (int.Parse(renewals) + 1)).ToString("yyyy/MM/dd");
            string return_time = Txt_Return_Time.Text.Trim();
            string overdue = Cb_Overdue.SelectedValue.ToString();
            string loss = Cb_Loss.SelectedValue.ToString();*/
            string record_id = Cb_Record_ID.SelectedValue.ToString();
            string show_administrator_id = Lbl_Show_Administrator_ID.Text.Trim();
            string penalty = Txt_Penalty.Text.Trim();
            string paid = Cb_Paid.SelectedValue.ToString();
            string fine_time = Txt_Fine_time.Text.Trim();
            string remark = Txt_Remark.Text.Trim();

            // 将remark中的单引号转义
            remark = remark.Replace("'", "\\'");

            if (show_administrator_id.Length == 0)
            {
                show_administrator_id = administrator_id;
            }

            if (penalty.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The borrowing time cannot be empty!";
                Txt_Penalty.Focus();
                return;
            }

            if (fine_time.Length == 0)
            {
                fine_time = "NULL";
            }
            else
            {
                fine_time = "'" + fine_time + "'";
            }

            /*INSERT INTO
    overdue_fine
VALUES
    (
        NULL,
        16,
        1,
        20.0,
        0,
        '2023/12/14',
        'remark'
    );*/

            if (Lbl_Status.Text == "Add")
            {

                string query = string.Format("INSERT INTO overdue_fine VALUES(NULL, {0}, {1}, {2}, {3}, {4}, '{5}')", record_id, show_administrator_id, penalty, paid, fine_time, remark);
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
                string query = string.Format(string.Format("UPDATE overdue_fine SET BBid={0}, Aid={1}, penalty={2}, pay={3}, fine_date={4}, remark='{5}' WHERE id={6}", record_id, show_administrator_id, penalty, paid, fine_time, remark, fine_id));
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
                /*record_id = item.SubItems[0].Text;
                Lbl_Show_ID.Text = item.SubItems[0].Text;
                Cb_Record_ID.SelectedValue = item.SubItems[1].Text;
                Cb_Reader_ID.SelectedValue = item.SubItems[2].Text;
                Lbl_Admin_Borrow_ID.Text = item.SubItems[3].Text;
                Lbl_Admin_return_ID.Text = item.SubItems[4].Text;
                Txt_Borrowing_time.Text = item.SubItems[5].Text;
                Txt_Due_Time.Text = item.SubItems[6].Text;
                Nudown_Renewals.Value = int.Parse(item.SubItems[7].Text);
                Txt_Return_Time.Text = item.SubItems[8].Text;
                Cb_Overdue.SelectedValue = item.SubItems[9].Text == "Yes" ? "1" : "0";
                Cb_Loss.SelectedValue = item.SubItems[10].Text == "Yes" ? "1" : "0";*/
                fine_id = item.SubItems[0].Text;
                Lbl_Show_ID.Text = item.SubItems[0].Text;
                Cb_Record_ID.SelectedValue = item.SubItems[1].Text;
                Lbl_Show_Administrator_ID.Text = item.SubItems[2].Text;
                Txt_Penalty.Text = item.SubItems[3].Text;
                Cb_Paid.SelectedValue = item.SubItems[4].Text == "Yes" ? "1" : "0";
                Txt_Fine_time.Text = item.SubItems[5].Text;
                Txt_Remark.Text = item.SubItems[6].Text;

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
            if (fine_id == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format("DELETE FROM overdue_fine WHERE id={0}", fine_id);
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
