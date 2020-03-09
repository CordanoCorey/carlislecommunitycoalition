using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class PlayerLeagueSeasonXref
    {
        public PlayerLeagueSeasonXref()
        {
        }
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int LeagueSeasonId { get; set; }
        public int? JerseySizeId { get; set; }
        public string JerseyNumberChoice1 { get; set; }
        public string JerseyNumberChoice2 { get; set; }
        public string JerseyNumberChoice3 { get; set; }

        public virtual Player Player { get; set; }
        public virtual LeagueSeasonXref LeagueSeason { get; set; }
        public virtual Size JerseySize { get; set; }
    }
}
