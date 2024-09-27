using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_ServiceOwner
{
    public class ServiceOwnerRepository : GenericRepository<ServiceOwner>, IServiceOwnerRepository
    {
        private readonly DatabaseContext DatabaseContext;

        public ServiceOwnerRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }

        public void ServiceOwnerAccept(Guid ServiceOwnerId)
        {
            var respone = DatabaseContext.Services.FirstOrDefault(e => e.Id == ServiceOwnerId);
            respone.IsAccepted = true;
            SaveChange();
        }

        public void CreateServiceOwner(ServiceOwner ServiceOwner)
        {
            Add(ServiceOwner);
            SaveChange();
        }

        public void DeleteServiceOwner(Guid ServiceOwnerId)
        {
            var respone = DatabaseContext.OwnerServices.FirstOrDefault(e => e.Id == ServiceOwnerId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public ServiceOwner GetServiceOwner(Guid ServiceOwnerId)
        {
            var response = Get(e => e.Id == ServiceOwnerId && e.IsAccepted && !e.IsDeleted, new[]
            {
                "Services",
                "Sector"
            });
            return response;
        }

        public List<ServiceOwner> GetServiceOwners()
        {
            var respone = All(new[]
            {
                "Services",
                "Sector"
            })
                         .Where(e => e.IsDeleted == false&& e.IsAccepted)
                         .ToList();
            return respone;
        }

        public void UpdateServiceOwner(Guid ServiceOwnerId)
        {
            throw new NotImplementedException();
        }

        
    }
}
