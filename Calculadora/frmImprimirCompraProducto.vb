Public Class frmImprimirCompraProducto
    Private Sub frmImprimirCompraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirCompraProducto' Puede moverla o quitarla según sea necesario.
        Me.ImprimirCompraProductoTableAdapter.FillImprimirCompraProducto(Me.bd_sigacDataSet.ImprimirCompraProducto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class