namespace lab15_library_management_system.Administrator.Library
{
    partial class Library_Management
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
            this.Btn_Return = new System.Windows.Forms.Button();
            this.Btn_Basic_information_management_of_books = new System.Windows.Forms.Button();
            this.Btn_Publishing_house_information_management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_Collection_book_information_management = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Return
            // 
            this.Btn_Return.Location = new System.Drawing.Point(326, 321);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(158, 50);
            this.Btn_Return.TabIndex = 11;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.UseVisualStyleBackColor = true;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // Btn_Basic_information_management_of_books
            // 
            this.Btn_Basic_information_management_of_books.Location = new System.Drawing.Point(260, 120);
            this.Btn_Basic_information_management_of_books.Name = "Btn_Basic_information_management_of_books";
            this.Btn_Basic_information_management_of_books.Size = new System.Drawing.Size(295, 54);
            this.Btn_Basic_information_management_of_books.TabIndex = 10;
            this.Btn_Basic_information_management_of_books.Text = "Basic information management of books";
            this.Btn_Basic_information_management_of_books.UseVisualStyleBackColor = true;
            this.Btn_Basic_information_management_of_books.Click += new System.EventHandler(this.Btn_Basic_information_management_of_books_Click);
            // 
            // Btn_Publishing_house_information_management
            // 
            this.Btn_Publishing_house_information_management.Location = new System.Drawing.Point(260, 36);
            this.Btn_Publishing_house_information_management.Name = "Btn_Publishing_house_information_management";
            this.Btn_Publishing_house_information_management.Size = new System.Drawing.Size(295, 54);
            this.Btn_Publishing_house_information_management.TabIndex = 9;
            this.Btn_Publishing_house_information_management.Text = "Publishing house information management";
            this.Btn_Publishing_house_information_management.UseVisualStyleBackColor = true;
            this.Btn_Publishing_house_information_management.Click += new System.EventHandler(this.Btn_Publishing_house_information_management_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_Administrator_ID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 8;
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
            // Btn_Collection_book_information_management
            // 
            this.Btn_Collection_book_information_management.Location = new System.Drawing.Point(260, 214);
            this.Btn_Collection_book_information_management.Name = "Btn_Collection_book_information_management";
            this.Btn_Collection_book_information_management.Size = new System.Drawing.Size(295, 54);
            this.Btn_Collection_book_information_management.TabIndex = 12;
            this.Btn_Collection_book_information_management.Text = "Collection book information management";
            this.Btn_Collection_book_information_management.UseVisualStyleBackColor = true;
            this.Btn_Collection_book_information_management.Click += new System.EventHandler(this.Btn_Collection_book_information_management_Click);
            // 
            // Library_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Collection_book_information_management);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Basic_information_management_of_books);
            this.Controls.Add(this.Btn_Publishing_house_information_management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Library_Management";
            this.Text = "Library_Management";
            this.Load += new System.EventHandler(this.Library_Management_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Basic_information_management_of_books;
        private System.Windows.Forms.Button Btn_Publishing_house_information_management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
        private System.Windows.Forms.Button Btn_Collection_book_information_management;
    }
}