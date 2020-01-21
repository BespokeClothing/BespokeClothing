using System.Collections.Generic;
using System.Threading.Tasks;
using BespokeClothing.API.Domain.Models;

namespace BespokeClothing.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        
    }
}