using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_ServiceOwner
{
    public class ServiceOwnerRepository : GenericRepository<ServiceOwner>, IServiceOwnerRepository
    {
        private readonly IMapper mapper;
        private readonly DatabaseContext DatabaseContext;

        public ServiceOwnerRepository(DatabaseContext DatabaseContext, IMapper mapper) : base(DatabaseContext)
        {
            this.mapper = mapper;
            this.DatabaseContext = DatabaseContext;
        }

        public void ServiceOwnerAccept(Guid ServiceOwnerId)
        {
            var respone = DatabaseContext.OwnerServices.FirstOrDefault(e => e.Id == ServiceOwnerId);
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
                         .Where(e => e.IsDeleted == false && e.IsAccepted)
                         .ToList();
            return respone;
        }

        public void UpdateServiceOwner(Guid ServiceOwnerId, JsonPatchDocument<ServiceOwnerForCreate_Update> PatchDocument)
        {
            var ServiceOwner = GetServiceOwner(ServiceOwnerId);
            var ServiceToPatch = mapper.Map<ServiceOwnerForCreate_Update>(ServiceOwner);
            PatchDocument.ApplyTo(ServiceToPatch);
            mapper.Map(ServiceToPatch, ServiceOwner);
            SaveChange();
            return;
        }
    }
}