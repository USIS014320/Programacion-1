Public Class frmUsuario
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Private Sub frmUsuarior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboCargoUsuario.DataSource = objConexion.obtenerDatos().Tables("cargos").DefaultView()
        cboCargoUsuario.DisplayMember = "cargo"
        cboCargoUsuario.ValueMember = "cargos.idCargo"

        cboCargoUsuario.AutoCompleteMode = AutoCompleteMode.Suggest
        cboCargoUsuario.AutoCompleteSource = AutoCompleteSource.ListItems
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Usuario
            cboCargoUsuario.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtUsuario.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtNombreUsuario.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonoUsuario.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtClaveUsuario.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtDireccionUsuario.Text = dataTable.Rows(posicion).ItemArray(6).ToString()


            lblRegistrosUsuario.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosUsuario()
            MessageBox.Show("No hay registros que mostrar", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosUsuario()
        txtUsuario.Text = ""
        txtNombreUsuario.Text = ""
        txtTelefonoUsuario.Text = ""
        txtClaveUsuario.Text = ""
        txtDireccionUsuario.Text = ""

    End Sub

    Private Sub btnPrimeroUsuarioClick(sender As Object, e As EventArgs) Handles btnPrimeroUsuario.Click
        posicion = 0
        mostrarDatos()
    End Sub
    Private Sub btnSiguienteUsuarior_Click(sender As Object, e As EventArgs) Handles btnSiguienteUsuario.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnAnteriorUsuario_Click(sender As Object, e As EventArgs) Handles btnAnteriorUsuario.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoUsuario_Click(sender As Object, e As EventArgs) Handles btnUltimoUsuario.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub


    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarUsuario.Enabled = estado
        btnBuscarUsuario.Enabled = estado
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        If btnAgregarUsuario.Text = "Nuevo" Then 'Nuevo
            btnAgregarUsuario.Text = "Guardar"
            btnModificarUsuario.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosUsuario()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosUsuario(New String() {
                Me.Tag, cboCargoUsuario.SelectedValue, txtUsuario.Text, txtNombreUsuario.Text, txtTelefonoUsuario.Text, txtClaveUsuario.Text, txtDireccionUsuario.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Usuarios",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarUsuario.Text = "Nuevo"
                btnModificarUsuario.Text = "Modificar"
            End If
        End If
    End Sub


    Private Sub btnModificarUsuario_Click(sender As Object, e As EventArgs) Handles btnModificarUsuario.Click
        If btnModificarUsuario.Text = "Modificar" Then 'Modificar
            btnAgregarUsuario.Text = "Guardar"
            btnModificarUsuario.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarUsuario.Text = "Nuevo"
            btnModificarUsuario.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreUsuario.Text, "Registro de usuario",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosUsuario(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarUsuarior_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click
        Dim objBuscarUsuario As New frmBuscarUsuario
        objBuscarUsuario.ShowDialog()
        If objBuscarUsuario._idU > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarUsuario._idU))
            mostrarDatos()
        End If
    End Sub



    Private Sub btnBuscarCargoUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarCargoUsuario.Click
        Dim objBuscarCargoUsuario As New frmBuscarCargos
        objBuscarCargoUsuario.ShowDialog()
        If objBuscarCargoUsuario._idC > 0 Then
            cboCargoUsuario.SelectedValue = objBuscarCargoUsuario._idC
        End If
    End Sub



End Class
