namespace Domain.ModelForCreate
{
    public class CategoryServiceForCreate_Update
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<byte> CategoryserviceIcon { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
    }
}