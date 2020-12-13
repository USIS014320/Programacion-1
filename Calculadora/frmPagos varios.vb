Public Class frmPagosVarios

    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmPagosVarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("pagosvarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idVarios")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCodigotipo.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtTipodeproducto.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtnfactura.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtDescripciontipo.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtCantidadtipo.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

            lblRegistrostipo.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarPagosvarios()
            MessageBox.Show("No hay registros que mostrar", "Registro de Pagos varios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimerotipo_Click(sender As Object, e As EventArgs) Handles btnPrimerotipo.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnAnteriortipo_Click(sender As Object, e As EventArgs) Handles btnAnteriortipo.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguientetipo_Click(sender As Object, e As EventArgs) Handles btnSiguientetipo.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimotipo_Click(sender As Object, e As EventArgs) Handles btnUltimotipo.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbPagosvarios.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminartipo.Enabled = estado
        btnBuscartipo.Enabled = estado
    End Sub


    Private Sub btnAgregartipo_Click(sender As Object, e As EventArgs) Handles btnAgregartipo.Click
        If btnAgregartipo.Text = "Nuevo" Then 'Nuevo
            btnAgregartipo.Text = "Guardar"
            btnModificartipo.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarPagosvarios()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoPagosvarios(New String() {
                Me.Tag, txtCodigotipo.Text, txtTipodeproducto.Text, txtnfactura.Text, txtDescripciontipo.Text, txtCantidadtipo.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Pagos varios",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregartipo.Text = "Nuevo"
                btnModificartipo.Text = "Modificar"
            End If
        End If
    End Sub



    Private Sub limpiarPagosvarios()
        txtTipodeproducto.Text = ""
        txtCodigotipo.Text = ""
        txtDescripciontipo.Text = ""
        txtCantidadtipo.Text = ""
        txtnfactura.Text = ""
    End Sub

    Private Sub btnModificartipo_Click(sender As Object, e As EventArgs) Handles btnModificartipo.Click
        If btnModificartipo.Text = "Modificar" Then 'Modificar
            btnAgregartipo.Text = "Guardar"
            btnModificartipo.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregartipo.Text = "Nuevo"
            btnModificartipo.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminartipo_Click(sender As Object, e As EventArgs) Handles btnEliminartipo.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtDescripciontipo.Text, "Registro de Pagos varios", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoPagosvarios(New String() {Me.Tag}, "eliminar")
            If msg IsNot "error" Then
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub

    Private Sub btnBuscartipo_Click(sender As Object, e As EventArgs) Handles btnBuscartipo.Click
        Dim objBuscarVarios As New frmBuscarvarios
        objBuscarVarios.ShowDialog()
        If objBuscarVarios._idV > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarVarios._idV))
            mostrarDatos()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim objClientes As New frmImprimirPagosVarios
        objClientes.Show()
    End Sub
End Class
