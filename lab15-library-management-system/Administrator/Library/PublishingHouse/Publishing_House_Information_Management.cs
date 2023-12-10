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

namespace lab15_library_management_system.Administrator.Library.PublishingHouse
{
    public partial class Publishing_House_Information_Management : Form
    {
        private string pulishing_house_id;
        public string administrator_id;

        public Publishing_House_Information_Management()
        {
            InitializeComponent();
            ClearTextBox();
        }

        private void Publishing_House_Information_Management_Load(object sender, EventArgs e)
        {
            DataBind_Customer();
            Lbl_Administrator_ID.Text = administrator_id;
        }

        

        private void ClearTextBox()
        {
            Lbl_ID.Text = "";
            Txt_Name.Clear();
            Txt_Person.Clear();
            Txt_Number.Clear();
            Txt_Fax.Clear();
            Txt_Address.Clear();
            Lbl_Status.Text = "Add";
            pulishing_house_id = "";
        }

        private void DataBind_Customer()
        {
            string query = "SELECT * FROM publisher_information";
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
                myitem.SubItems.Add(dr["name"].ToString());
                myitem.SubItems.Add(dr["person"].ToString());
                myitem.SubItems.Add(dr["number"].ToString());
                myitem.SubItems.Add(dr["fax"].ToString());
                myitem.SubItems.Add(dr["address"].ToString());
                lv_Customer.Items.Add(myitem);
            }
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];

                pulishing_house_id = myitem.SubItems[0].Text;
                Lbl_ID.Text = pulishing_house_id;
                Txt_Name.Text = myitem.SubItems[1].Text;
                Txt_Person.Text = myitem.SubItems[2].Text;
                Txt_Number.Text = myitem.SubItems[3].Text;
                Txt_Fax.Text = myitem.SubItems[4].Text;
                Txt_Address.Text = myitem.SubItems[5].Text;

                Lbl_Status.Text = "Modify";
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (pulishing_house_id == "")
            {
                MessageBox.Show("Please select the one you want to delete");
                return;
            }

            DialogResult res = MessageBox.Show("Sure you want to delete?", "Delete tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = string.Format("DELETE FROM publisher_information WHERE id={0}", pulishing_house_id);
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


        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = Txt_Name.Text.Trim();
            string person = Txt_Person.Text.Trim();
            string number = Txt_Number.Text.Trim();
            string fax = Txt_Fax.Text.Trim();
            string address = Txt_Address.Text.Trim();

            if (number.Length == 0)
            {
                lbl_Note.ForeColor = Color.Red;
                lbl_Note.Text = "The number cannot be empty!";
                Txt_Name.Focus();
                return;
            }

            if (Lbl_Status.Text == "Add")
            {
                string query = string.Format("insert into publisher_information values(null, '{0}', '{1}', '{2}', '{3}', '{4}')", name, person, number, fax, address);
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
                string query = string.Format("UPDATE publisher_information SET name='{0}', person='{1}', number='{2}', fax='{3}', address='{4}' WHERE id={5}", name, person, number, fax, address, pulishing_house_id);
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
