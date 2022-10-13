using Api.Models;

namespace Api.Interfaces;

public interface IRepository
{
    IQueryable<Koi> GetAll();
    Task<bool> Create(Koi koi);
    Task<bool> Delete(Guid id);
    Task<Koi?> Get(Guid id);
    Task<bool> Update(Koi koi);
    Task<bool> SaveChanges();
}