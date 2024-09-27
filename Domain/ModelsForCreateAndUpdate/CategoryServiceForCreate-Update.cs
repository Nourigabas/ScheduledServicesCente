using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelForCreate
{
    public class CategoryServiceForCreate
    {
        public string Name { get; set; }
        public Guid SectorId { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
