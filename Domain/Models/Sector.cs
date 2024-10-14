using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Sector
    {
        public Sector()
        {
            Id = Guid.NewGuid();
            ServiceOwners = new List<ServiceOwner>();
            Services = new List<Service>();
            CategoryServices = new List<CategoryService>();
        }

        public Guid Id { get; set; }
        public string TypeSector { get; set; }
        public string Description { get; set; }
        public string UrlSectorIcon { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
        public ICollection<ServiceOwner> ServiceOwners { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<CategoryService> CategoryServices { get; set; }
    }
}