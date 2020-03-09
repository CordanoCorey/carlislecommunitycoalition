using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class Game
    {
        public Game()
        {
            Teams = new HashSet<GameTeamXref>();
        }

        public int Id { get; set; }
        public int LeagueSeasonId { get; set; }
        public int LocationId { get; set; }
        public DateTime StartTime { get; set; }

        public virtual LeagueSeasonXref LeagueSeason { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<GameTeamXref> Teams { get; set; }
    }
}
