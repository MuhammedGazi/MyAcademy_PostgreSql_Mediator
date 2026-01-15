namespace MyAcademyMediatorProject.Repositories
{
    public interface IRepository<Tentity> where Tentity : class
    {
        Task<List<Tentity>> GetAllAsync();
        Task<Tentity> GetByIdAsync(Guid id);
        Task CreateAsync(Tentity entity);
        Task UpdateAsync(Tentity entity);
        Task DeleteAsync(Guid id);
    }
}
