﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWebApp.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.CalulatorWebServiceSoap")]
    public interface CalulatorWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CalculatorWebApp.CalculatorService.HelloWorldResponse HelloWorld(CalculatorWebApp.CalculatorService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.HelloWorldResponse> HelloWorldAsync(CalculatorWebApp.CalculatorService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTwoNumber", ReplyAction="*")]
        decimal AddTwoNumber(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTwoNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> AddTwoNumberAsync(decimal a, decimal b);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorWebApp.CalculatorService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CalculatorWebApp.CalculatorService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorWebApp.CalculatorService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CalculatorWebApp.CalculatorService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalulatorWebServiceSoapChannel : CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalulatorWebServiceSoapClient : System.ServiceModel.ClientBase<CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap>, CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap {
        
        public CalulatorWebServiceSoapClient() {
        }
        
        public CalulatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalulatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalulatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalulatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorWebApp.CalculatorService.HelloWorldResponse CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap.HelloWorld(CalculatorWebApp.CalculatorService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CalculatorWebApp.CalculatorService.HelloWorldRequest inValue = new CalculatorWebApp.CalculatorService.HelloWorldRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.HelloWorldRequestBody();
            CalculatorWebApp.CalculatorService.HelloWorldResponse retVal = ((CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.HelloWorldResponse> CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap.HelloWorldAsync(CalculatorWebApp.CalculatorService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.HelloWorldResponse> HelloWorldAsync() {
            CalculatorWebApp.CalculatorService.HelloWorldRequest inValue = new CalculatorWebApp.CalculatorService.HelloWorldRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.HelloWorldRequestBody();
            return ((CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public decimal AddTwoNumber(decimal a, decimal b) {
            return base.Channel.AddTwoNumber(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> AddTwoNumberAsync(decimal a, decimal b) {
            return base.Channel.AddTwoNumberAsync(a, b);
        }
    }
}
