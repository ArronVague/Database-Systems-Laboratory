using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15_library_management_system.Administrator.Library.Basic
{
    public partial class Basic_Management : Form
    {
        public string administrator_id;
        private string basic_book_id;

        public Basic_Management()
        {
            InitializeComponent();
        }

        private void DataBind_Customer()
        {
            /*
             SELECT
                ISBN,
                publisher_information.name AS publisher,
                basic_information_books.name,
                TYPE,
                author,
                edition,
                publication_date,
                price,
                introduction,
                quantity,
                total
            FROM
                basic_information_books,
                publisher_information
            WHERE
                basic_information_books.`id` = publisher_information.`id`;*/
            string query = "SELECT ISBN, publisher_information.name AS publisher, basic_information_books.name, TYPE, author, edition, publication_date, price, introduction, quantity, total FROM basic_information_books, publisher_information WHERE basic_information_books.`id` = publisher_information.`id`";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            lv_Customer.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["ISBN"].ToString());
                myitem.SubItems.Add(dr["publisher"].ToString());
                myitem.SubItems.Add(dr["name"].ToString());
                myitem.SubItems.Add(dr["TYPE"].ToString());
                myitem.SubItems.Add(dr["author"].ToString());
                myitem.SubItems.Add(dr["edition"].ToString());
                // 日期格式为yyyy/MM/dd
                myitem.SubItems.Add(DateTime.Parse(dr["publication_date"].ToString()).ToString("yyyy/MM/dd"));
                myitem.SubItems.Add(dr["price"].ToString());
                myitem.SubItems.Add(dr["introduction"].ToString());
                myitem.SubItems.Add(dr["quantity"].ToString());
                myitem.SubItems.Add(dr["total"].ToString());
/*                if (dr["valid"].ToString() == "")
                {
                    myitem.SubItems.Add("");
                }
                else
                {
                    // 日期格式为yyyy/MM/dd
                    myitem.SubItems.Add(DateTime.Parse(dr["valid"].ToString()).ToString("yyyy/MM/dd"));
                }   */
                lv_Customer.Items.Add(myitem);
            }
        }

        private void Information_Management_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
            ClearTextBox();
            Lbl_Administrator_ID.Text = administrator_id;
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
            /*ISBN,
                publisher_information.name AS publisher,
                basic_information_books.name,
                TYPE,
                author,
                edition,
                publication_date,
                price,
                introduction,
                quantity,
                total*/
            Txt_ISBN.Clear();
            Txt_Publishing_House.Clear();
            Txt_Name.Clear();
            Txt_Type.Clear();
            Txt_Author.Clear();
            Txt_Edition.Clear();
            Txt_Publication_Date.Clear();
            Txt_Price.Clear();
            Txt_Introduction.Clear();
            Nudown_Quantity.Value = 0;
            Nudown_Total.Value = 0;
            Lbl_Status.Text = "Add";
            basic_book_id = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
/*            string ISBN = Txt_ISBN.Text.Trim();
            string publishing_house = Txt_Publishing_House.Text.Trim();
            string name = Txt_Type.Text.Trim();
            string type = Txt_Type.Text.Trim();
            string author = Txt_Author.Text.Trim();
            string edition = Txt_Edition.Text.Trim();
            string publication_date = Txt_Publication_Date.Text.Trim();
            string price = Txt_Price.Text.Trim();
            string introduction = Txt_Introduction.Text.Trim();
            string quantity = Nudown_Quantity.Value.ToString();
            string total = Nudown_Total.Value.ToString();

            if (ID.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The ID cannot be empty!";
                Txt_ISBN.Focus();
                return;
            }

            if (registration.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The registration cannot be empty!";
                Txt_Publication_Date.Focus();
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
  /*          if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];

                Txt_ISBN.Text = myitem.SubItems[0].Text;
                reader_id = Txt_ISBN.Text;
                Txt_Publishing_House.Text = myitem.SubItems[1].Text;
                Cb_Category.Text = myitem.SubItems[2].Text;
                Txt_Type.Text = myitem.SubItems[3].Text;
                Txt_Author.Text = myitem.SubItems[4].Text;
                Txt_Edition.Text = myitem.SubItems[5].Text;
                Txt_Publication_Date.Text = myitem.SubItems[6].Text;
                Txt_Price.Text = myitem.SubItems[7].Text;
                Nudown_Currently.Value = decimal.Parse(myitem.SubItems[8].Text);
                Nudown_Quantity.Value = decimal.Parse(myitem.SubItems[9].Text);
                Cb_Loss.Text = myitem.SubItems[10].Text;
                Nudown_Total.Value = decimal.Parse(myitem.SubItems[11].Text);
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
/*            if (reader_id == "")
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
