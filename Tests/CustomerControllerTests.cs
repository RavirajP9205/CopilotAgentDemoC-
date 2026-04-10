using Microsoft.AspNetCore.Mvc;
using Xunit;
using CopilotAgentDemoC.Controllers;
using CopilotAgentDemoC.Models;

namespace CopilotAgentDemoC.Tests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void UpdateEmail_ReturnsBadRequest_WhenCustomerIdMissing()
        {
            var controller = new CustomerController();
            var request = new CustomerRequest
            {
                CustomerId = string.Empty,
                Email = "test@example.com"
            };

            var result = controller.UpdateEmail(request);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void UpdateEmail_ReturnsOkResult_WhenRequestValid()
        {
            var controller = new CustomerController();
            var request = new CustomerRequest
            {
                CustomerId = "123",
                Email = "test@example.com"
            };

            var result = controller.UpdateEmail(request);
            var okResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<CustomerResponse>(okResult.Value);

            Assert.Equal("123", response.CustomerId);
            Assert.Equal("test@example.com", response.Email);
            Assert.Equal("Success", response.Status);
        }
    }
}
