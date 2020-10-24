Public Class frmBuscarCargos
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub frmBuscarCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCargo.DataSource = objConexion.obtenerDatos().Tables("cargos").DefaultView
    End Sub
    Private Sub filtrarDatosCargos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarCargo.DataSource
        bs.Filter = "cargo like '%" + valor + "%'"
        grdBuscarCargo.DataSource = bs
    End Sub
    Private Sub seleccionarCargos()
        _idC = grdBuscarCargo.CurrentRow.Cells("idCargo").Value.ToString()
        Close()
    End Sub
    Private Sub txtBuscarUusuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCargo.KeyUp
        filtrarDatosCargos(txtBuscarCargo.Text)
        If e.KeyCode = 13 Then
            seleccionarCargos()
        End If
    End Sub

    Private Sub btnSeleccionarProductos_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCargo.Click
        seleccionarCargos()
    End Sub

    Private Sub btnCancelarCargo_Click(sender As Object, e As EventArgs) Handles btnCancelarCargo.Click
        Close()
    End Sub
End Class