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
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblmedia = New System.Windows.Forms.Label()
        Me.lblvarianza = New System.Windows.Forms.Label()
        Me.txtRespuestaVarianza = New System.Windows.Forms.TextBox()
        Me.txtRespuestaMedia = New System.Windows.Forms.TextBox()
        Me.txtRespuestaDesvTipica = New System.Windows.Forms.TextBox()
        Me.lblDesvTipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(267, 379)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(143, 59)
        Me.btnMediaAritmetica.TabIndex = 0
        Me.btnMediaAritmetica.Text = "Calculos Estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(311, 24)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(48, 17)
        Me.lblserie.TabIndex = 1
        Me.lblserie.Text = "SERIE"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(267, 44)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(143, 22)
        Me.txtserie.TabIndex = 2
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(309, 131)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(50, 17)
        Me.lblmedia.TabIndex = 3
        Me.lblmedia.Text = "MEDIA"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.Location = New System.Drawing.Point(298, 213)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(76, 17)
        Me.lblvarianza.TabIndex = 5
        Me.lblvarianza.Text = "VARIANZA"
        '
        'txtRespuestaVarianza
        '
        Me.txtRespuestaVarianza.Location = New System.Drawing.Point(267, 233)
        Me.txtRespuestaVarianza.Name = "txtRespuestaVarianza"
        Me.txtRespuestaVarianza.Size = New System.Drawing.Size(143, 22)
        Me.txtRespuestaVarianza.TabIndex = 8
        Me.txtRespuestaVarianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaMedia
        '
        Me.txtRespuestaMedia.Location = New System.Drawing.Point(267, 151)
        Me.txtRespuestaMedia.Name = "txtRespuestaMedia"
        Me.txtRespuestaMedia.Size = New System.Drawing.Size(143, 22)
        Me.txtRespuestaMedia.TabIndex = 10
        Me.txtRespuestaMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaDesvTipica
        '
        Me.txtRespuestaDesvTipica.Location = New System.Drawing.Point(267, 308)
        Me.txtRespuestaDesvTipica.Name = "txtRespuestaDesvTipica"
        Me.txtRespuestaDesvTipica.Size = New System.Drawing.Size(143, 22)
        Me.txtRespuestaDesvTipica.TabIndex = 12
        Me.txtRespuestaDesvTipica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(274, 288)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(136, 17)
        Me.lblDesvTipica.TabIndex = 11
        Me.lblDesvTipica.Text = "DESVIACION TIPICA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.txtRespuestaDesvTipica)
        Me.Controls.Add(Me.lblDesvTipica)
        Me.Controls.Add(Me.txtRespuestaMedia)
        Me.Controls.Add(Me.txtRespuestaVarianza)
        Me.Controls.Add(Me.lblvarianza)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Matrices y POO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents lblserie As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblmedia As Label
    Friend WithEvents lblvarianza As Label
    Friend WithEvents txtRespuestaVarianza As TextBox
    Friend WithEvents txtRespuestaMedia As TextBox
    Friend WithEvents txtRespuestaDesvTipica As TextBox
    Friend WithEvents lblDesvTipica As Label
End Class
