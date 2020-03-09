using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class LocationType : ILookup
    {
        public LocationType()
        {
            Locations = new HashSet<Location>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
