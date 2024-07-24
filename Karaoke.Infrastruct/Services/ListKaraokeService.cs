using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Karaoke;
using Karaoke.Domain.Models.Players;
using Karaoke.Infrastruct.Rest;

namespace Karaoke.Infrastruct.Services
{
    public class ListKaraokeService : IListKaraokeService
    {
        public readonly IPlayerRest _playrRest;
        public readonly IKaraokeRest _karaokeRest;

        public IEnumerable<Karaokes> ListKaraokes { get; set; }
        public IEnumerable<Player> ListPlayer { get; set; }

        public ListKaraokeService(IKaraokeRest karaokeRest, IPlayerRest playrRest) 
        {
            _playrRest = playrRest;
            _karaokeRest = karaokeRest;
        }

        public async void SetListKaraoke()
        {
            var response  = await _karaokeRest.GetKaraokes();
            ListKaraokes = response.ReturnData.Where(x => x.Ordem < 0);
        }

        public async void SetListPlayer()
        {
            var response = await _playrRest.GetPlayer();
            ListPlayer = response.ReturnData;
        }

        public void AddKaraoke(Karaokes karaokes)
        {
            Player player = new Player();
            
            Player newPlayer = ListPlayer.Where(x => x.Id == karaokes.PlayerId).First();

            for (int i = 0; i <= ListKaraokes.Count(); i++)
            {
                Karaokes k = ListKaraokes.Where(x => x.Id == i).First();

                player = ListPlayer.Where(x => x.Id == k.PlayerId).First();
                if ( player.QtdMusicasCanatda < newPlayer.QtdMusicasCanatda )
                {
                    _karaokeRest.PostKaraokes( karaokes );
                    karaokes.Ordem = k.Ordem;
                    AjusteOrdem(i);
                    return;
                }
            }
        }

        private void AjusteOrdem(int n)
        {
            for (int i = n; i <= ListKaraokes.Count(); i++)
            {
                ListKaraokes.ElementAt(i).Ordem++;
                _karaokeRest.PutKaraokes(ListKaraokes.ElementAt(i).Id, ListKaraokes.ElementAt(i));
            }

        }

    }
}
