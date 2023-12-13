namespace lab15_library_management_system.Administrator.Business.Borrow_Return
{
    partial class Borrow_Return_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Note = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cb_Loss = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Return_Time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Due_Time = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Borrowing_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Admin_return_ID = new System.Windows.Forms.Label();
            this.Lbl_Admin_Borrow_ID = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_Book_ID = new System.Windows.Forms.ComboBox();
            this.Lbl_Show_ID = new System.Windows.Forms.Label();
            this.Cb_Overdue = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Cb_Reader_ID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Category_Management_Return = new System.Windows.Forms.Button();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Nudown_Renewals = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Information_Management = new System.Windows.Forms.Button();
            this.Btn_Category_Management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Renewals)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.lbl_Note);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(11, 284);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(485, 335);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reader information list";
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(10, 18);
            this.lv_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(468, 313);
            this.lv_Customer.TabIndex = 19;
            this.lv_Customer.UseCompatibleStateImageBehavior = false;
            this.lv_Customer.View = System.Windows.Forms.View.Details;
            this.lv_Customer.SelectedIndexChanged += new System.EventHandler(this.lv_Customer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reader ID";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Admin borrow ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Admin return ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Borrowing time";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Due time";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Renewals";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Return time";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Overdue";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Loss";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(237, 0);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 12);
            this.lbl_Note.TabIndex = 18;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(161, -6);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(61, 24);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cb_Loss);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_Return_Time);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Due_Time);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_Borrowing_time);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Lbl_Admin_return_ID);
            this.groupBox1.Controls.Add(this.Lbl_Admin_Borrow_ID);
            this.groupBox1.Controls.Add(this.test);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Cb_Book_ID);
            this.groupBox1.Controls.Add(this.Lbl_Show_ID);
            this.groupBox1.Controls.Add(this.Cb_Overdue);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Cb_Reader_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Category_Management_Return);
            this.groupBox1.Controls.Add(this.Lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.Nudown_Renewals);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(485, 269);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit reader information  Status:";
            // 
            // Cb_Loss
            // 
            this.Cb_Loss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Loss.FormattingEnabled = true;
            this.Cb_Loss.Location = new System.Drawing.Point(320, 167);
            this.Cb_Loss.Name = "Cb_Loss";
            this.Cb_Loss.Size = new System.Drawing.Size(60, 20);
            this.Cb_Loss.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 57;
            this.label9.Text = "Loss";
            // 
            // Txt_Return_Time
            // 
            this.Txt_Return_Time.Location = new System.Drawing.Point(320, 108);
            this.Txt_Return_Time.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Return_Time.Name = "Txt_Return_Time";
            this.Txt_Return_Time.Size = new System.Drawing.Size(124, 21);
            this.Txt_Return_Time.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "Return time";
            // 
            // Txt_Due_Time
            // 
            this.Txt_Due_Time.Location = new System.Drawing.Point(98, 195);
            this.Txt_Due_Time.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Due_Time.Name = "Txt_Due_Time";
            this.Txt_Due_Time.Size = new System.Drawing.Size(124, 21);
            this.Txt_Due_Time.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "Due time";
            // 
            // Txt_Borrowing_time
            // 
            this.Txt_Borrowing_time.Location = new System.Drawing.Point(98, 157);
            this.Txt_Borrowing_time.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Borrowing_time.Name = "Txt_Borrowing_time";
            this.Txt_Borrowing_time.Size = new System.Drawing.Size(124, 21);
            this.Txt_Borrowing_time.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "Borrowing time";
            // 
            // Lbl_Admin_return_ID
            // 
            this.Lbl_Admin_return_ID.AutoSize = true;
            this.Lbl_Admin_return_ID.Location = new System.Drawing.Point(112, 139);
            this.Lbl_Admin_return_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Admin_return_ID.Name = "Lbl_Admin_return_ID";
            this.Lbl_Admin_return_ID.Size = new System.Drawing.Size(47, 12);
            this.Lbl_Admin_return_ID.TabIndex = 50;
            this.Lbl_Admin_return_ID.Text = "Show ID";
            // 
            // Lbl_Admin_Borrow_ID
            // 
            this.Lbl_Admin_Borrow_ID.AutoSize = true;
            this.Lbl_Admin_Borrow_ID.Location = new System.Drawing.Point(112, 115);
            this.Lbl_Admin_Borrow_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Admin_Borrow_ID.Name = "Lbl_Admin_Borrow_ID";
            this.Lbl_Admin_Borrow_ID.Size = new System.Drawing.Size(47, 12);
            this.Lbl_Admin_Borrow_ID.TabIndex = 49;
            this.Lbl_Admin_Borrow_ID.Text = "Show ID";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(4, 139);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(95, 12);
            this.test.TabIndex = 48;
            this.test.Text = "Admin return ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 47;
            this.label7.Text = "Admin borrow ID";
            // 
            // Cb_Book_ID
            // 
            this.Cb_Book_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Book_ID.FormattingEnabled = true;
            this.Cb_Book_ID.Location = new System.Drawing.Point(73, 53);
            this.Cb_Book_ID.Name = "Cb_Book_ID";
            this.Cb_Book_ID.Size = new System.Drawing.Size(121, 20);
            this.Cb_Book_ID.TabIndex = 46;
            // 
            // Lbl_Show_ID
            // 
            this.Lbl_Show_ID.AutoSize = true;
            this.Lbl_Show_ID.Location = new System.Drawing.Point(112, 28);
            this.Lbl_Show_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Show_ID.Name = "Lbl_Show_ID";
            this.Lbl_Show_ID.Size = new System.Drawing.Size(47, 12);
            this.Lbl_Show_ID.TabIndex = 45;
            this.Lbl_Show_ID.Text = "Show ID";
            // 
            // Cb_Overdue
            // 
            this.Cb_Overdue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Overdue.FormattingEnabled = true;
            this.Cb_Overdue.Location = new System.Drawing.Point(320, 133);
            this.Cb_Overdue.Name = "Cb_Overdue";
            this.Cb_Overdue.Size = new System.Drawing.Size(60, 20);
            this.Cb_Overdue.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Overdue";
            // 
            // Cb_Reader_ID
            // 
            this.Cb_Reader_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Reader_ID.FormattingEnabled = true;
            this.Cb_Reader_ID.Location = new System.Drawing.Point(73, 81);
            this.Cb_Reader_ID.Name = "Cb_Reader_ID";
            this.Cb_Reader_ID.Size = new System.Drawing.Size(121, 20);
            this.Cb_Reader_ID.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Reader ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Book ID";
            // 
            // Btn_Category_Management_Return
            // 
            this.Btn_Category_Management_Return.Location = new System.Drawing.Point(428, 233);
            this.Btn_Category_Management_Return.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Category_Management_Return.Name = "Btn_Category_Management_Return";
            this.Btn_Category_Management_Return.Size = new System.Drawing.Size(50, 22);
            this.Btn_Category_Management_Return.TabIndex = 21;
            this.Btn_Category_Management_Return.Text = "Return";
            this.Btn_Category_Management_Return.UseVisualStyleBackColor = true;
            this.Btn_Category_Management_Return.Click += new System.EventHandler(this.Btn_Category_Management_Return_Click);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(218, 0);
            this.Lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(41, 12);
            this.Lbl_Status.TabIndex = 17;
            this.Lbl_Status.Text = "label7";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(374, 233);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(50, 22);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(320, 233);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(50, 22);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Nudown_Renewals
            // 
            this.Nudown_Renewals.Location = new System.Drawing.Point(320, 80);
            this.Nudown_Renewals.Margin = new System.Windows.Forms.Padding(2);
            this.Nudown_Renewals.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nudown_Renewals.Name = "Nudown_Renewals";
            this.Nudown_Renewals.Size = new System.Drawing.Size(60, 21);
            this.Nudown_Renewals.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Renewals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Btn_Information_Management
            // 
            this.Btn_Information_Management.Location = new System.Drawing.Point(324, 122);
            this.Btn_Information_Management.Name = "Btn_Information_Management";
            this.Btn_Information_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Information_Management.TabIndex = 22;
            this.Btn_Information_Management.Text = "Information management";
            this.Btn_Information_Management.UseVisualStyleBackColor = true;
            // 
            // Btn_Category_Management
            // 
            this.Btn_Category_Management.Location = new System.Drawing.Point(324, 20);
            this.Btn_Category_Management.Name = "Btn_Category_Management";
            this.Btn_Category_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Category_Management.TabIndex = 21;
            this.Btn_Category_Management.Text = "Category management";
            this.Btn_Category_Management.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_Administrator_ID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 25);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel1.Text = "Administrator";
            // 
            // Lbl_Administrator_ID
            // 
            this.Lbl_Administrator_ID.Name = "Lbl_Administrator_ID";
            this.Lbl_Administrator_ID.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Administrator_ID.Text = "toolStripStatusLabel2";
            // 
            // Borrow_Return_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Information_Management);
            this.Controls.Add(this.Btn_Category_Management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Borrow_Return_Management";
            this.Text = "Borrow_Return_Management";
            this.Load += new System.EventHandler(this.Borrow_Return_Management_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Renewals)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_Overdue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cb_Reader_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Category_Management_Return;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown Nudown_Renewals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Information_Management;
        private System.Windows.Forms.Button Btn_Category_Management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
        private System.Windows.Forms.Label Lbl_Show_ID;
        private System.Windows.Forms.ComboBox Cb_Book_ID;
        private System.Windows.Forms.Label Lbl_Admin_return_ID;
        private System.Windows.Forms.Label Lbl_Admin_Borrow_ID;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox Txt_Due_Time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Borrowing_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Loss;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Return_Time;
        private System.Windows.Forms.Label label2;
    }
}