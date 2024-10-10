using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Evaluation
    {
        public Evaluation()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [Range(0, 5, ErrorMessage = "The evaluation must be between 0 and 5.")]
        public double EvaluationValue { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid? ServiceId { get; set; }
        public Service Service { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
