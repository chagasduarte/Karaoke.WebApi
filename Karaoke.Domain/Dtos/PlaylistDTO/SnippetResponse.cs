using System.Text.Json.Serialization;

namespace Karaoke.Domain.Dtos.PlaylistDTO
{
    public class SnippetResponse
    {
        public string? channelId { get; set; }
        public string? channelTitle { get; set; }
        public string? description { get; set; }
        public string? playlistId { get; set; }
        public int position { get; set; }
        public DateTime publishedAt { get; set; }
        public ResourceIdResponse resourceId { get; set; }
        public ThumbnailsResponse thumbnails { get; set; }
        public string title { get; set; }
        public string videoOwnerChannelId { get; set; }
        public string videoOwnerChannelTitle { get; set; }

    }
}
