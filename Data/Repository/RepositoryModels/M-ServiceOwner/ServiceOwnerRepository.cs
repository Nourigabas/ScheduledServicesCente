using AutoMapper;
using Data.Repository.EncryptionRepository;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_ServiceOwner
{
    public class ServiceOwnerRepository : GenericRepository<ServiceOwner>, IServiceOwnerRepository
    {
        private readonly IMapper mapper;
        private readonly DatabaseContext DatabaseContext;
        private readonly IEncryptionRepository Encryption;

        public ServiceOwnerRepository(DatabaseContext DatabaseContext, IMapper mapper, IEncryptionRepository Encryption) : base(DatabaseContext)
        {
            this.mapper = mapper;
            this.DatabaseContext = DatabaseContext;
            this.Encryption = Encryption;

        }

        public void ServiceOwnerAccept(Guid ServiceOwnerId)
        {
            var respone = DatabaseContext.OwnerServices.FirstOrDefault(e => e.Id == ServiceOwnerId);
            respone.IsAccepted = true;
            SaveChange();
        }

        public void CreateServiceOwner(ServiceOwner serviceowner)
        {
            serviceowner.Password = Encryption.Encryption(serviceowner.Password);
            Add(serviceowner);
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
                "Evaluations",
                "Sector",
                "User"
            });
            response.Password = Encryption.Decryption(response.Password);
            return response;
        }

        public List<ServiceOwner> GetServiceOwners()
        {
            var respone = All(new[]
            {
                "Services",
                "Evaluations",
                "Sector",
                "User"
            })
                         .Where(e => e.IsDeleted == false && e.IsAccepted)
                         .ToList();
            foreach (var temp in respone)
                temp.Password = Encryption.Decryption(temp.Password);
            return respone;
        }

        public void UpdateServiceOwner(Guid ServiceOwnerId, JsonPatchDocument<ServiceOwnerForCreate_Update> PatchDocument)
        {
            var ServiceOwner = GetServiceOwner(ServiceOwnerId);
            var ServiceToPatch = mapper.Map<ServiceOwnerForCreate_Update>(ServiceOwner);

            PatchDocument.ApplyTo(ServiceToPatch);
            mapper.Map(ServiceToPatch, ServiceOwner);
            if (ServiceOwner.Password is not null)
                ServiceOwner.Password = Encryption.Encryption(ServiceOwner.Password);
            SaveChange();
            return;
        }
    }
}