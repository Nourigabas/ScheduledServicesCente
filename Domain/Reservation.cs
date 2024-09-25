using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //حجوزات
    public class Reservation
    {
        public Guid Id { get; set; }
        //If the user wants to remove the reservation
        public bool IsDeleted { get; set; } = false;
        //Associating with the user
        public Guid UserId { get; set; }
        public User User { get; set; }
        //Linking with the service owner
        public Guid ServiceOwnerId { get; set; }
        public ServiceOwner ServiceOwner { get; set; }
        //Linking with the service
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        //Linking with the reservation appointment
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

    }
}
