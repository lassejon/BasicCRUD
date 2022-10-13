using Api.DbContext;
using Api.Interfaces;
using Api.Models;

namespace Api.Repositories;

public class KoiRepository : IRepository
{
    private readonly KoiDbContext _koiDbContext;

    public KoiRepository(KoiDbContext koiDbContext)
    {
        _koiDbContext = koiDbContext;
    }
    
    public IQueryable<Koi> GetAll()
    {
        return _koiDbContext.Kois;
    }

    public async Task<bool> Create(Koi koi)
    {
        try
        {
            await _koiDbContext.Kois.AddAsync(koi);
            return await SaveChanges();
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<bool> Delete(Guid id)
    {
        var koi = await _koiDbContext.Kois.FindAsync(id);
        if (koi == null)
        {
            return false;
        }

        _koiDbContext.Kois.Remove(koi);
        return await SaveChanges();
    }

    public async Task<Koi?> Get(Guid id)
    {
        return await _koiDbContext.Kois.FindAsync(id);
    }

    public async Task<bool> Update(Koi koi)
    {
        _koiDbContext.Kois.Update(koi);
        return await SaveChanges();
    }

    public async Task<bool> SaveChanges()
    {
        return await _koiDbContext.SaveChangesAsync() > 0;
    }
}