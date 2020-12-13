Public Class frmImprimirEmpleados
    Private Sub frmImprimirEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirProductos' Puede moverla o quitarla según sea necesario.
        Me.ImprimirProductosTableAdapter.FillImprimirProductos(Me.bd_sigacDataSet.ImprimirProductos)
        'TODO: esta línea de código carga datos en la tabla 'bd_sigacDataSet.ImprimirEmpleados' Puede moverla o quitarla según sea necesario.
        Me.ImprimirEmpleadosTableAdapter.FillImprimirEmpleados(Me.bd_sigacDataSet.ImprimirEmpleados)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class