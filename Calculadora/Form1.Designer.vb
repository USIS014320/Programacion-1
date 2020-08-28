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
        Me.lblNúmero = New System.Windows.Forms.Label()
        Me.txtNúmero = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.lblres = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(190, 322)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(215, 69)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblNúmero
        '
        Me.lblNúmero.AutoSize = True
        Me.lblNúmero.Location = New System.Drawing.Point(261, 63)
        Me.lblNúmero.Name = "lblNúmero"
        Me.lblNúmero.Size = New System.Drawing.Size(69, 17)
        Me.lblNúmero.TabIndex = 1
        Me.lblNúmero.Text = "NUMERO"
        '
        'txtNúmero
        '
        Me.txtNúmero.Location = New System.Drawing.Point(243, 83)
        Me.txtNúmero.Name = "txtNúmero"
        Me.txtNúmero.Size = New System.Drawing.Size(100, 22)
        Me.txtNúmero.TabIndex = 2
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(204, 194)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(201, 22)
        Me.txtRespuesta.TabIndex = 4
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Location = New System.Drawing.Point(261, 174)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(91, 17)
        Me.lblres.TabIndex = 5
        Me.lblres.Text = "RESPUESTA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(590, 454)
        Me.Controls.Add(Me.lblres)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtNúmero)
        Me.Controls.Add(Me.lblNúmero)
        Me.Controls.Add(Me.btnCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "DECIMALES A ROMANOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblNúmero As Label
    Friend WithEvents txtNúmero As TextBox
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents lblres As Label
End Class
