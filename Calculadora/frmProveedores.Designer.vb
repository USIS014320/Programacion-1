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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
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
        Me.txtFechaProveedor = New System.Windows.Forms.TextBox()
        Me.lblFechaProveedor = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosProveedor = New System.Windows.Forms.Label()
        Me.btnUltimoProveedor = New System.Windows.Forms.Button()
        Me.btnSiguienteProveedor = New System.Windows.Forms.Button()
        Me.btnAnteriorProveedor = New System.Windows.Forms.Button()
        Me.btnPrimeroProveedor = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grbDatos.Size = New System.Drawing.Size(783, 458)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Proveedores"
        '
        'txtFechaProveedor
        '
        Me.txtFechaProveedor.Location = New System.Drawing.Point(282, 396)
        Me.txtFechaProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFechaProveedor.Name = "txtFechaProveedor"
        Me.txtFechaProveedor.Size = New System.Drawing.Size(147, 22)
        Me.txtFechaProveedor.TabIndex = 67
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
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnModificarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProveedor)
        Me.grbEdicion.Location = New System.Drawing.Point(394, 498)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 69
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProveedor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarProveedor.Image = CType(resources.GetObject("btnBuscarProveedor.Image"), System.Drawing.Image)
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(344, 23)
        Me.btnBuscarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscarProveedor.TabIndex = 8
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProveedor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarProveedor.Image = CType(resources.GetObject("btnEliminarProveedor.Image"), System.Drawing.Image)
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(244, 23)
        Me.btnEliminarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(83, 48)
        Me.btnEliminarProveedor.TabIndex = 7
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProveedor.Location = New System.Drawing.Point(121, 23)
        Me.btnModificarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarProveedor.TabIndex = 6
        Me.btnModificarProveedor.Text = "Modificar"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(15, 23)
        Me.btnAgregarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarProveedor.TabIndex = 5
        Me.btnAgregarProveedor.Text = "Nuevo"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProveedor)
        Me.grbNavegacion.Location = New System.Drawing.Point(31, 498)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 68
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
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
        Me.btnUltimoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimoProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProveedor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimoProveedor.Image = CType(resources.GetObject("btnUltimoProveedor.Image"), System.Drawing.Image)
        Me.btnUltimoProveedor.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoProveedor.Name = "btnUltimoProveedor"
        Me.btnUltimoProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoProveedor.TabIndex = 3
        Me.btnUltimoProveedor.UseVisualStyleBackColor = True
        '
        'btnSiguienteProveedor
        '
        Me.btnSiguienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProveedor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguienteProveedor.Image = CType(resources.GetObject("btnSiguienteProveedor.Image"), System.Drawing.Image)
        Me.btnSiguienteProveedor.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteProveedor.Name = "btnSiguienteProveedor"
        Me.btnSiguienteProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteProveedor.TabIndex = 2
        Me.btnSiguienteProveedor.UseVisualStyleBackColor = True
        '
        'btnAnteriorProveedor
        '
        Me.btnAnteriorProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriorProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProveedor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriorProveedor.Image = CType(resources.GetObject("btnAnteriorProveedor.Image"), System.Drawing.Image)
        Me.btnAnteriorProveedor.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorProveedor.Name = "btnAnteriorProveedor"
        Me.btnAnteriorProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorProveedor.TabIndex = 1
        Me.btnAnteriorProveedor.UseVisualStyleBackColor = True
        '
        'btnPrimeroProveedor
        '
        Me.btnPrimeroProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeroProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProveedor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimeroProveedor.Image = CType(resources.GetObject("btnPrimeroProveedor.Image"), System.Drawing.Image)
        Me.btnPrimeroProveedor.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroProveedor.Name = "btnPrimeroProveedor"
        Me.btnPrimeroProveedor.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroProveedor.TabIndex = 0
        Me.btnPrimeroProveedor.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(839, 609)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedores"
        Me.Text = "Registro de Proveedores"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents lblFechaProveedor As Label
    Friend WithEvents txtFechaProveedor As TextBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosProveedor As Label
    Friend WithEvents btnUltimoProveedor As Button
    Friend WithEvents btnSiguienteProveedor As Button
    Friend WithEvents btnAnteriorProveedor As Button
    Friend WithEvents btnPrimeroProveedor As Button
End Class
