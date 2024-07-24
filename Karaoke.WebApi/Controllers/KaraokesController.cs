using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Karaoke.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaraokesController : ControllerBase
    {
        private readonly IKaraokeService _karaokeService;

        public KaraokesController(IKaraokeService karaokeService)
        {
            _karaokeService = karaokeService;
        }

        // GET: api/Karaokes
        [HttpGet]
        public async Task<ActionResult> GetKaraokes()
        {
            var response = await _karaokeService.GetKaraokes();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // GET: api/Karaokes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetKaraokes(int id)
        {
            var response = await _karaokeService.GetKaraokes(id);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // PUT: api/Karaokes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKaraokes(int id, Karaokes karaokes)
        {
            var response = await _karaokeService.PutKaraokes(id, karaokes);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // POST: api/Karaokes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Karaokes>> PostKaraokes(Karaokes karaokes)
        {
            var response = await _karaokeService.PostKaraokes(karaokes);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ReturnError);
            }
        }

        // DELETE: api/Karaokes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKaraokes(int id)
        {
            var response = await _karaokeService.DeleteKaraokes(id);

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
