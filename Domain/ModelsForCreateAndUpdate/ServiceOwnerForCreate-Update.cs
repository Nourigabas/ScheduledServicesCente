using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelForCreate
{
    public class ServiceOwnerForCreate
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Site { get; set; }
        public string UrlImgPersonalIdentity { get; set; }
        public string UrlImgWorkIdentity { get; set; }
        public string UrlCV { get; set; }
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public Guid SectorId { get; set; }
    }
}
