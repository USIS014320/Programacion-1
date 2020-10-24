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
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscartipo = New System.Windows.Forms.Button()
        Me.btnEliminartipo = New System.Windows.Forms.Button()
        Me.btnModificartipo = New System.Windows.Forms.Button()
        Me.btnAgregartipo = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosEmpleado = New System.Windows.Forms.Label()
        Me.btnUltimotipo = New System.Windows.Forms.Button()
        Me.btnSiguientetipo = New System.Windows.Forms.Button()
        Me.btnAnteriortipo = New System.Windows.Forms.Button()
        Me.btnPrimerotipo = New System.Windows.Forms.Button()
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
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbPagosvarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscartipo)
        Me.grbEdicion.Controls.Add(Me.btnEliminartipo)
        Me.grbEdicion.Controls.Add(Me.btnModificartipo)
        Me.grbEdicion.Controls.Add(Me.btnAgregartipo)
        Me.grbEdicion.Location = New System.Drawing.Point(293, 470)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 7
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscartipo
        '
        Me.btnBuscartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscartipo.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscartipo.Name = "btnBuscartipo"
        Me.btnBuscartipo.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscartipo.TabIndex = 8
        Me.btnBuscartipo.Text = "Buscar"
        Me.btnBuscartipo.UseVisualStyleBackColor = True
        '
        'btnEliminartipo
        '
        Me.btnEliminartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminartipo.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminartipo.Name = "btnEliminartipo"
        Me.btnEliminartipo.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminartipo.TabIndex = 7
        Me.btnEliminartipo.Text = "Eliminar"
        Me.btnEliminartipo.UseVisualStyleBackColor = True
        '
        'btnModificartipo
        '
        Me.btnModificartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificartipo.Location = New System.Drawing.Point(69, 19)
        Me.btnModificartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificartipo.Name = "btnModificartipo"
        Me.btnModificartipo.Size = New System.Drawing.Size(90, 39)
        Me.btnModificartipo.TabIndex = 6
        Me.btnModificartipo.Text = "Modificar"
        Me.btnModificartipo.UseVisualStyleBackColor = True
        '
        'btnAgregartipo
        '
        Me.btnAgregartipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregartipo.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregartipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregartipo.Name = "btnAgregartipo"
        Me.btnAgregartipo.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregartipo.TabIndex = 5
        Me.btnAgregartipo.Text = "Nuevo"
        Me.btnAgregartipo.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnUltimotipo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientetipo)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriortipo)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerotipo)
        Me.grbNavegacion.Location = New System.Drawing.Point(21, 470)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 6
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosEmpleado
        '
        Me.lblRegistrosEmpleado.AutoSize = True
        Me.lblRegistrosEmpleado.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosEmpleado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosEmpleado.Name = "lblRegistrosEmpleado"
        Me.lblRegistrosEmpleado.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosEmpleado.TabIndex = 4
        Me.lblRegistrosEmpleado.Text = "x de n"
        '
        'btnUltimotipo
        '
        Me.btnUltimotipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimotipo.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimotipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimotipo.Name = "btnUltimotipo"
        Me.btnUltimotipo.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimotipo.TabIndex = 3
        Me.btnUltimotipo.Text = ">|"
        Me.btnUltimotipo.UseVisualStyleBackColor = True
        '
        'btnSiguientetipo
        '
        Me.btnSiguientetipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientetipo.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguientetipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguientetipo.Name = "btnSiguientetipo"
        Me.btnSiguientetipo.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguientetipo.TabIndex = 2
        Me.btnSiguientetipo.Text = ">"
        Me.btnSiguientetipo.UseVisualStyleBackColor = True
        '
        'btnAnteriortipo
        '
        Me.btnAnteriortipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriortipo.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriortipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriortipo.Name = "btnAnteriortipo"
        Me.btnAnteriortipo.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriortipo.TabIndex = 1
        Me.btnAnteriortipo.Text = "<"
        Me.btnAnteriortipo.UseVisualStyleBackColor = True
        '
        'btnPrimerotipo
        '
        Me.btnPrimerotipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerotipo.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimerotipo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimerotipo.Name = "btnPrimerotipo"
        Me.btnPrimerotipo.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimerotipo.TabIndex = 0
        Me.btnPrimerotipo.Text = "|<"
        Me.btnPrimerotipo.UseVisualStyleBackColor = True
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
        Me.grbPagosvarios.Location = New System.Drawing.Point(16, 10)
        Me.grbPagosvarios.Margin = New System.Windows.Forms.Padding(1)
        Me.grbPagosvarios.Name = "grbPagosvarios"
        Me.grbPagosvarios.Padding = New System.Windows.Forms.Padding(1)
        Me.grbPagosvarios.Size = New System.Drawing.Size(589, 449)
        Me.grbPagosvarios.TabIndex = 5
        Me.grbPagosvarios.TabStop = False
        Me.grbPagosvarios.Text = "Pagos varios"
        '
        'lblCantidadtipo
        '
        Me.lblCantidadtipo.AutoSize = True
        Me.lblCantidadtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadtipo.Location = New System.Drawing.Point(15, 364)
        Me.lblCantidadtipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCantidadtipo.Name = "lblCantidadtipo"
        Me.lblCantidadtipo.Size = New System.Drawing.Size(171, 17)
        Me.lblCantidadtipo.TabIndex = 10
        Me.lblCantidadtipo.Text = "MONTO A CANCELAR:"
        '
        'txtDescripciontipo
        '
        Me.txtDescripciontipo.Location = New System.Drawing.Point(199, 226)
        Me.txtDescripciontipo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripciontipo.Multiline = True
        Me.txtDescripciontipo.Name = "txtDescripciontipo"
        Me.txtDescripciontipo.Size = New System.Drawing.Size(333, 103)
        Me.txtDescripciontipo.TabIndex = 5
        '
        'txtCantidadtipo
        '
        Me.txtCantidadtipo.Location = New System.Drawing.Point(199, 364)
        Me.txtCantidadtipo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCantidadtipo.Name = "txtCantidadtipo"
        Me.txtCantidadtipo.Size = New System.Drawing.Size(111, 20)
        Me.txtCantidadtipo.TabIndex = 9
        '
        'lblnfactura
        '
        Me.lblnfactura.AutoSize = True
        Me.lblnfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnfactura.Location = New System.Drawing.Point(15, 176)
        Me.lblnfactura.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblnfactura.Name = "lblnfactura"
        Me.lblnfactura.Size = New System.Drawing.Size(182, 17)
        Me.lblnfactura.TabIndex = 8
        Me.lblnfactura.Text = "NUMERO DE FACTURA:"
        '
        'txtnfactura
        '
        Me.txtnfactura.Location = New System.Drawing.Point(199, 175)
        Me.txtnfactura.Margin = New System.Windows.Forms.Padding(1)
        Me.txtnfactura.Name = "txtnfactura"
        Me.txtnfactura.Size = New System.Drawing.Size(111, 20)
        Me.txtnfactura.TabIndex = 7
        '
        'lblDescripciontipo
        '
        Me.lblDescripciontipo.AutoSize = True
        Me.lblDescripciontipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripciontipo.Location = New System.Drawing.Point(15, 240)
        Me.lblDescripciontipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripciontipo.Name = "lblDescripciontipo"
        Me.lblDescripciontipo.Size = New System.Drawing.Size(116, 17)
        Me.lblDescripciontipo.TabIndex = 6
        Me.lblDescripciontipo.Text = "DESCRIPCION:"
        '
        'lblTipoproducto
        '
        Me.lblTipoproducto.AutoSize = True
        Me.lblTipoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoproducto.Location = New System.Drawing.Point(15, 107)
        Me.lblTipoproducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTipoproducto.Name = "lblTipoproducto"
        Me.lblTipoproducto.Size = New System.Drawing.Size(167, 17)
        Me.lblTipoproducto.TabIndex = 4
        Me.lblTipoproducto.Text = "TIPO DE PRODUCTO:"
        '
        'txtTipodeproducto
        '
        Me.txtTipodeproducto.Location = New System.Drawing.Point(199, 107)
        Me.txtTipodeproducto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTipodeproducto.Name = "txtTipodeproducto"
        Me.txtTipodeproducto.Size = New System.Drawing.Size(333, 20)
        Me.txtTipodeproducto.TabIndex = 3
        '
        'txtCodigotipo
        '
        Me.txtCodigotipo.Location = New System.Drawing.Point(199, 36)
        Me.txtCodigotipo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigotipo.Name = "txtCodigotipo"
        Me.txtCodigotipo.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigotipo.TabIndex = 1
        '
        'lblCodigotipo
        '
        Me.lblCodigotipo.AutoSize = True
        Me.lblCodigotipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigotipo.Location = New System.Drawing.Point(15, 37)
        Me.lblCodigotipo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigotipo.Name = "lblCodigotipo"
        Me.lblCodigotipo.Size = New System.Drawing.Size(74, 17)
        Me.lblCodigotipo.TabIndex = 0
        Me.lblCodigotipo.Text = "CODIGO:"
        '
        'frmPagosVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(629, 548)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbPagosvarios)
        Me.Name = "frmPagosVarios"
        Me.Text = "Pagos varios"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbPagosvarios.ResumeLayout(False)
        Me.grbPagosvarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscartipo As Button
    Friend WithEvents btnEliminartipo As Button
    Friend WithEvents btnModificartipo As Button
    Friend WithEvents btnAgregartipo As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosEmpleado As Label
    Friend WithEvents btnUltimotipo As Button
    Friend WithEvents btnSiguientetipo As Button
    Friend WithEvents btnAnteriortipo As Button
    Friend WithEvents btnPrimerotipo As Button
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
End Class
