using System.ServiceModel;
using Microsoft.AspNetCore.Http.HttpResults;
using SOAPAssignment.Models;
using static SOAPAssignment.Models.CalculatorServiceContract;

namespace SOAPAssignment.Services
{
    public class CalculatorService : ICalculator
    {
        public double PerformAdd(double number1, double number2)
        {
            return number1 + number2;
        }

        public double PerformSubtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double PerformMultiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double PerformDivide(double number1, double number2)
        {
            if (number2 == 0)
                throw new FaultException("Cannot divide by 0");

            return number1 / number2;
        }
    }
}
