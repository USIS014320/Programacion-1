<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcreacionprestamo
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
        Me.grdRegistroPrest = New System.Windows.Forms.DataGridView()
        Me.idPrest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOcupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigocliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuotas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaprestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPrest = New System.Windows.Forms.Button()
        Me.btnEliminarPrest = New System.Windows.Forms.Button()
        Me.btnModificarPrest = New System.Windows.Forms.Button()
        Me.btnAgregarPrest = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosPrest = New System.Windows.Forms.Label()
        Me.btnUltimoPrest = New System.Windows.Forms.Button()
        Me.btnSiguientePrest = New System.Windows.Forms.Button()
        Me.btnAnteriorPrest = New System.Windows.Forms.Button()
        Me.btnPrimeroPrest = New System.Windows.Forms.Button()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblRespuestaMontoPrest = New System.Windows.Forms.Label()
        Me.lblRespuestInteresPrest = New System.Windows.Forms.Label()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.lblRespuestaTotalPrest = New System.Windows.Forms.Label()
        Me.lblTotalPrest = New System.Windows.Forms.Label()
        Me.lblClientePrest = New System.Windows.Forms.Label()
        Me.txtCédulaPrest = New System.Windows.Forms.TextBox()
        Me.lblPrest = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.cboClientePrest = New System.Windows.Forms.ComboBox()
        Me.lblCédulaPrest = New System.Windows.Forms.Label()
        Me.lblTeléfonoPrest = New System.Windows.Forms.Label()
        Me.txtTeléfonoPrest = New System.Windows.Forms.TextBox()
        Me.lblCódigoClientePrest = New System.Windows.Forms.Label()
        Me.txtCódigoClientePrest = New System.Windows.Forms.TextBox()
        Me.lblFechaPrestamo = New System.Windows.Forms.Label()
        Me.dtpFechaPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.lblOcupaciónPrest = New System.Windows.Forms.Label()
        Me.cboOcupacionPrest = New System.Windows.Forms.ComboBox()
        Me.lblMontoPrest = New System.Windows.Forms.Label()
        Me.txtMontoPrest = New System.Windows.Forms.TextBox()
        Me.lblCuotasPrest = New System.Windows.Forms.Label()
        Me.txtCuotasPrest = New System.Windows.Forms.TextBox()
        Me.lblInteresPrest = New System.Windows.Forms.Label()
        Me.cboInteresPrest = New System.Windows.Forms.ComboBox()
        Me.lblTituloPrest = New System.Windows.Forms.Label()
        CType(Me.grdRegistroPrest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdRegistroPrest
        '
        Me.grdRegistroPrest.AllowUserToAddRows = False
        Me.grdRegistroPrest.AllowUserToDeleteRows = False
        Me.grdRegistroPrest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRegistroPrest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPrest, Me.idCliente, Me.idOcupacion, Me.idInteres, Me.cedula, Me.telefono, Me.codigocliente, Me.cliente, Me.ocupacion, Me.monto, Me.cuotas, Me.interes, Me.fechaprestamo, Me.total})
        Me.grdRegistroPrest.Location = New System.Drawing.Point(10, 323)
        Me.grdRegistroPrest.Name = "grdRegistroPrest"
        Me.grdRegistroPrest.ReadOnly = True
        Me.grdRegistroPrest.RowHeadersWidth = 51
        Me.grdRegistroPrest.RowTemplate.Height = 24
        Me.grdRegistroPrest.Size = New System.Drawing.Size(951, 235)
        Me.grdRegistroPrest.TabIndex = 54
        '
        'idPrest
        '
        Me.idPrest.HeaderText = "ID PRESTAMO"
        Me.idPrest.MinimumWidth = 6
        Me.idPrest.Name = "idPrest"
        Me.idPrest.ReadOnly = True
        Me.idPrest.Visible = False
        Me.idPrest.Width = 125
        '
        'idCliente
        '
        Me.idCliente.HeaderText = "ID CLIENTE"
        Me.idCliente.MinimumWidth = 6
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        Me.idCliente.Width = 125
        '
        'idOcupacion
        '
        Me.idOcupacion.HeaderText = "ID OCUPACION"
        Me.idOcupacion.MinimumWidth = 6
        Me.idOcupacion.Name = "idOcupacion"
        Me.idOcupacion.ReadOnly = True
        Me.idOcupacion.Visible = False
        Me.idOcupacion.Width = 125
        '
        'idInteres
        '
        Me.idInteres.HeaderText = "ID INTERES"
        Me.idInteres.MinimumWidth = 6
        Me.idInteres.Name = "idInteres"
        Me.idInteres.ReadOnly = True
        Me.idInteres.Visible = False
        Me.idInteres.Width = 125
        '
        'cedula
        '
        Me.cedula.HeaderText = "CEDULA"
        Me.cedula.MinimumWidth = 6
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Width = 125
        '
        'telefono
        '
        Me.telefono.HeaderText = "TELEFONO"
        Me.telefono.MinimumWidth = 6
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 125
        '
        'codigocliente
        '
        Me.codigocliente.HeaderText = "CODIGO CLIENTE"
        Me.codigocliente.MinimumWidth = 6
        Me.codigocliente.Name = "codigocliente"
        Me.codigocliente.ReadOnly = True
        Me.codigocliente.Width = 125
        '
        'cliente
        '
        Me.cliente.HeaderText = "CLIENTE"
        Me.cliente.MinimumWidth = 6
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 125
        '
        'ocupacion
        '
        Me.ocupacion.HeaderText = "OCUPACION"
        Me.ocupacion.MinimumWidth = 6
        Me.ocupacion.Name = "ocupacion"
        Me.ocupacion.ReadOnly = True
        Me.ocupacion.Width = 125
        '
        'monto
        '
        Me.monto.HeaderText = "MONTO"
        Me.monto.MinimumWidth = 6
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 125
        '
        'cuotas
        '
        Me.cuotas.HeaderText = "CUOTAS"
        Me.cuotas.MinimumWidth = 6
        Me.cuotas.Name = "cuotas"
        Me.cuotas.ReadOnly = True
        Me.cuotas.Width = 125
        '
        'interes
        '
        Me.interes.HeaderText = "INTERES"
        Me.interes.MinimumWidth = 6
        Me.interes.Name = "interes"
        Me.interes.ReadOnly = True
        Me.interes.Width = 125
        '
        'fechaprestamo
        '
        Me.fechaprestamo.HeaderText = "FECHA PRESTAMO"
        Me.fechaprestamo.MinimumWidth = 6
        Me.fechaprestamo.Name = "fechaprestamo"
        Me.fechaprestamo.ReadOnly = True
        Me.fechaprestamo.Width = 125
        '
        'total
        '
        Me.total.HeaderText = "TOTAL"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 125
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarPrest)
        Me.grbEdicion.Controls.Add(Me.btnEliminarPrest)
        Me.grbEdicion.Controls.Add(Me.btnModificarPrest)
        Me.grbEdicion.Controls.Add(Me.btnAgregarPrest)
        Me.grbEdicion.Location = New System.Drawing.Point(438, 641)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(523, 71)
        Me.grbEdicion.TabIndex = 56
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarPrest
        '
        Me.btnBuscarPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPrest.Location = New System.Drawing.Point(409, 17)
        Me.btnBuscarPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarPrest.Name = "btnBuscarPrest"
        Me.btnBuscarPrest.Size = New System.Drawing.Size(99, 48)
        Me.btnBuscarPrest.TabIndex = 8
        Me.btnBuscarPrest.Text = "Buscar"
        Me.btnBuscarPrest.UseVisualStyleBackColor = True
        '
        'btnEliminarPrest
        '
        Me.btnEliminarPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPrest.Location = New System.Drawing.Point(270, 17)
        Me.btnEliminarPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarPrest.Name = "btnEliminarPrest"
        Me.btnEliminarPrest.Size = New System.Drawing.Size(107, 48)
        Me.btnEliminarPrest.TabIndex = 7
        Me.btnEliminarPrest.Text = "Eliminar"
        Me.btnEliminarPrest.UseVisualStyleBackColor = True
        '
        'btnModificarPrest
        '
        Me.btnModificarPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPrest.Location = New System.Drawing.Point(129, 17)
        Me.btnModificarPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarPrest.Name = "btnModificarPrest"
        Me.btnModificarPrest.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarPrest.TabIndex = 6
        Me.btnModificarPrest.Text = "Modificar"
        Me.btnModificarPrest.UseVisualStyleBackColor = True
        '
        'btnAgregarPrest
        '
        Me.btnAgregarPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPrest.Location = New System.Drawing.Point(17, 17)
        Me.btnAgregarPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarPrest.Name = "btnAgregarPrest"
        Me.btnAgregarPrest.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarPrest.TabIndex = 5
        Me.btnAgregarPrest.Text = "Nuevo"
        Me.btnAgregarPrest.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosPrest)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoPrest)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientePrest)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorPrest)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroPrest)
        Me.grbNavegacion.Location = New System.Drawing.Point(19, 641)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(399, 71)
        Me.grbNavegacion.TabIndex = 55
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosPrest
        '
        Me.lblRegistrosPrest.AutoSize = True
        Me.lblRegistrosPrest.Location = New System.Drawing.Point(146, 36)
        Me.lblRegistrosPrest.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosPrest.Name = "lblRegistrosPrest"
        Me.lblRegistrosPrest.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosPrest.TabIndex = 4
        Me.lblRegistrosPrest.Text = "x de n"
        '
        'btnUltimoPrest
        '
        Me.btnUltimoPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoPrest.Location = New System.Drawing.Point(333, 17)
        Me.btnUltimoPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoPrest.Name = "btnUltimoPrest"
        Me.btnUltimoPrest.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimoPrest.TabIndex = 3
        Me.btnUltimoPrest.Text = ">|"
        Me.btnUltimoPrest.UseVisualStyleBackColor = True
        '
        'btnSiguientePrest
        '
        Me.btnSiguientePrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePrest.Location = New System.Drawing.Point(266, 17)
        Me.btnSiguientePrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguientePrest.Name = "btnSiguientePrest"
        Me.btnSiguientePrest.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguientePrest.TabIndex = 2
        Me.btnSiguientePrest.Text = ">"
        Me.btnSiguientePrest.UseVisualStyleBackColor = True
        '
        'btnAnteriorPrest
        '
        Me.btnAnteriorPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorPrest.Location = New System.Drawing.Point(80, 17)
        Me.btnAnteriorPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorPrest.Name = "btnAnteriorPrest"
        Me.btnAnteriorPrest.Size = New System.Drawing.Size(55, 48)
        Me.btnAnteriorPrest.TabIndex = 1
        Me.btnAnteriorPrest.Text = "<"
        Me.btnAnteriorPrest.UseVisualStyleBackColor = True
        '
        'btnPrimeroPrest
        '
        Me.btnPrimeroPrest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroPrest.Location = New System.Drawing.Point(14, 17)
        Me.btnPrimeroPrest.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroPrest.Name = "btnPrimeroPrest"
        Me.btnPrimeroPrest.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimeroPrest.TabIndex = 0
        Me.btnPrimeroPrest.Text = "|<"
        Me.btnPrimeroPrest.UseVisualStyleBackColor = True
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(108, 591)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(100, 25)
        Me.lblMonto.TabIndex = 57
        Me.lblMonto.Text = "MONTO:"
        '
        'lblRespuestaMontoPrest
        '
        Me.lblRespuestaMontoPrest.AutoSize = True
        Me.lblRespuestaMontoPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaMontoPrest.Location = New System.Drawing.Point(208, 591)
        Me.lblRespuestaMontoPrest.Name = "lblRespuestaMontoPrest"
        Me.lblRespuestaMontoPrest.Size = New System.Drawing.Size(61, 25)
        Me.lblRespuestaMontoPrest.TabIndex = 58
        Me.lblRespuestaMontoPrest.Text = "00.00"
        '
        'lblRespuestInteresPrest
        '
        Me.lblRespuestInteresPrest.AutoSize = True
        Me.lblRespuestInteresPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestInteresPrest.Location = New System.Drawing.Point(506, 591)
        Me.lblRespuestInteresPrest.Name = "lblRespuestInteresPrest"
        Me.lblRespuestInteresPrest.Size = New System.Drawing.Size(61, 25)
        Me.lblRespuestInteresPrest.TabIndex = 60
        Me.lblRespuestInteresPrest.Text = "00.00"
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteres.Location = New System.Drawing.Point(406, 591)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(111, 25)
        Me.lblInteres.TabIndex = 59
        Me.lblInteres.Text = "INTERES:"
        '
        'lblRespuestaTotalPrest
        '
        Me.lblRespuestaTotalPrest.AutoSize = True
        Me.lblRespuestaTotalPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaTotalPrest.Location = New System.Drawing.Point(803, 591)
        Me.lblRespuestaTotalPrest.Name = "lblRespuestaTotalPrest"
        Me.lblRespuestaTotalPrest.Size = New System.Drawing.Size(61, 25)
        Me.lblRespuestaTotalPrest.TabIndex = 62
        Me.lblRespuestaTotalPrest.Text = "00.00"
        '
        'lblTotalPrest
        '
        Me.lblTotalPrest.AutoSize = True
        Me.lblTotalPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrest.Location = New System.Drawing.Point(703, 591)
        Me.lblTotalPrest.Name = "lblTotalPrest"
        Me.lblTotalPrest.Size = New System.Drawing.Size(91, 25)
        Me.lblTotalPrest.TabIndex = 61
        Me.lblTotalPrest.Text = "TOTAL:"
        '
        'lblClientePrest
        '
        Me.lblClientePrest.AutoSize = True
        Me.lblClientePrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientePrest.Location = New System.Drawing.Point(30, 131)
        Me.lblClientePrest.Name = "lblClientePrest"
        Me.lblClientePrest.Size = New System.Drawing.Size(66, 20)
        Me.lblClientePrest.TabIndex = 63
        Me.lblClientePrest.Text = "Cliente:"
        '
        'txtCédulaPrest
        '
        Me.txtCédulaPrest.Location = New System.Drawing.Point(446, 129)
        Me.txtCédulaPrest.Name = "txtCédulaPrest"
        Me.txtCédulaPrest.Size = New System.Drawing.Size(121, 22)
        Me.txtCédulaPrest.TabIndex = 64
        '
        'lblPrest
        '
        Me.lblPrest.AutoSize = True
        Me.lblPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrest.Location = New System.Drawing.Point(893, 60)
        Me.lblPrest.Name = "lblPrest"
        Me.lblPrest.Size = New System.Drawing.Size(28, 20)
        Me.lblPrest.TabIndex = 65
        Me.lblPrest.Text = "N°"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(741, 28)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(133, 52)
        Me.btnAgregarCliente.TabIndex = 66
        Me.btnAgregarCliente.Text = "Nuevo Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'cboClientePrest
        '
        Me.cboClientePrest.FormattingEnabled = True
        Me.cboClientePrest.Location = New System.Drawing.Point(113, 127)
        Me.cboClientePrest.Name = "cboClientePrest"
        Me.cboClientePrest.Size = New System.Drawing.Size(121, 24)
        Me.cboClientePrest.TabIndex = 67
        '
        'lblCédulaPrest
        '
        Me.lblCédulaPrest.AutoSize = True
        Me.lblCédulaPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCédulaPrest.Location = New System.Drawing.Point(363, 129)
        Me.lblCédulaPrest.Name = "lblCédulaPrest"
        Me.lblCédulaPrest.Size = New System.Drawing.Size(66, 20)
        Me.lblCédulaPrest.TabIndex = 68
        Me.lblCédulaPrest.Text = "Cédula:"
        '
        'lblTeléfonoPrest
        '
        Me.lblTeléfonoPrest.AutoSize = True
        Me.lblTeléfonoPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeléfonoPrest.Location = New System.Drawing.Point(704, 131)
        Me.lblTeléfonoPrest.Name = "lblTeléfonoPrest"
        Me.lblTeléfonoPrest.Size = New System.Drawing.Size(78, 20)
        Me.lblTeléfonoPrest.TabIndex = 69
        Me.lblTeléfonoPrest.Text = "Teléfono:"
        '
        'txtTeléfonoPrest
        '
        Me.txtTeléfonoPrest.Location = New System.Drawing.Point(789, 127)
        Me.txtTeléfonoPrest.Name = "txtTeléfonoPrest"
        Me.txtTeléfonoPrest.Size = New System.Drawing.Size(121, 22)
        Me.txtTeléfonoPrest.TabIndex = 70
        '
        'lblCódigoClientePrest
        '
        Me.lblCódigoClientePrest.AutoSize = True
        Me.lblCódigoClientePrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCódigoClientePrest.Location = New System.Drawing.Point(28, 208)
        Me.lblCódigoClientePrest.Name = "lblCódigoClientePrest"
        Me.lblCódigoClientePrest.Size = New System.Drawing.Size(123, 20)
        Me.lblCódigoClientePrest.TabIndex = 71
        Me.lblCódigoClientePrest.Text = "Código Cliente:"
        '
        'txtCódigoClientePrest
        '
        Me.txtCódigoClientePrest.Location = New System.Drawing.Point(157, 206)
        Me.txtCódigoClientePrest.Name = "txtCódigoClientePrest"
        Me.txtCódigoClientePrest.Size = New System.Drawing.Size(121, 22)
        Me.txtCódigoClientePrest.TabIndex = 72
        '
        'lblFechaPrestamo
        '
        Me.lblFechaPrestamo.AutoSize = True
        Me.lblFechaPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPrestamo.Location = New System.Drawing.Point(310, 206)
        Me.lblFechaPrestamo.Name = "lblFechaPrestamo"
        Me.lblFechaPrestamo.Size = New System.Drawing.Size(137, 20)
        Me.lblFechaPrestamo.TabIndex = 73
        Me.lblFechaPrestamo.Text = "Fecha Prestamo:"
        '
        'dtpFechaPrestamo
        '
        Me.dtpFechaPrestamo.Location = New System.Drawing.Point(453, 204)
        Me.dtpFechaPrestamo.Name = "dtpFechaPrestamo"
        Me.dtpFechaPrestamo.Size = New System.Drawing.Size(254, 22)
        Me.dtpFechaPrestamo.TabIndex = 74
        '
        'lblOcupaciónPrest
        '
        Me.lblOcupaciónPrest.AutoSize = True
        Me.lblOcupaciónPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupaciónPrest.Location = New System.Drawing.Point(713, 212)
        Me.lblOcupaciónPrest.Name = "lblOcupaciónPrest"
        Me.lblOcupaciónPrest.Size = New System.Drawing.Size(94, 20)
        Me.lblOcupaciónPrest.TabIndex = 75
        Me.lblOcupaciónPrest.Text = "Ocupación:"
        '
        'cboOcupacionPrest
        '
        Me.cboOcupacionPrest.FormattingEnabled = True
        Me.cboOcupacionPrest.Location = New System.Drawing.Point(813, 208)
        Me.cboOcupacionPrest.Name = "cboOcupacionPrest"
        Me.cboOcupacionPrest.Size = New System.Drawing.Size(121, 24)
        Me.cboOcupacionPrest.TabIndex = 76
        '
        'lblMontoPrest
        '
        Me.lblMontoPrest.AutoSize = True
        Me.lblMontoPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoPrest.Location = New System.Drawing.Point(28, 276)
        Me.lblMontoPrest.Name = "lblMontoPrest"
        Me.lblMontoPrest.Size = New System.Drawing.Size(60, 20)
        Me.lblMontoPrest.TabIndex = 77
        Me.lblMontoPrest.Text = "Monto:"
        '
        'txtMontoPrest
        '
        Me.txtMontoPrest.Location = New System.Drawing.Point(108, 276)
        Me.txtMontoPrest.Name = "txtMontoPrest"
        Me.txtMontoPrest.Size = New System.Drawing.Size(100, 22)
        Me.txtMontoPrest.TabIndex = 78
        '
        'lblCuotasPrest
        '
        Me.lblCuotasPrest.AutoSize = True
        Me.lblCuotasPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuotasPrest.Location = New System.Drawing.Point(351, 276)
        Me.lblCuotasPrest.Name = "lblCuotasPrest"
        Me.lblCuotasPrest.Size = New System.Drawing.Size(67, 20)
        Me.lblCuotasPrest.TabIndex = 79
        Me.lblCuotasPrest.Text = "Cuotas:"
        '
        'txtCuotasPrest
        '
        Me.txtCuotasPrest.Location = New System.Drawing.Point(425, 276)
        Me.txtCuotasPrest.Name = "txtCuotasPrest"
        Me.txtCuotasPrest.Size = New System.Drawing.Size(121, 22)
        Me.txtCuotasPrest.TabIndex = 80
        '
        'lblInteresPrest
        '
        Me.lblInteresPrest.AutoSize = True
        Me.lblInteresPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteresPrest.Location = New System.Drawing.Point(667, 276)
        Me.lblInteresPrest.Name = "lblInteresPrest"
        Me.lblInteresPrest.Size = New System.Drawing.Size(65, 20)
        Me.lblInteresPrest.TabIndex = 81
        Me.lblInteresPrest.Text = "Interes:"
        '
        'cboInteresPrest
        '
        Me.cboInteresPrest.FormattingEnabled = True
        Me.cboInteresPrest.Location = New System.Drawing.Point(753, 272)
        Me.cboInteresPrest.Name = "cboInteresPrest"
        Me.cboInteresPrest.Size = New System.Drawing.Size(121, 24)
        Me.cboInteresPrest.TabIndex = 82
        '
        'lblTituloPrest
        '
        Me.lblTituloPrest.AutoSize = True
        Me.lblTituloPrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTituloPrest.Location = New System.Drawing.Point(204, 28)
        Me.lblTituloPrest.Name = "lblTituloPrest"
        Me.lblTituloPrest.Size = New System.Drawing.Size(461, 52)
        Me.lblTituloPrest.TabIndex = 83
        Me.lblTituloPrest.Text = "PRESTAMOS SIGAC"
        '
        'frmcreacionprestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(966, 711)
        Me.Controls.Add(Me.lblTituloPrest)
        Me.Controls.Add(Me.cboInteresPrest)
        Me.Controls.Add(Me.lblInteresPrest)
        Me.Controls.Add(Me.txtCuotasPrest)
        Me.Controls.Add(Me.lblCuotasPrest)
        Me.Controls.Add(Me.txtMontoPrest)
        Me.Controls.Add(Me.lblMontoPrest)
        Me.Controls.Add(Me.cboOcupacionPrest)
        Me.Controls.Add(Me.lblOcupaciónPrest)
        Me.Controls.Add(Me.dtpFechaPrestamo)
        Me.Controls.Add(Me.lblFechaPrestamo)
        Me.Controls.Add(Me.txtCódigoClientePrest)
        Me.Controls.Add(Me.lblCódigoClientePrest)
        Me.Controls.Add(Me.txtTeléfonoPrest)
        Me.Controls.Add(Me.lblTeléfonoPrest)
        Me.Controls.Add(Me.lblCédulaPrest)
        Me.Controls.Add(Me.cboClientePrest)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.lblPrest)
        Me.Controls.Add(Me.txtCédulaPrest)
        Me.Controls.Add(Me.lblClientePrest)
        Me.Controls.Add(Me.lblRespuestaTotalPrest)
        Me.Controls.Add(Me.lblTotalPrest)
        Me.Controls.Add(Me.lblRespuestInteresPrest)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.lblRespuestaMontoPrest)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grdRegistroPrest)
        Me.Name = "frmcreacionprestamo"
        Me.Text = "Crear Prestamos"
        CType(Me.grdRegistroPrest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdRegistroPrest As DataGridView
    Friend WithEvents idPrest As DataGridViewTextBoxColumn
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents idOcupacion As DataGridViewTextBoxColumn
    Friend WithEvents idInteres As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents codigocliente As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents ocupacion As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents cuotas As DataGridViewTextBoxColumn
    Friend WithEvents interes As DataGridViewTextBoxColumn
    Friend WithEvents fechaprestamo As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarPrest As Button
    Friend WithEvents btnEliminarPrest As Button
    Friend WithEvents btnModificarPrest As Button
    Friend WithEvents btnAgregarPrest As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosPrest As Label
    Friend WithEvents btnUltimoPrest As Button
    Friend WithEvents btnSiguientePrest As Button
    Friend WithEvents btnAnteriorPrest As Button
    Friend WithEvents btnPrimeroPrest As Button
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblRespuestaMontoPrest As Label
    Friend WithEvents lblRespuestInteresPrest As Label
    Friend WithEvents lblInteres As Label
    Friend WithEvents lblRespuestaTotalPrest As Label
    Friend WithEvents lblTotalPrest As Label
    Friend WithEvents lblClientePrest As Label
    Friend WithEvents txtCédulaPrest As TextBox
    Friend WithEvents lblPrest As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents cboClientePrest As ComboBox
    Friend WithEvents lblCédulaPrest As Label
    Friend WithEvents lblTeléfonoPrest As Label
    Friend WithEvents txtTeléfonoPrest As TextBox
    Friend WithEvents lblCódigoClientePrest As Label
    Friend WithEvents txtCódigoClientePrest As TextBox
    Friend WithEvents lblFechaPrestamo As Label
    Friend WithEvents dtpFechaPrestamo As DateTimePicker
    Friend WithEvents lblOcupaciónPrest As Label
    Friend WithEvents cboOcupacionPrest As ComboBox
    Friend WithEvents lblMontoPrest As Label
    Friend WithEvents txtMontoPrest As TextBox
    Friend WithEvents lblCuotasPrest As Label
    Friend WithEvents txtCuotasPrest As TextBox
    Friend WithEvents lblInteresPrest As Label
    Friend WithEvents cboInteresPrest As ComboBox
    Friend WithEvents lblTituloPrest As Label
End Class
