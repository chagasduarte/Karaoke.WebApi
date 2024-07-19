using System.Text.Json.Serialization;

namespace Karaoke.Domain.Models.Playlist
{
    public class Thumbnails
    {
        [JsonPropertyName("Default_")]
        public Thumbnail Default { get; set; }

        [JsonPropertyName("Medium")]
        public Thumbnail Medium { get; set; }

        [JsonPropertyName("high")]
        public Thumbnail high { get; set; }
    }
}
