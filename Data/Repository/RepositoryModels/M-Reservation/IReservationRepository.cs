using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_Reservation
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();

        Reservation GetReservation(Guid ReservationId);

        void DeleteReservation(Guid ReservationId);

        void CreateReservation(Reservation Reservation);

        void UpdateReservation(Guid ReservationId, JsonPatchDocument<ReservationForCreate_Update> PatchDocument);
    }
}