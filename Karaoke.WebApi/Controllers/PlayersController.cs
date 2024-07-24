using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Players;
using Karaoke.Infrastruct.Context;
using Karaoke.Infrastruct.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Karaoke.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRest _playerService;

        public PlayersController(IPlayerRest playerService)
        {
            _playerService = playerService;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            var response = await _playerService.GetPlayer();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var response = await _playerService.GetPlayer(id);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // PUT: api/Players/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer(int id, Player player)
        {
            var response = await _playerService.PutPlayer(id, player);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // POST: api/Players
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {
            var response = await _playerService.PostPlayer(player);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var response = await _playerService.DeletePlayer(id);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }
    }
}
