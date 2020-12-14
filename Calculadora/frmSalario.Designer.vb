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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalario))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DescuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.lblDescuentos = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscarDescuento = New System.Windows.Forms.Button()
        Me.btnEliminarDescuento = New System.Windows.Forms.Button()
        Me.btnModificarDescuento = New System.Windows.Forms.Button()
        Me.btnAgregarDescuento = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosSalario = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.DescuentosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.DescuentosTableAdapter()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.grbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblUsuario)
        Me.grbDatos.Controls.Add(Me.txtUsuario)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(10, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(600, 95)
        Me.grbDatos.TabIndex = 9
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Usuario"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(15, 43)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(82, 17)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "USUARIO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lblDescuentos)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(10, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Size = New System.Drawing.Size(600, 95)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Descuentos"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DescuentosBindingSource
        Me.ComboBox1.DisplayMember = "Descuento"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(333, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'DescuentosBindingSource
        '
        Me.DescuentosBindingSource.DataMember = "Descuentos"
        Me.DescuentosBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'Bd_sigacDataSet
        '
        Me.Bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.Bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblDescuentos
        '
        Me.lblDescuentos.AutoSize = True
        Me.lblDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentos.Location = New System.Drawing.Point(15, 43)
        Me.lblDescuentos.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescuentos.Name = "lblDescuentos"
        Me.lblDescuentos.Size = New System.Drawing.Size(118, 17)
        Me.lblDescuentos.TabIndex = 4
        Me.lblDescuentos.Text = "DESCUENTOS:"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnImprimir)
        Me.grbEdicion.Controls.Add(Me.btnBuscarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnEliminarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnModificarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnAgregarDescuento)
        Me.grbEdicion.Location = New System.Drawing.Point(283, 230)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(329, 68)
        Me.grbEdicion.TabIndex = 71
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(230, 19)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(44, 39)
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscarDescuento
        '
        Me.btnBuscarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDescuento.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarDescuento.Image = CType(resources.GetObject("btnBuscarDescuento.Image"), System.Drawing.Image)
        Me.btnBuscarDescuento.Location = New System.Drawing.Point(273, 20)
        Me.btnBuscarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarDescuento.Name = "btnBuscarDescuento"
        Me.btnBuscarDescuento.Size = New System.Drawing.Size(54, 39)
        Me.btnBuscarDescuento.TabIndex = 8
        Me.btnBuscarDescuento.UseVisualStyleBackColor = True
        '
        'btnEliminarDescuento
        '
        Me.btnEliminarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDescuento.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarDescuento.Image = CType(resources.GetObject("btnEliminarDescuento.Image"), System.Drawing.Image)
        Me.btnEliminarDescuento.Location = New System.Drawing.Point(183, 19)
        Me.btnEliminarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarDescuento.Name = "btnEliminarDescuento"
        Me.btnEliminarDescuento.Size = New System.Drawing.Size(62, 39)
        Me.btnEliminarDescuento.TabIndex = 7
        Me.btnEliminarDescuento.UseVisualStyleBackColor = True
        '
        'btnModificarDescuento
        '
        Me.btnModificarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDescuento.Location = New System.Drawing.Point(91, 19)
        Me.btnModificarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarDescuento.Name = "btnModificarDescuento"
        Me.btnModificarDescuento.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarDescuento.TabIndex = 6
        Me.btnModificarDescuento.Text = "Modificar"
        Me.btnModificarDescuento.UseVisualStyleBackColor = True
        '
        'btnAgregarDescuento
        '
        Me.btnAgregarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDescuento.Location = New System.Drawing.Point(11, 19)
        Me.btnAgregarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarDescuento.Name = "btnAgregarDescuento"
        Me.btnAgregarDescuento.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarDescuento.TabIndex = 5
        Me.btnAgregarDescuento.Text = "Nuevo"
        Me.btnAgregarDescuento.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosSalario)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 230)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 70
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosSalario
        '
        Me.lblRegistrosSalario.AutoSize = True
        Me.lblRegistrosSalario.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosSalario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosSalario.Name = "lblRegistrosSalario"
        Me.lblRegistrosSalario.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosSalario.TabIndex = 4
        Me.lblRegistrosSalario.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(42, 19)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(41, 39)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimero.Image = CType(resources.GetObject("btnPrimero.Image"), System.Drawing.Image)
        Me.btnPrimero.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'DescuentosTableAdapter
        '
        Me.DescuentosTableAdapter.ClearBeforeFill = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(158, 40)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(333, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'frmSalario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(622, 306)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalario"
        Me.Text = " Salario"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDescuentos As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarDescuento As Button
    Friend WithEvents btnEliminarDescuento As Button
    Friend WithEvents btnModificarDescuento As Button
    Friend WithEvents btnAgregarDescuento As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosSalario As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents DescuentosBindingSource As BindingSource
    Friend WithEvents DescuentosTableAdapter As bd_sigacDataSetTableAdapters.DescuentosTableAdapter
    Friend WithEvents txtUsuario As TextBox
End Class
