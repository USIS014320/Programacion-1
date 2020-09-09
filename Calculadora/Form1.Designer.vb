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
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.cboDep = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.cboCantón = New System.Windows.Forms.ComboBox()
        Me.lblCantón = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Location = New System.Drawing.Point(77, 92)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(123, 17)
        Me.lblDepto.TabIndex = 1
        Me.lblDepto.Text = "DEPARTAMENTO"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(394, 92)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(77, 17)
        Me.lblMunicipio.TabIndex = 5
        Me.lblMunicipio.Text = "MUNICIPIO"
        '
        'cboDep
        '
        Me.cboDep.FormattingEnabled = True
        Me.cboDep.Location = New System.Drawing.Point(55, 112)
        Me.cboDep.Name = "cboDep"
        Me.cboDep.Size = New System.Drawing.Size(173, 24)
        Me.cboDep.TabIndex = 6
        '
        'cboMun
        '
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(342, 112)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(173, 24)
        Me.cboMun.TabIndex = 7
        '
        'cboCantón
        '
        Me.cboCantón.FormattingEnabled = True
        Me.cboCantón.Location = New System.Drawing.Point(602, 112)
        Me.cboCantón.Name = "cboCantón"
        Me.cboCantón.Size = New System.Drawing.Size(173, 24)
        Me.cboCantón.TabIndex = 9
        '
        'lblCantón
        '
        Me.lblCantón.AutoSize = True
        Me.lblCantón.Location = New System.Drawing.Point(654, 92)
        Me.lblCantón.Name = "lblCantón"
        Me.lblCantón.Size = New System.Drawing.Size(66, 17)
        Me.lblCantón.TabIndex = 8
        Me.lblCantón.Text = "CANTON"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(820, 253)
        Me.Controls.Add(Me.cboCantón)
        Me.Controls.Add(Me.lblCantón)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.cboDep)
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.lblDepto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "COMBO DINAMICO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDepto As Label
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents cboDep As ComboBox
    Friend WithEvents cboMun As ComboBox
    Friend WithEvents cboCantón As ComboBox
    Friend WithEvents lblCantón As Label
End Class
