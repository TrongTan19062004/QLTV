namespace PresentationLayer
{
    partial class HomeStaff
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanDocumentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDocumentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loanFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupBorrowingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reserveDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentToolStripMenuItem,
            this.loanDocumentManagementToolStripMenuItem,
            this.returnDocumentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentManagementToolStripMenuItem,
            this.searchDocumentToolStripMenuItem,
            this.reserveDocumentToolStripMenuItem});
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // documentManagementToolStripMenuItem
            // 
            this.documentManagementToolStripMenuItem.Name = "documentManagementToolStripMenuItem";
            this.documentManagementToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.documentManagementToolStripMenuItem.Text = "DocumentManagement";
            this.documentManagementToolStripMenuItem.Click += new System.EventHandler(this.documentManagementToolStripMenuItem_Click);
            // 
            // searchDocumentToolStripMenuItem
            // 
            this.searchDocumentToolStripMenuItem.Name = "searchDocumentToolStripMenuItem";
            this.searchDocumentToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.searchDocumentToolStripMenuItem.Text = "SearchDocument";
            // 
            // loanDocumentManagementToolStripMenuItem
            // 
            this.loanDocumentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loanFormToolStripMenuItem,
            this.lookupBorrowingHistoryToolStripMenuItem});
            this.loanDocumentManagementToolStripMenuItem.Name = "loanDocumentManagementToolStripMenuItem";
            this.loanDocumentManagementToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.loanDocumentManagementToolStripMenuItem.Text = "Loan_DocumentManagement";
            // 
            // returnDocumentManagementToolStripMenuItem
            // 
            this.returnDocumentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnFormToolStripMenuItem});
            this.returnDocumentManagementToolStripMenuItem.Name = "returnDocumentManagementToolStripMenuItem";
            this.returnDocumentManagementToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.returnDocumentManagementToolStripMenuItem.Text = "Return_DocumentManagement";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataUserToolStripMenuItem,
            this.searchUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.userManagementToolStripMenuItem.Text = "User_Management";
            // 
            // dataUserToolStripMenuItem
            // 
            this.dataUserToolStripMenuItem.Name = "dataUserToolStripMenuItem";
            this.dataUserToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dataUserToolStripMenuItem.Text = "DataUser";
            // 
            // searchUserToolStripMenuItem
            // 
            this.searchUserToolStripMenuItem.Name = "searchUserToolStripMenuItem";
            this.searchUserToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.searchUserToolStripMenuItem.Text = "SearchUser";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffProfileToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.exitToolStripMenuItem.Text = "Staff";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // staffProfileToolStripMenuItem
            // 
            this.staffProfileToolStripMenuItem.Name = "staffProfileToolStripMenuItem";
            this.staffProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.staffProfileToolStripMenuItem.Text = "StaffProfile";
            this.staffProfileToolStripMenuItem.Click += new System.EventHandler(this.staffProfileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2});
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // loanFormToolStripMenuItem
            // 
            this.loanFormToolStripMenuItem.Name = "loanFormToolStripMenuItem";
            this.loanFormToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.loanFormToolStripMenuItem.Text = "Loan_Form";
            // 
            // lookupBorrowingHistoryToolStripMenuItem
            // 
            this.lookupBorrowingHistoryToolStripMenuItem.Name = "lookupBorrowingHistoryToolStripMenuItem";
            this.lookupBorrowingHistoryToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.lookupBorrowingHistoryToolStripMenuItem.Text = "LookupBorrowingHistory";
            // 
            // returnFormToolStripMenuItem
            // 
            this.returnFormToolStripMenuItem.Name = "returnFormToolStripMenuItem";
            this.returnFormToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.returnFormToolStripMenuItem.Text = "ReturnForm";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.SystemColors.Info;
            this.lbWelcome.Location = new System.Drawing.Point(77, 41);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(0, 16);
            this.lbWelcome.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.London;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1091, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reserveDocumentToolStripMenuItem
            // 
            this.reserveDocumentToolStripMenuItem.Name = "reserveDocumentToolStripMenuItem";
            this.reserveDocumentToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.reserveDocumentToolStripMenuItem.Text = "ReserveDocument";
            // 
            // HomeStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeStaff";
            this.Text = "HomeStaff";
            this.Load += new System.EventHandler(this.HomeStaff_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanDocumentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnDocumentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loanFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupBorrowingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnFormToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.ToolStripMenuItem reserveDocumentToolStripMenuItem;
    }
}