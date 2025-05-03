using System;

namespace TransferObject
{
    public class LatePayment
    {
        public int PaymentId { get; set; }
        public int BorrowId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }
}
