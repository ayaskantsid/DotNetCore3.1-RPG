using AutoMapper;
using DotNetCore_RPG.Dtos.Character;
using DotNetCore_RPG.Models;

namespace DotNetCore_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
        }
    }
}