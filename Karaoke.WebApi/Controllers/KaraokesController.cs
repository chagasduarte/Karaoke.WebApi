using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Karaoke.Domain.Models.Karaoke;
using Karaoke.Infrastruct.Context;

namespace Karaoke.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaraokesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public KaraokesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Karaokes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Karaokes>>> GetKaraokes()
        {
            return await _context.Karaokes.ToListAsync();
        }

        // GET: api/Karaokes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Karaokes>> GetKaraokes(int id)
        {
            var karaokes = await _context.Karaokes.FindAsync(id);

            if (karaokes == null)
            {
                return NotFound();
            }

            return karaokes;
        }

        // PUT: api/Karaokes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKaraokes(int id, Karaokes karaokes)
        {
            if (id != karaokes.Id)
            {
                return BadRequest();
            }

            _context.Entry(karaokes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KaraokesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Karaokes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Karaokes>> PostKaraokes(Karaokes karaokes)
        {
            _context.Karaokes.Add(karaokes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKaraokes", new { id = karaokes.Id }, karaokes);
        }

        // DELETE: api/Karaokes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKaraokes(int id)
        {
            var karaokes = await _context.Karaokes.FindAsync(id);
            if (karaokes == null)
            {
                return NotFound();
            }

            _context.Karaokes.Remove(karaokes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KaraokesExists(int id)
        {
            return _context.Karaokes.Any(e => e.Id == id);
        }
    }
}
