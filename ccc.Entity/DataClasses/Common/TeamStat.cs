using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class TeamStat
    {
        public int Id { get; set; }
        public int GameTeamId { get; set; }
        public int StatCategoryId { get; set; }
        public int? Total { get; set; }

        public virtual GameTeamXref GameTeam { get; set; }
        public virtual StatCategory StatCategory { get; set; }
    }
}
