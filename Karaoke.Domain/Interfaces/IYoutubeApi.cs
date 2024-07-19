using Karaoke.Domain.Dtos;
using Karaoke.Domain.Enums;
using Karaoke.Domain.Models.Playlist;

namespace Karaoke.Domain.Interfaces
{
    public interface IYoutubeApi
    {
        Task<ResponseGeneric<Playlist>> GetPlaylist(Youtube youtube);
        Task<ResponseGeneric<Playlist>> SearchVideos(Youtube youtube, string search);
        Task<ResponseGeneric<Playlist>> GetVideoById(Youtube youtube, string id);
    }
}
