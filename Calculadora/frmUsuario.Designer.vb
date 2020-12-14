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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCargoUsuario = New System.Windows.Forms.Button()
        Me.cboCargoUsuario = New System.Windows.Forms.ComboBox()
        Me.lblCargoUsuario = New System.Windows.Forms.Label()
        Me.txtDireccionUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtTelefonoUsuario = New System.Windows.Forms.TextBox()
        Me.lblDireccionUsuario = New System.Windows.Forms.Label()
        Me.lblTelefonoUsuario = New System.Windows.Forms.Label()
        Me.txtClaveUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblClaveUsuario = New System.Windows.Forms.Label()
        Me.lblNombredeUsuario = New System.Windows.Forms.Label()
        Me.btnPrimeroUsuario = New System.Windows.Forms.Button()
        Me.btnSiguienteUsuario = New System.Windows.Forms.Button()
        Me.btnUltimoUsuario = New System.Windows.Forms.Button()
        Me.lblRegistrosUsuario = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnAnteriorUsuario = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnImprimirUsuario = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.btnBuscarCargoUsuario)
        Me.grbDatos.Controls.Add(Me.cboCargoUsuario)
        Me.grbDatos.Controls.Add(Me.lblCargoUsuario)
        Me.grbDatos.Controls.Add(Me.txtDireccionUsuario)
        Me.grbDatos.Controls.Add(Me.lblNombreUsuario)
        Me.grbDatos.Controls.Add(Me.txtNombreUsuario)
        Me.grbDatos.Controls.Add(Me.txtTelefonoUsuario)
        Me.grbDatos.Controls.Add(Me.lblDireccionUsuario)
        Me.grbDatos.Controls.Add(Me.lblTelefonoUsuario)
        Me.grbDatos.Controls.Add(Me.txtClaveUsuario)
        Me.grbDatos.Controls.Add(Me.txtUsuario)
        Me.grbDatos.Controls.Add(Me.lblClaveUsuario)
        Me.grbDatos.Controls.Add(Me.lblNombredeUsuario)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(8, 8)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(585, 453)
        Me.grbDatos.TabIndex = 29
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Usuarios"
        '
        'btnBuscarCargoUsuario
        '
        Me.btnBuscarCargoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCargoUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCargoUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarCargoUsuario.Image = CType(resources.GetObject("btnBuscarCargoUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarCargoUsuario.Location = New System.Drawing.Point(344, 36)
        Me.btnBuscarCargoUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarCargoUsuario.Name = "btnBuscarCargoUsuario"
        Me.btnBuscarCargoUsuario.Size = New System.Drawing.Size(64, 30)
        Me.btnBuscarCargoUsuario.TabIndex = 32
        Me.btnBuscarCargoUsuario.UseVisualStyleBackColor = True
        '
        'cboCargoUsuario
        '
        Me.cboCargoUsuario.FormattingEnabled = True
        Me.cboCargoUsuario.Location = New System.Drawing.Point(133, 44)
        Me.cboCargoUsuario.Name = "cboCargoUsuario"
        Me.cboCargoUsuario.Size = New System.Drawing.Size(191, 21)
        Me.cboCargoUsuario.TabIndex = 25
        '
        'lblCargoUsuario
        '
        Me.lblCargoUsuario.AutoSize = True
        Me.lblCargoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoUsuario.Location = New System.Drawing.Point(10, 47)
        Me.lblCargoUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCargoUsuario.Name = "lblCargoUsuario"
        Me.lblCargoUsuario.Size = New System.Drawing.Size(68, 17)
        Me.lblCargoUsuario.TabIndex = 24
        Me.lblCargoUsuario.Text = "CARGO:"
        '
        'txtDireccionUsuario
        '
        Me.txtDireccionUsuario.Location = New System.Drawing.Point(133, 327)
        Me.txtDireccionUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionUsuario.Multiline = True
        Me.txtDireccionUsuario.Name = "txtDireccionUsuario"
        Me.txtDireccionUsuario.Size = New System.Drawing.Size(333, 103)
        Me.txtDireccionUsuario.TabIndex = 21
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(10, 166)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(79, 17)
        Me.lblNombreUsuario.TabIndex = 11
        Me.lblNombreUsuario.Text = "NOMBRE:"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(133, 166)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(95, 20)
        Me.txtNombreUsuario.TabIndex = 12
        '
        'txtTelefonoUsuario
        '
        Me.txtTelefonoUsuario.Location = New System.Drawing.Point(133, 222)
        Me.txtTelefonoUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoUsuario.Name = "txtTelefonoUsuario"
        Me.txtTelefonoUsuario.Size = New System.Drawing.Size(150, 20)
        Me.txtTelefonoUsuario.TabIndex = 13
        '
        'lblDireccionUsuario
        '
        Me.lblDireccionUsuario.AutoSize = True
        Me.lblDireccionUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionUsuario.Location = New System.Drawing.Point(10, 360)
        Me.lblDireccionUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionUsuario.Name = "lblDireccionUsuario"
        Me.lblDireccionUsuario.Size = New System.Drawing.Size(96, 17)
        Me.lblDireccionUsuario.TabIndex = 22
        Me.lblDireccionUsuario.Text = "DIRECCION:"
        '
        'lblTelefonoUsuario
        '
        Me.lblTelefonoUsuario.AutoSize = True
        Me.lblTelefonoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoUsuario.Location = New System.Drawing.Point(10, 223)
        Me.lblTelefonoUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoUsuario.Name = "lblTelefonoUsuario"
        Me.lblTelefonoUsuario.Size = New System.Drawing.Size(91, 17)
        Me.lblTelefonoUsuario.TabIndex = 14
        Me.lblTelefonoUsuario.Text = "TELEFONO"
        '
        'txtClaveUsuario
        '
        Me.txtClaveUsuario.Location = New System.Drawing.Point(133, 283)
        Me.txtClaveUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClaveUsuario.Name = "txtClaveUsuario"
        Me.txtClaveUsuario.Size = New System.Drawing.Size(191, 20)
        Me.txtClaveUsuario.TabIndex = 15
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(133, 97)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(136, 20)
        Me.txtUsuario.TabIndex = 20
        '
        'lblClaveUsuario
        '
        Me.lblClaveUsuario.AutoSize = True
        Me.lblClaveUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaveUsuario.Location = New System.Drawing.Point(10, 284)
        Me.lblClaveUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblClaveUsuario.Name = "lblClaveUsuario"
        Me.lblClaveUsuario.Size = New System.Drawing.Size(62, 17)
        Me.lblClaveUsuario.TabIndex = 16
        Me.lblClaveUsuario.Text = "CLAVE:"
        '
        'lblNombredeUsuario
        '
        Me.lblNombredeUsuario.AutoSize = True
        Me.lblNombredeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombredeUsuario.Location = New System.Drawing.Point(10, 98)
        Me.lblNombredeUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombredeUsuario.Name = "lblNombredeUsuario"
        Me.lblNombredeUsuario.Size = New System.Drawing.Size(82, 17)
        Me.lblNombredeUsuario.TabIndex = 19
        Me.lblNombredeUsuario.Text = "USUARIO:"
        '
        'btnPrimeroUsuario
        '
        Me.btnPrimeroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeroUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimeroUsuario.Image = CType(resources.GetObject("btnPrimeroUsuario.Image"), System.Drawing.Image)
        Me.btnPrimeroUsuario.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroUsuario.Name = "btnPrimeroUsuario"
        Me.btnPrimeroUsuario.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroUsuario.TabIndex = 0
        Me.btnPrimeroUsuario.UseVisualStyleBackColor = True
        '
        'btnSiguienteUsuario
        '
        Me.btnSiguienteUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguienteUsuario.Image = CType(resources.GetObject("btnSiguienteUsuario.Image"), System.Drawing.Image)
        Me.btnSiguienteUsuario.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteUsuario.Name = "btnSiguienteUsuario"
        Me.btnSiguienteUsuario.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteUsuario.TabIndex = 2
        Me.btnSiguienteUsuario.UseVisualStyleBackColor = True
        '
        'btnUltimoUsuario
        '
        Me.btnUltimoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimoUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimoUsuario.Image = CType(resources.GetObject("btnUltimoUsuario.Image"), System.Drawing.Image)
        Me.btnUltimoUsuario.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoUsuario.Name = "btnUltimoUsuario"
        Me.btnUltimoUsuario.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoUsuario.TabIndex = 3
        Me.btnUltimoUsuario.UseVisualStyleBackColor = True
        '
        'lblRegistrosUsuario
        '
        Me.lblRegistrosUsuario.AutoSize = True
        Me.lblRegistrosUsuario.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosUsuario.Name = "lblRegistrosUsuario"
        Me.lblRegistrosUsuario.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosUsuario.TabIndex = 4
        Me.lblRegistrosUsuario.Text = "x de n"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorUsuario)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroUsuario)
        Me.grbNavegacion.Location = New System.Drawing.Point(6, 478)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 72
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'btnAnteriorUsuario
        '
        Me.btnAnteriorUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriorUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriorUsuario.Image = CType(resources.GetObject("btnAnteriorUsuario.Image"), System.Drawing.Image)
        Me.btnAnteriorUsuario.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorUsuario.Name = "btnAnteriorUsuario"
        Me.btnAnteriorUsuario.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorUsuario.TabIndex = 1
        Me.btnAnteriorUsuario.UseVisualStyleBackColor = True
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(11, 19)
        Me.btnAgregarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarUsuario.TabIndex = 5
        Me.btnAgregarUsuario.Text = "Nuevo"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarUsuario.Location = New System.Drawing.Point(88, 19)
        Me.btnModificarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarUsuario.TabIndex = 6
        Me.btnModificarUsuario.Text = "Modificar"
        Me.btnModificarUsuario.UseVisualStyleBackColor = True
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarUsuario.Image = CType(resources.GetObject("btnEliminarUsuario.Image"), System.Drawing.Image)
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(172, 19)
        Me.btnEliminarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(45, 39)
        Me.btnEliminarUsuario.TabIndex = 7
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarUsuario.Image = CType(resources.GetObject("btnBuscarUsuario.Image"), System.Drawing.Image)
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(266, 19)
        Me.btnBuscarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(46, 39)
        Me.btnBuscarUsuario.TabIndex = 8
        Me.btnBuscarUsuario.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnImprimirUsuario)
        Me.grbEdicion.Controls.Add(Me.btnBuscarUsuario)
        Me.grbEdicion.Controls.Add(Me.btnEliminarUsuario)
        Me.grbEdicion.Controls.Add(Me.btnModificarUsuario)
        Me.grbEdicion.Controls.Add(Me.btnAgregarUsuario)
        Me.grbEdicion.Location = New System.Drawing.Point(278, 478)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 73
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnImprimirUsuario
        '
        Me.btnImprimirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnImprimirUsuario.Image = CType(resources.GetObject("btnImprimirUsuario.Image"), System.Drawing.Image)
        Me.btnImprimirUsuario.Location = New System.Drawing.Point(219, 19)
        Me.btnImprimirUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnImprimirUsuario.Name = "btnImprimirUsuario"
        Me.btnImprimirUsuario.Size = New System.Drawing.Size(44, 39)
        Me.btnImprimirUsuario.TabIndex = 33
        Me.btnImprimirUsuario.UseVisualStyleBackColor = True
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(604, 554)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmUsuario"
        Me.Text = "Registros de Usuario"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtDireccionUsuario As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtTelefonoUsuario As TextBox
    Friend WithEvents lblDireccionUsuario As Label
    Friend WithEvents lblTelefonoUsuario As Label
    Friend WithEvents txtClaveUsuario As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblClaveUsuario As Label
    Friend WithEvents lblNombredeUsuario As Label
    Friend WithEvents cboCargoUsuario As ComboBox
    Friend WithEvents lblCargoUsuario As Label
    Friend WithEvents btnBuscarCargoUsuario As Button
    Friend WithEvents btnPrimeroUsuario As Button
    Friend WithEvents btnSiguienteUsuario As Button
    Friend WithEvents btnUltimoUsuario As Button
    Friend WithEvents lblRegistrosUsuario As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents btnModificarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnBuscarUsuario As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnAnteriorUsuario As Button
    Friend WithEvents btnImprimirUsuario As Button
End Class
