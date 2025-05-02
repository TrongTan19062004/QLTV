using System;

namespace TransferObject
{
    public class Borrow
    {
        public int BorrowID { get; set; }
        public int ReaderId { get; set; }
        public int DocumentId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; } = false;
    }
}
