using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab11_case0604;
using MySql.Data.MySqlClient;

namespace lab12_case_student_id
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txt_Name.Clear();
            txt_Company.Clear();
            txt_Telephone.Clear();
            txt_Address.Clear();
            rbtn_Sex1.Checked = true;
            nudown_Age.Value = 0;
            lbl_Status.Text = "Add";
            customerid = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim();
            string company = txt_Company.Text.Trim();
            string sex = rbtn_Sex1.Checked ? "M" : "F";
            string age = nudown_Age.Value.ToString();
            string telephone = txt_Telephone.Text.Trim();
            string address = txt_Address.Text.Trim();

            if (name.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The name cannot be empty!";
                txt_Name.Focus();
                return;
            }

            if (lbl_Status.Text == "Add")
            {
                string query = string.Format("insert into Customer_info values(null, '{0}', '{1}', '{2}', {3}, '{4}', '{5}')", name, company, sex, age, telephone, address);
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

            if (lbl_Status.Text == "Modify")
            {
                string query = string.Format("UPDATE customer_info SET CustomerName='{0}', Company='{1}', Sex='{2}', Age={3}, Telephone='{4}', Address='{5}' WHERE CustomerID={6}", name, company, sex, age, telephone, address, customerid);
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

        private void DataBind_Customer()
        {
            string query = "SELECT * FROM customer_info";
            MySqlConnection conn = Database.GetMySqlConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            lv_Customer.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["CustomerID"].ToString());
                myitem.SubItems.Add(dr["CustomerName"].ToString());
                myitem.SubItems.Add(dr["Company"].ToString());
                myitem.SubItems.Add(dr["Sex"].ToString());
                myitem.SubItems.Add(dr["Age"].ToString());
                myitem.SubItems.Add(dr["Telephone"].ToString());
                myitem.SubItems.Add(dr["Address"].ToString());

                lv_Customer.Items.Add(myitem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
        }

        private string customerid;

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];

                customerid = myitem.SubItems[0].Text;
                txt_Name.Text = myitem.SubItems[1].Text;
                txt_Company.Text = myitem.SubItems[2].Text;
                rbtn_Sex1.Checked = myitem.SubItems[3].Text == "M" ? true : false;
                rbtn_Sex2.Checked = !rbtn_Sex1.Checked;
                nudown_Age.Value = decimal.Parse(myitem.SubItems[4].Text);
                txt_Telephone.Text = myitem.SubItems[5].Text;
                txt_Address.Text = myitem.SubItems[6].Text;

                lbl_Status.Text = "Modify";
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (customerid == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format("DELETE FROM customer_info WHERE CustomerID={0}", customerid);
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
    }
}
