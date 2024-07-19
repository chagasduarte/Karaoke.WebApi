using AutoMapper;
using Karaoke.Domain.Models.Object;
using Karaoke.Domain.Models.Settings;

namespace karaoke.WebApi.Mapping
{
    public class YoutubeMapping : Profile
    {
        public YoutubeMapping() 
        {
            CreateMap<PlaylistItemsObject, ParametersQuery>();
            CreateMap<SearchObject, ParametersQuery>();
            CreateMap<VideoObject, ParametersQuery>();
        }
    }
}
