using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using CopilotAgentDemoC.Models;
using CopilotAgentDemoC.Services;

namespace CopilotAgentDemoC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : BaseApiController
    {
        private readonly CustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController() : this(NullLogger<CustomerController>.Instance)
        {
        }

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerService = new CustomerService();
        }

        [HttpPost("update-email")]
        public IActionResult UpdateEmail([FromBody] CustomerRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.CustomerId))
            {
                _logger.LogWarning("Invalid update request: missing CustomerId.");
                return HandleError("CustomerId is required.");
            }

            try
            {
                _logger.LogInformation("Updating email for CustomerId {CustomerId}", request.CustomerId);
                var response = _customerService.UpdateCustomerEmail(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while updating customer email.");
                return HandleError("Unable to update customer email.");
            }
        }
    }
}
