using Karaoke.Domain.Models.Settings;

namespace Karaoke.Domain.Models.Object
{
    public class SearchObject : ObjectQuery
    {
        public string? key { get; set; }
        public string? part { get; set; }
        public int? maxResults { get; set; }
        public string? q { get; set; }
        public SearchObject(ParametersQuery objectQuery, string query)
        {
            key = objectQuery.key;
            part = objectQuery.part;
            maxResults = objectQuery.maxResults;
            q = query;
        }
    }
}
