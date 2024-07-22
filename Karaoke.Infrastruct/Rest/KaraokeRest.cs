using Karaoke.Domain.Dtos;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;
using Karaoke.Infrastruct.Context;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Net;

namespace Karaoke.Infrastruct.Rest
{
    public class KaraokeRest: IKaraokeRest
    {
        private readonly AppDbContext _context;

        public KaraokeRest(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseGeneric<IEnumerable<Karaokes>>> GetKaraokes()
        {
            ResponseGeneric<IEnumerable<Karaokes>> response = new ResponseGeneric<IEnumerable<Karaokes>>();
            try
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = await _context.Karaokes.ToListAsync();
            }
            catch
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            return response;
        }

        public async Task<ResponseGeneric<Karaokes>> GetKaraokes(int id)
        {
            ResponseGeneric<Karaokes> response = new ResponseGeneric<Karaokes>();

            var karaokes = await _context.Karaokes.FindAsync(id);

            if (karaokes == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            else 
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = karaokes;
            }

            return response;
        }

        public async Task<ResponseGeneric<Karaokes>> PutKaraokes(int id, Karaokes karaokes)
        {
            ResponseGeneric<Karaokes> response = new ResponseGeneric<Karaokes>();

            if (id != karaokes.Id)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.ReturnError = new ExpandoObject();
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
                    response.StatusCode = HttpStatusCode.NotFound;
                    response.ReturnError = new ExpandoObject();
                }
                else
                {
                    response.StatusCode = HttpStatusCode.OK;
                    response.ReturnData = karaokes;
                }
            }

            return response;
        }

         public async Task<ResponseGeneric<Karaokes>> PostKaraokes(Karaokes karaokes)
        {
            ResponseGeneric<Karaokes> response = new ResponseGeneric<Karaokes>();
            try
            {
                _context.Karaokes.Add(karaokes);
                await _context.SaveChangesAsync();
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = karaokes;
            }
            catch
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            
            return response;
        }

        public async Task<ResponseGeneric<Karaokes>> DeleteKaraokes(int id)
        {
            ResponseGeneric<Karaokes> response = new ResponseGeneric<Karaokes>();

            var karaokes = await _context.Karaokes.FindAsync(id);
            if (karaokes == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            else
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = karaokes;
            }
            
            _context.Karaokes.Remove(karaokes);
            await _context.SaveChangesAsync();

            return response;
        }

        private bool KaraokesExists(int id)
        {
            return _context.Karaokes.Any(e => e.Id == id);
        }
    }
}
