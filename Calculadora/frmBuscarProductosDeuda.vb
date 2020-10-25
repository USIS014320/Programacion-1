Public Class frmBuscarProductosDeuda
    Dim objConexion As New db_conexion
    Public _idP As Integer

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        seleccionarCliente()
    End Sub

    Private Sub frmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProductoDeuda.DataSource = objConexion.obtenerDatos().Tables("ProductosDeuda").DefaultView
    End Sub

    Private Sub txtBuscarCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarProuctos.KeyUp

    End Sub
    Private Sub seleccionarCliente()
        _idP = grdBuscarProductoDeuda.CurrentRow.Cells("idProductoDeuda").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosClientes(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProductoDeuda.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombre like '%" & valor & "%'"
        grdBuscarProductoDeuda.DataSource = bs
    End Sub

    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        _idP = 0
        Close()
    End Sub
End Class