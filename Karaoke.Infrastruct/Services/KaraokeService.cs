using AutoMapper;
using Karaoke.Domain.Dtos;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.Infrastruct.Services
{
    public class KaraokeService : IKaraokeService
    {
        private readonly IMapper _mapper;
        private readonly IKaraokeRest _karaokeRest;

        public KaraokeService(IMapper mapper, IKaraokeRest karaokeRest)
        {
            _mapper = mapper;
            _karaokeRest = karaokeRest;
        }   

        public async Task<ResponseGeneric<IEnumerable<Karaokes>>> GetKaraokes()
        {
            var karaokes = await _karaokeRest.GetKaraokes();
            return _mapper.Map<ResponseGeneric<IEnumerable<Karaokes>>>(karaokes);
        }

        public async Task<ResponseGeneric<Karaokes>> GetKaraokes(int id)
        {
            var karaokes = await _karaokeRest.GetKaraokes(id);
            return _mapper.Map<ResponseGeneric<Karaokes>>(karaokes);
        }

        public async Task<ResponseGeneric<Karaokes>> PutKaraokes(int id, Karaokes karaokes)
        {
            await _karaokeRest.PutKaraokes(id, karaokes);
            return _mapper.Map<ResponseGeneric<Karaokes>>(karaokes);
        }
        public async Task<ResponseGeneric<Karaokes>> PostKaraokes(Karaokes karaoke)
        {
            var karaokes = _karaokeRest.PostKaraokes(karaoke);
            return _mapper.Map<ResponseGeneric<Karaokes>>(karaokes);
        }
        public async Task<ResponseGeneric<Karaokes>> DeleteKaraokes(int id)
        {
            var karaokes = _karaokeRest.DeleteKaraokes(id);
            return _mapper.Map<ResponseGeneric<Karaokes>>(karaokes);
        }
    }
}
