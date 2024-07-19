using Karaoke.Domain.Interfaces;

namespace Karaoke.Domain.Models.Settings
{
    public class AplicationSettings
    {
        public string? youtubeApi { get; set; }
        public ParametersQuery? parametersQuery { get; set; }
    }
}
