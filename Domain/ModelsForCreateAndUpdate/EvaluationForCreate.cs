using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelsForCreateAndUpdate
{
    public class EvaluationForCreate
    {
        [Range(0, 5, ErrorMessage = "The evaluation must be between 0 and 5.")]
        public double EvaluationValue { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
