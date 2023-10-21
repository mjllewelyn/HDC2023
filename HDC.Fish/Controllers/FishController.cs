using Microsoft.AspNetCore.Mvc;

namespace HDC.Fish.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FishController : ControllerBase
    {
        private readonly ILogger<FishController> _logger;

        public FishController(ILogger<FishController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/Fish1")]
        public IActionResult Fish1()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Fish1.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Fish2")]
        public IActionResult Fish2()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Fish2.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Fish3")]
        public IActionResult Fish3()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Fish3.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Health")]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}