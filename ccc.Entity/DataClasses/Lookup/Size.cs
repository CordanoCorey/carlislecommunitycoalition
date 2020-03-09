using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class Size : ILookup
    {
        public Size()
        {
            Players = new HashSet<PlayerLeagueSeasonXref>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PlayerLeagueSeasonXref> Players { get; set; }
    }
}
