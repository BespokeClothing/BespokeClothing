using System.Collections.Generic;
using System.Threading.Tasks;
using BespokeClothing.API.Domain.Models;
using BespokeClothing.API.Domain.Services.Communication;

namespace BespokeClothing.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();

        Task<CategoryResponse> SaveAsync(Category category);

        Task<CategoryResponse> UpdateAsync(int id, Category category);

        Task<CategoryResponse> DeleteAsync(int id);
    }
}