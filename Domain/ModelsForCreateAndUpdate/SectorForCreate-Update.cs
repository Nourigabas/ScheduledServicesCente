namespace Domain.ModelsForCreateAndUpdate
{
    public class SectorForCreate_Update
    {
        public string TypeSector { get; set; }
        public string Description { get; set; }
        public List<byte> SectorIcon { get; set; }
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}