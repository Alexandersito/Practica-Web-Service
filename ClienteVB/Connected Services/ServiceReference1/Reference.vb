﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.WebService1Soap")>  _
    Public Interface WebService1Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function Suma(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function SumaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function Resta(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function RestaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function Multiplicacion(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function MultiplicacionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function Division(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function DivisionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Raiz", ReplyAction:="*")>  _
        Function Raiz(ByVal i As Double, ByVal n As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Raiz", ReplyAction:="*")>  _
        Function RaizAsync(ByVal i As Double, ByVal n As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function Potencia(ByVal b As Double, ByVal e As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function PotenciaAsync(ByVal b As Double, ByVal e As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Inversa", ReplyAction:="*")>  _
        Function Inversa(ByVal n As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Inversa", ReplyAction:="*")>  _
        Function InversaAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Factorial", ReplyAction:="*")>  _
        Function Factorial(ByVal n As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Factorial", ReplyAction:="*")>  _
        Function FactorialAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Logaritmo", ReplyAction:="*")>  _
        Function Logaritmo(ByVal n As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Logaritmo", ReplyAction:="*")>  _
        Function LogaritmoAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValorAbsoluto", ReplyAction:="*")>  _
        Function ValorAbsoluto(ByVal n As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValorAbsoluto", ReplyAction:="*")>  _
        Function ValorAbsolutoAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebService1SoapChannel
        Inherits ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebService1SoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.WebService1Soap)
        Implements ServiceReference1.WebService1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Suma(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference1.WebService1Soap.Suma
            Return MyBase.Channel.Suma(n1, n2)
        End Function
        
        Public Function SumaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.SumaAsync
            Return MyBase.Channel.SumaAsync(n1, n2)
        End Function
        
        Public Function Resta(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference1.WebService1Soap.Resta
            Return MyBase.Channel.Resta(n1, n2)
        End Function
        
        Public Function RestaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.RestaAsync
            Return MyBase.Channel.RestaAsync(n1, n2)
        End Function
        
        Public Function Multiplicacion(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference1.WebService1Soap.Multiplicacion
            Return MyBase.Channel.Multiplicacion(n1, n2)
        End Function
        
        Public Function MultiplicacionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.MultiplicacionAsync
            Return MyBase.Channel.MultiplicacionAsync(n1, n2)
        End Function
        
        Public Function Division(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference1.WebService1Soap.Division
            Return MyBase.Channel.Division(n1, n2)
        End Function
        
        Public Function DivisionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.DivisionAsync
            Return MyBase.Channel.DivisionAsync(n1, n2)
        End Function
        
        Public Function Raiz(ByVal i As Double, ByVal n As Double) As Double Implements ServiceReference1.WebService1Soap.Raiz
            Return MyBase.Channel.Raiz(i, n)
        End Function
        
        Public Function RaizAsync(ByVal i As Double, ByVal n As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.RaizAsync
            Return MyBase.Channel.RaizAsync(i, n)
        End Function
        
        Public Function Potencia(ByVal b As Double, ByVal e As Double) As Double Implements ServiceReference1.WebService1Soap.Potencia
            Return MyBase.Channel.Potencia(b, e)
        End Function
        
        Public Function PotenciaAsync(ByVal b As Double, ByVal e As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.PotenciaAsync
            Return MyBase.Channel.PotenciaAsync(b, e)
        End Function
        
        Public Function Inversa(ByVal n As Double) As Double Implements ServiceReference1.WebService1Soap.Inversa
            Return MyBase.Channel.Inversa(n)
        End Function
        
        Public Function InversaAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.InversaAsync
            Return MyBase.Channel.InversaAsync(n)
        End Function
        
        Public Function Factorial(ByVal n As Double) As Double Implements ServiceReference1.WebService1Soap.Factorial
            Return MyBase.Channel.Factorial(n)
        End Function
        
        Public Function FactorialAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.FactorialAsync
            Return MyBase.Channel.FactorialAsync(n)
        End Function
        
        Public Function Logaritmo(ByVal n As Double) As Double Implements ServiceReference1.WebService1Soap.Logaritmo
            Return MyBase.Channel.Logaritmo(n)
        End Function
        
        Public Function LogaritmoAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.LogaritmoAsync
            Return MyBase.Channel.LogaritmoAsync(n)
        End Function
        
        Public Function ValorAbsoluto(ByVal n As Double) As Double Implements ServiceReference1.WebService1Soap.ValorAbsoluto
            Return MyBase.Channel.ValorAbsoluto(n)
        End Function
        
        Public Function ValorAbsolutoAsync(ByVal n As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.WebService1Soap.ValorAbsolutoAsync
            Return MyBase.Channel.ValorAbsolutoAsync(n)
        End Function
    End Class
End Namespace