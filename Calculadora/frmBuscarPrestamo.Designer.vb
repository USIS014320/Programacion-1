<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarPrestamo))
        Me.btnCancelarPrestamo = New System.Windows.Forms.Button()
        Me.btnSeleccionarEmpleadoPrestamo = New System.Windows.Forms.Button()
        Me.grdBuscarPrestamo = New System.Windows.Forms.DataGridView()
        Me.idSalario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscarEmpleadoPrestamo = New System.Windows.Forms.Label()
        Me.txtBuscarEmpleadoPrestamo = New System.Windows.Forms.TextBox()
        CType(Me.grdBuscarPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarPrestamo
        '
        Me.btnCancelarPrestamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCancelarPrestamo.Image = CType(resources.GetObject("btnCancelarPrestamo.Image"), System.Drawing.Image)
        Me.btnCancelarPrestamo.Location = New System.Drawing.Point(908, 574)
        Me.btnCancelarPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarPrestamo.Name = "btnCancelarPrestamo"
        Me.btnCancelarPrestamo.Size = New System.Drawing.Size(57, 41)
        Me.btnCancelarPrestamo.TabIndex = 24
        Me.btnCancelarPrestamo.UseVisualStyleBackColor = True
        '
        'btnSeleccionarEmpleadoPrestamo
        '
        Me.btnSeleccionarEmpleadoPrestamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarEmpleadoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarEmpleadoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarEmpleadoPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSeleccionarEmpleadoPrestamo.Image = CType(resources.GetObject("btnSeleccionarEmpleadoPrestamo.Image"), System.Drawing.Image)
        Me.btnSeleccionarEmpleadoPrestamo.Location = New System.Drawing.Point(851, 574)
        Me.btnSeleccionarEmpleadoPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarEmpleadoPrestamo.Name = "btnSeleccionarEmpleadoPrestamo"
        Me.btnSeleccionarEmpleadoPrestamo.Size = New System.Drawing.Size(55, 41)
        Me.btnSeleccionarEmpleadoPrestamo.TabIndex = 23
        Me.btnSeleccionarEmpleadoPrestamo.UseVisualStyleBackColor = True
        '
        'grdBuscarPrestamo
        '
        Me.grdBuscarPrestamo.AllowUserToAddRows = False
        Me.grdBuscarPrestamo.AllowUserToDeleteRows = False
        Me.grdBuscarPrestamo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSalario, Me.idEmpleado, Me.nombre, Me.mes, Me.pago, Me.descuento, Me.capital})
        Me.grdBuscarPrestamo.Location = New System.Drawing.Point(35, 79)
        Me.grdBuscarPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarPrestamo.Name = "grdBuscarPrestamo"
        Me.grdBuscarPrestamo.ReadOnly = True
        Me.grdBuscarPrestamo.RowHeadersWidth = 102
        Me.grdBuscarPrestamo.RowTemplate.Height = 40
        Me.grdBuscarPrestamo.Size = New System.Drawing.Size(941, 474)
        Me.grdBuscarPrestamo.TabIndex = 22
        '
        'idSalario
        '
        Me.idSalario.DataPropertyName = "idSalario"
        Me.idSalario.HeaderText = "ID"
        Me.idSalario.MinimumWidth = 6
        Me.idSalario.Name = "idSalario"
        Me.idSalario.ReadOnly = True
        Me.idSalario.Visible = False
        Me.idSalario.Width = 125
        '
        'idEmpleado
        '
        Me.idEmpleado.DataPropertyName = "idEmpleado"
        Me.idEmpleado.HeaderText = "IDEMPLEADO"
        Me.idEmpleado.MinimumWidth = 6
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Visible = False
        Me.idEmpleado.Width = 125
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.MinimumWidth = 12
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 125
        '
        'mes
        '
        Me.mes.DataPropertyName = "mes"
        Me.mes.HeaderText = "MES"
        Me.mes.MinimumWidth = 6
        Me.mes.Name = "mes"
        Me.mes.ReadOnly = True
        Me.mes.Width = 125
        '
        'pago
        '
        Me.pago.DataPropertyName = "pago"
        Me.pago.HeaderText = "PAGO"
        Me.pago.MinimumWidth = 6
        Me.pago.Name = "pago"
        Me.pago.ReadOnly = True
        Me.pago.Width = 125
        '
        'descuento
        '
        Me.descuento.DataPropertyName = "descuento"
        Me.descuento.HeaderText = "DESCUENTO"
        Me.descuento.MinimumWidth = 12
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Width = 150
        '
        'capital
        '
        Me.capital.DataPropertyName = "capital"
        Me.capital.HeaderText = "CAPITAL"
        Me.capital.MinimumWidth = 12
        Me.capital.Name = "capital"
        Me.capital.ReadOnly = True
        Me.capital.Width = 125
        '
        'lblBuscarEmpleadoPrestamo
        '
        Me.lblBuscarEmpleadoPrestamo.AutoSize = True
        Me.lblBuscarEmpleadoPrestamo.Location = New System.Drawing.Point(21, 30)
        Me.lblBuscarEmpleadoPrestamo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarEmpleadoPrestamo.Name = "lblBuscarEmpleadoPrestamo"
        Me.lblBuscarEmpleadoPrestamo.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarEmpleadoPrestamo.TabIndex = 21
        Me.lblBuscarEmpleadoPrestamo.Text = "BUSCAR:"
        '
        'txtBuscarEmpleadoPrestamo
        '
        Me.txtBuscarEmpleadoPrestamo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarEmpleadoPrestamo.Location = New System.Drawing.Point(95, 26)
        Me.txtBuscarEmpleadoPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarEmpleadoPrestamo.Name = "txtBuscarEmpleadoPrestamo"
        Me.txtBuscarEmpleadoPrestamo.Size = New System.Drawing.Size(871, 22)
        Me.txtBuscarEmpleadoPrestamo.TabIndex = 20
        '
        'frmBuscarPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(989, 640)
        Me.Controls.Add(Me.btnCancelarPrestamo)
        Me.Controls.Add(Me.btnSeleccionarEmpleadoPrestamo)
        Me.Controls.Add(Me.grdBuscarPrestamo)
        Me.Controls.Add(Me.lblBuscarEmpleadoPrestamo)
        Me.Controls.Add(Me.txtBuscarEmpleadoPrestamo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmBuscarPrestamo"
        Me.Text = "Busqueda de Cuotas de Prestamo"
        CType(Me.grdBuscarPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarPrestamo As Button
    Friend WithEvents btnSeleccionarEmpleadoPrestamo As Button
    Friend WithEvents grdBuscarPrestamo As DataGridView
    Friend WithEvents lblBuscarEmpleadoPrestamo As Label
    Friend WithEvents txtBuscarEmpleadoPrestamo As TextBox
    Friend WithEvents idSalario As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents pago As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents capital As DataGridViewTextBoxColumn
End Class
