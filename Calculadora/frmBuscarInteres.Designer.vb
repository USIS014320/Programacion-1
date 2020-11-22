<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarInteres
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
        Me.btnCancelarInteres = New System.Windows.Forms.Button()
        Me.btnSeleccionarInteres = New System.Windows.Forms.Button()
        Me.grdBuscarInteres = New System.Windows.Forms.DataGridView()
        Me.lblBuscarInteres = New System.Windows.Forms.Label()
        Me.txtBuscarInteres = New System.Windows.Forms.TextBox()
        Me.idInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarInteres
        '
        Me.btnCancelarInteres.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarInteres.Location = New System.Drawing.Point(802, 562)
        Me.btnCancelarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarInteres.Name = "btnCancelarInteres"
        Me.btnCancelarInteres.Size = New System.Drawing.Size(160, 41)
        Me.btnCancelarInteres.TabIndex = 24
        Me.btnCancelarInteres.Text = "Cancelar"
        Me.btnCancelarInteres.UseVisualStyleBackColor = True
        '
        'btnSeleccionarInteres
        '
        Me.btnSeleccionarInteres.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarInteres.Location = New System.Drawing.Point(452, 562)
        Me.btnSeleccionarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarInteres.Name = "btnSeleccionarInteres"
        Me.btnSeleccionarInteres.Size = New System.Drawing.Size(315, 41)
        Me.btnSeleccionarInteres.TabIndex = 23
        Me.btnSeleccionarInteres.Text = "Seleccionar Cargo"
        Me.btnSeleccionarInteres.UseVisualStyleBackColor = True
        '
        'grdBuscarInteres
        '
        Me.grdBuscarInteres.AllowUserToAddRows = False
        Me.grdBuscarInteres.AllowUserToDeleteRows = False
        Me.grdBuscarInteres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarInteres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idInteres, Me.interes})
        Me.grdBuscarInteres.Location = New System.Drawing.Point(21, 77)
        Me.grdBuscarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarInteres.Name = "grdBuscarInteres"
        Me.grdBuscarInteres.ReadOnly = True
        Me.grdBuscarInteres.RowHeadersWidth = 102
        Me.grdBuscarInteres.RowTemplate.Height = 40
        Me.grdBuscarInteres.Size = New System.Drawing.Size(941, 474)
        Me.grdBuscarInteres.TabIndex = 22
        '
        'lblBuscarInteres
        '
        Me.lblBuscarInteres.AutoSize = True
        Me.lblBuscarInteres.Location = New System.Drawing.Point(18, 18)
        Me.lblBuscarInteres.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarInteres.Name = "lblBuscarInteres"
        Me.lblBuscarInteres.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarInteres.TabIndex = 21
        Me.lblBuscarInteres.Text = "BUSCAR:"
        '
        'txtBuscarInteres
        '
        Me.txtBuscarInteres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarInteres.Location = New System.Drawing.Point(91, 15)
        Me.txtBuscarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarInteres.Name = "txtBuscarInteres"
        Me.txtBuscarInteres.Size = New System.Drawing.Size(871, 22)
        Me.txtBuscarInteres.TabIndex = 20
        '
        'idInteres
        '
        Me.idInteres.DataPropertyName = "idInteres"
        Me.idInteres.HeaderText = "ID"
        Me.idInteres.MinimumWidth = 6
        Me.idInteres.Name = "idInteres"
        Me.idInteres.ReadOnly = True
        Me.idInteres.Visible = False
        Me.idInteres.Width = 125
        '
        'interes
        '
        Me.interes.DataPropertyName = "interes"
        Me.interes.HeaderText = "INTERES"
        Me.interes.MinimumWidth = 6
        Me.interes.Name = "interes"
        Me.interes.ReadOnly = True
        Me.interes.Width = 125
        '
        'frmBuscarInteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(980, 618)
        Me.Controls.Add(Me.btnCancelarInteres)
        Me.Controls.Add(Me.btnSeleccionarInteres)
        Me.Controls.Add(Me.grdBuscarInteres)
        Me.Controls.Add(Me.lblBuscarInteres)
        Me.Controls.Add(Me.txtBuscarInteres)
        Me.Name = "frmBuscarInteres"
        Me.Text = "Busqueda de Interes"
        CType(Me.grdBuscarInteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarInteres As Button
    Friend WithEvents btnSeleccionarInteres As Button
    Friend WithEvents grdBuscarInteres As DataGridView
    Friend WithEvents lblBuscarInteres As Label
    Friend WithEvents txtBuscarInteres As TextBox
    Friend WithEvents idInteres As DataGridViewTextBoxColumn
    Friend WithEvents interes As DataGridViewTextBoxColumn
End Class
