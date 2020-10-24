Public Class frmBuscarvarios
    Dim objConexion As New db_conexion
    Public _idV As Integer
    Private Sub frmBuscarvarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarVarios.DataSource = objConexion.obtenerDatos().Tables("pagosvarios").DefaultView
    End Sub
    Private Sub filtrarDatosvarios(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarVarios.DataSource
        bs.Filter = "tipoproducto like '%" + valor + "%' or codigo like '%" & valor & "%' or  descripcion like '%" & valor & "%'"
        grdBuscarvarios.DataSource = bs
    End Sub
    Private Sub btnSeleccionarvarios_Click(sender As Object, e As EventArgs) Handles btnSeleccionarvarios.Click
        seleccionarpagosvarios()
    End Sub

    Private Sub txtBuscarvarios_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarvarios.KeyUp
        filtrarDatosvarios(txtBuscarvarios.Text)
        If e.KeyCode = 13 Then
            seleccionarpagosvarios()
        End If
    End Sub
    Private Sub seleccionarpagosvarios()
        _idV = grdBuscarvarios.CurrentRow.Cells("idVarios").Value.ToString()
        Close()
    End Sub

    Private Sub btnCancelarvarios_Click(sender As Object, e As EventArgs) Handles btnCancelarvarios.Click
        _idV = 0
        Close()
    End Sub
End Class