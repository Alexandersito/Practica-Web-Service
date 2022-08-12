<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClienteWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cliente Web</h1>
            <h3>Tabaco & Channel</h3>
                <hr />
            <asp:Label ID="lnlNro1" Text="Número 1:" runat="server" />
            <asp:TextBox ID="txtNro1" runat="server" />
            <asp:Label ID="Label2" Text="Número 2:" runat="server"/>
            <asp:TextBox ID="txtNro2" runat="server" />
                <hr />
            <div>
                <asp:Button ID="btnResultado" Text="Resultado" runat="server" Font-Size="20px"/>
            </div>
                <hr />
            <asp:Button ID="btnSuma" Text="Suma" runat="server" Width="200px" OnClick="btnSuma_Click"/>
            <br />
            <asp:Button ID="btnResta" Text="Resta" runat="server" Width="200px" OnClick="btnResta_Click"/>
            <br />
            <asp:Button ID="btnMultiplicacion" Text="Multiplicacion" runat="server" Width="200px" OnClick="btnMultiplicacion_Click"/>
            <br />
            <asp:Button ID="btnDivision" Text="Division" runat="server" Width="200px" OnClick="btnDivision_Click"/>
            <br />
            <asp:Button ID="btnRaiz" Text="Raiz" runat="server" Width="200px" OnClick="btnRaiz_Click"/>
            <br />
            <asp:Button ID="btnPotencia" Text="Potencia" runat="server" Width="200px" OnClick="btnPotencia_Click"/>
            <br />
            <asp:Button ID="btnInversa" Text="Inversa" runat="server" Width="200px" OnClick="btnInversa_Click"/>
            <br />
            <asp:Button ID="btnFactorial" Text="Factorial" runat="server" Width="200px" OnClick="btnFactorial_Click"/>
            <br />
            <asp:Button ID="btnLogaritmo" Text="Logaritmo" runat="server" Width="200px" OnClick="btnLogaritmo_Click"/>
            <br />
            <asp:Button ID="btnValorAbsoluto" Text="Valor Absoluto" runat="server" Width="200px" OnClick="btnValorAbsoluto_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
