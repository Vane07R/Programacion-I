Public Class lblntabla
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As SByte

        ntabla = txtntabla.Text
        lstTablas.Items.Clear()
        If ntabla <= 12 Then
            For i = 1 To 10
                lstTablas.Items.Add(ntabla.ToString() + "X" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            lstTablas.Items.Add("Por favor ingrese solo tablas iguales o menores a 12")
        End If
    End Sub
End Class
