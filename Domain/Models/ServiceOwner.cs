using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ServiceOwner
    {
        public ServiceOwner()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Site { get; set; }
        public string UrlImgPersonalIdentity { get; set; }
        public string UrlImgWorkIdentity { get; set; }
        public string UrlCV { get; set; }
        public bool IsAccepted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public string UserName { get; set; }
        public string Password { get; set; }
        [Range(0, 5, ErrorMessage = "The evaluation must be between 0 and 5.")]
        public double EvaluationAverage { get; set; }
        public ICollection<Service> Services { get; set; }
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}