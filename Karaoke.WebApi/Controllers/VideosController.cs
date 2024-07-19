using Karaoke.Domain.Enums;
using Karaoke.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Karaoke.WebApi.Controllers
{
    public class VideosController : ControllerBase
    {
        private readonly IVideoService _videoService;
        public VideosController(IVideoService service)
        {
            _videoService = service;
        }

        [HttpGet("videos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchVideos(string search)
        {
            var response = await _videoService.SearchVideos(Youtube.search, search);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }
        [HttpGet("video/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetVideoById(string id)
        {
            var response = await _videoService.GetVideoById(Youtube.videos, id);

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
