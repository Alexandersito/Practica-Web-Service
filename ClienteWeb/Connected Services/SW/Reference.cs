﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWeb.SW {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SW.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClienteWeb.SW.HelloWorldResponse HelloWorld(ClienteWeb.SW.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWeb.SW.HelloWorldResponse> HelloWorldAsync(ClienteWeb.SW.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suma", ReplyAction="*")]
        double suma(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suma", ReplyAction="*")]
        System.Threading.Tasks.Task<double> sumaAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/resta", ReplyAction="*")]
        double resta(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/resta", ReplyAction="*")]
        System.Threading.Tasks.Task<double> restaAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicacion", ReplyAction="*")]
        double multiplicacion(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<double> multiplicacionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/divicion", ReplyAction="*")]
        double divicion(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/divicion", ReplyAction="*")]
        System.Threading.Tasks.Task<double> divicionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/raiz", ReplyAction="*")]
        double raiz(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/raiz", ReplyAction="*")]
        System.Threading.Tasks.Task<double> raizAsync(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/exponente", ReplyAction="*")]
        double exponente(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/exponente", ReplyAction="*")]
        System.Threading.Tasks.Task<double> exponenteAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/inversa", ReplyAction="*")]
        double inversa(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/inversa", ReplyAction="*")]
        System.Threading.Tasks.Task<double> inversaAsync(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/factorial", ReplyAction="*")]
        double factorial(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/factorial", ReplyAction="*")]
        System.Threading.Tasks.Task<double> factorialAsync(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/logaritmo", ReplyAction="*")]
        double logaritmo(double x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/logaritmo", ReplyAction="*")]
        System.Threading.Tasks.Task<double> logaritmoAsync(double x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/valorAbsoluto", ReplyAction="*")]
        double valorAbsoluto(double x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/valorAbsoluto", ReplyAction="*")]
        System.Threading.Tasks.Task<double> valorAbsolutoAsync(double x);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWeb.SW.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClienteWeb.SW.HelloWorldRequestBody Body) {
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
        public ClienteWeb.SW.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClienteWeb.SW.HelloWorldResponseBody Body) {
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
    public interface WebService1SoapChannel : ClienteWeb.SW.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ClienteWeb.SW.WebService1Soap>, ClienteWeb.SW.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWeb.SW.HelloWorldResponse ClienteWeb.SW.WebService1Soap.HelloWorld(ClienteWeb.SW.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClienteWeb.SW.HelloWorldRequest inValue = new ClienteWeb.SW.HelloWorldRequest();
            inValue.Body = new ClienteWeb.SW.HelloWorldRequestBody();
            ClienteWeb.SW.HelloWorldResponse retVal = ((ClienteWeb.SW.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWeb.SW.HelloWorldResponse> ClienteWeb.SW.WebService1Soap.HelloWorldAsync(ClienteWeb.SW.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.SW.HelloWorldResponse> HelloWorldAsync() {
            ClienteWeb.SW.HelloWorldRequest inValue = new ClienteWeb.SW.HelloWorldRequest();
            inValue.Body = new ClienteWeb.SW.HelloWorldRequestBody();
            return ((ClienteWeb.SW.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public double suma(double a, double b) {
            return base.Channel.suma(a, b);
        }
        
        public System.Threading.Tasks.Task<double> sumaAsync(double a, double b) {
            return base.Channel.sumaAsync(a, b);
        }
        
        public double resta(double a, double b) {
            return base.Channel.resta(a, b);
        }
        
        public System.Threading.Tasks.Task<double> restaAsync(double a, double b) {
            return base.Channel.restaAsync(a, b);
        }
        
        public double multiplicacion(double a, double b) {
            return base.Channel.multiplicacion(a, b);
        }
        
        public System.Threading.Tasks.Task<double> multiplicacionAsync(double a, double b) {
            return base.Channel.multiplicacionAsync(a, b);
        }
        
        public double divicion(double a, double b) {
            return base.Channel.divicion(a, b);
        }
        
        public System.Threading.Tasks.Task<double> divicionAsync(double a, double b) {
            return base.Channel.divicionAsync(a, b);
        }
        
        public double raiz(double a) {
            return base.Channel.raiz(a);
        }
        
        public System.Threading.Tasks.Task<double> raizAsync(double a) {
            return base.Channel.raizAsync(a);
        }
        
        public double exponente(double a, double b) {
            return base.Channel.exponente(a, b);
        }
        
        public System.Threading.Tasks.Task<double> exponenteAsync(double a, double b) {
            return base.Channel.exponenteAsync(a, b);
        }
        
        public double inversa(double a) {
            return base.Channel.inversa(a);
        }
        
        public System.Threading.Tasks.Task<double> inversaAsync(double a) {
            return base.Channel.inversaAsync(a);
        }
        
        public double factorial(double a) {
            return base.Channel.factorial(a);
        }
        
        public System.Threading.Tasks.Task<double> factorialAsync(double a) {
            return base.Channel.factorialAsync(a);
        }
        
        public double logaritmo(double x) {
            return base.Channel.logaritmo(x);
        }
        
        public System.Threading.Tasks.Task<double> logaritmoAsync(double x) {
            return base.Channel.logaritmoAsync(x);
        }
        
        public double valorAbsoluto(double x) {
            return base.Channel.valorAbsoluto(x);
        }
        
        public System.Threading.Tasks.Task<double> valorAbsolutoAsync(double x) {
            return base.Channel.valorAbsolutoAsync(x);
        }
    }
}