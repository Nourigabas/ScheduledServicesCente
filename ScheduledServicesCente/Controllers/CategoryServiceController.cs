using AutoMapper;
using Data.Repository.ImageRepository;
using Data.Repository.RepositoryModels;
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
    public class CategoryServiceController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ICategoryServiceRepository CategoryService;

        public CategoryServiceController(
            ICategoryServiceRepository CategoryService,
            IMapper mapper)        {
            this.mapper = mapper;
            this.CategoryService = CategoryService;
        }

        [HttpGet]
        public ActionResult<List<CategoryService>> GetCategoryServices()
        {
            var respone = CategoryService.GetCategoryServices();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpGet("{CategoryServiceId}")]
        public ActionResult<CategoryService> GetCategoryService(Guid CategoryServiceId)
        {
            var respone = CategoryService.GetCategoryService(CategoryServiceId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreateCategoryService(CategoryServiceForCreate_Update categoryservice)
        {

            var CategoryServiceForCreate = mapper.Map<CategoryService>(categoryservice);
            CategoryService.CreateCategoryService(CategoryServiceForCreate);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{CategoryServiceId}")]
        public ActionResult DeleteCategoryService(Guid CategoryServiceId)
        {
            var Check = CategoryService.GetCategoryService(CategoryServiceId);
            if (Check == null)
                return NotFound();
            CategoryService.DeleteCategoryService(CategoryServiceId);
            return Ok();
        }

        [HttpPatch]
        [Route("update/{CategoryServiceId}")]
        public ActionResult<CategoryService> UpdateCategoryService(Guid CategoryServiceId,
                                                           JsonPatchDocument<CategoryServiceForCreate_Update> PatchDocument)
        {
            var Check = CategoryService.GetCategoryService(CategoryServiceId);
            if (Check == null)
                return NotFound();
            CategoryService.UpdateCategoryService(CategoryServiceId, PatchDocument);
            return NoContent();
        }
    }
}