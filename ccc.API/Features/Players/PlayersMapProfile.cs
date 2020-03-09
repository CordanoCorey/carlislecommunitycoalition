using AutoMapper;
using ccc.Entity.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccc.API.Features.Players
{
    public class PlayersMapProfile : Profile
    {
        public PlayersMapProfile()
        {
            CreateMap<Player, PlayerModel>()
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Contact == null ? s.Email : s.Contact.Email))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.Contact == null ? null : s.Contact.PhoneNumber))
            .ReverseMap()
            ;

            CreateMap<PlayerLeagueSeasonXref, PlayerSeasonModel>()
            .ReverseMap()
            ;
        }
    }
}