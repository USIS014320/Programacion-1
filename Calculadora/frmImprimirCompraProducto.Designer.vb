<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirCompraProducto
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.ImprimirCompraProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprimirCompraProductoTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.ImprimirCompraProductoTableAdapter()
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImprimirCompraProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ImprimirCompraProducto"
        ReportDataSource1.Value = Me.ImprimirCompraProductoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.impresionCompraProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1042, 430)
        Me.ReportViewer1.TabIndex = 0
        '
        'bd_sigacDataSet
        '
        Me.bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImprimirCompraProductoBindingSource
        '
        Me.ImprimirCompraProductoBindingSource.DataMember = "ImprimirCompraProducto"
        Me.ImprimirCompraProductoBindingSource.DataSource = Me.bd_sigacDataSet
        '
        'ImprimirCompraProductoTableAdapter
        '
        Me.ImprimirCompraProductoTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirCompraProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 433)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirCompraProducto"
        Me.Text = "Reporte de Compra de Productos"
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImprimirCompraProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ImprimirCompraProductoBindingSource As BindingSource
    Friend WithEvents bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents ImprimirCompraProductoTableAdapter As bd_sigacDataSetTableAdapters.ImprimirCompraProductoTableAdapter
End Class
