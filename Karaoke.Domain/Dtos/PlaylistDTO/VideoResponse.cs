using System.Text.Json.Serialization;

namespace Karaoke.Domain.Dtos.PlaylistDTO
{
    public class VideoResponse
    {
        public string? kind { get; set; }
        public string? etag { get; set; }
        [JsonIgnore]
        public string? id { get; set; }
        public SnippetResponse? snippet { get; set; }
    }
}
