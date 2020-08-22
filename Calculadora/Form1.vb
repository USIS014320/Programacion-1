Public Class Form1

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim m1, m2, m3, m4 As Int64

        m1 = cboDe.SelectedIndex
        m2 = cboA.SelectedIndex

        m3 = cboDe1.SelectedIndex
        m4 = cboA1.SelectedIndex



        If m1 = 0 And m2 = 1 Then
            txtrespuesta.Text = txtEntradab.Text / 60
        Else
            If m1 = 0 And m2 = 2 Then
                txtrespuesta.Text = txtEntradab.Text / 3600
            Else
                If m1 = 0 And m2 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 86400
                Else
                    If m1 = 0 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 604800
                    Else
                        If m1 = 0 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 1210000.0
                        Else
                            If m1 = 0 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text / 2628000.0
                            Else
                                If m1 = 0 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 315400000.0
                                Else
                                    If m1 = 0 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 15760000.0
                                    Else
                                        If m1 = 0 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 31540000.0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 1 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 60
        Else
            If m1 = 1 And m2 = 2 Then
                txtrespuesta.Text = txtEntradab.Text / 60
            Else
                If m1 = 1 And m2 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 1440
                Else
                    If m1 = 1 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 10080
                    Else
                        If m1 = 1 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 20160
                        Else
                            If m1 = 1 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text / 43800
                            Else
                                If m1 = 1 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 5256000.0
                                Else
                                    If m1 = 1 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 262800
                                    Else
                                        If m1 = 1 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 525600
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 2 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 3600
        Else
            If m1 = 2 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 60
            Else
                If m1 = 2 And m2 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 24
                Else
                    If m1 = 2 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 168
                    Else
                        If m1 = 2 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 360
                        Else
                            If m1 = 2 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text / 730
                            Else
                                If m1 = 2 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 87600
                                Else
                                    If m1 = 2 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1008
                                    Else
                                        If m1 = 2 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 8760
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 3 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 86400
        Else
            If m1 = 3 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 1440
            Else
                If m1 = 3 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 24
                Else
                    If m1 = 3 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 7
                    Else
                        If m1 = 3 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 14
                        Else
                            If m1 = 3 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text / 30.417
                            Else
                                If m1 = 3 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 3650
                                Else
                                    If m1 = 3 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 182.5
                                    Else
                                        If m1 = 3 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 365
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 4 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 604800
        Else
            If m1 = 4 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 10080
            Else
                If m1 = 4 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 168
                Else
                    If m1 = 4 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 7
                    Else
                        If m1 = 4 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 2
                        Else
                            If m1 = 4 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text / 4.345
                            Else
                                If m1 = 4 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 541
                                Else
                                    If m1 = 4 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 260700
                                    Else
                                        If m1 = 4 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 52.143
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 5 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 1210000.0
        Else
            If m1 = 5 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 20160
            Else
                If m1 = 5 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 360
                Else
                    If m1 = 5 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 14
                    Else
                        If m1 = 5 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 2
                        Else
                            If m1 = 5 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text / 2.173
                            Else
                                If m1 = 5 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 261
                                Else
                                    If m1 = 5 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 362
                                    Else
                                        If m1 = 5 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 26.071
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 6 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 2628000.0
        Else
            If m1 = 6 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 43800
            Else
                If m1 = 6 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 730
                Else
                    If m1 = 6 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 30.417
                    Else
                        If m1 = 6 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 4.345
                        Else
                            If m1 = 6 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 2.173
                            Else
                                If m1 = 6 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text / 120
                                Else
                                    If m1 = 6 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text / 6
                                    Else
                                        If m1 = 6 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 12
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 7 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 315400000.0
        Else
            If m1 = 7 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 5256000.0
            Else
                If m1 = 7 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 87600
                Else
                    If m1 = 7 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 3650
                    Else
                        If m1 = 7 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 521
                        Else
                            If m1 = 7 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 261
                            Else
                                If m1 = 7 And m2 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text * 120
                                Else
                                    If m1 = 7 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 20
                                    Else
                                        If m1 = 7 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 10
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 8 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 2628000.0
        Else
            If m1 = 8 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 43800
            Else
                If m1 = 8 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 4380
                Else
                    If m1 = 8 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 182.5
                    Else
                        If m1 = 8 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 26.071
                        Else
                            If m1 = 8 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 13.035
                            Else
                                If m1 = 8 And m2 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text * 6

                                Else
                                    If m1 = 8 And m2 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text / 5
                                    Else
                                        If m1 = 8 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 2
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 9 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 31540000.0
        Else
            If m1 = 9 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 525600
            Else
                If m1 = 9 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 8760
                Else
                    If m1 = 9 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 365
                    Else
                        If m1 = 9 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 52.143
                        Else
                            If m1 = 9 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 26.071
                            Else
                                If m1 = 9 And m2 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text * 12
                                Else
                                    If m1 = 9 And m2 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text / 10
                                    Else
                                        If m1 = 9 And m2 = 8 Then
                                            txtrespuesta.Text = txtEntradab.Text * 2
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m3 = 0 And m4 = 1 Then
            txtrespuesta.Text = txtEntradab.Text * 2.205
        Else
            If m3 = 0 And m4 = 2 Then
                txtrespuesta.Text = txtEntradab.Text * 35.274
            Else
                If m3 = 0 And m4 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 100
                Else
                    If m3 = 0 And m4 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 1000
                    Else
                        If m3 = 0 And m4 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m3 = 0 And m4 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000
                            Else
                                If m3 = 0 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                Else
                                    If m3 = 0 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                    Else
                                        If m1 = 0 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5000
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 1 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 2.205
        Else
            If m3 = 1 And m4 = 2 Then
                txtrespuesta.Text = txtEntradab.Text * 16
            Else
                If m3 = 1 And m4 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 220
                Else
                    If m3 = 1 And m4 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 2205
                    Else
                        If m3 = 1 And m4 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m3 = 1 And m4 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 454
                            Else
                                If m3 = 1 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 453592
                                Else
                                    If m3 = 1 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 453600000.0
                                    Else
                                        If m3 = 1 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 2268
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 2 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 35.274
        Else
            If m3 = 2 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 16
            Else
                If m3 = 2 And m4 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 3527
                Else
                    If m3 = 2 And m4 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 35274
                    Else
                        If m3 = 2 And m4 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m3 = 2 And m4 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 28.35
                            Else
                                If m3 = 2 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 28350
                                Else
                                    If m3 = 2 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 28350000.0
                                    Else
                                        If m3 = 2 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 142
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 3 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 100
        Else
            If m3 = 3 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 220
            Else
                If m3 = 3 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 3527
                Else
                    If m3 = 3 And m4 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 10
                    Else
                        If m3 = 3 And m4 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m3 = 3 And m4 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 100000
                            Else
                                If m3 = 3 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 100000000.0
                                Else
                                    If m3 = 3 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 100000000000.0
                                    Else
                                        If m3 = 3 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 142
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 4 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 1000
        Else
            If m3 = 4 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 2205
            Else
                If m3 = 4 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 35274
                Else
                    If m3 = 4 And m4 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10
                    Else
                        If m3 = 4 And m4 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m3 = 4 And m4 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                            Else
                                If m3 = 4 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                Else
                                    If m3 = 4 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                                    Else
                                        If m3 = 4 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5000000.0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 5 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 1000
        Else
            If m3 = 5 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 2205
            Else
                If m3 = 5 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 35274
                Else
                    If m3 = 5 And m4 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10
                    Else
                        If m3 = 5 And m4 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m3 = 5 And m4 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                            Else
                                If m3 = 5 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                Else
                                    If m3 = 5 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                                    Else
                                        If m3 = 5 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5000000.0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 6 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 1000
        Else
            If m3 = 6 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 454
            Else
                If m3 = 6 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 28.35
                Else
                    If m3 = 6 And m4 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10
                    Else
                        If m3 = 6 And m4 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 10
                        Else
                            If m3 = 6 And m4 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text / 25
                            Else
                                If m3 = 6 And m4 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 100000000.0
                                Else
                                    If m3 = 6 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 100000000000.0
                                    Else
                                        If m3 = 6 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 7 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 1000000.0
        Else
            If m3 = 7 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 453592
            Else
                If m3 = 7 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 28350
                Else
                    If m3 = 7 And m4 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text / 100000000.0
                    Else
                        If m3 = 7 And m4 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                        Else
                            If m3 = 7 And m4 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text / 11.3398
                            Else
                                If m3 = 7 And m4 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1000
                                Else
                                    If m3 = 7 And m4 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                    Else
                                        If m3 = 7 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 200
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 8 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 1000000000.0
        Else
            If m3 = 8 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 453600000.0
            Else
                If m3 = 8 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 28350000.0
                Else
                    If m3 = 8 And m4 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text / 100000000000.0
                    Else
                        If m3 = 8 And m4 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000000000000.0
                        Else
                            If m3 = 8 And m4 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 453600000.0
                            Else
                                If m3 = 8 And m4 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                Else
                                    If m3 = 8 And m4 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1000
                                    Else
                                        If m3 = 8 And m4 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 200000
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m3 = 9 And m4 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 5000
        Else
            If m3 = 9 And m4 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 2268
            Else
                If m3 = 9 And m4 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 142
                Else
                    If m3 = 9 And m4 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text / 500000
                    Else
                        If m3 = 9 And m4 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 5000000.0
                        Else
                            If m3 = 9 And m4 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 2268
                            Else
                                If m3 = 9 And m4 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text / 5
                                Else
                                    If m3 = 9 And m4 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text * 200
                                    Else
                                        If m3 = 9 And m4 = 8 Then
                                            txtrespuesta.Text = txtEntradab.Text * 200000
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

End Class
