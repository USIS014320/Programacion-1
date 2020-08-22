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
        Me.SuspendLayout()
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(374, 48)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(97, 29)
        Me.lblvalor.TabIndex = 44
        Me.lblvalor.Text = "VALOR"
        '
        'lblMasa
        '
        Me.lblMasa.AutoSize = True
        Me.lblMasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasa.Location = New System.Drawing.Point(48, 237)
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
        Me.lbla2.Location = New System.Drawing.Point(615, 213)
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
        Me.lblde2.Location = New System.Drawing.Point(189, 209)
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
        Me.cboDe1.Location = New System.Drawing.Point(151, 241)
        Me.cboDe1.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDe1.Name = "cboDe1"
        Me.cboDe1.Size = New System.Drawing.Size(160, 24)
        Me.cboDe1.TabIndex = 40
        '
        'cboA1
        '
        Me.cboA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA1.FormattingEnabled = True
        Me.cboA1.Items.AddRange(New Object() {"Kilogramo", "Libra", "Onza", "Quintal", "Tonelada", "Arroba", "Gramo", "Miligramo", "Microgramo", "Quilate"})
        Me.cboA1.Location = New System.Drawing.Point(549, 241)
        Me.cboA1.Margin = New System.Windows.Forms.Padding(4)
        Me.cboA1.Name = "cboA1"
        Me.cboA1.Size = New System.Drawing.Size(160, 24)
        Me.cboA1.TabIndex = 39
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(352, 496)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(163, 45)
        Me.btnConvertir.TabIndex = 38
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(418, 395)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(28, 29)
        Me.lblIgual.TabIndex = 37
        Me.lblIgual.Text = "="
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(364, 428)
        Me.txtrespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(132, 22)
        Me.txtrespuesta.TabIndex = 36
        '
        'txtEntradab
        '
        Me.txtEntradab.Location = New System.Drawing.Point(361, 81)
        Me.txtEntradab.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntradab.Name = "txtEntradab"
        Me.txtEntradab.Size = New System.Drawing.Size(132, 22)
        Me.txtEntradab.TabIndex = 35
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(48, 145)
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
        Me.lbla1.Location = New System.Drawing.Point(625, 121)
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
        Me.lblde1.Location = New System.Drawing.Point(199, 117)
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
        Me.cboDe.Location = New System.Drawing.Point(151, 149)
        Me.cboDe.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDe.Name = "cboDe"
        Me.cboDe.Size = New System.Drawing.Size(160, 24)
        Me.cboDe.TabIndex = 31
        '
        'cboA
        '
        Me.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA.FormattingEnabled = True
        Me.cboA.Items.AddRange(New Object() {"Segundo", "Minuto", "Hora", "Día", "Semana", "Quincena", "Mes", "Década", "Semestre", "Año"})
        Me.cboA.Location = New System.Drawing.Point(549, 149)
        Me.cboA.Margin = New System.Windows.Forms.Padding(4)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(160, 24)
        Me.cboA.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(786, 593)
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
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora"
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
End Class
