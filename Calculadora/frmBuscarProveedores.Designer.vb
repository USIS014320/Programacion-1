<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProveedores
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
        Me.btnCancelarProveedor = New System.Windows.Forms.Button()
        Me.btnSeleccionarProveedor = New System.Windows.Forms.Button()
        Me.grdBuscarProveedor = New System.Windows.Forms.DataGridView()
        Me.lblBuscarProveedor = New System.Windows.Forms.Label()
        Me.txtBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreempresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrepropietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.website = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProveedor
        '
        Me.btnCancelarProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProveedor.Location = New System.Drawing.Point(588, 564)
        Me.btnCancelarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarProveedor.Name = "btnCancelarProveedor"
        Me.btnCancelarProveedor.Size = New System.Drawing.Size(160, 41)
        Me.btnCancelarProveedor.TabIndex = 9
        Me.btnCancelarProveedor.Text = "Cancelar"
        Me.btnCancelarProveedor.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProveedor
        '
        Me.btnSeleccionarProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProveedor.Location = New System.Drawing.Point(252, 564)
        Me.btnSeleccionarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor"
        Me.btnSeleccionarProveedor.Size = New System.Drawing.Size(315, 41)
        Me.btnSeleccionarProveedor.TabIndex = 8
        Me.btnSeleccionarProveedor.Text = "Seleccionar Proveedor"
        Me.btnSeleccionarProveedor.UseVisualStyleBackColor = True
        '
        'grdBuscarProveedor
        '
        Me.grdBuscarProveedor.AllowUserToAddRows = False
        Me.grdBuscarProveedor.AllowUserToDeleteRows = False
        Me.grdBuscarProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProveedor.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdBuscarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.codigo, Me.nombreempresa, Me.nombrepropietario, Me.direccion, Me.telefono, Me.email, Me.website, Me.fechaproveedor, Me.pais, Me.departamento, Me.municipio})
        Me.grdBuscarProveedor.Location = New System.Drawing.Point(107, 70)
        Me.grdBuscarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarProveedor.Name = "grdBuscarProveedor"
        Me.grdBuscarProveedor.ReadOnly = True
        Me.grdBuscarProveedor.RowHeadersWidth = 102
        Me.grdBuscarProveedor.RowTemplate.Height = 40
        Me.grdBuscarProveedor.Size = New System.Drawing.Size(641, 474)
        Me.grdBuscarProveedor.TabIndex = 7
        '
        'lblBuscarProveedor
        '
        Me.lblBuscarProveedor.AutoSize = True
        Me.lblBuscarProveedor.Location = New System.Drawing.Point(35, 34)
        Me.lblBuscarProveedor.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarProveedor.Name = "lblBuscarProveedor"
        Me.lblBuscarProveedor.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarProveedor.TabIndex = 6
        Me.lblBuscarProveedor.Text = "BUSCAR:"
        '
        'txtBuscarProveedor
        '
        Me.txtBuscarProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProveedor.Location = New System.Drawing.Point(107, 29)
        Me.txtBuscarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarProveedor.Name = "txtBuscarProveedor"
        Me.txtBuscarProveedor.Size = New System.Drawing.Size(541, 22)
        Me.txtBuscarProveedor.TabIndex = 5
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "idCliente"
        Me.idCliente.HeaderText = "ID"
        Me.idCliente.MinimumWidth = 12
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        Me.idCliente.Width = 350
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.MinimumWidth = 12
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'nombreempresa
        '
        Me.nombreempresa.HeaderText = "NombreEmpresa"
        Me.nombreempresa.MinimumWidth = 6
        Me.nombreempresa.Name = "nombreempresa"
        Me.nombreempresa.ReadOnly = True
        Me.nombreempresa.Width = 125
        '
        'nombrepropietario
        '
        Me.nombrepropietario.HeaderText = "NOMBREPROPIETARIO"
        Me.nombrepropietario.MinimumWidth = 6
        Me.nombrepropietario.Name = "nombrepropietario"
        Me.nombrepropietario.ReadOnly = True
        Me.nombrepropietario.Width = 125
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
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.MinimumWidth = 12
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 125
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 12
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 125
        '
        'website
        '
        Me.website.HeaderText = "WESITE"
        Me.website.MinimumWidth = 6
        Me.website.Name = "website"
        Me.website.ReadOnly = True
        Me.website.Width = 125
        '
        'fechaproveedor
        '
        Me.fechaproveedor.HeaderText = "FECHAPROVEEDOR"
        Me.fechaproveedor.MinimumWidth = 6
        Me.fechaproveedor.Name = "fechaproveedor"
        Me.fechaproveedor.ReadOnly = True
        Me.fechaproveedor.Width = 125
        '
        'pais
        '
        Me.pais.HeaderText = "PAIS"
        Me.pais.MinimumWidth = 6
        Me.pais.Name = "pais"
        Me.pais.ReadOnly = True
        Me.pais.Width = 125
        '
        'departamento
        '
        Me.departamento.HeaderText = "DEPARTAMENTO"
        Me.departamento.MinimumWidth = 6
        Me.departamento.Name = "departamento"
        Me.departamento.ReadOnly = True
        Me.departamento.Width = 125
        '
        'municipio
        '
        Me.municipio.HeaderText = "MUNICIPIO"
        Me.municipio.MinimumWidth = 6
        Me.municipio.Name = "municipio"
        Me.municipio.ReadOnly = True
        Me.municipio.Width = 125
        '
        'frmBuscarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(775, 635)
        Me.Controls.Add(Me.btnCancelarProveedor)
        Me.Controls.Add(Me.btnSeleccionarProveedor)
        Me.Controls.Add(Me.grdBuscarProveedor)
        Me.Controls.Add(Me.lblBuscarProveedor)
        Me.Controls.Add(Me.txtBuscarProveedor)
        Me.Name = "frmBuscarProveedores"
        Me.Text = "Busqueda de Proveedores"
        CType(Me.grdBuscarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProveedor As Button
    Friend WithEvents btnSeleccionarProveedor As Button
    Friend WithEvents grdBuscarProveedor As DataGridView
    Friend WithEvents lblBuscarProveedor As Label
    Friend WithEvents txtBuscarProveedor As TextBox
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombreempresa As DataGridViewTextBoxColumn
    Friend WithEvents nombrepropietario As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents website As DataGridViewTextBoxColumn
    Friend WithEvents fechaproveedor As DataGridViewTextBoxColumn
    Friend WithEvents pais As DataGridViewTextBoxColumn
    Friend WithEvents departamento As DataGridViewTextBoxColumn
    Friend WithEvents municipio As DataGridViewTextBoxColumn
End Class
