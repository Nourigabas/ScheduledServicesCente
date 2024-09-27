using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelForCreate
{
    public class ServiceForCreate
    {
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
        public Guid ServiceOwnerId { get; set; }
        public Guid CategoryServiceId { get; set; }
        public Guid SectorId { get; set; }

    }
}
