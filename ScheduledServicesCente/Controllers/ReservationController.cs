using AutoMapper;
using Data.Repository.RepositoryModels.M_Reservation;
using Domain.ModelForCreate;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ReservationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IReservationRepository Reservation;

        public ReservationController(IReservationRepository Reservation, IMapper mapper)
        {
            this.Reservation = Reservation;
            this.mapper = mapper;
        }



        [HttpGet]
        [Route("reservations")]
        public ActionResult<List<Reservation>> GetReservations()
        {
            var respone = Reservation.GetReservations();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }
        [HttpGet]
        [Route("reservation/{ReservationId}")]
        public ActionResult<Reservation> GetReservation(Guid ReservationId)
        {
            var respone = Reservation.GetReservation(ReservationId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }
        [HttpPost]
        [Route("reservation/create")]
        public ActionResult CreateReservation(ReservationForCreate_Update reservation)
        {
            var ReservationForCreate = mapper.Map<Reservation>(reservation);
            Reservation.CreateReservation(ReservationForCreate);
            return Ok();
        }
        [HttpDelete]
        [Route("reservation/delete/{ReservationId}")]
        public ActionResult DeleteReservation(Guid ReservationId)
        {
            var Check = Reservation.GetReservation(ReservationId);
            if (Check == null)
                return NotFound();
            Reservation.DeleteReservation(ReservationId);
            return Ok();
        }
        [HttpPatch]
        [Route("reservation/update/{ReservationId}")]
        public ActionResult<Reservation> UpdateReservation(Guid ReservationId,
                                                           JsonPatchDocument<ReservationForCreate_Update> PatchDocument)
        {
            var Check = Reservation.GetReservation(ReservationId);
            if (Check == null)
                return NotFound();
            Reservation.UpdateReservation(ReservationId, PatchDocument);
            return NoContent();
        }
    }
}
