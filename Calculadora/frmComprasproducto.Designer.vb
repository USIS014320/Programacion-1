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
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
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
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblnregistros = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.grbdComprasProductos = New System.Windows.Forms.GroupBox()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.lblIdCompra = New System.Windows.Forms.Label()
        NfacturaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
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
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbdComprasProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(588, 6)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(61, 13)
        NfacturaLabel.TabIndex = 3
        NfacturaLabel.Text = "Factura N°:"
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(297, 54)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 9
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(530, 53)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(81, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Forma de pago:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Location = New System.Drawing.Point(3, 8)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(59, 13)
        IdProveedorLabel.TabIndex = 13
        IdProveedorLabel.Text = "Proveedor:"
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(12, 53)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(75, 13)
        Fecha_vtaLabel.TabIndex = 14
        Fecha_vtaLabel.Text = "fecha compra:"
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
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "nfactura", True))
        Me.NfacturaTextBox.Location = New System.Drawing.Point(655, 6)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.Size = New System.Drawing.Size(110, 20)
        Me.NfacturaTextBox.TabIndex = 4
        '
        'IdTipofacturaComboBox
        '
        Me.IdTipofacturaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComprasBindingSource, "idTipofactura", True))
        Me.IdTipofacturaComboBox.DataSource = Me.TipofacturaBindingSource
        Me.IdTipofacturaComboBox.DisplayMember = "tipofactura"
        Me.IdTipofacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdTipofacturaComboBox.FormattingEnabled = True
        Me.IdTipofacturaComboBox.Location = New System.Drawing.Point(370, 47)
        Me.IdTipofacturaComboBox.Name = "IdTipofacturaComboBox"
        Me.IdTipofacturaComboBox.Size = New System.Drawing.Size(146, 21)
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
        Me.IdPagoComboBox.Location = New System.Drawing.Point(617, 48)
        Me.IdPagoComboBox.Name = "IdPagoComboBox"
        Me.IdPagoComboBox.Size = New System.Drawing.Size(148, 21)
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
        Me.IdProveedorComboBox.Location = New System.Drawing.Point(68, 5)
        Me.IdProveedorComboBox.Name = "IdProveedorComboBox"
        Me.IdProveedorComboBox.Size = New System.Drawing.Size(208, 21)
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
        Me.TableAdapterManager.deudaTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.faltanteproductoTableAdapter = Nothing
        Me.TableAdapterManager.ImprimirProveedorTableAdapter = Nothing
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
        Me.Fecha_vtaDateTimePicker.Location = New System.Drawing.Point(91, 48)
        Me.Fecha_vtaDateTimePicker.Name = "Fecha_vtaDateTimePicker"
        Me.Fecha_vtaDateTimePicker.Size = New System.Drawing.Size(186, 20)
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
        Me.DcomprasProductosDataGridView.Location = New System.Drawing.Point(15, 103)
        Me.DcomprasProductosDataGridView.Name = "DcomprasProductosDataGridView"
        Me.DcomprasProductosDataGridView.ReadOnly = True
        Me.DcomprasProductosDataGridView.RowHeadersWidth = 51
        Me.DcomprasProductosDataGridView.Size = New System.Drawing.Size(750, 327)
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
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 225
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
        Me.subtotal.Width = 125
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
        Me.Panel1.Location = New System.Drawing.Point(593, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 120)
        Me.Panel1.TabIndex = 16
        '
        'lblrespuestatotalcompra
        '
        Me.lblrespuestatotalcompra.AutoSize = True
        Me.lblrespuestatotalcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuestatotalcompra.Location = New System.Drawing.Point(108, 91)
        Me.lblrespuestatotalcompra.Name = "lblrespuestatotalcompra"
        Me.lblrespuestatotalcompra.Size = New System.Drawing.Size(36, 16)
        Me.lblrespuestatotalcompra.TabIndex = 5
        Me.lblrespuestatotalcompra.Text = "0.00"
        '
        'lblrespuestaivacompra
        '
        Me.lblrespuestaivacompra.AutoSize = True
        Me.lblrespuestaivacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuestaivacompra.Location = New System.Drawing.Point(108, 52)
        Me.lblrespuestaivacompra.Name = "lblrespuestaivacompra"
        Me.lblrespuestaivacompra.Size = New System.Drawing.Size(36, 16)
        Me.lblrespuestaivacompra.TabIndex = 4
        Me.lblrespuestaivacompra.Text = "0.00"
        '
        'lblrespuestasumacompra
        '
        Me.lblrespuestasumacompra.AutoSize = True
        Me.lblrespuestasumacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuestasumacompra.Location = New System.Drawing.Point(108, 15)
        Me.lblrespuestasumacompra.Name = "lblrespuestasumacompra"
        Me.lblrespuestasumacompra.Size = New System.Drawing.Size(36, 16)
        Me.lblrespuestasumacompra.TabIndex = 3
        Me.lblrespuestasumacompra.Text = "0.00"
        '
        'lbltotalcompra
        '
        Me.lbltotalcompra.AutoSize = True
        Me.lbltotalcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcompra.Location = New System.Drawing.Point(7, 91)
        Me.lbltotalcompra.Name = "lbltotalcompra"
        Me.lbltotalcompra.Size = New System.Drawing.Size(69, 20)
        Me.lbltotalcompra.TabIndex = 2
        Me.lbltotalcompra.Text = "TOTAL:"
        '
        'lblivacompra
        '
        Me.lblivacompra.AutoSize = True
        Me.lblivacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblivacompra.Location = New System.Drawing.Point(7, 52)
        Me.lblivacompra.Name = "lblivacompra"
        Me.lblivacompra.Size = New System.Drawing.Size(44, 20)
        Me.lblivacompra.TabIndex = 1
        Me.lblivacompra.Text = "IVA:"
        '
        'lblsumacompra
        '
        Me.lblsumacompra.AutoSize = True
        Me.lblsumacompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsumacompra.Location = New System.Drawing.Point(7, 15)
        Me.lblsumacompra.Name = "lblsumacompra"
        Me.lblsumacompra.Size = New System.Drawing.Size(65, 20)
        Me.lblsumacompra.TabIndex = 0
        Me.lblsumacompra.Text = "SUMA:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblnregistros)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(6, 518)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(200, 47)
        Me.grbNavegacion.TabIndex = 17
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblnregistros
        '
        Me.lblnregistros.AutoSize = True
        Me.lblnregistros.Location = New System.Drawing.Point(72, 22)
        Me.lblnregistros.Name = "lblnregistros"
        Me.lblnregistros.Size = New System.Drawing.Size(36, 13)
        Me.lblnregistros.TabIndex = 4
        Me.lblnregistros.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(160, 13)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(33, 31)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(128, 13)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(33, 31)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(37, 13)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(33, 31)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(5, 13)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(33, 31)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnImprimir)
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnAgregar)
        Me.grbEdicion.Location = New System.Drawing.Point(212, 518)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(375, 47)
        Me.grbEdicion.TabIndex = 18
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(299, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 31)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(231, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 31)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(157, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 31)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(77, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(81, 31)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(2, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(76, 31)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(289, 6)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(138, 22)
        Me.btnAgregarProveedor.TabIndex = 20
        Me.btnAgregarProveedor.Text = "Nuevo Proveedor"
        Me.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        Me.btnAgregarProveedor.Visible = False
        '
        'grbdComprasProductos
        '
        Me.grbdComprasProductos.Controls.Add(Me.btnQuitarProducto)
        Me.grbdComprasProductos.Controls.Add(Me.btnAgregarProducto)
        Me.grbdComprasProductos.Location = New System.Drawing.Point(6, 460)
        Me.grbdComprasProductos.Name = "grbdComprasProductos"
        Me.grbdComprasProductos.Size = New System.Drawing.Size(352, 50)
        Me.grbdComprasProductos.TabIndex = 21
        Me.grbdComprasProductos.TabStop = False
        Me.grbdComprasProductos.Visible = False
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarProducto.Location = New System.Drawing.Point(177, 13)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(165, 31)
        Me.btnQuitarProducto.TabIndex = 10
        Me.btnQuitarProducto.Text = "Quitar Productos"
        Me.btnQuitarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(6, 13)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(165, 31)
        Me.btnAgregarProducto.TabIndex = 9
        Me.btnAgregarProducto.Text = "Agregar Productos"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'lblIdCompra
        '
        Me.lblIdCompra.AutoSize = True
        Me.lblIdCompra.Location = New System.Drawing.Point(440, 11)
        Me.lblIdCompra.Name = "lblIdCompra"
        Me.lblIdCompra.Size = New System.Drawing.Size(39, 13)
        Me.lblIdCompra.TabIndex = 21
        Me.lblIdCompra.Text = "Label1"
        '
        'frmComprasproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(777, 568)
        Me.Controls.Add(Me.lblIdCompra)
        Me.Controls.Add(Me.grbdComprasProductos)
        Me.Controls.Add(Me.btnAgregarProveedor)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComprasproducto"
        Me.Text = "Compras de productos"
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
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbdComprasProductos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As bd_sigacDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents TableAdapterManager As bd_sigacDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblrespuestatotalcompra As Label
    Friend WithEvents lblrespuestaivacompra As Label
    Friend WithEvents lblrespuestasumacompra As Label
    Friend WithEvents lbltotalcompra As Label
    Friend WithEvents lblivacompra As Label
    Friend WithEvents lblsumacompra As Label
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
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblnregistros As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents grbdComprasProductos As GroupBox
    Friend WithEvents btnQuitarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents lblIdCompra As Label
End Class
