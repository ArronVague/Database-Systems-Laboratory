namespace lab15_library_management_system.Administrator
{
    partial class Administrator_Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Administrator_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_Reader_Management = new System.Windows.Forms.Button();
            this.Btn_Library_Management = new System.Windows.Forms.Button();
            this.Btn_Business_Management = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_Administrator_ID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 0;
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
            // Btn_Reader_Management
            // 
            this.Btn_Reader_Management.Location = new System.Drawing.Point(324, 77);
            this.Btn_Reader_Management.Name = "Btn_Reader_Management";
            this.Btn_Reader_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Reader_Management.TabIndex = 1;
            this.Btn_Reader_Management.Text = "Reader management";
            this.Btn_Reader_Management.UseVisualStyleBackColor = true;
            this.Btn_Reader_Management.Click += new System.EventHandler(this.Btn_Reader_Management_Click);
            // 
            // Btn_Library_Management
            // 
            this.Btn_Library_Management.Location = new System.Drawing.Point(324, 179);
            this.Btn_Library_Management.Name = "Btn_Library_Management";
            this.Btn_Library_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Library_Management.TabIndex = 2;
            this.Btn_Library_Management.Text = "Library management";
            this.Btn_Library_Management.UseVisualStyleBackColor = true;
            this.Btn_Library_Management.Click += new System.EventHandler(this.Btn_Library_Management_Click);
            // 
            // Btn_Business_Management
            // 
            this.Btn_Business_Management.Location = new System.Drawing.Point(324, 286);
            this.Btn_Business_Management.Name = "Btn_Business_Management";
            this.Btn_Business_Management.Size = new System.Drawing.Size(158, 50);
            this.Btn_Business_Management.TabIndex = 3;
            this.Btn_Business_Management.Text = "Business management";
            this.Btn_Business_Management.UseVisualStyleBackColor = true;
            // 
            // Administrator_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Business_Management);
            this.Controls.Add(this.Btn_Library_Management);
            this.Controls.Add(this.Btn_Reader_Management);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Administrator_Main";
            this.Text = "Administrator_Main";
            this.Load += new System.EventHandler(this.Administrator_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Administrator_ID;
        private System.Windows.Forms.Button Btn_Reader_Management;
        private System.Windows.Forms.Button Btn_Library_Management;
        private System.Windows.Forms.Button Btn_Business_Management;
    }
}