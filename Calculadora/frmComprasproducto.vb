Imports System.Data.SqlClient
Public Class frmComprasproducto
    Public _idCpro As Integer = 0
    Private Sub frmComprasproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarDs()
        totalizar()

    End Sub

    Private Sub actualizarDs()
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.dcompras' Puede moverla o quitarla según sea necesario.
        Me.DcomprasTableAdapter.Fill(Me.Bd_sigacDataSet.dcompras)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.Bd_sigacDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.tipofactura' Puede moverla o quitarla según sea necesario.
        Me.TipofacturaTableAdapter.Fill(Me.Bd_sigacDataSet.tipofactura)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.Bd_sigacDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.DcomprasProductos' Puede moverla o quitarla según sea necesario.
        Me.DcomprasProductosTableAdapter.FillDcomprasProducto(Me.Bd_sigacDataSet.DcomprasProductos)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.Bd_sigacDataSet.compras)

    End Sub

    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DcomprasProductosDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DcomprasProductosDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()
                sumas += subtotal
            Next
            iva = If(IdTipofacturaComboBox.SelectedValue = 2, sumas * 0.13, 0)
            total = sumas + iva

            lblrespuestasumacompra.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblrespuestaivacompra.Text = "$ " + Math.Round(iva, 2).ToString()
            lblrespuestatotalcompra.Text = "$ " + Math.Round(total, 2).ToString()

            lblnregistros.Text = (ComprasBindingSource.Position + 1) & " de " & ComprasBindingSource.Count
        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        ComprasBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ComprasBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ComprasBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ComprasBindingSource.MoveLast()
        totalizar()
    End Sub
    Private Sub habdesh_controles(ByVal valor As Boolean)
        NfacturaTextBox.ReadOnly = valor
        IdProveedorComboBox.Enabled = Not valor
        Fecha_vtaDateTimePicker.Enabled = Not valor
        IdTipofacturaComboBox.Enabled = Not valor
        IdPagoComboBox.Enabled = Not valor
        DcomprasProductosDataGridView.ReadOnly = valor

        grbdComprasProductos.Visible = Not valor
        grbNavegacion.Visible = valor
        btnAgregarProveedor.Visible = Not valor

        btnEliminar.Enabled = valor
        btnBuscar.Enabled = valor
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
            ComprasBindingSource.AddNew()

            IdProveedorComboBox.SelectedValue = 1 'Cliente por default Ventas a Publico
            IdTipofacturaComboBox.SelectedValue = 3 'Tipo de factura por default consumidor final 
            IdPagoComboBox.SelectedValue = 1 'Tipo de Pago por default efectivo
            Fecha_vtaDateTimePicker.Value = Date.Now
        Else 'Guardar
            Try
                _idCpro = Integer.Parse(lblIdCompra.Text)
                Me.Validate()
                ComprasBindingSource.EndEdit()

                If _idCpro > 0 Then 'Modificanco
                    eliminarDetalle()
                Else 'Agregando Nuevas Facturas
                    ComprasTableAdapter.Connection.Open()
                    Dim comando As New SqlCommand
                    comando.Connection = ComprasTableAdapter.Connection
                    comando.CommandText = "SELECT ident_current('compras') + 1 AS idCompra"
                    _idCpro = Integer.Parse(comando.ExecuteScalar().ToString())
                    ComprasTableAdapter.Connection.Close()
                End If

                Dim nfilas As Integer = DcomprasProductosDataGridView.Rows.Count
                Dim valores(nfilas, 3) As String
                Dim fila As New DataGridViewRow

                For i = 0 To nfilas - 1
                    fila = DcomprasProductosDataGridView.Rows(i)

                    valores(i, 0) = fila.Cells("idProducto").Value.ToString()
                    valores(i, 1) = fila.Cells("cantidad").Value.ToString()
                    valores(i, 2) = fila.Cells("precio").Value.ToString()
                Next
                TableAdapterManager.UpdateAll(Bd_sigacDataSet)

                For i = 0 To nfilas - 1
                    DcomprasTableAdapter.Insert(
                        _idCpro,
                        valores(i, 0),
                        valores(i, 1),
                        valores(i, 2)
                    )
                Next
                actualizarDs()
                ComprasBindingSource.MoveLast()

                habdesh_controles(True)
                btnAgregar.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            Catch ex As Exception
                MessageBox.Show("Error al intentar guardar: " + ex.Message,
                    "Registro de Facturas de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub eliminarDetalle()
        ComprasTableAdapter.Connection.Open()
        Dim comando As New SqlCommand
        comando.Connection = ComprasTableAdapter.Connection

        comando.CommandText = "delete from dcompras where idCompra=" + _idCpro.ToString()
        comando.ExecuteNonQuery()
        ComprasTableAdapter.Connection.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)

        Else 'cancelar
            DcomprasProductosBindingSource.CancelEdit()
            ComprasBindingSource.CancelEdit()
            habdesh_controles(True)

            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If

    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim objProductos As New frmProductos
        objProductos.Show()

    End Sub

    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        Try
            DcomprasProductosDataGridView.Rows.Remove(DcomprasProductosDataGridView.CurrentRow)
            totalizar()
        Catch ex As Exception
            MessageBox.Show("Error al intentar quitar la fila: " + ex.Message)
        End Try
    End Sub

    Private Sub DcomprasProductosDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DcomprasProductosDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        Dim objProveedores As New frmProveedores
        objProveedores.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        eliminarDetalle()

        ComprasBindingSource.RemoveAt(ComprasBindingSource.Position)
        ComprasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Bd_sigacDataSet)

        actualizarDs()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim objImprimirComprasProductos As New frmImprimirCompraProducto
        objImprimirComprasProductos.Show()
    End Sub
End Class