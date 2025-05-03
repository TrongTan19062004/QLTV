using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PresentationLayer
{
    public partial class ReservationManagementForAdmin : Form
    {
        public ReservationManagementForAdmin()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = int.Parse(txtReservationId.Text);
                string newStatus = txtStatus.Text;
                ReservationBL reservationBL = new ReservationBL();
                bool check = reservationBL.UpdateStatus(reservationId, newStatus);
                if (check)
                {
                    MessageBox.Show("sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
                dgvReservation.DataSource = reservationBL.GetAllReservations();
            }
            catch(Exception ex) {
                MessageBox.Show("Nhap khong dung dinh dang");
            }
        }

        private void ReservationManagementForAdmin_Load(object sender, EventArgs e)
        {
            ReservationBL reservationBL = new ReservationBL();
            
            dgvReservation.DataSource= reservationBL.GetAllReservations();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = int.Parse(txtReservationId.Text);
                string newStatus = txtStatus.Text;
                ReservationBL reservationBL = new ReservationBL();
                bool check = reservationBL.CancelReservation(reservationId);
                dgvReservation.DataSource = reservationBL.GetAllReservations();
                if (check)
                {
                    MessageBox.Show("sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap khong dung dinh dang");
            }
        }
    }
}
