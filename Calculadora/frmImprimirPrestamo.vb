Public Class frmImprimirPrestamo
    Private Sub frmImprimirPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirPrestamo' Puede moverla o quitarla según sea necesario.
        Me.ImprimirPrestamoTableAdapter.FillImprimirPrestamo(Me.bd_sigacDataSet.ImprimirPrestamo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class