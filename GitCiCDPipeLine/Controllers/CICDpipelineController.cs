using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitCiCDPipeLine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CICDpipelineController : ControllerBase
    {
        [HttpGet("GetNewDetails")]
        public IActionResult GetData()
        {
            return Ok("Hello from GetNewDetails");
        }
    
    // this is test case for git ci cd pipeline

    [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok("Hello from Test");
        }
    }
}
