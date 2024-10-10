namespace Domain.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsOwner { get; set; } = false;
        public Guid? EvaluationId { get; set; }
        public Evaluation? Evaluation { get; set; }
        public Guid? OwnerServiceId { get; set; }
        public ServiceOwner? ServiceOwner { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}