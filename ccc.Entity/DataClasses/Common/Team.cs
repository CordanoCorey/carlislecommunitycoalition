using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class Team
    {
        public Team()
        {
            Games = new HashSet<GameTeamXref>();
            Seasons = new HashSet<TeamLeagueSeasonXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }

        public virtual ICollection<GameTeamXref> Games { get; set; }
        public virtual ICollection<TeamLeagueSeasonXref> Seasons { get; set; }
    }
}
