Public Class frmPrestamo

    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"
    Dim objmeses = New meses()


    Private Sub frmmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboMesPrestamo.Items.AddRange(objmeses.mes)
    End Sub

    Class meses
        Public mes() As String = {"Enero",
            "Febrero", "Marzo", "Abril", “Mayo”, “Junio”, “Julio”, “Agosto”,
            “Septiembre”, “Octubre”, “Noviembre”, “Diciembre”}
    End Class

    Private Sub frmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("prestamos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("iPrestamo")}

        cboNombreEmpleado.DataSource = objConexion.obtenerDatos().Tables("empleados").DefaultView()
        cboNombreEmpleado.DisplayMember = "nombre"
        cboNombreEmpleado.ValueMember = "empleados.idEmpleado"

        cboNombreEmpleado.AutoCompleteMode = AutoCompleteMode.Suggest
        cboNombreEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Prestamo
            cboNombreEmpleado.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            cboMesPrestamo.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtPagoPrestamo.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtDescuentoPrestamo.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtCapital.Text = dataTable.Rows(posicion).ItemArray(5).ToString()


            lblRegistrosPrestamo.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosPrestamo()
            MessageBox.Show("No hay registros que mostrar", "Registro de Prestamoss", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosPrestamo()
        cboMesPrestamo.Text = ""
        txtPagoPrestamo.Text = ""
        txtDescuentoPrestamo.Text = ""
        txtCapital.Text = ""

    End Sub

    Private Sub btnPrimeroSalario_Click(sender As Object, e As EventArgs) Handles btnPrimeroPrestamo.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorPrestamo_Click(sender As Object, e As EventArgs) Handles btnAnteriorPrestamo.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguientePrestamo_Click(sender As Object, e As EventArgs) Handles btnSiguientePrestamo.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoPrestamo_Click(sender As Object, e As EventArgs) Handles btnUltimoPrestamo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarPrestamo.Enabled = estado
        btnBuscarPrestamo.Enabled = estado
    End Sub

    Private Sub btnAgregarPrestamo_Click(sender As Object, e As EventArgs) Handles btnAgregarPrestamo.Click
        If btnAgregarPrestamo.Text = "Nuevo" Then 'Nuevo
            btnAgregarPrestamo.Text = "Guardar"
            btnModificarPrestamo.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosPrestamo()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosPrestamo(New String() {
                Me.Tag, cboNombreEmpleado.SelectedValue, cboMesPrestamo.Text, txtPagoPrestamo.Text, txtDescuentoPrestamo.Text, txtCapital.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Prestamos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarPrestamo.Text = "Nuevo"
                btnModificarPrestamo.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificarPrestamo_Click(sender As Object, e As EventArgs) Handles btnModificarPrestamo.Click
        If btnModificarPrestamo.Text = "Modificar" Then 'Modificar
            btnAgregarPrestamo.Text = "Guardar"
            btnModificarPrestamo.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarPrestamo.Text = "Nuevo"
            btnModificarPrestamo.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarPrestamo_Click(sender As Object, e As EventArgs) Handles btnEliminarPrestamo.Click
        If (MessageBox.Show("Esta seguro de borrar a " + cboNombreEmpleado.Text, "Registro de prestamo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosPrestamo(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarPrestamoo_Click(sender As Object, e As EventArgs) Handles btnBuscarPrestamo.Click
        Dim objBuscarPrestamo As New frmBuscarPrestamo
        objBuscarPrestamo.ShowDialog()
        If objBuscarPrestamo._idPt > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarPrestamo._idPt))
            mostrarDatos()
        End If
    End Sub

    Private Sub btnAplicarDescuento_Click(sender As Object, e As EventArgs) Handles btnAplicarDescuento.Click

        txtCapital.Text = (((txtPagoPrestamo.Text * txtDescuentoPrestamo.Text) / 100) - txtPagoPrestamo.Text) * (-1)
    End Sub
End Class