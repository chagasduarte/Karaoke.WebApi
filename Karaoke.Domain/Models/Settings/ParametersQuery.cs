using Karaoke.Domain.Models.Object;

namespace Karaoke.Domain.Models.Settings
{
    public class ParametersQuery : ObjectQuery
    {
        public string? key { get; set; }
        public string? playlistId { get; set; }
        public string? part { get; set; }
        public int? maxResults { get; set; }
    }
}
