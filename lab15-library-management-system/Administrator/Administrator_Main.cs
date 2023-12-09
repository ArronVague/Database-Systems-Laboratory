﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab15_library_management_system.Administrator.Reader;

namespace lab15_library_management_system.Administrator
{
    public partial class Administrator_Main : Form
    {
        public string administrator_id;

        public Administrator_Main()
        {
            InitializeComponent();
        }

        private void Administrator_Main_Load(object sender, EventArgs e)
        {
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void Btn_Reader_Management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reader_Management reader_Management = new Reader_Management();
            reader_Management.administrator_id = administrator_id;
            reader_Management.Show();
        }
    }
}
