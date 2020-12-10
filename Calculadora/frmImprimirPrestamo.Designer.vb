<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirPrestamo
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimirPrestamo))
        Me.ImprimirPrestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ImprimirPrestamoTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.ImprimirPrestamoTableAdapter()
        CType(Me.ImprimirPrestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImprimirPrestamoBindingSource
        '
        Me.ImprimirPrestamoBindingSource.DataMember = "ImprimirPrestamo"
        Me.ImprimirPrestamoBindingSource.DataSource = Me.bd_sigacDataSet
        '
        'bd_sigacDataSet
        '
        Me.bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsImprimirPrestamo"
        ReportDataSource1.Value = Me.ImprimirPrestamoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.impresionPrestamo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1125, 585)
        Me.ReportViewer1.TabIndex = 0
        '
        'ImprimirPrestamoTableAdapter
        '
        Me.ImprimirPrestamoTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1123, 584)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimirPrestamo"
        Me.Text = " Imprimir Prestamo"
        CType(Me.ImprimirPrestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ImprimirPrestamoBindingSource As BindingSource
    Friend WithEvents bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents ImprimirPrestamoTableAdapter As bd_sigacDataSetTableAdapters.ImprimirPrestamoTableAdapter
End Class
