namespace PresentationLayer
{
    partial class UserManagementForStaff
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
            this.txtId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picAvatar1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId1 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtCountry1 = new System.Windows.Forms.TextBox();
            this.txtUserName1 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.dtPicBirth1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbtype1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvUserManagement1 = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSearchUser2 = new System.Windows.Forms.Button();
            this.btnUpdateUser2 = new System.Windows.Forms.Button();
            this.btnDeleteUser2 = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManagement1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.BackColor = System.Drawing.Color.PowderBlue;
            this.txtId.Location = new System.Drawing.Point(43, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(18, 16);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Location = new System.Drawing.Point(43, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Location = new System.Drawing.Point(43, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Location = new System.Drawing.Point(43, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Location = new System.Drawing.Point(43, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Location = new System.Drawing.Point(43, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone";
            // 
            // picAvatar1
            // 
            this.picAvatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAvatar1.Location = new System.Drawing.Point(445, 62);
            this.picAvatar1.Name = "picAvatar1";
            this.picAvatar1.Size = new System.Drawing.Size(275, 407);
            this.picAvatar1.TabIndex = 8;
            this.picAvatar1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1380, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "UserManagement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId1
            // 
            this.txtId1.Location = new System.Drawing.Point(111, 62);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(281, 22);
            this.txtId1.TabIndex = 10;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(111, 112);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(281, 22);
            this.txtName1.TabIndex = 11;
            // 
            // txtCountry1
            // 
            this.txtCountry1.Location = new System.Drawing.Point(111, 212);
            this.txtCountry1.Name = "txtCountry1";
            this.txtCountry1.Size = new System.Drawing.Size(281, 22);
            this.txtCountry1.TabIndex = 13;
            // 
            // txtUserName1
            // 
            this.txtUserName1.Location = new System.Drawing.Point(130, 262);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.Size = new System.Drawing.Size(281, 22);
            this.txtUserName1.TabIndex = 14;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(130, 412);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(281, 22);
            this.txtPhone1.TabIndex = 17;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(130, 362);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(281, 22);
            this.txtEmail1.TabIndex = 16;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(130, 312);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(281, 22);
            this.txtPass1.TabIndex = 15;
            // 
            // dtPicBirth1
            // 
            this.dtPicBirth1.Location = new System.Drawing.Point(125, 169);
            this.dtPicBirth1.Name = "dtPicBirth1";
            this.dtPicBirth1.Size = new System.Drawing.Size(267, 22);
            this.dtPicBirth1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PowderBlue;
            this.label9.Location = new System.Drawing.Point(41, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "TypeName";
            // 
            // cbtype1
            // 
            this.cbtype1.FormattingEnabled = true;
            this.cbtype1.Items.AddRange(new object[] {
            "User"});
            this.cbtype1.Location = new System.Drawing.Point(147, 452);
            this.cbtype1.Name = "cbtype1";
            this.cbtype1.Size = new System.Drawing.Size(245, 24);
            this.cbtype1.TabIndex = 21;
            // 
            // dgvUserManagement1
            // 
            this.dgvUserManagement1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserManagement1.Location = new System.Drawing.Point(764, 74);
            this.dgvUserManagement1.Name = "dgvUserManagement1";
            this.dgvUserManagement1.RowHeadersWidth = 51;
            this.dgvUserManagement1.RowTemplate.Height = 24;
            this.dgvUserManagement1.Size = new System.Drawing.Size(581, 395);
            this.dgvUserManagement1.TabIndex = 22;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddUser.Location = new System.Drawing.Point(57, 582);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(144, 53);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.Text = "AddUser";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSearchUser2
            // 
            this.btnSearchUser2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearchUser2.Location = new System.Drawing.Point(305, 582);
            this.btnSearchUser2.Name = "btnSearchUser2";
            this.btnSearchUser2.Size = new System.Drawing.Size(144, 53);
            this.btnSearchUser2.TabIndex = 24;
            this.btnSearchUser2.Text = "SearchUser";
            this.btnSearchUser2.UseVisualStyleBackColor = false;
            this.btnSearchUser2.Click += new System.EventHandler(this.btnSearchUser2_Click);
            // 
            // btnUpdateUser2
            // 
            this.btnUpdateUser2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateUser2.Location = new System.Drawing.Point(524, 582);
            this.btnUpdateUser2.Name = "btnUpdateUser2";
            this.btnUpdateUser2.Size = new System.Drawing.Size(144, 53);
            this.btnUpdateUser2.TabIndex = 25;
            this.btnUpdateUser2.Text = "UpdateUser";
            this.btnUpdateUser2.UseVisualStyleBackColor = false;
            this.btnUpdateUser2.Click += new System.EventHandler(this.btnUpdateUser2_Click);
            // 
            // btnDeleteUser2
            // 
            this.btnDeleteUser2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteUser2.Location = new System.Drawing.Point(785, 582);
            this.btnDeleteUser2.Name = "btnDeleteUser2";
            this.btnDeleteUser2.Size = new System.Drawing.Size(144, 53);
            this.btnDeleteUser2.TabIndex = 26;
            this.btnDeleteUser2.Text = "deleteUser";
            this.btnDeleteUser2.UseVisualStyleBackColor = false;
            this.btnDeleteUser2.Click += new System.EventHandler(this.btnDeleteUser2_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(483, 495);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(164, 64);
            this.btnOpenImage.TabIndex = 27;
            this.btnOpenImage.Text = "OpenImage";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // UserManagementForStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.London;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 663);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnDeleteUser2);
            this.Controls.Add(this.btnUpdateUser2);
            this.Controls.Add(this.btnSearchUser2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvUserManagement1);
            this.Controls.Add(this.cbtype1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtPicBirth1);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtUserName1);
            this.Controls.Add(this.txtCountry1);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.txtId1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAvatar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Name = "UserManagementForStaff";
            this.Text = "UserManagementForStaff";
            this.Load += new System.EventHandler(this.UserManagementForStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManagement1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picAvatar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtCountry1;
        private System.Windows.Forms.TextBox txtUserName1;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.DateTimePicker dtPicBirth1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbtype1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvUserManagement1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchUser2;
        private System.Windows.Forms.Button btnUpdateUser2;
        private System.Windows.Forms.Button btnDeleteUser2;
        private System.Windows.Forms.Button btnOpenImage;
    }
}