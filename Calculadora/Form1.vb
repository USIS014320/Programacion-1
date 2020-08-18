Public Class Form1
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim ntabla, i As Int64
        i = 1
        ntabla = txttabla.Text

        lstTablas.Items.Clear()

        Do While i <= 10
            lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            i = i + 1
        Loop

    End Sub
End Class