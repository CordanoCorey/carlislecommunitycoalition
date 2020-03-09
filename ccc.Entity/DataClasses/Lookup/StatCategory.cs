using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class StatCategory : ILookup
    {
        public StatCategory()
        {
            Stats = new HashSet<Stat>();
            TeamStats = new HashSet<TeamStat>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public bool IsActive { get; set; }
        public int SportId { get; set; }

        public virtual ICollection<Stat> Stats { get; set; }
        public virtual ICollection<TeamStat> TeamStats { get; set; }
    }
}
