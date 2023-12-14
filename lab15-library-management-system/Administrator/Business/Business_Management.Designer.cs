namespace lab15_library_management_system.Administrator.Business
{
    partial class Business_Management
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
            this.Btn_Fine_management = new System.Windows.Forms.Button();
            this.Btn_Books_borrowing_returning_management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Return
            // 
            this.Btn_Return.Location = new System.Drawing.Point(326, 303);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(158, 50);
            this.Btn_Return.TabIndex = 16;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.UseVisualStyleBackColor = true;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // Btn_Fine_management
            // 
            this.Btn_Fine_management.Location = new System.Drawing.Point(260, 178);
            this.Btn_Fine_management.Name = "Btn_Fine_management";
            this.Btn_Fine_management.Size = new System.Drawing.Size(295, 54);
            this.Btn_Fine_management.TabIndex = 15;
            this.Btn_Fine_management.Text = "Fine management";
            this.Btn_Fine_management.UseVisualStyleBackColor = true;
            this.Btn_Fine_management.Click += new System.EventHandler(this.Btn_Fine_management_Click);
            // 
            // Btn_Books_borrowing_returning_management
            // 
            this.Btn_Books_borrowing_returning_management.Location = new System.Drawing.Point(260, 57);
            this.Btn_Books_borrowing_returning_management.Name = "Btn_Books_borrowing_returning_management";
            this.Btn_Books_borrowing_returning_management.Size = new System.Drawing.Size(295, 54);
            this.Btn_Books_borrowing_returning_management.TabIndex = 14;
            this.Btn_Books_borrowing_returning_management.Text = "Books borrowing/returning management";
            this.Btn_Books_borrowing_returning_management.UseVisualStyleBackColor = true;
            this.Btn_Books_borrowing_returning_management.Click += new System.EventHandler(this.Btn_Books_borrowing_returning_management_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_Administrator_ID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 13;
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
            // Business_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Fine_management);
            this.Controls.Add(this.Btn_Books_borrowing_returning_management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Business_Management";
            this.Text = "Business_Management";
            this.Load += new System.EventHandler(this.Business_Management_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Fine_management;
        private System.Windows.Forms.Button Btn_Books_borrowing_returning_management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
    }
}