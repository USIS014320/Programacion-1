Public Class frmBuscarEmpleados
    Dim objConexion As New db_conexion
    Public _idE As Integer

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEmpleado.Click
        seleccionarEmpleado()
    End Sub

    Private Sub FrmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarEmpleados.DataSource = objConexion.obtenerDatos().Tables("Empleados").DefaultView
    End Sub

    Private Sub txtBuscarEmpleados_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEmpleado.KeyUp
        filtrarDatosEmpleados(txtBuscarEmpleado.Text)
        If e.KeyCode = 13 Then
            seleccionarEmpleado()
        End If
    End Sub
    Private Sub seleccionarEmpleado()
        _idE = grdBuscarEmpleados.CurrentRow.Cells("idEmpleado").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosEmpleados(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarEmpleados.DataSource
        bs.Filter = "nombre like '%" & valor & "%' or  usuario like '%" & valor & "%'"
        grdBuscarEmpleados.DataSource = bs
    End Sub

    Private Sub btnCancelarEmpleado_Click(sender As Object, e As EventArgs) Handles btnCancelarEmpleado.Click
        _idE = 0
        Close()
    End Sub
End Class