using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class Season : ILookup
    {
        public Season()
        {
            Leagues = new HashSet<LeagueSeasonXref>();
            Players = new HashSet<PlayerLeagueSeasonXref>();
            Sponsors = new HashSet<SponsorSeasonXref>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int SeasonTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<LeagueSeasonXref> Leagues { get; set; }
        public virtual ICollection<PlayerLeagueSeasonXref> Players { get; set; }
        public virtual ICollection<SponsorSeasonXref> Sponsors { get; set; }
    }
}
