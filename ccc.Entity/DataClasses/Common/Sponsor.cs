using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class Sponsor
    {
        public Sponsor()
        {
            Seasons = new HashSet<SponsorSeasonXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }

        public virtual ICollection<SponsorSeasonXref> Seasons { get; set; }
    }
}
