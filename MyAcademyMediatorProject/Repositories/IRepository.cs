using System.Linq.Expressions;

namespace MyAcademyMediatorProject.Repositories
{
    public interface IRepository<Tentity> where Tentity : class
    {
        Task<List<Tentity>> GetAllAsync();
        Task<List<Tentity>> GetAllAsync(params Expression<Func<Tentity, object>>[] includes);
        Task<Tentity> GetByIdAsync(Guid id);
        Task CreateAsync(Tentity entity);
        Task UpdateAsync(Tentity entity);
        Task DeleteAsync(Guid id);
    }
}
