using AutoMapper;
using Karaoke.Domain.Models.Settings;
using Karaoke.Infrastruct.Rest;
using Karaoke.WebApi.Test.Mock;

namespace Karaoke.WebApi.Test.Helper
{
    public static class Helpper
    {
        private static AplicationSettings settings = new AppSettingsTest().GetAppSettingsPreenchido();

        private static IMapper mapper = new MapperTest.MapperProfileTest().GetMapper();

        public static GetUrlRequest GetUrlRequestHelper()
        {
            return new GetUrlRequest(settings, mapper);
        }
    }
}
