namespace Domain.ModelForCreate
{
    public class ServiceForCreate_Update
    {
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid ServiceOwnerId { get; set; }
        public Guid CategoryServiceId { get; set; }
        public Guid SectorId { get; set; }
    }
}