using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelsForCreateAndUpdate
{
    public class SectorForCreate_Update
    {
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
