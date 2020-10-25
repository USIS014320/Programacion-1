Public Class frmBuscarPrestamo
    Dim objConexion As New db_conexion
    Public _idPt As Integer
    Private Sub frmBuscarPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarPrestamo.DataSource = objConexion.obtenerDatos().Tables("Prestamos").DefaultView
    End Sub
    Private Sub filtrarDatosPrestamo(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarPrestamo.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdBuscarPrestamo.DataSource = bs
    End Sub
    Private Sub seleccionarPrestamo()
        _idPt = grdBuscarPrestamo.CurrentRow.Cells("idPrestamo").Value.ToString()
        Close()
    End Sub
    Private Sub btnSeleccionarEmpleadoPrestamoo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEmpleadoPrestamo.Click
        seleccionarPrestamo()
    End Sub
    Private Sub txtBuscarPrestamo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEmpleadoPrestamo.KeyUp
        filtrarDatosPrestamo(txtBuscarEmpleadoPrestamo.Text)
        If e.KeyCode = 13 Then
            seleccionarPrestamo()
        End If
    End Sub

    Private Sub btnCancelarPrestamo_Click(sender As Object, e As EventArgs) Handles btnCancelarPrestamo.Click
        Close()
    End Sub
End Class