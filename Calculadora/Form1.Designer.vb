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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txttabla = New System.Windows.Forms.TextBox()
        Me.lbltabla = New System.Windows.Forms.Label()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbligual
        '
        Me.lbligual.AutoSize = True
        Me.lbligual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbligual.Location = New System.Drawing.Point(362, 121)
        Me.lbligual.Name = "lbligual"
        Me.lbligual.Size = New System.Drawing.Size(25, 25)
        Me.lbligual.TabIndex = 42
        Me.lbligual.Text = "="
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(300, 375)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(154, 63)
        Me.btnGenerar.TabIndex = 40
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txttabla
        '
        Me.txttabla.Location = New System.Drawing.Point(300, 96)
        Me.txttabla.Name = "txttabla"
        Me.txttabla.Size = New System.Drawing.Size(137, 22)
        Me.txttabla.TabIndex = 32
        '
        'lbltabla
        '
        Me.lbltabla.AutoSize = True
        Me.lbltabla.Location = New System.Drawing.Point(349, 76)
        Me.lbltabla.Name = "lbltabla"
        Me.lbltabla.Size = New System.Drawing.Size(51, 17)
        Me.lbltabla.TabIndex = 30
        Me.lbltabla.Text = "Tablas"
        '
        'lstTablas
        '
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.ItemHeight = 16
        Me.lstTablas.Location = New System.Drawing.Point(300, 149)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(154, 196)
        Me.lstTablas.TabIndex = 43
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.lbligual)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txttabla)
        Me.Controls.Add(Me.lbltabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbligual As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txttabla As TextBox
    Friend WithEvents lbltabla As Label
    Friend WithEvents lstTablas As ListBox
End Class
