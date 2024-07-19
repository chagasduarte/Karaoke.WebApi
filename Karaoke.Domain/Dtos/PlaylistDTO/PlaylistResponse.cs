using System.Text.Json.Serialization;

namespace Karaoke.Domain.Dtos.PlaylistDTO
{
    public class PlaylistResponse
    {
        public string etag { get; set; }
        public IEnumerable<VideoResponse> items { get; set; }
        public string kind { get; set; }
    }
}
