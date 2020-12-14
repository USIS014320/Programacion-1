Public Class frmDeuda
    Private Sub DeudaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DeudaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DeudaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_sigacDataSet)

    End Sub

    Private Sub frmDeuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.prestamos' Puede moverla o quitarla según sea necesario.
        Me.PrestamosTableAdapter.FillPrestamos(Me.Bd_sigacDataSet.prestamos)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.FillEmpleados(Me.Bd_sigacDataSet.empleados)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.DetallaPrestamo' Puede moverla o quitarla según sea necesario.
        Me.DetallaPrestamoTableAdapter.FillDetallaPrestamo(Me.Bd_sigacDataSet.DetallaPrestamo)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.deuda' Puede moverla o quitarla según sea necesario.
        Me.DeudaTableAdapter.FillDeuda(Me.Bd_sigacDataSet.deuda)

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim objImprimirDeudas As New frmImprimirDeudas
        objImprimirDeudas.ShowDialog()
    End Sub
End Class