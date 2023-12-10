namespace lab15_library_management_system.Administrator.Library.PublishingHouse
{
    partial class Publishing_House_Information_Management
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
            this.Btn_Category_Management_Return = new System.Windows.Forms.Button();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.Btn_Information_Management = new System.Windows.Forms.Button();
            this.Btn_Category_Management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.Txt_Person = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Fax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.lbl_Note);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(11, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(485, 278);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category information list";
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(10, 18);
            this.lv_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(468, 254);
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
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Person";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Number";
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
            this.groupBox1.Controls.Add(this.Txt_Address);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_Fax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Person);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.Btn_Category_Management_Return);
            this.groupBox1.Controls.Add(this.Lbl_ID);
            this.groupBox1.Controls.Add(this.Lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.Txt_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(485, 194);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit category information  Status:";
            // 
            // Btn_Category_Management_Return
            // 
            this.Btn_Category_Management_Return.Location = new System.Drawing.Point(324, 148);
            this.Btn_Category_Management_Return.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Category_Management_Return.Name = "Btn_Category_Management_Return";
            this.Btn_Category_Management_Return.Size = new System.Drawing.Size(50, 22);
            this.Btn_Category_Management_Return.TabIndex = 21;
            this.Btn_Category_Management_Return.Text = "Return";
            this.Btn_Category_Management_Return.UseVisualStyleBackColor = true;
            this.Btn_Category_Management_Return.Click += new System.EventHandler(this.Btn_Category_Management_Return_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(132, 34);
            this.Lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(41, 12);
            this.Lbl_ID.TabIndex = 20;
            this.Lbl_ID.Text = "showID";
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
            this.btn_Cancel.Location = new System.Drawing.Point(220, 148);
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
            this.btn_Save.Location = new System.Drawing.Point(125, 148);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(50, 22);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(301, 31);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(124, 21);
            this.Txt_Name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Btn_Return
            // 
            this.Btn_Return.Location = new System.Drawing.Point(324, 229);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(158, 50);
            this.Btn_Return.TabIndex = 17;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.UseVisualStyleBackColor = true;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 25);
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
            // Txt_Person
            // 
            this.Txt_Person.Location = new System.Drawing.Point(98, 66);
            this.Txt_Person.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Person.Name = "Txt_Person";
            this.Txt_Person.Size = new System.Drawing.Size(124, 21);
            this.Txt_Person.TabIndex = 23;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(39, 66);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(41, 12);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Person";
            // 
            // Txt_Number
            // 
            this.Txt_Number.Location = new System.Drawing.Point(301, 66);
            this.Txt_Number.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(124, 21);
            this.Txt_Number.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number";
            // 
            // Txt_Fax
            // 
            this.Txt_Fax.Location = new System.Drawing.Point(98, 111);
            this.Txt_Fax.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Fax.Name = "Txt_Fax";
            this.Txt_Fax.Size = new System.Drawing.Size(124, 21);
            this.Txt_Fax.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fax";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(301, 111);
            this.Txt_Address.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(124, 21);
            this.Txt_Address.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fax";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            // 
            // Publishing_House_Information_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Information_Management);
            this.Controls.Add(this.Btn_Category_Management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Publishing_House_Information_Management";
            this.Text = "Publishing_House_Information_Management";
            this.Load += new System.EventHandler(this.Publishing_House_Information_Management_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Category_Management_Return;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Information_Management;
        private System.Windows.Forms.Button Btn_Category_Management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Fax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Person;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}