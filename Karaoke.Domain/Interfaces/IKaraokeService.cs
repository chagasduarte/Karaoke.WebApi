using Karaoke.Domain.Dtos;
using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.Domain.Interfaces
{
    public interface IKaraokeService
    {
        public Task<ResponseGeneric<IEnumerable<Karaokes>>> GetKaraokes();
        public Task<ResponseGeneric<Karaokes>> GetKaraokes(int id);
        public Task<ResponseGeneric<Karaokes>> PutKaraokes(int id, Karaokes karaokes);
        public Task<ResponseGeneric<Karaokes>> PostKaraokes(Karaokes karaokes);
        public Task<ResponseGeneric<Karaokes>> DeleteKaraokes(int id);

    }
}
