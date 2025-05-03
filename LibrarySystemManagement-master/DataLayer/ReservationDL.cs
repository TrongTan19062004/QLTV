using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class ReservationDL
    {
        private DataProvier db;

        public ReservationDL()
        {
            db = new DataProvier();
        }

        public List<Reservation> GetAllReservations()
        {
            string sql = "SELECT * FROM Reservation";
            DataTable dt = db.MyExcuteReader(sql, CommandType.Text);
            List<Reservation> list = new List<Reservation>();
            foreach (DataRow row in dt.Rows)
            {
                Reservation res = new Reservation(
                    Convert.ToInt32(row["reservation_id"]),
                    Convert.ToInt32(row["user_id"]),
                    Convert.ToInt32(row["document_id"]),
                    Convert.ToDateTime(row["reservation_date"]),
                    row["reservation_status"].ToString()
                );
                list.Add(res);
            }
            return list;
        }

        public bool AddReservation(Reservation res)
        {
            string sql = "INSERT INTO Reservation (user_id, document_id, reservation_date, reservation_status) " +
                         "VALUES (@user_id, @document_id, @reservation_date, @reservation_status)";
            SqlParameter[] parameters = {
            new SqlParameter("@user_id", res.UserId),
            new SqlParameter("@document_id", res.DocumentId),
            new SqlParameter("@reservation_date", DateTime.Now),
            new SqlParameter("@reservation_status", res.ReservationStatus)
        };
            return db.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool UpdateReservationStatus(int reservationId, string status)
        {
            string sql = "UPDATE Reservation SET reservation_status = @status WHERE reservation_id = @id";
            SqlParameter[] parameters = {
            new SqlParameter("@status", status),
            new SqlParameter("@id", reservationId)
        };
            return db.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool DeleteReservation(int reservationId)
        {
            string sql = "DELETE FROM Reservation WHERE reservation_id = @id";
            SqlParameter[] parameters = {
            new SqlParameter("@id", reservationId)
        };
            return db.MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }
    }
}
