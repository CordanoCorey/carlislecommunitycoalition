using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class Stat
    {
        public int Id { get; set; }
        public int GamePlayerId { get; set; }
        public int StatCategoryId { get; set; }
        public int? Total { get; set; }

        public virtual GamePlayerXref GamePlayer { get; set; }
        public virtual StatCategory StatCategory { get; set; }
    }
}
