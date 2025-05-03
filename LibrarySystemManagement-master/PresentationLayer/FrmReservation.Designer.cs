namespace PresentationLayer
{
    partial class FrmReservation
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentIdReservation = new System.Windows.Forms.TextBox();
            this.dgvDocumentForReservation = new System.Windows.Forms.DataGridView();
            this.btnReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentForReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ReservationDocument";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DocumentId";
            // 
            // txtDocumentIdReservation
            // 
            this.txtDocumentIdReservation.Location = new System.Drawing.Point(199, 64);
            this.txtDocumentIdReservation.Name = "txtDocumentIdReservation";
            this.txtDocumentIdReservation.Size = new System.Drawing.Size(307, 22);
            this.txtDocumentIdReservation.TabIndex = 3;
            // 
            // dgvDocumentForReservation
            // 
            this.dgvDocumentForReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentForReservation.Location = new System.Drawing.Point(49, 124);
            this.dgvDocumentForReservation.Name = "dgvDocumentForReservation";
            this.dgvDocumentForReservation.RowHeadersWidth = 51;
            this.dgvDocumentForReservation.RowTemplate.Height = 24;
            this.dgvDocumentForReservation.Size = new System.Drawing.Size(667, 265);
            this.dgvDocumentForReservation.TabIndex = 4;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(240, 416);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(287, 23);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dgvDocumentForReservation);
            this.Controls.Add(this.txtDocumentIdReservation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmReservation";
            this.Text = "FrmReservation";
            this.Load += new System.EventHandler(this.FrmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentForReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentIdReservation;
        private System.Windows.Forms.DataGridView dgvDocumentForReservation;
        private System.Windows.Forms.Button btnReserve;
    }
}