using AutoMapper;
using Data.Repository.RepositoryModels;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
        [AllowAnonymous]
    [ApiController]
    [Route("api/[Controller]")]
    public class SectorController : ControllerBase
    {
        private readonly ISectorRepository Sector;
        private readonly IMapper mapper;

        public SectorController(ISectorRepository Sector, IMapper mapper)
        {
            this.Sector = Sector;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("sectors")]
        public ActionResult<List<Sector>> GetSectors()
        {
            var respone = Sector.GetSectors();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpGet]
        [Route("sector/{sectorId}")]
        public ActionResult<Sector> GetSector(Guid sectorId)
        {
            var respone = Sector.GetSector(sectorId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpPost]
        [Route("sector/create")]
        public ActionResult CreateSector(SectorForCreate_Update sector)
        {
            var SectorForCreate = mapper.Map<Sector>(sector);
            Sector.CreateSector(SectorForCreate);
            return Ok();
        }

        [HttpDelete]
        [Route("sector/delete/{sectorId}")]
        public ActionResult DeleteSector(Guid sectorId)
        {
            var Check = Sector.GetSector(sectorId);
            if (Check == null)
                return NotFound();
            Sector.DeletSector(sectorId);
            return Ok();
        }

        [HttpPatch]
        [Route("sector/update/{ServiceId}")]
        public ActionResult<Sector> UpdateSector(Guid SectorId, JsonPatchDocument<SectorForCreate_Update> PatchDocument)
        {
            var Check = Sector.GetSector(SectorId);
            if (Check == null)
                return NotFound();
            Sector.UpdateSector(SectorId, PatchDocument);
            return NoContent();
        }
    }
}