﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculator")]
    public interface ICalculator
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformAdd", ReplyAction="http://tempuri.org/ICalculator/PerformAddResponse")]
        double PerformAdd(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformAdd", ReplyAction="http://tempuri.org/ICalculator/PerformAddResponse")]
        System.Threading.Tasks.Task<double> PerformAddAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformSubtract", ReplyAction="http://tempuri.org/ICalculator/PerformSubtractResponse")]
        double PerformSubtract(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformSubtract", ReplyAction="http://tempuri.org/ICalculator/PerformSubtractResponse")]
        System.Threading.Tasks.Task<double> PerformSubtractAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformMultiply", ReplyAction="http://tempuri.org/ICalculator/PerformMultiplyResponse")]
        double PerformMultiply(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformMultiply", ReplyAction="http://tempuri.org/ICalculator/PerformMultiplyResponse")]
        System.Threading.Tasks.Task<double> PerformMultiplyAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformDivide", ReplyAction="http://tempuri.org/ICalculator/PerformDivideResponse")]
        double PerformDivide(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/PerformDivide", ReplyAction="http://tempuri.org/ICalculator/PerformDivideResponse")]
        System.Threading.Tasks.Task<double> PerformDivideAsync(double number1, double number2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ICalculatorChannel : ServiceReference1.ICalculator, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<ServiceReference1.ICalculator>, ServiceReference1.ICalculator
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CalculatorClient() : 
                base(CalculatorClient.GetDefaultBinding(), CalculatorClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICalculator.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorClient(EndpointConfiguration endpointConfiguration) : 
                base(CalculatorClient.GetBindingForEndpoint(endpointConfiguration), CalculatorClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CalculatorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CalculatorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public double PerformAdd(double number1, double number2)
        {
            return base.Channel.PerformAdd(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> PerformAddAsync(double number1, double number2)
        {
            return base.Channel.PerformAddAsync(number1, number2);
        }
        
        public double PerformSubtract(double number1, double number2)
        {
            return base.Channel.PerformSubtract(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> PerformSubtractAsync(double number1, double number2)
        {
            return base.Channel.PerformSubtractAsync(number1, number2);
        }
        
        public double PerformMultiply(double number1, double number2)
        {
            return base.Channel.PerformMultiply(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> PerformMultiplyAsync(double number1, double number2)
        {
            return base.Channel.PerformMultiplyAsync(number1, number2);
        }
        
        public double PerformDivide(double number1, double number2)
        {
            return base.Channel.PerformDivide(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> PerformDivideAsync(double number1, double number2)
        {
            return base.Channel.PerformDivideAsync(number1, number2);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICalculator))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICalculator))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7243/Service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CalculatorClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICalculator);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CalculatorClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICalculator);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICalculator,
        }
    }
}
