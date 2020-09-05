Public Class Form1

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
                txtRespuesta.Text = txtEntradab.Text * 0.698896
            Else
                If m1 = 3 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 1.19599
                Else
                    If m1 = 3 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 1
                    Else
                        If m1 = 3 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text / 628.86
                        Else
                            If m1 = 3 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text / 6988
                            Else
                                If m1 = 3 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text / 10000
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 4 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 6768.34687
        Else
            If m1 = 4 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 877.174247
            Else
                If m1 = 4 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 752.038
                Else
                    If m1 = 4 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 628.86
                    Else
                        If m1 = 4 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text / 1
                        Else
                            If m1 = 4 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text * 0.08926746167

                            Else
                                If m1 = 4 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text * 0.06288
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m1 = 5 And m2 = 0 Then
            txtRespuesta.Text = txtEntradab.Text * 75820.984975
        Else
            If m1 = 5 And m2 = 1 Then
                txtRespuesta.Text = txtEntradab.Text * 10000
            Else
                If m1 = 5 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 8424.5538861
                Else
                    If m1 = 5 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 7044
                    Else
                        If m1 = 5 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 10000 / 628.8634
                        Else
                            If m1 = 5 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text
                            Else
                                If m1 = 5 And m2 = 6 Then
                                    txtRespuesta.Text = txtEntradab.Text / 0.7044
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
                txtRespuesta.Text = txtEntradab.Text * 14285.71
            Else
                If m1 = 6 And m2 = 2 Then
                    txtRespuesta.Text = txtEntradab.Text * 11959.9
                Else
                    If m1 = 6 And m2 = 3 Then
                        txtRespuesta.Text = txtEntradab.Text * 10000
                    Else
                        If m1 = 6 And m2 = 4 Then
                            txtRespuesta.Text = txtEntradab.Text * 22.88
                        Else
                            If m1 = 6 And m2 = 5 Then
                                txtRespuesta.Text = txtEntradab.Text * 1.43
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

    Private Sub btbConvertirU_Click(sender As Object, e As EventArgs) Handles btbConvertirU.Click
        Dim libras, conver, i, cont As Int64
        libras = txtNúmero.Text
        conver = txtUnidad.Text

        If i = 0 Then
            i = libras \ conver
            cont = libras Mod conver
        End If
        txtRespuestaU.Text = i & "/" & cont
    End Sub
End Class