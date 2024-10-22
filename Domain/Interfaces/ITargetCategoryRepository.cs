using Domain.Models;

namespace Domain.Interfaces;

public interface ITargetCategoryRepository
{
    Task<TargetCategory?> GetByIdAsync(int id);
    Task<IEnumerable<TargetCategory>> GetAllAsync();
    Task AddAsync(TargetCategory targetCategory);
    Task UpdateAsync(TargetCategory targetCategory);
    Task DeleteAsync(TargetCategory targetCategory);
}