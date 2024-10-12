using Data.Repository.RepositoryModels.M_Service;
using Data.Repository.RepositoryModels.M_ServiceOwner;
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
        private readonly IServiceOwnerRepository ServiceOwner;

        public EvaluationRepository(DatabaseContext DatabaseContext, IServiceOwnerRepository ServiceOwner) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
            this.ServiceOwner = ServiceOwner;
        }

        public void CreateEvaluation(Evaluation Evaluation)
        {
            Add(Evaluation);
            var respone = ServiceOwner.GetServiceOwner(Evaluation.ServiceOwnerId);
            if (respone is not null)
            {
                respone.EvaluationAverage = (respone.EvaluationAverage + Evaluation.EvaluationValue) / 2;
                DatabaseContext.SaveChanges();
            }
            SaveChange();
            return;
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
