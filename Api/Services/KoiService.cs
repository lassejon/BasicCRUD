using Api.Dtos;
using Api.Interfaces;
using Api.Models;
using AutoMapper;

namespace Api.Services;

public class KoiService : IService
{
    private readonly IRepository _koiRepository;
    private readonly IMapper _mapper;

    public KoiService(IRepository koiRepository, IMapper mapper)
    {
        _koiRepository = koiRepository;
        _mapper = mapper;
    }
    
    public IEnumerable<Koi> GetAll()
    {
        return _koiRepository.GetAll().ToList();
    }

    public Task<bool> Create(KoiCreateDto koiDto)
    {
        var koi = _mapper.Map<Koi>(koiDto);
        koi.Id = new Guid();
        koi.Created = DateTime.Now;
        
        return _koiRepository.Create(koi);
    }

    public Task<bool> Delete(Guid id)
    {
        return _koiRepository.Delete(id);
    }

    public Task<Koi?> Get(Guid id)
    {
        return _koiRepository.Get(id);
    }

    public Task<bool> Update(Koi koi)
    {
        return _koiRepository.Update(koi);
    }
}