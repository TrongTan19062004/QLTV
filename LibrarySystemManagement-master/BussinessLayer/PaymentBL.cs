using DataLayer;
using TransferObject;
using System;

namespace BusinessLayer
{
    public class PaymentBL
    {
        private PaymentDL paymentDL = new PaymentDL();

        public bool RecordLatePayment(LatePayment payment)
        {
            return paymentDL.InsertLatePayment(payment);
        }

        public decimal CalculateLateFee(DateTime dueDate, DateTime returnDate)
        {
            int lateDays = (returnDate - dueDate).Days;
            return lateDays * 5000; // Ví dụ: 5000 VND/ngày
        }
    }
}
