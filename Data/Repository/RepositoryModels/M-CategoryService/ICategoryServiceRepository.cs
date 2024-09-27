using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels
{
    public interface ICategoryServiceRepository
    {
        List<CategoryService> GetCategoryServices();
        CategoryService GetCategoryService(Guid CategoryServiceId);
        void DeletCategoryService(Guid CategoryServiceId);
        void CreateCategoryService(CategoryService CategoryService);
        void UpdateCategoryService(Guid CategoryServiceId);
    }
}
