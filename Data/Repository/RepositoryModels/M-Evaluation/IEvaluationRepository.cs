using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Evaluation
{
    public interface IEvaluationRepository
    {
        List<Evaluation> GetEvaluations();
        void CreateEvaluation(Evaluation Evaluation);

    }
}
