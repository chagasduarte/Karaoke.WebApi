using Karaoke.Domain.Enums;

namespace Karaoke.Domain.Interfaces
{
    public interface IGetUrlRequest
    {
        string GetUrl(Youtube endpoint, string search = "");
    }
}
