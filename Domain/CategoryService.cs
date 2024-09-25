using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CategoryService
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }
        public ICollection<Service> Services { get; set; }

    }
}
