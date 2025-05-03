using BussinessLayer;
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
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace PresentationLayer
{
    public partial class FrmReservation : Form
    {
        private Account account;
        public FrmReservation(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

            int documentId = int.Parse(txtDocumentIdReservation.Text);


            string status;
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-H6KBR02F\\SQLEXPRESS01;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                string checkQuantityQuery = "SELECT quantity FROM Document WHERE document_id = @DocumentId";
                SqlCommand checkCmd = new SqlCommand(checkQuantityQuery, conn);
                checkCmd.Parameters.AddWithValue("@DocumentId", documentId);

                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Không tìm thấy tài liệu.");
                    return;
                }

                int quantity = Convert.ToInt32(result);

                status = (quantity <= 0) ? "Đang chờ" : "Thông báo";
                if (quantity > 0)
                {
                    string updateQuantityQuery = "UPDATE Document SET quantity = quantity - 1 WHERE document_id = @DocumentId";
                    SqlCommand updateCmd = new SqlCommand(updateQuantityQuery, conn);
                    updateCmd.Parameters.AddWithValue("@DocumentId", documentId);
                    updateCmd.ExecuteNonQuery();
                }

            }
            ReservationBL reservationBL = new ReservationBL();
            Reservation reservation = new Reservation();
            reservation.DocumentId = documentId;
            reservation.UserId = account.Id;
            reservation.ReservationDate = DateTime.Now;
            reservation.ReservationStatus = status;
            bool check = reservationBL.AddReservation(reservation);
            if (check)
            {
                MessageBox.Show("Dat truoc thanh cong");
            }
            
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            DocumentBL documentBL = new DocumentBL();
            dgvDocumentForReservation.DataSource = documentBL.GetDocuments();

        }
    }
}


