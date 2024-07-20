using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.Domain.Interfaces
{
    public interface IListKaraokeService
    {
        public ListKaraoke AddKaraoke(ListKaraoke karaoke);
        public Boolean RemoveKaraoke(ListKaraoke karaokeId);
        public void OrdenaLista();
    }
}
