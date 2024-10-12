namespace Domain.Models
{
    public class CategoryService
    {
        public CategoryService()
        {
            Id = Guid.NewGuid();
            Services = new List<Service>();

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlCategoryserviceIcon { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}