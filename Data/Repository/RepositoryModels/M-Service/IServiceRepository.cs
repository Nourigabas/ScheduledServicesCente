using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_Service
{
    public interface IServiceRepository
    {
        List<Service> GetServices();

        Service GetService(Guid ServiceId);

        void DeleteService(Guid ServiceId);

        void CreateService(Service Service);

        void UpdateService(Guid ServiceId, JsonPatchDocument<ServiceForCreate_Update> PatchDocument);

    }
}