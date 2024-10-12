using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ServiceOwner
    {
        public ServiceOwner()
        {
            Id = Guid.NewGuid();
            Services = new List<Service>();
            Evaluations = new List<Evaluation>();
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Site { get; set; }
        public List<byte> ImgPersonalIdentity { get; set; }
        public List<byte> ImgWorkIdentity { get; set; }
        public List<byte> CV { get; set; }
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public string UserName { get; set; }
        public string Password { get; set; }

        [Range(0, 5, ErrorMessage = "The evaluation must be between 0 and 5.")]
        public double EvaluationAverage { get; set; } = 0;
        public ICollection<Service> Services { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
    }
}