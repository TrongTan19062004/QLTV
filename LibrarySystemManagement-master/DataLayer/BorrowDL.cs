using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class BorrowDL
    {
        private DataProvier db = new DataProvier();

        public bool InsertBorrow(Borrow borrow)
        {
            string sql = @"INSERT INTO Borrow (ReaderId, DocumentId, BorrowDate, ReturnDate, IsReturned)
                           VALUES (@ReaderId, @DocumentId, @BorrowDate, @ReturnDate, 0)";
            SqlParameter[] parameters = {
                new SqlParameter("@ReaderId", borrow.ReaderId),
                new SqlParameter("@DocumentId", borrow.DocumentId),
                new SqlParameter("@BorrowDate", borrow.BorrowDate),
                new SqlParameter("@ReturnDate", borrow.ReturnDate)
            };
            return db.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public List<Borrow> GetUnreturnedBorrows()
        {
            List<Borrow> list = new List<Borrow>();
            string sql = "SELECT * FROM Borrow WHERE IsReturned = 0";
            DataTable dt = db.MyExcuteReader(sql, CommandType.Text);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Borrow
                {
                    BorrowID = Convert.ToInt32(row["BorrowId"]),
                    ReaderId = Convert.ToInt32(row["ReaderId"]),
                    DocumentId = Convert.ToInt32(row["DocumentId"]),
                    BorrowDate = Convert.ToDateTime(row["BorrowDate"]),
                    ReturnDate = Convert.ToDateTime(row["ReturnDate"]),
                    IsReturned = false
                });
            }

            return list;
        }

        public bool MarkAsReturned(int borrowId)
        {
            string sql = @"UPDATE Borrow SET IsReturned = 1, ReturnedAt = GETDATE()
                           WHERE BorrowId = @BorrowId";
            return db.MyExecuteNonQuery(sql, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@BorrowId", borrowId) }) > 0;
        }
        public Borrow GetBorrowById(int borrowId)
        {
            string sql = "SELECT * FROM Borrow WHERE BorrowId = @BorrowId";
            DataTable dt = db.MyExcuteReader(sql, CommandType.Text, new SqlParameter[]
            {
        new SqlParameter("@BorrowId", borrowId)
            });

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new Borrow
                {
                    BorrowID = borrowId,
                    ReaderId = Convert.ToInt32(row["ReaderId"]),
                    DocumentId = Convert.ToInt32(row["DocumentId"]),
                    BorrowDate = Convert.ToDateTime(row["BorrowDate"]),
                    ReturnDate = Convert.ToDateTime(row["ReturnDate"]),
                    IsReturned = Convert.ToBoolean(row["IsReturned"])
                };
            }

            return null;
        }

    }
}
