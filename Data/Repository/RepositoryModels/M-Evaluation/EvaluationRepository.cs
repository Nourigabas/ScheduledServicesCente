using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Evaluation
{
    public class EvaluationRepository : GenericRepository<Evaluation>, IEvaluationRepository
    {
        private readonly DatabaseContext DatabaseContext;
        public EvaluationRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }

        public void CreateEvaluation(Evaluation Evaluation)
        {
            Add(Evaluation);
            SaveChange();
        }

        public List<Evaluation> GetEvaluations()
        {
            var respone = All()
                         .Where(e => e.IsDeleted == false)
                         .ToList();
            return respone;
        }
    }
}
