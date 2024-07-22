using Karaoke.Domain.Dtos;
using Karaoke.Domain.Models.Players;

namespace Karaoke.Domain.Interfaces
{
    public interface IPlayerService
    {
        public Task<ResponseGeneric<IEnumerable<Player>>> GetPlayer();
        public Task<ResponseGeneric<Player>> GetPlayer(int id);
        public Task<ResponseGeneric<Player>> PutPlayer(int id, Player player);
        public Task<ResponseGeneric<Player>> PostPlayer(Player player);
        public Task<ResponseGeneric<Player>> DeletePlayer(int id);
    }
}
