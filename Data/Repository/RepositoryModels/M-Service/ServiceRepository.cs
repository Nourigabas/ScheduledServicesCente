using Domain.Models;

namespace Data.Repository.RepositoryModels.M_Service
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        private readonly DatabaseContext DatabaseContext;

        public ServiceRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }

        public void ServiceAccept(Guid ServiceId)
        {
            var respone = DatabaseContext.Services.FirstOrDefault(e => e.Id == ServiceId);
            respone.IsAccepted = true;
            SaveChange();
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
            var response = Get(e => e.Id == ServiceId && e.IsAccepted && !e.IsDeleted, new[]
            {
                "ServiceOwner",
                "CategoryService",
                "Appointments",
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
                "Appointment",
                "Reservation",
                "Sector"
            })
                        .Where(e => e.IsDeleted == false && e.IsAccepted)
                        .ToList();
            return respone;
        }

        public void UpdateService(Guid ServiceId)
        {
            throw new NotImplementedException();
        }
    }
}
