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
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAnteriorProveedor = New System.Windows.Forms.Button()
        Me.btnPrimeroProveedor = New System.Windows.Forms.Button()
        Me.lblRegistrosProveedor = New System.Windows.Forms.Label()
        Me.btnUltimoProveedor = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnSiguienteProveedor = New System.Windows.Forms.Button()
        Me.lblCodigoProveedor = New System.Windows.Forms.Label()
        Me.txtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresaProveedor = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpresaProveedor = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.lblTelefonoProveedor = New System.Windows.Forms.Label()
        Me.txtEmailProveedor = New System.Windows.Forms.TextBox()
        Me.lblEmailProveedor = New System.Windows.Forms.Label()
        Me.txtNombrePropietarioProveedor = New System.Windows.Forms.TextBox()
        Me.lblNombrePropietarioEmpresaProveedor = New System.Windows.Forms.Label()
        Me.lblWebSiteProveedor = New System.Windows.Forms.Label()
        Me.txtWebSiteProveedor = New System.Windows.Forms.TextBox()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtDepartamentoProveedor = New System.Windows.Forms.TextBox()
        Me.txtMunicipioProveedor = New System.Windows.Forms.TextBox()
        Me.txtCantónProveedor = New System.Windows.Forms.TextBox()
        Me.txtPaísProveedor = New System.Windows.Forms.TextBox()
        Me.lblPaísProveedor = New System.Windows.Forms.Label()
        Me.lblCantónProveedor = New System.Windows.Forms.Label()
        Me.lblMunicipioProveedor = New System.Windows.Forms.Label()
        Me.lblDepartamentoProveedor = New System.Windows.Forms.Label()
        Me.lblFechaProveedor = New System.Windows.Forms.Label()
        Me.txtFechaProveedor = New System.Windows.Forms.TextBox()
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
        Me.grbEdicion.Location = New System.Drawing.Point(393, 664)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(421, 84)
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
        Me.grbNavegacion.Location = New System.Drawing.Point(31, 664)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(783, 84)
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
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(282, 57)
        Me.txtCodigoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(125, 22)
        Me.txtCodigoProveedor.TabIndex = 1
        '
        'txtNombreEmpresaProveedor
        '
        Me.txtNombreEmpresaProveedor.Location = New System.Drawing.Point(282, 116)
        Me.txtNombreEmpresaProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreEmpresaProveedor.Name = "txtNombreEmpresaProveedor"
        Me.txtNombreEmpresaProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtNombreEmpresaProveedor.TabIndex = 3
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
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(282, 235)
        Me.txtTelefonoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtTelefonoProveedor.TabIndex = 7
        '
        'lblTelefonoProveedor
        '
        Me.lblTelefonoProveedor.AutoSize = True
        Me.lblTelefonoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoProveedor.Location = New System.Drawing.Point(20, 235)
        Me.lblTelefonoProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoProveedor.Name = "lblTelefonoProveedor"
        Me.lblTelefonoProveedor.Size = New System.Drawing.Size(113, 20)
        Me.lblTelefonoProveedor.TabIndex = 8
        Me.lblTelefonoProveedor.Text = "TELEFONO:"
        '
        'txtEmailProveedor
        '
        Me.txtEmailProveedor.Location = New System.Drawing.Point(282, 280)
        Me.txtEmailProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmailProveedor.Name = "txtEmailProveedor"
        Me.txtEmailProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtEmailProveedor.TabIndex = 9
        '
        'lblEmailProveedor
        '
        Me.lblEmailProveedor.AccessibleName = ""
        Me.lblEmailProveedor.AutoSize = True
        Me.lblEmailProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailProveedor.Location = New System.Drawing.Point(20, 282)
        Me.lblEmailProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmailProveedor.Name = "lblEmailProveedor"
        Me.lblEmailProveedor.Size = New System.Drawing.Size(70, 20)
        Me.lblEmailProveedor.TabIndex = 10
        Me.lblEmailProveedor.Text = "EMAIL:"
        '
        'txtNombrePropietarioProveedor
        '
        Me.txtNombrePropietarioProveedor.Location = New System.Drawing.Point(282, 186)
        Me.txtNombrePropietarioProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombrePropietarioProveedor.Name = "txtNombrePropietarioProveedor"
        Me.txtNombrePropietarioProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtNombrePropietarioProveedor.TabIndex = 11
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
        'lblWebSiteProveedor
        '
        Me.lblWebSiteProveedor.AccessibleName = ""
        Me.lblWebSiteProveedor.AutoSize = True
        Me.lblWebSiteProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebSiteProveedor.Location = New System.Drawing.Point(20, 336)
        Me.lblWebSiteProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWebSiteProveedor.Name = "lblWebSiteProveedor"
        Me.lblWebSiteProveedor.Size = New System.Drawing.Size(97, 20)
        Me.lblWebSiteProveedor.TabIndex = 13
        Me.lblWebSiteProveedor.Text = "WEBSITE:"
        '
        'txtWebSiteProveedor
        '
        Me.txtWebSiteProveedor.Location = New System.Drawing.Point(282, 334)
        Me.txtWebSiteProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtWebSiteProveedor.Name = "txtWebSiteProveedor"
        Me.txtWebSiteProveedor.Size = New System.Drawing.Size(443, 22)
        Me.txtWebSiteProveedor.TabIndex = 14
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtFechaProveedor)
        Me.grbDatos.Controls.Add(Me.txtDepartamentoProveedor)
        Me.grbDatos.Controls.Add(Me.txtMunicipioProveedor)
        Me.grbDatos.Controls.Add(Me.txtCantónProveedor)
        Me.grbDatos.Controls.Add(Me.txtPaísProveedor)
        Me.grbDatos.Controls.Add(Me.lblPaísProveedor)
        Me.grbDatos.Controls.Add(Me.lblCantónProveedor)
        Me.grbDatos.Controls.Add(Me.lblMunicipioProveedor)
        Me.grbDatos.Controls.Add(Me.lblDepartamentoProveedor)
        Me.grbDatos.Controls.Add(Me.lblFechaProveedor)
        Me.grbDatos.Controls.Add(Me.txtWebSiteProveedor)
        Me.grbDatos.Controls.Add(Me.lblWebSiteProveedor)
        Me.grbDatos.Controls.Add(Me.lblNombrePropietarioEmpresaProveedor)
        Me.grbDatos.Controls.Add(Me.txtNombrePropietarioProveedor)
        Me.grbDatos.Controls.Add(Me.lblEmailProveedor)
        Me.grbDatos.Controls.Add(Me.txtEmailProveedor)
        Me.grbDatos.Controls.Add(Me.lblTelefonoProveedor)
        Me.grbDatos.Controls.Add(Me.txtTelefonoProveedor)
        Me.grbDatos.Controls.Add(Me.lblNombreEmpresaProveedor)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpresaProveedor)
        Me.grbDatos.Controls.Add(Me.txtCodigoProveedor)
        Me.grbDatos.Controls.Add(Me.lblCodigoProveedor)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(31, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(783, 638)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Proveedores"
        '
        'txtDepartamentoProveedor
        '
        Me.txtDepartamentoProveedor.Location = New System.Drawing.Point(282, 495)
        Me.txtDepartamentoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDepartamentoProveedor.Name = "txtDepartamentoProveedor"
        Me.txtDepartamentoProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtDepartamentoProveedor.TabIndex = 66
        '
        'txtMunicipioProveedor
        '
        Me.txtMunicipioProveedor.Location = New System.Drawing.Point(282, 544)
        Me.txtMunicipioProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMunicipioProveedor.Name = "txtMunicipioProveedor"
        Me.txtMunicipioProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtMunicipioProveedor.TabIndex = 65
        '
        'txtCantónProveedor
        '
        Me.txtCantónProveedor.Location = New System.Drawing.Point(282, 599)
        Me.txtCantónProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCantónProveedor.Name = "txtCantónProveedor"
        Me.txtCantónProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtCantónProveedor.TabIndex = 64
        '
        'txtPaísProveedor
        '
        Me.txtPaísProveedor.Location = New System.Drawing.Point(283, 444)
        Me.txtPaísProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPaísProveedor.Name = "txtPaísProveedor"
        Me.txtPaísProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtPaísProveedor.TabIndex = 63
        '
        'lblPaísProveedor
        '
        Me.lblPaísProveedor.AutoSize = True
        Me.lblPaísProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaísProveedor.Location = New System.Drawing.Point(20, 444)
        Me.lblPaísProveedor.Name = "lblPaísProveedor"
        Me.lblPaísProveedor.Size = New System.Drawing.Size(56, 20)
        Me.lblPaísProveedor.TabIndex = 58
        Me.lblPaísProveedor.Text = "PAIS:"
        '
        'lblCantónProveedor
        '
        Me.lblCantónProveedor.AutoSize = True
        Me.lblCantónProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantónProveedor.Location = New System.Drawing.Point(20, 601)
        Me.lblCantónProveedor.Name = "lblCantónProveedor"
        Me.lblCantónProveedor.Size = New System.Drawing.Size(91, 20)
        Me.lblCantónProveedor.TabIndex = 57
        Me.lblCantónProveedor.Text = "CANTON:"
        '
        'lblMunicipioProveedor
        '
        Me.lblMunicipioProveedor.AutoSize = True
        Me.lblMunicipioProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipioProveedor.Location = New System.Drawing.Point(20, 544)
        Me.lblMunicipioProveedor.Name = "lblMunicipioProveedor"
        Me.lblMunicipioProveedor.Size = New System.Drawing.Size(110, 20)
        Me.lblMunicipioProveedor.TabIndex = 56
        Me.lblMunicipioProveedor.Text = "MUNICIPIO:"
        '
        'lblDepartamentoProveedor
        '
        Me.lblDepartamentoProveedor.AutoSize = True
        Me.lblDepartamentoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamentoProveedor.Location = New System.Drawing.Point(20, 495)
        Me.lblDepartamentoProveedor.Name = "lblDepartamentoProveedor"
        Me.lblDepartamentoProveedor.Size = New System.Drawing.Size(166, 20)
        Me.lblDepartamentoProveedor.TabIndex = 55
        Me.lblDepartamentoProveedor.Text = "DEPARTAMENTO:"
        '
        'lblFechaProveedor
        '
        Me.lblFechaProveedor.AccessibleName = ""
        Me.lblFechaProveedor.AutoSize = True
        Me.lblFechaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaProveedor.Location = New System.Drawing.Point(20, 398)
        Me.lblFechaProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFechaProveedor.Name = "lblFechaProveedor"
        Me.lblFechaProveedor.Size = New System.Drawing.Size(199, 20)
        Me.lblFechaProveedor.TabIndex = 54
        Me.lblFechaProveedor.Text = "FECHA PROVEEDOR:"
        '
        'txtFechaProveedor
        '
        Me.txtFechaProveedor.Location = New System.Drawing.Point(282, 396)
        Me.txtFechaProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFechaProveedor.Name = "txtFechaProveedor"
        Me.txtFechaProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtFechaProveedor.TabIndex = 67
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(839, 764)
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
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAnteriorProveedor As Button
    Friend WithEvents btnPrimeroProveedor As Button
    Friend WithEvents lblRegistrosProveedor As Label
    Friend WithEvents btnUltimoProveedor As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents btnSiguienteProveedor As Button
    Friend WithEvents lblCodigoProveedor As Label
    Friend WithEvents txtCodigoProveedor As TextBox
    Friend WithEvents txtNombreEmpresaProveedor As TextBox
    Friend WithEvents lblNombreEmpresaProveedor As Label
    Friend WithEvents txtTelefonoProveedor As TextBox
    Friend WithEvents lblTelefonoProveedor As Label
    Friend WithEvents txtEmailProveedor As TextBox
    Friend WithEvents lblEmailProveedor As Label
    Friend WithEvents txtNombrePropietarioProveedor As TextBox
    Friend WithEvents lblNombrePropietarioEmpresaProveedor As Label
    Friend WithEvents lblWebSiteProveedor As Label
    Friend WithEvents txtWebSiteProveedor As TextBox
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblPaísProveedor As Label
    Friend WithEvents lblCantónProveedor As Label
    Friend WithEvents lblMunicipioProveedor As Label
    Friend WithEvents lblDepartamentoProveedor As Label
    Friend WithEvents lblFechaProveedor As Label
    Friend WithEvents txtDepartamentoProveedor As TextBox
    Friend WithEvents txtMunicipioProveedor As TextBox
    Friend WithEvents txtCantónProveedor As TextBox
    Friend WithEvents txtPaísProveedor As TextBox
    Friend WithEvents txtFechaProveedor As TextBox
End Class
