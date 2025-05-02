using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class ReaderDL
    {
        private DataProvier db = new DataProvier();

        public Reader GetReaderById(int readerId)
        {
            string sql = "SELECT * FROM Users WHERE user_id = @ReaderId";
            DataTable dt = db.MyExcuteReader(sql, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@ReaderId", readerId) });

            if (dt.Rows.Count > 0)
            {
                var r = dt.Rows[0];
                return new Reader
                {
                    UserId = readerId,
                    FullName = r["user_name"].ToString(),
                    Email = r["user_email"].ToString(),
                    Phone = r["user_phone"].ToString()
                };
            }

            return null;
        }
    }
}
