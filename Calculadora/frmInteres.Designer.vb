<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInteres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInteres))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarInteres = New System.Windows.Forms.Button()
        Me.btnEliminarInteres = New System.Windows.Forms.Button()
        Me.btnModificarInteres = New System.Windows.Forms.Button()
        Me.btnAgregarInteres = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosInteres = New System.Windows.Forms.Label()
        Me.btnUltimoInteres = New System.Windows.Forms.Button()
        Me.btnSiguienteInteres = New System.Windows.Forms.Button()
        Me.btnAnteriorInteres = New System.Windows.Forms.Button()
        Me.btnPrimeroInteres = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblInteres)
        Me.grbDatos.Controls.Add(Me.txtInteres)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(27, 22)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(780, 117)
        Me.grbDatos.TabIndex = 28
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Cargos"
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteres.Location = New System.Drawing.Point(20, 53)
        Me.lblInteres.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(93, 20)
        Me.lblInteres.TabIndex = 4
        Me.lblInteres.Text = "INTERES:"
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(177, 52)
        Me.txtInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(443, 22)
        Me.txtInteres.TabIndex = 3
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarInteres)
        Me.grbEdicion.Controls.Add(Me.btnEliminarInteres)
        Me.grbEdicion.Controls.Add(Me.btnModificarInteres)
        Me.grbEdicion.Controls.Add(Me.btnAgregarInteres)
        Me.grbEdicion.Location = New System.Drawing.Point(387, 178)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 6
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarInteres
        '
        Me.btnBuscarInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarInteres.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarInteres.Image = CType(resources.GetObject("btnBuscarInteres.Image"), System.Drawing.Image)
        Me.btnBuscarInteres.Location = New System.Drawing.Point(344, 23)
        Me.btnBuscarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarInteres.Name = "btnBuscarInteres"
        Me.btnBuscarInteres.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscarInteres.TabIndex = 8
        Me.btnBuscarInteres.UseVisualStyleBackColor = True
        '
        'btnEliminarInteres
        '
        Me.btnEliminarInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarInteres.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarInteres.Image = CType(resources.GetObject("btnEliminarInteres.Image"), System.Drawing.Image)
        Me.btnEliminarInteres.Location = New System.Drawing.Point(244, 23)
        Me.btnEliminarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarInteres.Name = "btnEliminarInteres"
        Me.btnEliminarInteres.Size = New System.Drawing.Size(83, 48)
        Me.btnEliminarInteres.TabIndex = 7
        Me.btnEliminarInteres.UseVisualStyleBackColor = True
        '
        'btnModificarInteres
        '
        Me.btnModificarInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarInteres.Location = New System.Drawing.Point(121, 23)
        Me.btnModificarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarInteres.Name = "btnModificarInteres"
        Me.btnModificarInteres.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarInteres.TabIndex = 6
        Me.btnModificarInteres.Text = "Modificar"
        Me.btnModificarInteres.UseVisualStyleBackColor = True
        '
        'btnAgregarInteres
        '
        Me.btnAgregarInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarInteres.Location = New System.Drawing.Point(15, 23)
        Me.btnAgregarInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarInteres.Name = "btnAgregarInteres"
        Me.btnAgregarInteres.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarInteres.TabIndex = 5
        Me.btnAgregarInteres.Text = "Nuevo"
        Me.btnAgregarInteres.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosInteres)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoInteres)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteInteres)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorInteres)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroInteres)
        Me.grbNavegacion.Location = New System.Drawing.Point(24, 178)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 5
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosInteres
        '
        Me.lblRegistrosInteres.AutoSize = True
        Me.lblRegistrosInteres.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosInteres.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosInteres.Name = "lblRegistrosInteres"
        Me.lblRegistrosInteres.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosInteres.TabIndex = 4
        Me.lblRegistrosInteres.Text = "x de n"
        '
        'btnUltimoInteres
        '
        Me.btnUltimoInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimoInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoInteres.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimoInteres.Image = CType(resources.GetObject("btnUltimoInteres.Image"), System.Drawing.Image)
        Me.btnUltimoInteres.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimoInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoInteres.Name = "btnUltimoInteres"
        Me.btnUltimoInteres.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoInteres.TabIndex = 3
        Me.btnUltimoInteres.UseVisualStyleBackColor = True
        '
        'btnSiguienteInteres
        '
        Me.btnSiguienteInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteInteres.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguienteInteres.Image = CType(resources.GetObject("btnSiguienteInteres.Image"), System.Drawing.Image)
        Me.btnSiguienteInteres.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguienteInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteInteres.Name = "btnSiguienteInteres"
        Me.btnSiguienteInteres.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguienteInteres.TabIndex = 2
        Me.btnSiguienteInteres.UseVisualStyleBackColor = True
        '
        'btnAnteriorInteres
        '
        Me.btnAnteriorInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnteriorInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorInteres.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnteriorInteres.Image = CType(resources.GetObject("btnAnteriorInteres.Image"), System.Drawing.Image)
        Me.btnAnteriorInteres.Location = New System.Drawing.Point(56, 23)
        Me.btnAnteriorInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorInteres.Name = "btnAnteriorInteres"
        Me.btnAnteriorInteres.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorInteres.TabIndex = 1
        Me.btnAnteriorInteres.UseVisualStyleBackColor = True
        '
        'btnPrimeroInteres
        '
        Me.btnPrimeroInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimeroInteres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroInteres.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimeroInteres.Image = CType(resources.GetObject("btnPrimeroInteres.Image"), System.Drawing.Image)
        Me.btnPrimeroInteres.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimeroInteres.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroInteres.Name = "btnPrimeroInteres"
        Me.btnPrimeroInteres.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroInteres.TabIndex = 0
        Me.btnPrimeroInteres.UseVisualStyleBackColor = True
        '
        'frmInteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(830, 272)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInteres"
        Me.Text = " Registros de Intereses"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblInteres As Label
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarInteres As Button
    Friend WithEvents btnEliminarInteres As Button
    Friend WithEvents btnModificarInteres As Button
    Friend WithEvents btnAgregarInteres As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosInteres As Label
    Friend WithEvents btnUltimoInteres As Button
    Friend WithEvents btnSiguienteInteres As Button
    Friend WithEvents btnAnteriorInteres As Button
    Friend WithEvents btnPrimeroInteres As Button
End Class
