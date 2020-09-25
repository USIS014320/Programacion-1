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
        Me.optMod = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'optMod
        '
        Me.optMod.AutoSize = True
        Me.optMod.Location = New System.Drawing.Point(216, 216)
        Me.optMod.Margin = New System.Windows.Forms.Padding(4)
        Me.optMod.Name = "optMod"
        Me.optMod.Size = New System.Drawing.Size(61, 21)
        Me.optMod.TabIndex = 24
        Me.optMod.Text = "MOD"
        Me.optMod.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(217, 279)
        Me.optExponenciacion.Margin = New System.Windows.Forms.Padding(4)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(36, 21)
        Me.optExponenciacion.TabIndex = 23
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(216, 250)
        Me.optPorcentaje.Margin = New System.Windows.Forms.Padding(4)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(97, 21)
        Me.optPorcentaje.TabIndex = 22
        Me.optPorcentaje.Text = "Porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(216, 187)
        Me.optDividir.Margin = New System.Windows.Forms.Padding(4)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(33, 21)
        Me.optDividir.TabIndex = 21
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(216, 159)
        Me.optMultiplicar.Margin = New System.Windows.Forms.Padding(4)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(34, 21)
        Me.optMultiplicar.TabIndex = 20
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(216, 130)
        Me.optResta.Margin = New System.Windows.Forms.Padding(4)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(34, 21)
        Me.optResta.TabIndex = 19
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Location = New System.Drawing.Point(216, 102)
        Me.optSuma.Margin = New System.Windows.Forms.Padding(4)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(37, 21)
        Me.optSuma.TabIndex = 18
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(197, 342)
        Me.txtnum2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(73, 22)
        Me.txtnum2.TabIndex = 17
        Me.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(214, 321)
        Me.lblnum2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(53, 17)
        Me.lblnum2.TabIndex = 16
        Me.lblnum2.Text = "Num 2:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(173, 420)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(125, 62)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(200, 61)
        Me.txtnum1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(73, 22)
        Me.txtnum1.TabIndex = 14
        Me.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(214, 40)
        Me.lblnum1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(53, 17)
        Me.lblnum1.TabIndex = 13
        Me.lblnum1.Text = "Num 1:"
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(173, 390)
        Me.txtRespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(125, 22)
        Me.txtRespuesta.TabIndex = 25
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"Seleccione una opcion", "Suma", "Resta", "Multiplicacion", "Division", "MOD", "Porcentaje", "Exponenciacion"})
        Me.cboOperaciones.Location = New System.Drawing.Point(422, 234)
        Me.cboOperaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(160, 24)
        Me.cboOperaciones.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(684, 507)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.optMod)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "CALCULADORA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optMod As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblnum2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents lblnum1 As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents cboOperaciones As ComboBox
End Class
