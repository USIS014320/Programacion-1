Public Class Form1
    Private Sub btnCalcular_Click_1(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Num1, Num2, respuesta As Double
        Num1 = txtnum1.Text
        Num2 = txtnum2.Text


        If optSuma.Checked Then
            txtRespuesta.Text = Num1 + Num2
        End If

        If optResta.Checked Then
            txtRespuesta.Text = Num1 - Num2
        End If

        If optMultiplicar.Checked Then
            txtRespuesta.Text = Num1 * Num2
        End If

        If optDividir.Checked Then
            txtRespuesta.Text = Num1 / Num2
        End If

        If optMod.Checked Then
            txtRespuesta.Text = Num1 Mod Num2
        End If

        If optPorcentaje.Checked Then
            txtRespuesta.Text = Num1 * Num2 / 100
        End If

        If optExponenciacion.Checked Then
            txtRespuesta.Text = Num1 ^ Num2
        End If
        '...
        Select Case cboOperaciones.SelectedIndex
            Case 1 'Suma
                txtRespuesta.Text = Num1 + Num2

            Case 2 'Resta
                txtRespuesta.Text = Num1 - Num2

            Case 3 'Multiplicación
                txtRespuesta.Text = Num1 * Num2

            Case 4 'División
                txtRespuesta.Text = Num1 / Num2

            Case 5 'MOD
                txtRespuesta.Text = Num1 Mod Num2

            Case 6 ' Porcentaje
                txtRespuesta.Text = Num1 * Num2 / 100

            Case 7 ' Exponenciación
                txtRespuesta.Text = Num1 ^ Num2
        End Select

    End Sub
End Class