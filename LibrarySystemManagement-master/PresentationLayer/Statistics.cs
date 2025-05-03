using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        // Thay đổi chuỗi kết nối cho phù hợp với máy bạn
        string connectionString = "Data Source=LAPTOP-H6KBR02F\\SQLEXPRESS01;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;TrustServerCertificate=True";

        private void LoadStatisticsByMonth(int year)
        {
            string query = @"SELECT 
                        MONTH(BorrowDate) AS BorrowMonth,
                        COUNT(*) AS BorrowCount
                     FROM Borrow
                     WHERE YEAR(BorrowDate) = @Year
                     GROUP BY MONTH(BorrowDate)
                     ORDER BY BorrowMonth";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Year", year);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                string seriesName = "BorrowByMonth " + txtMonthStatistics.Text;
                chart1.ChartAreas[0].AxisX.Title = "Day";
                chart1.ChartAreas[0].AxisY.Title = "Số lượng";
                if (!chart1.Series.IsUniqueName(seriesName))
                {
                    chart1.Series.Remove(chart1.Series[seriesName]);
                }

                chart1.Series.Clear(); // Xoá series cũ nếu chỉ dùng 1 series
                chart1.Series.Add(seriesName);
                chart1.Series[seriesName].ChartType = SeriesChartType.Column;
                chart1.Series[seriesName].LegendText = seriesName;  // Hiển thị bên phải


                while (reader.Read())
                {
                    int month = reader.GetInt32(0);
                    int count = reader.GetInt32(1);
                    chart1.Series[seriesName].Points.AddXY(month, count);
                }

                conn.Close();
            }
        }

        private void LoadStatisticsByYear()
        {
            string query = @"SELECT 
                        YEAR(BorrowDate) AS BorrowYear,
                        COUNT(*) AS BorrowCount
                     FROM Borrow
                     GROUP BY YEAR(BorrowDate)
                     ORDER BY BorrowYear";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                string seriesName = "BorrowByYear";

                if (!chart1.Series.IsUniqueName(seriesName))
                {
                    chart1.Series.Remove(chart1.Series[seriesName]);
                }
                chart1.ChartAreas[0].AxisX.Title = "Year";
                chart1.ChartAreas[0].AxisY.Title = "Số lượng";
                chart1.Series.Clear(); // Xoá series cũ nếu chỉ dùng 1 series
                chart1.Series.Add(seriesName);
                chart1.Series[seriesName].ChartType = SeriesChartType.Column;
                chart1.Series[seriesName].LegendText = seriesName;  // Hiển thị bên phải
                while (reader.Read())
                {
                    int year = reader.GetInt32(0);
                    int count = reader.GetInt32(1);
                    chart1.Series[seriesName].Points.AddXY(year, count);
                }

                conn.Close();
            }
        }

        private void btnStatisticsByMonth_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtYearStatistics.Text, out int year))
            {
                LoadStatisticsByMonth(year);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ.");
            }
        }

        
            private void btnStatisticsByYear_Click(object sender, EventArgs e)
        {
            LoadStatisticsByYear();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // Thiết lập tiêu đề trục X và Y
            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Số lượng";

            // (Tuỳ chọn) Căn chỉnh font hoặc cỡ chữ nếu muốn
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);

        }
    }
    }

