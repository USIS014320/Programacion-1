<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeuda
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
        Dim IdDeudaLabel As System.Windows.Forms.Label
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim IdPrestamoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeuda))
        Me.Bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.DeudaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeudaTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.deudaTableAdapter()
        Me.TableAdapterManager = New Calculadora.bd_sigacDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.empleadosTableAdapter()
        Me.PrestamosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.prestamosTableAdapter()
        Me.DeudaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DeudaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdDeudaComboBox = New System.Windows.Forms.ComboBox()
        Me.DeudaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeudaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdEmpleadoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPrestamoComboBox = New System.Windows.Forms.ComboBox()
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallaPrestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallaPrestamoTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.DetallaPrestamoTableAdapter()
        Me.DetallaPrestamoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnImprimir = New System.Windows.Forms.Button()
        IdDeudaLabel = New System.Windows.Forms.Label()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        IdPrestamoLabel = New System.Windows.Forms.Label()
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeudaBindingNavigator.SuspendLayout()
        CType(Me.DeudaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeudaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallaPrestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallaPrestamoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdDeudaLabel
        '
        IdDeudaLabel.AutoSize = True
        IdDeudaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdDeudaLabel.Location = New System.Drawing.Point(20, 46)
        IdDeudaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdDeudaLabel.Name = "IdDeudaLabel"
        IdDeudaLabel.Size = New System.Drawing.Size(140, 17)
        IdDeudaLabel.TabIndex = 1
        IdDeudaLabel.Text = "Código de Prestamo:"
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdEmpleadoLabel.Location = New System.Drawing.Point(362, 40)
        IdEmpleadoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(75, 17)
        IdEmpleadoLabel.TabIndex = 3
        IdEmpleadoLabel.Text = "Empleado:"
        '
        'IdPrestamoLabel
        '
        IdPrestamoLabel.AutoSize = True
        IdPrestamoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPrestamoLabel.Location = New System.Drawing.Point(20, 93)
        IdPrestamoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdPrestamoLabel.Name = "IdPrestamoLabel"
        IdPrestamoLabel.Size = New System.Drawing.Size(72, 17)
        IdPrestamoLabel.TabIndex = 5
        IdPrestamoLabel.Text = "Prestamo:"
        '
        'Bd_sigacDataSet
        '
        Me.Bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.Bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeudaBindingSource
        '
        Me.DeudaBindingSource.DataMember = "deuda"
        Me.DeudaBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'DeudaTableAdapter
        '
        Me.DeudaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cargosTableAdapter = Nothing
        Me.TableAdapterManager.categoriafaltanteTableAdapter = Nothing
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.contactosTableAdapter = Nothing
        Me.TableAdapterManager.crearprestamoTableAdapter = Nothing
        Me.TableAdapterManager.dcomprasTableAdapter = Nothing
        Me.TableAdapterManager.DescuentosTableAdapter = Nothing
        Me.TableAdapterManager.deudaTableAdapter = Me.DeudaTableAdapter
        Me.TableAdapterManager.empleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.faltanteproductoTableAdapter = Nothing
        Me.TableAdapterManager.ImprimirProveedorTableAdapter = Nothing
        Me.TableAdapterManager.interesesTableAdapter = Nothing
        Me.TableAdapterManager.ocupacionTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.pagosvariosTableAdapter = Nothing
        Me.TableAdapterManager.prestamosTableAdapter = Me.PrestamosTableAdapter
        Me.TableAdapterManager.ProductosDeudaTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.salariosTableAdapter = Nothing
        Me.TableAdapterManager.tipofacturaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Calculadora.bd_sigacDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'DeudaBindingNavigator
        '
        Me.DeudaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DeudaBindingNavigator.BindingSource = Me.DeudaBindingSource
        Me.DeudaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DeudaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DeudaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DeudaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DeudaBindingNavigatorSaveItem})
        Me.DeudaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DeudaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DeudaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DeudaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DeudaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DeudaBindingNavigator.Name = "DeudaBindingNavigator"
        Me.DeudaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DeudaBindingNavigator.Size = New System.Drawing.Size(676, 27)
        Me.DeudaBindingNavigator.TabIndex = 0
        Me.DeudaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'DeudaBindingNavigatorSaveItem
        '
        Me.DeudaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeudaBindingNavigatorSaveItem.Image = CType(resources.GetObject("DeudaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DeudaBindingNavigatorSaveItem.Name = "DeudaBindingNavigatorSaveItem"
        Me.DeudaBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.DeudaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdDeudaComboBox
        '
        Me.IdDeudaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DeudaBindingSource1, "IdDeuda", True))
        Me.IdDeudaComboBox.DataSource = Me.DeudaBindingSource2
        Me.IdDeudaComboBox.DisplayMember = "Codigo"
        Me.IdDeudaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdDeudaComboBox.FormattingEnabled = True
        Me.IdDeudaComboBox.Location = New System.Drawing.Point(175, 42)
        Me.IdDeudaComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdDeudaComboBox.Name = "IdDeudaComboBox"
        Me.IdDeudaComboBox.Size = New System.Drawing.Size(119, 21)
        Me.IdDeudaComboBox.TabIndex = 2
        Me.IdDeudaComboBox.ValueMember = "IdDeuda"
        '
        'DeudaBindingSource1
        '
        Me.DeudaBindingSource1.DataMember = "deuda"
        Me.DeudaBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'DeudaBindingSource2
        '
        Me.DeudaBindingSource2.DataMember = "deuda"
        Me.DeudaBindingSource2.DataSource = Me.Bd_sigacDataSet
        '
        'IdEmpleadoComboBox
        '
        Me.IdEmpleadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idEmpleado", True))
        Me.IdEmpleadoComboBox.DataSource = Me.EmpleadosBindingSource1
        Me.IdEmpleadoComboBox.DisplayMember = "nombre"
        Me.IdEmpleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdEmpleadoComboBox.FormattingEnabled = True
        Me.IdEmpleadoComboBox.Location = New System.Drawing.Point(466, 40)
        Me.IdEmpleadoComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdEmpleadoComboBox.Name = "IdEmpleadoComboBox"
        Me.IdEmpleadoComboBox.Size = New System.Drawing.Size(108, 21)
        Me.IdEmpleadoComboBox.TabIndex = 4
        Me.IdEmpleadoComboBox.ValueMember = "idEmpleado"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'EmpleadosBindingSource1
        '
        Me.EmpleadosBindingSource1.DataMember = "empleados"
        Me.EmpleadosBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'IdPrestamoComboBox
        '
        Me.IdPrestamoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrestamosBindingSource, "idPrestamo", True))
        Me.IdPrestamoComboBox.DataSource = Me.PrestamosBindingSource1
        Me.IdPrestamoComboBox.DisplayMember = "capital"
        Me.IdPrestamoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPrestamoComboBox.FormattingEnabled = True
        Me.IdPrestamoComboBox.Location = New System.Drawing.Point(175, 89)
        Me.IdPrestamoComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdPrestamoComboBox.Name = "IdPrestamoComboBox"
        Me.IdPrestamoComboBox.Size = New System.Drawing.Size(119, 21)
        Me.IdPrestamoComboBox.TabIndex = 6
        Me.IdPrestamoComboBox.ValueMember = "idPrestamo"
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "prestamos"
        Me.PrestamosBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'PrestamosBindingSource1
        '
        Me.PrestamosBindingSource1.DataMember = "prestamos"
        Me.PrestamosBindingSource1.DataSource = Me.Bd_sigacDataSet
        '
        'DetallaPrestamoBindingSource
        '
        Me.DetallaPrestamoBindingSource.DataMember = "DetallaPrestamo"
        Me.DetallaPrestamoBindingSource.DataSource = Me.Bd_sigacDataSet
        '
        'DetallaPrestamoTableAdapter
        '
        Me.DetallaPrestamoTableAdapter.ClearBeforeFill = True
        '
        'DetallaPrestamoDataGridView
        '
        Me.DetallaPrestamoDataGridView.AllowUserToAddRows = False
        Me.DetallaPrestamoDataGridView.AllowUserToDeleteRows = False
        Me.DetallaPrestamoDataGridView.AutoGenerateColumns = False
        Me.DetallaPrestamoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallaPrestamoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8})
        Me.DetallaPrestamoDataGridView.DataSource = Me.DetallaPrestamoBindingSource
        Me.DetallaPrestamoDataGridView.Location = New System.Drawing.Point(23, 121)
        Me.DetallaPrestamoDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DetallaPrestamoDataGridView.Name = "DetallaPrestamoDataGridView"
        Me.DetallaPrestamoDataGridView.ReadOnly = True
        Me.DetallaPrestamoDataGridView.RowHeadersWidth = 51
        Me.DetallaPrestamoDataGridView.RowTemplate.Height = 24
        Me.DetallaPrestamoDataGridView.Size = New System.Drawing.Size(636, 179)
        Me.DetallaPrestamoDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdDeuda"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdDeuda"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idEmpleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idEmpleado"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idPrestamo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idPrestamo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mes"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MES"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "pago"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PAGO"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SUBTOTAL"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "capital"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CAPITAL"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(614, 320)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(45, 36)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmDeuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(676, 379)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.DetallaPrestamoDataGridView)
        Me.Controls.Add(IdDeudaLabel)
        Me.Controls.Add(Me.IdDeudaComboBox)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoComboBox)
        Me.Controls.Add(IdPrestamoLabel)
        Me.Controls.Add(Me.IdPrestamoComboBox)
        Me.Controls.Add(Me.DeudaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDeuda"
        Me.Text = " Regristro de Prestamos"
        CType(Me.Bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeudaBindingNavigator.ResumeLayout(False)
        Me.DeudaBindingNavigator.PerformLayout()
        CType(Me.DeudaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeudaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallaPrestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallaPrestamoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents DeudaBindingSource As BindingSource
    Friend WithEvents DeudaTableAdapter As bd_sigacDataSetTableAdapters.deudaTableAdapter
    Friend WithEvents TableAdapterManager As bd_sigacDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DeudaBindingNavigator As BindingNavigator
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
    Friend WithEvents DeudaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdDeudaComboBox As ComboBox
    Friend WithEvents IdEmpleadoComboBox As ComboBox
    Friend WithEvents IdPrestamoComboBox As ComboBox
    Friend WithEvents DetallaPrestamoBindingSource As BindingSource
    Friend WithEvents DetallaPrestamoTableAdapter As bd_sigacDataSetTableAdapters.DetallaPrestamoTableAdapter
    Friend WithEvents DetallaPrestamoDataGridView As DataGridView
    Friend WithEvents EmpleadosTableAdapter As bd_sigacDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents DeudaBindingSource1 As BindingSource
    Friend WithEvents DeudaBindingSource2 As BindingSource
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents PrestamosTableAdapter As bd_sigacDataSetTableAdapters.prestamosTableAdapter
    Friend WithEvents EmpleadosBindingSource1 As BindingSource
    Friend WithEvents PrestamosBindingSource As BindingSource
    Friend WithEvents PrestamosBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
End Class
