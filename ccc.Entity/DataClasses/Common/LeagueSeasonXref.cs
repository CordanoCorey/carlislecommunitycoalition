using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class LeagueSeasonXref
    {
        public LeagueSeasonXref()
        {
            Games = new HashSet<Game>();
            Players = new HashSet<PlayerLeagueSeasonXref>();
            Teams = new HashSet<TeamLeagueSeasonXref>();
        }

        public int Id { get; set; }
        public int LeagueId { get; set; }
        public int SeasonId { get; set; }

        public virtual League League { get; set; }
        public virtual Season Season { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<PlayerLeagueSeasonXref> Players { get; set; }
        public virtual ICollection<TeamLeagueSeasonXref> Teams { get; set; }
    }
}
