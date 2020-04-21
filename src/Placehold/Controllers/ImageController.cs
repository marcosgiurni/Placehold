using Microsoft.AspNetCore.Mvc;
using Placehold.Services;

namespace Placehold.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [Route("{dimensions}")]
        public IActionResult Index(string dimensions)
        {
            var imagePath = _imageService.CreateImage(dimensions);

            return File(imagePath, "image/png");
        }
    }
}