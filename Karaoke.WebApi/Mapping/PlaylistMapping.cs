using AutoMapper;
using Karaoke.Domain.Dtos;
using Karaoke.Domain.Models.Playlist;
using Karaoke.Domain.Dtos.PlaylistDTO;

namespace Karaoke.WebApi.Mapping
{
    public class PlaylistMapping : Profile
    {
        public PlaylistMapping() 
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<PlaylistResponse, Playlist>();
            CreateMap<Playlist, PlaylistResponse>();
        }

    }
}
