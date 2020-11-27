<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.cboCategoriaProductos = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaProducto = New System.Windows.Forms.Label()
        Me.lblMedidasProducto = New System.Windows.Forms.Label()
        Me.txtMedidasProducto = New System.Windows.Forms.TextBox()
        Me.lblMarcaProducto = New System.Windows.Forms.Label()
        Me.txtMarcaProducto = New System.Windows.Forms.TextBox()
        Me.lblDescripcionProducto = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosProducto = New System.Windows.Forms.Label()
        Me.btnUltimoProducto = New System.Windows.Forms.Button()
        Me.btnSiguienteProducto = New System.Windows.Forms.Button()
        Me.btnAnteriorProducto = New System.Windows.Forms.Button()
        Me.btnPrimeroProducto = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.cboCategoriaProductos)
        Me.grbDatos.Controls.Add(Me.lblCategoriaProducto)
        Me.grbDatos.Controls.Add(Me.lblMedidasProducto)
        Me.grbDatos.Controls.Add(Me.txtMedidasProducto)
        Me.grbDatos.Controls.Add(Me.lblMarcaProducto)
        Me.grbDatos.Controls.Add(Me.txtMarcaProducto)
        Me.grbDatos.Controls.Add(Me.lblDescripcionProducto)
        Me.grbDatos.Controls.Add(Me.txtDescripcionProducto)
        Me.grbDatos.Controls.Add(Me.txtCodigoProducto)
        Me.grbDatos.Controls.Add(Me.lblCodigoProducto)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(17, 17)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(783, 464)
        Me.grbDatos.TabIndex = 9
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Productos"
        '
        'cboCategoriaProductos
        '
        Me.cboCategoriaProductos.FormattingEnabled = True
        Me.cboCategoriaProductos.Location = New System.Drawing.Point(188, 63)
        Me.cboCategoriaProductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCategoriaProductos.Name = "cboCategoriaProductos"
        Me.cboCategoriaProductos.Size = New System.Drawing.Size(253, 24)
        Me.cboCategoriaProductos.TabIndex = 10
        '
        'lblCategoriaProducto
        '
        Me.lblCategoriaProducto.AutoSize = True
        Me.lblCategoriaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaProducto.Location = New System.Drawing.Point(31, 68)
        Me.lblCategoriaProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCategoriaProducto.Name = "lblCategoriaProducto"
        Me.lblCategoriaProducto.Size = New System.Drawing.Size(121, 20)
        Me.lblCategoriaProducto.TabIndex = 9
        Me.lblCategoriaProducto.Text = "CATEGORIA:"
        '
        'lblMedidasProducto
        '
        Me.lblMedidasProducto.AutoSize = True
        Me.lblMedidasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidasProducto.Location = New System.Drawing.Point(31, 370)
        Me.lblMedidasProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMedidasProducto.Name = "lblMedidasProducto"
        Me.lblMedidasProducto.Size = New System.Drawing.Size(99, 20)
        Me.lblMedidasProducto.TabIndex = 8
        Me.lblMedidasProducto.Text = "MEDIDAS:"
        '
        'txtMedidasProducto
        '
        Me.txtMedidasProducto.Location = New System.Drawing.Point(188, 370)
        Me.txtMedidasProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMedidasProducto.Name = "txtMedidasProducto"
        Me.txtMedidasProducto.Size = New System.Drawing.Size(253, 22)
        Me.txtMedidasProducto.TabIndex = 7
        '
        'lblMarcaProducto
        '
        Me.lblMarcaProducto.AutoSize = True
        Me.lblMarcaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaProducto.Location = New System.Drawing.Point(31, 299)
        Me.lblMarcaProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMarcaProducto.Name = "lblMarcaProducto"
        Me.lblMarcaProducto.Size = New System.Drawing.Size(80, 20)
        Me.lblMarcaProducto.TabIndex = 6
        Me.lblMarcaProducto.Text = "MARCA:"
        '
        'txtMarcaProducto
        '
        Me.txtMarcaProducto.Location = New System.Drawing.Point(188, 295)
        Me.txtMarcaProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMarcaProducto.Name = "txtMarcaProducto"
        Me.txtMarcaProducto.Size = New System.Drawing.Size(253, 22)
        Me.txtMarcaProducto.TabIndex = 5
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.AutoSize = True
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(31, 222)
        Me.lblDescripcionProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(141, 20)
        Me.lblDescripcionProducto.TabIndex = 4
        Me.lblDescripcionProducto.Text = "DESCRIPCION:"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(188, 220)
        Me.txtDescripcionProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(443, 22)
        Me.txtDescripcionProducto.TabIndex = 3
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(188, 149)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(125, 22)
        Me.txtCodigoProducto.TabIndex = 1
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProducto.Location = New System.Drawing.Point(31, 149)
        Me.lblCodigoProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(89, 20)
        Me.lblCodigoProducto.TabIndex = 0
        Me.lblCodigoProducto.Text = "CODIGO:"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProducto)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProducto)
        Me.grbEdicion.Controls.Add(Me.btnModificarProducto)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProducto)
        Me.grbEdicion.Location = New System.Drawing.Point(380, 498)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 21
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
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosProducto)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoProducto)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProducto)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProducto)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProducto)
        Me.grbNavegacion.Location = New System.Drawing.Point(17, 498)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 20
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosProducto
        '
        Me.lblRegistrosProducto.AutoSize = True
        Me.lblRegistrosProducto.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosProducto.Name = "lblRegistrosProducto"
        Me.lblRegistrosProducto.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosProducto.TabIndex = 4
        Me.lblRegistrosProducto.Text = "x de n"
        '
        'btnUltimoProducto
        '
        Me.btnUltimoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimoProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimoProducto.Image = CType(resources.GetObject("btnUltimoProducto.Image"), System.Drawing.Image)
        Me.btnUltimoProducto.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoProducto.Name = "btnUltimoProducto"
        Me.btnUltimoProducto.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoProducto.TabIndex = 3
        Me.btnUltimoProducto.UseVisualStyleBackColor = True
        '
        'btnSiguienteProducto
        '
        Me.btnSiguienteProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguienteProducto.Image = CType(resources.GetObject("btnSiguienteProducto.Image"), System.Drawing.Image)
        Me.btnSiguienteProducto.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteProducto.Name = "btnSiguienteProducto"
        Me.btnSiguienteProducto.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteProducto.TabIndex = 2
        Me.btnSiguienteProducto.UseVisualStyleBackColor = True
        '
        'btnAnteriorProducto
        '
        Me.btnAnteriorProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriorProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriorProducto.Image = CType(resources.GetObject("btnAnteriorProducto.Image"), System.Drawing.Image)
        Me.btnAnteriorProducto.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorProducto.Name = "btnAnteriorProducto"
        Me.btnAnteriorProducto.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorProducto.TabIndex = 1
        Me.btnAnteriorProducto.UseVisualStyleBackColor = True
        '
        'btnPrimeroProducto
        '
        Me.btnPrimeroProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeroProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimeroProducto.Image = CType(resources.GetObject("btnPrimeroProducto.Image"), System.Drawing.Image)
        Me.btnPrimeroProducto.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroProducto.Name = "btnPrimeroProducto"
        Me.btnPrimeroProducto.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroProducto.TabIndex = 0
        Me.btnPrimeroProducto.UseVisualStyleBackColor = True
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(817, 592)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmProductos"
        Me.Text = "Datos de producto"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents cboCategoriaProductos As ComboBox
    Friend WithEvents lblCategoriaProducto As Label
    Friend WithEvents lblMedidasProducto As Label
    Friend WithEvents txtMedidasProducto As TextBox
    Friend WithEvents lblMarcaProducto As Label
    Friend WithEvents txtMarcaProducto As TextBox
    Friend WithEvents lblDescripcionProducto As Label
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents lblCodigoProducto As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosProducto As Label
    Friend WithEvents btnUltimoProducto As Button
    Friend WithEvents btnSiguienteProducto As Button
    Friend WithEvents btnAnteriorProducto As Button
    Friend WithEvents btnPrimeroProducto As Button
End Class
