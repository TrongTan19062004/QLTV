using DataLayer;
using TransferObject;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BorrowBL
    {
        private BorrowDL borrowDL = new BorrowDL();
        private ReaderDL readerDL = new ReaderDL();
        private DocumentDL documentDL = new DocumentDL();

        public bool BorrowDocument(Borrow borrow)
        {
            return borrowDL.InsertBorrow(borrow);
        }

        public bool MarkAsReturned(int borrowId)
        {
            return borrowDL.MarkAsReturned(borrowId);
        }

        public List<Borrow> GetUnreturnedBorrows()
        {
            return borrowDL.GetUnreturnedBorrows();
        }

        public Reader GetReaderById(int readerId)
        {
            return readerDL.GetReaderById(readerId);
        }

        public Document GetDocumentById(int docId)
        {
            return documentDL.GetDocumentById(docId);
        }
        public Borrow GetBorrowById(int borrowId)
        {
            return borrowDL.GetBorrowById(borrowId);
        }

    }
}
