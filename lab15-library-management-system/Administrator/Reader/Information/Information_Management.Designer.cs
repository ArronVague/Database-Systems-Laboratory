namespace lab15_library_management_system.Administrator.Reader.Information
{
    partial class Information_Management
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
            this.lbl_Note = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Remark = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Valid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Registration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Gender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_Category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Category_Management_Return = new System.Windows.Forms.Button();
            this.Nudown_Cumulative = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Nudown_Currently = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Information_Management = new System.Windows.Forms.Button();
            this.Btn_Category_Management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nudown_Violations = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cb_Loss = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Cumulative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Currently)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Violations)).BeginInit();
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
            this.groupBox2.TabIndex = 19;
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
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
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
            this.columnHeader2.Text = "Password";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
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
            this.groupBox1.Controls.Add(this.Nudown_Violations);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.Txt_Remark);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Txt_Valid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_Registration);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_Number);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_Gender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Cb_Category);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Category_Management_Return);
            this.groupBox1.Controls.Add(this.Nudown_Cumulative);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.Nudown_Currently);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(485, 269);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit reader information  Status:";
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(70, 22);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(124, 21);
            this.Txt_ID.TabIndex = 40;
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.Location = new System.Drawing.Point(70, 191);
            this.Txt_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Remark.Multiline = true;
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Size = new System.Drawing.Size(246, 64);
            this.Txt_Remark.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "Remark";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "Loss";
            // 
            // Txt_Valid
            // 
            this.Txt_Valid.Location = new System.Drawing.Point(313, 50);
            this.Txt_Valid.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Valid.Name = "Txt_Valid";
            this.Txt_Valid.Size = new System.Drawing.Size(124, 21);
            this.Txt_Valid.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "Valid";
            // 
            // Txt_Registration
            // 
            this.Txt_Registration.Location = new System.Drawing.Point(313, 25);
            this.Txt_Registration.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Registration.Name = "Txt_Registration";
            this.Txt_Registration.Size = new System.Drawing.Size(124, 21);
            this.Txt_Registration.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Registration";
            // 
            // Txt_Number
            // 
            this.Txt_Number.Location = new System.Drawing.Point(70, 161);
            this.Txt_Number.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(124, 21);
            this.Txt_Number.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "Number";
            // 
            // Txt_Gender
            // 
            this.Txt_Gender.Location = new System.Drawing.Point(70, 136);
            this.Txt_Gender.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Gender.Name = "Txt_Gender";
            this.Txt_Gender.Size = new System.Drawing.Size(124, 21);
            this.Txt_Gender.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "Gender";
            // 
            // Cb_Category
            // 
            this.Cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Category.FormattingEnabled = true;
            this.Cb_Category.Location = new System.Drawing.Point(73, 81);
            this.Cb_Category.Name = "Cb_Category";
            this.Cb_Category.Size = new System.Drawing.Size(121, 20);
            this.Cb_Category.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Category";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(70, 50);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(124, 21);
            this.Txt_Password.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
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
            // Nudown_Cumulative
            // 
            this.Nudown_Cumulative.Location = new System.Drawing.Point(320, 106);
            this.Nudown_Cumulative.Margin = new System.Windows.Forms.Padding(2);
            this.Nudown_Cumulative.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nudown_Cumulative.Name = "Nudown_Cumulative";
            this.Nudown_Cumulative.Size = new System.Drawing.Size(60, 21);
            this.Nudown_Cumulative.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cumulative";
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
            // Nudown_Currently
            // 
            this.Nudown_Currently.Location = new System.Drawing.Point(320, 80);
            this.Nudown_Currently.Margin = new System.Windows.Forms.Padding(2);
            this.Nudown_Currently.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nudown_Currently.Name = "Nudown_Currently";
            this.Nudown_Currently.Size = new System.Drawing.Size(60, 21);
            this.Nudown_Currently.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Currently";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(70, 110);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(124, 21);
            this.Txt_Name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
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
            this.Btn_Information_Management.TabIndex = 16;
            this.Btn_Information_Management.Text = "Information management";
            this.Btn_Information_Management.UseVisualStyleBackColor = true;
            // 
            // Btn_Category_Management
            // 
            this.Btn_Category_Management.Location = new System.Drawing.Point(324, 20);
            this.Btn_Category_Management.Name = "Btn_Category_Management";
            this.Btn_Category_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Category_Management.TabIndex = 15;
            this.Btn_Category_Management.Text = "Category management";
            this.Btn_Category_Management.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_Administrator_ID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 25);
            this.statusStrip1.TabIndex = 14;
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
            // Nudown_Violations
            // 
            this.Nudown_Violations.Location = new System.Drawing.Point(320, 158);
            this.Nudown_Violations.Margin = new System.Windows.Forms.Padding(2);
            this.Nudown_Violations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nudown_Violations.Name = "Nudown_Violations";
            this.Nudown_Violations.Size = new System.Drawing.Size(60, 21);
            this.Nudown_Violations.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "Violations";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gender";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Number";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Registration";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Valid";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Currently";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cumulative";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Loss";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Violations";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Remark";
            // 
            // Cb_Loss
            // 
            this.Cb_Loss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Loss.FormattingEnabled = true;
            this.Cb_Loss.Location = new System.Drawing.Point(320, 133);
            this.Cb_Loss.Name = "Cb_Loss";
            this.Cb_Loss.Size = new System.Drawing.Size(60, 20);
            this.Cb_Loss.TabIndex = 43;
            // 
            // Information_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Information_Management);
            this.Controls.Add(this.Btn_Category_Management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Information_Management";
            this.Text = "Information_Management";
            this.Load += new System.EventHandler(this.Information_Management_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Cumulative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Currently)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudown_Violations)).EndInit();
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
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Category_Management_Return;
        private System.Windows.Forms.NumericUpDown Nudown_Cumulative;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown Nudown_Currently;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Information_Management;
        private System.Windows.Forms.Button Btn_Category_Management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
        private System.Windows.Forms.ComboBox Cb_Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Valid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Registration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.TextBox Txt_Remark;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.NumericUpDown Nudown_Violations;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Cb_Loss;
    }
}