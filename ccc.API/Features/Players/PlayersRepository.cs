using AutoMapper;
using ccc.API.Infrastructure;
using ccc.Entity.Context;
using ccc.Entity.DataClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ccc.API.Features.Players
{
    public interface IPlayersRepository : IBaseRepository<Player, PlayerModel>
    {
        IEnumerable<PlayerModel> SearchPlayers(PlayerQueryModel query);
    }
    public class PlayerLeagueSeasonComparer : IEqualityComparer<PlayerLeagueSeasonXref>
    {
        public bool Equals(PlayerLeagueSeasonXref x1, PlayerLeagueSeasonXref x2)
        {
            return x1.LeagueSeasonId == x2.LeagueSeasonId;
        }

        public int GetHashCode(PlayerLeagueSeasonXref obj)
        {
            return obj.Id;
        }
    }

    public class PlayersRepository : BaseRepository<CCCContext, Player, PlayerModel>, IPlayersRepository
    {
        public PlayersRepository(CCCContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public IEnumerable<PlayerModel> SearchPlayers(PlayerQueryModel query)
        {
            return FindBy(x => true)
            //.Take(query.Take)
            ;
        }

        public override PlayerModel Update(PlayerModel model)
        {
            var entity = _mapper.Map<Player>(model);
            var remove = FindEntityByKey(model.Id)?.Seasons.Except(entity.Seasons, new PlayerLeagueSeasonComparer()).ToList();
            _context.ChangeTracker.TrackGraph(entity, (EntityEntryGraphNode node) =>
            {
                var entry = node.Entry;
                entry.State = entry.IsKeySet ? EntityState.Modified : EntityState.Added;
            });
            foreach (var item in remove)
            {
                _context.Entry(item).State = EntityState.Deleted;
                //_context.Set<PlayerLeagueSeasonXref>().Remove(item);
            }
            Save();
            return Map(entity);
        }

        protected override IQueryable<Player> IncludeAll(IQueryable<Player> queryable)
        {
            return queryable
                .Include(x => x.Contact)
                .Include(x => x.Seasons)
            ;
        }

        protected override IQueryable<Player> Include(IQueryable<Player> queryable)
        {
            return queryable
                .Include(x => x.Contact)
                .Include(x => x.Seasons)
            ;
        }

        protected override IQueryable<Player> IncludeSingle(IQueryable<Player> queryable)
        {
            return queryable
                .Include(x => x.Contact)
                .Include(x => x.Seasons)
            ;
        }
    }
}
