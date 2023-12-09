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

namespace lab15_library_management_system.Administrator.Reader.Category
{
    public partial class Category_Management : Form
    {
        private string category_id;
        public string administrator_id;

        public Category_Management()
        {
            InitializeComponent();
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            Lbl_ID.Text = "";
            Txt_Name.Clear();
            NuDown_Books.Value = 0;
            Nudown_Days.Value = 0;
            Lbl_Status.Text = "Add";
            category_id = "";
        }

        private void DataBind_Customer()
        {
            string query = "SELECT * FROM reader_category";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            lv_Customer.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["Cid"].ToString());
                myitem.SubItems.Add(dr["name"].ToString());
                myitem.SubItems.Add(dr["books"].ToString());
                myitem.SubItems.Add(dr["days"].ToString());
                lv_Customer.Items.Add(myitem);
            }
        }

        

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];

                category_id = myitem.SubItems[0].Text;
                Lbl_ID.Text = category_id;
                Txt_Name.Text = myitem.SubItems[1].Text;
                NuDown_Books.Value = decimal.Parse(myitem.SubItems[2].Text);
                Nudown_Days.Value = decimal.Parse(myitem.SubItems[3].Text);

                Lbl_Status.Text = "Modify";
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (category_id == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format("DELETE FROM reader_category WHERE Cid={0}", category_id);
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Note.Text = "";
        }

        private void Category_Management_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = Txt_Name.Text.Trim();
            string books = NuDown_Books.Value.ToString();
            string days = Nudown_Days.Value.ToString();

            if (name.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The name cannot be empty!";
                Txt_Name.Focus();
                return;
            }

            if (Lbl_Status.Text == "Add")
            {
                string query = string.Format("insert into reader_category values(null, '{0}', {1}, {2})", name, books, days);
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
                string query = string.Format("UPDATE reader_category SET name='{0}', books={1}, days={2} WHERE Cid={3}", name, books, days, category_id);
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

        private void Btn_Category_Management_Return_Click(object sender, EventArgs e)
        {
            // 返回上一个界面
            this.Close();
        }
    }
}
