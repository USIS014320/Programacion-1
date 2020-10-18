<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.txtDireccionEmpleados = New System.Windows.Forms.TextBox()
        Me.txtTelefonoEmpleados = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtClaveEmpleados = New System.Windows.Forms.TextBox()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreEmpleados = New System.Windows.Forms.TextBox()
        Me.txtUsuarioEmpleados = New System.Windows.Forms.TextBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosEmpleado = New System.Windows.Forms.Label()
        Me.btnUltimoEmpleado = New System.Windows.Forms.Button()
        Me.btnSiguienteEmpleado = New System.Windows.Forms.Button()
        Me.btnAnteriorEmpleado = New System.Windows.Forms.Button()
        Me.btnPrimeroEmpleado = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarEmpleados = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleados = New System.Windows.Forms.Button()
        Me.btnModificarEmpleados = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleados = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblEmailCliente)
        Me.grbDatos.Controls.Add(Me.txtDireccionEmpleados)
        Me.grbDatos.Controls.Add(Me.txtTelefonoEmpleados)
        Me.grbDatos.Controls.Add(Me.lblTelefonoCliente)
        Me.grbDatos.Controls.Add(Me.txtClaveEmpleados)
        Me.grbDatos.Controls.Add(Me.lblDireccionCliente)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpleados)
        Me.grbDatos.Controls.Add(Me.txtUsuarioEmpleados)
        Me.grbDatos.Controls.Add(Me.lblCodigoCliente)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(9, 7)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(476, 449)
        Me.grbDatos.TabIndex = 2
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Empleados"
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCliente.Location = New System.Drawing.Point(15, 376)
        Me.lblEmailCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(96, 17)
        Me.lblEmailCliente.TabIndex = 10
        Me.lblEmailCliente.Text = "TELEFONO:"
        '
        'txtDireccionEmpleados
        '
        Me.txtDireccionEmpleados.Location = New System.Drawing.Point(121, 239)
        Me.txtDireccionEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDireccionEmpleados.Multiline = True
        Me.txtDireccionEmpleados.Name = "txtDireccionEmpleados"
        Me.txtDireccionEmpleados.Size = New System.Drawing.Size(333, 103)
        Me.txtDireccionEmpleados.TabIndex = 5
        '
        'txtTelefonoEmpleados
        '
        Me.txtTelefonoEmpleados.Location = New System.Drawing.Point(121, 377)
        Me.txtTelefonoEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTelefonoEmpleados.Name = "txtTelefonoEmpleados"
        Me.txtTelefonoEmpleados.Size = New System.Drawing.Size(111, 20)
        Me.txtTelefonoEmpleados.TabIndex = 9
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(15, 176)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefonoCliente.TabIndex = 8
        Me.lblTelefonoCliente.Text = "CLAVE:"
        '
        'txtClaveEmpleados
        '
        Me.txtClaveEmpleados.Location = New System.Drawing.Point(121, 176)
        Me.txtClaveEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClaveEmpleados.Name = "txtClaveEmpleados"
        Me.txtClaveEmpleados.Size = New System.Drawing.Size(111, 20)
        Me.txtClaveEmpleados.TabIndex = 7
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.Location = New System.Drawing.Point(15, 240)
        Me.lblDireccionCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(96, 17)
        Me.lblDireccionCliente.TabIndex = 6
        Me.lblDireccionCliente.Text = "DIRECCION:"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(15, 39)
        Me.lblNombreCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(79, 17)
        Me.lblNombreCliente.TabIndex = 4
        Me.lblNombreCliente.Text = "NOMBRE:"
        '
        'txtNombreEmpleados
        '
        Me.txtNombreEmpleados.Location = New System.Drawing.Point(121, 36)
        Me.txtNombreEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreEmpleados.Name = "txtNombreEmpleados"
        Me.txtNombreEmpleados.Size = New System.Drawing.Size(333, 20)
        Me.txtNombreEmpleados.TabIndex = 3
        '
        'txtUsuarioEmpleados
        '
        Me.txtUsuarioEmpleados.Location = New System.Drawing.Point(121, 110)
        Me.txtUsuarioEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsuarioEmpleados.Name = "txtUsuarioEmpleados"
        Me.txtUsuarioEmpleados.Size = New System.Drawing.Size(95, 20)
        Me.txtUsuarioEmpleados.TabIndex = 1
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCliente.Location = New System.Drawing.Point(15, 110)
        Me.lblCodigoCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(82, 17)
        Me.lblCodigoCliente.TabIndex = 0
        Me.lblCodigoCliente.Text = "USUARIO:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroEmpleado)
        Me.grbNavegacion.Location = New System.Drawing.Point(9, 466)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 3
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosEmpleado
        '
        Me.lblRegistrosEmpleado.AutoSize = True
        Me.lblRegistrosEmpleado.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosEmpleado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosEmpleado.Name = "lblRegistrosEmpleado"
        Me.lblRegistrosEmpleado.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosEmpleado.TabIndex = 4
        Me.lblRegistrosEmpleado.Text = "x de n"
        '
        'btnUltimoEmpleado
        '
        Me.btnUltimoEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoEmpleado.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoEmpleado.Name = "btnUltimoEmpleado"
        Me.btnUltimoEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoEmpleado.TabIndex = 3
        Me.btnUltimoEmpleado.Text = ">|"
        Me.btnUltimoEmpleado.UseVisualStyleBackColor = True
        '
        'btnSiguienteEmpleado
        '
        Me.btnSiguienteEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteEmpleado.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteEmpleado.Name = "btnSiguienteEmpleado"
        Me.btnSiguienteEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteEmpleado.TabIndex = 2
        Me.btnSiguienteEmpleado.Text = ">"
        Me.btnSiguienteEmpleado.UseVisualStyleBackColor = True
        '
        'btnAnteriorEmpleado
        '
        Me.btnAnteriorEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorEmpleado.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorEmpleado.Name = "btnAnteriorEmpleado"
        Me.btnAnteriorEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorEmpleado.TabIndex = 1
        Me.btnAnteriorEmpleado.Text = "<"
        Me.btnAnteriorEmpleado.UseVisualStyleBackColor = True
        '
        'btnPrimeroEmpleado
        '
        Me.btnPrimeroEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroEmpleado.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroEmpleado.Name = "btnPrimeroEmpleado"
        Me.btnPrimeroEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroEmpleado.TabIndex = 0
        Me.btnPrimeroEmpleado.Text = "|<"
        Me.btnPrimeroEmpleado.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarEmpleados)
        Me.grbEdicion.Controls.Add(Me.btnEliminarEmpleados)
        Me.grbEdicion.Controls.Add(Me.btnModificarEmpleados)
        Me.grbEdicion.Controls.Add(Me.btnAgregarEmpleados)
        Me.grbEdicion.Location = New System.Drawing.Point(281, 466)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 4
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarEmpleados
        '
        Me.btnBuscarEmpleados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleados.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarEmpleados.Name = "btnBuscarEmpleados"
        Me.btnBuscarEmpleados.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarEmpleados.TabIndex = 8
        Me.btnBuscarEmpleados.Text = "Buscar"
        Me.btnBuscarEmpleados.UseVisualStyleBackColor = True
        '
        'btnEliminarEmpleados
        '
        Me.btnEliminarEmpleados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEmpleados.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarEmpleados.Name = "btnEliminarEmpleados"
        Me.btnEliminarEmpleados.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarEmpleados.TabIndex = 7
        Me.btnEliminarEmpleados.Text = "Eliminar"
        Me.btnEliminarEmpleados.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleados
        '
        Me.btnModificarEmpleados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEmpleados.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarEmpleados.Name = "btnModificarEmpleados"
        Me.btnModificarEmpleados.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarEmpleados.TabIndex = 6
        Me.btnModificarEmpleados.Text = "Modificar"
        Me.btnModificarEmpleados.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleados
        '
        Me.btnAgregarEmpleados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleados.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarEmpleados.Name = "btnAgregarEmpleados"
        Me.btnAgregarEmpleados.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarEmpleados.TabIndex = 5
        Me.btnAgregarEmpleados.Text = "Nuevo"
        Me.btnAgregarEmpleados.UseVisualStyleBackColor = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 544)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmEmpleados"
        Me.Text = "Sistema Empleados"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblEmailCliente As Label
    Friend WithEvents txtDireccionEmpleados As TextBox
    Friend WithEvents txtTelefonoEmpleados As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtClaveEmpleados As TextBox
    Friend WithEvents lblDireccionCliente As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreEmpleados As TextBox
    Friend WithEvents txtUsuarioEmpleados As TextBox
    Friend WithEvents lblCodigoCliente As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosEmpleado As Label
    Friend WithEvents btnUltimoEmpleado As Button
    Friend WithEvents btnSiguienteEmpleado As Button
    Friend WithEvents btnAnteriorEmpleado As Button
    Friend WithEvents btnPrimeroEmpleado As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarEmpleados As Button
    Friend WithEvents btnEliminarEmpleados As Button
    Friend WithEvents btnModificarEmpleados As Button
    Friend WithEvents btnAgregarEmpleados As Button
End Class
