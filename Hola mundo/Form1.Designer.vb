<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lblntabla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblntabl = New System.Windows.Forms.Label()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblntabl
        '
        Me.lblntabl.AutoSize = True
        Me.lblntabl.Location = New System.Drawing.Point(59, 52)
        Me.lblntabl.Name = "lblntabl"
        Me.lblntabl.Size = New System.Drawing.Size(37, 13)
        Me.lblntabl.TabIndex = 0
        Me.lblntabl.Text = "Tabla:"
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(102, 49)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(100, 20)
        Me.txtntabla.TabIndex = 1
        '
        'lstTablas
        '
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.Location = New System.Drawing.Point(219, 39)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(159, 147)
        Me.lstTablas.TabIndex = 2
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(62, 109)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(151, 57)
        Me.btnProcesar.TabIndex = 3
        Me.btnProcesar.Text = "Generar Tabla"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblntabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 450)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.lblntabl)
        Me.Name = "lblntabla"
        Me.Text = "Tablas de Multiplicar "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblntabl As Label
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents lstTablas As ListBox
    Friend WithEvents btnProcesar As Button
End Class
