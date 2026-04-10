using Microsoft.AspNetCore.Mvc;
using CopilotAgentDemoC.Models;
using CopilotAgentDemoC.Services;

namespace CopilotAgentDemoC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : BaseApiController
    {
        private readonly CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        [HttpPost("update-email")]
        public IActionResult UpdateEmail([FromBody] CustomerRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.CustomerId))
            {
                return HandleError("CustomerId is required.");
            }

            var response = _customerService.UpdateCustomerEmail(request);
            return Ok(response);
        }
    }
}
