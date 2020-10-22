<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.lblNombredeUsuario = New System.Windows.Forms.Label()
        Me.lblCargoUsuario = New System.Windows.Forms.Label()
        Me.lblClaveUsuario = New System.Windows.Forms.Label()
        Me.txtMarcaProducto = New System.Windows.Forms.TextBox()
        Me.lblTelefonoUsuario = New System.Windows.Forms.Label()
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtNombredeUsuario = New System.Windows.Forms.TextBox()
        Me.lblDireccionUsuario = New System.Windows.Forms.Label()
        Me.txtDireccionUsuario = New System.Windows.Forms.TextBox()
        Me.cboCargoUsuario = New System.Windows.Forms.ComboBox()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosUsuario = New System.Windows.Forms.Label()
        Me.btnUltimoUsuario = New System.Windows.Forms.Button()
        Me.btnSiguienteUsuario = New System.Windows.Forms.Button()
        Me.btnAnteriorUsuario = New System.Windows.Forms.Button()
        Me.btnPrimeroUsuario = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombredeUsuario
        '
        Me.lblNombredeUsuario.AutoSize = True
        Me.lblNombredeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombredeUsuario.Location = New System.Drawing.Point(24, 48)
        Me.lblNombredeUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombredeUsuario.Name = "lblNombredeUsuario"
        Me.lblNombredeUsuario.Size = New System.Drawing.Size(97, 20)
        Me.lblNombredeUsuario.TabIndex = 19
        Me.lblNombredeUsuario.Text = "USUARIO:"
        '
        'lblCargoUsuario
        '
        Me.lblCargoUsuario.AutoSize = True
        Me.lblCargoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoUsuario.Location = New System.Drawing.Point(18, 517)
        Me.lblCargoUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCargoUsuario.Name = "lblCargoUsuario"
        Me.lblCargoUsuario.Size = New System.Drawing.Size(81, 20)
        Me.lblCargoUsuario.TabIndex = 18
        Me.lblCargoUsuario.Text = "CARGO:"
        '
        'lblClaveUsuario
        '
        Me.lblClaveUsuario.AutoSize = True
        Me.lblClaveUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaveUsuario.Location = New System.Drawing.Point(24, 279)
        Me.lblClaveUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblClaveUsuario.Name = "lblClaveUsuario"
        Me.lblClaveUsuario.Size = New System.Drawing.Size(75, 20)
        Me.lblClaveUsuario.TabIndex = 16
        Me.lblClaveUsuario.Text = "CLAVE:"
        '
        'txtMarcaProducto
        '
        Me.txtMarcaProducto.Location = New System.Drawing.Point(181, 275)
        Me.txtMarcaProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMarcaProducto.Name = "txtMarcaProducto"
        Me.txtMarcaProducto.Size = New System.Drawing.Size(253, 22)
        Me.txtMarcaProducto.TabIndex = 15
        '
        'lblTelefonoUsuario
        '
        Me.lblTelefonoUsuario.AutoSize = True
        Me.lblTelefonoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoUsuario.Location = New System.Drawing.Point(24, 202)
        Me.lblTelefonoUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoUsuario.Name = "lblTelefonoUsuario"
        Me.lblTelefonoUsuario.Size = New System.Drawing.Size(107, 20)
        Me.lblTelefonoUsuario.TabIndex = 14
        Me.lblTelefonoUsuario.Text = "TELEFONO"
        '
        'txtTelefonoUsuario
        '
        Me.txtTelefonoUsuario.Location = New System.Drawing.Point(181, 200)
        Me.txtTelefonoUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoUsuario.Name = "txtTelefonoUsuario"
        Me.txtTelefonoUsuario.Size = New System.Drawing.Size(198, 22)
        Me.txtTelefonoUsuario.TabIndex = 13
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(181, 129)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(125, 22)
        Me.txtNombreUsuario.TabIndex = 12
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(24, 129)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(95, 20)
        Me.lblNombreUsuario.TabIndex = 11
        Me.lblNombreUsuario.Text = "NOMBRE:"
        '
        'txtNombredeUsuario
        '
        Me.txtNombredeUsuario.Location = New System.Drawing.Point(181, 46)
        Me.txtNombredeUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombredeUsuario.Name = "txtNombredeUsuario"
        Me.txtNombredeUsuario.Size = New System.Drawing.Size(180, 22)
        Me.txtNombredeUsuario.TabIndex = 20
        '
        'lblDireccionUsuario
        '
        Me.lblDireccionUsuario.AutoSize = True
        Me.lblDireccionUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionUsuario.Location = New System.Drawing.Point(24, 373)
        Me.lblDireccionUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionUsuario.Name = "lblDireccionUsuario"
        Me.lblDireccionUsuario.Size = New System.Drawing.Size(117, 20)
        Me.lblDireccionUsuario.TabIndex = 22
        Me.lblDireccionUsuario.Text = "DIRECCION:"
        '
        'txtDireccionUsuario
        '
        Me.txtDireccionUsuario.Location = New System.Drawing.Point(181, 328)
        Me.txtDireccionUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionUsuario.Multiline = True
        Me.txtDireccionUsuario.Name = "txtDireccionUsuario"
        Me.txtDireccionUsuario.Size = New System.Drawing.Size(443, 126)
        Me.txtDireccionUsuario.TabIndex = 21
        '
        'cboCargoUsuario
        '
        Me.cboCargoUsuario.FormattingEnabled = True
        Me.cboCargoUsuario.Location = New System.Drawing.Point(181, 513)
        Me.cboCargoUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCargoUsuario.Name = "cboCargoUsuario"
        Me.cboCargoUsuario.Size = New System.Drawing.Size(253, 24)
        Me.cboCargoUsuario.TabIndex = 23
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarUsuario)
        Me.grbEdicion.Controls.Add(Me.btnEliminarUsuario)
        Me.grbEdicion.Controls.Add(Me.btnModificarUsuario)
        Me.grbEdicion.Controls.Add(Me.btnAgregarUsuario)
        Me.grbEdicion.Location = New System.Drawing.Point(373, 580)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 25
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(316, 23)
        Me.btnBuscarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(100, 48)
        Me.btnBuscarUsuario.TabIndex = 8
        Me.btnBuscarUsuario.Text = "Buscar"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = True
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(211, 23)
        Me.btnEliminarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(107, 48)
        Me.btnEliminarUsuario.TabIndex = 7
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.Location = New System.Drawing.Point(92, 23)
        Me.btnModificarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarUsuario.TabIndex = 6
        Me.btnModificarUsuario.Text = "Modificar"
        Me.btnModificarUsuario.UseVisualStyleBackColor = True
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(3, 23)
        Me.btnAgregarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarUsuario.TabIndex = 5
        Me.btnAgregarUsuario.Text = "Nuevo"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroUsuario)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 580)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 24
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosUsuario
        '
        Me.lblRegistrosUsuario.AutoSize = True
        Me.lblRegistrosUsuario.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosUsuario.Name = "lblRegistrosUsuario"
        Me.lblRegistrosUsuario.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosUsuario.TabIndex = 4
        Me.lblRegistrosUsuario.Text = "x de n"
        '
        'btnUltimoUsuario
        '
        Me.btnUltimoUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoUsuario.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoUsuario.Name = "btnUltimoUsuario"
        Me.btnUltimoUsuario.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoUsuario.TabIndex = 3
        Me.btnUltimoUsuario.Text = ">|"
        Me.btnUltimoUsuario.UseVisualStyleBackColor = True
        '
        'btnSiguienteUsuario
        '
        Me.btnSiguienteUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteUsuario.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteUsuario.Name = "btnSiguienteUsuario"
        Me.btnSiguienteUsuario.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteUsuario.TabIndex = 2
        Me.btnSiguienteUsuario.Text = ">"
        Me.btnSiguienteUsuario.UseVisualStyleBackColor = True
        '
        'btnAnteriorUsuario
        '
        Me.btnAnteriorUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorUsuario.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorUsuario.Name = "btnAnteriorUsuario"
        Me.btnAnteriorUsuario.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorUsuario.TabIndex = 1
        Me.btnAnteriorUsuario.Text = "<"
        Me.btnAnteriorUsuario.UseVisualStyleBackColor = True
        '
        'btnPrimeroUsuario
        '
        Me.btnPrimeroUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroUsuario.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroUsuario.Name = "btnPrimeroUsuario"
        Me.btnPrimeroUsuario.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroUsuario.TabIndex = 0
        Me.btnPrimeroUsuario.Text = "|<"
        Me.btnPrimeroUsuario.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtDireccionUsuario)
        Me.grbDatos.Controls.Add(Me.lblNombreUsuario)
        Me.grbDatos.Controls.Add(Me.txtNombreUsuario)
        Me.grbDatos.Controls.Add(Me.cboCargoUsuario)
        Me.grbDatos.Controls.Add(Me.txtTelefonoUsuario)
        Me.grbDatos.Controls.Add(Me.lblDireccionUsuario)
        Me.grbDatos.Controls.Add(Me.lblTelefonoUsuario)
        Me.grbDatos.Controls.Add(Me.txtMarcaProducto)
        Me.grbDatos.Controls.Add(Me.txtNombredeUsuario)
        Me.grbDatos.Controls.Add(Me.lblClaveUsuario)
        Me.grbDatos.Controls.Add(Me.lblNombredeUsuario)
        Me.grbDatos.Controls.Add(Me.lblCargoUsuario)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(13, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(780, 557)
        Me.grbDatos.TabIndex = 26
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Usuarios"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(807, 684)
        Me.Controls.Add(Me.grbDatos)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Name = "frmUsuario"
        Me.Text = "Registro de Usuarios"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombredeUsuario As Label
    Friend WithEvents lblCargoUsuario As Label
    Friend WithEvents lblClaveUsuario As Label
    Friend WithEvents txtMarcaProducto As TextBox
    Friend WithEvents lblTelefonoUsuario As Label
    Friend WithEvents txtTelefonoUsuario As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents txtNombredeUsuario As TextBox
    Friend WithEvents lblDireccionUsuario As Label
    Friend WithEvents txtDireccionUsuario As TextBox
    Friend WithEvents cboCargoUsuario As ComboBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnModificarUsuario As Button
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosUsuario As Label
    Friend WithEvents btnUltimoUsuario As Button
    Friend WithEvents btnSiguienteUsuario As Button
    Friend WithEvents btnAnteriorUsuario As Button
    Friend WithEvents btnPrimeroUsuario As Button
    Friend WithEvents grbDatos As GroupBox
End Class
