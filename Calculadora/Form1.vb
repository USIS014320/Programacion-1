Public Class Form1

    Dim objromanos = New conversor_romanos

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) 
        txtRespuestaC.Text = objromanos.convertir(txtNúmero.Text)
    End Sub


    Class conversor_romanos
        Dim romanos()() As String = {
        New String() {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
        New String() {"", "X", "XX", "XXX", "XL", "LV", "LXX", "LXXX", "XC"},
        New String() {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}
    }

        Dim u, d, c, temp As Integer

        Public Function convertir(ByVal num As Integer)

            u = num Mod 10
            c = num \ 100
            temp = num Mod 100
            d = temp \ 10
            Return romanos(2)(c) + romanos(1)(d) + romanos(0)(u)

        End Function
    End Class



    Private Sub btnConvertir_Click_1(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim m1, m2 As Int64

        m1 = cboDe.SelectedIndex
        m2 = cboA.SelectedIndex

        If m1 = 0 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 1
        Else
            If m1 = 0 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 0.13223088
            Else
                If m1 = 0 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text / 9
                Else
                    If m1 = 0 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text / 10.764
                    Else
                        If m1 = 0 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 0.00014775
                        Else
                            If m1 = 0 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text * 0.00001319
                            Else
                                If m1 = 0 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text / 107.639
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 1 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 7.521
        Else
            If m1 = 1 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 1
            Else
                If m1 = 1 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 0.8357
                Else
                    If m1 = 1 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 0.6987
                    Else
                        If m1 = 1 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 0.0011173378658
                        Else
                            If m1 = 1 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text * 0.000099741915105
                            Else
                                If m1 = 1 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text * 0.000070258205
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 2 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 9
        Else
            If m1 = 2 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 1.1900778849
            Else
                If m1 = 2 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 1
                Else
                    If m1 = 2 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text / 1.196
                    Else
                        If m1 = 2 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 0.001329719084
                        Else
                            If m1 = 2 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text * 0.00011870064736
                            Else
                                If m1 = 2 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text * 0.000083612736
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 3 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 10.764
        Else
            If m1 = 3 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 0
            Else
                If m1 = 3 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 1.196
                Else
                    If m1 = 3 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 1
                    Else
                        If m1 = 3 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text / 0
                        Else
                            If m1 = 3 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text / 0
                            Else
                                If m1 = 3 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text / 10.0
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 4 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 0
        Else
            If m1 = 4 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 0
            Else
                If m1 = 4 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 0
                Else
                    If m1 = 4 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 0
                    Else
                        If m1 = 4 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text / 0
                        Else
                            If m1 = 4 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text / 0
                            Else
                                If m1 = 4 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text / 0
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 5 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 0
        Else
            If m1 = 5 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 0
            Else
                If m1 = 5 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 0
                Else
                    If m1 = 5 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 0
                    Else
                        If m1 = 5 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 0
                        Else
                            If m1 = 5 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text / 0
                            Else
                                If m1 = 5 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text / 0
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 6 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 107.639
        Else
            If m1 = 6 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 0
            Else
                If m1 = 6 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 11.96
                Else
                    If m1 = 6 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 10.0
                    Else
                        If m1 = 6 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 0
                        Else
                            If m1 = 6 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text * 0
                            Else
                                If m1 = 6 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text * 1

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub
End Class
