Public Class frmProductosDeuda
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("ProductosDeuda")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProductoDeuda")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtNombreCliente.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtDireccionCliente.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtCodigoCliente.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonoCliente.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtDeptoProductos.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtMunProducto.Text = dataTable.Rows(posicion).ItemArray(6).ToString()

            lblRegistrosCliente.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosCliente()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos Deudas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroCliente_Click(sender As Object, e As EventArgs) Handles btnPrimeroCliente.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteCliente_Click(sender As Object, e As EventArgs) Handles btnSiguienteCliente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos deudas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAnteriorCliente_Click(sender As Object, e As EventArgs) Handles btnAnteriorCliente.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Productos deudas ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnUltimoCliente_Click(sender As Object, e As EventArgs) Handles btnUltimoCliente.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If btnAgregarProducto.Text = "Nuevo" Then 'Nuevo
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCliente()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosProductosDeuda(New String() {
                Me.Tag, txtNombreCliente.Text, txtDireccionCliente.Text, txtCodigoCliente.Text, txtTelefonoCliente.Text, txtDeptoProductos.Text, txtMunProducto.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Productos, deudas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarProducto.Text = "Nuevo"
                btnModificarProducto.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProducto.Enabled = estado
        btnBuscarProducto.Enabled = estado
    End Sub
    Private Sub limpiarDatosCliente()
        txtNombreCliente.Text = ""
        txtDireccionCliente.Text = ""
        txtCodigoCliente.Text = ""
        txtTelefonoCliente.Text = ""
        txtDeptoProductos.Text = ""
        txtMunProducto.Text = ""

        lblRegistrosCliente.Text = ""
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        If btnModificarProducto.Text = "Modificar" Then 'Modificar
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarProducto.Text = "Nuevo"
            btnModificarProducto.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreCliente.Text, "Registro de Productos, deudas",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosProductosDeuda(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim objBuscarCliente As New frmBuscarProductosDeuda
        objBuscarCliente.ShowDialog()
        If objBuscarCliente._idP > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarCliente._idP))
            mostrarDatos()
        End If
    End Sub
End Class