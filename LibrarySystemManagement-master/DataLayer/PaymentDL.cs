using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class PaymentDL
    {
        private DataProvier db = new DataProvier();

        public bool InsertLatePayment(LatePayment payment)
        {
            string sql = "INSERT INTO LatePayment (BorrowId, PaymentDate, Amount) VALUES (@BorrowId, @PaymentDate, @Amount)";
            SqlParameter[] parameters = {
                new SqlParameter("@BorrowId", payment.BorrowId),
                new SqlParameter("@PaymentDate", payment.PaymentDate),
                new SqlParameter("@Amount", payment.Amount)
            };
            return db.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }
    }
}
