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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDe = New System.Windows.Forms.ComboBox()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.txtEntradab = New System.Windows.Forms.TextBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tcConver = New System.Windows.Forms.TabPage()
        Me.tcArea = New System.Windows.Forms.TabPage()
        Me.txtRespuestaU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btbConvertirU = New System.Windows.Forms.Button()
        Me.txtNúmero = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tcConver.SuspendLayout()
        Me.tcArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 28)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "De:"
        '
        'cboDe
        '
        Me.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDe.FormattingEnabled = True
        Me.cboDe.Items.AddRange(New Object() {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea"})
        Me.cboDe.Location = New System.Drawing.Point(219, 165)
        Me.cboDe.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDe.Name = "cboDe"
        Me.cboDe.Size = New System.Drawing.Size(160, 24)
        Me.cboDe.TabIndex = 81
        '
        'cboA
        '
        Me.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboA.FormattingEnabled = True
        Me.cboA.Items.AddRange(New Object() {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea"})
        Me.cboA.Location = New System.Drawing.Point(219, 247)
        Me.cboA.Margin = New System.Windows.Forms.Padding(4)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(160, 24)
        Me.cboA.TabIndex = 80
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(213, 352)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(176, 46)
        Me.btnConvertir.TabIndex = 70
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(287, 303)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(28, 29)
        Me.lblIgual.TabIndex = 69
        Me.lblIgual.Text = "="
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(219, 324)
        Me.txtRespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(160, 22)
        Me.txtRespuesta.TabIndex = 68
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEntradab
        '
        Me.txtEntradab.Location = New System.Drawing.Point(219, 93)
        Me.txtEntradab.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntradab.Name = "txtEntradab"
        Me.txtEntradab.Size = New System.Drawing.Size(160, 22)
        Me.txtEntradab.TabIndex = 67
        Me.txtEntradab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(287, 215)
        Me.lblA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(35, 28)
        Me.lblA.TabIndex = 83
        Me.lblA.Text = "A:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(267, 61)
        Me.lblArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(74, 28)
        Me.lblArea.TabIndex = 84
        Me.lblArea.Text = "AREA"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tcConver)
        Me.TabControl1.Controls.Add(Me.tcArea)
        Me.TabControl1.Location = New System.Drawing.Point(79, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(604, 506)
        Me.TabControl1.TabIndex = 85
        '
        'tcConver
        '
        Me.tcConver.BackColor = System.Drawing.Color.OrangeRed
        Me.tcConver.Controls.Add(Me.txtRespuestaU)
        Me.tcConver.Controls.Add(Me.Label1)
        Me.tcConver.Controls.Add(Me.lblCantidad)
        Me.tcConver.Controls.Add(Me.btbConvertirU)
        Me.tcConver.Controls.Add(Me.txtNúmero)
        Me.tcConver.Controls.Add(Me.txtUnidad)
        Me.tcConver.Controls.Add(Me.lblUnidad)
        Me.tcConver.Location = New System.Drawing.Point(4, 25)
        Me.tcConver.Name = "tcConver"
        Me.tcConver.Padding = New System.Windows.Forms.Padding(3)
        Me.tcConver.Size = New System.Drawing.Size(596, 477)
        Me.tcConver.TabIndex = 0
        Me.tcConver.Text = "CONVERSOR"
        '
        'tcArea
        '
        Me.tcArea.BackColor = System.Drawing.Color.OrangeRed
        Me.tcArea.Controls.Add(Me.lblArea)
        Me.tcArea.Controls.Add(Me.txtEntradab)
        Me.tcArea.Controls.Add(Me.lblA)
        Me.tcArea.Controls.Add(Me.txtRespuesta)
        Me.tcArea.Controls.Add(Me.Label6)
        Me.tcArea.Controls.Add(Me.lblIgual)
        Me.tcArea.Controls.Add(Me.cboDe)
        Me.tcArea.Controls.Add(Me.btnConvertir)
        Me.tcArea.Controls.Add(Me.cboA)
        Me.tcArea.Location = New System.Drawing.Point(4, 25)
        Me.tcArea.Name = "tcArea"
        Me.tcArea.Padding = New System.Windows.Forms.Padding(3)
        Me.tcArea.Size = New System.Drawing.Size(596, 477)
        Me.tcArea.TabIndex = 1
        Me.tcArea.Text = "AREA"
        '
        'txtRespuestaU
        '
        Me.txtRespuestaU.Location = New System.Drawing.Point(200, 247)
        Me.txtRespuestaU.Name = "txtRespuestaU"
        Me.txtRespuestaU.Size = New System.Drawing.Size(196, 22)
        Me.txtRespuestaU.TabIndex = 13
        Me.txtRespuestaU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "RESPUESTA"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(261, 102)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(77, 17)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "CANTIDAD"
        '
        'btbConvertirU
        '
        Me.btbConvertirU.Location = New System.Drawing.Point(200, 306)
        Me.btbConvertirU.Name = "btbConvertirU"
        Me.btbConvertirU.Size = New System.Drawing.Size(196, 69)
        Me.btbConvertirU.TabIndex = 8
        Me.btbConvertirU.Text = "CONVERTIR"
        Me.btbConvertirU.UseVisualStyleBackColor = True
        '
        'txtNúmero
        '
        Me.txtNúmero.Location = New System.Drawing.Point(200, 122)
        Me.txtNúmero.Name = "txtNúmero"
        Me.txtNúmero.Size = New System.Drawing.Size(196, 22)
        Me.txtNúmero.TabIndex = 10
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(200, 178)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(196, 22)
        Me.txtUnidad.TabIndex = 11
        Me.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(261, 158)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(60, 17)
        Me.lblUnidad.TabIndex = 12
        Me.lblUnidad.Text = "UNIDAD"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(732, 600)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "CONVERSOR"
        Me.TabControl1.ResumeLayout(False)
        Me.tcConver.ResumeLayout(False)
        Me.tcConver.PerformLayout()
        Me.tcArea.ResumeLayout(False)
        Me.tcArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDe As ComboBox
    Friend WithEvents cboA As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblIgual As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents txtEntradab As TextBox
    Friend WithEvents lblA As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tcConver As TabPage
    Friend WithEvents tcArea As TabPage
    Friend WithEvents txtRespuestaU As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btbConvertirU As Button
    Friend WithEvents txtNúmero As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents lblUnidad As Label
End Class
