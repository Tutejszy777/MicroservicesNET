using Microsoft.AspNetCore.Mvc;

namespace MicroserviceCommand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestConnection()
        {
            Console.WriteLine("Post in a COMMAND SERVICE");

            return Ok("Test from command srvce");
        }
    }
}
