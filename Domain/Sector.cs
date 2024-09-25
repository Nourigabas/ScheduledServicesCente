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
        //Description of the sector
        public string Description { get; set; }
        //If the service providers do not deal with us, meaning there is no one left providing the service,
        //the sector will be deleted
        public bool IsDeleted { get; set; } = false;
        //Service owners
        public ICollection<ServiceOwner> ServiceOwners { get; set; }
        //Services that are provided in this sector
        public ICollection<Service> Services { get; set; }


    }
}
