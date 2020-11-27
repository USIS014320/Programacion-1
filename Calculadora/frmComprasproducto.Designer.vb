<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprasproducto
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
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Dim Fecha_vtaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprasproducto))
        Me.ComprasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
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
        Me.ComprasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipofacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.TipofacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.comprasTableAdapter()
        Me.TableAdapterManager = New Calculadora.bd_sigacDataSetTableAdapters.TableAdapterManager()
        Me.DcomprasProductosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.DcomprasProductosTableAdapter()
        Me.Fecha_vtaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProveedoresTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.proveedoresTableAdapter()
        Me.TipofacturaTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.tipofacturaTableAdapter()
        Me.PagosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.pagosTableAdapter()
        Me.DcomprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.dcomprasTableAdapter()
        Me.DcomprasProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DcomprasProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.idDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblrespuestatotalcompra = New System.Windows.Forms.Label()
        Me.lblrespuestaivacompra = New System.Windows.Forms.Label()
        Me.lblrespuestasumacompra = New System.Windows.Forms.Label()
        Me.lbltotalcompra = New System.Windows.Forms.Label()
        Me.lblivacompra = New System.Windows.Forms.Label()
        Me.lblsumacompra = New System.Windows.Forms.Label()
        NfacturaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasBindingNavigator.SuspendLayout()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipofacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcomprasProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(776, 47)
        NfacturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(80, 17)
        NfacturaLabel.TabIndex = 3
        NfacturaLabel.Text = "Factura N°:"
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(396, 106)
        IdTipofacturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(88, 17)
        IdTipofacturaLabel.TabIndex = 9
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(694, 106)
        IdPagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(108, 17)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Forma de pago:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Location = New System.Drawing.Point(4, 49)
        IdProveedorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(78, 17)
        IdProveedorLabel.TabIndex = 13
        IdProveedorLabel.Text = "Proveedor:"
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(16, 105)
        Fecha_vtaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(98, 17)
        Fecha_vtaLabel.TabIndex = 14
        Fecha_vtaLabel.Text = "fecha compra:"
        '
        'ComprasBindingNavigator
        '
        Me.ComprasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ComprasBindingNavigator.BindingSource = Me.ComprasBindingSource
        Me.ComprasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComprasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ComprasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ComprasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComprasBindingNavigatorSaveItem})
        Me.ComprasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComprasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComprasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComprasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComprasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComprasBindingNavigator.Name = "ComprasBindingNavigator"
        Me.ComprasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComprasBindingNavigator.Size = New System.Drawing.Size(1036, 27)
        Me.ComprasBindingNavigator.TabIndex = 0
        Me.ComprasBindingNavigator.Text = "BindingNavigator1"
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
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "compras"
        Me.ComprasBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'Bd_sigacDataSet
        '
        Me.Bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.Bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        'ComprasBindingNavigatorSaveItem
        '
        Me.ComprasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComprasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComprasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComprasBindingNavigatorSaveItem.Name = "ComprasBindingNavigatorSaveItem"
        Me.ComprasBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ComprasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "nfactura", True))
        Me.NfacturaTextBox.Location = New System.Drawing.Point(864, 44)
        Me.NfacturaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.Size = New System.Drawing.Size(145, 22)
        Me.NfacturaTextBox.TabIndex = 4
        '
        'IdTipofacturaComboBox
        '
        Me.IdTipofacturaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idTipofactura", True))
        Me.IdTipofacturaComboBox.DataSource = Me.TipofacturaBindingSource
        Me.IdTipofacturaComboBox.DisplayMember = "tipofactura"
        Me.IdTipofacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdTipofacturaComboBox.FormattingEnabled = True
        Me.IdTipofacturaComboBox.Location = New System.Drawing.Point(493, 97)
        Me.IdTipofacturaComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTipofacturaComboBox.Name = "IdTipofacturaComboBox"
        Me.IdTipofacturaComboBox.Size = New System.Drawing.Size(193, 24)
        Me.IdTipofacturaComboBox.TabIndex = 10
        Me.IdTipofacturaComboBox.ValueMember = "idTipofactura"
        '
        'TipofacturaBindingSource
        '
        Me.TipofacturaBindingSource.DataMember = "tipofactura"
        Me.TipofacturaBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'IdPagoComboBox
        '
        Me.IdPagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idPago", True))
        Me.IdPagoComboBox.DataSource = Me.PagosBindingSource
        Me.IdPagoComboBox.DisplayMember = "pago"
        Me.IdPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPagoComboBox.FormattingEnabled = True
        Me.IdPagoComboBox.Location = New System.Drawing.Point(813, 99)
        Me.IdPagoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdPagoComboBox.Name = "IdPagoComboBox"
        Me.IdPagoComboBox.Size = New System.Drawing.Size(196, 24)
        Me.IdPagoComboBox.TabIndex = 12
        Me.IdPagoComboBox.ValueMember = "idPago"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        Me.PagosBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'IdProveedorComboBox
        '
        Me.IdProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idProveedor", True))
        Me.IdProveedorComboBox.DataSource = Me.ProveedoresBindingSource
        Me.IdProveedorComboBox.DisplayMember = "nombreempresa"
        Me.IdProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdProveedorComboBox.FormattingEnabled = True
        Me.IdProveedorComboBox.Location = New System.Drawing.Point(91, 46)
        Me.IdProveedorComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdProveedorComboBox.Name = "IdProveedorComboBox"
        Me.IdProveedorComboBox.Size = New System.Drawing.Size(276, 24)
        Me.IdProveedorComboBox.TabIndex = 14
        Me.IdProveedorComboBox.ValueMember = "idProveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'DcomprasProductosBindingSource
        '
        Me.DcomprasProductosBindingSource.DataMember = "DcomprasProductos"
        Me.DcomprasProductosBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargosTableAdapter = Nothing
        Me.TableAdapterManager.categoriafaltanteTableAdapter = Nothing
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.contactosTableAdapter = Nothing
        Me.TableAdapterManager.crearprestamoTableAdapter = Nothing
        Me.TableAdapterManager.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager.DescuentosTableAdapter = Nothing
        Me.TableAdapterManager.DeudaTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.faltanteproductoTableAdapter = Nothing
        Me.TableAdapterManager.interesesTableAdapter = Nothing
        Me.TableAdapterManager.ocupacionTableAdapter = Nothing
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
        'DcomprasProductosTableAdapter
        '
        Me.DcomprasProductosTableAdapter.ClearBeforeFill = True
        '
        'Fecha_vtaDateTimePicker
        '
        Me.Fecha_vtaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "fecha_vta", True))
        Me.Fecha_vtaDateTimePicker.Location = New System.Drawing.Point(121, 98)
        Me.Fecha_vtaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.Fecha_vtaDateTimePicker.Name = "Fecha_vtaDateTimePicker"
        Me.Fecha_vtaDateTimePicker.Size = New System.Drawing.Size(246, 22)
        Me.Fecha_vtaDateTimePicker.TabIndex = 15
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TipofacturaTableAdapter
        '
        Me.TipofacturaTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'DcomprasBindingSource
        '
        Me.DcomprasBindingSource.DataMember = "dcompras"
        Me.DcomprasBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'DcomprasTableAdapter
        '
        Me.DcomprasTableAdapter.ClearBeforeFill = True
        '
        'DcomprasProductosBindingSource1
        '
        Me.DcomprasProductosBindingSource1.DataMember = "FK_dcompras_compras1"
        Me.DcomprasProductosBindingSource1.DataSource = Me.ComprasBindingSource
        '
        'DcomprasProductosDataGridView
        '
        Me.DcomprasProductosDataGridView.AllowUserToAddRows = False
        Me.DcomprasProductosDataGridView.AllowUserToDeleteRows = False
        Me.DcomprasProductosDataGridView.AutoGenerateColumns = False
        Me.DcomprasProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DcomprasProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDetalle, Me.idCompra, Me.idProducto, Me.codigo, Me.descripcion, Me.cantidad, Me.precio, Me.subtotal, Me.marca, Me.medidas})
        Me.DcomprasProductosDataGridView.DataSource = Me.DcomprasProductosBindingSource1
        Me.DcomprasProductosDataGridView.Location = New System.Drawing.Point(20, 155)
        Me.DcomprasProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DcomprasProductosDataGridView.Name = "DcomprasProductosDataGridView"
        Me.DcomprasProductosDataGridView.ReadOnly = True
        Me.DcomprasProductosDataGridView.RowHeadersWidth = 51
        Me.DcomprasProductosDataGridView.Size = New System.Drawing.Size(989, 374)
        Me.DcomprasProductosDataGridView.TabIndex = 15
        '
        'idDetalle
        '
        Me.idDetalle.DataPropertyName = "idDetalle"
        Me.idDetalle.HeaderText = "idDetalle"
        Me.idDetalle.MinimumWidth = 6
        Me.idDetalle.Name = "idDetalle"
        Me.idDetalle.ReadOnly = True
        Me.idDetalle.Visible = False
        Me.idDetalle.Width = 125
        '
        'idCompra
        '
        Me.idCompra.DataPropertyName = "idCompra"
        Me.idCompra.HeaderText = "idCompra"
        Me.idCompra.MinimumWidth = 6
        Me.idCompra.Name = "idCompra"
        Me.idCompra.ReadOnly = True
        Me.idCompra.Visible = False
        Me.idCompra.Width = 125
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idProducto"
        Me.idProducto.HeaderText = "idProducto"
        Me.idProducto.MinimumWidth = 6
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        Me.idProducto.Width = 125
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 250
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.MinimumWidth = 6
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 125
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "PRECIO"
        Me.precio.MinimumWidth = 6
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 125
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.MinimumWidth = 6
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 150
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "marca"
        Me.marca.MinimumWidth = 6
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Visible = False
        Me.marca.Width = 125
        '
        'medidas
        '
        Me.medidas.DataPropertyName = "medidas"
        Me.medidas.HeaderText = "medidas"
        Me.medidas.MinimumWidth = 6
        Me.medidas.Name = "medidas"
        Me.medidas.ReadOnly = True
        Me.medidas.Visible = False
        Me.medidas.Width = 125
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblrespuestatotalcompra)
        Me.Panel1.Controls.Add(Me.lblrespuestaivacompra)
        Me.Panel1.Controls.Add(Me.lblrespuestasumacompra)
        Me.Panel1.Controls.Add(Me.lbltotalcompra)
        Me.Panel1.Controls.Add(Me.lblivacompra)
        Me.Panel1.Controls.Add(Me.lblsumacompra)
        Me.Panel1.Location = New System.Drawing.Point(717, 537)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 148)
        Me.Panel1.TabIndex = 16
        '
        'lblrespuestatotalcompra
        '
        Me.lblrespuestatotalcompra.AutoSize = True
        Me.lblrespuestatotalcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuestatotalcompra.Location = New System.Drawing.Point(163, 112)
        Me.lblrespuestatotalcompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuestatotalcompra.Name = "lblrespuestatotalcompra"
        Me.lblrespuestatotalcompra.Size = New System.Drawing.Size(54, 25)
        Me.lblrespuestatotalcompra.TabIndex = 5
        Me.lblrespuestatotalcompra.Text = "0.00"
        '
        'lblrespuestaivacompra
        '
        Me.lblrespuestaivacompra.AutoSize = True
        Me.lblrespuestaivacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuestaivacompra.Location = New System.Drawing.Point(163, 64)
        Me.lblrespuestaivacompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuestaivacompra.Name = "lblrespuestaivacompra"
        Me.lblrespuestaivacompra.Size = New System.Drawing.Size(54, 25)
        Me.lblrespuestaivacompra.TabIndex = 4
        Me.lblrespuestaivacompra.Text = "0.00"
        '
        'lblrespuestasumacompra
        '
        Me.lblrespuestasumacompra.AutoSize = True
        Me.lblrespuestasumacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuestasumacompra.Location = New System.Drawing.Point(163, 18)
        Me.lblrespuestasumacompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuestasumacompra.Name = "lblrespuestasumacompra"
        Me.lblrespuestasumacompra.Size = New System.Drawing.Size(54, 25)
        Me.lblrespuestasumacompra.TabIndex = 3
        Me.lblrespuestasumacompra.Text = "0.00"
        '
        'lbltotalcompra
        '
        Me.lbltotalcompra.AutoSize = True
        Me.lbltotalcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcompra.Location = New System.Drawing.Point(9, 112)
        Me.lbltotalcompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalcompra.Name = "lbltotalcompra"
        Me.lbltotalcompra.Size = New System.Drawing.Size(91, 25)
        Me.lbltotalcompra.TabIndex = 2
        Me.lbltotalcompra.Text = "TOTAL:"
        '
        'lblivacompra
        '
        Me.lblivacompra.AutoSize = True
        Me.lblivacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblivacompra.Location = New System.Drawing.Point(9, 64)
        Me.lblivacompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblivacompra.Name = "lblivacompra"
        Me.lblivacompra.Size = New System.Drawing.Size(55, 25)
        Me.lblivacompra.TabIndex = 1
        Me.lblivacompra.Text = "IVA:"
        '
        'lblsumacompra
        '
        Me.lblsumacompra.AutoSize = True
        Me.lblsumacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsumacompra.Location = New System.Drawing.Point(9, 18)
        Me.lblsumacompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsumacompra.Name = "lblsumacompra"
        Me.lblsumacompra.Size = New System.Drawing.Size(82, 25)
        Me.lblsumacompra.TabIndex = 0
        Me.lblsumacompra.Text = "SUMA:"
        '
        'frmComprasproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1036, 699)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DcomprasProductosDataGridView)
        Me.Controls.Add(Fecha_vtaLabel)
        Me.Controls.Add(Me.Fecha_vtaDateTimePicker)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Me.NfacturaTextBox)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(Me.IdTipofacturaComboBox)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoComboBox)
        Me.Controls.Add(IdProveedorLabel)
        Me.Controls.Add(Me.IdProveedorComboBox)
        Me.Controls.Add(Me.ComprasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmComprasproducto"
        Me.Text = "Compras de productos"
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasBindingNavigator.ResumeLayout(False)
        Me.ComprasBindingNavigator.PerformLayout()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipofacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcomprasProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As bd_sigacDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents TableAdapterManager As bd_sigacDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasBindingNavigator As BindingNavigator
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
    Friend WithEvents ComprasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NfacturaTextBox As TextBox
    Friend WithEvents IdTipofacturaComboBox As ComboBox
    Friend WithEvents IdPagoComboBox As ComboBox
    Friend WithEvents IdProveedorComboBox As ComboBox
    Friend WithEvents DcomprasProductosBindingSource As BindingSource
    Friend WithEvents DcomprasProductosTableAdapter As bd_sigacDataSetTableAdapters.DcomprasProductosTableAdapter
    Friend WithEvents Fecha_vtaDateTimePicker As DateTimePicker
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As bd_sigacDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents TipofacturaBindingSource As BindingSource
    Friend WithEvents TipofacturaTableAdapter As bd_sigacDataSetTableAdapters.tipofacturaTableAdapter
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As bd_sigacDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents DcomprasBindingSource As BindingSource
    Friend WithEvents DcomprasTableAdapter As bd_sigacDataSetTableAdapters.dcomprasTableAdapter
    Friend WithEvents DcomprasProductosBindingSource1 As BindingSource
    Friend WithEvents DcomprasProductosDataGridView As DataGridView
    Friend WithEvents idDetalle As DataGridViewTextBoxColumn
    Friend WithEvents idCompra As DataGridViewTextBoxColumn
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents medidas As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblrespuestatotalcompra As Label
    Friend WithEvents lblrespuestaivacompra As Label
    Friend WithEvents lblrespuestasumacompra As Label
    Friend WithEvents lbltotalcompra As Label
    Friend WithEvents lblivacompra As Label
    Friend WithEvents lblsumacompra As Label
End Class
