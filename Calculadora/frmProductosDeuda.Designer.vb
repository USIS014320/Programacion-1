<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosDeuda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosDeuda))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtMunProducto = New System.Windows.Forms.TextBox()
        Me.txtDeptoProductos = New System.Windows.Forms.TextBox()
        Me.lblMunProducto = New System.Windows.Forms.Label()
        Me.lblDeptoProducto = New System.Windows.Forms.Label()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCliente = New System.Windows.Forms.Label()
        Me.btnUltimoCliente = New System.Windows.Forms.Button()
        Me.btnSiguienteCliente = New System.Windows.Forms.Button()
        Me.btnAnteriorCliente = New System.Windows.Forms.Button()
        Me.btnPrimeroCliente = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtMunProducto)
        Me.grbDatos.Controls.Add(Me.txtDeptoProductos)
        Me.grbDatos.Controls.Add(Me.lblMunProducto)
        Me.grbDatos.Controls.Add(Me.lblDeptoProducto)
        Me.grbDatos.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.txtTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.lblDireccionCliente)
        Me.grbDatos.Controls.Add(Me.txtDireccionCliente)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtCodigoCliente)
        Me.grbDatos.Controls.Add(Me.lblCodigoCliente)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(13, 12)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(783, 521)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Clientes"
        '
        'txtMunProducto
        '
        Me.txtMunProducto.Location = New System.Drawing.Point(192, 431)
        Me.txtMunProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMunProducto.Name = "txtMunProducto"
        Me.txtMunProducto.Size = New System.Drawing.Size(147, 22)
        Me.txtMunProducto.TabIndex = 15
        '
        'txtDeptoProductos
        '
        Me.txtDeptoProductos.Location = New System.Drawing.Point(192, 369)
        Me.txtDeptoProductos.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDeptoProductos.Name = "txtDeptoProductos"
        Me.txtDeptoProductos.Size = New System.Drawing.Size(147, 22)
        Me.txtDeptoProductos.TabIndex = 14
        '
        'lblMunProducto
        '
        Me.lblMunProducto.AutoSize = True
        Me.lblMunProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunProducto.Location = New System.Drawing.Point(68, 431)
        Me.lblMunProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMunProducto.Name = "lblMunProducto"
        Me.lblMunProducto.Size = New System.Drawing.Size(110, 20)
        Me.lblMunProducto.TabIndex = 12
        Me.lblMunProducto.Text = "MUNICIPIO:"
        '
        'lblDeptoProducto
        '
        Me.lblDeptoProducto.AutoSize = True
        Me.lblDeptoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptoProducto.Location = New System.Drawing.Point(3, 370)
        Me.lblDeptoProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDeptoProducto.Name = "lblDeptoProducto"
        Me.lblDeptoProducto.Size = New System.Drawing.Size(166, 20)
        Me.lblDeptoProducto.TabIndex = 11
        Me.lblDeptoProducto.Text = "DEPARTAMENTO:"
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(61, 297)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(113, 20)
        Me.lblTelefonoCliente.TabIndex = 8
        Me.lblTelefonoCliente.Text = "TELEFONO:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(193, 297)
        Me.txtTelefonoCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(147, 22)
        Me.txtTelefonoCliente.TabIndex = 7
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(61, 96)
        Me.lblDireccionCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(117, 20)
        Me.lblDireccionCliente.TabIndex = 6
        Me.lblDireccionCliente.Text = "DIRECCION:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(193, 95)
        Me.txtDireccionCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionCliente.Multiline = True
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(443, 126)
        Me.txtDireccionCliente.TabIndex = 5
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(84, 43)
        Me.lblNombreCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(95, 20)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(193, 43)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(443, 22)
        Me.txtNombreCliente.TabIndex = 3
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(193, 239)
        Me.txtCodigoCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(125, 22)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(91, 239)
        Me.lblCodigoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(89, 20)
        Me.lblCodigoCliente.TabIndex = 0
        Me.lblCodigoCliente.Text = "CODIGO:"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProducto)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProducto)
        Me.grbEdicion.Controls.Add(Me.btnModificarProducto)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProducto)
        Me.grbEdicion.Location = New System.Drawing.Point(376, 554)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 23
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarProducto.Image = CType(resources.GetObject("btnBuscarProducto.Image"), System.Drawing.Image)
        Me.btnBuscarProducto.Location = New System.Drawing.Point(344, 23)
        Me.btnBuscarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscarProducto.TabIndex = 8
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarProducto.Image = CType(resources.GetObject("btnEliminarProducto.Image"), System.Drawing.Image)
        Me.btnEliminarProducto.Location = New System.Drawing.Point(244, 23)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(83, 48)
        Me.btnEliminarProducto.TabIndex = 7
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(121, 23)
        Me.btnModificarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarProducto.TabIndex = 6
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(15, 23)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarProducto.TabIndex = 5
        Me.btnAgregarProducto.Text = "Nuevo"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCliente)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCliente)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCliente)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCliente)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCliente)
        Me.grbNavegacion.Location = New System.Drawing.Point(13, 554)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 22
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCliente
        '
        Me.lblRegistrosCliente.AutoSize = True
        Me.lblRegistrosCliente.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosCliente.Name = "lblRegistrosCliente"
        Me.lblRegistrosCliente.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosCliente.TabIndex = 4
        Me.lblRegistrosCliente.Text = "x de n"
        '
        'btnUltimoCliente
        '
        Me.btnUltimoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimoCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCliente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimoCliente.Image = CType(resources.GetObject("btnUltimoCliente.Image"), System.Drawing.Image)
        Me.btnUltimoCliente.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoCliente.Name = "btnUltimoCliente"
        Me.btnUltimoCliente.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoCliente.TabIndex = 3
        Me.btnUltimoCliente.UseVisualStyleBackColor = True
        '
        'btnSiguienteCliente
        '
        Me.btnSiguienteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCliente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguienteCliente.Image = CType(resources.GetObject("btnSiguienteCliente.Image"), System.Drawing.Image)
        Me.btnSiguienteCliente.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteCliente.Name = "btnSiguienteCliente"
        Me.btnSiguienteCliente.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteCliente.TabIndex = 2
        Me.btnSiguienteCliente.UseVisualStyleBackColor = True
        '
        'btnAnteriorCliente
        '
        Me.btnAnteriorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriorCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCliente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriorCliente.Image = CType(resources.GetObject("btnAnteriorCliente.Image"), System.Drawing.Image)
        Me.btnAnteriorCliente.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorCliente.Name = "btnAnteriorCliente"
        Me.btnAnteriorCliente.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorCliente.TabIndex = 1
        Me.btnAnteriorCliente.UseVisualStyleBackColor = True
        '
        'btnPrimeroCliente
        '
        Me.btnPrimeroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeroCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCliente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimeroCliente.Image = CType(resources.GetObject("btnPrimeroCliente.Image"), System.Drawing.Image)
        Me.btnPrimeroCliente.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroCliente.Name = "btnPrimeroCliente"
        Me.btnPrimeroCliente.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroCliente.TabIndex = 0
        Me.btnPrimeroCliente.UseVisualStyleBackColor = True
        '
        'frmProductosDeuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(816, 663)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProductosDeuda"
        Me.Text = " Productos Deuda"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtMunProducto As TextBox
    Friend WithEvents txtDeptoProductos As TextBox
    Friend WithEvents lblMunProducto As Label
    Friend WithEvents lblDeptoProducto As Label
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents txtDireccionCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents lblCodigoCliente As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCliente As Label
    Friend WithEvents btnUltimoCliente As Button
    Friend WithEvents btnSiguienteCliente As Button
    Friend WithEvents btnAnteriorCliente As Button
    Friend WithEvents btnPrimeroCliente As Button
End Class
