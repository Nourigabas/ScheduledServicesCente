using Data;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Appointment
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly DatabaseContext DatabaseContext;

        public AppointmentRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }

        public void AppointmentBooked(Guid AppointmentId)
        {
            var respone = DatabaseContext.Appointments.FirstOrDefault(e => e.Id == AppointmentId);
            respone.IsBooked = true;
            SaveChange();
        }

        public void CreateAppointment(Appointment Appointment)
        {
            Add(Appointment);
            SaveChange();
        }

        public void DeleteAppointment(Guid AppointmentId)
        {
            var respone = DatabaseContext.Appointments.FirstOrDefault(e => e.Id == AppointmentId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public Appointment GetAppointment(Guid AppointmentId)
        {
            var response = Get(e => e.Id == AppointmentId && !e.IsBooked && !e.IsDeleted, new[]
            {
                "Service",
                "Reservation"
            });
            return response;
        }

        public List<Appointment> GetAppointments()
        {
            var respone = All(new[]
            {
                "Service",
                "Reservation"
            })
                         .Where(e => e.IsDeleted == false && !e.IsBooked)
                         .ToList();
            return respone;
        }

        public void UpdateAppointment(Guid AppointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
