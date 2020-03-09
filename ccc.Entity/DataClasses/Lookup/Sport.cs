using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class Sport : ILookup
    {
        public Sport()
        {
            Leagues = new HashSet<League>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<League> Leagues { get; set; }
    }
}
