using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class TeamLeagueSeasonXref
    {
        public TeamLeagueSeasonXref()
        {
        }
        public int Id { get; set; }
        public int CoachId { get; set; }
        public int ColorId { get; set; }
        public int LeagueSeasonId { get; set; }
        public int TeamId { get; set; }
        public int SponsorSeasonId { get; set; }

        public virtual ApplicationUser Coach { get; set; }
        public virtual Color Color { get; set; }
        public virtual LeagueSeasonXref LeagueSeason { get; set; }
        public virtual SponsorSeasonXref SponsorSeason { get; set; }
        public virtual Team Team { get; set; }
    }
}
