using Api.Dtos;
using Api.Models;

namespace Api.Interfaces;

public interface IService
{
    IEnumerable<Koi> GetAll();
    Task<bool> Create(KoiCreateDto koi);
    Task<bool> Delete(Guid id);
    Task<Koi?> Get(Guid id);
    Task<bool> Update(Koi koi);
}