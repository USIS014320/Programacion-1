Public Class frmProductosfaltantes
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmProductosfaltantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("faltanteproducto")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idFaltanteproducto")}

        cboCategoriafaltante.DataSource = objConexion.obtenerDatos().Tables("categoriafaltante").DefaultView()
        cboCategoriafaltante.DisplayMember = "categoriafalta"
        cboCategoriafaltante.ValueMember = "categoriafaltante.idFaltante"

        cboCategoriafaltante.AutoCompleteMode = AutoCompleteMode.Suggest
        cboCategoriafaltante.AutoCompleteSource = AutoCompleteSource.ListItems
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()

            cboCategoriafaltante.SelectedValue = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtCodigofaltante.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDescripcionfaltante.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtMarcafaltante.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtMedidasfaltante.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtCantidadfaltante.Text = dataTable.Rows(posicion).ItemArray(6).ToString()

            lblRegistrosProducto.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosfaltantes()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub limpiarDatosfaltantes()
        txtCodigofaltante.Text = ""
        txtDescripcionfaltante.Text = ""
        txtMarcafaltante.Text = ""
        txtMedidasfaltante.Text = ""
        txtCantidadfaltante.Text = ""
    End Sub

    Private Sub btnPrimerofaltante_Click(sender As Object, e As EventArgs) Handles btnPrimerofaltante.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriorfaltante_Click(sender As Object, e As EventArgs) Handles btnAnteriorfaltante.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Productos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguientefaltante_Click(sender As Object, e As EventArgs) Handles btnSiguientefaltante.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimofaltante_Click(sender As Object, e As EventArgs) Handles btnUltimofaltante.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbfaltantes.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarfaltante.Enabled = estado
        btnBuscarfaltante.Enabled = estado
    End Sub
    Private Sub btnAgregarfaltante_Click(sender As Object, e As EventArgs) Handles btnAgregarfaltante.Click
        If btnAgregarfaltante.Text = "Nuevo" Then 'Nuevo
            btnAgregarfaltante.Text = "Guardar"
            btnModificarfaltante.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosfaltantes()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosfaltantes(New String() {
                    Me.Tag, cboCategoriafaltante.SelectedValue, txtCodigofaltante.Text, txtDescripcionfaltante.Text, txtMarcafaltante.Text, txtMedidasfaltante.Text, txtCantidadfaltante.Text
                }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Productos faltantes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarfaltante.Text = "Nuevo"
                btnModificarfaltante.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub btnModificarfaltante_Click(sender As Object, e As EventArgs) Handles btnModificarfaltante.Click
        If btnModificarfaltante.Text = "Modificar" Then 'Modificar
            btnAgregarfaltante.Text = "Guardar"
            btnModificarfaltante.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarfaltante.Text = "Nuevo"
            btnModificarfaltante.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarfaltante_Click(sender As Object, e As EventArgs) Handles btnEliminarfaltante.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtDescripcionfaltante.Text, "Registro de Producto faltante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosfaltantes(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub

    Private Sub btnBuscarfaltante_Click(sender As Object, e As EventArgs) Handles btnBuscarfaltante.Click
        Dim objBuscarProductofaltante As New frmBuscarProductofaltante
        objBuscarProductofaltante.ShowDialog()
        If objBuscarProductofaltante._idPF > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProductofaltante._idPF))
            mostrarDatos()
        End If
    End Sub
End Class
