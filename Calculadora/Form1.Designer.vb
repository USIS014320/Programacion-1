<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPRESAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResgistrosDePrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosDeudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosExsitentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosFaltantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EMPRESAToolStripMenuItem, Me.INVENTARIOToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1015, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ArchivoToolStripMenuItem.Image = CType(resources.GetObject("ArchivoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EMPRESAToolStripMenuItem
        '
        Me.EMPRESAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.RegistroDeCargosToolStripMenuItem, Me.ToolStripMenuItem3, Me.ResgistrosDePrestamosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.CrearPrestamoToolStripMenuItem})
        Me.EMPRESAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.EMPRESAToolStripMenuItem.Image = CType(resources.GetObject("EMPRESAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EMPRESAToolStripMenuItem.Name = "EMPRESAToolStripMenuItem"
        Me.EMPRESAToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.EMPRESAToolStripMenuItem.Text = "EMPRESA"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.EmpleadosToolStripMenuItem.Image = CType(resources.GetObject("EmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProveedoresToolStripMenuItem.Image = CType(resources.GetObject("ProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'RegistroDeCargosToolStripMenuItem
        '
        Me.RegistroDeCargosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RegistroDeCargosToolStripMenuItem.Image = CType(resources.GetObject("RegistroDeCargosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistroDeCargosToolStripMenuItem.Name = "RegistroDeCargosToolStripMenuItem"
        Me.RegistroDeCargosToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.RegistroDeCargosToolStripMenuItem.Text = "Registro de Cargos"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(252, 26)
        Me.ToolStripMenuItem3.Text = "Salarios"
        '
        'ResgistrosDePrestamosToolStripMenuItem
        '
        Me.ResgistrosDePrestamosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ResgistrosDePrestamosToolStripMenuItem.Image = CType(resources.GetObject("ResgistrosDePrestamosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResgistrosDePrestamosToolStripMenuItem.Name = "ResgistrosDePrestamosToolStripMenuItem"
        Me.ResgistrosDePrestamosToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.ResgistrosDePrestamosToolStripMenuItem.Text = "Resgistros de Prestamos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CrearPrestamoToolStripMenuItem
        '
        Me.CrearPrestamoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CrearPrestamoToolStripMenuItem.Image = CType(resources.GetObject("CrearPrestamoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CrearPrestamoToolStripMenuItem.Name = "CrearPrestamoToolStripMenuItem"
        Me.CrearPrestamoToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.CrearPrestamoToolStripMenuItem.Text = "Crear Prestamo"
        '
        'INVENTARIOToolStripMenuItem
        '
        Me.INVENTARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ProductosDeudaToolStripMenuItem, Me.InventarioToolStripMenuItem1, Me.ComprasToolStripMenuItem})
        Me.INVENTARIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.INVENTARIOToolStripMenuItem.Image = CType(resources.GetObject("INVENTARIOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.INVENTARIOToolStripMenuItem.Name = "INVENTARIOToolStripMenuItem"
        Me.INVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.INVENTARIOToolStripMenuItem.Text = "INVENTARIO"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProductosDeudaToolStripMenuItem
        '
        Me.ProductosDeudaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductosDeudaToolStripMenuItem.Image = CType(resources.GetObject("ProductosDeudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosDeudaToolStripMenuItem.Name = "ProductosDeudaToolStripMenuItem"
        Me.ProductosDeudaToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ProductosDeudaToolStripMenuItem.Text = "ProductosDeuda"
        '
        'InventarioToolStripMenuItem1
        '
        Me.InventarioToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.InventarioToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosExsitentesToolStripMenuItem, Me.ProductosFaltantesToolStripMenuItem})
        Me.InventarioToolStripMenuItem1.Image = CType(resources.GetObject("InventarioToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.InventarioToolStripMenuItem1.Name = "InventarioToolStripMenuItem1"
        Me.InventarioToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.InventarioToolStripMenuItem1.Text = "Inventario"
        '
        'ProductosExsitentesToolStripMenuItem
        '
        Me.ProductosExsitentesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductosExsitentesToolStripMenuItem.Image = CType(resources.GetObject("ProductosExsitentesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosExsitentesToolStripMenuItem.Name = "ProductosExsitentesToolStripMenuItem"
        Me.ProductosExsitentesToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ProductosExsitentesToolStripMenuItem.Text = "Productos exsitentes"
        '
        'ProductosFaltantesToolStripMenuItem
        '
        Me.ProductosFaltantesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductosFaltantesToolStripMenuItem.Image = CType(resources.GetObject("ProductosFaltantesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosFaltantesToolStripMenuItem.Name = "ProductosFaltantesToolStripMenuItem"
        Me.ProductosFaltantesToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ProductosFaltantesToolStripMenuItem.Text = "Productos faltantes"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ComprasToolStripMenuItem.Image = CType(resources.GetObject("ComprasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ComprasToolStripMenuItem.Text = "Compras de productos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.DeudasToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(89, 24)
        Me.ToolStripMenuItem1.Text = "PAGOS"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem2.Text = "Pagos varios"
        '
        'DeudasToolStripMenuItem
        '
        Me.DeudasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DeudasToolStripMenuItem.Image = CType(resources.GetObject("DeudasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeudasToolStripMenuItem.Name = "DeudasToolStripMenuItem"
        Me.DeudasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DeudasToolStripMenuItem.Text = "Deudas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Calculadora.My.Resources.Resources.unnamed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1015, 630)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Sistema Informático SIGAC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMPRESAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RegistroDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosDeudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosExsitentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosFaltantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResgistrosDePrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeudasToolStripMenuItem As ToolStripMenuItem
End Class
