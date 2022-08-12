Public Class Form1
    'Declarar un objeto para acceder al servicio web
    Dim Servicio As New ServiceReference1.WebService1SoapClient
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'SUMA
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        'Declarar variables
        Dim Nro1, Nro2, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Suma(Nro1, Nro2)
        btnResultado.Text = Resultado.ToString
    End Sub

    'RESTA
    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        'Declarar variables
        Dim Nro1, Nro2, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Resta(Nro1, Nro2)
        btnResultado.Text = Resultado.ToString
    End Sub

    'MULTIPLICACION
    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        'Declarar variables
        Dim Nro1, Nro2, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Multiplicacion(Nro1, Nro2)
        btnResultado.Text = Resultado.ToString
    End Sub

    'DIVISION
    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        'Declarar variables
        Dim Nro1, Nro2, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Division(Nro1, Nro2)
        btnResultado.Text = Resultado.ToString
    End Sub

    'RAIZ
    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        'Declarar variables
        Dim Nro1, Nro2, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Raiz(Nro1, Nro2)
        btnResultado.Text = Resultado.ToString
    End Sub

    'POTENCIA
    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        'Declarar variables
        Dim Nro1, Nro2, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Potencia(Nro1, Nro2)
        btnResultado.Text = Resultado.ToString
    End Sub

    'INVERSA
    Private Sub btnInversa_Click(sender As Object, e As EventArgs) Handles btnInversa.Click
        'Declarar variables
        Dim Nro1, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Inversa(Nro1)
        btnResultado.Text = Resultado.ToString
    End Sub

    'FACTORIAL
    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        'Declarar variables
        Dim Nro1, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Factorial(Nro1)
        btnResultado.Text = Resultado.ToString
    End Sub

    'LOGARITMO
    Private Sub btnLogaritmo_Click(sender As Object, e As EventArgs) Handles btnLogaritmo.Click
        'Declarar variables
        Dim Nro1, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Logaritmo(Nro1)
        btnResultado.Text = Resultado.ToString
    End Sub

    'VALOR ABSOLUTO
    Private Sub btnValorAbsoluto_Click(sender As Object, e As EventArgs) Handles btnValorAbsoluto.Click
        'Declarar variables
        Dim Nro1, Resultado As Double
        'Leer datos
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.ValorAbsoluto(Nro1)
        btnResultado.Text = Resultado.ToString
    End Sub
End Class
