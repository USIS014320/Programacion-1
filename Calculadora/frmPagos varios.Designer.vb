<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPagosVarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagosVarios))
        Me.grbPagosvarios = New System.Windows.Forms.GroupBox()
        Me.lblCantidadtipo = New System.Windows.Forms.Label()
        Me.txtDescripciontipo = New System.Windows.Forms.TextBox()
        Me.txtCantidadtipo = New System.Windows.Forms.TextBox()
        Me.lblnfactura = New System.Windows.Forms.Label()
        Me.txtnfactura = New System.Windows.Forms.TextBox()
        Me.lblDescripciontipo = New System.Windows.Forms.Label()
        Me.lblTipoproducto = New System.Windows.Forms.Label()
        Me.txtTipodeproducto = New System.Windows.Forms.TextBox()
        Me.txtCodigotipo = New System.Windows.Forms.TextBox()
        Me.lblCodigotipo = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscartipo = New System.Windows.Forms.Button()
        Me.btnEliminartipo = New System.Windows.Forms.Button()
        Me.btnModificartipo = New System.Windows.Forms.Button()
        Me.btnAgregartipo = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrostipo = New System.Windows.Forms.Label()
        Me.btnUltimotipo = New System.Windows.Forms.Button()
        Me.btnSiguientetipo = New System.Windows.Forms.Button()
        Me.btnAnteriortipo = New System.Windows.Forms.Button()
        Me.btnPrimerotipo = New System.Windows.Forms.Button()
        Me.grbPagosvarios.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPagosvarios
        '
        Me.grbPagosvarios.Controls.Add(Me.lblCantidadtipo)
        Me.grbPagosvarios.Controls.Add(Me.txtDescripciontipo)
        Me.grbPagosvarios.Controls.Add(Me.txtCantidadtipo)
        Me.grbPagosvarios.Controls.Add(Me.lblnfactura)
        Me.grbPagosvarios.Controls.Add(Me.txtnfactura)
        Me.grbPagosvarios.Controls.Add(Me.lblDescripciontipo)
        Me.grbPagosvarios.Controls.Add(Me.lblTipoproducto)
        Me.grbPagosvarios.Controls.Add(Me.txtTipodeproducto)
        Me.grbPagosvarios.Controls.Add(Me.txtCodigotipo)
        Me.grbPagosvarios.Controls.Add(Me.lblCodigotipo)
        Me.grbPagosvarios.Enabled = False
        Me.grbPagosvarios.Location = New System.Drawing.Point(21, 12)
        Me.grbPagosvarios.Margin = New System.Windows.Forms.Padding(1)
        Me.grbPagosvarios.Name = "grbPagosvarios"
        Me.grbPagosvarios.Padding = New System.Windows.Forms.Padding(1)
        Me.grbPagosvarios.Size = New System.Drawing.Size(785, 553)
        Me.grbPagosvarios.TabIndex = 5
        Me.grbPagosvarios.TabStop = False
        Me.grbPagosvarios.Text = "Pagos varios"
        '
        'lblCantidadtipo
        '
        Me.lblCantidadtipo.AutoSize = True
        Me.lblCantidadtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadtipo.Location = New System.Drawing.Point(20, 448)
        Me.lblCantidadtipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCantidadtipo.Name = "lblCantidadtipo"
        Me.lblCantidadtipo.Size = New System.Drawing.Size(205, 20)
        Me.lblCantidadtipo.TabIndex = 10
        Me.lblCantidadtipo.Text = "MONTO A CANCELAR:"
        '
        'txtDescripciontipo
        '
        Me.txtDescripciontipo.Location = New System.Drawing.Point(265, 278)
        Me.txtDescripciontipo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripciontipo.Multiline = True
        Me.txtDescripciontipo.Name = "txtDescripciontipo"
        Me.txtDescripciontipo.Size = New System.Drawing.Size(443, 126)
        Me.txtDescripciontipo.TabIndex = 5
        '
        'txtCantidadtipo
        '
        Me.txtCantidadtipo.Location = New System.Drawing.Point(265, 448)
        Me.txtCantidadtipo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCantidadtipo.Name = "txtCantidadtipo"
        Me.txtCantidadtipo.Size = New System.Drawing.Size(147, 22)
        Me.txtCantidadtipo.TabIndex = 9
        '
        'lblnfactura
        '
        Me.lblnfactura.AutoSize = True
        Me.lblnfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnfactura.Location = New System.Drawing.Point(20, 217)
        Me.lblnfactura.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblnfactura.Name = "lblnfactura"
        Me.lblnfactura.Size = New System.Drawing.Size(218, 20)
        Me.lblnfactura.TabIndex = 8
        Me.lblnfactura.Text = "NUMERO DE FACTURA:"
        '
        'txtnfactura
        '
        Me.txtnfactura.Location = New System.Drawing.Point(265, 215)
        Me.txtnfactura.Margin = New System.Windows.Forms.Padding(1)
        Me.txtnfactura.Name = "txtnfactura"
        Me.txtnfactura.Size = New System.Drawing.Size(147, 22)
        Me.txtnfactura.TabIndex = 7
        '
        'lblDescripciontipo
        '
        Me.lblDescripciontipo.AutoSize = True
        Me.lblDescripciontipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripciontipo.Location = New System.Drawing.Point(20, 295)
        Me.lblDescripciontipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripciontipo.Name = "lblDescripciontipo"
        Me.lblDescripciontipo.Size = New System.Drawing.Size(141, 20)
        Me.lblDescripciontipo.TabIndex = 6
        Me.lblDescripciontipo.Text = "DESCRIPCION:"
        '
        'lblTipoproducto
        '
        Me.lblTipoproducto.AutoSize = True
        Me.lblTipoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoproducto.Location = New System.Drawing.Point(20, 132)
        Me.lblTipoproducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTipoproducto.Name = "lblTipoproducto"
        Me.lblTipoproducto.Size = New System.Drawing.Size(199, 20)
        Me.lblTipoproducto.TabIndex = 4
        Me.lblTipoproducto.Text = "TIPO DE PRODUCTO:"
        '
        'txtTipodeproducto
        '
        Me.txtTipodeproducto.Location = New System.Drawing.Point(265, 132)
        Me.txtTipodeproducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTipodeproducto.Name = "txtTipodeproducto"
        Me.txtTipodeproducto.Size = New System.Drawing.Size(443, 22)
        Me.txtTipodeproducto.TabIndex = 3
        '
        'txtCodigotipo
        '
        Me.txtCodigotipo.Location = New System.Drawing.Point(265, 44)
        Me.txtCodigotipo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigotipo.Name = "txtCodigotipo"
        Me.txtCodigotipo.Size = New System.Drawing.Size(125, 22)
        Me.txtCodigotipo.TabIndex = 1
        '
        'lblCodigotipo
        '
        Me.lblCodigotipo.AutoSize = True
        Me.lblCodigotipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigotipo.Location = New System.Drawing.Point(20, 46)
        Me.lblCodigotipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigotipo.Name = "lblCodigotipo"
        Me.lblCodigotipo.Size = New System.Drawing.Size(89, 20)
        Me.lblCodigotipo.TabIndex = 0
        Me.lblCodigotipo.Text = "CODIGO:"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscartipo)
        Me.grbEdicion.Controls.Add(Me.btnEliminartipo)
        Me.grbEdicion.Controls.Add(Me.btnModificartipo)
        Me.grbEdicion.Controls.Add(Me.btnAgregartipo)
        Me.grbEdicion.Location = New System.Drawing.Point(386, 580)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 12
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscartipo
        '
        Me.btnBuscartipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscartipo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscartipo.Image = CType(resources.GetObject("btnBuscartipo.Image"), System.Drawing.Image)
        Me.btnBuscartipo.Location = New System.Drawing.Point(344, 23)
        Me.btnBuscartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscartipo.Name = "btnBuscartipo"
        Me.btnBuscartipo.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscartipo.TabIndex = 8
        Me.btnBuscartipo.UseVisualStyleBackColor = True
        '
        'btnEliminartipo
        '
        Me.btnEliminartipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminartipo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminartipo.Image = CType(resources.GetObject("btnEliminartipo.Image"), System.Drawing.Image)
        Me.btnEliminartipo.Location = New System.Drawing.Point(244, 23)
        Me.btnEliminartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminartipo.Name = "btnEliminartipo"
        Me.btnEliminartipo.Size = New System.Drawing.Size(83, 48)
        Me.btnEliminartipo.TabIndex = 7
        Me.btnEliminartipo.UseVisualStyleBackColor = True
        '
        'btnModificartipo
        '
        Me.btnModificartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificartipo.Location = New System.Drawing.Point(121, 23)
        Me.btnModificartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificartipo.Name = "btnModificartipo"
        Me.btnModificartipo.Size = New System.Drawing.Size(120, 48)
        Me.btnModificartipo.TabIndex = 6
        Me.btnModificartipo.Text = "Modificar"
        Me.btnModificartipo.UseVisualStyleBackColor = True
        '
        'btnAgregartipo
        '
        Me.btnAgregartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregartipo.Location = New System.Drawing.Point(15, 23)
        Me.btnAgregartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregartipo.Name = "btnAgregartipo"
        Me.btnAgregartipo.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregartipo.TabIndex = 5
        Me.btnAgregartipo.Text = "Nuevo"
        Me.btnAgregartipo.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrostipo)
        Me.grbNavegacion.Controls.Add(Me.btnUltimotipo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientetipo)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriortipo)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerotipo)
        Me.grbNavegacion.Location = New System.Drawing.Point(23, 580)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 11
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrostipo
        '
        Me.lblRegistrostipo.AutoSize = True
        Me.lblRegistrostipo.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrostipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrostipo.Name = "lblRegistrostipo"
        Me.lblRegistrostipo.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrostipo.TabIndex = 4
        Me.lblRegistrostipo.Text = "x de n"
        '
        'btnUltimotipo
        '
        Me.btnUltimotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimotipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimotipo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimotipo.Image = CType(resources.GetObject("btnUltimotipo.Image"), System.Drawing.Image)
        Me.btnUltimotipo.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimotipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimotipo.Name = "btnUltimotipo"
        Me.btnUltimotipo.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimotipo.TabIndex = 3
        Me.btnUltimotipo.UseVisualStyleBackColor = True
        '
        'btnSiguientetipo
        '
        Me.btnSiguientetipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguientetipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientetipo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguientetipo.Image = CType(resources.GetObject("btnSiguientetipo.Image"), System.Drawing.Image)
        Me.btnSiguientetipo.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguientetipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguientetipo.Name = "btnSiguientetipo"
        Me.btnSiguientetipo.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguientetipo.TabIndex = 2
        Me.btnSiguientetipo.UseVisualStyleBackColor = True
        '
        'btnAnteriortipo
        '
        Me.btnAnteriortipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriortipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriortipo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriortipo.Image = CType(resources.GetObject("btnAnteriortipo.Image"), System.Drawing.Image)
        Me.btnAnteriortipo.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriortipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriortipo.Name = "btnAnteriortipo"
        Me.btnAnteriortipo.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriortipo.TabIndex = 1
        Me.btnAnteriortipo.UseVisualStyleBackColor = True
        '
        'btnPrimerotipo
        '
        Me.btnPrimerotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimerotipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerotipo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimerotipo.Image = CType(resources.GetObject("btnPrimerotipo.Image"), System.Drawing.Image)
        Me.btnPrimerotipo.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimerotipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimerotipo.Name = "btnPrimerotipo"
        Me.btnPrimerotipo.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimerotipo.TabIndex = 0
        Me.btnPrimerotipo.UseVisualStyleBackColor = True
        '
        'frmPagosVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(839, 674)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbPagosvarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPagosVarios"
        Me.Text = "Pagos varios"
        Me.grbPagosvarios.ResumeLayout(False)
        Me.grbPagosvarios.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbPagosvarios As GroupBox
    Friend WithEvents lblCantidadtipo As Label
    Friend WithEvents txtDescripciontipo As TextBox
    Friend WithEvents txtCantidadtipo As TextBox
    Friend WithEvents lblnfactura As Label
    Friend WithEvents txtnfactura As TextBox
    Friend WithEvents lblDescripciontipo As Label
    Friend WithEvents lblTipoproducto As Label
    Friend WithEvents txtTipodeproducto As TextBox
    Friend WithEvents txtCodigotipo As TextBox
    Friend WithEvents lblCodigotipo As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscartipo As Button
    Friend WithEvents btnEliminartipo As Button
    Friend WithEvents btnModificartipo As Button
    Friend WithEvents btnAgregartipo As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrostipo As Label
    Friend WithEvents btnUltimotipo As Button
    Friend WithEvents btnSiguientetipo As Button
    Friend WithEvents btnAnteriortipo As Button
    Friend WithEvents btnPrimerotipo As Button
End Class
