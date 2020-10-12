Public Class frmProveedores
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("proveedores")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProveedor")}

        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then

            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Proveedor
            txtCodigoProveedor.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombreEmpresaProveedor.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtNombrePropietarioProveedor.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtTelefonoProveedor.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtEmailProveedor.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtWebSiteProveedor.Text = dataTable.Rows(posicion).ItemArray(6).ToString()
            dtpFechaProveedor.Text = dataTable.Rows(posicion).ItemArray(7).ToString()
            cboPaísProveedor.Text = dataTable.Rows(posicion).ItemArray(8).ToString()
            cboDepartamentoProveedor.Text = dataTable.Rows(posicion).ItemArray(9).ToString()
            cboMunicipioProveedor.Text = dataTable.Rows(posicion).ItemArray(10).ToString()
            cboCantónProveedor.Text = dataTable.Rows(posicion).ItemArray(11).ToString()

            lblRegistrosProveedor.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProveedor()
            MessageBox.Show("No hay registros que mostrar", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnPrimeroProveedor_Click(sender As Object, e As EventArgs) Handles btnPrimeroProveedor.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteProveedor_Click(sender As Object, e As EventArgs) Handles btnSiguienteProveedor.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnAnteriorProveedor_Click(sender As Object, e As EventArgs) Handles btnAnteriorProveedor.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUltimoProveedor_Click(sender As Object, e As EventArgs) Handles btnUltimoProveedor.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        If btnAgregarProveedor.Text = "Nuevo" Then 'Nuevo
            btnAgregarProveedor.Text = "Guardar"
            btnModificarProveedor.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)

            limpiarDatosProveedor()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosProveedor(New String() {
                Me.Tag, txtCodigoProveedor.Text, txtNombreEmpresaProveedor.Text, txtNombrePropietarioProveedor.Text, txtTelefonoProveedor.Text, txtEmailProveedor.Text, txtWebSiteProveedor.Text, dtpFechaProveedor.Text, cboPaísProveedor.Text, cboDepartamentoProveedor.Text, cboMunicipioProveedor.Text, cboCantónProveedor.Text
            }, accion)

            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Proveedores",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarProveedor.Text = "Nuevo"
                btnModificarProveedor.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProveedor.Enabled = estado
        btnBuscarProveedor.Enabled = estado
    End Sub
    Private Sub limpiarDatosProveedor()
        txtCodigoProveedor.Text = ""
        txtNombreEmpresaProveedor.Text = ""
        txtNombrePropietarioProveedor.Text = ""
        txtTelefonoProveedor.Text = ""
        txtEmailProveedor.Text = ""
        txtWebSiteProveedor.Text = ""
        dtpFechaProveedor.Text = ""
        cboPaísProveedor.Text = ""
        cboDepartamentoProveedor.Text = ""
        cboMunicipioProveedor.Text = ""
        cboCantónProveedor.Text = ""
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        If btnModificarProveedor.Text = "Modificar" Then 'Modificar
            btnAgregarProveedor.Text = "Guardar"
            btnModificarProveedor.Text = "Cancelar"

            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarProveedor.Text = "Nuevo"
            btnModificarProveedor.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedor.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtNombreEmpresaProveedor.Text, "Registro de Proveedor",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoDatosProveedor(New String() {Me.Tag}, "eliminar")
            If posicion > 0 Then
                posicion -= 1 'Hemos borrado un registro
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Dim objBuscarProveedor As New frmBuscarProveedores
        objBuscarProveedor.ShowDialog()
        If objBuscarProveedor._idP > 0 Then
            posicion = dataTable.Rows.IndexOf(dataTable.Rows.Find(objBuscarProveedor._idP))
            mostrarDatos()
        End If
    End Sub


    Dim objdirecciones = New direcciones()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepartamentoProveedor.Items.AddRange(objdirecciones.dept)
    End Sub

    Private Sub cboPaísProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaísProveedor.SelectedIndexChanged
        cboDepartamentoProveedor.Items.Clear()
        cboDepartamentoProveedor.Text = ""
        cboDepartamentoProveedor.Items.AddRange(objdirecciones.dept(cboPaísProveedor.SelectedIndex))
    End Sub

    Private Sub cboDepartamentoProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartamentoProveedor.SelectedIndexChanged
        cboMunicipioProveedor.Items.Clear()
        cboMunicipioProveedor.Text = ""
        cboMunicipioProveedor.Items.AddRange(objdirecciones.mun(cboDepartamentoProveedor.SelectedIndex))
    End Sub

    Private Sub cboMunicipioProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipioProveedor.SelectedIndexChanged
        cboCantónProveedor.Items.Clear()
        cboCantónProveedor.Text = ""
        cboCantónProveedor.Items.AddRange(objdirecciones.cant(cboMunicipioProveedor.SelectedIndex))
    End Sub
    Class direcciones

        Public pais() As String = {"Seleccione un pais.", "El Salvador"}

        Public dept() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan", "San Salvador", "La Libertad", "Chalatenango", "San Vicente", "Cabañas"}

        Public mun()() As String = {
            New String() {"Seleccione un depto."},
            New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria", "Concepción Batres"},  '0->Usulutan
            New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},'1->San Miguel
            New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},                  '2->La Union
            New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},              '3->Morazan
            New String() {"Seleccione un municipio", "San Salvador", "Apopa", "Aguilares", "Ilopango", "El Paisnal"}, '4->San Salvador
            New String() {"Seleccione un municipio", "Santa Tecla", "Antiguo Cuscatlan", "Cuidad Arce", "Colón", "Comasagua"}, '5->La libertad
            New String() {"Seleccione un municipio", "Agua Caliente", "Arcatao", "Chalatenango", "Dulce Nombre de Maria", "Concepción Quezaltepeque"}, '6->Chalatenango
            New String() {"Seleccione un municipio", "San Vicente", "Apastepeque", "Guadalupe", "San Sebastián", "Santo Domingo"} '7->San Vicente
            }
        Public cant()() As String = {
          New String() {"Selecione un mun."},
          New String() {"selecione un cantón"},
          New String() {"selecione un cantón"},
          New String() {"selecione un cantón"},
           New String() {"selecione un cantón"},
          New String() {"selecione un cantón", "El Cañal", "El paraisal", "El Porvenir", "Hacienda Nueva", "San Ildefonso", "La Anchila", "La Danta", "San Antonio", "San Felipe", "B.º. La Parroquia", "B.º. Candelaria", "B.º. San Antonio", "El Calvario", "Col. Amaya", "Col. El Progeso"} '4>-Concepción Batres
          }



    End Class


End Class