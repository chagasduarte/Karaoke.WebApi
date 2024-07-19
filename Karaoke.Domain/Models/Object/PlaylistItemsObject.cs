using Karaoke.Domain.Models.Settings;

namespace Karaoke.Domain.Models.Object
{
    public class PlaylistItemsObject : ObjectQuery
    {
        public string? key { get; set; }
        public string? playlistId { get; set; }
        public string? part { get; set; }
        public int? maxResults { get; set; }

        public PlaylistItemsObject(ParametersQuery objectQuery)
        {
            key = objectQuery.key;
            playlistId = objectQuery.playlistId;
            part = objectQuery.part;
            maxResults = objectQuery.maxResults;
        }
    }
}
