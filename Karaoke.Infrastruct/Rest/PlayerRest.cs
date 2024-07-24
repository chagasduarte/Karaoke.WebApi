using Karaoke.Domain.Dtos;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;
using Karaoke.Domain.Models.Players;
using Karaoke.Infrastruct.Context;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Net;

namespace Karaoke.Infrastruct.Rest
{
    public class PlayerRest : IPlayerRest
    {

        private readonly AppDbContext _context;

        public PlayerRest(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseGeneric<IEnumerable<Player>>> GetPlayer()
        {
            ResponseGeneric<IEnumerable<Player>> response = new ResponseGeneric<IEnumerable<Player>>();
            
            try
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = await _context.Players.ToListAsync();
            }
            catch
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            return response;
        }

        public async Task<ResponseGeneric<Player>> GetPlayer(int id)
        {
            ResponseGeneric<Player> response = new ResponseGeneric<Player>();

            var player = await _context.Players.FindAsync(id);

            if (player == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            else
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = player;
            }

            return response;
        }
        public async Task<ResponseGeneric<Player>> PutPlayer(int id, Player player)
        {
            ResponseGeneric<Player> response = new ResponseGeneric<Player>();

            if (id != player.Id)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.ReturnError = new ExpandoObject();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
                {
                    response.StatusCode = HttpStatusCode.NotFound;
                    response.ReturnError = new ExpandoObject();
                }
                else
                {
                    response.StatusCode = HttpStatusCode.OK;
                    response.ReturnData = player;
                }
            }

            return response;
        }
        public async Task<ResponseGeneric<Player>> PostPlayer(Player player)
        {
            ResponseGeneric<Player> response = new ResponseGeneric<Player>();
            try
            {
                _context.Players.Add(player);
                await _context.SaveChangesAsync();
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = player;
            }
            catch
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }

            return response;
        }

       
        public async Task<ResponseGeneric<Player>> DeletePlayer(int id)
        {
            ResponseGeneric<Player> response = new ResponseGeneric<Player>();

            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReturnError = new ExpandoObject();
            }
            else
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ReturnData = player;
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return response;
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.Id == id);
        }
    }
}
