using System.Threading.Tasks;
using Json.Patch;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("patchme")]
    public class TestPatchController : ControllerBase
    {
        [HttpPatch]
        public async Task<IActionResult> Patch(
            [FromBody] JsonPatch clockingPatch)
        {
            return Ok();
        }
    }
}
