using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //مواعيد
    public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime TheAppointment { get; set; }
        //If the service owner wants to remove the end of the season
        public bool IsDeleted { get; set; } = false;
        //Reserved or not
        public bool IsBooked { get; set; } = false;
        //id of the service owner
        public Guid ServiceOwnerId { get; set; }
        public ServiceOwner ServiceOwner { get; set; }
        //id service
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        //id reservation 
        //It was set to be null because it is possible that there is no reservation
        public Guid? ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
