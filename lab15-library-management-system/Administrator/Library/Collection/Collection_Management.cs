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

namespace lab15_library_management_system.Administrator.Library.Collection
{
    public partial class Collection_Management : Form
    {
        public string administrator_id;
        private string collection_book_id;

        public Collection_Management()
        {
            InitializeComponent();
        }

        private void Collection_Management_Load(object sender, EventArgs e)
        {
            DataBind_Collection_Books();
            Databind_Staus();
            Databind_ISBN();
            ClearTextBox();
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void DataBind_Collection_Books()
        {
            /*
            SELECT
    *
FROM
    book_collection_information;*/
            string query = "SELECT * FROM book_collection_information";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            lv_Customer.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["BCid"].ToString());
                myitem.SubItems.Add(dr["ISBN"].ToString());
                // 日期格式为yyyy/MM/dd
                if (dr["storage_time"].ToString() == "")
                {
                    myitem.SubItems.Add("");
                }
                else
                {
                    // 日期格式为yyyy/MM/dd
                    myitem.SubItems.Add(DateTime.Parse(dr["storage_time"].ToString()).ToString("yyyy/MM/dd"));
                }
                myitem.SubItems.Add(dr["status"].ToString());
                lv_Customer.Items.Add(myitem);
            }
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

        protected void Databind_ISBN()
        {
            string sql = "SELECT * FROM basic_information_books";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Cb_ISBN.DataSource = dt;
            Cb_ISBN.DisplayMember = "ISBN";
            Cb_ISBN.ValueMember = "ISBN";
        }

        private void ClearTextBox()
        {
            Lbl_ID.Text = "";
            // combox这样好像不清空
            /*Cb_ISBN.Text = "";*/
            Cb_ISBN.SelectedIndex = 0;
            Txt_Storage_Time.Clear();
            Cb_Status.SelectedIndex = 0;

            Lbl_Status.Text = "Add";
            collection_book_id = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ISBN = Cb_ISBN.SelectedValue.ToString();
            string storage_time = Txt_Storage_Time.Text.Trim();
            string status = Cb_Status.Text.Trim();

            /*string ISBN = Txt_ISBN.Text.Trim();
            string publishing_house = Cb_ph.SelectedValue.ToString();
            string name = Txt_Type.Text.Trim();
            string type = Txt_Type.Text.Trim();
            string author = Txt_Author.Text.Trim();
            string edition = Txt_Edition.Text.Trim();
            string publication_date = Txt_Publication_Date.Text.Trim();
            string price = Txt_Price.Text.Trim();
            string introduction = Txt_Introduction.Text.Trim();
            string quantity = Nudown_Quantity.Value.ToString();
            string total = Nudown_Total.Value.ToString();*/

            if (storage_time.Length == 0)
            {
                storage_time = "NULL";
            }
            else
            {
                storage_time = "'" + storage_time + "'";
            }

            if (Lbl_Status.Text == "Add")
            {
                /*
                 INSERT INTO
                    book_collection_information
                VALUES
                    (
                        NULL,
                        'ISBN',
                        '2021-01-01',
                        'not lent'
                    );*/
                string query = string.Format("INSERT INTO book_collection_information VALUES (NULL,'{0}',{1},'{2}')", ISBN, storage_time, status);


                /*string query = string.Format("INSERT INTO reader_information VALUES ({0},'{1}',{2},'{3}','{4}','{5}','{6}',{7},{8},{9},{10},{11},'{12}')", ID, password, category, name, gender, number, registration, valid, currently, cumulative, loss, violations, remark);*/
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
                    DataBind_Collection_Books();
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
                string query = string.Format("UPDATE book_collection_information SET `ISBN` = '{0}', `storage_time` = {1}, `status` = '{2}' WHERE `BCid` = {3}", ISBN, storage_time, status, collection_book_id);

                /*string query = string.Format("UPDATE reader_information SET `Rid` = {0}, `Password` = '{1}', `Cid` = {2}, `name` = '{3}', `gender` = '{4}', `number` = '{5}', `registration` = '{6}', `valid` = {7}, `currently` = {8}, `cumulative` = {9}, `loss` = {10}, `violations` = {11}, `remark` = '{12}' WHERE `Rid` = {13}", ID, password, category, name, gender, number, registration, valid, currently, cumulative, loss, violations, remark, ID);*/
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
                    DataBind_Collection_Books();
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
                ListViewItem myitem = lv_Customer.SelectedItems[0];
                Lbl_ID.Text = myitem.SubItems[0].Text;
                collection_book_id = Lbl_ID.Text;
                Cb_ISBN.Text = myitem.SubItems[1].Text;
                Txt_Storage_Time.Text = myitem.SubItems[2].Text;
                Cb_Status.Text = myitem.SubItems[3].Text;
                /*Txt_ISBN.Text = myitem.SubItems[0].Text;
                basic_book_id = Txt_ISBN.Text;
                Cb_ph.Text = myitem.SubItems[1].Text;
                Txt_Name.Text = myitem.SubItems[2].Text;
                Txt_Type.Text = myitem.SubItems[3].Text;
                Txt_Author.Text = myitem.SubItems[4].Text;
                Txt_Edition.Text = myitem.SubItems[5].Text;
                Txt_Publication_Date.Text = myitem.SubItems[6].Text;
                Txt_Price.Text = myitem.SubItems[7].Text;
                Txt_Introduction.Text = myitem.SubItems[8].Text;
                Nudown_Quantity.Value = decimal.Parse(myitem.SubItems[9].Text);
                Nudown_Total.Value = decimal.Parse(myitem.SubItems[10].Text);*/
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
            if (collection_book_id == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format("DELETE FROM book_collection_information WHERE BCid={0}", collection_book_id);

                /*string query = string.Format("DELETE FROM reader_information WHERE Rid={0}", reader_id);*/
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
                    DataBind_Collection_Books();
                }
                else
                {
                    lbl_Note.ForeColor = Color.Red;
                    lbl_Note.Text = "Delete failed!";
                }
            }
        }

        protected void Databind_Staus()
        {
            /*DataTable dt = new DataTable();
                        dt.Columns.Add("id", typeof(int));
                        dt.Columns.Add("name", typeof(string));
                        dt.Rows.Add(0, "No");
                        dt.Rows.Add(1, "Yes");
                        Cb_Loss.DataSource = dt;
                        Cb_Loss.DisplayMember = dt.Columns[1].ColumnName;
                        Cb_Loss.ValueMember = dt.Columns[0].ColumnName;*/

            DataTable dt = new DataTable();
            dt.Columns.Add("string", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add("not lent", "not lent");
            dt.Rows.Add("lent", "lent");
            dt.Rows.Add("lost", "lost");
            Cb_Status.DataSource = dt;
            Cb_Status.DisplayMember = dt.Columns[1].ColumnName;
            Cb_Status.ValueMember = dt.Columns[0].ColumnName;
        }
    }
}
