<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcrearprestamo
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
        Dim lblFechaPrestamo As System.Windows.Forms.Label
        Dim lblInteresPrest As System.Windows.Forms.Label
        Dim lblClientePrest As System.Windows.Forms.Label
        Dim lblCédulaPrest As System.Windows.Forms.Label
        Dim lblTeléfonoPrest As System.Windows.Forms.Label
        Dim lblCódigoClientePrest As System.Windows.Forms.Label
        Dim lblOcupaciónPrest As System.Windows.Forms.Label
        Dim lblMontoPrest As System.Windows.Forms.Label
        Dim lblCuotasPrest As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIdVenta = New System.Windows.Forms.Label()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaInteres = New System.Windows.Forms.Label()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.lblRespuestaMonto = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblnregistros = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DventasProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.idDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DventasProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpFechaPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.TipofacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCédulaPrest = New System.Windows.Forms.TextBox()
        Me.txtTeléfonoPrest = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboClientePrest = New System.Windows.Forms.ComboBox()
        Me.txtMontoPrest = New System.Windows.Forms.TextBox()
        Me.txtCuotasPrest = New System.Windows.Forms.TextBox()
        Me.cboInteresPrest = New System.Windows.Forms.ComboBox()
        Me.cboOcupacionPrest = New System.Windows.Forms.ComboBox()
        lblFechaPrestamo = New System.Windows.Forms.Label()
        lblInteresPrest = New System.Windows.Forms.Label()
        lblClientePrest = New System.Windows.Forms.Label()
        lblCédulaPrest = New System.Windows.Forms.Label()
        lblTeléfonoPrest = New System.Windows.Forms.Label()
        lblCódigoClientePrest = New System.Windows.Forms.Label()
        lblOcupaciónPrest = New System.Windows.Forms.Label()
        lblMontoPrest = New System.Windows.Forms.Label()
        lblCuotasPrest = New System.Windows.Forms.Label()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        CType(Me.DventasProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DventasProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipofacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaPrestamo
        '
        lblFechaPrestamo.AutoSize = True
        lblFechaPrestamo.Location = New System.Drawing.Point(40, 167)
        lblFechaPrestamo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblFechaPrestamo.Name = "lblFechaPrestamo"
        lblFechaPrestamo.Size = New System.Drawing.Size(115, 17)
        lblFechaPrestamo.TabIndex = 23
        lblFechaPrestamo.Text = "Fecha Prestamo:"
        '
        'lblInteresPrest
        '
        lblInteresPrest.AutoSize = True
        lblInteresPrest.Location = New System.Drawing.Point(292, 235)
        lblInteresPrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblInteresPrest.Name = "lblInteresPrest"
        lblInteresPrest.Size = New System.Drawing.Size(55, 17)
        lblInteresPrest.TabIndex = 27
        lblInteresPrest.Text = "Interes:"
        '
        'lblClientePrest
        '
        lblClientePrest.AutoSize = True
        lblClientePrest.Location = New System.Drawing.Point(44, 45)
        lblClientePrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblClientePrest.Name = "lblClientePrest"
        lblClientePrest.Size = New System.Drawing.Size(55, 17)
        lblClientePrest.TabIndex = 29
        lblClientePrest.Text = "Cliente:"
        '
        'lblCédulaPrest
        '
        lblCédulaPrest.AutoSize = True
        lblCédulaPrest.Location = New System.Drawing.Point(36, 110)
        lblCédulaPrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCédulaPrest.Name = "lblCédulaPrest"
        lblCédulaPrest.Size = New System.Drawing.Size(56, 17)
        lblCédulaPrest.TabIndex = 38
        lblCédulaPrest.Text = "Cédula:"
        '
        'lblTeléfonoPrest
        '
        lblTeléfonoPrest.AutoSize = True
        lblTeléfonoPrest.Location = New System.Drawing.Point(314, 109)
        lblTeléfonoPrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblTeléfonoPrest.Name = "lblTeléfonoPrest"
        lblTeléfonoPrest.Size = New System.Drawing.Size(68, 17)
        lblTeléfonoPrest.TabIndex = 40
        lblTeléfonoPrest.Text = "Teléfono:"
        '
        'lblCódigoClientePrest
        '
        lblCódigoClientePrest.AutoSize = True
        lblCódigoClientePrest.Location = New System.Drawing.Point(586, 107)
        lblCódigoClientePrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCódigoClientePrest.Name = "lblCódigoClientePrest"
        lblCódigoClientePrest.Size = New System.Drawing.Size(103, 17)
        lblCódigoClientePrest.TabIndex = 42
        lblCódigoClientePrest.Text = "Código Cliente:"
        '
        'lblOcupaciónPrest
        '
        lblOcupaciónPrest.AutoSize = True
        lblOcupaciónPrest.Location = New System.Drawing.Point(464, 167)
        lblOcupaciónPrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblOcupaciónPrest.Name = "lblOcupaciónPrest"
        lblOcupaciónPrest.Size = New System.Drawing.Size(80, 17)
        lblOcupaciónPrest.TabIndex = 45
        lblOcupaciónPrest.Text = "Ocupación:"
        '
        'lblMontoPrest
        '
        lblMontoPrest.AutoSize = True
        lblMontoPrest.Location = New System.Drawing.Point(759, 167)
        lblMontoPrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblMontoPrest.Name = "lblMontoPrest"
        lblMontoPrest.Size = New System.Drawing.Size(51, 17)
        lblMontoPrest.TabIndex = 47
        lblMontoPrest.Text = "Monto:"
        '
        'lblCuotasPrest
        '
        lblCuotasPrest.AutoSize = True
        lblCuotasPrest.Location = New System.Drawing.Point(40, 235)
        lblCuotasPrest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCuotasPrest.Name = "lblCuotasPrest"
        lblCuotasPrest.Size = New System.Drawing.Size(56, 17)
        lblCuotasPrest.TabIndex = 49
        lblCuotasPrest.Text = "Cuotas:"
        '
        'lblIdVenta
        '
        Me.lblIdVenta.AutoSize = True
        Me.lblIdVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "idVenta", True))
        Me.lblIdVenta.Location = New System.Drawing.Point(615, 50)
        Me.lblIdVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdVenta.Name = "lblIdVenta"
        Me.lblIdVenta.Size = New System.Drawing.Size(51, 17)
        Me.lblIdVenta.TabIndex = 37
        Me.lblIdVenta.Text = "Label1"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        '
        'subtotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle1
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
        'lblRespuestaTotal
        '
        Me.lblRespuestaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaTotal.Location = New System.Drawing.Point(822, 607)
        Me.lblRespuestaTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaTotal.Name = "lblRespuestaTotal"
        Me.lblRespuestaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaTotal.Size = New System.Drawing.Size(89, 31)
        Me.lblRespuestaTotal.TabIndex = 5
        Me.lblRespuestaTotal.Text = "00.00"
        Me.lblRespuestaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(723, 608)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(91, 25)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL:"
        '
        'lblRespuestaInteres
        '
        Me.lblRespuestaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaInteres.Location = New System.Drawing.Point(521, 609)
        Me.lblRespuestaInteres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaInteres.Name = "lblRespuestaInteres"
        Me.lblRespuestaInteres.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaInteres.Size = New System.Drawing.Size(88, 27)
        Me.lblRespuestaInteres.TabIndex = 3
        Me.lblRespuestaInteres.Text = "00.00"
        Me.lblRespuestaInteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteres.Location = New System.Drawing.Point(410, 609)
        Me.lblInteres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(111, 25)
        Me.lblInteres.TabIndex = 2
        Me.lblInteres.Text = "INTERES:"
        '
        'lblRespuestaMonto
        '
        Me.lblRespuestaMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaMonto.Location = New System.Drawing.Point(163, 613)
        Me.lblRespuestaMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaMonto.Name = "lblRespuestaMonto"
        Me.lblRespuestaMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaMonto.Size = New System.Drawing.Size(89, 25)
        Me.lblRespuestaMonto.TabIndex = 1
        Me.lblRespuestaMonto.Text = "00.00"
        Me.lblRespuestaMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(89, 611)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(82, 25)
        Me.lblMonto.TabIndex = 0
        Me.lblMonto.Text = "SUMA:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblnregistros)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(11, 660)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(4)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(4)
        Me.grbNavegacion.Size = New System.Drawing.Size(391, 58)
        Me.grbNavegacion.TabIndex = 33
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblnregistros
        '
        Me.lblnregistros.AutoSize = True
        Me.lblnregistros.Location = New System.Drawing.Point(130, 29)
        Me.lblnregistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnregistros.Name = "lblnregistros"
        Me.lblnregistros.Size = New System.Drawing.Size(46, 17)
        Me.lblnregistros.TabIndex = 4
        Me.lblnregistros.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(327, 17)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(44, 38)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(275, 17)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(44, 38)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(60, 17)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(44, 38)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(8, 17)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(44, 38)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnAgregar)
        Me.grbEdicion.Location = New System.Drawing.Point(410, 660)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(4)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(4)
        Me.grbEdicion.Size = New System.Drawing.Size(556, 58)
        Me.grbEdicion.TabIndex = 34
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(435, 16)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(95, 38)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(296, 16)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 38)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(148, 17)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(108, 38)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(14, 17)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(101, 38)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarCliente.Location = New System.Drawing.Point(415, 29)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(184, 38)
        Me.btnAgregarCliente.TabIndex = 36
        Me.btnAgregarCliente.Text = "Nuevo Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        Me.btnAgregarCliente.Visible = False
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.precio.HeaderText = "PRECIO"
        Me.precio.MinimumWidth = 6
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 125
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.cantidad.HeaderText = "CANT"
        Me.cantidad.MinimumWidth = 6
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 125
        '
        'DventasProductosDataGridView
        '
        Me.DventasProductosDataGridView.AllowUserToAddRows = False
        Me.DventasProductosDataGridView.AllowUserToDeleteRows = False
        Me.DventasProductosDataGridView.AutoGenerateColumns = False
        Me.DventasProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DventasProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDetalle, Me.idVenta, Me.idProducto, Me.codigo, Me.descripcion, Me.cantidad, Me.precio, Me.subtotal, Me.marca, Me.medidas})
        Me.DventasProductosDataGridView.DataSource = Me.DventasProductosBindingSource
        Me.DventasProductosDataGridView.Location = New System.Drawing.Point(11, 293)
        Me.DventasProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DventasProductosDataGridView.Name = "DventasProductosDataGridView"
        Me.DventasProductosDataGridView.ReadOnly = True
        Me.DventasProductosDataGridView.RowHeadersWidth = 51
        Me.DventasProductosDataGridView.Size = New System.Drawing.Size(960, 289)
        Me.DventasProductosDataGridView.TabIndex = 30
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
        'idVenta
        '
        Me.idVenta.DataPropertyName = "idVenta"
        Me.idVenta.HeaderText = "idVenta"
        Me.idVenta.MinimumWidth = 6
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Visible = False
        Me.idVenta.Width = 125
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
        'DventasProductosBindingSource
        '
        Me.DventasProductosBindingSource.DataMember = "FK_dventas_ventas1"
        Me.DventasProductosBindingSource.DataSource = Me.VentasBindingSource
        '
        'dtpFechaPrestamo
        '
        Me.dtpFechaPrestamo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fecha_vta", True))
        Me.dtpFechaPrestamo.Enabled = False
        Me.dtpFechaPrestamo.Location = New System.Drawing.Point(163, 162)
        Me.dtpFechaPrestamo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaPrestamo.Name = "dtpFechaPrestamo"
        Me.dtpFechaPrestamo.Size = New System.Drawing.Size(288, 22)
        Me.dtpFechaPrestamo.TabIndex = 24
        '
        'TipofacturaBindingSource
        '
        Me.TipofacturaBindingSource.DataMember = "tipofactura"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        '
        'txtCédulaPrest
        '
        Me.txtCédulaPrest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nfactura", True))
        Me.txtCédulaPrest.Location = New System.Drawing.Point(136, 106)
        Me.txtCédulaPrest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCédulaPrest.Name = "txtCédulaPrest"
        Me.txtCédulaPrest.ReadOnly = True
        Me.txtCédulaPrest.Size = New System.Drawing.Size(140, 22)
        Me.txtCédulaPrest.TabIndex = 39
        '
        'txtTeléfonoPrest
        '
        Me.txtTeléfonoPrest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nfactura", True))
        Me.txtTeléfonoPrest.Location = New System.Drawing.Point(405, 104)
        Me.txtTeléfonoPrest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTeléfonoPrest.Name = "txtTeléfonoPrest"
        Me.txtTeléfonoPrest.ReadOnly = True
        Me.txtTeléfonoPrest.Size = New System.Drawing.Size(140, 22)
        Me.txtTeléfonoPrest.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nfactura", True))
        Me.TextBox1.Location = New System.Drawing.Point(697, 102)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(140, 22)
        Me.TextBox1.TabIndex = 43
        '
        'cboClientePrest
        '
        Me.cboClientePrest.FormattingEnabled = True
        Me.cboClientePrest.Location = New System.Drawing.Point(144, 38)
        Me.cboClientePrest.Name = "cboClientePrest"
        Me.cboClientePrest.Size = New System.Drawing.Size(218, 24)
        Me.cboClientePrest.TabIndex = 44
        '
        'txtMontoPrest
        '
        Me.txtMontoPrest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nfactura", True))
        Me.txtMontoPrest.Location = New System.Drawing.Point(830, 167)
        Me.txtMontoPrest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoPrest.Name = "txtMontoPrest"
        Me.txtMontoPrest.ReadOnly = True
        Me.txtMontoPrest.Size = New System.Drawing.Size(140, 22)
        Me.txtMontoPrest.TabIndex = 48
        '
        'txtCuotasPrest
        '
        Me.txtCuotasPrest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nfactura", True))
        Me.txtCuotasPrest.Location = New System.Drawing.Point(112, 232)
        Me.txtCuotasPrest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuotasPrest.Name = "txtCuotasPrest"
        Me.txtCuotasPrest.ReadOnly = True
        Me.txtCuotasPrest.Size = New System.Drawing.Size(140, 22)
        Me.txtCuotasPrest.TabIndex = 50
        '
        'cboInteresPrest
        '
        Me.cboInteresPrest.FormattingEnabled = True
        Me.cboInteresPrest.Location = New System.Drawing.Point(354, 230)
        Me.cboInteresPrest.Name = "cboInteresPrest"
        Me.cboInteresPrest.Size = New System.Drawing.Size(149, 24)
        Me.cboInteresPrest.TabIndex = 51
        '
        'cboOcupacionPrest
        '
        Me.cboOcupacionPrest.FormattingEnabled = True
        Me.cboOcupacionPrest.Location = New System.Drawing.Point(562, 167)
        Me.cboOcupacionPrest.Name = "cboOcupacionPrest"
        Me.cboOcupacionPrest.Size = New System.Drawing.Size(152, 24)
        Me.cboOcupacionPrest.TabIndex = 52
        '
        'frmcrearprestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(984, 725)
        Me.Controls.Add(Me.cboOcupacionPrest)
        Me.Controls.Add(Me.cboInteresPrest)
        Me.Controls.Add(lblCuotasPrest)
        Me.Controls.Add(Me.txtCuotasPrest)
        Me.Controls.Add(lblMontoPrest)
        Me.Controls.Add(Me.txtMontoPrest)
        Me.Controls.Add(lblOcupaciónPrest)
        Me.Controls.Add(Me.cboClientePrest)
        Me.Controls.Add(lblCódigoClientePrest)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(lblTeléfonoPrest)
        Me.Controls.Add(Me.txtTeléfonoPrest)
        Me.Controls.Add(lblCédulaPrest)
        Me.Controls.Add(Me.txtCédulaPrest)
        Me.Controls.Add(Me.lblRespuestaTotal)
        Me.Controls.Add(Me.lblIdVenta)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblRespuestaInteres)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.lblRespuestaMonto)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(lblFechaPrestamo)
        Me.Controls.Add(Me.DventasProductosDataGridView)
        Me.Controls.Add(Me.dtpFechaPrestamo)
        Me.Controls.Add(lblInteresPrest)
        Me.Controls.Add(lblClientePrest)
        Me.Name = "frmcrearprestamo"
        Me.Text = "Registro de Prestamos"
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        CType(Me.DventasProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DventasProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipofacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdVenta As Label
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents medidas As DataGridViewTextBoxColumn
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaInteres As Label
    Friend WithEvents lblInteres As Label
    Friend WithEvents lblRespuestaMonto As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblnregistros As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DventasProductosDataGridView As DataGridView
    Friend WithEvents idDetalle As DataGridViewTextBoxColumn
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DventasProductosBindingSource As BindingSource
    Friend WithEvents dtpFechaPrestamo As DateTimePicker
    Friend WithEvents TipofacturaBindingSource As BindingSource
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents txtCédulaPrest As TextBox
    Friend WithEvents txtTeléfonoPrest As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboClientePrest As ComboBox
    Friend WithEvents txtMontoPrest As TextBox
    Friend WithEvents txtCuotasPrest As TextBox
    Friend WithEvents cboInteresPrest As ComboBox
    Friend WithEvents cboOcupacionPrest As ComboBox
End Class
