using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.Domain.Interfaces
{
    public interface IListKaraokeService
    {
        public Karaokes AddKaraoke(Karaokes karaoke);
        public Boolean RemoveKaraoke(Karaokes karaokeId);
        public void OrdenaLista();
    }
}
