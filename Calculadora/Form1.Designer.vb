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
        Me.lbligual = New System.Windows.Forms.Label()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.optExponenciacion = New System.Windows.Forms.CheckBox()
        Me.optPorcentaje = New System.Windows.Forms.CheckBox()
        Me.optMod = New System.Windows.Forms.CheckBox()
        Me.optResta = New System.Windows.Forms.CheckBox()
        Me.optMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.optDivision = New System.Windows.Forms.CheckBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.optSuma = New System.Windows.Forms.CheckBox()
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbligual
        '
        Me.lbligual.AutoSize = True
        Me.lbligual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbligual.Location = New System.Drawing.Point(383, 326)
        Me.lbligual.Name = "lbligual"
        Me.lbligual.Size = New System.Drawing.Size(25, 25)
        Me.lbligual.TabIndex = 42
        Me.lbligual.Text = "="
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(341, 354)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(118, 22)
        Me.txtrespuesta.TabIndex = 41
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(341, 382)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(118, 39)
        Me.btncalcular.TabIndex = 40
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(378, 250)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(37, 21)
        Me.optExponenciacion.TabIndex = 39
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(378, 223)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(42, 21)
        Me.optPorcentaje.TabIndex = 38
        Me.optPorcentaje.Text = "%"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optMod
        '
        Me.optMod.AutoSize = True
        Me.optMod.Location = New System.Drawing.Point(378, 196)
        Me.optMod.Name = "optMod"
        Me.optMod.Size = New System.Drawing.Size(57, 21)
        Me.optMod.TabIndex = 37
        Me.optMod.Text = "Mod"
        Me.optMod.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(378, 115)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(35, 21)
        Me.optResta.TabIndex = 36
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicacion
        '
        Me.optMultiplicacion.AutoSize = True
        Me.optMultiplicacion.Location = New System.Drawing.Point(378, 142)
        Me.optMultiplicacion.Name = "optMultiplicacion"
        Me.optMultiplicacion.Size = New System.Drawing.Size(35, 21)
        Me.optMultiplicacion.TabIndex = 35
        Me.optMultiplicacion.Text = "*"
        Me.optMultiplicacion.UseVisualStyleBackColor = True
        '
        'optDivision
        '
        Me.optDivision.AutoSize = True
        Me.optDivision.Location = New System.Drawing.Point(378, 169)
        Me.optDivision.Name = "optDivision"
        Me.optDivision.Size = New System.Drawing.Size(34, 21)
        Me.optDivision.TabIndex = 34
        Me.optDivision.Text = "/"
        Me.optDivision.UseVisualStyleBackColor = True
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(341, 299)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(108, 22)
        Me.txtnum2.TabIndex = 33
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(341, 50)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(108, 22)
        Me.txtnum1.TabIndex = 32
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(371, 279)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(45, 17)
        Me.lblnum2.TabIndex = 31
        Me.lblnum2.Text = "Num2"
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(375, 30)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(45, 17)
        Me.lblnum1.TabIndex = 30
        Me.lblnum1.Text = "Num1"
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Location = New System.Drawing.Point(378, 88)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(38, 21)
        Me.optSuma.TabIndex = 29
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division", "Mod", "Porcentaje", "Exponenciacion"})
        Me.cboOperaciones.Location = New System.Drawing.Point(615, 154)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(121, 24)
        Me.cboOperaciones.TabIndex = 43
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.lbligual)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optMod)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optMultiplicacion)
        Me.Controls.Add(Me.optDivision)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Controls.Add(Me.optSuma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbligual As Label
    Friend WithEvents txtrespuesta As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents optExponenciacion As CheckBox
    Friend WithEvents optPorcentaje As CheckBox
    Friend WithEvents optMod As CheckBox
    Friend WithEvents optResta As CheckBox
    Friend WithEvents optMultiplicacion As CheckBox
    Friend WithEvents optDivision As CheckBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents lblnum2 As Label
    Friend WithEvents lblnum1 As Label
    Friend WithEvents optSuma As CheckBox
    Friend WithEvents cboOperaciones As ComboBox
End Class
