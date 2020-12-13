Public Class frmImprimirSalarios
    Private Sub frmImprimirSalarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirSalarios' Puede moverla o quitarla según sea necesario.
        Me.ImprimirSalariosTableAdapter.FillImprimirSalarios(Me.bd_sigacDataSet.ImprimirSalarios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class