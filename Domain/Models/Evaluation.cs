using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Evaluation
    {
        public Evaluation()
        {
            Id = Guid.NewGuid();
            Users = new List<User>();
        }

        public Guid Id { get; set; }

        [Range(0, 5, ErrorMessage = "The evaluation must be between 0 and 5.")]
        public double EvaluationValue { get; set; }

        public bool IsDeleted { get; set; } = false;
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid ServiceOwnerId { get; set; }
        public ServiceOwner ServiceOwner { get; set; }
        public ICollection<User> Users { get; set; }
    }
}