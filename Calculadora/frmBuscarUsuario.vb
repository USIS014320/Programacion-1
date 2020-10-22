Public Class frmBuscarUsuario
    Dim objConexion As New db_conexion
    Public _idP As Integer
    Private Sub frmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarUsuario.DataSource = objConexion.obtenerDatos().Tables("productos").DefaultView
    End Sub
    Private Sub filtrarDatosUsuario(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarUsuario.DataSource
        bs.Filter = "cargo like '%" & valor & "%'"
        grdBuscarUsuario.DataSource = bs
    End Sub
    Private Sub seleccionarUsuario()
        _idP = grdBuscarUsuario.CurrentRow.Cells("idUsuario").Value.ToString()
        Close()
    End Sub
    Private Sub btnSeleccionarUsuarios_Click(sender As Object, e As EventArgs) Handles btnSeleccionarUsuario.Click
        seleccionarUsuario()
    End Sub
    Private Sub txtBuscarProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarUsuario.KeyUp
        filtrarDatosUsuario(txtBuscarUsuario.Text)
        If e.KeyCode = 13 Then
            seleccionarUsuario()
        End If
    End Sub
End Class