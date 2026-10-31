using Microsoft.AspNetCore.Mvc;

namespace SmartBiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            var responce = new
            {
                Application = "SmartBiz",
                Status = "Healthy",
                Message = "SmartBiz Api is running successfully."
            };
            return Ok(responce);
        }
    }
}
