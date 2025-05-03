namespace PresentationLayer
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtMonthStatistics = new System.Windows.Forms.MaskedTextBox();
            this.txtYearStatistics = new System.Windows.Forms.TextBox();
            this.btnStatisticsByMonth = new System.Windows.Forms.Button();
            this.btnStatisticsByYear = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1113, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "StatisticsBorrowingDocument";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMonth.Location = new System.Drawing.Point(33, 127);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(79, 29);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Month";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbYear.Location = new System.Drawing.Point(48, 205);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(64, 29);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Year";
            // 
            // txtMonthStatistics
            // 
            this.txtMonthStatistics.Location = new System.Drawing.Point(178, 134);
            this.txtMonthStatistics.Name = "txtMonthStatistics";
            this.txtMonthStatistics.Size = new System.Drawing.Size(306, 22);
            this.txtMonthStatistics.TabIndex = 4;
            // 
            // txtYearStatistics
            // 
            this.txtYearStatistics.Location = new System.Drawing.Point(178, 212);
            this.txtYearStatistics.Name = "txtYearStatistics";
            this.txtYearStatistics.Size = new System.Drawing.Size(306, 22);
            this.txtYearStatistics.TabIndex = 5;
            // 
            // btnStatisticsByMonth
            // 
            this.btnStatisticsByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatisticsByMonth.Location = new System.Drawing.Point(47, 301);
            this.btnStatisticsByMonth.Name = "btnStatisticsByMonth";
            this.btnStatisticsByMonth.Size = new System.Drawing.Size(179, 61);
            this.btnStatisticsByMonth.TabIndex = 7;
            this.btnStatisticsByMonth.Text = "StatisticsByMonth";
            this.btnStatisticsByMonth.UseVisualStyleBackColor = true;
            this.btnStatisticsByMonth.Click += new System.EventHandler(this.btnStatisticsByMonth_Click);
            // 
            // btnStatisticsByYear
            // 
            this.btnStatisticsByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatisticsByYear.Location = new System.Drawing.Point(289, 301);
            this.btnStatisticsByYear.Name = "btnStatisticsByYear";
            this.btnStatisticsByYear.Size = new System.Drawing.Size(195, 61);
            this.btnStatisticsByYear.TabIndex = 8;
            this.btnStatisticsByYear.Text = "StatisticsByYear";
            this.btnStatisticsByYear.UseVisualStyleBackColor = true;
            this.btnStatisticsByYear.Click += new System.EventHandler(this.btnStatisticsByYear_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(577, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(524, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStatisticsByYear);
            this.Controls.Add(this.btnStatisticsByMonth);
            this.Controls.Add(this.txtYearStatistics);
            this.Controls.Add(this.txtMonthStatistics);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.MaskedTextBox txtMonthStatistics;
        private System.Windows.Forms.TextBox txtYearStatistics;
        private System.Windows.Forms.Button btnStatisticsByMonth;
        private System.Windows.Forms.Button btnStatisticsByYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}