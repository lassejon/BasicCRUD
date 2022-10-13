using Api.Dtos;
using Api.Models;
using AutoMapper;

namespace Api.Profiles;

public class KoiProfile : Profile
{
    public KoiProfile()
    {
        CreateMap<KoiCreateDto, Koi>();
    }
}