<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.lblEmailProveedor = New System.Windows.Forms.Label()
        Me.txtEmailProveedor = New System.Windows.Forms.TextBox()
        Me.lblTelefonoProveedor = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.lblDireccionProveedor = New System.Windows.Forms.Label()
        Me.txtDireccionProveedor = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpresaProveedor = New System.Windows.Forms.Label()
        Me.txtNombreEmpresaProveedor = New System.Windows.Forms.TextBox()
        Me.txtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAnteriorProveedor = New System.Windows.Forms.Button()
        Me.btnPrimeroProveedor = New System.Windows.Forms.Button()
        Me.lblCodigoProveedor = New System.Windows.Forms.Label()
        Me.lblRegistrosProveedor = New System.Windows.Forms.Label()
        Me.btnUltimoProveedor = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnSiguienteProveedor = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblMunicipioProveedor = New System.Windows.Forms.Label()
        Me.txtMunicipioProveedor = New System.Windows.Forms.TextBox()
        Me.lblDepartamentoProveedor = New System.Windows.Forms.Label()
        Me.txtDepartamentoProveedor = New System.Windows.Forms.TextBox()
        Me.lblPaisProveedor = New System.Windows.Forms.Label()
        Me.txtPaisProveedor = New System.Windows.Forms.TextBox()
        Me.dtpFechaProveedor = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaProveedor = New System.Windows.Forms.Label()
        Me.txtWebSiteProveedor = New System.Windows.Forms.TextBox()
        Me.lblWebSiteProveedor = New System.Windows.Forms.Label()
        Me.lblNombrePropietarioEmpresaProveedor = New System.Windows.Forms.Label()
        Me.txtNombrePropietarioProveedor = New System.Windows.Forms.TextBox()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(3, 23)
        Me.btnAgregarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarProveedor.TabIndex = 5
        Me.btnAgregarProveedor.Text = "Nuevo"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'lblEmailProveedor
        '
        Me.lblEmailProveedor.AccessibleName = ""
        Me.lblEmailProveedor.AutoSize = True
        Me.lblEmailProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailProveedor.Location = New System.Drawing.Point(20, 404)
        Me.lblEmailProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmailProveedor.Name = "lblEmailProveedor"
        Me.lblEmailProveedor.Size = New System.Drawing.Size(70, 20)
        Me.lblEmailProveedor.TabIndex = 10
        Me.lblEmailProveedor.Text = "EMAIL:"
        '
        'txtEmailProveedor
        '
        Me.txtEmailProveedor.Location = New System.Drawing.Point(264, 402)
        Me.txtEmailProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmailProveedor.Name = "txtEmailProveedor"
        Me.txtEmailProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtEmailProveedor.TabIndex = 9
        '
        'lblTelefonoProveedor
        '
        Me.lblTelefonoProveedor.AutoSize = True
        Me.lblTelefonoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoProveedor.Location = New System.Drawing.Point(20, 357)
        Me.lblTelefonoProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoProveedor.Name = "lblTelefonoProveedor"
        Me.lblTelefonoProveedor.Size = New System.Drawing.Size(113, 20)
        Me.lblTelefonoProveedor.TabIndex = 8
        Me.lblTelefonoProveedor.Text = "TELEFONO:"
        '
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(264, 357)
        Me.txtTelefonoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtTelefonoProveedor.TabIndex = 7
        '
        'lblDireccionProveedor
        '
        Me.lblDireccionProveedor.AutoSize = True
        Me.lblDireccionProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionProveedor.Location = New System.Drawing.Point(20, 231)
        Me.lblDireccionProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionProveedor.Name = "lblDireccionProveedor"
        Me.lblDireccionProveedor.Size = New System.Drawing.Size(117, 20)
        Me.lblDireccionProveedor.TabIndex = 6
        Me.lblDireccionProveedor.Text = "DIRECCION:"
        '
        'txtDireccionProveedor
        '
        Me.txtDireccionProveedor.Location = New System.Drawing.Point(264, 231)
        Me.txtDireccionProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionProveedor.Multiline = True
        Me.txtDireccionProveedor.Name = "txtDireccionProveedor"
        Me.txtDireccionProveedor.Size = New System.Drawing.Size(443, 97)
        Me.txtDireccionProveedor.TabIndex = 5
        '
        'lblNombreEmpresaProveedor
        '
        Me.lblNombreEmpresaProveedor.AutoSize = True
        Me.lblNombreEmpresaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresaProveedor.Location = New System.Drawing.Point(20, 116)
        Me.lblNombreEmpresaProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreEmpresaProveedor.Name = "lblNombreEmpresaProveedor"
        Me.lblNombreEmpresaProveedor.Size = New System.Drawing.Size(189, 20)
        Me.lblNombreEmpresaProveedor.TabIndex = 4
        Me.lblNombreEmpresaProveedor.Text = "NOMBRE EMPRESA:"
        '
        'txtNombreEmpresaProveedor
        '
        Me.txtNombreEmpresaProveedor.Location = New System.Drawing.Point(264, 116)
        Me.txtNombreEmpresaProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreEmpresaProveedor.Name = "txtNombreEmpresaProveedor"
        Me.txtNombreEmpresaProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtNombreEmpresaProveedor.TabIndex = 3
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(264, 57)
        Me.txtCodigoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(125, 22)
        Me.txtCodigoProveedor.TabIndex = 1
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(316, 23)
        Me.btnBuscarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(100, 48)
        Me.btnBuscarProveedor.TabIndex = 8
        Me.btnBuscarProveedor.Text = "Buscar"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(211, 23)
        Me.btnEliminarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(107, 48)
        Me.btnEliminarProveedor.TabIndex = 7
        Me.btnEliminarProveedor.Text = "Eliminar"
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnModificarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProveedor)
        Me.grbEdicion.Location = New System.Drawing.Point(408, 772)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProveedor.Location = New System.Drawing.Point(92, 23)
        Me.btnModificarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarProveedor.TabIndex = 6
        Me.btnModificarProveedor.Text = "Modificar"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnAnteriorProveedor
        '
        Me.btnAnteriorProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProveedor.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorProveedor.Name = "btnAnteriorProveedor"
        Me.btnAnteriorProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorProveedor.TabIndex = 1
        Me.btnAnteriorProveedor.Text = "<"
        Me.btnAnteriorProveedor.UseVisualStyleBackColor = True
        '
        'btnPrimeroProveedor
        '
        Me.btnPrimeroProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProveedor.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroProveedor.Name = "btnPrimeroProveedor"
        Me.btnPrimeroProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroProveedor.TabIndex = 0
        Me.btnPrimeroProveedor.Text = "|<"
        Me.btnPrimeroProveedor.UseVisualStyleBackColor = True
        '
        'lblCodigoProveedor
        '
        Me.lblCodigoProveedor.AutoSize = True
        Me.lblCodigoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProveedor.Location = New System.Drawing.Point(20, 57)
        Me.lblCodigoProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Size = New System.Drawing.Size(89, 20)
        Me.lblCodigoProveedor.TabIndex = 0
        Me.lblCodigoProveedor.Text = "CODIGO:"
        '
        'lblRegistrosProveedor
        '
        Me.lblRegistrosProveedor.AutoSize = True
        Me.lblRegistrosProveedor.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosProveedor.Name = "lblRegistrosProveedor"
        Me.lblRegistrosProveedor.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosProveedor.TabIndex = 4
        Me.lblRegistrosProveedor.Text = "x de n"
        '
        'btnUltimoProveedor
        '
        Me.btnUltimoProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProveedor.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoProveedor.Name = "btnUltimoProveedor"
        Me.btnUltimoProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoProveedor.TabIndex = 3
        Me.btnUltimoProveedor.Text = ">|"
        Me.btnUltimoProveedor.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProveedor)
        Me.grbNavegacion.Location = New System.Drawing.Point(46, 772)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'btnSiguienteProveedor
        '
        Me.btnSiguienteProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProveedor.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteProveedor.Name = "btnSiguienteProveedor"
        Me.btnSiguienteProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteProveedor.TabIndex = 2
        Me.btnSiguienteProveedor.Text = ">"
        Me.btnSiguienteProveedor.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblMunicipioProveedor)
        Me.grbDatos.Controls.Add(Me.txtMunicipioProveedor)
        Me.grbDatos.Controls.Add(Me.lblDepartamentoProveedor)
        Me.grbDatos.Controls.Add(Me.txtDepartamentoProveedor)
        Me.grbDatos.Controls.Add(Me.lblPaisProveedor)
        Me.grbDatos.Controls.Add(Me.txtPaisProveedor)
        Me.grbDatos.Controls.Add(Me.dtpFechaProveedor)
        Me.grbDatos.Controls.Add(Me.lblFechaProveedor)
        Me.grbDatos.Controls.Add(Me.txtWebSiteProveedor)
        Me.grbDatos.Controls.Add(Me.lblWebSiteProveedor)
        Me.grbDatos.Controls.Add(Me.lblNombrePropietarioEmpresaProveedor)
        Me.grbDatos.Controls.Add(Me.txtNombrePropietarioProveedor)
        Me.grbDatos.Controls.Add(Me.lblEmailProveedor)
        Me.grbDatos.Controls.Add(Me.txtEmailProveedor)
        Me.grbDatos.Controls.Add(Me.lblTelefonoProveedor)
        Me.grbDatos.Controls.Add(Me.txtTelefonoProveedor)
        Me.grbDatos.Controls.Add(Me.lblDireccionProveedor)
        Me.grbDatos.Controls.Add(Me.txtDireccionProveedor)
        Me.grbDatos.Controls.Add(Me.lblNombreEmpresaProveedor)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpresaProveedor)
        Me.grbDatos.Controls.Add(Me.txtCodigoProveedor)
        Me.grbDatos.Controls.Add(Me.lblCodigoProveedor)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(31, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(783, 745)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Proveedores"
        '
        'lblMunicipioProveedor
        '
        Me.lblMunicipioProveedor.AccessibleName = ""
        Me.lblMunicipioProveedor.AutoSize = True
        Me.lblMunicipioProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipioProveedor.Location = New System.Drawing.Point(20, 692)
        Me.lblMunicipioProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMunicipioProveedor.Name = "lblMunicipioProveedor"
        Me.lblMunicipioProveedor.Size = New System.Drawing.Size(105, 20)
        Me.lblMunicipioProveedor.TabIndex = 22
        Me.lblMunicipioProveedor.Text = "MUNICPIO:"
        '
        'txtMunicipioProveedor
        '
        Me.txtMunicipioProveedor.Location = New System.Drawing.Point(264, 692)
        Me.txtMunicipioProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMunicipioProveedor.Name = "txtMunicipioProveedor"
        Me.txtMunicipioProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtMunicipioProveedor.TabIndex = 21
        '
        'lblDepartamentoProveedor
        '
        Me.lblDepartamentoProveedor.AccessibleName = ""
        Me.lblDepartamentoProveedor.AutoSize = True
        Me.lblDepartamentoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamentoProveedor.Location = New System.Drawing.Point(20, 637)
        Me.lblDepartamentoProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDepartamentoProveedor.Name = "lblDepartamentoProveedor"
        Me.lblDepartamentoProveedor.Size = New System.Drawing.Size(166, 20)
        Me.lblDepartamentoProveedor.TabIndex = 20
        Me.lblDepartamentoProveedor.Text = "DEPARTAMENTO:"
        '
        'txtDepartamentoProveedor
        '
        Me.txtDepartamentoProveedor.Location = New System.Drawing.Point(264, 637)
        Me.txtDepartamentoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDepartamentoProveedor.Name = "txtDepartamentoProveedor"
        Me.txtDepartamentoProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtDepartamentoProveedor.TabIndex = 19
        '
        'lblPaisProveedor
        '
        Me.lblPaisProveedor.AccessibleName = ""
        Me.lblPaisProveedor.AutoSize = True
        Me.lblPaisProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisProveedor.Location = New System.Drawing.Point(20, 583)
        Me.lblPaisProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPaisProveedor.Name = "lblPaisProveedor"
        Me.lblPaisProveedor.Size = New System.Drawing.Size(56, 20)
        Me.lblPaisProveedor.TabIndex = 18
        Me.lblPaisProveedor.Text = "PAIS:"
        '
        'txtPaisProveedor
        '
        Me.txtPaisProveedor.Location = New System.Drawing.Point(264, 581)
        Me.txtPaisProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPaisProveedor.Name = "txtPaisProveedor"
        Me.txtPaisProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtPaisProveedor.TabIndex = 17
        '
        'dtpFechaProveedor
        '
        Me.dtpFechaProveedor.Location = New System.Drawing.Point(264, 510)
        Me.dtpFechaProveedor.Name = "dtpFechaProveedor"
        Me.dtpFechaProveedor.Size = New System.Drawing.Size(247, 22)
        Me.dtpFechaProveedor.TabIndex = 16
        '
        'lblFechaProveedor
        '
        Me.lblFechaProveedor.AccessibleName = ""
        Me.lblFechaProveedor.AutoSize = True
        Me.lblFechaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaProveedor.Location = New System.Drawing.Point(20, 512)
        Me.lblFechaProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFechaProveedor.Name = "lblFechaProveedor"
        Me.lblFechaProveedor.Size = New System.Drawing.Size(199, 20)
        Me.lblFechaProveedor.TabIndex = 15
        Me.lblFechaProveedor.Text = "FECHA PROVEEDOR:"
        '
        'txtWebSiteProveedor
        '
        Me.txtWebSiteProveedor.Location = New System.Drawing.Point(264, 456)
        Me.txtWebSiteProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtWebSiteProveedor.Name = "txtWebSiteProveedor"
        Me.txtWebSiteProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtWebSiteProveedor.TabIndex = 14
        '
        'lblWebSiteProveedor
        '
        Me.lblWebSiteProveedor.AccessibleName = ""
        Me.lblWebSiteProveedor.AutoSize = True
        Me.lblWebSiteProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebSiteProveedor.Location = New System.Drawing.Point(20, 458)
        Me.lblWebSiteProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWebSiteProveedor.Name = "lblWebSiteProveedor"
        Me.lblWebSiteProveedor.Size = New System.Drawing.Size(97, 20)
        Me.lblWebSiteProveedor.TabIndex = 13
        Me.lblWebSiteProveedor.Text = "WEBSITE:"
        '
        'lblNombrePropietarioEmpresaProveedor
        '
        Me.lblNombrePropietarioEmpresaProveedor.AutoSize = True
        Me.lblNombrePropietarioEmpresaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePropietarioEmpresaProveedor.Location = New System.Drawing.Point(20, 186)
        Me.lblNombrePropietarioEmpresaProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombrePropietarioEmpresaProveedor.Name = "lblNombrePropietarioEmpresaProveedor"
        Me.lblNombrePropietarioEmpresaProveedor.Size = New System.Drawing.Size(224, 20)
        Me.lblNombrePropietarioEmpresaProveedor.TabIndex = 12
        Me.lblNombrePropietarioEmpresaProveedor.Text = "NOMBRE PROPIETARIO:"
        '
        'txtNombrePropietarioProveedor
        '
        Me.txtNombrePropietarioProveedor.Location = New System.Drawing.Point(264, 186)
        Me.txtNombrePropietarioProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombrePropietarioProveedor.Name = "txtNombrePropietarioProveedor"
        Me.txtNombrePropietarioProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtNombrePropietarioProveedor.TabIndex = 11
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(872, 866)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmProveedores"
        Me.Text = "Registro de Proveedores"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents lblEmailProveedor As Label
    Friend WithEvents txtEmailProveedor As TextBox
    Friend WithEvents lblTelefonoProveedor As Label
    Friend WithEvents txtTelefonoProveedor As TextBox
    Friend WithEvents lblDireccionProveedor As Label
    Friend WithEvents txtDireccionProveedor As TextBox
    Friend WithEvents lblNombreEmpresaProveedor As Label
    Friend WithEvents txtNombreEmpresaProveedor As TextBox
    Friend WithEvents txtCodigoProveedor As TextBox
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAnteriorProveedor As Button
    Friend WithEvents btnPrimeroProveedor As Button
    Friend WithEvents lblCodigoProveedor As Label
    Friend WithEvents lblRegistrosProveedor As Label
    Friend WithEvents btnUltimoProveedor As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents btnSiguienteProveedor As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblNombrePropietarioEmpresaProveedor As Label
    Friend WithEvents txtNombrePropietarioProveedor As TextBox
    Friend WithEvents txtWebSiteProveedor As TextBox
    Friend WithEvents lblWebSiteProveedor As Label
    Friend WithEvents lblFechaProveedor As Label
    Friend WithEvents lblMunicipioProveedor As Label
    Friend WithEvents txtMunicipioProveedor As TextBox
    Friend WithEvents lblDepartamentoProveedor As Label
    Friend WithEvents txtDepartamentoProveedor As TextBox
    Friend WithEvents lblPaisProveedor As Label
    Friend WithEvents txtPaisProveedor As TextBox
    Friend WithEvents dtpFechaProveedor As DateTimePicker
End Class
