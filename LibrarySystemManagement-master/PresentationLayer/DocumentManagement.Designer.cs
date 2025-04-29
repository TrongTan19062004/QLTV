namespace PresentationLayer
{
    partial class DocumentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnUpdateDocument = new System.Windows.Forms.Button();
            this.btnSearchDocument = new System.Windows.Forms.Button();
            this.btnDeleteDocument = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAuthor_name = new System.Windows.Forms.TextBox();
            this.txtType_Name = new System.Windows.Forms.TextBox();
            this.txtGenre_name = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPubYear = new System.Windows.Forms.TextBox();
            this.txtDocument_Id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, -95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ReaderMmanagement";
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddDocument.Location = new System.Drawing.Point(18, 25);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(145, 57);
            this.btnAddDocument.TabIndex = 7;
            this.btnAddDocument.Text = "Add ";
            this.btnAddDocument.UseVisualStyleBackColor = false;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnUpdateDocument
            // 
            this.btnUpdateDocument.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateDocument.Location = new System.Drawing.Point(187, 28);
            this.btnUpdateDocument.Name = "btnUpdateDocument";
            this.btnUpdateDocument.Size = new System.Drawing.Size(145, 54);
            this.btnUpdateDocument.TabIndex = 8;
            this.btnUpdateDocument.Text = "Update ";
            this.btnUpdateDocument.UseVisualStyleBackColor = false;
            this.btnUpdateDocument.Click += new System.EventHandler(this.btnUpdateDocument_Click);
            // 
            // btnSearchDocument
            // 
            this.btnSearchDocument.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearchDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchDocument.Location = new System.Drawing.Point(348, 25);
            this.btnSearchDocument.Name = "btnSearchDocument";
            this.btnSearchDocument.Size = new System.Drawing.Size(145, 56);
            this.btnSearchDocument.TabIndex = 9;
            this.btnSearchDocument.Text = "Search";
            this.btnSearchDocument.UseVisualStyleBackColor = false;
            this.btnSearchDocument.Click += new System.EventHandler(this.btnSearchDocument_Click);
            // 
            // btnDeleteDocument
            // 
            this.btnDeleteDocument.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteDocument.Location = new System.Drawing.Point(504, 26);
            this.btnDeleteDocument.Name = "btnDeleteDocument";
            this.btnDeleteDocument.Size = new System.Drawing.Size(145, 54);
            this.btnDeleteDocument.TabIndex = 10;
            this.btnDeleteDocument.Text = "Delete ";
            this.btnDeleteDocument.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1794, 56);
            this.label2.TabIndex = 11;
            this.label2.Text = "DocumentManagement";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Location = new System.Drawing.Point(929, 181);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.RowTemplate.Height = 24;
            this.dgvDocuments.Size = new System.Drawing.Size(853, 649);
            this.dgvDocuments.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(628, 865);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(391, 61);
            this.button6.TabIndex = 14;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDocument);
            this.groupBox1.Controls.Add(this.btnUpdateDocument);
            this.groupBox1.Controls.Add(this.btnSearchDocument);
            this.groupBox1.Controls.Add(this.btnDeleteDocument);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processing";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtAuthor_name);
            this.groupBox2.Controls.Add(this.txtType_Name);
            this.groupBox2.Controls.Add(this.txtGenre_name);
            this.groupBox2.Controls.Add(this.txtPage);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtLanguage);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtPubYear);
            this.groupBox2.Controls.Add(this.txtDocument_Id);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(17, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 633);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Document_Information";
            // 
            // txtAuthor_name
            // 
            this.txtAuthor_name.Location = new System.Drawing.Point(234, 333);
            this.txtAuthor_name.Name = "txtAuthor_name";
            this.txtAuthor_name.Size = new System.Drawing.Size(308, 30);
            this.txtAuthor_name.TabIndex = 19;
            // 
            // txtType_Name
            // 
            this.txtType_Name.Location = new System.Drawing.Point(234, 482);
            this.txtType_Name.Name = "txtType_Name";
            this.txtType_Name.Size = new System.Drawing.Size(308, 30);
            this.txtType_Name.TabIndex = 18;
            this.txtType_Name.TextChanged += new System.EventHandler(this.txtType_Name_TextChanged);
            // 
            // txtGenre_name
            // 
            this.txtGenre_name.Location = new System.Drawing.Point(234, 423);
            this.txtGenre_name.Name = "txtGenre_name";
            this.txtGenre_name.Size = new System.Drawing.Size(308, 30);
            this.txtGenre_name.TabIndex = 17;
            this.txtGenre_name.TextChanged += new System.EventHandler(this.txtGenre_name_TextChanged);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(234, 377);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(308, 30);
            this.txtPage.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(234, 293);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(308, 30);
            this.txtPrice.TabIndex = 15;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(234, 246);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(308, 30);
            this.txtQuantity.TabIndex = 14;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(234, 200);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(308, 30);
            this.txtLanguage.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(234, 160);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(308, 30);
            this.txtTitle.TabIndex = 12;
            // 
            // txtPubYear
            // 
            this.txtPubYear.Location = new System.Drawing.Point(234, 109);
            this.txtPubYear.Name = "txtPubYear";
            this.txtPubYear.Size = new System.Drawing.Size(308, 30);
            this.txtPubYear.TabIndex = 11;
            // 
            // txtDocument_Id
            // 
            this.txtDocument_Id.Location = new System.Drawing.Point(234, 46);
            this.txtDocument_Id.Name = "txtDocument_Id";
            this.txtDocument_Id.Size = new System.Drawing.Size(308, 30);
            this.txtDocument_Id.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Type_Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Genre_name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "document_page";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Author_name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publication_Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Document_Id";
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(608, 186);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(293, 644);
            this.picHinh.TabIndex = 17;
            this.picHinh.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1791, 955);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DocumentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 969);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "DocumentManagement";
            this.Text = "DocumentManagement";
            this.Load += new System.EventHandler(this.DocumentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Button btnUpdateDocument;
        private System.Windows.Forms.Button btnSearchDocument;
        private System.Windows.Forms.Button btnDeleteDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor_name;
        private System.Windows.Forms.TextBox txtType_Name;
        private System.Windows.Forms.TextBox txtGenre_name;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPubYear;
        private System.Windows.Forms.TextBox txtDocument_Id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picHinh;
    }
}