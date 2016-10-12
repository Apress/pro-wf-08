﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleMathServiceClient.MathService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ProWF", ConfigurationName="MathService.IMathService", SessionMode=System.ServiceModel.SessionMode.NotAllowed)]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ProWF/IMathService/DivideNumbers", ReplyAction="http://ProWF/IMathService/DivideNumbersResponse")]
        double DivideNumbers(double dividend, double divisor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMathServiceChannel : ConsoleMathServiceClient.MathService.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<ConsoleMathServiceClient.MathService.IMathService>, ConsoleMathServiceClient.MathService.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double DivideNumbers(double dividend, double divisor) {
            return base.Channel.DivideNumbers(dividend, divisor);
        }
    }
}