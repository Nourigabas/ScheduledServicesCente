using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels
{
    public interface ISectorRepository
    {
        List<Sector> GetSectors();
        Sector GetSector(Guid SectorId);
        void DeletSector(Guid SectorId);
        void CreateSector(Sector Sector);
        void UpdateSector(Guid SectorId);
    }
}
