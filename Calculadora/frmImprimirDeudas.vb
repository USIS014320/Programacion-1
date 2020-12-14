Public Class frmImprimirDeudas
    Private Sub frmImprimirDeudas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirDeudas' Puede moverla o quitarla según sea necesario.
        Me.ImprimirDeudasTableAdapter.FillImprimirDeuda(Me.bd_sigacDataSet.ImprimirDeudas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class