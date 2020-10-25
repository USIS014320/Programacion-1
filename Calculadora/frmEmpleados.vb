Public Class frmEmpleados
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("empleados")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idEmpleado")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtNombreEmpleados.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtUsuarioEmpleados.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtClaveEmpleados.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtDireccionEmpleados.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtTelefonoEmpleados.Text = dataTable.Rows(posicion).ItemArray(5).ToString()


            lblRegistrosEmpleado.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosEmpleado()
            MessageBox.Show("No hay registros que mostrar", "Registro de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroEmpleado_Click(sender As Object, e As EventArgs) Handles btnPrimeroEmpleado.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteEmpleado_Click(sender As Object, e As EventArgs) Handles btnSiguienteEmpleado.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAnteriorEmpleado_Click(sender As Object, e As EventArgs) Handles btnAnteriorEmpleado.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnUltimoEmpleado_Click(sender As Object, e As EventArgs) Handles btnUltimoEmpleado.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleados.Click
        If btnAgregarEmpleados.Text = "Nuevo" Then
            btnAgregarEmpleados.Text = "Guardar"
            btnModificarEmpleados.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosEmpleado()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosEmpleados(New String() {
                Me.Tag, txtNombreEmpleados.Text, txtUsuarioEmpleados.Text, txtClaveEmpleados.Text, txtDireccionEmpleados.Text, txtTelefonoEmpleados.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Empleados",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarEmpleados.Text = "Nuevo"
                btnModificarEmpleados.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarEmpleados.Enabled = estado
        btnBuscarEmpleados.Enabled = estado
    End Sub
    Private Sub limpiarDatosEmpleado()
        txtNombreEmpleados.Text = ""
        txtUsuarioEmpleados.Text = ""
        txtClaveEmpleados.Text = ""
        txtDireccionEmpleados.Text = ""
        txtTelefonoEmpleados.Text = ""
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleados.Click
        If btnModificarEmpleados.Text = "Modificar" Then
            btnAgregarEmpleados.Text = "Guardar"
            btnModificarEmpleados.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarEmpleados.Text = "Nuevo"
            btnModificarEmpleados.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleados.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreEmpleados.Text, "Registro de empleados",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosEmpleados(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleados.Click
        Dim objBuscarEmpleado As New frmBuscarEmpleados
        objBuscarEmpleado.ShowDialog()
        If objBuscarEmpleado._idE > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarEmpleado._idE))
            mostrarDatos()
        End If
    End Sub
End Class