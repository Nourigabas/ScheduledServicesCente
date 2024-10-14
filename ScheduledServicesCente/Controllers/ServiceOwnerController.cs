using AutoMapper;
using Data.Repository.RepositoryModels.M_ServiceOwner;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [AllowAnonymous]

    [ApiController]
    [Route("api/[Controller]")]
    public class ServiceOwnerController : ControllerBase
    {
        private readonly IServiceOwnerRepository ServiceOwner;
        private readonly IMapper mapper;

        public ServiceOwnerController(IServiceOwnerRepository ServiceOwner, IMapper mapper)
        {
            this.ServiceOwner = ServiceOwner;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("serviceowners")]
        public ActionResult<List<ServiceOwner>> GetServiceOwners()
        {
            var respone = ServiceOwner.GetServiceOwners();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpGet]
        [Route("serviceowner/{ServiceOwnerId}")]
        public ActionResult<ServiceOwner> GetServiceOwner(Guid ServiceOwnerId)
        {
            var respone = ServiceOwner.GetServiceOwner(ServiceOwnerId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpPost]
        [Route("serviceowner/create")]
        public ActionResult CreateServiceOwner(ServiceOwnerForCreate_Update serviceowner)
        {
            var ServiceOwnerForCreate = mapper.Map<ServiceOwner>(serviceowner);
            ServiceOwner.CreateServiceOwner(ServiceOwnerForCreate);
            return Ok();
        }

        [HttpDelete]
        [Route("serviceowner/delete/{ServiceOwnerId}")]
        public ActionResult DeleteServiceOwner(Guid ServiceOwnerId)
        {
            var Check = ServiceOwner.GetServiceOwner(ServiceOwnerId);
            if (Check == null)
                return NotFound();
            ServiceOwner.DeleteServiceOwner(ServiceOwnerId);
            return Ok();
        }

        [HttpPatch]
        [Route("serviceowner/update/{ServiceOwnerId}")]
        public ActionResult<ServiceOwner> UpdateServiceOwner(Guid ServiceOwnerId, JsonPatchDocument<ServiceOwnerForCreate_Update> PatchDocument)
        {
            var Check = ServiceOwner.GetServiceOwner(ServiceOwnerId);
            if (Check == null)
                return NotFound();
            ServiceOwner.UpdateServiceOwner(ServiceOwnerId, PatchDocument);
            return NoContent();
        }

        [HttpPatch]
        [Route("serviceowner/accept/{ServiceOwnerId}")]
        public ActionResult ServiceAccept(Guid ServiceOwnerId)
        {
            var Check = ServiceOwner.GetServiceOwner(ServiceOwnerId);
            if (Check == null)
                return NotFound();
            ServiceOwner.ServiceOwnerAccept(ServiceOwnerId);
            return Ok();
        }
    }
}