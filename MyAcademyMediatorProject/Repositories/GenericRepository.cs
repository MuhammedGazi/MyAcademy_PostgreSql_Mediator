
using Microsoft.EntityFrameworkCore;
using MyAcademyMediatorProject.Context;

namespace MyAcademyMediatorProject.Repositories
{
    public class GenericRepository<Tentity>(AppDbContext _context) : IRepository<Tentity> where Tentity : class
    {
        public async Task CreateAsync(Tentity entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var value = await GetByIdAsync(id);
            _context.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Tentity>> GetAllAsync()
        {
            return await _context.Set<Tentity>().AsNoTracking().ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(Guid id)
        {
            return await _context.Set<Tentity>().FindAsync(id);
        }

        public async Task UpdateAsync(Tentity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
