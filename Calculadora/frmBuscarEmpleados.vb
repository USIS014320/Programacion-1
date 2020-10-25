Public Class frmBuscarEmpleados
    Dim objConexion As New db_conexion
    Public _idE As Integer
    Private Sub frmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarEmpleados.DataSource = objConexion.obtenerDatos().Tables("Empleados").DefaultView
    End Sub
    Private Sub filtrarDatosEmpleado(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarEmpleados.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdBuscarEmpleados.DataSource = bs
    End Sub
    Private Sub seleccionarEmpleado()
        _idE = grdBuscarEmpleados.CurrentRow.Cells("idEmpleado").Value.ToString()
        Close()
    End Sub
    Private Sub btnSeleccionarEmpleados_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEmpleado.Click
        seleccionarEmpleado()
    End Sub
    Private Sub txtBuscarEmpleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEmpleado.KeyUp
        filtrarDatosEmpleado(txtBuscarEmpleado.Text)
        If e.KeyCode = 13 Then
            seleccionarEmpleado()
        End If
    End Sub

    Private Sub btnCancelarEmpleadoo_Click(sender As Object, e As EventArgs) Handles btnCancelarEmpleado.Click
        Close()
    End Sub
End Class