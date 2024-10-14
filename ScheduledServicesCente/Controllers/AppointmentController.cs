using AutoMapper;
using Data.Repository.RepositoryModels.M_Appointment;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [AllowAnonymous]

    [ApiController]
    [Route("api/[Controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IAppointmentRepository Appointment;

        public AppointmentController(IAppointmentRepository Appointment, IMapper mapper)
        {
            this.mapper = mapper;
            this.Appointment = Appointment;
        }

        [HttpGet]
        [Route("appointment")]
        public ActionResult<List<Appointment>> GetCAppointments()
        {
            var respone = Appointment.GetAppointments();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpGet]
        [Route("appointment/{AppointmentId}")]
        public ActionResult<CategoryService> GetAppointment(Guid AppointmentId)
        {
            var respone = Appointment.GetAppointment(AppointmentId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpPost]
        [Route("appointment/create")]
        public ActionResult CreateAppointment(AppointmentForCreate_Update appointment)
        {
            var AppointmentForCreate = mapper.Map<Appointment>(appointment);
            Appointment.CreateAppointment(AppointmentForCreate);
            return Ok();
        }

        [HttpDelete]
        [Route("appointment/delete/{AppointmentId}")]
        public ActionResult DeleteAppointment(Guid AppointmentId)
        {
            var Check = Appointment.GetAppointment(AppointmentId);
            if (Check == null)
                return NotFound();
            Appointment.DeleteAppointment(AppointmentId);
            return Ok();
        }

        [HttpPatch]
        [Route("appointment/update/{AppointmentId}")]
        public ActionResult<Appointment> UpdateAppointment(Guid AppointmentId,
                                                           JsonPatchDocument<AppointmentForCreate_Update> PatchDocument)
        {
            var Check = Appointment.GetAppointment(AppointmentId);
            if (Check == null)
                return NotFound();
            Appointment.UpdateAppointment(AppointmentId, PatchDocument);
            return NoContent();
        }

        [HttpPatch]
        [Route("appointment/booked/{AppointmentId}")]
        public ActionResult AppointmentBooked(Guid AppointmentId)
        {
            var Check = Appointment.GetAppointment(AppointmentId);
            if (Check == null)
                return NotFound();
            Appointment.AppointmentBooked(AppointmentId);
            return Ok();
        }
    }
}