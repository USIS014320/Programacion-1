<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargos
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
        Me.lblDescripcionCargos = New System.Windows.Forms.Label()
        Me.txtDescripcionCargo = New System.Windows.Forms.TextBox()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCargo = New System.Windows.Forms.Button()
        Me.btnEliminarCargo = New System.Windows.Forms.Button()
        Me.btnModificarCargo = New System.Windows.Forms.Button()
        Me.btnAgregarCargo = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCargo = New System.Windows.Forms.Label()
        Me.btnUltimoCargo = New System.Windows.Forms.Button()
        Me.btnSiguienteCargo = New System.Windows.Forms.Button()
        Me.btnAnteriorCargo = New System.Windows.Forms.Button()
        Me.btnPrimeroCargo = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblDescripcionCargos)
        Me.grbDatos.Controls.Add(Me.txtDescripcionCargo)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(10, 18)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(780, 117)
        Me.grbDatos.TabIndex = 9
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Cargos"
        '
        'lblDescripcionCargos
        '
        Me.lblDescripcionCargos.AutoSize = True
        Me.lblDescripcionCargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCargos.Location = New System.Drawing.Point(20, 53)
        Me.lblDescripcionCargos.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripcionCargos.Name = "lblDescripcionCargos"
        Me.lblDescripcionCargos.Size = New System.Drawing.Size(93, 20)
        Me.lblDescripcionCargos.TabIndex = 4
        Me.lblDescripcionCargos.Text = "CARGOS:"
        '
        'txtDescripcionCargo
        '
        Me.txtDescripcionCargo.Location = New System.Drawing.Point(177, 52)
        Me.txtDescripcionCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripcionCargo.Name = "txtDescripcionCargo"
        Me.txtDescripcionCargo.Size = New System.Drawing.Size(443, 22)
        Me.txtDescripcionCargo.TabIndex = 3
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarCargo)
        Me.grbEdicion.Controls.Add(Me.btnEliminarCargo)
        Me.grbEdicion.Controls.Add(Me.btnModificarCargo)
        Me.grbEdicion.Controls.Add(Me.btnAgregarCargo)
        Me.grbEdicion.Location = New System.Drawing.Point(370, 163)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 27
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarCargo
        '
        Me.btnBuscarCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCargo.Location = New System.Drawing.Point(316, 23)
        Me.btnBuscarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarCargo.Name = "btnBuscarCargo"
        Me.btnBuscarCargo.Size = New System.Drawing.Size(100, 48)
        Me.btnBuscarCargo.TabIndex = 8
        Me.btnBuscarCargo.Text = "Buscar"
        Me.btnBuscarCargo.UseVisualStyleBackColor = True
        '
        'btnEliminarCargo
        '
        Me.btnEliminarCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCargo.Location = New System.Drawing.Point(211, 23)
        Me.btnEliminarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarCargo.Name = "btnEliminarCargo"
        Me.btnEliminarCargo.Size = New System.Drawing.Size(107, 48)
        Me.btnEliminarCargo.TabIndex = 7
        Me.btnEliminarCargo.Text = "Eliminar"
        Me.btnEliminarCargo.UseVisualStyleBackColor = True
        '
        'btnModificarCargo
        '
        Me.btnModificarCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCargo.Location = New System.Drawing.Point(92, 23)
        Me.btnModificarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarCargo.Name = "btnModificarCargo"
        Me.btnModificarCargo.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarCargo.TabIndex = 6
        Me.btnModificarCargo.Text = "Modificar"
        Me.btnModificarCargo.UseVisualStyleBackColor = True
        '
        'btnAgregarCargo
        '
        Me.btnAgregarCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCargo.Location = New System.Drawing.Point(3, 23)
        Me.btnAgregarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarCargo.Name = "btnAgregarCargo"
        Me.btnAgregarCargo.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarCargo.TabIndex = 5
        Me.btnAgregarCargo.Text = "Nuevo"
        Me.btnAgregarCargo.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCargo)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCargo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCargo)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCargo)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCargo)
        Me.grbNavegacion.Location = New System.Drawing.Point(7, 163)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 26
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCargo
        '
        Me.lblRegistrosCargo.AutoSize = True
        Me.lblRegistrosCargo.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosCargo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosCargo.Name = "lblRegistrosCargo"
        Me.lblRegistrosCargo.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosCargo.TabIndex = 4
        Me.lblRegistrosCargo.Text = "x de n"
        '
        'btnUltimoCargo
        '
        Me.btnUltimoCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCargo.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoCargo.Name = "btnUltimoCargo"
        Me.btnUltimoCargo.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoCargo.TabIndex = 3
        Me.btnUltimoCargo.Text = ">|"
        Me.btnUltimoCargo.UseVisualStyleBackColor = True
        '
        'btnSiguienteCargo
        '
        Me.btnSiguienteCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCargo.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteCargo.Name = "btnSiguienteCargo"
        Me.btnSiguienteCargo.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteCargo.TabIndex = 2
        Me.btnSiguienteCargo.Text = ">"
        Me.btnSiguienteCargo.UseVisualStyleBackColor = True
        '
        'btnAnteriorCargo
        '
        Me.btnAnteriorCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCargo.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorCargo.Name = "btnAnteriorCargo"
        Me.btnAnteriorCargo.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorCargo.TabIndex = 1
        Me.btnAnteriorCargo.Text = "<"
        Me.btnAnteriorCargo.UseVisualStyleBackColor = True
        '
        'btnPrimeroCargo
        '
        Me.btnPrimeroCargo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCargo.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroCargo.Name = "btnPrimeroCargo"
        Me.btnPrimeroCargo.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroCargo.TabIndex = 0
        Me.btnPrimeroCargo.Text = "|<"
        Me.btnPrimeroCargo.UseVisualStyleBackColor = True
        '
        'frmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(800, 253)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmCargos"
        Me.Text = "Resgistro de Cargos"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblDescripcionCargos As Label
    Friend WithEvents txtDescripcionCargo As TextBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarCargo As Button
    Friend WithEvents btnEliminarCargo As Button
    Friend WithEvents btnModificarCargo As Button
    Friend WithEvents btnAgregarCargo As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCargo As Label
    Friend WithEvents btnUltimoCargo As Button
    Friend WithEvents btnSiguienteCargo As Button
    Friend WithEvents btnAnteriorCargo As Button
    Friend WithEvents btnPrimeroCargo As Button
End Class
