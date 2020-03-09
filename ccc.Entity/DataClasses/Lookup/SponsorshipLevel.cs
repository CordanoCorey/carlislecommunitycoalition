using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class SponsorshipLevel : ILookup
    {
        public SponsorshipLevel()
        {
            SponsorSeasons = new HashSet<SponsorSeasonXref>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SponsorSeasonXref> SponsorSeasons { get; set; }
    }
}
