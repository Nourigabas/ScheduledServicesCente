using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Service
    {
        public Guid Id { get; set; }
        //Description of the Service
        public string Description { get; set; }
        //Service delivery site
        public string Location { get; set; }
        //If the service owner wants to delete the service he provides
        public bool IsDeleted { get; set; } = false;
        //This field was added because when a service is added, it is reviewed by the platform owner 
        //To verify the accuracy of the information provided to that service
        //After 24 hours, the order of rejection or acceptance comes
        public bool IsAccepted { get; set; } = false;
        //It is possible for one service to be provided by more than one person
        public ICollection<ServiceOwner> ServiceOwners { get; set; }
        //It is possible for more than one user to obtain this service
        public ICollection<User> Users { get; set; }
        //The service may have more than one appointment
        public ICollection<Appointment> Appointments { get; set; }
        //The service can have more than one reservation
        public ICollection<Reservation> Reservations { get; set; }
        //This service lies in any sector
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }

    }
}
