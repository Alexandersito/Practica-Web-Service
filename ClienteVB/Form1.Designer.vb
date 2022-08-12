<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnInversa = New System.Windows.Forms.Button()
        Me.btnLogaritmo = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnValorAbsoluto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabaco and Channel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtNro1
        '
        Me.txtNro1.Location = New System.Drawing.Point(244, 91)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(100, 22)
        Me.txtNro1.TabIndex = 1
        Me.txtNro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNro2
        '
        Me.txtNro2.Location = New System.Drawing.Point(420, 91)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(100, 22)
        Me.txtNro2.TabIndex = 2
        Me.txtNro2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(119, 144)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(97, 42)
        Me.btnSuma.TabIndex = 3
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(334, 418)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(111, 67)
        Me.btnResultado.TabIndex = 13
        Me.btnResultado.Text = "Resultado"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(261, 144)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(97, 42)
        Me.btnResta.TabIndex = 14
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Location = New System.Drawing.Point(402, 144)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(113, 42)
        Me.btnMultiplicacion.TabIndex = 15
        Me.btnMultiplicacion.Text = "Multiplicacion"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(538, 144)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(97, 42)
        Me.btnDivision.TabIndex = 16
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnRaiz
        '
        Me.btnRaiz.Location = New System.Drawing.Point(187, 212)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(97, 42)
        Me.btnRaiz.TabIndex = 17
        Me.btnRaiz.Text = "Raiz"
        Me.btnRaiz.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Location = New System.Drawing.Point(334, 212)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(97, 42)
        Me.btnPotencia.TabIndex = 18
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnInversa
        '
        Me.btnInversa.Location = New System.Drawing.Point(471, 212)
        Me.btnInversa.Name = "btnInversa"
        Me.btnInversa.Size = New System.Drawing.Size(97, 42)
        Me.btnInversa.TabIndex = 19
        Me.btnInversa.Text = "Inversa"
        Me.btnInversa.UseVisualStyleBackColor = True
        '
        'btnLogaritmo
        '
        Me.btnLogaritmo.Location = New System.Drawing.Point(418, 276)
        Me.btnLogaritmo.Name = "btnLogaritmo"
        Me.btnLogaritmo.Size = New System.Drawing.Size(97, 42)
        Me.btnLogaritmo.TabIndex = 20
        Me.btnLogaritmo.Text = "Logaritmo"
        Me.btnLogaritmo.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(261, 276)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(97, 42)
        Me.btnFactorial.TabIndex = 21
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnValorAbsoluto
        '
        Me.btnValorAbsoluto.Location = New System.Drawing.Point(334, 349)
        Me.btnValorAbsoluto.Name = "btnValorAbsoluto"
        Me.btnValorAbsoluto.Size = New System.Drawing.Size(111, 42)
        Me.btnValorAbsoluto.TabIndex = 22
        Me.btnValorAbsoluto.Text = "ValorAbsoluto"
        Me.btnValorAbsoluto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 497)
        Me.Controls.Add(Me.btnValorAbsoluto)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnLogaritmo)
        Me.Controls.Add(Me.btnInversa)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnRaiz)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResultado As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnInversa As Button
    Friend WithEvents btnLogaritmo As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnValorAbsoluto As Button
End Class
