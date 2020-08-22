Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim Num1, Num2, respuesta As Double
        Num1 = txtnum1.Text
        Num2 = txtnum1.Text
        respuesta = txtrespuesta.Text

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

        Select Case cboOperaciones.SelectedIndex
            Case 0
                txtrespuesta.Text = Num1 + Num2
            Case 1
                txtrespuesta.Text = Num1 - Num2
            Case 2
                txtrespuesta.Text = Num1 * Num2
            Case 3
                txtrespuesta.Text = Num1 / Num2
            Case 4
                txtrespuesta.Text = Num1 Mod Num2
            Case 5
                txtrespuesta.Text = Num1 * Num2 / 100
            Case 6
                txtrespuesta.Text = Num1 ^ Num2

        End Select

    End Sub
End Class

