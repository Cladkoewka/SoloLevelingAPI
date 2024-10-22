using Domain.Interfaces;
using Domain.Models;
using Infrastructrure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructrure.Repositories;

public class TargetRepository : ITargetRepository
{
    private readonly AppDbContext _context;

    public TargetRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Target?> GetByIdAsync(int id)
    {
        return await _context.Targets
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<IEnumerable<Target>> GetAllAsync()
    {
        return await _context.Targets.ToListAsync();
    }

    public async Task AddAsync(Target target)
    {
        await _context.Targets.AddAsync(target);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Target target)
    {
        _context.Targets.Update(target);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Target target)
    {
        _context.Targets.Remove(target);
        await _context.SaveChangesAsync();
    }
}