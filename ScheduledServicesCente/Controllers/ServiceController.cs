using AutoMapper;
using Data.Repository.RepositoryModels.M_Service;
using Domain.ModelForCreate;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ServiceController : Controller
    {
        private readonly IMapper mapper;
        private readonly IServiceRepository Service;

        public ServiceController(IServiceRepository Service,IMapper mapper)
        {
            this.mapper = mapper;
            this.Service = Service;
        }


        [HttpGet]
        [Route("services")]
        public ActionResult<List<Service>> GetServices()
        {
            var respone = Service.GetServices();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }




        [HttpGet]
        [Route("service/{ServiceId}")]
        public ActionResult<Service> GetService(Guid ServiceId)
        {
            var respone = Service.GetService(ServiceId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }




        [HttpPost]
        [Route("service/create")]
        public ActionResult CreateService(ServiceForCreate_Update service)
        {
            var SectorForCreate = mapper.Map<Service>(service);
            Service.CreateService(SectorForCreate);
            return Ok();
        }
        [HttpDelete]
        [Route("service/delete/{ServiceId}")]
        public ActionResult DeleteService(Guid ServiceId)
        {
            var Check = Service.GetService(ServiceId);
            if (Check == null)
                return NotFound();
            Service.DeleteService(ServiceId);
            return Ok();
        }
        [HttpPatch]
        [Route("service/update/{ServiceId}")]
        public ActionResult<Service> UpdateService(Guid ServiceId, JsonPatchDocument<ServiceForCreate_Update> PatchDocument)
        {
            var Check = Service.GetService(ServiceId);
            if (Check == null)
                return NotFound();
            Service.UpdateService(ServiceId, PatchDocument);
            return NoContent();
        }
        [HttpPatch]
        [Route("service/accept/{ServiceId}")]
        public ActionResult ServiceAccept(Guid ServiceId)
        {
            var Check = Service.GetService(ServiceId);
            if (Check == null)
                return NotFound();
            Service.ServiceAccept(ServiceId);
            return Ok();
        }
    }
}
