using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels
{
    public class SectorRepository : GenericRepository<Sector>, ISectorRepository
    {
        private readonly DatabaseContext DatabaseContext;

        public SectorRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }
        public void CreateSector(Sector Sector)
        {
            Add(Sector);
            SaveChange();
        }
        public Sector GetSector(Guid SectorId)
        {
            var response = Get(e => e.Id == SectorId && !e.IsDeleted, new[] 
            {
                "ServiceOwners" ,
                "CategoryServices",
                "Services"
            });
            return response;
        }

        public void DeletSector(Guid SectorId)
        {
            var respone = DatabaseContext.Sectors.FirstOrDefault(e => e.Id == SectorId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public List<Sector> GetSectors()
        {
            var respone = All(new[] 
            { 
                "CategoryService", 
                "Service", 
                "ServiceOwner"
            })
                        .Where(e => e.IsDeleted == false)
                        .ToList();
            return respone;
        }

        public void UpdateSector(Guid SectorId)
        {

        }
    }
}
