using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelForCreate
{
    public class AppointmentForCreate
    {
        public DateTime TheAppointment { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBooked { get; set; } = false;
        public Guid ServiceId { get; set; }
        public Guid? ReservationId { get; set; }
    }
}
