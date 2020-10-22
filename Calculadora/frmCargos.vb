Public Class frmCargos
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("cargos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idCargo")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Cargo 
            txtDescripcionCargo.Text = dataTable.Rows(posicion).ItemArray(1).ToString()

            lblRegistrosCargo.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosCategoria()
            MessageBox.Show("No hay registros que mostrar", "Registro de Uusarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosCategoria()
        txtDescripcionCargo.Text = ""
    End Sub
    Private Sub btnPrimeroCargo_Click(sender As Object, e As EventArgs) Handles btnPrimeroCargo.Click
        posicion = 0
        mostrarDatos()
    End Sub
    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnteriorCargo.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSiguienteCargo_Click(sender As Object, e As EventArgs) Handles btnSiguienteCargo.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimoCargo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarCargo.Enabled = estado
        btnBuscarCargo.Enabled = estado
    End Sub
    Private Sub btnAgregarCargo_Click(sender As Object, e As EventArgs) Handles btnAgregarCargo.Click
        If btnAgregarCargo.Text = "Nuevo" Then 'Nuevo
            btnAgregarCargo.Text = "Guardar"
            btnModificarCargo.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCategoria()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosCargo(New String() {
                Me.Tag, txtDescripcionCargo.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Cargos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarCargo.Text = "Nuevo"
                btnModificarCargo.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub btnModificarCargo_Click(sender As Object, e As EventArgs) Handles btnModificarCargo.Click
        If btnModificarCargo.Text = "Modificar" Then 'Modificar
            btnAgregarCargo.Text = "Guardar"
            btnModificarCargo.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarCargo.Text = "Nuevo"
            btnModificarCargo.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarCargo_Click(sender As Object, e As EventArgs) Handles btnEliminarCargo.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtDescripcionCargo.Text, "Registro de Cargos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosCargo(New String() {Me.Tag}, "eliminar")
            If msg = "error" Then
                MessageBox.Show("No se pudo eliminar la categoria porque hay usuarios que depende de esta categoria", "Registro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub
    Private Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCargo.Click
        Dim objBuscarCargo As New frmBuscarCargos
        objBuscarCargo.ShowDialog()
        If objBuscarCargo._idC > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCargo._idC))
            mostrarDatos()
        End If
    End Sub
End Class