using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels
{
    public interface ICategoryServiceRepository
    {
        List<CategoryService> GetCategoryServices();

        CategoryService GetCategoryService(Guid CategoryServiceId);

        void DeleteCategoryService(Guid CategoryServiceId);

        void CreateCategoryService(CategoryService CategoryService);

        void UpdateCategoryService(Guid CategoryServiceId, JsonPatchDocument<CategoryServiceForCreate_Update> PatchDocument);
        void CategoryServiceAccept(Guid CategoryServiceId);

    }
}