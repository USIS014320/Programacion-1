<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimirUsuarios))
        Me.ImprimirUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_sigacDataSet = New Calculadora.bd_sigacDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ImprimirUsuarioTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.ImprimirUsuarioTableAdapter()
        Me.ImprimirProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprimirProveedorTableAdapter = New Calculadora.bd_sigacDataSetTableAdapters.ImprimirProveedorTableAdapter()
        CType(Me.ImprimirUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImprimirProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImprimirUsuarioBindingSource
        '
        Me.ImprimirUsuarioBindingSource.DataMember = "ImprimirUsuario"
        Me.ImprimirUsuarioBindingSource.DataSource = Me.bd_sigacDataSet
        '
        'bd_sigacDataSet
        '
        Me.bd_sigacDataSet.DataSetName = "bd_sigacDataSet"
        Me.bd_sigacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ImprimirUsuario"
        ReportDataSource1.Value = Me.ImprimirUsuarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.impresionUsuarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(973, 516)
        Me.ReportViewer1.TabIndex = 0
        '
        'ImprimirUsuarioTableAdapter
        '
        Me.ImprimirUsuarioTableAdapter.ClearBeforeFill = True
        '
        'ImprimirProveedorBindingSource
        '
        Me.ImprimirProveedorBindingSource.DataMember = "ImprimirProveedor"
        Me.ImprimirProveedorBindingSource.DataSource = Me.bd_sigacDataSet
        '
        'ImprimirProveedorTableAdapter
        '
        Me.ImprimirProveedorTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 519)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimirUsuarios"
        Me.Text = " Reporte de Usuarios"
        CType(Me.ImprimirUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_sigacDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImprimirProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ImprimirUsuarioBindingSource As BindingSource
    Friend WithEvents bd_sigacDataSet As bd_sigacDataSet
    Friend WithEvents ImprimirUsuarioTableAdapter As bd_sigacDataSetTableAdapters.ImprimirUsuarioTableAdapter
    Friend WithEvents ImprimirProveedorBindingSource As BindingSource
    Friend WithEvents ImprimirProveedorTableAdapter As bd_sigacDataSetTableAdapters.ImprimirProveedorTableAdapter
End Class
