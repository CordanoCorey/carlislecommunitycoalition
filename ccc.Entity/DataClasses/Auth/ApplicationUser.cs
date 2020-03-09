using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
    public partial class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            Players = new HashSet<Player>();
            Teams = new HashSet<TeamLeagueSeasonXref>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordResetCode { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<TeamLeagueSeasonXref> Teams { get; set; }
    }
}
