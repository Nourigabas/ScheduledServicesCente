using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Appointment
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAppointments();
        Appointment GetAppointment(Guid AppointmentId);
        void DeleteAppointment(Guid AppointmentId);
        void CreateAppointment(Appointment Appointment);
        void UpdateAppointment(Guid AppointmentId);
        void AppointmentBooked(Guid AppointmentId);
    }
}
