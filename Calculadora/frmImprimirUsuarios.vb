Public Class frmImprimirUsuarios
    Private Sub frmImprimirUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirUsuario' Puede moverla o quitarla según sea necesario.
        Me.ImprimirUsuarioTableAdapter.FillImprimirUsuario(Me.bd_sigacDataSet.ImprimirUsuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class