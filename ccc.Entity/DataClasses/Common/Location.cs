using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class Location
    {
        public Location()
        {
            Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public int LocationTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual LocationType LocationType { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
