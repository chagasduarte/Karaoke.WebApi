using Karaoke.Domain.Dtos;
using Karaoke.Domain.Enums;
using Karaoke.Domain.Models.Playlist;

namespace Karaoke.Domain.Interfaces
{
    public interface IPlaylistService
    {
        Task<ResponseGeneric<Playlist>> GetPlaylist(Youtube youtube);
    }
}
