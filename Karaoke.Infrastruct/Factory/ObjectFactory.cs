using Karaoke.Domain.Enums;
using Karaoke.Domain.Models.Settings;
using Karaoke.Domain.Models.Object;

namespace Karaoke.Infrastruct.Factory
{
    public class ObjectFactory
    {
        public ObjectQuery GetObjectQuery(Youtube youtube, ParametersQuery objectQuery, string search = "")
        {
            switch (youtube)
            {
                case Youtube.playlistItems:
                    return new PlaylistItemsObject(objectQuery);

                case Youtube.videos:
                    return new VideoObject(objectQuery, search);

                case Youtube.search:
                    return new SearchObject(objectQuery, search);
            }

            return new DefaultObject();
        }
    }
}
