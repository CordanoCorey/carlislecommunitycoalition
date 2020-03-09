using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class Color : ILookup
    {
        public Color()
        {
            Teams = new HashSet<TeamLeagueSeasonXref>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TeamLeagueSeasonXref> Teams { get; set; }
    }
}
