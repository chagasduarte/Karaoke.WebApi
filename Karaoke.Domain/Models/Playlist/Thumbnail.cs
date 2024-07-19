using System.Text.Json.Serialization;

namespace Karaoke.Domain.Models.Playlist
{
    public class Thumbnail
    {
        [JsonPropertyName("height")]
        public int height { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}
