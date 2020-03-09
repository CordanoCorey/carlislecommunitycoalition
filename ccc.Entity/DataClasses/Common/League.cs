using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class League
    {
        public League()
        {
            Seasons = new HashSet<LeagueSeasonXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LeagueSeasonXref> Seasons { get; set; }
    }
}
