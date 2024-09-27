using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    //حجوزات
    public class Reservation
    {
        public Reservation()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

    }
}
