using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Linq;

namespace SOAPAssignment.Models
{
    public class CalculatorServiceContract
    {
        [ServiceContract]
        public interface ICalculator
        {
            [OperationContract]
            double PerformAdd(double number1, double number2);

            [OperationContract]
            double PerformSubtract(double number1, double number2);

            [OperationContract]
            double PerformMultiply(double number1, double number2);

            [OperationContract]
            double PerformDivide(double number1, double number2);
        }
    }
}
