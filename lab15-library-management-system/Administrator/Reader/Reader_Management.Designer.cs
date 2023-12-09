namespace lab15_library_management_system.Administrator.Reader
{
    partial class Reader_Management
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
            this.Btn_Information_Management = new System.Windows.Forms.Button();
            this.Btn_Category_Management = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Return
            // 
            this.Btn_Return.Location = new System.Drawing.Point(324, 248);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(158, 50);
            this.Btn_Return.TabIndex = 7;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.UseVisualStyleBackColor = true;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // Btn_Information_Management
            // 
            this.Btn_Information_Management.Location = new System.Drawing.Point(324, 141);
            this.Btn_Information_Management.Name = "Btn_Information_Management";
            this.Btn_Information_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Information_Management.TabIndex = 6;
            this.Btn_Information_Management.Text = "Information management";
            this.Btn_Information_Management.UseVisualStyleBackColor = true;
            // 
            // Btn_Category_Management
            // 
            this.Btn_Category_Management.Location = new System.Drawing.Point(324, 39);
            this.Btn_Category_Management.Name = "Btn_Category_Management";
            this.Btn_Category_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Category_Management.TabIndex = 5;
            this.Btn_Category_Management.Text = "Category management";
            this.Btn_Category_Management.UseVisualStyleBackColor = true;
            this.Btn_Category_Management.Click += new System.EventHandler(this.Btn_Category_Management_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_Administrator_ID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 4;
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
            // Reader_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Information_Management);
            this.Controls.Add(this.Btn_Category_Management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Reader_Management";
            this.Text = "Reader_Management";
            this.Load += new System.EventHandler(this.Reader_Management_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Information_Management;
        private System.Windows.Forms.Button Btn_Category_Management;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
    }
}