using System.Text.Json.Serialization;

namespace Karaoke.Domain.Models.Playlist
{
    public class Snippet
    {
        [JsonPropertyName("channelId")]
        public string? channelId { get; set; }

        [JsonPropertyName("channelTitle")]
        public string? channelTitle { get; set; }

        [JsonPropertyName("description")]
        public string? description { get; set; }

        [JsonPropertyName("playlistId")]
        public string? playlistId { get; set; }

        [JsonPropertyName("position")]
        public int position { get; set; }

        [JsonPropertyName("publishedAt")]
        public DateTime publishedAt { get; set; }

        [JsonPropertyName("resourceId")]
        public ResourceId resourceId { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnails thumbnails { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("videoOwnerChannelId")]
        public string videoOwnerChannelId { get; set; }

        [JsonPropertyName("videoOwnerChannelTitle")]
        public string videoOwnerChannelTitle { get; set; }

    }
}
