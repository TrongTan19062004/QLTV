using DataLayer;
using System;
using System.Collections.Generic;
using TransferObject;

public class ReservationBL
{
    private ReservationDL dal;

    public ReservationBL()
    {
        dal = new ReservationDL();
    }

    public List<Reservation> GetAllReservations()
    {
        return dal.GetAllReservations();
    }

    public bool AddReservation(Reservation res)
    {
        return dal.AddReservation(res);
    }

    public bool UpdateStatus(int reservationId, string newStatus)
    {
        return dal.UpdateReservationStatus(reservationId, newStatus);
    }

    public bool CancelReservation(int reservationId)
    {
        return dal.DeleteReservation(reservationId);
    }
}
