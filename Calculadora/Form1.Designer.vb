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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblInteresCompuesto = New System.Windows.Forms.Label()
        Me.lblInteresSimple = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(189, 454)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(215, 69)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(261, 63)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(64, 17)
        Me.lblCapital.TabIndex = 1
        Me.lblCapital.Text = "CAPITAL"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(243, 83)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 22)
        Me.txtCapital.TabIndex = 2
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(243, 153)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(100, 22)
        Me.txtInteres.TabIndex = 4
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(258, 133)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(67, 17)
        Me.lblInteres.TabIndex = 3
        Me.lblInteres.Text = "INTERES"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(221, 226)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(143, 22)
        Me.txtTiempo.TabIndex = 6
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(240, 206)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(113, 17)
        Me.lblTiempo.TabIndex = 5
        Me.lblTiempo.Text = "TIEMPO (AÑOS)"
        '
        'lblInteresCompuesto
        '
        Me.lblInteresCompuesto.AutoSize = True
        Me.lblInteresCompuesto.Location = New System.Drawing.Point(214, 360)
        Me.lblInteresCompuesto.Name = "lblInteresCompuesto"
        Me.lblInteresCompuesto.Size = New System.Drawing.Size(159, 17)
        Me.lblInteresCompuesto.TabIndex = 7
        Me.lblInteresCompuesto.Text = "INTERES COMPUESTO"
        Me.lblInteresCompuesto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInteresSimple
        '
        Me.lblInteresSimple.AutoSize = True
        Me.lblInteresSimple.Location = New System.Drawing.Point(232, 314)
        Me.lblInteresSimple.Name = "lblInteresSimple"
        Me.lblInteresSimple.Size = New System.Drawing.Size(120, 17)
        Me.lblInteresSimple.TabIndex = 8
        Me.lblInteresSimple.Text = "INTERES SIMPLE"
        Me.lblInteresSimple.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(590, 589)
        Me.Controls.Add(Me.lblInteresSimple)
        Me.Controls.Add(Me.lblInteresCompuesto)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.btnCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "EJERCICIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents lblInteres As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblInteresCompuesto As Label
    Friend WithEvents lblInteresSimple As Label
End Class
