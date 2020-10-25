<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProductofaltante
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
        Me.btnCancelarfaltante = New System.Windows.Forms.Button()
        Me.btnSeleccionarfaltante = New System.Windows.Forms.Button()
        Me.grdBuscarfaltante = New System.Windows.Forms.DataGridView()
        Me.idFaltante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoriafaltante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoriafalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigofalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionfalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcafalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidasfalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadfalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscarfaltante = New System.Windows.Forms.Label()
        Me.txtBuscarfaltante = New System.Windows.Forms.TextBox()
        CType(Me.grdBuscarfaltante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarfaltante
        '
        Me.btnCancelarfaltante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarfaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarfaltante.Location = New System.Drawing.Point(848, 668)
        Me.btnCancelarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarfaltante.Name = "btnCancelarfaltante"
        Me.btnCancelarfaltante.Size = New System.Drawing.Size(160, 41)
        Me.btnCancelarfaltante.TabIndex = 22
        Me.btnCancelarfaltante.Text = "Cancelar"
        Me.btnCancelarfaltante.UseVisualStyleBackColor = True
        '
        'btnSeleccionarfaltante
        '
        Me.btnSeleccionarfaltante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarfaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarfaltante.Location = New System.Drawing.Point(531, 668)
        Me.btnSeleccionarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarfaltante.Name = "btnSeleccionarfaltante"
        Me.btnSeleccionarfaltante.Size = New System.Drawing.Size(315, 41)
        Me.btnSeleccionarfaltante.TabIndex = 21
        Me.btnSeleccionarfaltante.Text = "Seleccionar Producto"
        Me.btnSeleccionarfaltante.UseVisualStyleBackColor = True
        '
        'grdBuscarfaltante
        '
        Me.grdBuscarfaltante.AllowUserToAddRows = False
        Me.grdBuscarfaltante.AllowUserToDeleteRows = False
        Me.grdBuscarfaltante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarfaltante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarfaltante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFaltante, Me.idCategoriafaltante, Me.categoriafalta, Me.codigofalta, Me.descripcionfalta, Me.marcafalta, Me.medidasfalta, Me.cantidadfalta})
        Me.grdBuscarfaltante.Location = New System.Drawing.Point(28, 62)
        Me.grdBuscarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarfaltante.Name = "grdBuscarfaltante"
        Me.grdBuscarfaltante.ReadOnly = True
        Me.grdBuscarfaltante.RowHeadersWidth = 102
        Me.grdBuscarfaltante.RowTemplate.Height = 40
        Me.grdBuscarfaltante.Size = New System.Drawing.Size(984, 588)
        Me.grdBuscarfaltante.TabIndex = 20
        '
        'idFaltante
        '
        Me.idFaltante.DataPropertyName = "idFaltante"
        Me.idFaltante.HeaderText = "ID"
        Me.idFaltante.MinimumWidth = 12
        Me.idFaltante.Name = "idFaltante"
        Me.idFaltante.ReadOnly = True
        Me.idFaltante.Visible = False
        Me.idFaltante.Width = 350
        '
        'idCategoriafaltante
        '
        Me.idCategoriafaltante.DataPropertyName = "idCategoriafaltante"
        Me.idCategoriafaltante.HeaderText = "IDCAT"
        Me.idCategoriafaltante.MinimumWidth = 6
        Me.idCategoriafaltante.Name = "idCategoriafaltante"
        Me.idCategoriafaltante.ReadOnly = True
        Me.idCategoriafaltante.Visible = False
        Me.idCategoriafaltante.Width = 125
        '
        'categoriafalta
        '
        Me.categoriafalta.DataPropertyName = "categoriafalta"
        Me.categoriafalta.HeaderText = "CATEGORIA"
        Me.categoriafalta.MinimumWidth = 12
        Me.categoriafalta.Name = "categoriafalta"
        Me.categoriafalta.ReadOnly = True
        Me.categoriafalta.Width = 125
        '
        'codigofalta
        '
        Me.codigofalta.DataPropertyName = "codigofalta"
        Me.codigofalta.HeaderText = "CODIGO"
        Me.codigofalta.MinimumWidth = 12
        Me.codigofalta.Name = "codigofalta"
        Me.codigofalta.ReadOnly = True
        Me.codigofalta.Width = 125
        '
        'descripcionfalta
        '
        Me.descripcionfalta.DataPropertyName = "descripcionfalta"
        Me.descripcionfalta.HeaderText = "DESCRIPCION"
        Me.descripcionfalta.MinimumWidth = 12
        Me.descripcionfalta.Name = "descripcionfalta"
        Me.descripcionfalta.ReadOnly = True
        Me.descripcionfalta.Width = 150
        '
        'marcafalta
        '
        Me.marcafalta.DataPropertyName = "marcafalta"
        Me.marcafalta.HeaderText = "MARCA"
        Me.marcafalta.MinimumWidth = 12
        Me.marcafalta.Name = "marcafalta"
        Me.marcafalta.ReadOnly = True
        Me.marcafalta.Width = 150
        '
        'medidasfalta
        '
        Me.medidasfalta.DataPropertyName = "medidasfalta"
        Me.medidasfalta.HeaderText = "MEDIDAS"
        Me.medidasfalta.MinimumWidth = 12
        Me.medidasfalta.Name = "medidasfalta"
        Me.medidasfalta.ReadOnly = True
        Me.medidasfalta.Width = 125
        '
        'cantidadfalta
        '
        Me.cantidadfalta.DataPropertyName = "cantidadfalta"
        Me.cantidadfalta.HeaderText = "CANTIDAD FALTANTE"
        Me.cantidadfalta.MinimumWidth = 6
        Me.cantidadfalta.Name = "cantidadfalta"
        Me.cantidadfalta.ReadOnly = True
        Me.cantidadfalta.Width = 125
        '
        'lblBuscarfaltante
        '
        Me.lblBuscarfaltante.AutoSize = True
        Me.lblBuscarfaltante.Location = New System.Drawing.Point(24, 15)
        Me.lblBuscarfaltante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarfaltante.Name = "lblBuscarfaltante"
        Me.lblBuscarfaltante.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarfaltante.TabIndex = 19
        Me.lblBuscarfaltante.Text = "BUSCAR:"
        '
        'txtBuscarfaltante
        '
        Me.txtBuscarfaltante.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarfaltante.Location = New System.Drawing.Point(97, 11)
        Me.txtBuscarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarfaltante.Name = "txtBuscarfaltante"
        Me.txtBuscarfaltante.Size = New System.Drawing.Size(876, 22)
        Me.txtBuscarfaltante.TabIndex = 18
        '
        'frmBuscarProductofaltante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1045, 719)
        Me.Controls.Add(Me.btnCancelarfaltante)
        Me.Controls.Add(Me.btnSeleccionarfaltante)
        Me.Controls.Add(Me.grdBuscarfaltante)
        Me.Controls.Add(Me.lblBuscarfaltante)
        Me.Controls.Add(Me.txtBuscarfaltante)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmBuscarProductofaltante"
        Me.Text = "Producto Faltante"
        CType(Me.grdBuscarfaltante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarfaltante As Button
    Friend WithEvents btnSeleccionarfaltante As Button
    Friend WithEvents grdBuscarfaltante As DataGridView
    Friend WithEvents lblBuscarfaltante As Label
    Friend WithEvents txtBuscarfaltante As TextBox
    Friend WithEvents idFaltante As DataGridViewTextBoxColumn
    Friend WithEvents idCategoriafaltante As DataGridViewTextBoxColumn
    Friend WithEvents categoriafalta As DataGridViewTextBoxColumn
    Friend WithEvents codigofalta As DataGridViewTextBoxColumn
    Friend WithEvents descripcionfalta As DataGridViewTextBoxColumn
    Friend WithEvents marcafalta As DataGridViewTextBoxColumn
    Friend WithEvents medidasfalta As DataGridViewTextBoxColumn
    Friend WithEvents cantidadfalta As DataGridViewTextBoxColumn
End Class
