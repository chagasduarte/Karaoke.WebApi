using Karaoke.Infrastruct.Rest;
using Karaoke.WebApi.Test.Helper;
using System.Net;

namespace Karaoke.WebApi.Test.RestTest
{
    public class YoutubeApiRestTest
    {
        private readonly YoutubeApiRest _youtubeApiRest;
        public YoutubeApiRestTest()
        {
            _youtubeApiRest = new YoutubeApiRest(Helpper.GetUrlRequestHelper(),  new HttpClient());
        }

        [Fact]
        public void GetPlayList_DeveRetornarOk()
        {
            //Arrange
            //Action
            var response = _youtubeApiRest.GetPlaylist(Domain.Enums.Youtube.playlistItems);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(response.Result.StatusCode, HttpStatusCode.OK);
        }
    }
}
