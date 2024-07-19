using System.Text.Json.Serialization;

namespace Karaoke.Domain.Dtos.PlaylistDTO
{
    public class ThumbnailsResponse
    {
        public ThumbnailResponse Default { get; set; }
        public ThumbnailResponse Medium { get; set; }
        public ThumbnailResponse high { get; set; }
    }
}
