Public Class frmImprimirProveedores
    Private Sub frmImprimirProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirProveedor' Puede moverla o quitarla según sea necesario.
        Me.ImprimirProveedorTableAdapter.FillImprimirProveedor(Me.bd_sigacDataSet.ImprimirProveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class