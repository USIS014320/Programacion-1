Public Class Form1

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim m1, m2, m3, m4, m5, m6 As Int64
        Dim tipo1, tipo2 As Int64
        Dim almacenamiento1, almacenamiento2 As Int64


        m1 = cboDe.SelectedIndex
        m2 = cboA.SelectedIndex

        m3 = cboDe1.SelectedIndex
        m4 = cboA1.SelectedIndex

        m5 = cboDe2.SelectedIndex
        m6 = cboA2.SelectedIndex

        tipo1 = cbo1.SelectedIndex
        tipo2 = cbo2.SelectedIndex

        almacenamiento1 = cboalmacenamientoentrada.SelectedIndex
        almacenamiento2 = cboalmacenamientosalida.SelectedIndex


        Select Case cbo1.SelectedIndex
            Case 0
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 100
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 100000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 10
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 160934
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 91.44
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 30.48
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 2.54
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 10000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 185200
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 1
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 100
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1609
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1.094
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 3.281
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 39.37
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1852
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 2
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 100000
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1.609
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1094
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 3281
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 39370
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1.852
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 3
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text / 10
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000000.0
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1609000.0
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 914
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 305
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 25.4
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1852000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 4
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 160934
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1609
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1.609
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1609000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1760
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 5280
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 63360
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1609000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1.151
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 5
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 91.44
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 91.44 / 100
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 91.44 / 100000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 91.44 * 10
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 91.44 / 160934
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 91.44 / 30.48
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 91.44 / 2.54
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 91.44 * 10000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text * 91.44 / 185200
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 6
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 30.48
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 3.281
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 3281
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 305
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 5280
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 3
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 12
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 304800
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 6076
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 7
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 2.54
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 3937
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 39370
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 25.4
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 63360
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 36
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 12
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 25400
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 72913
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 8
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text / 10000
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000000.0
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1000
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1609000000.0
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 914400
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 304800
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 25400
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1852000000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 9
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 185200
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1852
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1.852
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1852000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1.151
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 2025
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 6076
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 72913
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1852000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
        End Select

        Select Case cboalmacenamientoentrada.SelectedIndex
            Case 0
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 8
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 8000
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 8192
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 8000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 8389000.0
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 8000000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 8590000000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 8000000000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 8.0E+15
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 1
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1024
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1049000.0
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1074000000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000000000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1.0E+15
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 2
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1024
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1000
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1049
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1074000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000000000000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 3
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8192
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1024
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1.024
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 977
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1024
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 976562
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1049000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 976600000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 976600000000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 4
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 977
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1.049
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 1000
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1074
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 5
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8389000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1049000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1049
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1024
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1.049
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 954
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1024
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 953674
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 953700000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 6
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 976563
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 954
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1.074
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 7
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8590000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1074000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1074000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1049000.0
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1074
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1024
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 1.074
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 931
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 931323
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 8
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000000000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 976600000.0
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 953674
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 1000
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 931
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 9
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8.0E+15
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1.0E+15
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 976600000000.0
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 953700000.0
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 931323
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
        End Select

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

        If m5 = 0 And m6 = 1 Then
            txtrespuesta.Text = txtEntradab.Text * 0.85
        Else
            If m5 = 0 And m6 = 2 Then
                txtrespuesta.Text = txtEntradab.Text * 105.8
            Else
                If m5 = 0 And m6 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text * 74.82
                Else
                    If m5 = 0 And m6 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text * 21.98
                    Else
                        If m5 = 0 And m6 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text * 1192.22
                        Else
                            If m5 = 0 And m6 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 3.67
                            Else
                                If m5 = 0 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 74.93
                                Else
                                    If m5 = 0 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 3.58
                                    Else
                                        If m5 = 0 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 6.92
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 1 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 1.18
        Else
            If m5 = 1 And m6 = 2 Then
                txtrespuesta.Text = txtEntradab.Text * 124.8
            Else
                If m5 = 1 And m6 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text * 88.25
                Else
                    If m5 = 1 And m6 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text * 25.92
                    Else
                        If m5 = 1 And m6 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text * 1406.22
                        Else
                            If m5 = 1 And m6 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 4.33
                            Else
                                If m5 = 1 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 88.38
                                Else
                                    If m5 = 1 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 4.22
                                    Else
                                        If m5 = 1 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 8.16
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 2 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.0095
        Else
            If m5 = 2 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.008
            Else
                If m5 = 2 And m6 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text * 0.71
                Else
                    If m5 = 2 And m6 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text * 0.21
                    Else
                        If m5 = 2 And m6 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text * 11.26
                        Else
                            If m5 = 2 And m6 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 0.035
                            Else
                                If m5 = 2 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 0.71
                                Else
                                    If m5 = 2 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 0.034
                                    Else
                                        If m5 = 2 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 0.065
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 3 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.013
        Else
            If m5 = 3 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.011
            Else
                If m5 = 3 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 1.41
                Else
                    If m5 = 3 And m6 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text * 0.29
                    Else
                        If m5 = 3 And m6 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text * 15.93
                        Else
                            If m5 = 3 And m6 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 0.049
                            Else
                                If m5 = 3 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1
                                Else
                                    If m5 = 3 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 0.048
                                    Else
                                        If m5 = 3 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 0.092
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 4 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.046
        Else
            If m5 = 4 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.039
            Else
                If m5 = 4 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 4.81
                Else
                    If m5 = 4 And m6 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 3.4
                    Else
                        If m5 = 4 And m6 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text * 54.25
                        Else
                            If m5 = 4 And m6 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 0.17
                            Else
                                If m5 = 4 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 3.41
                                Else
                                    If m5 = 4 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 0.16
                                    Else
                                        If m5 = 4 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 0.31
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 5 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.00084
        Else
            If m5 = 5 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.00071
            Else
                If m5 = 5 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 0.089
                Else
                    If m5 = 5 And m6 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 0.063
                    Else
                        If m5 = 5 And m6 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 0.018
                        Else
                            If m5 = 5 And m6 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 0.0031
                            Else
                                If m5 = 5 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 0.063
                                Else
                                    If m5 = 5 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 0.003
                                    Else
                                        If m5 = 5 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 0.0058
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 6 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.27
        Else
            If m5 = 6 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.23
            Else
                If m5 = 6 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 28.8
                Else
                    If m5 = 6 And m6 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 20.37
                    Else
                        If m5 = 6 And m6 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 5.98
                        Else
                            If m5 = 6 And m6 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 324.6
                            Else
                                If m5 = 6 And m6 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 20.4
                                Else
                                    If m5 = 6 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 0.97
                                    Else
                                        If m5 = 6 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1.88
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 7 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.013
        Else
            If m5 = 7 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.011
            Else
                If m5 = 7 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 1.41
                Else
                    If m5 = 7 And m6 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 1
                    Else
                        If m5 = 7 And m6 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 0.29
                        Else
                            If m5 = 7 And m6 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 15.91
                            Else
                                If m5 = 7 And m6 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text * 0.049
                                Else
                                    If m5 = 7 And m6 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 0.048
                                    Else
                                        If m5 = 7 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 0.092
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 8 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.28
        Else
            If m5 = 8 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.24
            Else
                If m5 = 8 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 29.57
                Else
                    If m5 = 8 And m6 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 20.91
                    Else
                        If m5 = 8 And m6 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 6.14
                        Else
                            If m5 = 8 And m6 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 333.21
                            Else
                                If m5 = 8 And m6 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1.03
                                Else
                                    If m5 = 8 And m6 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text * 20.94
                                    Else
                                        If m5 = 8 And m6 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1.93
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If m5 = 9 And m6 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 0.14
        Else
            If m5 = 9 And m6 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 0.12
            Else
                If m5 = 9 And m6 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 15.29
                Else
                    If m5 = 9 And m6 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10.81
                    Else
                        If m5 = 9 And m6 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text * 3.18
                        Else
                            If m5 = 9 And m6 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 172.3
                            Else
                                If m5 = 9 And m6 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text * 0.53
                                Else
                                    If m5 = 9 And m6 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text * 10.83
                                    Else
                                        If m5 = 9 And m6 = 8 Then
                                            txtrespuesta.Text = txtEntradab.Text * 0.52
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
