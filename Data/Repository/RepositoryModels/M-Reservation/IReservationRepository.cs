using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Reservation
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        Reservation GetReservation(Guid ReservationId);
        void DeleteReservation(Guid ReservationId);
        void CreateReservation(Reservation Reservation);
        void UpdateReservation(Guid ReservationId);
    }
}
