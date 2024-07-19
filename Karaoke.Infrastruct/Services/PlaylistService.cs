using AutoMapper;
using Karaoke.Domain.Dtos;
using Karaoke.Domain.Enums;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Playlist;

namespace Karaoke.Infrastruct.Services
{
    public class PlaylistService : IPlaylistService
    {
        
        private readonly IMapper _mapper;
        private readonly IYoutubeApi _youtubeApi;

        public PlaylistService(IYoutubeApi youtubeApi, IMapper mapper)
        {
            _youtubeApi = youtubeApi;
            _mapper = mapper;
        }
        
        public async Task<ResponseGeneric<Playlist>> GetPlaylist(Youtube youtube)
        {
            var playlist = await _youtubeApi.GetPlaylist(youtube);
            return _mapper.Map<ResponseGeneric<Playlist>>(playlist);
        }

    }
}
