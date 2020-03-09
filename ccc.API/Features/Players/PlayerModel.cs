using ccc.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccc.API.Features.Players
{
    public class PlayerModel : BaseEntity
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? IsActive { get; set; }

        public IEnumerable<PlayerSeasonModel> Seasons { get; set; }
    }

    public class PlayerSeasonModel
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int LeagueSeasonId { get; set; }
        public int? JerseySizeId { get; set; }
        public string JerseyNumberChoice1 { get; set; }
        public string JerseyNumberChoice2 { get; set; }
        public string JerseyNumberChoice3 { get; set; }
    }

    public class PlayerQueryModel
    {
        public int Skip { get; set; } = 0;
        public virtual IEnumerable<string> Sort { get; set; }
        public int Take { get; set; } = 10;
        public string Term { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
