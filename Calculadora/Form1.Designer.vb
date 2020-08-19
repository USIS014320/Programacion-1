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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnParoimpar = New System.Windows.Forms.Button()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbligual
        '
        Me.lbligual.AutoSize = True
        Me.lbligual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbligual.Location = New System.Drawing.Point(437, 147)
        Me.lbligual.Name = "lbligual"
        Me.lbligual.Size = New System.Drawing.Size(25, 25)
        Me.lbligual.TabIndex = 42
        Me.lbligual.Text = "="
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(379, 92)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(139, 39)
        Me.btnProcesar.TabIndex = 40
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(101, 106)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(139, 22)
        Me.txtnum1.TabIndex = 32
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(139, 86)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(58, 17)
        Me.lblnum1.TabIndex = 30
        Me.lblnum1.Text = "Número"
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.ItemHeight = 16
        Me.lstEjercicios.Location = New System.Drawing.Point(337, 175)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(248, 244)
        Me.lstEjercicios.TabIndex = 43
        '
        'btnParoimpar
        '
        Me.btnParoimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParoimpar.Location = New System.Drawing.Point(101, 134)
        Me.btnParoimpar.Name = "btnParoimpar"
        Me.btnParoimpar.Size = New System.Drawing.Size(139, 92)
        Me.btnParoimpar.TabIndex = 44
        Me.btnParoimpar.Text = "PAR O IMPAR"
        Me.btnParoimpar.UseVisualStyleBackColor = True
        '
        'btnPrimo
        '
        Me.btnPrimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimo.Location = New System.Drawing.Point(101, 232)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(139, 92)
        Me.btnPrimo.TabIndex = 45
        Me.btnPrimo.Text = "PRIMO"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(101, 330)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(139, 92)
        Me.btnCajero.TabIndex = 46
        Me.btnCajero.Text = "CAJERO"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.btnParoimpar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.lbligual)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ejercicios de estructura control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbligual As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents lblnum1 As Label
    Friend WithEvents lstEjercicios As ListBox
    Friend WithEvents btnParoimpar As Button
    Friend WithEvents btnPrimo As Button
    Friend WithEvents btnCajero As Button
End Class
