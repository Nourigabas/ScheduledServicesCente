using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Site { get; set; }
        //The services he wants to obtain
        public ICollection<Service> Services { get; set; }
        //Bookings for those services he wants
        public ICollection<Reservation> Reservations { get; set; }
    }
}
