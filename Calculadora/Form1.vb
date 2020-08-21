Public Class Form1
    Dim objEstadistica As New estadistica

    Private Sub btnMediaAritmetica_Click(sender As Object, e As EventArgs) Handles btnMediaAritmetica.Click
        txtRespuestaMedia.Text = objEstadistica.calcularMedia(txtserie.Text.Split(","))
        txtRespuestaVarianza.Text = objEstadistica.calcularVarianza(txtserie.Text.Split(","))
        txtRespuestaDesvTipica.Text = objEstadistica.caclularDesvTipica(txtserie.Text.Split(","))
    End Sub
End Class

