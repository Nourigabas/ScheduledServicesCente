using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Service
    {
        public Service()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
        public Guid ServiceOwnerId { get; set; }
        public ServiceOwner ServiceOwner { get; set; }
        public Guid CategoryServiceId { get; set; }
        public CategoryService CategoryService { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }

    }
}
