using System.Runtime.Serialization;

namespace SOAPAssignment.Models
{
    [DataContract]
    public class CalculatorDataContract
    {
        [DataMember]
        public double result { get; set; }
    }
}
