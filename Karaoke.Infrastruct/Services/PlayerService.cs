using AutoMapper;
using Karaoke.Domain.Dtos;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;
using Karaoke.Domain.Models.Players;
using Karaoke.Infrastruct.Rest;

namespace Karaoke.Infrastruct.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IMapper _mapper;
        private readonly IPlayerRest _playerRest;

        public PlayerService(IMapper mapper, IPlayerRest playerRest)
        {
            _mapper = mapper;
            _playerRest = playerRest;
        }
       

        public async Task<ResponseGeneric<IEnumerable<Player>>> GetPlayer()
        {
            var karaokes = await _playerRest.GetPlayer();
            return _mapper.Map<ResponseGeneric<IEnumerable<Player>>>(karaokes);
        }

        public async Task<ResponseGeneric<Player>> GetPlayer(int id)
        {
            var karaokes = await _playerRest.GetPlayer(id);
            return _mapper.Map<ResponseGeneric<Player>>(karaokes);
        }

        public async Task<ResponseGeneric<Player>> PutPlayer(int id, Player player)
        {
            await _playerRest.PutPlayer(id, player);
            return _mapper.Map<ResponseGeneric<Player>>(player);
        }
        public async Task<ResponseGeneric<Player>> PostPlayer(Player player)
        {
            var karaokes = _playerRest.PostPlayer(player);
            return _mapper.Map<ResponseGeneric<Player>>(karaokes);
        }

        public async Task<ResponseGeneric<Player>> DeletePlayer(int id)
        {
            var karaokes = _playerRest.DeletePlayer(id);
            return _mapper.Map<ResponseGeneric<Player>>(karaokes);
        }
    }
}
