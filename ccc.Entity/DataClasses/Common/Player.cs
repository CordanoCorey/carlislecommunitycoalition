using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class Player
    {
        public Player()
        {
            Games = new HashSet<GamePlayerXref>();
            Seasons = new HashSet<PlayerLeagueSeasonXref>();
        }

        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ApplicationUser Contact { get; set; }
        public virtual ICollection<GamePlayerXref> Games { get; set; }
        public virtual ICollection<PlayerLeagueSeasonXref> Seasons { get; set; }
    }
}
