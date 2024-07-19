using System.Text.Json.Serialization;

namespace Karaoke.Domain.Dtos.PlaylistDTO
{
    public class ThumbnailResponse
    {
        public int height { get; set; }
        public int width { get; set; }
        public string url { get; set; }
    }
}
