using CopilotAgentDemoC.Constants;
using CopilotAgentDemoC.Models;

namespace CopilotAgentDemoC.Services
{
    public class CustomerService
    {
        public CustomerResponse UpdateCustomerEmail(CustomerRequest request)
        {
            return new CustomerResponse
            {
                CustomerId = request.CustomerId,
                Email = request.Email,
                Status = ApiConstants.SuccessStatus
            };
        }
    }
}
