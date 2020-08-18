Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim Num1, Num2, respuesta As Double
        Num1 = txtnum1.Text
        Num2 = txtnum1.Text


        If optSuma.Checked Then
            txtrespuesta.Text = Num1 + Num2
        End If

        If optResta.Checked Then
            txtrespuesta.Text = Num1 - Num2
        End If

        If optMultiplicacion.Checked Then
            txtrespuesta.Text = Num1 * Num2
        End If

        If optDivision.Checked Then
            txtrespuesta.Text = Num1 / Num2
        End If

        If optMod.Checked Then
            txtrespuesta.Text = Num1 Mod Num2
        End If

        If optPorcentaje.Checked Then
            txtrespuesta.Text = Num1 * Num2 / 100
        End If

        If optExponenciacion.Checked Then
            txtrespuesta.Text = Num1 ^ Num2
        End If


    End Sub
End Class

