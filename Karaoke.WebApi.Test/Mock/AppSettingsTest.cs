using Karaoke.Domain.Models.Settings;

namespace Karaoke.WebApi.Test.Mock
{
    public class AppSettingsTest
    {
        public AppSettingsTest() { }
        public AplicationSettings GetAppSettingsPreenchido()
        {
            AplicationSettings settings = new AplicationSettings();
            settings.youtubeApi = "https://www.googleapis.com/youtube/v3";
            settings.parametersQuery = new ParametersQuery();
            settings.parametersQuery.playlistId = "PLESrnPp1eqbUkUvycvjnFk6WkMDVv7t6v";
            settings.parametersQuery.key = "AIzaSyBgliuzy_VqjnYAHmwPlYY9E68qoZDdwQ4";
            settings.parametersQuery.maxResults = 5;
            settings.parametersQuery.part = "snippet";

            return settings;
        } 
    }
}
