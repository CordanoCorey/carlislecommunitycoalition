using ccc.API.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccc.API.Features.Players
{
    public interface IPlayersService
    {
        IEnumerable<PlayerModel> GetPlayers();
        IEnumerable<PlayerModel> GetPlayers(PlayerQueryModel query);
        IEnumerable<PlayerSeasonModel> GetPlayerSeasons(int seasonId);
        IEnumerable<PlayerSeasonModel> GetPlayerSeasons(int seasonId, PlayerQueryModel query);
        PlayerModel GetPlayer(int id);
        PlayerModel AddPlayer(PlayerModel model);
        PlayerModel UpdatePlayer(PlayerModel model);
        PlayerModel AddPlayerSeason(PlayerSeasonModel model);
    }

    public class PlayersService : IPlayersService
    {
        private readonly IPlayersRepository _repo;
        private readonly IPlayerSeasonsRepository _playerSeasons;
        private readonly IUsersService _users;

        public PlayersService(IPlayersRepository repo, IPlayerSeasonsRepository playerSeasons, IUsersService users)
        {
            _repo = repo;
            _playerSeasons = playerSeasons;
            _users = users;
        }

        public PlayerModel AddPlayerSeason(PlayerSeasonModel model)
        {
            _playerSeasons.Insert(model);
            return GetPlayer(model.PlayerId);
        }

        public PlayerModel GetPlayer(int id)
        {
            return _repo.FindByKey(id);
        }

        public IEnumerable<PlayerModel> GetPlayers()
        {
            var all = _repo.All();
            return all;
        }

        public IEnumerable<PlayerSeasonModel> GetPlayerSeasons(int seasonId)
        {
            return _playerSeasons.FindBySeason(seasonId);
        }

        public IEnumerable<PlayerSeasonModel> GetPlayerSeasons(int seasonId, PlayerQueryModel query)
        {
            var players = GetPlayerSeasons(seasonId);
            return players;
        }

        public IEnumerable<PlayerModel> GetPlayers(PlayerQueryModel query)
        {
            var players = GetPlayers()
                .Where(x =>
                    (String.IsNullOrEmpty(query.FirstName) && String.IsNullOrEmpty(query.LastName) && String.IsNullOrEmpty(query.Email))
                    || (
                            (
                                (String.IsNullOrEmpty(query.FirstName)
                                || (!String.IsNullOrEmpty(x.FirstName) && x.FirstName.ToLower().StartsWith(query.FirstName.ToLower()))
                                || (!String.IsNullOrEmpty(x.Nickname) && x.Nickname.ToLower().StartsWith(query.FirstName.ToLower()))
                            )
                            && (String.IsNullOrEmpty(query.LastName) || (!String.IsNullOrEmpty(x.LastName) && x.LastName.ToLower().StartsWith(query.LastName.ToLower())))
                            && (String.IsNullOrEmpty(query.Email) || (!String.IsNullOrEmpty(x.Email) && x.Email.ToLower().StartsWith(query.Email.ToLower())))
                            )
                        )
                    )
                .Take(query.Take);
            return players;
        }

        public PlayerModel AddPlayer(PlayerModel model)
        {
            if (model.ContactId == null || model.ContactId == 0)
            {
                model.ContactId = _users.InsertOrUpdateUser(model.CreatedById, model.Email, model.PhoneNumber);
            }
            var inserted = _repo.Insert(model);
            return GetPlayer(inserted.Id);
        }

        public PlayerModel UpdatePlayer(PlayerModel model)
        {
            var updated = _repo.Update(model);
            return GetPlayer(updated.Id);
        }
    }
}
