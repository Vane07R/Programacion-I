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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.optsuma = New System.Windows.Forms.RadioButton()
        Me.optresta = New System.Windows.Forms.RadioButton()
        Me.optmultipli = New System.Windows.Forms.RadioButton()
        Me.optdivi = New System.Windows.Forms.RadioButton()
        Me.optporcentaje = New System.Windows.Forms.RadioButton()
        Me.optexponente = New System.Windows.Forms.RadioButton()
        Me.optmodulo = New System.Windows.Forms.RadioButton()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(97, 55)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(41, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "Num 1:"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(144, 52)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 2
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(334, 53)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 3
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(84, 116)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(103, 40)
        Me.btncalcular.TabIndex = 4
        Me.btncalcular.Text = "Calcular "
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'optsuma
        '
        Me.optsuma.AutoSize = True
        Me.optsuma.Location = New System.Drawing.Point(250, 53)
        Me.optsuma.Name = "optsuma"
        Me.optsuma.Size = New System.Drawing.Size(31, 17)
        Me.optsuma.TabIndex = 5
        Me.optsuma.TabStop = True
        Me.optsuma.Text = "+"
        Me.optsuma.UseVisualStyleBackColor = True
        '
        'optresta
        '
        Me.optresta.AutoSize = True
        Me.optresta.Location = New System.Drawing.Point(250, 71)
        Me.optresta.Name = "optresta"
        Me.optresta.Size = New System.Drawing.Size(28, 17)
        Me.optresta.TabIndex = 6
        Me.optresta.TabStop = True
        Me.optresta.Text = "-"
        Me.optresta.UseVisualStyleBackColor = True
        '
        'optmultipli
        '
        Me.optmultipli.AutoSize = True
        Me.optmultipli.Location = New System.Drawing.Point(250, 94)
        Me.optmultipli.Name = "optmultipli"
        Me.optmultipli.Size = New System.Drawing.Size(29, 17)
        Me.optmultipli.TabIndex = 7
        Me.optmultipli.TabStop = True
        Me.optmultipli.Text = "*"
        Me.optmultipli.UseVisualStyleBackColor = True
        '
        'optdivi
        '
        Me.optdivi.AutoSize = True
        Me.optdivi.Location = New System.Drawing.Point(250, 117)
        Me.optdivi.Name = "optdivi"
        Me.optdivi.Size = New System.Drawing.Size(30, 17)
        Me.optdivi.TabIndex = 8
        Me.optdivi.TabStop = True
        Me.optdivi.Text = "/"
        Me.optdivi.UseVisualStyleBackColor = True
        '
        'optporcentaje
        '
        Me.optporcentaje.AutoSize = True
        Me.optporcentaje.Location = New System.Drawing.Point(248, 139)
        Me.optporcentaje.Name = "optporcentaje"
        Me.optporcentaje.Size = New System.Drawing.Size(79, 17)
        Me.optporcentaje.TabIndex = 9
        Me.optporcentaje.TabStop = True
        Me.optporcentaje.Text = "Porcentaje "
        Me.optporcentaje.UseVisualStyleBackColor = True
        '
        'optexponente
        '
        Me.optexponente.AutoSize = True
        Me.optexponente.Location = New System.Drawing.Point(249, 162)
        Me.optexponente.Name = "optexponente"
        Me.optexponente.Size = New System.Drawing.Size(31, 17)
        Me.optexponente.TabIndex = 10
        Me.optexponente.TabStop = True
        Me.optexponente.Text = "^"
        Me.optexponente.UseVisualStyleBackColor = True
        '
        'optmodulo
        '
        Me.optmodulo.AutoSize = True
        Me.optmodulo.Location = New System.Drawing.Point(248, 185)
        Me.optmodulo.Name = "optmodulo"
        Me.optmodulo.Size = New System.Drawing.Size(33, 17)
        Me.optmodulo.TabIndex = 11
        Me.optmodulo.TabStop = True
        Me.optmodulo.Text = "%"
        Me.optmodulo.UseVisualStyleBackColor = True
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(287, 55)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(41, 13)
        Me.lblnum2.TabIndex = 1
        Me.lblnum2.Text = "Num 2:"
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(440, 59)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(70, 13)
        Me.lblrespuesta.TabIndex = 12
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.optmodulo)
        Me.Controls.Add(Me.optexponente)
        Me.Controls.Add(Me.optporcentaje)
        Me.Controls.Add(Me.optdivi)
        Me.Controls.Add(Me.optmultipli)
        Me.Controls.Add(Me.optresta)
        Me.Controls.Add(Me.optsuma)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents optsuma As RadioButton
    Friend WithEvents optresta As RadioButton
    Friend WithEvents optmultipli As RadioButton
    Friend WithEvents optdivi As RadioButton
    Friend WithEvents optporcentaje As RadioButton
    Friend WithEvents optexponente As RadioButton
    Friend WithEvents optmodulo As RadioButton
    Friend WithEvents lblnum2 As Label
    Friend WithEvents lblrespuesta As Label
End Class
