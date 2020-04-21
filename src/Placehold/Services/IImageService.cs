using System.IO;

namespace Placehold.Services
{
    public interface IImageService
    {
        Stream CreateImage(string dimensions);
    }
}
