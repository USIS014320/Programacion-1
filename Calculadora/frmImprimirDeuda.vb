Public Class frmImprimirDeuda
    Private Sub frmImprimirDeuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirDeuda' Puede moverla o quitarla según sea necesario.
        Me.ImprimirDeudaTableAdapter.FillImprimirDeuda(Me.bd_sigacDataSet.ImprimirDeuda)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class