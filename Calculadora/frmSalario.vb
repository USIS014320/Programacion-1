Public Class frmSalario
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmSalario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.Descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.Bd_sigacDataSet.Descuentos)
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Descuentos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("IdDescuento")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Categoria 
            ComboBox1.Text = dataTable.Rows(posicion).ItemArray(1).ToString()

            lblRegistrosSalario.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosCategoria()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosCategoria()
        ComboBox1.Text = ""
    End Sub
    Private Sub btnPrimeroCategoria_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        posicion = 0
        mostrarDatos()
    End Sub
    Private Sub btnAnteriorCategoria_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSiguienteCategoria_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoCategoria_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarDescuento.Enabled = estado
    End Sub
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarDescuento.Click
        If btnAgregarDescuento.Text = "Nuevo" Then 'Nuevo
            btnAgregarDescuento.Text = "Guardar"
            btnModificarDescuento.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosCategoria()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosDescuentos(New String() {
                Me.Tag, ComboBox1.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarDescuento.Text = "Nuevo"
                btnModificarDescuento.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub btnModificarCategoria_Click(sender As Object, e As EventArgs) Handles btnModificarDescuento.Click
        If btnModificarDescuento.Text = "Modificar" Then 'Modificar
            btnAgregarDescuento.Text = "Guardar"
            btnModificarDescuento.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarDescuento.Text = "Nuevo"
            btnModificarDescuento.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarDescuento.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtUsuario.Text, "Registro de Descuentos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosSalarios(New String() {Me.Tag}, "eliminar")
            If msg = "error" Then
                MessageBox.Show("No se pudo eliminar el descuento porque hay salarios que depende de esta descuento", "Registro de Descuentos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub
    Private Sub btnImprimirSalario_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim objImprimirSalarios As New frmImprimirSalarios
        objImprimirSalarios.ShowDialog()
    End Sub
End Class
