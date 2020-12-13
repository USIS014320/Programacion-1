<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearprestamo
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearprestamo))
        Me.Bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.CrearprestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CrearprestamoTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.crearprestamoTableAdapter()
        Me.TableAdapterManager = New Calculadora.bd_sigacDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.clientesTableAdapter()
        Me.InteresesTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.interesesTableAdapter()
        Me.OcupacionTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.ocupacionTableAdapter()
        Me.lblTituloPrest = New System.Windows.Forms.Label()
        Me.IdClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdOcupacionComboBox = New System.Windows.Forms.ComboBox()
        Me.OcupacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OcupacionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OcupacionBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OcupacionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdInteresComboBox = New System.Windows.Forms.ComboBox()
        Me.InteresesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InteresesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InteresesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InteresesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.CuotasTextBox = New System.Windows.Forms.TextBox()
        Me.FechaprestamoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CrearprestamoClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CrearprestamoClienteTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.crearprestamoClienteTableAdapter()
        Me.CrearprestamoClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarClienteNuevo = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblinteresCompuesto = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(15, 93)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 20)
        Label1.TabIndex = 204
        Label1.Text = "Cliente:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(338, 93)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 20)
        Label4.TabIndex = 205
        Label4.Text = "Cédula:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(646, 89)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(94, 20)
        Label2.TabIndex = 206
        Label2.Text = "Ocupacion:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(16, 150)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(67, 20)
        Label6.TabIndex = 207
        Label6.Text = "Cuotas:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(338, 148)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(60, 20)
        Label5.TabIndex = 208
        Label5.Text = "Monto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(675, 154)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(65, 20)
        Label3.TabIndex = 209
        Label3.Text = "Interes:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(15, 225)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(137, 20)
        Label7.TabIndex = 210
        Label7.Text = "Fecha Prestamo:"
        '
        'Bd_sigacDataSet
        '
        Me.Bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.Bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrearprestamoBindingSource
        '
        Me.CrearprestamoBindingSource.DataMember = "crearprestamo"
        Me.CrearprestamoBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'CrearprestamoTableAdapter
        '
        Me.CrearprestamoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargosTableAdapter = Nothing
        Me.TableAdapterManager.categoriafaltanteTableAdapter = Nothing
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.contactosTableAdapter = Nothing
        Me.TableAdapterManager.crearprestamoTableAdapter = Me.CrearprestamoTableAdapter
        Me.TableAdapterManager.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager.DescuentosTableAdapter = Nothing
        Me.TableAdapterManager.deudaTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.faltanteproductoTableAdapter = Nothing
        Me.TableAdapterManager.ImprimirPagosVariosTableAdapter = Nothing
        Me.TableAdapterManager.ImprimirProveedorTableAdapter = Nothing
        Me.TableAdapterManager.interesesTableAdapter = Me.InteresesTableAdapter
        Me.TableAdapterManager.ocupacionTableAdapter = Me.OcupacionTableAdapter
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.pagosvariosTableAdapter = Nothing
        Me.TableAdapterManager.prestamosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosDeudaTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.salariosTableAdapter = Nothing
        Me.TableAdapterManager.tipofacturaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Calculadora.bd_sigacDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'InteresesTableAdapter
        '
        Me.InteresesTableAdapter.ClearBeforeFill = True
        '
        'OcupacionTableAdapter
        '
        Me.OcupacionTableAdapter.ClearBeforeFill = True
        '
        'lblTituloPrest
        '
        Me.lblTituloPrest.AutoSize = True
        Me.lblTituloPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTituloPrest.Location = New System.Drawing.Point(254, 9)
        Me.lblTituloPrest.Name = "lblTituloPrest"
        Me.lblTituloPrest.Size = New System.Drawing.Size(453, 51)
        Me.lblTituloPrest.TabIndex = 184
        Me.lblTituloPrest.Text = "PRESTAMOS SIGAC"
        '
        'IdClienteComboBox
        '
        Me.IdClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "idCliente", True))
        Me.IdClienteComboBox.DataSource = Me.ClientesBindingSource
        Me.IdClienteComboBox.DisplayMember = "nombre"
        Me.IdClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdClienteComboBox.FormattingEnabled = True
        Me.IdClienteComboBox.Location = New System.Drawing.Point(103, 89)
        Me.IdClienteComboBox.Name = "IdClienteComboBox"
        Me.IdClienteComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdClienteComboBox.TabIndex = 189
        Me.IdClienteComboBox.ValueMember = "idCliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'ClientesBindingSource2
        '
        Me.ClientesBindingSource2.DataMember = "clientes"
        Me.ClientesBindingSource2.DataSource = Me.Bd_sigacDataSet
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "clientes"
        Me.ClientesBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'IdOcupacionComboBox
        '
        Me.IdOcupacionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OcupacionBindingSource, "idOcupacion", True))
        Me.IdOcupacionComboBox.DataSource = Me.OcupacionBindingSource
        Me.IdOcupacionComboBox.DisplayMember = "ocupacion"
        Me.IdOcupacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdOcupacionComboBox.FormattingEnabled = True
        Me.IdOcupacionComboBox.Location = New System.Drawing.Point(761, 89)
        Me.IdOcupacionComboBox.Name = "IdOcupacionComboBox"
        Me.IdOcupacionComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdOcupacionComboBox.TabIndex = 191
        Me.IdOcupacionComboBox.ValueMember = "idOcupacion"
        '
        'OcupacionBindingSource
        '
        Me.OcupacionBindingSource.DataMember = "ocupacion"
        Me.OcupacionBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'OcupacionBindingSource2
        '
        Me.OcupacionBindingSource2.DataMember = "ocupacion"
        Me.OcupacionBindingSource2.DataSource = Me.Bd_sigacDataSet
        '
        'OcupacionBindingSource3
        '
        Me.OcupacionBindingSource3.DataMember = "ocupacion"
        Me.OcupacionBindingSource3.DataSource = Me.Bd_sigacDataSet
        '
        'OcupacionBindingSource1
        '
        Me.OcupacionBindingSource1.DataMember = "ocupacion"
        Me.OcupacionBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'IdInteresComboBox
        '
        Me.IdInteresComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InteresesBindingSource, "idInteres", True))
        Me.IdInteresComboBox.DataSource = Me.InteresesBindingSource
        Me.IdInteresComboBox.DisplayMember = "interes"
        Me.IdInteresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdInteresComboBox.FormattingEnabled = True
        Me.IdInteresComboBox.Location = New System.Drawing.Point(761, 150)
        Me.IdInteresComboBox.Name = "IdInteresComboBox"
        Me.IdInteresComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdInteresComboBox.TabIndex = 193
        Me.IdInteresComboBox.ValueMember = "idInteres"
        '
        'InteresesBindingSource
        '
        Me.InteresesBindingSource.DataMember = "intereses"
        Me.InteresesBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'InteresesBindingSource2
        '
        Me.InteresesBindingSource2.DataMember = "intereses"
        Me.InteresesBindingSource2.DataSource = Me.Bd_sigacDataSet
        '
        'InteresesBindingSource3
        '
        Me.InteresesBindingSource3.DataMember = "intereses"
        Me.InteresesBindingSource3.DataSource = Me.Bd_sigacDataSet
        '
        'InteresesBindingSource1
        '
        Me.InteresesBindingSource1.DataMember = "intereses"
        Me.InteresesBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CrearprestamoBindingSource, "cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(429, 93)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CedulaTextBox.TabIndex = 195
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CrearprestamoBindingSource, "monto", True))
        Me.MontoTextBox.Location = New System.Drawing.Point(429, 148)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MontoTextBox.TabIndex = 197
        '
        'CuotasTextBox
        '
        Me.CuotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CrearprestamoBindingSource, "cuotas", True))
        Me.CuotasTextBox.Location = New System.Drawing.Point(103, 148)
        Me.CuotasTextBox.Name = "CuotasTextBox"
        Me.CuotasTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CuotasTextBox.TabIndex = 199
        '
        'FechaprestamoDateTimePicker
        '
        Me.FechaprestamoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CrearprestamoBindingSource, "fechaprestamo", True))
        Me.FechaprestamoDateTimePicker.Location = New System.Drawing.Point(178, 223)
        Me.FechaprestamoDateTimePicker.Name = "FechaprestamoDateTimePicker"
        Me.FechaprestamoDateTimePicker.Size = New System.Drawing.Size(252, 22)
        Me.FechaprestamoDateTimePicker.TabIndex = 201
        '
        'CrearprestamoClienteBindingSource
        '
        Me.CrearprestamoClienteBindingSource.DataMember = "crearprestamoCliente"
        Me.CrearprestamoClienteBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'CrearprestamoClienteTableAdapter
        '
        Me.CrearprestamoClienteTableAdapter.ClearBeforeFill = True
        '
        'CrearprestamoClienteDataGridView
        '
        Me.CrearprestamoClienteDataGridView.AllowUserToAddRows = False
        Me.CrearprestamoClienteDataGridView.AllowUserToDeleteRows = False
        Me.CrearprestamoClienteDataGridView.AutoGenerateColumns = False
        Me.CrearprestamoClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CrearprestamoClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.CrearprestamoClienteDataGridView.DataSource = Me.CrearprestamoClienteBindingSource
        Me.CrearprestamoClienteDataGridView.Location = New System.Drawing.Point(44, 263)
        Me.CrearprestamoClienteDataGridView.Name = "CrearprestamoClienteDataGridView"
        Me.CrearprestamoClienteDataGridView.ReadOnly = True
        Me.CrearprestamoClienteDataGridView.RowHeadersWidth = 51
        Me.CrearprestamoClienteDataGridView.RowTemplate.Height = 24
        Me.CrearprestamoClienteDataGridView.Size = New System.Drawing.Size(917, 289)
        Me.CrearprestamoClienteDataGridView.TabIndex = 210
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idPrest"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPrest"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idCliente"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idOcupacion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idOcupacion"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idInteres"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idInteres"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cedula"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CEDULA"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MONTO"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cuotas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CUOTAS"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechaprestamo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FECHA DE PRESTAMO"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'btnAgregarClienteNuevo
        '
        Me.btnAgregarClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarClienteNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarClienteNuevo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAgregarClienteNuevo.Image = CType(resources.GetObject("btnAgregarClienteNuevo.Image"), System.Drawing.Image)
        Me.btnAgregarClienteNuevo.Location = New System.Drawing.Point(882, 13)
        Me.btnAgregarClienteNuevo.Name = "btnAgregarClienteNuevo"
        Me.btnAgregarClienteNuevo.Size = New System.Drawing.Size(79, 62)
        Me.btnAgregarClienteNuevo.TabIndex = 211
        Me.btnAgregarClienteNuevo.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCalcular.Image = CType(resources.GetObject("btnCalcular.Image"), System.Drawing.Image)
        Me.btnCalcular.Location = New System.Drawing.Point(679, 190)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(67, 61)
        Me.btnCalcular.TabIndex = 213
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(757, 210)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(74, 20)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL:"
        '
        'lblinteresCompuesto
        '
        Me.lblinteresCompuesto.AutoSize = True
        Me.lblinteresCompuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(912, 210)
        Me.lblinteresCompuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(49, 20)
        Me.lblinteresCompuesto.TabIndex = 224
        Me.lblinteresCompuesto.Text = "00.00"
        '
        'grbEdicion
        '
        Me.grbEdicion.BackColor = System.Drawing.Color.Transparent
        Me.grbEdicion.Controls.Add(Me.btnImprimir)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnAgregar)
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Location = New System.Drawing.Point(495, 561)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(466, 84)
        Me.grbEdicion.TabIndex = 226
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(337, 23)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(58, 48)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(131, 23)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(120, 48)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(21, 23)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(402, 23)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 48)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(253, 23)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 48)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'grbNavegacion
        '
        Me.grbNavegacion.BackColor = System.Drawing.Color.Transparent
        Me.grbNavegacion.Controls.Add(Me.lblRegistros)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(44, 561)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 225
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistros.TabIndex = 4
        Me.lblRegistros.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.Location = New System.Drawing.Point(288, 23)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(231, 23)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(56, 23)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(55, 48)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimero.Image = CType(resources.GetObject("btnPrimero.Image"), System.Drawing.Image)
        Me.btnPrimero.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'frmCrearprestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1007, 653)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.lblinteresCompuesto)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.btnAgregarClienteNuevo)
        Me.Controls.Add(Me.CrearprestamoClienteDataGridView)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.IdClienteComboBox)
        Me.Controls.Add(Me.IdOcupacionComboBox)
        Me.Controls.Add(Me.IdInteresComboBox)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(Me.MontoTextBox)
        Me.Controls.Add(Me.CuotasTextBox)
        Me.Controls.Add(Me.FechaprestamoDateTimePicker)
        Me.Controls.Add(Me.lblTituloPrest)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrearprestamo"
        Me.Text = "Registro de Prestamo"
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents CrearprestamoBindingSource As BindingSource
    Friend WithEvents CrearprestamoTableAdapter As bd_sigacDataSetTableAdapters.crearprestamoTableAdapter
    Friend WithEvents TableAdapterManager As bd_sigacDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblTituloPrest As Label
    Friend WithEvents IdClienteComboBox As ComboBox
    Friend WithEvents IdOcupacionComboBox As ComboBox
    Friend WithEvents IdInteresComboBox As ComboBox
    Friend WithEvents CedulaTextBox As TextBox
    Friend WithEvents MontoTextBox As TextBox
    Friend WithEvents CuotasTextBox As TextBox
    Friend WithEvents FechaprestamoDateTimePicker As DateTimePicker
    Friend WithEvents CrearprestamoClienteBindingSource As BindingSource
    Friend WithEvents CrearprestamoClienteTableAdapter As bd_sigacDataSetTableAdapters.crearprestamoClienteTableAdapter
    Friend WithEvents CrearprestamoClienteDataGridView As DataGridView
    Friend WithEvents ClientesTableAdapter As bd_sigacDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents OcupacionTableAdapter As bd_sigacDataSetTableAdapters.ocupacionTableAdapter
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents OcupacionBindingSource As BindingSource
    Friend WithEvents InteresesTableAdapter As bd_sigacDataSetTableAdapters.interesesTableAdapter
    Friend WithEvents OcupacionBindingSource1 As BindingSource
    Friend WithEvents InteresesBindingSource As BindingSource
    Friend WithEvents InteresesBindingSource1 As BindingSource
    Friend WithEvents btnAgregarClienteNuevo As Button
    Friend WithEvents ClientesBindingSource2 As BindingSource
    Friend WithEvents OcupacionBindingSource2 As BindingSource
    Friend WithEvents OcupacionBindingSource3 As BindingSource
    Friend WithEvents InteresesBindingSource2 As BindingSource
    Friend WithEvents InteresesBindingSource3 As BindingSource
    Friend WithEvents btnCalcular As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblinteresCompuesto As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistros As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnImprimir As Button
End Class
