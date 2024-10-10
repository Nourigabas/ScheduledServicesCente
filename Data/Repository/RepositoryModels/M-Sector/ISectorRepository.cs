using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels
{
    public interface ISectorRepository
    {
        List<Sector> GetSectors();

        Sector GetSector(Guid SectorId);

        void DeletSector(Guid SectorId);

        void CreateSector(Sector Sector);

        void UpdateSector(Guid SectorId, JsonPatchDocument<SectorForCreate_Update> PatchDocument);
        void SectorAccept(Guid SectorId);

    }
}