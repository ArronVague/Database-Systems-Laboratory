namespace lab15_library_management_system.Administrator.Library.Collection
{
    partial class Collection_Management
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
            this.Txt_Storage_Time = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Category_Management_Return = new System.Windows.Forms.Button();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Btn_Information_Management = new System.Windows.Forms.Button();
            this.Btn_Category_Management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.Cb_ISBN = new System.Windows.Forms.ComboBox();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox2.Location = new System.Drawing.Point(10, 177);
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
            this.columnHeader4});
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
            this.columnHeader2.Text = "ISBN";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Storage time";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
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
            this.groupBox1.Controls.Add(this.Cb_Status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lbl_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_ISBN);
            this.groupBox1.Controls.Add(this.Txt_Storage_Time);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Category_Management_Return);
            this.groupBox1.Controls.Add(this.Lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(485, 161);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit reader information  Status:";
            // 
            // Txt_Storage_Time
            // 
            this.Txt_Storage_Time.Location = new System.Drawing.Point(323, 34);
            this.Txt_Storage_Time.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Storage_Time.Name = "Txt_Storage_Time";
            this.Txt_Storage_Time.Size = new System.Drawing.Size(124, 21);
            this.Txt_Storage_Time.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Storage_time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "ISBN";
            // 
            // Btn_Category_Management_Return
            // 
            this.Btn_Category_Management_Return.Location = new System.Drawing.Point(266, 125);
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
            this.btn_Cancel.Location = new System.Drawing.Point(212, 125);
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
            this.btn_Save.Location = new System.Drawing.Point(158, 125);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(50, 22);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 25);
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
            // Cb_ISBN
            // 
            this.Cb_ISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_ISBN.FormattingEnabled = true;
            this.Cb_ISBN.Location = new System.Drawing.Point(87, 87);
            this.Cb_ISBN.Name = "Cb_ISBN";
            this.Cb_ISBN.Size = new System.Drawing.Size(121, 20);
            this.Cb_ISBN.TabIndex = 45;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(131, 34);
            this.Lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(41, 12);
            this.Lbl_ID.TabIndex = 47;
            this.Lbl_ID.Text = "showID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID";
            // 
            // Cb_Status
            // 
            this.Cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Status.FormattingEnabled = true;
            this.Cb_Status.Location = new System.Drawing.Point(323, 87);
            this.Cb_Status.Name = "Cb_Status";
            this.Cb_Status.Size = new System.Drawing.Size(121, 20);
            this.Cb_Status.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status";
            // 
            // Collection_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Information_Management);
            this.Controls.Add(this.Btn_Category_Management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Collection_Management";
            this.Text = "Collection_Management";
            this.Load += new System.EventHandler(this.Collection_Management_Load);
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
        private System.Windows.Forms.TextBox Txt_Storage_Time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Category_Management_Return;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button Btn_Information_Management;
        private System.Windows.Forms.Button Btn_Category_Management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
        private System.Windows.Forms.ComboBox Cb_ISBN;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Status;
        private System.Windows.Forms.Label label2;
    }
}