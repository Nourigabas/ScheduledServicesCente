using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_Service
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        private readonly IMapper mapper;
        private readonly DatabaseContext DatabaseContext;

        public ServiceRepository(DatabaseContext DatabaseContext, IMapper mapper) : base(DatabaseContext)
        {
            this.mapper = mapper;
            this.DatabaseContext = DatabaseContext;
        }

        public void CreateService(Service Service)
        {
            Add(Service);
            SaveChange();
        }

        public void DeleteService(Guid ServiceId)
        {
            var respone = DatabaseContext.Services.FirstOrDefault(e => e.Id == ServiceId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public Service GetService(Guid ServiceId)
        {
            var response = Get(e => e.Id == ServiceId && !e.IsDeleted, new[]
            {
                "ServiceOwner",
                "CategoryService",
                "Appointments",
                "Evaluations",
                "Reservations",
                "Sector"
            });
            return response;
        }

        public List<Service> GetServices()
        {
            var respone = All(new[]
            {
                "ServiceOwner",
                "CategoryService",
                "Appointments",
                "Evaluations",
                "Reservations",
                "Sector"
            })
                        .Where(e => e.IsDeleted == false)
                        .ToList();
            return respone;
        }

        public void UpdateService(Guid ServiceId, JsonPatchDocument<ServiceForCreate_Update> PatchDocument)
        {
            var Service = GetService(ServiceId);
            var ReservationToPatch = mapper.Map<ServiceForCreate_Update>(Service);
            PatchDocument.ApplyTo(ReservationToPatch);
            mapper.Map(ReservationToPatch, Service);
            SaveChange();
            return;
        }
    }
}