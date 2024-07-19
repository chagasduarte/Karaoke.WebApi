using AutoMapper;
using Karaoke.Domain.Dtos;
using Karaoke.Domain.Enums;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Playlist;

namespace Karaoke.Infrastruct.Services
{
    public class VideoService : IVideoService
    {

        private readonly IMapper _mapper;
        private readonly IYoutubeApi _youtubeApi;

        public VideoService(IYoutubeApi youtubeApi, IMapper mapper)
        {
            _youtubeApi = youtubeApi;
            _mapper = mapper;
        }

        public async Task<ResponseGeneric<Playlist>> SearchVideos(Youtube youtube,string search)
        {
      
            var videos = await _youtubeApi.SearchVideos(youtube, search);
            return _mapper.Map<ResponseGeneric<Playlist>>(videos);
            
        }
        public async Task<ResponseGeneric<Playlist>> GetVideoById(Youtube youtube,string id)
        {
            var videos = await _youtubeApi.GetVideoById(youtube, id);
            return _mapper.Map<ResponseGeneric<Playlist>>(videos);
        }
    }
}
