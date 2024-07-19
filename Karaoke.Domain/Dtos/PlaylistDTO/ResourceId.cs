using System.Text.Json.Serialization;

namespace Karaoke.Domain.Dtos.PlaylistDTO
{
    public class ResourceIdResponse
    {
        public string kind { get; set; }
        public string videoId { get; set; }
    }
}
