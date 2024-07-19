using System.Text.Json.Serialization;

namespace Karaoke.Domain.Models.Playlist
{
    public class Video
    {
        [JsonPropertyName("kind")]
        public string? kind { get; set; }

        [JsonPropertyName("etag")]
        public string? etag { get; set; }

        private string? idStorage { get; set; }

        [JsonPropertyName("id")]
        public dynamic? id { get; set; }


        [JsonPropertyName("snippet")]
        public Snippet? snippet { get; set; }
    }
}
