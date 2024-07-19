using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace Karaoke.Domain.Models.Playlist
{
    public class Playlist
    {
        [JsonPropertyName("kind")]
        public string? kind { get; set; }

        [JsonPropertyName("etag")]
        public string? etag { get; set; }

        [JsonPropertyName("nextPageToken")]
        public string? nextPageToken { get; set; }

        [JsonPropertyName("regionCode")]
        public string? regionCode { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo? pageInfo { get; set; }

        [JsonPropertyName("items")]
        public IEnumerable<Video>? items { get; set; }

        
    }
}
