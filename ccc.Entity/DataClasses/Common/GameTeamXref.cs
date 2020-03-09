using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class GameTeamXref
    {
        public GameTeamXref()
        {
            TeamStats = new HashSet<TeamStat>();
        }

        public int Id { get; set; }
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public int? GameResultTypeId { get; set; }

        public virtual Game Game { get; set; }
        public virtual GameResultType GameResultType { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<GamePlayerXref> Players { get; set; }
        public virtual ICollection<TeamStat> TeamStats { get; set; }
    }
}
