using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab15_library_management_system.Administrator.Business.Borrow_Return;

namespace lab15_library_management_system.Administrator.Business
{
    public partial class Business_Management : Form
    {
        public string administrator_id;

        public Business_Management()
        {
            InitializeComponent();
        }

        private void Business_Management_Load(object sender, EventArgs e)
        {
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Books_borrowing_returning_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow_Return_Management borrow_return_management = new Borrow_Return_Management();
            borrow_return_management.administrator_id = administrator_id;
            borrow_return_management.ShowDialog();
            this.Show();
        }
    }
}
