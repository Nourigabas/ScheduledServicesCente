namespace Domain.ModelForCreate
{
    public class CategoryServiceForCreate_Update
    {
        public string Name { get; set; }
        public Guid SectorId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
    }
}