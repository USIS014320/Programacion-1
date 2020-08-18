Public Class Form1
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim ntabla, i As Byte
        ntabla = txttabla.Text

        lstTablas.Items.Clear()

        If ntabla <= 12 Then
            For i = 1 To 10
                lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            lstTablas.Items.Add("Solo tablas menores o iguales a 12.")
        End If



    End Sub
End Class