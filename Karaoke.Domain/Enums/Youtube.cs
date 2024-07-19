using System.ComponentModel;

namespace Karaoke.Domain.Enums
{
    public enum Youtube
    {
        [Description("playlistItems")]
        playlistItems = 1,

        [Description("videos")]
        videos = 2,

        [Description("search")]
        search = 3
    }
}
