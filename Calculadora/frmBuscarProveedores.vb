Public Class frmBuscarProveedores
    Dim objConexion As New db_conexion
    Public _idP As Integer

    Private Sub btnSeleccionarProveedor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProveedor.Click
        seleccionarProveedor()
    End Sub

    Private Sub frmBuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProveedor.DataSource = objConexion.obtenerDatos().Tables("proveedores").DefaultView
    End Sub

    Private Sub txtBuscarProveedor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarProveedor.KeyUp
        filtrarDatosProveedores(txtBuscarProveedor.Text)
        If e.KeyCode = 13 Then
            seleccionarProveedor()
        End If
    End Sub
    Private Sub seleccionarProveedor()
        _idP = grdBuscarProveedor.CurrentRow.Cells("idProveedor").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosProveedores(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProveedor.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombreempresa like '%" & valor & "%'"
        grdBuscarProveedor.DataSource = bs
    End Sub

    Private Sub btnCancelarPorveedor_Click(sender As Object, e As EventArgs) Handles btnCancelarProveedor.Click
        _idP = 0
        Close()
    End Sub
End Class