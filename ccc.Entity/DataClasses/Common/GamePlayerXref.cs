using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class GamePlayerXref
    {
        public GamePlayerXref()
        {
            Stats = new HashSet<Stat>();
        }

        public int Id { get; set; }
        public int GameTeamId { get; set; }
        public int PlayerId { get; set; }
        public string JerseyNumber { get; set; }

        public virtual GameTeamXref GameTeam { get; set; }
        public virtual Player Player { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
    }
}
