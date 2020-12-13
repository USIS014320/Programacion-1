<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarRegistroPrestamos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarRegistroPrestamos))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grdBuscar = New System.Windows.Forms.DataGridView()
        Me.idPrest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOcupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuotas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaprestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(917, 560)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(57, 41)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.Location = New System.Drawing.Point(860, 560)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(55, 41)
        Me.btnSeleccionar.TabIndex = 28
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(30, 16)
        Me.lblBuscar.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscar.TabIndex = 26
        Me.lblBuscar.Text = "BUSCAR:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(104, 12)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(871, 22)
        Me.txtBuscar.TabIndex = 25
        '
        'grdBuscar
        '
        Me.grdBuscar.AllowUserToAddRows = False
        Me.grdBuscar.AllowUserToDeleteRows = False
        Me.grdBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPrest, Me.idCliente, Me.idOcupacion, Me.idInteres, Me.cedula, Me.monto, Me.cuotas, Me.fechaprestamo, Me.total})
        Me.grdBuscar.Location = New System.Drawing.Point(33, 76)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.ReadOnly = True
        Me.grdBuscar.RowHeadersWidth = 51
        Me.grdBuscar.RowTemplate.Height = 24
        Me.grdBuscar.Size = New System.Drawing.Size(942, 419)
        Me.grdBuscar.TabIndex = 30
        '
        'idPrest
        '
        Me.idPrest.DataPropertyName = "idPrest"
        Me.idPrest.HeaderText = "ID PRESTAMO"
        Me.idPrest.MinimumWidth = 6
        Me.idPrest.Name = "idPrest"
        Me.idPrest.ReadOnly = True
        Me.idPrest.Visible = False
        Me.idPrest.Width = 125
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "idCliente"
        Me.idCliente.HeaderText = "CLIENTE"
        Me.idCliente.MinimumWidth = 6
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Width = 125
        '
        'idOcupacion
        '
        Me.idOcupacion.DataPropertyName = "idOcupacion"
        Me.idOcupacion.HeaderText = "OCUPACION"
        Me.idOcupacion.MinimumWidth = 6
        Me.idOcupacion.Name = "idOcupacion"
        Me.idOcupacion.ReadOnly = True
        Me.idOcupacion.Width = 125
        '
        'idInteres
        '
        Me.idInteres.DataPropertyName = "idInteres"
        Me.idInteres.HeaderText = "INTERES"
        Me.idInteres.MinimumWidth = 6
        Me.idInteres.Name = "idInteres"
        Me.idInteres.ReadOnly = True
        Me.idInteres.Width = 125
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "cedula"
        Me.cedula.HeaderText = "CEDULA"
        Me.cedula.MinimumWidth = 6
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Width = 125
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        Me.monto.HeaderText = "MONTO"
        Me.monto.MinimumWidth = 6
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 125
        '
        'cuotas
        '
        Me.cuotas.DataPropertyName = "cuotas"
        Me.cuotas.HeaderText = "CUOTAS"
        Me.cuotas.MinimumWidth = 6
        Me.cuotas.Name = "cuotas"
        Me.cuotas.ReadOnly = True
        Me.cuotas.Width = 125
        '
        'fechaprestamo
        '
        Me.fechaprestamo.DataPropertyName = "fechaprestamo"
        Me.fechaprestamo.HeaderText = "FECHA DE PRESTAMO"
        Me.fechaprestamo.MinimumWidth = 6
        Me.fechaprestamo.Name = "fechaprestamo"
        Me.fechaprestamo.ReadOnly = True
        Me.fechaprestamo.Width = 125
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "TOTAL"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 125
        '
        'frmBuscarRegistroPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1015, 613)
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarRegistroPrestamos"
        Me.Text = "Busqueda de Registros de Prestamos Creados"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents grdBuscar As DataGridView
    Friend WithEvents idPrest As DataGridViewTextBoxColumn
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents idOcupacion As DataGridViewTextBoxColumn
    Friend WithEvents idInteres As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents cuotas As DataGridViewTextBoxColumn
    Friend WithEvents fechaprestamo As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
