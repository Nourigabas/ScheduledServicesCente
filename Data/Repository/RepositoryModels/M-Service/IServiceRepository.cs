using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Service
{
    public interface IServiceRepository
    {
        List<Service> GetServices();
        Service GetService(Guid ServiceId);
        void DeleteService(Guid ServiceId);
        void CreateService(Service Service);
        void UpdateService(Guid ServiceId);
        void ServiceAccept(Guid ServiceId);

    }
}
