using AutoMapper;
using karaoke.WebApi.Mapping;
using Karaoke.WebApi.Mapping;

namespace Karaoke.WebApi.Test.MapperTest
{
    public class MapperProfileTest
    {
        private MapperConfiguration Configuration()
        {
            return new MapperConfiguration(conf =>
            {
                conf.AddProfile(new PlaylistMapping());
                conf.AddProfile(new VideosMapping());
                conf.AddProfile(new YoutubeMapping());
            });
        }

        public IMapper GetMapper()
        {
            return Configuration().CreateMapper();
        }
    }
}
