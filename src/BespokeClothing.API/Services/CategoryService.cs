
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BespokeClothing.API.Domain.Models;
using BespokeClothing.API.Domain.Repositories;
using BespokeClothing.API.Domain.Services;
using BespokeClothing.API.Domain.Services.Communication;

namespace BespokeClothing.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this._categoryRepository = categoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();
                return new SaveCategoryResponse(category);
            }
            catch(Exception ex)
            {
                return new SaveCategoryResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }
    }
}