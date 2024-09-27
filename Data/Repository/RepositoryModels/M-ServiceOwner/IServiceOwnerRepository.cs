using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
