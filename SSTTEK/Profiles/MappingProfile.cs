using AutoMapper;
using SSTTEK.DTO;
using SSTTEK.Entity;

namespace SSTTEK.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<SaveUpdateBookDTO, Books>();
        CreateMap<Books, SaveUpdateBookDTO>();
    }
}
