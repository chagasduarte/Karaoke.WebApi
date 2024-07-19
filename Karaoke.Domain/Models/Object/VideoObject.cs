using Karaoke.Domain.Models.Settings;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Karaoke.Domain.Models.Object
{
    public class VideoObject : ObjectQuery
    {
        public string? key { get; set; }
        public string? part { get; set; }
        public int? maxResults { get; set; }
        public string? id { get; set; }

        public VideoObject(ParametersQuery objectQuery, string idVideo)
        {
            key = objectQuery.key;
            part = objectQuery.part;
            maxResults = objectQuery.maxResults;
            id = idVideo;
        }
    }
}
