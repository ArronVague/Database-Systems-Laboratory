using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab15_library_management_system.Administrator.Reader.Category;

namespace lab15_library_management_system.Administrator.Reader
{
    public partial class Reader_Management : Form
    {
        public string administrator_id;

        public Reader_Management()
        {
            InitializeComponent();
        }

        private void Btn_Category_Management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management category_Management = new Category_Management();
            category_Management.administrator_id = administrator_id;
            category_Management.ShowDialog();
            this.Show();
        }

        private void Reader_Management_Load(object sender, EventArgs e)
        {
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
