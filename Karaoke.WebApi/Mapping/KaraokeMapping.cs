using AutoMapper;
using Karaoke.Domain.Dtos.PlaylistDTO;
using Karaoke.Domain.Dtos;
using Karaoke.Domain.Models.Karaoke;

namespace Karaoke.WebApi.Mapping
{
    public class KaraokeMapping : Profile
    {
        public KaraokeMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<KaraokeResponse, Karaokes>();
            CreateMap<Karaokes, KaraokeResponse>();
        }
    }
}
