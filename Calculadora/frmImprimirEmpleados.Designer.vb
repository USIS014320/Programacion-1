<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirEmpleados
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
        Me.ImprimirEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprimirEmpleadosTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.ImprimirEmpleadosTableAdapter()
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImprimirEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ImprimirEmpleados"
        ReportDataSource1.Value = Me.ImprimirEmpleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.ImprimirEmpleadosrdlc.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(795, 445)
        Me.ReportViewer1.TabIndex = 0
        '
        'bd_sigacDataSet
        '
        Me.bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImprimirEmpleadosBindingSource
        '
        Me.ImprimirEmpleadosBindingSource.DataMember = "ImprimirEmpleados"
        Me.ImprimirEmpleadosBindingSource.DataSource = Me.bd_sigacDataSet
        '
        'ImprimirEmpleadosTableAdapter
        '
        Me.ImprimirEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirEmpleados"
        Me.Text = "frmImprimirEmpleados"
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImprimirEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ImprimirEmpleadosBindingSource As BindingSource
    Friend WithEvents bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents ImprimirEmpleadosTableAdapter As bd_sigacDataSetTableAdapters.ImprimirEmpleadosTableAdapter
End Class
