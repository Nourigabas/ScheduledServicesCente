﻿using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels
{
    public class CategoryServiceRepository : GenericRepository<CategoryService>, ICategoryServiceRepository
    {
        private readonly IMapper mapper;
        private readonly DatabaseContext DatabaseContext;

        public CategoryServiceRepository(DatabaseContext DatabaseContext, IMapper mapper) : base(DatabaseContext)
        {
            this.mapper = mapper;
            this.DatabaseContext = DatabaseContext;
        }

        public void CategoryServiceAccept(Guid CategoryServiceId)
        {
            var respone = DatabaseContext.CategoryServices.FirstOrDefault(e => e.Id == CategoryServiceId);
            respone.IsAccepted = true;
            SaveChange();
        }

        public void CreateCategoryService(CategoryService CategoryService)
        {
            Add(CategoryService);
            SaveChange();
        }

        public void DeleteCategoryService(Guid CategoryServiceId)
        {
            var respone = DatabaseContext.CategoryServices.FirstOrDefault(e => e.Id == CategoryServiceId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public CategoryService GetCategoryService(Guid CategoryServiceId)
        {
            var response = Get(e => e.Id == CategoryServiceId && !e.IsDeleted, new[]
            {
                "Sector",
                "Services"
            });
            return response;
        }

        public List<CategoryService> GetCategoryServices()
        {
            var respone = All(new[]
            {
                "Sector",
                "Services"
            })
                        .Where(e => e.IsDeleted == false)
                        .ToList();
            return respone;
        }

        public void UpdateCategoryService(Guid CategoryServiceId, JsonPatchDocument<CategoryServiceForCreate_Update> PatchDocument)
        {
            var CategoryService = GetCategoryService(CategoryServiceId);
            var CategoryServiceToPatch = mapper.Map<CategoryServiceForCreate_Update>(CategoryService);
            PatchDocument.ApplyTo(CategoryServiceToPatch);
            mapper.Map(CategoryServiceToPatch, CategoryService);
            SaveChange();
            return;
        }
    }
}