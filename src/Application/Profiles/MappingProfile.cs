using Application.DTOs.DadJoke;
using AutoMapper;
using Domain;

namespace Application.Profiles;

public class MappingProfile : Profile
{
    /// <summary>
    /// Sets up the map between the Domain object and the DTO
    /// </summary>
    public MappingProfile()
    {
        //ReverseMap will create a two-way mapping between the source and the destination
        //This works because the properties have the same name on the objects. If the names
        //are different, we need to explicitly map those properties.
        CreateMap<DadJoke, DadJokeDTO>().ReverseMap();

        CreateMap<DadJoke, CreateDadJokeDTO>().ReverseMap();
    }
}
