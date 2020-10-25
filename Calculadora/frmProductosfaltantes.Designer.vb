<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosfaltantes
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
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarfaltante = New System.Windows.Forms.Button()
        Me.btnEliminarfaltante = New System.Windows.Forms.Button()
        Me.btnModificarfaltante = New System.Windows.Forms.Button()
        Me.btnAgregarfaltante = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosProducto = New System.Windows.Forms.Label()
        Me.btnUltimofaltante = New System.Windows.Forms.Button()
        Me.btnSiguientefaltante = New System.Windows.Forms.Button()
        Me.btnAnteriorfaltante = New System.Windows.Forms.Button()
        Me.btnPrimerofaltante = New System.Windows.Forms.Button()
        Me.grbfaltantes = New System.Windows.Forms.GroupBox()
        Me.lblCantidadfaltante = New System.Windows.Forms.Label()
        Me.txtCantidadfaltante = New System.Windows.Forms.TextBox()
        Me.cboCategoriafaltante = New System.Windows.Forms.ComboBox()
        Me.lblCategoriafaltante = New System.Windows.Forms.Label()
        Me.lblMedidasfaltantes = New System.Windows.Forms.Label()
        Me.txtMedidasfaltante = New System.Windows.Forms.TextBox()
        Me.lblMarcafaltante = New System.Windows.Forms.Label()
        Me.txtMarcafaltante = New System.Windows.Forms.TextBox()
        Me.lblDescripcionfaltante = New System.Windows.Forms.Label()
        Me.txtDescripcionfaltante = New System.Windows.Forms.TextBox()
        Me.txtCodigofaltante = New System.Windows.Forms.TextBox()
        Me.lblCodigofaltante = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbfaltantes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarfaltante)
        Me.grbEdicion.Controls.Add(Me.btnEliminarfaltante)
        Me.grbEdicion.Controls.Add(Me.btnModificarfaltante)
        Me.grbEdicion.Controls.Add(Me.btnAgregarfaltante)
        Me.grbEdicion.Location = New System.Drawing.Point(280, 429)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 20
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarfaltante
        '
        Me.btnBuscarfaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarfaltante.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarfaltante.Name = "btnBuscarfaltante"
        Me.btnBuscarfaltante.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarfaltante.TabIndex = 8
        Me.btnBuscarfaltante.Text = "Buscar"
        Me.btnBuscarfaltante.UseVisualStyleBackColor = True
        '
        'btnEliminarfaltante
        '
        Me.btnEliminarfaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarfaltante.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarfaltante.Name = "btnEliminarfaltante"
        Me.btnEliminarfaltante.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarfaltante.TabIndex = 7
        Me.btnEliminarfaltante.Text = "Eliminar"
        Me.btnEliminarfaltante.UseVisualStyleBackColor = True
        '
        'btnModificarfaltante
        '
        Me.btnModificarfaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarfaltante.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarfaltante.Name = "btnModificarfaltante"
        Me.btnModificarfaltante.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarfaltante.TabIndex = 6
        Me.btnModificarfaltante.Text = "Modificar"
        Me.btnModificarfaltante.UseVisualStyleBackColor = True
        '
        'btnAgregarfaltante
        '
        Me.btnAgregarfaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarfaltante.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarfaltante.Name = "btnAgregarfaltante"
        Me.btnAgregarfaltante.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarfaltante.TabIndex = 5
        Me.btnAgregarfaltante.Text = "Nuevo"
        Me.btnAgregarfaltante.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosProducto)
        Me.grbNavegacion.Controls.Add(Me.btnUltimofaltante)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientefaltante)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorfaltante)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerofaltante)
        Me.grbNavegacion.Location = New System.Drawing.Point(8, 429)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 19
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosProducto
        '
        Me.lblRegistrosProducto.AutoSize = True
        Me.lblRegistrosProducto.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosProducto.Name = "lblRegistrosProducto"
        Me.lblRegistrosProducto.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosProducto.TabIndex = 4
        Me.lblRegistrosProducto.Text = "x de n"
        '
        'btnUltimofaltante
        '
        Me.btnUltimofaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimofaltante.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimofaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimofaltante.Name = "btnUltimofaltante"
        Me.btnUltimofaltante.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimofaltante.TabIndex = 3
        Me.btnUltimofaltante.Text = ">|"
        Me.btnUltimofaltante.UseVisualStyleBackColor = True
        '
        'btnSiguientefaltante
        '
        Me.btnSiguientefaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientefaltante.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguientefaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguientefaltante.Name = "btnSiguientefaltante"
        Me.btnSiguientefaltante.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguientefaltante.TabIndex = 2
        Me.btnSiguientefaltante.Text = ">"
        Me.btnSiguientefaltante.UseVisualStyleBackColor = True
        '
        'btnAnteriorfaltante
        '
        Me.btnAnteriorfaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorfaltante.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorfaltante.Name = "btnAnteriorfaltante"
        Me.btnAnteriorfaltante.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorfaltante.TabIndex = 1
        Me.btnAnteriorfaltante.Text = "<"
        Me.btnAnteriorfaltante.UseVisualStyleBackColor = True
        '
        'btnPrimerofaltante
        '
        Me.btnPrimerofaltante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerofaltante.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimerofaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimerofaltante.Name = "btnPrimerofaltante"
        Me.btnPrimerofaltante.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimerofaltante.TabIndex = 0
        Me.btnPrimerofaltante.Text = "|<"
        Me.btnPrimerofaltante.UseVisualStyleBackColor = True
        '
        'grbfaltantes
        '
        Me.grbfaltantes.Controls.Add(Me.lblCantidadfaltante)
        Me.grbfaltantes.Controls.Add(Me.txtCantidadfaltante)
        Me.grbfaltantes.Controls.Add(Me.cboCategoriafaltante)
        Me.grbfaltantes.Controls.Add(Me.lblCategoriafaltante)
        Me.grbfaltantes.Controls.Add(Me.lblMedidasfaltantes)
        Me.grbfaltantes.Controls.Add(Me.txtMedidasfaltante)
        Me.grbfaltantes.Controls.Add(Me.lblMarcafaltante)
        Me.grbfaltantes.Controls.Add(Me.txtMarcafaltante)
        Me.grbfaltantes.Controls.Add(Me.lblDescripcionfaltante)
        Me.grbfaltantes.Controls.Add(Me.txtDescripcionfaltante)
        Me.grbfaltantes.Controls.Add(Me.txtCodigofaltante)
        Me.grbfaltantes.Controls.Add(Me.lblCodigofaltante)
        Me.grbfaltantes.Enabled = False
        Me.grbfaltantes.Location = New System.Drawing.Point(8, 4)
        Me.grbfaltantes.Margin = New System.Windows.Forms.Padding(1)
        Me.grbfaltantes.Name = "grbfaltantes"
        Me.grbfaltantes.Padding = New System.Windows.Forms.Padding(1)
        Me.grbfaltantes.Size = New System.Drawing.Size(587, 423)
        Me.grbfaltantes.TabIndex = 18
        Me.grbfaltantes.TabStop = False
        Me.grbfaltantes.Text = "Datos de Productos"
        '
        'lblCantidadfaltante
        '
        Me.lblCantidadfaltante.AutoSize = True
        Me.lblCantidadfaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadfaltante.Location = New System.Drawing.Point(19, 364)
        Me.lblCantidadfaltante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCantidadfaltante.Name = "lblCantidadfaltante"
        Me.lblCantidadfaltante.Size = New System.Drawing.Size(174, 17)
        Me.lblCantidadfaltante.TabIndex = 12
        Me.lblCantidadfaltante.Text = "CANTIDAD FALATNTE:"
        '
        'txtCantidadfaltante
        '
        Me.txtCantidadfaltante.Location = New System.Drawing.Point(195, 364)
        Me.txtCantidadfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCantidadfaltante.Name = "txtCantidadfaltante"
        Me.txtCantidadfaltante.Size = New System.Drawing.Size(191, 20)
        Me.txtCantidadfaltante.TabIndex = 11
        '
        'cboCategoriafaltante
        '
        Me.cboCategoriafaltante.FormattingEnabled = True
        Me.cboCategoriafaltante.Location = New System.Drawing.Point(195, 51)
        Me.cboCategoriafaltante.Name = "cboCategoriafaltante"
        Me.cboCategoriafaltante.Size = New System.Drawing.Size(191, 21)
        Me.cboCategoriafaltante.TabIndex = 10
        '
        'lblCategoriafaltante
        '
        Me.lblCategoriafaltante.AutoSize = True
        Me.lblCategoriafaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriafaltante.Location = New System.Drawing.Point(23, 55)
        Me.lblCategoriafaltante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCategoriafaltante.Name = "lblCategoriafaltante"
        Me.lblCategoriafaltante.Size = New System.Drawing.Size(102, 17)
        Me.lblCategoriafaltante.TabIndex = 9
        Me.lblCategoriafaltante.Text = "CATEGORIA:"
        '
        'lblMedidasfaltantes
        '
        Me.lblMedidasfaltantes.AutoSize = True
        Me.lblMedidasfaltantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidasfaltantes.Location = New System.Drawing.Point(23, 301)
        Me.lblMedidasfaltantes.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMedidasfaltantes.Name = "lblMedidasfaltantes"
        Me.lblMedidasfaltantes.Size = New System.Drawing.Size(81, 17)
        Me.lblMedidasfaltantes.TabIndex = 8
        Me.lblMedidasfaltantes.Text = "MEDIDAS:"
        '
        'txtMedidasfaltante
        '
        Me.txtMedidasfaltante.Location = New System.Drawing.Point(195, 301)
        Me.txtMedidasfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMedidasfaltante.Name = "txtMedidasfaltante"
        Me.txtMedidasfaltante.Size = New System.Drawing.Size(191, 20)
        Me.txtMedidasfaltante.TabIndex = 7
        '
        'lblMarcafaltante
        '
        Me.lblMarcafaltante.AutoSize = True
        Me.lblMarcafaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcafaltante.Location = New System.Drawing.Point(23, 243)
        Me.lblMarcafaltante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMarcafaltante.Name = "lblMarcafaltante"
        Me.lblMarcafaltante.Size = New System.Drawing.Size(66, 17)
        Me.lblMarcafaltante.TabIndex = 6
        Me.lblMarcafaltante.Text = "MARCA:"
        '
        'txtMarcafaltante
        '
        Me.txtMarcafaltante.Location = New System.Drawing.Point(195, 240)
        Me.txtMarcafaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMarcafaltante.Name = "txtMarcafaltante"
        Me.txtMarcafaltante.Size = New System.Drawing.Size(191, 20)
        Me.txtMarcafaltante.TabIndex = 5
        '
        'lblDescripcionfaltante
        '
        Me.lblDescripcionfaltante.AutoSize = True
        Me.lblDescripcionfaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionfaltante.Location = New System.Drawing.Point(23, 180)
        Me.lblDescripcionfaltante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripcionfaltante.Name = "lblDescripcionfaltante"
        Me.lblDescripcionfaltante.Size = New System.Drawing.Size(116, 17)
        Me.lblDescripcionfaltante.TabIndex = 4
        Me.lblDescripcionfaltante.Text = "DESCRIPCION:"
        '
        'txtDescripcionfaltante
        '
        Me.txtDescripcionfaltante.Location = New System.Drawing.Point(195, 180)
        Me.txtDescripcionfaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripcionfaltante.Name = "txtDescripcionfaltante"
        Me.txtDescripcionfaltante.Size = New System.Drawing.Size(333, 20)
        Me.txtDescripcionfaltante.TabIndex = 3
        '
        'txtCodigofaltante
        '
        Me.txtCodigofaltante.Location = New System.Drawing.Point(195, 118)
        Me.txtCodigofaltante.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCodigofaltante.Name = "txtCodigofaltante"
        Me.txtCodigofaltante.Size = New System.Drawing.Size(95, 20)
        Me.txtCodigofaltante.TabIndex = 1
        '
        'lblCodigofaltante
        '
        Me.lblCodigofaltante.AutoSize = True
        Me.lblCodigofaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigofaltante.Location = New System.Drawing.Point(23, 121)
        Me.lblCodigofaltante.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigofaltante.Name = "lblCodigofaltante"
        Me.lblCodigofaltante.Size = New System.Drawing.Size(74, 17)
        Me.lblCodigofaltante.TabIndex = 0
        Me.lblCodigofaltante.Text = "CODIGO:"
        '
        'frmProductosfaltantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 511)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbfaltantes)
        Me.Name = "frmProductosfaltantes"
        Me.Text = "frmProductosfaltantes"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbfaltantes.ResumeLayout(False)
        Me.grbfaltantes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarfaltante As Button
    Friend WithEvents btnEliminarfaltante As Button
    Friend WithEvents btnModificarfaltante As Button
    Friend WithEvents btnAgregarfaltante As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosProducto As Label
    Friend WithEvents btnUltimofaltante As Button
    Friend WithEvents btnSiguientefaltante As Button
    Friend WithEvents btnAnteriorfaltante As Button
    Friend WithEvents btnPrimerofaltante As Button
    Friend WithEvents grbfaltantes As GroupBox
    Friend WithEvents lblCantidadfaltante As Label
    Friend WithEvents txtCantidadfaltante As TextBox
    Friend WithEvents cboCategoriafaltante As ComboBox
    Friend WithEvents lblCategoriafaltante As Label
    Friend WithEvents lblMedidasfaltantes As Label
    Friend WithEvents txtMedidasfaltante As TextBox
    Friend WithEvents lblMarcafaltante As Label
    Friend WithEvents txtMarcafaltante As TextBox
    Friend WithEvents lblDescripcionfaltante As Label
    Friend WithEvents txtDescripcionfaltante As TextBox
    Friend WithEvents txtCodigofaltante As TextBox
    Friend WithEvents lblCodigofaltante As Label
End Class
