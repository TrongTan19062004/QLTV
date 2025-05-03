namespace PresentationLayer
{
    partial class FrmRegulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdRegulation = new System.Windows.Forms.MaskedTextBox();
            this.txtDescriptionRegulation = new System.Windows.Forms.MaskedTextBox();
            this.txtMaxBooksDayRegulation = new System.Windows.Forms.MaskedTextBox();
            this.txtFinePerDayRegulation = new System.Windows.Forms.MaskedTextBox();
            this.txtMaxBooksAllowed = new System.Windows.Forms.MaskedTextBox();
            this.dgvRegulation = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1222, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "RegulationManagement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(34, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "MaxBooksDay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(34, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "FinePerDay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(34, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "MaxBooksAllowed";
            // 
            // txtIdRegulation
            // 
            this.txtIdRegulation.Location = new System.Drawing.Point(317, 81);
            this.txtIdRegulation.Name = "txtIdRegulation";
            this.txtIdRegulation.Size = new System.Drawing.Size(281, 22);
            this.txtIdRegulation.TabIndex = 6;
            // 
            // txtDescriptionRegulation
            // 
            this.txtDescriptionRegulation.Location = new System.Drawing.Point(317, 157);
            this.txtDescriptionRegulation.Name = "txtDescriptionRegulation";
            this.txtDescriptionRegulation.Size = new System.Drawing.Size(281, 22);
            this.txtDescriptionRegulation.TabIndex = 7;
            // 
            // txtMaxBooksDayRegulation
            // 
            this.txtMaxBooksDayRegulation.Location = new System.Drawing.Point(317, 226);
            this.txtMaxBooksDayRegulation.Name = "txtMaxBooksDayRegulation";
            this.txtMaxBooksDayRegulation.Size = new System.Drawing.Size(281, 22);
            this.txtMaxBooksDayRegulation.TabIndex = 8;
            // 
            // txtFinePerDayRegulation
            // 
            this.txtFinePerDayRegulation.Location = new System.Drawing.Point(317, 309);
            this.txtFinePerDayRegulation.Name = "txtFinePerDayRegulation";
            this.txtFinePerDayRegulation.Size = new System.Drawing.Size(281, 22);
            this.txtFinePerDayRegulation.TabIndex = 9;
            // 
            // txtMaxBooksAllowed
            // 
            this.txtMaxBooksAllowed.Location = new System.Drawing.Point(317, 385);
            this.txtMaxBooksAllowed.Name = "txtMaxBooksAllowed";
            this.txtMaxBooksAllowed.Size = new System.Drawing.Size(281, 22);
            this.txtMaxBooksAllowed.TabIndex = 10;
            // 
            // dgvRegulation
            // 
            this.dgvRegulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegulation.Location = new System.Drawing.Point(652, 86);
            this.dgvRegulation.Name = "dgvRegulation";
            this.dgvRegulation.RowHeadersWidth = 51;
            this.dgvRegulation.RowTemplate.Height = 24;
            this.dgvRegulation.Size = new System.Drawing.Size(466, 321);
            this.dgvRegulation.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(525, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 50);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmRegulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 502);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvRegulation);
            this.Controls.Add(this.txtMaxBooksAllowed);
            this.Controls.Add(this.txtFinePerDayRegulation);
            this.Controls.Add(this.txtMaxBooksDayRegulation);
            this.Controls.Add(this.txtDescriptionRegulation);
            this.Controls.Add(this.txtIdRegulation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegulation";
            this.Text = "FrmRegulation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtIdRegulation;
        private System.Windows.Forms.MaskedTextBox txtDescriptionRegulation;
        private System.Windows.Forms.MaskedTextBox txtMaxBooksDayRegulation;
        private System.Windows.Forms.MaskedTextBox txtFinePerDayRegulation;
        private System.Windows.Forms.MaskedTextBox txtMaxBooksAllowed;
        private System.Windows.Forms.DataGridView dgvRegulation;
        private System.Windows.Forms.Button btnUpdate;
    }
}