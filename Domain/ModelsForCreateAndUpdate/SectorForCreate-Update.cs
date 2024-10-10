namespace Domain.ModelsForCreateAndUpdate
{
    public class SectorForCreate_Update
    {
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
    }
}