using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelForCreate
{
    public class ReservationForCreate
    {
        public bool IsDeleted { get; set; } = false;
        public Guid UserId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid AppointmentId { get; set; }
    }
}
