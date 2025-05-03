using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TransferObject;

namespace PresentationLayer
{
    public partial class Return : Form
    {
        private BorrowBL borrowBL = new BorrowBL();
        private PaymentBL paymentBL = new PaymentBL();
        private Borrow currentBorrow;

        public Return()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += chkReturned_CheckedChanged;
            btn_searchBorrow.Click += btnSearch_Click;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_BorrowID.Text, out int borrowId))
            {
                currentBorrow = borrowBL.GetBorrowById(borrowId);
                if (currentBorrow != null && !currentBorrow.IsReturned)
                {
                    var reader = borrowBL.GetReaderById(currentBorrow.ReaderId);
                    var doc = borrowBL.GetDocumentById(currentBorrow.DocumentId);

                    txt_FullName.Text = reader.FullName;
                    txt_Email.Text = reader.Email;
                    txt_Phone.Text = reader.Phone;
                    txt_Document.Text = doc.Title;
                    txt_Date.Text = currentBorrow.BorrowDate.ToShortDateString();
                    txt_Due.Text = currentBorrow.ReturnDate.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn hợp lệ hoặc đã trả.");
                }
            }
        }

        private void chkReturned_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && currentBorrow != null)
            {
                var today = DateTime.Today;
                if (today <= currentBorrow.ReturnDate)
                {
                    if (borrowBL.MarkAsReturned(currentBorrow.BorrowID))
                    {
                        MessageBox.Show("Trả tài liệu đúng hạn thành công!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Trả quá hạn! Vui lòng thanh toán phí trễ.");
                    btnPayLateFee.Visible = true;
                }
            }
        }


        private void btnPayLateFee_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra ID phiếu mượn có trống không
            if (currentBorrow == null || string.IsNullOrEmpty(currentBorrow.BorrowID.ToString()))
            {
                MessageBox.Show("Please enter the Borrow ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã quá hạn 20 ngày chưa
            TimeSpan duration = DateTime.Today - currentBorrow.BorrowDate;
            if (duration.TotalDays <= 20)
            {
                MessageBox.Show("The book is returned on time. Please click the 'Returned' button instead.", "No Late Fee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thông báo yêu cầu đóng phạt
            DialogResult result = MessageBox.Show(
                "Please pay the late return fee of 50,000 VND.",
                "Late Payment Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                var payment = new LatePayment
                {
                    BorrowId = currentBorrow.BorrowID,
                    PaymentDate = DateTime.Now,
                    Amount = paymentBL.CalculateLateFee(currentBorrow.ReturnDate, DateTime.Today)
                };

                if (paymentBL.RecordLatePayment(payment) && borrowBL.MarkAsReturned(currentBorrow.BorrowID))
                {
                    MessageBox.Show("Late fee paid and book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
