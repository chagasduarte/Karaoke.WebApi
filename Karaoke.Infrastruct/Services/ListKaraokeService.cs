using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.Infrastruct.Services
{
    public class ListKaraokeService : IListKaraokeService
    {
        public List<ListKaraoke> listKaraokes;
        public ListKaraokeService() 
        { 
            listKaraokes = new List<ListKaraoke>();
        }

        public ListKaraoke AddKaraoke(ListKaraoke karaoke)
        {
            listKaraokes.Add(karaoke);
            return karaoke;
        }

        public void OrdenaLista()
        {
            listKaraokes.OrderBy(x => x.Ordem);
        }

        public Boolean RemoveKaraoke(ListKaraoke karaoke)
        {
            return listKaraokes.Remove(karaoke);
        }


    }
}
