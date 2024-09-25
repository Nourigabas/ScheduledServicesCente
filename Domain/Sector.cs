using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sector
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<ServiceOwner> ServiceOwners { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<CategoryService> CategoryServices { get; set; }



    }
}
