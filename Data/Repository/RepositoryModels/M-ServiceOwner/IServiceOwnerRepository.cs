using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_ServiceOwner
{
    public interface IServiceOwnerRepository
    {
        List<ServiceOwner> GetServiceOwners();

        ServiceOwner GetServiceOwner(Guid ServiceOwnerId);

        void DeleteServiceOwner(Guid ServiceOwnerId);

        void CreateServiceOwner(ServiceOwner ServiceOwner);

        void UpdateServiceOwner(Guid ServiceOwnerId, JsonPatchDocument<ServiceOwnerForCreate_Update> PatchDocument);

        void ServiceOwnerAccept(Guid ServiceOwnerId);
    }
}