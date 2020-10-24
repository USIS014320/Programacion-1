<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarvarios
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
        Me.btnCancelarvarios = New System.Windows.Forms.Button()
        Me.btnSeleccionarvarios = New System.Windows.Forms.Button()
        Me.grdBuscarvarios = New System.Windows.Forms.DataGridView()
        Me.lblBuscarvarios = New System.Windows.Forms.Label()
        Me.txtBuscarvarios = New System.Windows.Forms.TextBox()
        Me.idVarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarvarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarvarios
        '
        Me.btnCancelarvarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarvarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarvarios.Location = New System.Drawing.Point(625, 488)
        Me.btnCancelarvarios.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarvarios.Name = "btnCancelarvarios"
        Me.btnCancelarvarios.Size = New System.Drawing.Size(120, 33)
        Me.btnCancelarvarios.TabIndex = 22
        Me.btnCancelarvarios.Text = "Cancelar"
        Me.btnCancelarvarios.UseVisualStyleBackColor = True
        '
        'btnSeleccionarvarios
        '
        Me.btnSeleccionarvarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarvarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarvarios.Location = New System.Drawing.Point(387, 488)
        Me.btnSeleccionarvarios.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarvarios.Name = "btnSeleccionarvarios"
        Me.btnSeleccionarvarios.Size = New System.Drawing.Size(236, 33)
        Me.btnSeleccionarvarios.TabIndex = 21
        Me.btnSeleccionarvarios.Text = "Seleccionar"
        Me.btnSeleccionarvarios.UseVisualStyleBackColor = True
        '
        'grdBuscarvarios
        '
        Me.grdBuscarvarios.AllowUserToAddRows = False
        Me.grdBuscarvarios.AllowUserToDeleteRows = False
        Me.grdBuscarvarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarvarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarvarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVarios, Me.codigo, Me.tipoproducto, Me.nfactura, Me.descripcion, Me.cantidad})
        Me.grdBuscarvarios.Location = New System.Drawing.Point(14, 41)
        Me.grdBuscarvarios.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarvarios.Name = "grdBuscarvarios"
        Me.grdBuscarvarios.ReadOnly = True
        Me.grdBuscarvarios.RowHeadersWidth = 102
        Me.grdBuscarvarios.RowTemplate.Height = 40
        Me.grdBuscarvarios.Size = New System.Drawing.Size(731, 435)
        Me.grdBuscarvarios.TabIndex = 20
        '
        'lblBuscarvarios
        '
        Me.lblBuscarvarios.AutoSize = True
        Me.lblBuscarvarios.Location = New System.Drawing.Point(11, 13)
        Me.lblBuscarvarios.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarvarios.Name = "lblBuscarvarios"
        Me.lblBuscarvarios.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarvarios.TabIndex = 19
        Me.lblBuscarvarios.Text = "BUSCAR:"
        '
        'txtBuscarvarios
        '
        Me.txtBuscarvarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarvarios.Location = New System.Drawing.Point(66, 10)
        Me.txtBuscarvarios.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarvarios.Name = "txtBuscarvarios"
        Me.txtBuscarvarios.Size = New System.Drawing.Size(641, 20)
        Me.txtBuscarvarios.TabIndex = 18
        '
        'idVarios
        '
        Me.idVarios.DataPropertyName = "idVarios"
        Me.idVarios.HeaderText = "ID"
        Me.idVarios.MinimumWidth = 12
        Me.idVarios.Name = "idVarios"
        Me.idVarios.ReadOnly = True
        Me.idVarios.Visible = False
        Me.idVarios.Width = 350
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.MinimumWidth = 12
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'tipoproducto
        '
        Me.tipoproducto.DataPropertyName = "tipoproducto"
        Me.tipoproducto.HeaderText = "TIPO DE PRODUCTO"
        Me.tipoproducto.MinimumWidth = 12
        Me.tipoproducto.Name = "tipoproducto"
        Me.tipoproducto.ReadOnly = True
        '
        'nfactura
        '
        Me.nfactura.DataPropertyName = "nfactura"
        Me.nfactura.HeaderText = "NUMERO DE FACTURA"
        Me.nfactura.MinimumWidth = 12
        Me.nfactura.Name = "nfactura"
        Me.nfactura.ReadOnly = True
        Me.nfactura.Width = 150
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.MinimumWidth = 12
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "MONTO A PAGAR"
        Me.cantidad.MinimumWidth = 12
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'frmBuscarvarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 527)
        Me.Controls.Add(Me.btnCancelarvarios)
        Me.Controls.Add(Me.btnSeleccionarvarios)
        Me.Controls.Add(Me.grdBuscarvarios)
        Me.Controls.Add(Me.lblBuscarvarios)
        Me.Controls.Add(Me.txtBuscarvarios)
        Me.Name = "frmBuscarvarios"
        Me.Text = "Buscar pagos varios"
        CType(Me.grdBuscarvarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarvarios As Button
    Friend WithEvents btnSeleccionarvarios As Button
    Friend WithEvents grdBuscarvarios As DataGridView
    Friend WithEvents lblBuscarvarios As Label
    Friend WithEvents txtBuscarvarios As TextBox
    Friend WithEvents idVarios As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents tipoproducto As DataGridViewTextBoxColumn
    Friend WithEvents nfactura As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
End Class
