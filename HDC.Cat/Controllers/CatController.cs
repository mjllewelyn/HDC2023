using Microsoft.AspNetCore.Mvc;

namespace HDC.Cat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        private readonly ILogger<CatController> _logger;

        public CatController(ILogger<CatController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/Cat1")]
        public IActionResult Cat1()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Cat1.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Cat2")]
        public IActionResult Cat2()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Cat2.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Cat3")]
        public IActionResult Cat3()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Images/Cat3.jpg");
            return File(b, "image/jpeg");
        }

        [HttpGet("~/Health")]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}