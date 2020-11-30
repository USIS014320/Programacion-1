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
        Me.CrearprestamoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CrearprestamoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.lblTituloPrest = New System.Windows.Forms.Label()
        Me.IdClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdOcupacionComboBox = New System.Windows.Forms.ComboBox()
        Me.OcupacionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OcupacionBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OcupacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OcupacionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdInteresComboBox = New System.Windows.Forms.ComboBox()
        Me.InteresesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InteresesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InteresesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CrearprestamoBindingNavigator.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OcupacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteresesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrearprestamoClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(12, 132)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 20)
        Label1.TabIndex = 204
        Label1.Text = "Cliente:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(335, 132)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 20)
        Label4.TabIndex = 205
        Label4.Text = "Cédula:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(643, 128)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(94, 20)
        Label2.TabIndex = 206
        Label2.Text = "Ocupacion:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(13, 189)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(67, 20)
        Label6.TabIndex = 207
        Label6.Text = "Cuotas:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(335, 187)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(60, 20)
        Label5.TabIndex = 208
        Label5.Text = "Monto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(672, 193)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(65, 20)
        Label3.TabIndex = 209
        Label3.Text = "Interes:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(12, 264)
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
        Me.TableAdapterManager.DeudaTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.faltanteproductoTableAdapter = Nothing
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
        'CrearprestamoBindingNavigator
        '
        Me.CrearprestamoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CrearprestamoBindingNavigator.BindingSource = Me.CrearprestamoBindingSource
        Me.CrearprestamoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CrearprestamoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CrearprestamoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CrearprestamoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CrearprestamoBindingNavigatorSaveItem})
        Me.CrearprestamoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CrearprestamoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CrearprestamoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CrearprestamoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CrearprestamoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CrearprestamoBindingNavigator.Name = "CrearprestamoBindingNavigator"
        Me.CrearprestamoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CrearprestamoBindingNavigator.Size = New System.Drawing.Size(1007, 27)
        Me.CrearprestamoBindingNavigator.TabIndex = 0
        Me.CrearprestamoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CrearprestamoBindingNavigatorSaveItem
        '
        Me.CrearprestamoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CrearprestamoBindingNavigatorSaveItem.Image = CType(resources.GetObject("CrearprestamoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CrearprestamoBindingNavigatorSaveItem.Name = "CrearprestamoBindingNavigatorSaveItem"
        Me.CrearprestamoBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CrearprestamoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'lblTituloPrest
        '
        Me.lblTituloPrest.AutoSize = True
        Me.lblTituloPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTituloPrest.Location = New System.Drawing.Point(251, 48)
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
        Me.IdClienteComboBox.Location = New System.Drawing.Point(100, 128)
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
        Me.IdOcupacionComboBox.Location = New System.Drawing.Point(758, 128)
        Me.IdOcupacionComboBox.Name = "IdOcupacionComboBox"
        Me.IdOcupacionComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdOcupacionComboBox.TabIndex = 191
        Me.IdOcupacionComboBox.ValueMember = "idOcupacion"
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
        'OcupacionBindingSource
        '
        Me.OcupacionBindingSource.DataMember = "ocupacion"
        Me.OcupacionBindingSource.DataSource = Me.Bd_sigacDataSet
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
        Me.IdInteresComboBox.Location = New System.Drawing.Point(758, 189)
        Me.IdInteresComboBox.Name = "IdInteresComboBox"
        Me.IdInteresComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdInteresComboBox.TabIndex = 193
        Me.IdInteresComboBox.ValueMember = "idInteres"
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
        'InteresesBindingSource
        '
        Me.InteresesBindingSource.DataMember = "intereses"
        Me.InteresesBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'InteresesBindingSource1
        '
        Me.InteresesBindingSource1.DataMember = "intereses"
        Me.InteresesBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CrearprestamoBindingSource, "cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(426, 132)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CedulaTextBox.TabIndex = 195
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CrearprestamoBindingSource, "monto", True))
        Me.MontoTextBox.Location = New System.Drawing.Point(426, 187)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MontoTextBox.TabIndex = 197
        '
        'CuotasTextBox
        '
        Me.CuotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CrearprestamoBindingSource, "cuotas", True))
        Me.CuotasTextBox.Location = New System.Drawing.Point(100, 187)
        Me.CuotasTextBox.Name = "CuotasTextBox"
        Me.CuotasTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CuotasTextBox.TabIndex = 199
        '
        'FechaprestamoDateTimePicker
        '
        Me.FechaprestamoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CrearprestamoBindingSource, "fechaprestamo", True))
        Me.FechaprestamoDateTimePicker.Location = New System.Drawing.Point(175, 262)
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
        Me.CrearprestamoClienteDataGridView.Location = New System.Drawing.Point(41, 302)
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
        Me.btnAgregarClienteNuevo.Location = New System.Drawing.Point(879, 52)
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
        Me.btnCalcular.Location = New System.Drawing.Point(676, 229)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(67, 61)
        Me.btnCalcular.TabIndex = 213
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(754, 249)
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
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(909, 249)
        Me.lblinteresCompuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(49, 20)
        Me.lblinteresCompuesto.TabIndex = 224
        Me.lblinteresCompuesto.Text = "00.00"
        '
        'frmCrearprestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1007, 648)
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
        Me.Controls.Add(Me.CrearprestamoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrearprestamo"
        Me.Text = "Registro de Prestamo"
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CrearprestamoBindingNavigator.ResumeLayout(False)
        Me.CrearprestamoBindingNavigator.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OcupacionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteresesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrearprestamoClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents CrearprestamoBindingSource As BindingSource
    Friend WithEvents CrearprestamoTableAdapter As bd_sigacDataSetTableAdapters.crearprestamoTableAdapter
    Friend WithEvents TableAdapterManager As bd_sigacDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CrearprestamoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CrearprestamoBindingNavigatorSaveItem As ToolStripButton
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
End Class
