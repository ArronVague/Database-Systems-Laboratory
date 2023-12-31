﻿using lab15_library_management_system.Administrator.Library.PublishingHouse;
using lab15_library_management_system.Administrator.Library.Basic;
using lab15_library_management_system.Administrator.Library.Collection;
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

        private void Btn_Publishing_house_information_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Publishing_House_Information_Management publishing_House_Information_Management = new Publishing_House_Information_Management();
            publishing_House_Information_Management.administrator_id = administrator_id;
            publishing_House_Information_Management.ShowDialog();
            this.Show();
        }

        private void Library_Management_Load(object sender, EventArgs e)
        {
            Lbl_Administrator_ID.Text = administrator_id;
        }

        private void Btn_Basic_information_management_of_books_Click(object sender, EventArgs e)
        {
            this.Hide();
            Basic_Management basic_Management = new Basic_Management();
            basic_Management.administrator_id = administrator_id;
            basic_Management.ShowDialog();
            this.Show();
        }

        private void Btn_Collection_book_information_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Collection_Management collection_Management = new Collection_Management();
            collection_Management.administrator_id = administrator_id;
            collection_Management.ShowDialog();
            this.Show();
        }
    }
}
