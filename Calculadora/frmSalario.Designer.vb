<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalario
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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.lblDescuentos = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCategoria = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnEliminarDescuento = New System.Windows.Forms.Button()
        Me.btnModificarDescuento = New System.Windows.Forms.Button()
        Me.btnAgregarDescuento = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblUsuario)
        Me.grbDatos.Controls.Add(Me.txtUsuario)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(13, 12)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(784, 117)
        Me.grbDatos.TabIndex = 9
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Usuario"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(20, 53)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(97, 20)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "USUARIO:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(211, 49)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(443, 22)
        Me.txtUsuario.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescuentos)
        Me.GroupBox1.Controls.Add(Me.lblDescuentos)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(13, 132)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Size = New System.Drawing.Size(784, 117)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Descuentos"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Location = New System.Drawing.Point(211, 49)
        Me.txtDescuentos.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(443, 22)
        Me.txtDescuentos.TabIndex = 5
        '
        'lblDescuentos
        '
        Me.lblDescuentos.AutoSize = True
        Me.lblDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentos.Location = New System.Drawing.Point(20, 53)
        Me.lblDescuentos.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescuentos.Name = "lblDescuentos"
        Me.lblDescuentos.Size = New System.Drawing.Size(141, 20)
        Me.lblDescuentos.TabIndex = 4
        Me.lblDescuentos.Text = "DESCUENTOS:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(13, 274)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 12
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCategoria
        '
        Me.lblRegistrosCategoria.AutoSize = True
        Me.lblRegistrosCategoria.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosCategoria.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosCategoria.Name = "lblRegistrosCategoria"
        Me.lblRegistrosCategoria.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosCategoria.TabIndex = 4
        Me.lblRegistrosCategoria.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(56, 23)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(55, 48)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnEliminarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnModificarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnAgregarDescuento)
        Me.grbEdicion.Location = New System.Drawing.Point(377, 274)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 13
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnEliminarDescuento
        '
        Me.btnEliminarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDescuento.Location = New System.Drawing.Point(291, 25)
        Me.btnEliminarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarDescuento.Name = "btnEliminarDescuento"
        Me.btnEliminarDescuento.Size = New System.Drawing.Size(107, 48)
        Me.btnEliminarDescuento.TabIndex = 7
        Me.btnEliminarDescuento.Text = "Eliminar"
        Me.btnEliminarDescuento.UseVisualStyleBackColor = True
        '
        'btnModificarDescuento
        '
        Me.btnModificarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDescuento.Location = New System.Drawing.Point(131, 23)
        Me.btnModificarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarDescuento.Name = "btnModificarDescuento"
        Me.btnModificarDescuento.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarDescuento.TabIndex = 6
        Me.btnModificarDescuento.Text = "Modificar"
        Me.btnModificarDescuento.UseVisualStyleBackColor = True
        '
        'btnAgregarDescuento
        '
        Me.btnAgregarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDescuento.Location = New System.Drawing.Point(17, 23)
        Me.btnAgregarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarDescuento.Name = "btnAgregarDescuento"
        Me.btnAgregarDescuento.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarDescuento.TabIndex = 5
        Me.btnAgregarDescuento.Text = "Nuevo"
        Me.btnAgregarDescuento.UseVisualStyleBackColor = True
        '
        'frmSalario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(815, 377)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grbDatos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSalario"
        Me.Text = "Salario"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescuentos As TextBox
    Friend WithEvents lblDescuentos As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCategoria As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnEliminarDescuento As Button
    Friend WithEvents btnModificarDescuento As Button
    Friend WithEvents btnAgregarDescuento As Button
End Class
