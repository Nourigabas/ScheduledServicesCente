using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Sector
    {
        public Sector()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string TypeSector { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public ICollection<ServiceOwner> ServiceOwners { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<CategoryService> CategoryServices { get; set; }



    }
}
