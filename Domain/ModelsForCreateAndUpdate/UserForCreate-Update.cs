namespace Domain.ModelForCreate
{
    public class UserForCreate_Update
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Site { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid? EvaluationId { get; set; }
        public Guid? OwnerServiceId { get; set; }

    }
}