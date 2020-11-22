Public Class frmInteres
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmInteres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("interes")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idInteres")}

        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Interes
            txtInteres.Text = dataTable.Rows(posicion).ItemArray(1).ToString()

            lblRegistrosInteres.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosInteres()
            MessageBox.Show("No hay registros que mostrar", "Registro de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub limpiarDatosInteres()
        txtInteres.Text = ""
    End Sub
    Private Sub btnPrimeroInteres_Click(sender As Object, e As EventArgs) Handles btnPrimeroInteres.Click
        posicion = 0
        mostrarDatos()
    End Sub
    Private Sub btnAnteriorInteres_Click(sender As Object, e As EventArgs) Handles btnAnteriorInteres.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSiguienteInteres_Click(sender As Object, e As EventArgs) Handles btnSiguienteInteres.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoInteres_Click(sender As Object, e As EventArgs) Handles btnUltimoInteres.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarInteres.Enabled = estado
        btnBuscarInteres.Enabled = estado
    End Sub
    Private Sub btnAgregarInteres_Click(sender As Object, e As EventArgs) Handles btnAgregarInteres.Click
        If btnAgregarInteres.Text = "Nuevo" Then 'Nuevo
            btnAgregarInteres.Text = "Guardar"
            btnModificarInteres.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosInteres()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosInteres(New String() {
                Me.Tag, txtInteres.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Intereses",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarInteres.Text = "Nuevo"
                btnModificarInteres.Text = "Modificar"
            End If
        End If
    End Sub
    Private Sub btnModificarInteres_Click(sender As Object, e As EventArgs) Handles btnModificarInteres.Click
        If btnModificarInteres.Text = "Modificar" Then 'Modificar
            btnAgregarInteres.Text = "Guardar"
            btnModificarInteres.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarInteres.Text = "Nuevo"
            btnModificarInteres.Text = "Modificar"
        End If
    End Sub
    Private Sub btnEliminarInteres_Click(sender As Object, e As EventArgs) Handles btnEliminarInteres.Click
        If MessageBox.Show("Esta seguro de eliminar " & txtInteres.Text, "Registro de Interes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Dim msg = objConexion.mantenimientoDatosInteres(New String() {Me.Tag}, "eliminar")
            If msg = "error" Then
                MessageBox.Show("No se pudo eliminar el interes porque hay usuarios que depende de este interes", "Registro de Interes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If posicion > 0 Then
                    posicion -= 1
                End If
                obtenerDatos()
                mostrarDatos()
            End If
        End If
    End Sub
    Private Sub btnBuscarInteres_Click(sender As Object, e As EventArgs) Handles btnBuscarInteres.Click
        Dim objBuscarInteres As New frmBuscarInteres
        objBuscarInteres.ShowDialog()
        If objBuscarInteres._idI > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarInteres._idI))
            mostrarDatos()
        End If
    End Sub
End Class
