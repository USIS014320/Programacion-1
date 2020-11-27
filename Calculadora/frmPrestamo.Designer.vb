<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrestamo))
        Me.cboMesPrestamo = New System.Windows.Forms.ComboBox()
        Me.lblMesPrestamo = New System.Windows.Forms.Label()
        Me.btnAplicarDescuento = New System.Windows.Forms.Button()
        Me.txtPagoPrestamo = New System.Windows.Forms.TextBox()
        Me.lblPagoPrestamo = New System.Windows.Forms.Label()
        Me.lblCapitalFinal = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.cboNombreEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtDescuentoPrestamo = New System.Windows.Forms.TextBox()
        Me.lblidEmpleadoPrestamo = New System.Windows.Forms.Label()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblDescuentoPrestamo = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPrestamo = New System.Windows.Forms.Button()
        Me.btnEliminarPrestamo = New System.Windows.Forms.Button()
        Me.btnModificarPrestamo = New System.Windows.Forms.Button()
        Me.btnAgregarPrestamo = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosPrestamo = New System.Windows.Forms.Label()
        Me.btnUltimoPrestamo = New System.Windows.Forms.Button()
        Me.btnSiguientePrestamo = New System.Windows.Forms.Button()
        Me.btnAnteriorPrestamo = New System.Windows.Forms.Button()
        Me.btnPrimeroPrestamo = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMesPrestamo
        '
        Me.cboMesPrestamo.FormattingEnabled = True
        Me.cboMesPrestamo.Location = New System.Drawing.Point(188, 143)
        Me.cboMesPrestamo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMesPrestamo.Name = "cboMesPrestamo"
        Me.cboMesPrestamo.Size = New System.Drawing.Size(253, 24)
        Me.cboMesPrestamo.TabIndex = 17
        '
        'lblMesPrestamo
        '
        Me.lblMesPrestamo.AutoSize = True
        Me.lblMesPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesPrestamo.Location = New System.Drawing.Point(17, 147)
        Me.lblMesPrestamo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMesPrestamo.Name = "lblMesPrestamo"
        Me.lblMesPrestamo.Size = New System.Drawing.Size(54, 20)
        Me.lblMesPrestamo.TabIndex = 16
        Me.lblMesPrestamo.Text = "MES:"
        '
        'btnAplicarDescuento
        '
        Me.btnAplicarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicarDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarDescuento.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAplicarDescuento.Image = CType(resources.GetObject("btnAplicarDescuento.Image"), System.Drawing.Image)
        Me.btnAplicarDescuento.Location = New System.Drawing.Point(249, 331)
        Me.btnAplicarDescuento.Name = "btnAplicarDescuento"
        Me.btnAplicarDescuento.Size = New System.Drawing.Size(88, 55)
        Me.btnAplicarDescuento.TabIndex = 15
        Me.btnAplicarDescuento.UseVisualStyleBackColor = True
        '
        'txtPagoPrestamo
        '
        Me.txtPagoPrestamo.Location = New System.Drawing.Point(188, 215)
        Me.txtPagoPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPagoPrestamo.Name = "txtPagoPrestamo"
        Me.txtPagoPrestamo.Size = New System.Drawing.Size(125, 22)
        Me.txtPagoPrestamo.TabIndex = 14
        '
        'lblPagoPrestamo
        '
        Me.lblPagoPrestamo.AutoSize = True
        Me.lblPagoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoPrestamo.Location = New System.Drawing.Point(17, 215)
        Me.lblPagoPrestamo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPagoPrestamo.Name = "lblPagoPrestamo"
        Me.lblPagoPrestamo.Size = New System.Drawing.Size(67, 20)
        Me.lblPagoPrestamo.TabIndex = 13
        Me.lblPagoPrestamo.Text = "PAGO:"
        '
        'lblCapitalFinal
        '
        Me.lblCapitalFinal.AutoSize = True
        Me.lblCapitalFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapitalFinal.Location = New System.Drawing.Point(17, 431)
        Me.lblCapitalFinal.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCapitalFinal.Name = "lblCapitalFinal"
        Me.lblCapitalFinal.Size = New System.Drawing.Size(91, 20)
        Me.lblCapitalFinal.TabIndex = 12
        Me.lblCapitalFinal.Text = "CAPITAL:"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(188, 429)
        Me.txtCapital.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.ReadOnly = True
        Me.txtCapital.Size = New System.Drawing.Size(253, 22)
        Me.txtCapital.TabIndex = 11
        '
        'cboNombreEmpleado
        '
        Me.cboNombreEmpleado.FormattingEnabled = True
        Me.cboNombreEmpleado.Location = New System.Drawing.Point(188, 53)
        Me.cboNombreEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNombreEmpleado.Name = "cboNombreEmpleado"
        Me.cboNombreEmpleado.Size = New System.Drawing.Size(253, 24)
        Me.cboNombreEmpleado.TabIndex = 10
        '
        'txtDescuentoPrestamo
        '
        Me.txtDescuentoPrestamo.Location = New System.Drawing.Point(188, 277)
        Me.txtDescuentoPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescuentoPrestamo.Name = "txtDescuentoPrestamo"
        Me.txtDescuentoPrestamo.Size = New System.Drawing.Size(253, 22)
        Me.txtDescuentoPrestamo.TabIndex = 5
        '
        'lblidEmpleadoPrestamo
        '
        Me.lblidEmpleadoPrestamo.AutoSize = True
        Me.lblidEmpleadoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidEmpleadoPrestamo.Location = New System.Drawing.Point(17, 57)
        Me.lblidEmpleadoPrestamo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblidEmpleadoPrestamo.Name = "lblidEmpleadoPrestamo"
        Me.lblidEmpleadoPrestamo.Size = New System.Drawing.Size(117, 20)
        Me.lblidEmpleadoPrestamo.TabIndex = 4
        Me.lblidEmpleadoPrestamo.Text = "EMPLEADO:"
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.cboMesPrestamo)
        Me.grbDatos.Controls.Add(Me.lblMesPrestamo)
        Me.grbDatos.Controls.Add(Me.btnAplicarDescuento)
        Me.grbDatos.Controls.Add(Me.txtPagoPrestamo)
        Me.grbDatos.Controls.Add(Me.lblPagoPrestamo)
        Me.grbDatos.Controls.Add(Me.lblCapitalFinal)
        Me.grbDatos.Controls.Add(Me.txtCapital)
        Me.grbDatos.Controls.Add(Me.cboNombreEmpleado)
        Me.grbDatos.Controls.Add(Me.lblDescuentoPrestamo)
        Me.grbDatos.Controls.Add(Me.txtDescuentoPrestamo)
        Me.grbDatos.Controls.Add(Me.lblidEmpleadoPrestamo)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(25, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(783, 495)
        Me.grbDatos.TabIndex = 15
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Prestamos"
        '
        'lblDescuentoPrestamo
        '
        Me.lblDescuentoPrestamo.AutoSize = True
        Me.lblDescuentoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoPrestamo.Location = New System.Drawing.Point(17, 279)
        Me.lblDescuentoPrestamo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescuentoPrestamo.Name = "lblDescuentoPrestamo"
        Me.lblDescuentoPrestamo.Size = New System.Drawing.Size(129, 20)
        Me.lblDescuentoPrestamo.TabIndex = 6
        Me.lblDescuentoPrestamo.Text = "DESCUENTO:"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarPrestamo)
        Me.grbEdicion.Controls.Add(Me.btnEliminarPrestamo)
        Me.grbEdicion.Controls.Add(Me.btnModificarPrestamo)
        Me.grbEdicion.Controls.Add(Me.btnAgregarPrestamo)
        Me.grbEdicion.Location = New System.Drawing.Point(388, 522)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 19
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarPrestamo
        '
        Me.btnBuscarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarPrestamo.Image = CType(resources.GetObject("btnBuscarPrestamo.Image"), System.Drawing.Image)
        Me.btnBuscarPrestamo.Location = New System.Drawing.Point(344, 23)
        Me.btnBuscarPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarPrestamo.Name = "btnBuscarPrestamo"
        Me.btnBuscarPrestamo.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscarPrestamo.TabIndex = 8
        Me.btnBuscarPrestamo.UseVisualStyleBackColor = True
        '
        'btnEliminarPrestamo
        '
        Me.btnEliminarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarPrestamo.Image = CType(resources.GetObject("btnEliminarPrestamo.Image"), System.Drawing.Image)
        Me.btnEliminarPrestamo.Location = New System.Drawing.Point(244, 23)
        Me.btnEliminarPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarPrestamo.Name = "btnEliminarPrestamo"
        Me.btnEliminarPrestamo.Size = New System.Drawing.Size(83, 48)
        Me.btnEliminarPrestamo.TabIndex = 7
        Me.btnEliminarPrestamo.UseVisualStyleBackColor = True
        '
        'btnModificarPrestamo
        '
        Me.btnModificarPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPrestamo.Location = New System.Drawing.Point(121, 23)
        Me.btnModificarPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarPrestamo.Name = "btnModificarPrestamo"
        Me.btnModificarPrestamo.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarPrestamo.TabIndex = 6
        Me.btnModificarPrestamo.Text = "Modificar"
        Me.btnModificarPrestamo.UseVisualStyleBackColor = True
        '
        'btnAgregarPrestamo
        '
        Me.btnAgregarPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPrestamo.Location = New System.Drawing.Point(15, 23)
        Me.btnAgregarPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarPrestamo.Name = "btnAgregarPrestamo"
        Me.btnAgregarPrestamo.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarPrestamo.TabIndex = 5
        Me.btnAgregarPrestamo.Text = "Nuevo"
        Me.btnAgregarPrestamo.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosPrestamo)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoPrestamo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientePrestamo)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorPrestamo)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroPrestamo)
        Me.grbNavegacion.Location = New System.Drawing.Point(25, 522)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 18
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosPrestamo
        '
        Me.lblRegistrosPrestamo.AutoSize = True
        Me.lblRegistrosPrestamo.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosPrestamo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosPrestamo.Name = "lblRegistrosPrestamo"
        Me.lblRegistrosPrestamo.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosPrestamo.TabIndex = 4
        Me.lblRegistrosPrestamo.Text = "x de n"
        '
        'btnUltimoPrestamo
        '
        Me.btnUltimoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimoPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimoPrestamo.Image = CType(resources.GetObject("btnUltimoPrestamo.Image"), System.Drawing.Image)
        Me.btnUltimoPrestamo.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoPrestamo.Name = "btnUltimoPrestamo"
        Me.btnUltimoPrestamo.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoPrestamo.TabIndex = 3
        Me.btnUltimoPrestamo.UseVisualStyleBackColor = True
        '
        'btnSiguientePrestamo
        '
        Me.btnSiguientePrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguientePrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguientePrestamo.Image = CType(resources.GetObject("btnSiguientePrestamo.Image"), System.Drawing.Image)
        Me.btnSiguientePrestamo.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguientePrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguientePrestamo.Name = "btnSiguientePrestamo"
        Me.btnSiguientePrestamo.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguientePrestamo.TabIndex = 2
        Me.btnSiguientePrestamo.UseVisualStyleBackColor = True
        '
        'btnAnteriorPrestamo
        '
        Me.btnAnteriorPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriorPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriorPrestamo.Image = CType(resources.GetObject("btnAnteriorPrestamo.Image"), System.Drawing.Image)
        Me.btnAnteriorPrestamo.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorPrestamo.Name = "btnAnteriorPrestamo"
        Me.btnAnteriorPrestamo.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorPrestamo.TabIndex = 1
        Me.btnAnteriorPrestamo.UseVisualStyleBackColor = True
        '
        'btnPrimeroPrestamo
        '
        Me.btnPrimeroPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeroPrestamo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroPrestamo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimeroPrestamo.Image = CType(resources.GetObject("btnPrimeroPrestamo.Image"), System.Drawing.Image)
        Me.btnPrimeroPrestamo.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroPrestamo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroPrestamo.Name = "btnPrimeroPrestamo"
        Me.btnPrimeroPrestamo.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroPrestamo.TabIndex = 0
        Me.btnPrimeroPrestamo.UseVisualStyleBackColor = True
        '
        'frmPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(821, 616)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrestamo"
        Me.Text = "Datos de Prestamo"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboMesPrestamo As ComboBox
    Friend WithEvents lblMesPrestamo As Label
    Friend WithEvents btnAplicarDescuento As Button
    Friend WithEvents txtPagoPrestamo As TextBox
    Friend WithEvents lblPagoPrestamo As Label
    Friend WithEvents lblCapitalFinal As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents cboNombreEmpleado As ComboBox
    Friend WithEvents txtDescuentoPrestamo As TextBox
    Friend WithEvents lblidEmpleadoPrestamo As Label
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblDescuentoPrestamo As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarPrestamo As Button
    Friend WithEvents btnEliminarPrestamo As Button
    Friend WithEvents btnModificarPrestamo As Button
    Friend WithEvents btnAgregarPrestamo As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosPrestamo As Label
    Friend WithEvents btnUltimoPrestamo As Button
    Friend WithEvents btnSiguientePrestamo As Button
    Friend WithEvents btnAnteriorPrestamo As Button
    Friend WithEvents btnPrimeroPrestamo As Button
End Class
