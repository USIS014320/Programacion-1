<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEmpleados))
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.grdBuscarEmpleados = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionarEmpleado = New System.Windows.Forms.Button()
        Me.btnCancelarEmpleado = New System.Windows.Forms.Button()
        CType(Me.grdBuscarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.AutoSize = True
        Me.lblBuscarCliente.Location = New System.Drawing.Point(31, 44)
        Me.lblBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarCliente.TabIndex = 3
        Me.lblBuscarCliente.Text = "BUSCAR:"
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(105, 41)
        Me.txtBuscarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(871, 22)
        Me.txtBuscarEmpleado.TabIndex = 4
        '
        'grdBuscarEmpleados
        '
        Me.grdBuscarEmpleados.AllowUserToAddRows = False
        Me.grdBuscarEmpleados.AllowUserToDeleteRows = False
        Me.grdBuscarEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombre, Me.Usuario, Me.Clave, Me.Direccion, Me.Telefono})
        Me.grdBuscarEmpleados.Location = New System.Drawing.Point(13, 79)
        Me.grdBuscarEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarEmpleados.Name = "grdBuscarEmpleados"
        Me.grdBuscarEmpleados.ReadOnly = True
        Me.grdBuscarEmpleados.RowHeadersWidth = 102
        Me.grdBuscarEmpleados.RowTemplate.Height = 40
        Me.grdBuscarEmpleados.Size = New System.Drawing.Size(1000, 415)
        Me.grdBuscarEmpleados.TabIndex = 5
        '
        'idEmpleado
        '
        Me.idEmpleado.DataPropertyName = "idEmpleado"
        Me.idEmpleado.HeaderText = "ID"
        Me.idEmpleado.MinimumWidth = 12
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Visible = False
        Me.idEmpleado.Width = 350
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 125
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "USUARIO"
        Me.Usuario.HeaderText = "USUARIO"
        Me.Usuario.MinimumWidth = 12
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 150
        '
        'Clave
        '
        Me.Clave.DataPropertyName = "CLAVE"
        Me.Clave.HeaderText = "CLAVE"
        Me.Clave.MinimumWidth = 12
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        Me.Clave.Width = 150
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "DIRECCION"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.MinimumWidth = 12
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 125
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "TELEFONO"
        Me.Telefono.HeaderText = "TELEFONO"
        Me.Telefono.MinimumWidth = 12
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 125
        '
        'btnSeleccionarEmpleado
        '
        Me.btnSeleccionarEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarEmpleado.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSeleccionarEmpleado.Image = CType(resources.GetObject("btnSeleccionarEmpleado.Image"), System.Drawing.Image)
        Me.btnSeleccionarEmpleado.Location = New System.Drawing.Point(859, 514)
        Me.btnSeleccionarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado"
        Me.btnSeleccionarEmpleado.Size = New System.Drawing.Size(75, 41)
        Me.btnSeleccionarEmpleado.TabIndex = 6
        Me.btnSeleccionarEmpleado.UseVisualStyleBackColor = True
        '
        'btnCancelarEmpleado
        '
        Me.btnCancelarEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEmpleado.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCancelarEmpleado.Image = CType(resources.GetObject("btnCancelarEmpleado.Image"), System.Drawing.Image)
        Me.btnCancelarEmpleado.Location = New System.Drawing.Point(936, 514)
        Me.btnCancelarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarEmpleado.Name = "btnCancelarEmpleado"
        Me.btnCancelarEmpleado.Size = New System.Drawing.Size(77, 41)
        Me.btnCancelarEmpleado.TabIndex = 7
        Me.btnCancelarEmpleado.UseVisualStyleBackColor = True
        '
        'frmBuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1039, 567)
        Me.Controls.Add(Me.btnCancelarEmpleado)
        Me.Controls.Add(Me.btnSeleccionarEmpleado)
        Me.Controls.Add(Me.grdBuscarEmpleados)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBuscarEmpleados"
        Me.Text = "Buscar Empleados"
        CType(Me.grdBuscarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents grdBuscarEmpleados As DataGridView
    Friend WithEvents btnSeleccionarEmpleado As Button
    Friend WithEvents btnCancelarEmpleado As Button
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
End Class
