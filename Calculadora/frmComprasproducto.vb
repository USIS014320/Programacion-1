Public Class frmComprasproducto
    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComprasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_sigacDataSet)

    End Sub

    Private Sub frmComprasproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


End Class