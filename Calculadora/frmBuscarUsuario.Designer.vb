<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarUsuario))
        Me.btnCancelarUsuario = New System.Windows.Forms.Button()
        Me.btnSeleccionarUsuario = New System.Windows.Forms.Button()
        Me.grdBuscarUsuario = New System.Windows.Forms.DataGridView()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscarUsuario = New System.Windows.Forms.Label()
        Me.txtBuscarUsuario = New System.Windows.Forms.TextBox()
        CType(Me.grdBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarUsuario
        '
        Me.btnCancelarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCancelarUsuario.Image = CType(resources.GetObject("btnCancelarUsuario.Image"), System.Drawing.Image)
        Me.btnCancelarUsuario.Location = New System.Drawing.Point(925, 546)
        Me.btnCancelarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarUsuario.Name = "btnCancelarUsuario"
        Me.btnCancelarUsuario.Size = New System.Drawing.Size(54, 41)
        Me.btnCancelarUsuario.TabIndex = 14
        Me.btnCancelarUsuario.UseVisualStyleBackColor = True
        '
        'btnSeleccionarUsuario
        '
        Me.btnSeleccionarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarUsuario.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSeleccionarUsuario.Image = CType(resources.GetObject("btnSeleccionarUsuario.Image"), System.Drawing.Image)
        Me.btnSeleccionarUsuario.Location = New System.Drawing.Point(869, 546)
        Me.btnSeleccionarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarUsuario.Name = "btnSeleccionarUsuario"
        Me.btnSeleccionarUsuario.Size = New System.Drawing.Size(54, 41)
        Me.btnSeleccionarUsuario.TabIndex = 13
        Me.btnSeleccionarUsuario.UseVisualStyleBackColor = True
        '
        'grdBuscarUsuario
        '
        Me.grdBuscarUsuario.AllowUserToAddRows = False
        Me.grdBuscarUsuario.AllowUserToDeleteRows = False
        Me.grdBuscarUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.usuario, Me.nombre, Me.telefono, Me.clave, Me.direccion, Me.cargo})
        Me.grdBuscarUsuario.Location = New System.Drawing.Point(38, 90)
        Me.grdBuscarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarUsuario.Name = "grdBuscarUsuario"
        Me.grdBuscarUsuario.ReadOnly = True
        Me.grdBuscarUsuario.RowHeadersWidth = 102
        Me.grdBuscarUsuario.RowTemplate.Height = 40
        Me.grdBuscarUsuario.Size = New System.Drawing.Size(941, 454)
        Me.grdBuscarUsuario.TabIndex = 12
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.HeaderText = "ID"
        Me.idUsuario.MinimumWidth = 6
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.Visible = False
        Me.idUsuario.Width = 125
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "USUARIO"
        Me.usuario.MinimumWidth = 12
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 125
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.MinimumWidth = 12
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.MinimumWidth = 12
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 125
        '
        'clave
        '
        Me.clave.DataPropertyName = "clave"
        Me.clave.HeaderText = "CLAVE"
        Me.clave.MinimumWidth = 12
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Width = 125
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.MinimumWidth = 12
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "CARGO"
        Me.cargo.MinimumWidth = 6
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Width = 125
        '
        'lblBuscarUsuario
        '
        Me.lblBuscarUsuario.AutoSize = True
        Me.lblBuscarUsuario.Location = New System.Drawing.Point(35, 31)
        Me.lblBuscarUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarUsuario.Name = "lblBuscarUsuario"
        Me.lblBuscarUsuario.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarUsuario.TabIndex = 11
        Me.lblBuscarUsuario.Text = "BUSCAR:"
        '
        'txtBuscarUsuario
        '
        Me.txtBuscarUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarUsuario.Location = New System.Drawing.Point(108, 28)
        Me.txtBuscarUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(871, 22)
        Me.txtBuscarUsuario.TabIndex = 10
        '
        'frmBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1043, 597)
        Me.Controls.Add(Me.btnCancelarUsuario)
        Me.Controls.Add(Me.btnSeleccionarUsuario)
        Me.Controls.Add(Me.grdBuscarUsuario)
        Me.Controls.Add(Me.lblBuscarUsuario)
        Me.Controls.Add(Me.txtBuscarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarUsuario"
        Me.Text = "Busqueda de Usuario"
        CType(Me.grdBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarUsuario As Button
    Friend WithEvents btnSeleccionarUsuario As Button
    Friend WithEvents grdBuscarUsuario As DataGridView
    Friend WithEvents lblBuscarUsuario As Label
    Friend WithEvents txtBuscarUsuario As TextBox
    Friend WithEvents idUsuario As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents clave As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
End Class
