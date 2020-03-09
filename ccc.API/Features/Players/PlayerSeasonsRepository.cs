using AutoMapper;
using ccc.API.Infrastructure;
using ccc.Entity.Context;
using ccc.Entity.DataClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ccc.API.Features.Players
{
    public interface IPlayerSeasonsRepository : IBaseRepository<PlayerLeagueSeasonXref, PlayerSeasonModel>
    {
        IEnumerable<PlayerSeasonModel> FindBySeason(int seasonId);
    }

    public class PlayerSeasonsRepository : BaseRepository<CCCContext, PlayerLeagueSeasonXref, PlayerSeasonModel>, IPlayerSeasonsRepository
    {
        public PlayerSeasonsRepository(CCCContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public IEnumerable<PlayerSeasonModel> FindBySeason(int seasonId)
        {
            return FindBy(x => x.LeagueSeasonId == seasonId);
        }

        protected override IQueryable<PlayerLeagueSeasonXref> Include(IQueryable<PlayerLeagueSeasonXref> queryable)
        {
            return queryable
                .Include(x => x.Player)
            ;
        }

        protected override IQueryable<PlayerLeagueSeasonXref> IncludeSingle(IQueryable<PlayerLeagueSeasonXref> queryable)
        {
            return queryable
                .Include(x => x.Player)
            ;
        }
    }
}
