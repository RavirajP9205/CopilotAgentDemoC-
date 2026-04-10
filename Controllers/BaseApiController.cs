using Microsoft.AspNetCore.Mvc;

namespace CopilotAgentDemoC.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        protected IActionResult HandleError(string message)
        {
            return BadRequest(new { Error = message });
        }
    }
}
