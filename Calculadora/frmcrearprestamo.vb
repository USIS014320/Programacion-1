Public Class frmCrearprestamo


    Dim objInteres As New interes()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        objInteres.inter = IdInteresComboBox.SelectedItem
        objInteres.tiempo = CuotasTextBox.Text
        objInteres.monto = CuotasTextBox
        lblinteresCompuesto.Text = "$" & objInteres.interesCompuesto()
    End Sub

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


Class interes
    Dim _interes As String, _ntiempo As Int16, _capital As Double

    Public Property inter
        Set(value)
            If value >= 0 And value <= 100 Then
                _interes = value
            Else
                MessageBox.Show("El valor del interes no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _interes
        End Get
    End Property
    Public Property tiempo
        Set(value)
            If value >= 1 And value <= 120 Then
                _ntiempo = value
            Else
                MessageBox.Show("Tiempo no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _ntiempo
        End Get
    End Property
    Public Property monto
        Set(value)
            If value > 0 Then
                _capital = value
            Else
                MessageBox.Show("El capital debe ser mayor a 0", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _capital
        End Get
    End Property

    Public Function interesCompuesto()
        Dim inC = (_capital * (1 + _interes / 100) ^ ((_ntiempo / 12)))
        Return Math.Round(inC, 2)
    End Function
End Class


