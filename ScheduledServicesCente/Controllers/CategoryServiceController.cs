using AutoMapper;
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
    public class CategoryServiceController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICategoryServiceRepository CategoryService;

        public CategoryServiceController(ICategoryServiceRepository CategoryService, IMapper mapper)
        {
            this.mapper = mapper;
            this.CategoryService = CategoryService;
        }

        [HttpGet]
        [Route("categoryservice")]
        public ActionResult<List<CategoryService>> GetCategoryServices()
        {
            var respone = CategoryService.GetCategoryServices();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpGet]
        [Route("categoryservice/{CategoryServiceId}")]
        public ActionResult<CategoryService> GetCategoryService(Guid CategoryServiceId)
        {
            var respone = CategoryService.GetCategoryService(CategoryServiceId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpPost]
        [Route("categoryservice/create")]
        public ActionResult CreateCategoryService(CategoryServiceForCreate_Update categoryservice)
        {
            var CategoryServiceForCreate = mapper.Map<CategoryService>(categoryservice);
            CategoryService.CreateCategoryService(CategoryServiceForCreate);
            return Ok();
        }

        [HttpDelete]
        [Route("categoryservice/delete/{CategoryServiceId}")]
        public ActionResult DeleteCategoryService(Guid CategoryServiceId)
        {
            var Check = CategoryService.GetCategoryService(CategoryServiceId);
            if (Check == null)
                return NotFound();
            CategoryService.DeleteCategoryService(CategoryServiceId);
            return Ok();
        }

        [HttpPatch]
        [Route("categoryservice/update/{CategoryServiceId}")]
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