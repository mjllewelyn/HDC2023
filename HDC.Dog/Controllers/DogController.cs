using Microsoft.AspNetCore.Mvc;

namespace HDC.Dog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        private readonly ILogger<DogController> _logger;

        public DogController(ILogger<DogController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/Dog1")]
        public IActionResult Dog1()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Dog1.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Dog2")]
        public IActionResult Dog2()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Dog2.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Dog3")]
        public IActionResult Dog3()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Dog3.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Health")]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}