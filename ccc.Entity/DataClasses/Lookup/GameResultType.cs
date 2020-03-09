using System;
using System.Collections.Generic;

namespace ccc.Entity.DataClasses
{
    public partial class GameResultType : ILookup
    {
        public GameResultType()
        {
            GameTeams = new HashSet<GameTeamXref>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GameTeamXref> GameTeams { get; set; }
    }
}
