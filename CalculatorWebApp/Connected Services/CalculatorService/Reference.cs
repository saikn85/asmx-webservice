//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWebApp.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubtractTwoNumber", ReplyAction="*")]
        decimal SubtractTwoNumber(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubtractTwoNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> SubtractTwoNumberAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplyTwoNumber", ReplyAction="*")]
        decimal MultiplyTwoNumber(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplyTwoNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> MultiplyTwoNumberAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DivideTwoNumber", ReplyAction="*")]
        decimal DivideTwoNumber(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DivideTwoNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> DivideTwoNumberAsync(decimal a, decimal b);
        
        // CODEGEN: Generating message contract since element name GetCalulationsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalulations", ReplyAction="*")]
        CalculatorWebApp.CalculatorService.GetCalulationsResponse GetCalulations(CalculatorWebApp.CalculatorService.GetCalulationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalulations", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.GetCalulationsResponse> GetCalulationsAsync(CalculatorWebApp.CalculatorService.GetCalulationsRequest request);
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalulationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalulations", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorWebApp.CalculatorService.GetCalulationsRequestBody Body;
        
        public GetCalulationsRequest() {
        }
        
        public GetCalulationsRequest(CalculatorWebApp.CalculatorService.GetCalulationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalulationsRequestBody {
        
        public GetCalulationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalulationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalulationsResponse", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorWebApp.CalculatorService.GetCalulationsResponseBody Body;
        
        public GetCalulationsResponse() {
        }
        
        public GetCalulationsResponse(CalculatorWebApp.CalculatorService.GetCalulationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCalulationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorWebApp.CalculatorService.ArrayOfString GetCalulationsResult;
        
        public GetCalulationsResponseBody() {
        }
        
        public GetCalulationsResponseBody(CalculatorWebApp.CalculatorService.ArrayOfString GetCalulationsResult) {
            this.GetCalulationsResult = GetCalulationsResult;
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
        
        public decimal SubtractTwoNumber(decimal a, decimal b) {
            return base.Channel.SubtractTwoNumber(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> SubtractTwoNumberAsync(decimal a, decimal b) {
            return base.Channel.SubtractTwoNumberAsync(a, b);
        }
        
        public decimal MultiplyTwoNumber(decimal a, decimal b) {
            return base.Channel.MultiplyTwoNumber(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> MultiplyTwoNumberAsync(decimal a, decimal b) {
            return base.Channel.MultiplyTwoNumberAsync(a, b);
        }
        
        public decimal DivideTwoNumber(decimal a, decimal b) {
            return base.Channel.DivideTwoNumber(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> DivideTwoNumberAsync(decimal a, decimal b) {
            return base.Channel.DivideTwoNumberAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorWebApp.CalculatorService.GetCalulationsResponse CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap.GetCalulations(CalculatorWebApp.CalculatorService.GetCalulationsRequest request) {
            return base.Channel.GetCalulations(request);
        }
        
        public CalculatorWebApp.CalculatorService.ArrayOfString GetCalulations() {
            CalculatorWebApp.CalculatorService.GetCalulationsRequest inValue = new CalculatorWebApp.CalculatorService.GetCalulationsRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.GetCalulationsRequestBody();
            CalculatorWebApp.CalculatorService.GetCalulationsResponse retVal = ((CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap)(this)).GetCalulations(inValue);
            return retVal.Body.GetCalulationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.GetCalulationsResponse> CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap.GetCalulationsAsync(CalculatorWebApp.CalculatorService.GetCalulationsRequest request) {
            return base.Channel.GetCalulationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.GetCalulationsResponse> GetCalulationsAsync() {
            CalculatorWebApp.CalculatorService.GetCalulationsRequest inValue = new CalculatorWebApp.CalculatorService.GetCalulationsRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.GetCalulationsRequestBody();
            return ((CalculatorWebApp.CalculatorService.CalulatorWebServiceSoap)(this)).GetCalulationsAsync(inValue);
        }
    }
}
