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
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.lblres = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.cboDe = New System.Windows.Forms.ComboBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(205, 340)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(201, 54)
        Me.btnConvertir.TabIndex = 0
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(271, 31)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(55, 17)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "VALOR"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(253, 51)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 2
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(205, 286)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(201, 22)
        Me.txtRespuesta.TabIndex = 4
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Location = New System.Drawing.Point(262, 266)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(91, 17)
        Me.lblres.TabIndex = 5
        Me.lblres.Text = "RESPUESTA"
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.White
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Moneda", "Longitud", "Masa", "Almacenamiento", "Tiempo"})
        Me.cboTipo.Location = New System.Drawing.Point(410, 51)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 24)
        Me.cboTipo.TabIndex = 6
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(449, 31)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(40, 17)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Text = "TIPO"
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(102, 129)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(27, 17)
        Me.lblDe.TabIndex = 9
        Me.lblDe.Text = "DE"
        '
        'cboDe
        '
        Me.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe.FormattingEnabled = True
        Me.cboDe.Location = New System.Drawing.Point(56, 149)
        Me.cboDe.Name = "cboDe"
        Me.cboDe.Size = New System.Drawing.Size(121, 24)
        Me.cboDe.TabIndex = 8
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(449, 129)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 17)
        Me.lblA.TabIndex = 11
        Me.lblA.Text = "A"
        '
        'cboA
        '
        Me.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA.FormattingEnabled = True
        Me.cboA.Location = New System.Drawing.Point(391, 149)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(121, 24)
        Me.cboA.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(590, 454)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.cboA)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.cboDe)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.lblres)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.btnConvertir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "CONVERSORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblValor As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents lblres As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblDe As Label
    Friend WithEvents cboDe As ComboBox
    Friend WithEvents lblA As Label
    Friend WithEvents cboA As ComboBox
End Class
