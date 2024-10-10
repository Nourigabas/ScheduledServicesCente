using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_Appointment
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAppointments();

        Appointment GetAppointment(Guid AppointmentId);

        void DeleteAppointment(Guid AppointmentId);

        void CreateAppointment(Appointment Appointment);

        void UpdateAppointment(Guid AppointmentId, JsonPatchDocument<AppointmentForCreate_Update> PatchDocument);

        void AppointmentBooked(Guid AppointmentId);
    }
}