Public Class frmImprimirPagosVarios
    Private Sub frmImprimirPagosVarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirPagosVarios' Puede moverla o quitarla según sea necesario.
        Me.ImprimirPagosVariosTableAdapter.FillImprimirPagosVarios(Me.bd_sigacDataSet.ImprimirPagosVarios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class