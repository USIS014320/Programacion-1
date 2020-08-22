<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.lblMasa = New System.Windows.Forms.Label()
        Me.lbla2 = New System.Windows.Forms.Label()
        Me.lblde2 = New System.Windows.Forms.Label()
        Me.cboDe1 = New System.Windows.Forms.ComboBox()
        Me.cboA1 = New System.Windows.Forms.ComboBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.txtEntradab = New System.Windows.Forms.TextBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lbla1 = New System.Windows.Forms.Label()
        Me.lblde1 = New System.Windows.Forms.Label()
        Me.cboDe = New System.Windows.Forms.ComboBox()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.lblmonedas = New System.Windows.Forms.Label()
        Me.lbla3 = New System.Windows.Forms.Label()
        Me.lblde3 = New System.Windows.Forms.Label()
        Me.cboDe2 = New System.Windows.Forms.ComboBox()
        Me.cboA2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblalmacenamiento = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboalmacenamientoentrada = New System.Windows.Forms.ComboBox()
        Me.cboalmacenamientosalida = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(580, 18)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(97, 29)
        Me.lblvalor.TabIndex = 44
        Me.lblvalor.Text = "VALOR"
        '
        'lblMasa
        '
        Me.lblMasa.AutoSize = True
        Me.lblMasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasa.Location = New System.Drawing.Point(186, 261)
        Me.lblMasa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasa.Name = "lblMasa"
        Me.lblMasa.Size = New System.Drawing.Size(75, 25)
        Me.lblMasa.TabIndex = 43
        Me.lblMasa.Text = "MASA"
        '
        'lbla2
        '
        Me.lbla2.AutoSize = True
        Me.lbla2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla2.Location = New System.Drawing.Point(864, 232)
        Me.lbla2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbla2.Name = "lbla2"
        Me.lbla2.Size = New System.Drawing.Size(30, 24)
        Me.lbla2.TabIndex = 42
        Me.lbla2.Text = "A:"
        '
        'lblde2
        '
        Me.lblde2.AutoSize = True
        Me.lblde2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblde2.Location = New System.Drawing.Point(341, 229)
        Me.lblde2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblde2.Name = "lblde2"
        Me.lblde2.Size = New System.Drawing.Size(48, 28)
        Me.lblde2.TabIndex = 41
        Me.lblde2.Text = "De:"
        '
        'cboDe1
        '
        Me.cboDe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe1.FormattingEnabled = True
        Me.cboDe1.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboDe1.Location = New System.Drawing.Point(293, 261)
        Me.cboDe1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDe1.Name = "cboDe1"
        Me.cboDe1.Size = New System.Drawing.Size(160, 24)
        Me.cboDe1.TabIndex = 40
        '
        'cboA1
        '
        Me.cboA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA1.FormattingEnabled = True
        Me.cboA1.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboA1.Location = New System.Drawing.Point(799, 262)
        Me.cboA1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboA1.Name = "cboA1"
        Me.cboA1.Size = New System.Drawing.Size(160, 24)
        Me.cboA1.TabIndex = 39
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(544, 527)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(176, 46)
        Me.btnConvertir.TabIndex = 38
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(614, 466)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(28, 29)
        Me.lblIgual.TabIndex = 37
        Me.lblIgual.Text = "="
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(564, 499)
        Me.txtrespuesta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(132, 22)
        Me.txtrespuesta.TabIndex = 36
        '
        'txtEntradab
        '
        Me.txtEntradab.Location = New System.Drawing.Point(564, 62)
        Me.txtEntradab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEntradab.Name = "txtEntradab"
        Me.txtEntradab.Size = New System.Drawing.Size(132, 22)
        Me.txtEntradab.TabIndex = 35
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(166, 167)
        Me.lblTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(95, 25)
        Me.lblTiempo.TabIndex = 34
        Me.lblTiempo.Text = "TIEMPO"
        '
        'lbla1
        '
        Me.lbla1.AutoSize = True
        Me.lbla1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla1.Location = New System.Drawing.Point(864, 141)
        Me.lbla1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbla1.Name = "lbla1"
        Me.lbla1.Size = New System.Drawing.Size(30, 24)
        Me.lbla1.TabIndex = 33
        Me.lbla1.Text = "A:"
        '
        'lblde1
        '
        Me.lblde1.AutoSize = True
        Me.lblde1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblde1.Location = New System.Drawing.Point(341, 137)
        Me.lblde1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblde1.Name = "lblde1"
        Me.lblde1.Size = New System.Drawing.Size(48, 28)
        Me.lblde1.TabIndex = 32
        Me.lblde1.Text = "De:"
        '
        'cboDe
        '
        Me.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe.FormattingEnabled = True
        Me.cboDe.Items.AddRange(New Object() {"Segundo", "Minuto", "Hora", "Día", "Semana", "Quincena", "Mes", "Década", "Semestre", "Año"})
        Me.cboDe.Location = New System.Drawing.Point(293, 168)
        Me.cboDe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDe.Name = "cboDe"
        Me.cboDe.Size = New System.Drawing.Size(160, 24)
        Me.cboDe.TabIndex = 31
        '
        'cboA
        '
        Me.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA.FormattingEnabled = True
        Me.cboA.Items.AddRange(New Object() {"Segundo", "Minuto", "Hora", "Día", "Semana", "Quincena", "Mes", "Década", "Semestre", "Año"})
        Me.cboA.Location = New System.Drawing.Point(799, 167)
        Me.cboA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(160, 24)
        Me.cboA.TabIndex = 30
        '
        'lblmonedas
        '
        Me.lblmonedas.AutoSize = True
        Me.lblmonedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonedas.Location = New System.Drawing.Point(140, 347)
        Me.lblmonedas.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblmonedas.Name = "lblmonedas"
        Me.lblmonedas.Size = New System.Drawing.Size(121, 25)
        Me.lblmonedas.TabIndex = 49
        Me.lblmonedas.Text = "MONEDAS"
        '
        'lbla3
        '
        Me.lbla3.AutoSize = True
        Me.lbla3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla3.Location = New System.Drawing.Point(864, 317)
        Me.lbla3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbla3.Name = "lbla3"
        Me.lbla3.Size = New System.Drawing.Size(30, 24)
        Me.lbla3.TabIndex = 48
        Me.lbla3.Text = "A:"
        '
        'lblde3
        '
        Me.lblde3.AutoSize = True
        Me.lblde3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblde3.Location = New System.Drawing.Point(341, 313)
        Me.lblde3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblde3.Name = "lblde3"
        Me.lblde3.Size = New System.Drawing.Size(48, 28)
        Me.lblde3.TabIndex = 47
        Me.lblde3.Text = "De:"
        '
        'cboDe2
        '
        Me.cboDe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe2.FormattingEnabled = True
        Me.cboDe2.Items.AddRange(New Object() {"Dolar Estado Unidense", "Euro", "Yen Japones", "Rublo Ruso", "Peso Mexicano", "Won SunCoreano", "Dírham Emiratos Arabes Unidos", "Rupia India", "Sol Peruano", "Renminbi"})
        Me.cboDe2.Location = New System.Drawing.Point(293, 345)
        Me.cboDe2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cboDe2.Name = "cboDe2"
        Me.cboDe2.Size = New System.Drawing.Size(160, 24)
        Me.cboDe2.TabIndex = 46
        '
        'cboA2
        '
        Me.cboA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA2.FormattingEnabled = True
        Me.cboA2.Items.AddRange(New Object() {"Dolar Estado Unidense", "Euro", "Yen Japones", "Rublo Ruso", "Peso Mexicano", "Won SunCoreano", "Dírham Emiratos Arabes Unidos", "Rupia India", "Sol Peruano", "Renminbi"})
        Me.cboA2.Location = New System.Drawing.Point(799, 349)
        Me.cboA2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cboA2.Name = "cboA2"
        Me.cboA2.Size = New System.Drawing.Size(160, 24)
        Me.cboA2.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(864, 401)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "A:"
        '
        'cbo2
        '
        Me.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo2.Location = New System.Drawing.Point(799, 433)
        Me.cbo2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(160, 24)
        Me.cbo2.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 401)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 28)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "De:"
        '
        'cbo1
        '
        Me.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"Centimetro", "Metro", "Kilometro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Micrómetro", "Milla náutica"})
        Me.cbo1.Location = New System.Drawing.Point(293, 433)
        Me.cbo1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(160, 24)
        Me.cbo1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 429)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "LONGITUD"
        '
        'lblalmacenamiento
        '
        Me.lblalmacenamiento.AutoSize = True
        Me.lblalmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalmacenamiento.Location = New System.Drawing.Point(46, 90)
        Me.lblalmacenamiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblalmacenamiento.Name = "lblalmacenamiento"
        Me.lblalmacenamiento.Size = New System.Drawing.Size(216, 25)
        Me.lblalmacenamiento.TabIndex = 59
        Me.lblalmacenamiento.Text = "ALMACENAMIENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(864, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 24)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "A:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 28)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "De:"
        '
        'cboalmacenamientoentrada
        '
        Me.cboalmacenamientoentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientoentrada.FormattingEnabled = True
        Me.cboalmacenamientoentrada.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientoentrada.Location = New System.Drawing.Point(293, 92)
        Me.cboalmacenamientoentrada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboalmacenamientoentrada.Name = "cboalmacenamientoentrada"
        Me.cboalmacenamientoentrada.Size = New System.Drawing.Size(160, 24)
        Me.cboalmacenamientoentrada.TabIndex = 56
        '
        'cboalmacenamientosalida
        '
        Me.cboalmacenamientosalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacenamientosalida.FormattingEnabled = True
        Me.cboalmacenamientosalida.Items.AddRange(New Object() {"Bit", "Byte", "Kilobyte", "Kibibyte", "Megabyte", "Mebibyte", "Gigabyte", "Gibibyte", "Terabyte", "Petabyte"})
        Me.cboalmacenamientosalida.Location = New System.Drawing.Point(799, 91)
        Me.cboalmacenamientosalida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboalmacenamientosalida.Name = "cboalmacenamientosalida"
        Me.cboalmacenamientosalida.Size = New System.Drawing.Size(160, 24)
        Me.cboalmacenamientosalida.TabIndex = 55
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1136, 593)
        Me.Controls.Add(Me.lblalmacenamiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboalmacenamientoentrada)
        Me.Controls.Add(Me.cboalmacenamientosalida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo2)
        Me.Controls.Add(Me.lblmonedas)
        Me.Controls.Add(Me.lbla3)
        Me.Controls.Add(Me.lblde3)
        Me.Controls.Add(Me.cboDe2)
        Me.Controls.Add(Me.cboA2)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.lblMasa)
        Me.Controls.Add(Me.lbla2)
        Me.Controls.Add(Me.lblde2)
        Me.Controls.Add(Me.cboDe1)
        Me.Controls.Add(Me.cboA1)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblIgual)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.txtEntradab)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lbla1)
        Me.Controls.Add(Me.lblde1)
        Me.Controls.Add(Me.cboDe)
        Me.Controls.Add(Me.cboA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sistemas de Conversión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblvalor As Label
    Friend WithEvents lblMasa As Label
    Friend WithEvents lbla2 As Label
    Friend WithEvents lblde2 As Label
    Friend WithEvents cboDe1 As ComboBox
    Friend WithEvents cboA1 As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblIgual As Label
    Friend WithEvents txtrespuesta As TextBox
    Friend WithEvents txtEntradab As TextBox
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lbla1 As Label
    Friend WithEvents lblde1 As Label
    Friend WithEvents cboDe As ComboBox
    Friend WithEvents cboA As ComboBox
    Friend WithEvents lblmonedas As Label
    Friend WithEvents lbla3 As Label
    Friend WithEvents lblde3 As Label
    Friend WithEvents cboDe2 As ComboBox
    Friend WithEvents cboA2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblalmacenamiento As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboalmacenamientoentrada As ComboBox
    Friend WithEvents cboalmacenamientosalida As ComboBox
End Class
