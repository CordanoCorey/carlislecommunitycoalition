using ccc.API.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ccc.API.Features.Players
{
    [Route("api/players")]
    public class PlayersController : BaseController
    {
        private readonly IPlayersService _service;
        public PlayersController(IPlayersService service, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPlayers([FromQuery] PlayerQueryModel query)
        {
            var results = query == null ? _service.GetPlayers() : _service.GetPlayers(query);
            //var results = _service.GetPlayers(query);
            return Ok(results);
        }

        [HttpGet("~/api/seasons/{seasonId}/players")]
        public IActionResult GetSeasonPlayers(int seasonId, [FromQuery] PlayerQueryModel query)
        {
            var results = query == null ? _service.GetPlayerSeasons(seasonId) : _service.GetPlayerSeasons(seasonId, query);
            //var results = _service.GetPlayers(seasonId);
            return Ok(results);
        }

        [HttpPost("{id}/seasons")]
        public IActionResult AddPlayerSeason(int id, [FromBody] PlayerSeasonModel player)
        {
            var result = _service.AddPlayerSeason(player);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddPlayer(int id, [FromBody] PlayerModel player)
        {
            var result = _service.AddPlayer(Audit(player));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePlayer(int id, [FromBody] PlayerModel player)
        {
            var result = _service.UpdatePlayer(AuditExisting(player));
            return Ok(result);
        }
    }
}
