using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class SponsorSeasonXref
    {
        public SponsorSeasonXref()
        {
            Teams = new HashSet<TeamLeagueSeasonXref>();
        }

        public int Id { get; set; }
        public int SponsorId { get; set; }
        public int SeasonId { get; set; }
        public int? SponsorshipLevelId { get; set; }

        public virtual Season Season { get; set; }
        public virtual Sponsor Sponsor { get; set; }
        public virtual SponsorshipLevel SponsorshipLevel { get; set; }
        public virtual ICollection<TeamLeagueSeasonXref> Teams { get; set; }
    }
}
