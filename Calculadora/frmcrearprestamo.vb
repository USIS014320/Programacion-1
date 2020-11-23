Public Class frmcrearprestamo
    Private Sub CrearprestamoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CrearprestamoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CrearprestamoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_sigacDataSet)

    End Sub

    Private Sub frmcrearprestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.intereses' Puede moverla o quitarla según sea necesario.
        Me.InteresesTableAdapter.FillInteres(Me.Bd_sigacDataSet.intereses)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.ocupacion' Puede moverla o quitarla según sea necesario.
        Me.OcupacionTableAdapter.FillOcupacion(Me.Bd_sigacDataSet.ocupacion)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.FillClientes(Me.Bd_sigacDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.crearprestamoCliente' Puede moverla o quitarla según sea necesario.
        Me.CrearprestamoClienteTableAdapter.FillcrearprestamoCliente(Me.Bd_sigacDataSet.crearprestamoCliente)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.crearprestamo' Puede moverla o quitarla según sea necesario.
        Me.CrearprestamoTableAdapter.FillCrearPrestamo(Me.Bd_sigacDataSet.crearprestamo)

    End Sub

    Private Sub btnAgregarClienteNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregarClienteNuevo.Click
        Dim objClientes As New frmClientes
        objClientes.Show()
    End Sub
End Class