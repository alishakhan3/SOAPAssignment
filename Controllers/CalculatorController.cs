using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using SOAPAssignment.Models;

namespace SOAPAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        [HttpGet("Addition: {num1:double}, {num2:double}")]
        public async Task<double> PerformAddAsync(double num1, double num2)
        {
            ICalculator service = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await service.PerformAddAsync(num1, num2);
        }

        [HttpGet("Subtraction: {num1:double}, {num2:double}")]
        public async Task<double> PerformSubtractAsync(double num1, double num2)
        {
            ICalculator service = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await service.PerformSubtractAsync(num1, num2);
        }

        [HttpGet("Multiplication: {num1:double}, {num2:double}")]
        public async Task<double> PerformMultiplyAsync(double num1, double num2)
        {
            ICalculator service = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await service.PerformMultiplyAsync(num1, num2);
        }

        [HttpGet("Division: {num1:double}, {num2:double}")]
        public async Task<IActionResult> PerformDivideAsync(double num1, double num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Division by zero is not allowed");
            }
            ICalculator service = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            double result = await service.PerformDivideAsync(num1, num2);
            return Ok(result);
        }
    }
}
