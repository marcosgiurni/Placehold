using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Placehold.Services
{
    public class ImageService : IImageService
    {
        public Stream CreateImage(string dimensions)
        {
            var sizes = dimensions.Split("x");

            var width = Convert.ToInt32(sizes[0]);
            var heigth = Convert.ToInt32(sizes[1]);

            var image = new Bitmap(width, heigth);

            for (var x = 0; x < image.Width; x++)
            {
                for (var y = 0; y < image.Height; y++)
                {
                    image.SetPixel(x, y, Color.LightGray);
                }
            }

            var memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            memoryStream.Position = 0;

            return memoryStream;
        }
    }
}
