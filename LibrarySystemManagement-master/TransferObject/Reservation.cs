using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationStatus { get; set; }

        public Reservation() { }

        public Reservation(int reservationId, int userId, int documentId, DateTime reservationDate, string reservationStatus)
        {
            ReservationId = reservationId;
            UserId = userId;
            DocumentId = documentId;
            ReservationDate = reservationDate;
            ReservationStatus = reservationStatus;
        }
    }

}
