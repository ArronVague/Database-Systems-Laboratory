using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15_library_management_system.Administrator.Library
{
    public partial class Library_Management : Form
    {
        public string administrator_id;

        public Library_Management()
        {
            InitializeComponent();
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
