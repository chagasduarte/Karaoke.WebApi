using System.Text.Json.Serialization;

namespace Karaoke.Domain.Models.Playlist
{
    public class ResourceId
    {
        [JsonPropertyName("kind")]
        public string? kind { get; set; }

        [JsonPropertyName("videoId")]
        public string? videoId { get; set; }

    }
}
