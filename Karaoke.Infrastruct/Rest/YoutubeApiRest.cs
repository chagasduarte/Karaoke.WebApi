using Karaoke.Domain.Dtos;
using Karaoke.Domain.Enums;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Playlist;
using System.Dynamic;
using System.Text.Json;

namespace Karaoke.Infrastruct.Rest
{
    public class YoutubeApiRest : IYoutubeApi
    {
        private readonly IGetUrlRequest _getUrlRequest;
        private readonly HttpClient _httpClient;

        public YoutubeApiRest(IGetUrlRequest getUrlRequest, HttpClient http) 
        {
            _getUrlRequest = getUrlRequest;
            _httpClient = http;
        }

        public async Task<ResponseGeneric<Playlist>> GetPlaylist(Youtube youtube)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _getUrlRequest.GetUrl(youtube));

            var response = new ResponseGeneric<Playlist>();

           
            var responsePlaylist = await _httpClient.SendAsync(request);
            var contentResp = await responsePlaylist.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Playlist>(contentResp);

            response.StatusCode = responsePlaylist.StatusCode;

            if (responsePlaylist.IsSuccessStatusCode)
            {
                response.ReturnData = objResponse;
            }
            else
            {
                response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
            
            return response;
        }

        public async Task<ResponseGeneric<Playlist>> SearchVideos(Youtube youtube,string search)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _getUrlRequest.GetUrl(youtube, search));
            var response = new ResponseGeneric<Playlist>();

            var responseVideo = await _httpClient.SendAsync(request);
            var contentResp = await responseVideo.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Playlist>(contentResp);

            if (responseVideo.IsSuccessStatusCode) 
            {
                response.StatusCode = responseVideo.StatusCode;
                response.ReturnData = objResponse;
            }
            else
            {
                response.StatusCode = responseVideo.StatusCode;
                response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
            return response;
        }

        public async Task<ResponseGeneric<Playlist>> GetVideoById(Youtube youtube, string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _getUrlRequest.GetUrl(youtube, id));
            var response = new ResponseGeneric<Playlist>();

            var responseVideo = await _httpClient.SendAsync(request);
            var contentResp = await responseVideo.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Playlist>(contentResp);

            if (responseVideo.IsSuccessStatusCode)
            {
                response.StatusCode = responseVideo.StatusCode;
                response.ReturnData = objResponse;
            }
            else
            {
                response.StatusCode = responseVideo.StatusCode;
                response.ReturnError = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
            return response;
        }

    }
}
