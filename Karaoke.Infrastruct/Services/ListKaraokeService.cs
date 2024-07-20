using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.Infrastruct.Services
{
    public class ListKaraokeService : IListKaraokeService
    {
        public List<Karaokes> listKaraokes;
        public ListKaraokeService() 
        { 
            listKaraokes = new List<Karaokes>();
        }

        public Karaokes AddKaraoke(Karaokes karaoke)
        {
            listKaraokes.Add(karaoke);
            return karaoke;
        }

        public void OrdenaLista()
        {
            listKaraokes.OrderBy(x => x.Ordem);
        }

        public Boolean RemoveKaraoke(Karaokes karaoke)
        {
            return listKaraokes.Remove(karaoke);
        }


    }
}
