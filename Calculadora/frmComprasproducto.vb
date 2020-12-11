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



        Else 'Guardar

            habdesh_controles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If

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
End Class