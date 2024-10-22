using Domain.Models;

namespace Domain.Interfaces;

public interface ITargetRepository
{
    Task<Target?> GetByIdAsync(int id);
    Task<IEnumerable<Target>> GetAllAsync();
    Task AddAsync(Target target);
    Task UpdateAsync(Target target);
    Task DeleteAsync(Target target);
}