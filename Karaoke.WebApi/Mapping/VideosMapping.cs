using AutoMapper;
using Karaoke.Domain.Models.Playlist;
using Karaoke.Domain.Dtos.PlaylistDTO;

namespace Karaoke.WebApi.Mapping
{
    public class VideosMapping : Profile
    {
        public VideosMapping()
        {
            CreateMap<VideoResponse, Video>();
            CreateMap<Video, VideoResponse>();
        }
    }
}
