using AutoMapper;
using Common.Dtos;
using Data.Models;

namespace Common.MapperProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        } 
    }
}
