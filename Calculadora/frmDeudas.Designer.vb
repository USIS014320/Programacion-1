<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeudas
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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeudas))
        Me.DvDeudasDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.EmpleadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdsigacDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeudaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaIva = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblRespuestaSuma = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.CboDeuda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblnregistros = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.EmpleadosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.empleadosTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.categoriasTableAdapter()
        Me.DeudaTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.DeudaTableAdapter()
        Me.EmpleadosDeudaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosDeudaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_sigacDataSet1 = New Calculadora.bd_sigacDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.usuariosTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        CType(Me.DvDeudasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdsigacDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDeudaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDeudaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_sigacDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(492, 22)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 17)
        Label1.TabIndex = 28
        Label1.Text = "Fecha:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(33, 22)
        IdClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(75, 17)
        IdClienteLabel.TabIndex = 26
        IdClienteLabel.Text = "Empleado:"
        '
        'DvDeudasDataGridView
        '
        Me.DvDeudasDataGridView.AllowUserToAddRows = False
        Me.DvDeudasDataGridView.AllowUserToDeleteRows = False
        Me.DvDeudasDataGridView.AutoGenerateColumns = False
        Me.DvDeudasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvDeudasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.subtotal})
        Me.DvDeudasDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.DvDeudasDataGridView.Location = New System.Drawing.Point(37, 55)
        Me.DvDeudasDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DvDeudasDataGridView.Name = "DvDeudasDataGridView"
        Me.DvDeudasDataGridView.ReadOnly = True
        Me.DvDeudasDataGridView.RowHeadersWidth = 51
        Me.DvDeudasDataGridView.Size = New System.Drawing.Size(792, 247)
        Me.DvDeudasDataGridView.TabIndex = 29
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 125
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "clave"
        Me.ClaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        Me.ClaveDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaveDataGridViewTextBoxColumn.Width = 125
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "sub total "
        Me.subtotal.MinimumWidth = 6
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 125
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'Bd_sigacDataSet
        '
        Me.Bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.Bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource1
        '
        Me.EmpleadosBindingSource1.DataMember = "empleados"
        Me.EmpleadosBindingSource1.DataSource = Me.BdsigacDataSetBindingSource
        '
        'BdsigacDataSetBindingSource
        '
        Me.BdsigacDataSetBindingSource.DataSource = Me.Bd_sigacDataSet
        Me.BdsigacDataSetBindingSource.Position = 0
        '
        'DeudaBindingSource
        '
        Me.DeudaBindingSource.DataMember = "Deuda"
        Me.DeudaBindingSource.DataSource = Me.BdsigacDataSetBindingSource
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpleadosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 18)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.ValueMember = "usuario"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRespuestaTotal)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lblRespuestaIva)
        Me.Panel1.Controls.Add(Me.lbliva)
        Me.Panel1.Controls.Add(Me.lblRespuestaSuma)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(563, 326)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 90)
        Me.Panel1.TabIndex = 34
        '
        'lblRespuestaTotal
        '
        Me.lblRespuestaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaTotal.Location = New System.Drawing.Point(128, 71)
        Me.lblRespuestaTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaTotal.Name = "lblRespuestaTotal"
        Me.lblRespuestaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaTotal.Size = New System.Drawing.Size(133, 20)
        Me.lblRespuestaTotal.TabIndex = 5
        Me.lblRespuestaTotal.Text = "00.00"
        Me.lblRespuestaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(12, 71)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(74, 20)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL:"
        '
        'lblRespuestaIva
        '
        Me.lblRespuestaIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaIva.Location = New System.Drawing.Point(129, 37)
        Me.lblRespuestaIva.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaIva.Name = "lblRespuestaIva"
        Me.lblRespuestaIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaIva.Size = New System.Drawing.Size(133, 20)
        Me.lblRespuestaIva.TabIndex = 3
        Me.lblRespuestaIva.Text = "00.00"
        Me.lblRespuestaIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbliva
        '
        Me.lbliva.AutoSize = True
        Me.lbliva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.Location = New System.Drawing.Point(45, 37)
        Me.lbliva.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(44, 20)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "IVA:"
        '
        'lblRespuestaSuma
        '
        Me.lblRespuestaSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaSuma.Location = New System.Drawing.Point(129, 0)
        Me.lblRespuestaSuma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaSuma.Name = "lblRespuestaSuma"
        Me.lblRespuestaSuma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaSuma.Size = New System.Drawing.Size(133, 20)
        Me.lblRespuestaSuma.TabIndex = 1
        Me.lblRespuestaSuma.Text = "00.00"
        Me.lblRespuestaSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuma.Location = New System.Drawing.Point(21, 0)
        Me.lblsuma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(67, 20)
        Me.lblsuma.TabIndex = 0
        Me.lblsuma.Text = "SUMA:"
        '
        'CboDeuda
        '
        Me.CboDeuda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDeuda.FormattingEnabled = True
        Me.CboDeuda.Items.AddRange(New Object() {"Hipotecario", "Bancario", "Bono Corporativo"})
        Me.CboDeuda.Location = New System.Drawing.Point(117, 390)
        Me.CboDeuda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboDeuda.Name = "CboDeuda"
        Me.CboDeuda.Size = New System.Drawing.Size(160, 24)
        Me.CboDeuda.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 394)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Tipo Deuda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(611, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Monto a pagar:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblnregistros)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(288, 358)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbNavegacion.Size = New System.Drawing.Size(267, 58)
        Me.grbNavegacion.TabIndex = 30
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblnregistros
        '
        Me.lblnregistros.AutoSize = True
        Me.lblnregistros.Location = New System.Drawing.Point(96, 27)
        Me.lblnregistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnregistros.Name = "lblnregistros"
        Me.lblnregistros.Size = New System.Drawing.Size(46, 17)
        Me.lblnregistros.TabIndex = 4
        Me.lblnregistros.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(213, 16)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(44, 38)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(171, 16)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(44, 38)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(49, 16)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(44, 38)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(7, 16)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(44, 38)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(545, 18)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 35
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 326)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Producto Prestado:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.CategoriasBindingSource
        Me.ComboBox2.DisplayMember = "categoria"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(160, 320)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox2.TabIndex = 37
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'DeudaTableAdapter
        '
        Me.DeudaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosDeudaBindingSource
        '
        Me.EmpleadosDeudaBindingSource.DataMember = "empleados_Deuda"
        Me.EmpleadosDeudaBindingSource.DataSource = Me.EmpleadosBindingSource
        '
        'EmpleadosDeudaBindingSource1
        '
        Me.EmpleadosDeudaBindingSource1.DataMember = "empleados_Deuda"
        Me.EmpleadosDeudaBindingSource1.DataSource = Me.EmpleadosBindingSource
        '
        'Bd_sigacDataSet1
        '
        Me.Bd_sigacDataSet1.DataSetName = "bd_sigacDataSet"
        Me.Bd_sigacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.Bd_sigacDataSet1
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'frmDeudas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(868, 460)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CboDeuda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.DvDeudasDataGridView)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdClienteLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDeudas"
        Me.Text = "Registro de Deudas"
        CType(Me.DvDeudasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdsigacDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDeudaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDeudaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_sigacDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DvDeudasDataGridView As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaIva As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblRespuestaSuma As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents CboDeuda As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblnregistros As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BdsigacDataSetBindingSource As BindingSource
    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As bd_sigacDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasTableAdapter As bd_sigacDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents DeudaBindingSource As BindingSource
    Friend WithEvents DeudaTableAdapter As bd_sigacDataSetTableAdapters.DeudaTableAdapter
    Friend WithEvents EmpleadosBindingSource1 As BindingSource
    Friend WithEvents EmpleadosDeudaBindingSource As BindingSource
    Friend WithEvents EmpleadosDeudaBindingSource1 As BindingSource
    Friend WithEvents Bd_sigacDataSet1 As bd_sigacDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As bd_sigacDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
End Class
