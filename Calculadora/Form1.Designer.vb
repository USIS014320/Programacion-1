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
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        Me.lbltotalx1xf1 = New System.Windows.Forms.Label()
        Me.lbltotalx21xf1 = New System.Windows.Forms.Label()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x1xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x21xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(52, 378)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(143, 59)
        Me.btnMediaAritmetica.TabIndex = 0
        Me.btnMediaAritmetica.Text = "Calculos Estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(96, 23)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(48, 17)
        Me.lblserie.TabIndex = 1
        Me.lblserie.Text = "SERIE"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(52, 43)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(143, 22)
        Me.txtserie.TabIndex = 2
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(94, 130)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(50, 17)
        Me.lblmedia.TabIndex = 3
        Me.lblmedia.Text = "MEDIA"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.Location = New System.Drawing.Point(83, 212)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(76, 17)
        Me.lblvarianza.TabIndex = 5
        Me.lblvarianza.Text = "VARIANZA"
        '
        'txtRespuestaVarianza
        '
        Me.txtRespuestaVarianza.Location = New System.Drawing.Point(52, 232)
        Me.txtRespuestaVarianza.Name = "txtRespuestaVarianza"
        Me.txtRespuestaVarianza.Size = New System.Drawing.Size(143, 22)
        Me.txtRespuestaVarianza.TabIndex = 8
        Me.txtRespuestaVarianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaMedia
        '
        Me.txtRespuestaMedia.Location = New System.Drawing.Point(52, 150)
        Me.txtRespuestaMedia.Name = "txtRespuestaMedia"
        Me.txtRespuestaMedia.Size = New System.Drawing.Size(143, 22)
        Me.txtRespuestaMedia.TabIndex = 10
        Me.txtRespuestaMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaDesvTipica
        '
        Me.txtRespuestaDesvTipica.Location = New System.Drawing.Point(52, 307)
        Me.txtRespuestaDesvTipica.Name = "txtRespuestaDesvTipica"
        Me.txtRespuestaDesvTipica.Size = New System.Drawing.Size(143, 22)
        Me.txtRespuestaDesvTipica.TabIndex = 12
        Me.txtRespuestaDesvTipica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(59, 287)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(136, 17)
        Me.lblDesvTipica.TabIndex = 11
        Me.lblDesvTipica.Text = "DESVIACION TIPICA"
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(647, 457)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(28, 17)
        Me.lbltotalf1.TabIndex = 14
        Me.lbltotalf1.Text = "0.0"
        '
        'lbltotalx1xf1
        '
        Me.lbltotalx1xf1.AutoSize = True
        Me.lbltotalx1xf1.Location = New System.Drawing.Point(785, 457)
        Me.lbltotalx1xf1.Name = "lbltotalx1xf1"
        Me.lbltotalx1xf1.Size = New System.Drawing.Size(28, 17)
        Me.lbltotalx1xf1.TabIndex = 15
        Me.lbltotalx1xf1.Text = "0.0"
        '
        'lbltotalx21xf1
        '
        Me.lbltotalx21xf1.AutoSize = True
        Me.lbltotalx21xf1.Location = New System.Drawing.Point(884, 457)
        Me.lbltotalx21xf1.Name = "lbltotalx21xf1"
        Me.lbltotalx21xf1.Size = New System.Drawing.Size(28, 17)
        Me.lbltotalx21xf1.TabIndex = 16
        Me.lbltotalx21xf1.Text = "0.0"
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x1, Me.f1, Me.n1, Me.x1xf1, Me.x21xf1})
        Me.grdEstadistica.Location = New System.Drawing.Point(234, 43)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.RowHeadersWidth = 51
        Me.grdEstadistica.RowTemplate.Height = 24
        Me.grdEstadistica.Size = New System.Drawing.Size(678, 394)
        Me.grdEstadistica.TabIndex = 17
        '
        'x1
        '
        Me.x1.HeaderText = "X1"
        Me.x1.MinimumWidth = 6
        Me.x1.Name = "x1"
        Me.x1.Width = 125
        '
        'f1
        '
        Me.f1.HeaderText = "F1"
        Me.f1.MinimumWidth = 6
        Me.f1.Name = "f1"
        Me.f1.Width = 125
        '
        'n1
        '
        Me.n1.HeaderText = "N1"
        Me.n1.MinimumWidth = 6
        Me.n1.Name = "n1"
        Me.n1.Width = 125
        '
        'x1xf1
        '
        Me.x1xf1.HeaderText = "X1 x F1"
        Me.x1xf1.MinimumWidth = 6
        Me.x1xf1.Name = "x1xf1"
        Me.x1xf1.Width = 125
        '
        'x21xf1
        '
        Me.x21xf1.HeaderText = "X21 x F1"
        Me.x21xf1.MinimumWidth = 6
        Me.x21xf1.Name = "x21xf1"
        Me.x21xf1.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(957, 534)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.lbltotalx21xf1)
        Me.Controls.Add(Me.lbltotalx1xf1)
        Me.Controls.Add(Me.lbltotalf1)
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
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbltotalf1 As Label
    Friend WithEvents lbltotalx1xf1 As Label
    Friend WithEvents lbltotalx21xf1 As Label
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents x1 As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents n1 As DataGridViewTextBoxColumn
    Friend WithEvents x1xf1 As DataGridViewTextBoxColumn
    Friend WithEvents x21xf1 As DataGridViewTextBoxColumn
End Class
