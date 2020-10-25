<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProductosDeuda
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
        Me.lblBuscarCliente = New System.Windows.Forms.Label()
        Me.txtBuscarProuctos = New System.Windows.Forms.TextBox()
        Me.grdBuscarProductoDeuda = New System.Windows.Forms.DataGridView()
        Me.idProductosDeuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        CType(Me.grdBuscarProductoDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscarCliente
        '
        Me.lblBuscarCliente.AutoSize = True
        Me.lblBuscarCliente.Location = New System.Drawing.Point(40, 30)
        Me.lblBuscarCliente.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarCliente.Name = "lblBuscarCliente"
        Me.lblBuscarCliente.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarCliente.TabIndex = 4
        Me.lblBuscarCliente.Text = "BUSCAR:"
        '
        'txtBuscarProuctos
        '
        Me.txtBuscarProuctos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProuctos.Location = New System.Drawing.Point(115, 26)
        Me.txtBuscarProuctos.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarProuctos.Name = "txtBuscarProuctos"
        Me.txtBuscarProuctos.Size = New System.Drawing.Size(1072, 22)
        Me.txtBuscarProuctos.TabIndex = 5
        '
        'grdBuscarProductoDeuda
        '
        Me.grdBuscarProductoDeuda.AllowUserToAddRows = False
        Me.grdBuscarProductoDeuda.AllowUserToDeleteRows = False
        Me.grdBuscarProductoDeuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProductoDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProductoDeuda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductosDeuda, Me.codigo, Me.nombre, Me.direccion, Me.telefono, Me.depto, Me.Municipio})
        Me.grdBuscarProductoDeuda.Location = New System.Drawing.Point(115, 53)
        Me.grdBuscarProductoDeuda.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarProductoDeuda.Name = "grdBuscarProductoDeuda"
        Me.grdBuscarProductoDeuda.ReadOnly = True
        Me.grdBuscarProductoDeuda.RowHeadersWidth = 102
        Me.grdBuscarProductoDeuda.RowTemplate.Height = 40
        Me.grdBuscarProductoDeuda.Size = New System.Drawing.Size(1073, 506)
        Me.grdBuscarProductoDeuda.TabIndex = 6
        '
        'idProductosDeuda
        '
        Me.idProductosDeuda.DataPropertyName = "idProductosDeuda"
        Me.idProductosDeuda.HeaderText = "ID"
        Me.idProductosDeuda.MinimumWidth = 12
        Me.idProductosDeuda.Name = "idProductosDeuda"
        Me.idProductosDeuda.ReadOnly = True
        Me.idProductosDeuda.Visible = False
        Me.idProductosDeuda.Width = 350
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "NOMBRE"
        Me.codigo.HeaderText = "NOMBRE"
        Me.codigo.MinimumWidth = 12
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "direccion"
        Me.nombre.HeaderText = "DIRECCION"
        Me.nombre.MinimumWidth = 12
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "codigo"
        Me.direccion.HeaderText = "CODIGO"
        Me.direccion.MinimumWidth = 12
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 150
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
        'depto
        '
        Me.depto.DataPropertyName = "depto"
        Me.depto.HeaderText = "DEPARTAMENTO"
        Me.depto.MinimumWidth = 12
        Me.depto.Name = "depto"
        Me.depto.ReadOnly = True
        Me.depto.Width = 125
        '
        'Municipio
        '
        Me.Municipio.DataPropertyName = "MUNICIPIO"
        Me.Municipio.HeaderText = "MUNICIPIO"
        Me.Municipio.MinimumWidth = 6
        Me.Municipio.Name = "Municipio"
        Me.Municipio.ReadOnly = True
        Me.Municipio.Width = 125
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(525, 569)
        Me.btnSeleccionarCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(315, 41)
        Me.btnSeleccionarCliente.TabIndex = 7
        Me.btnSeleccionarCliente.Text = "Seleccionar Cliente"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCliente.Location = New System.Drawing.Point(1028, 569)
        Me.btnCancelarCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(160, 41)
        Me.btnCancelarCliente.TabIndex = 8
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'frmBuscarProductosDeuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1239, 622)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnSeleccionarCliente)
        Me.Controls.Add(Me.grdBuscarProductoDeuda)
        Me.Controls.Add(Me.txtBuscarProuctos)
        Me.Controls.Add(Me.lblBuscarCliente)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmBuscarProductosDeuda"
        Me.Text = "Buscar Productos Deuda"
        CType(Me.grdBuscarProductoDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscarCliente As Label
    Friend WithEvents txtBuscarProuctos As TextBox
    Friend WithEvents grdBuscarProductoDeuda As DataGridView
    Friend WithEvents idProductosDeuda As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents depto As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents btnCancelarCliente As Button
End Class
