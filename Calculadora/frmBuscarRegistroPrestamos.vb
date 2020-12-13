Public Class frmBuscarRegistroPrestamos
    Dim objConexion As New db_conexion
    Public _idP As Integer

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        seleccionar()
    End Sub

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscar.DataSource = objConexion.obtenerDatos().Tables("crearprestamo").DefaultView
    End Sub

    Private Sub txtBuscarPrest_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        filtrarDatoscrearprestamo(txtBuscar.Text)
        If e.KeyCode = 13 Then
            seleccionar()
        End If
    End Sub
    Private Sub seleccionar()
        _idP = grdBuscar.CurrentRow.Cells("idPrest").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatoscrearprestamo(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscar.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombre like '%" & valor & "%'"
        grdBuscar.DataSource = bs
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _idP = 0
        Close()
    End Sub
End Class