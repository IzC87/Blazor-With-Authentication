using AutoMapper;
using Medieval.Shared;
using Server.Models;

namespace Server.Configuration
{
    public class MappedProfiles : Profile
    {
        public MappedProfiles()
        {
            CreateMap<Game, GameModel>()
                .ReverseMap();

            CreateMap<Resources, ResourceModel>()
                .ReverseMap();
        }
    }
}