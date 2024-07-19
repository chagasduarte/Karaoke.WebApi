using Karaoke.Domain.Enums;
using Karaoke.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Karaoke.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistService _playlistService;
        public PlaylistController(IPlaylistService service) 
        {
            _playlistService = service;
        }

        [HttpGet("playList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPlaylist()
        {
            var response = await _playlistService.GetPlaylist(Youtube.playlistItems);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
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
