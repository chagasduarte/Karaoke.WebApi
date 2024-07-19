using Karaoke.WebApi.Test.Mock;
using Karaoke.Infrastruct.Rest;
using Karaoke.Domain.Models.Settings;
using AutoMapper;
using Karaoke.Domain.Enums;

namespace Karaoke.WebApi.Test.RestTest
{
    public class GetUrlRequestTest
    {

        private GetUrlRequest getUrlRequest;
        public GetUrlRequestTest()
        {
            var settings = new AppSettingsTest().GetAppSettingsPreenchido();
            var mapper = new MapperTest.MapperProfileTest().GetMapper();
            getUrlRequest = new GetUrlRequest(settings, mapper);
        }

        [Fact]
        public void GetUrl_DeveRetornarUrlValidaparaPlaylistItems()
        {
            //Arrange

            //Action
            string urlResult = getUrlRequest.GetUrl(Youtube.playlistItems);

            //Assert
            Assert.True(Helper.GetUrlRequestHelper.IsValidUrl(urlResult));
        }

        [Fact]
        public void GetUrl_DeveRetornarUrlValidaParaVideos()
        {
            //Arrange

            //Action
            string urlResult = getUrlRequest.GetUrl(Youtube.videos, "-bd#DFsdf");

            //Assert
            Assert.True(Helper.GetUrlRequestHelper.IsValidUrl(urlResult));
        }

        [Fact]
        public void GetUrl_DeveRetornarUrlValidaParaSearch()
        {

            //Action
            string urlResult = getUrlRequest.GetUrl(Youtube.search, "Testando!23");

            //Assert
            Assert.True(Helper.GetUrlRequestHelper.IsValidUrl(urlResult));
        }

    }
}