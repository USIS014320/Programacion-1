Imports System.Data.SqlClient
Public Class frmCrearprestamo
    Public _idPrest As Integer = 0



    Private Sub frmcrearprestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarDs()
        totalizar()

    End Sub

    Private Sub actualizarDs()


        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.intereses' Puede moverla o quitarla según sea necesario.
        Me.InteresesTableAdapter.FillInteres(Me.Bd_sigacDataSet.intereses)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.ocupacion' Puede moverla o quitarla según sea necesario.
        Me.OcupacionTableAdapter.FillOcupacion(Me.Bd_sigacDataSet.ocupacion)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.FillClientes(Me.Bd_sigacDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.crearprestamoCliente' Puede moverla o quitarla según sea necesario.
        Me.CrearprestamoClienteTableAdapter.FillcrearprestamoCliente(Me.Bd_sigacDataSet.crearprestamoCliente)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.crearprestamo' Puede moverla o quitarla según sea necesario.
        Me.CrearprestamoTableAdapter.FillCrearPrestamo(Me.Bd_sigacDataSet.crearprestamo)

    End Sub

    Private Sub totalizar()

        lblRegistros.Text = (CrearprestamoBindingSource.Position + 1) & " de " & CrearprestamoBindingSource.Count

    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        CrearprestamoBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        CrearprestamoBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        CrearprestamoBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        CrearprestamoBindingSource.MoveLast()
        totalizar()
    End Sub

    Private Sub habdesh_controles(ByVal valor As Boolean)
        IdClienteComboBox.Enabled = Not valor
        IdOcupacionComboBox.Enabled = Not valor
        IdInteresComboBox.Enabled = Not valor
        CedulaTextBox.ReadOnly = valor
        MontoTextBox.ReadOnly = valor
        CuotasTextBox.ReadOnly = valor
        FechaprestamoDateTimePicker.Enabled = Not valor

        CrearprestamoClienteDataGridView.ReadOnly = valor
        grbNavegacion.Visible = valor
        btnAgregarClienteNuevo.Visible = Not valor
        btnCalcular.Visible = Not valor

        btnEliminar.Enabled = valor
        btnBuscar.Enabled = valor
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
            CrearprestamoBindingSource.AddNew()

            IdClienteComboBox.SelectedValue = 1 'Cliente por default Prestamos a Publico
            IdOcupacionComboBox.SelectedValue = 3 'Tipo de ocupacion por default Cliente
            IdInteresComboBox.SelectedValue = 1 'Tarifa de interes por default prestamor final 
            FechaprestamoDateTimePicker.Value = Date.Now
        Else 'Guardar
            Try
                Dim _idPrest = Integer.Parse(lblRegistros.Text)
                Me.Validate()
                CrearprestamoBindingSource.EndEdit()

                Dim comando As New SqlCommand
                comando.Connection = CrearprestamoTableAdapter.Connection

                If _idPrest > 0 Then
                    comando.CommandText = "delete from crearprestamo where idPrest" + _idPrest
                    comando.ExecuteNonQuery()
                Else
                    comando.CommandText = "select ident_current(crearprestamo + 1 AS idPrest"
                    _idPrest = Integer.Parse(comando.ExecuteScalar().ToString())
                End If

                Dim nfilas As Integer = CrearprestamoClienteDataGridView.Rows.Count
                Dim valores(nfilas, 3) As String
                Dim fila As New DataGridViewRow

                For i = 0 To nfilas - 1
                    fila = CrearprestamoClienteDataGridView.Rows(i)

                    valores(i, 0) = fila.Cells("idPres").Value.ToString()
                    valores(i, 1) = fila.Cells("cedula").Value.ToString()
                    valores(i, 2) = fila.Cells("monto").Value.ToString()
                    valores(i, 3) = fila.Cells("cuotas").Value.ToString()
                    valores(i, 4) = fila.Cells("fechaprestamo").Value.ToString()
                    valores(i, 5) = fila.Cells("total").Value.ToString()
                Next
                Me.TableAdapterManager.UpdateAll(Me.Bd_sigacDataSet)


                For i = 0 To nfilas - 1
                    CrearprestamoTableAdapter.Insert(
                    _idPrest,
                    Integer.Parse(valores(i, 0)),
                    Integer.Parse(valores(i, 1)),
                    Integer.Parse(valores(i, 2)),
                    Integer.Parse(valores(i, 3)),
                    Date.Parse(valores(i, 4)),
                    Date.Parse(valores(i, 5)),
                    Integer.Parse(valores(i, 6))
                )
                Next
                actualizarDs()
                CrearprestamoBindingSource.MoveLast()

                habdesh_controles(True)
                btnAgregar.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            Catch ex As Exception
                MessageBox.Show("Error al intentar guardar: " + ex.Message,
                    "Registro de Facturas de Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub eliminarDetalle()
        CrearprestamoTableAdapter.Connection.Open()
        Dim comando As New SqlCommand
        comando.Connection = CrearprestamoTableAdapter.Connection

        comando.CommandText = "delete from crearprestamo where idPrest=" + _idPrest.ToString()
        comando.ExecuteNonQuery()
        CrearprestamoTableAdapter.Connection.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
        Else 'Cancelar
            CrearprestamoClienteBindingSource.CancelEdit()
            CrearprestamoBindingSource.CancelEdit()

            habdesh_controles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub


    Private Sub CrearprestamoClienteDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles CrearprestamoClienteDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _idPrest = Integer.Parse(lblRegistros.Text)
        eliminarDetalle()

        CrearprestamoBindingSource.RemoveAt(CrearprestamoBindingSource.Position)
        CrearprestamoBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Bd_sigacDataSet)

        actualizarDs()
    End Sub

    Private Sub btnAgregarClienteNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregarClienteNuevo.Click
        Dim objClientes As New frmClientes
        objClientes.Show()
    End Sub

    Private Sub bonImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim objClientes As New frmImprimirPrestamo
        objClientes.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objPrest As New frmBuscarRegistroPrestamos
        objPrest.Show()
    End Sub
End Class

