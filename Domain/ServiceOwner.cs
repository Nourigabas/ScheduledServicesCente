using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceOwner
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Site { get; set; }
        //It is necessary to verify the data he provides, so his personal identity was requested
        public string UrlImgPersonalIdentity { get; set; }
        //Anything that proves that this person has something to offer on this platform 
        //For example, a doctor has an identity specific to his field
        public string UrlImgWorkIdentity { get; set; }
        //Upload his CV file to know more details about him
        public string UrlCV { get; set; }
        //Initially, account creation is not accepted 
        //It is reviewed by the platform administration 
        //After 24 hours, the order of rejection or acceptance comes
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        //Available appointments for that service that the employer will provide
        public ICollection<Appointment> Appointments { get; set; }
        //Reservations made by users
        //Mmm, it could be null because initially, when creating the account, it does not have any reservations
        public ICollection<Reservation>? Reservations { get; set; }
        //The service that will be provided
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        //In which sector is the service that will be provided?
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }

    }
}
