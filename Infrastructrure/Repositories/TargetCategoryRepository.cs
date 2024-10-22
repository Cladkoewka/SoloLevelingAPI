using Domain.Interfaces;
using Domain.Models;
using Infrastructrure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructrure.Repositories;

public class TargetCategoryRepository : ITargetCategoryRepository
{
    private readonly AppDbContext _context;

    public TargetCategoryRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<TargetCategory?> GetByIdAsync(int id)
    {
        return await _context.TargetCategories
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<TargetCategory>> GetAllAsync()
    {
        return await _context.TargetCategories.ToListAsync();
    }

    public async Task AddAsync(TargetCategory targetCategory)
    {
        await _context.TargetCategories.AddAsync(targetCategory);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TargetCategory targetCategory)
    {
        _context.TargetCategories.Update(targetCategory);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TargetCategory targetCategory)
    {
        _context.TargetCategories.Remove(targetCategory);
        await _context.SaveChangesAsync();
    }
}