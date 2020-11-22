Public Class frmDeudas
    Private Sub frmDeudas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Bd_sigacDataSet1.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.Deuda' Puede moverla o quitarla según sea necesario.
        Me.DeudaTableAdapter.Fill(Me.Bd_sigacDataSet.Deuda)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.Deuda' Puede moverla o quitarla según sea necesario.
        Me.DeudaTableAdapter.Fill(Me.Bd_sigacDataSet.Deuda)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.Bd_sigacDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.Bd_sigacDataSet.empleados)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet1.Deuda' Puede moverla o quitarla según sea necesario.
        Me.DeudaTableAdapter.Fill(Me.Bd_sigacDataSet.Deuda)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.Bd_sigacDataSet.empleados)
        'TODO: esta línea de código carga datos en la tabla 'Bd_sigacDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.Bd_sigacDataSet.empleados)
    End Sub
    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = DvDeudasDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = DvDeudasDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("nombre").Value.ToString()) * Double.Parse(fila.Cells("descripcion").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()
                sumas += subtotal
            Next
            iva = If(ComboBox1.SelectedValue = 4, sumas * 0.13, 0)
            total = sumas + iva

            lblRespuestaSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblRespuestaIva.Text = "$ " + Math.Round(iva, 2).ToString()
            lblRespuestaTotal.Text = "$ " + Math.Round(total, 2).ToString()

            lblnregistros.Text = (DeudaBindingSource.Position + 1) & " de " & DeudaBindingSource.Count
        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        DeudaBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        DeudaBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        DeudaBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        DeudaBindingSource.MoveLast()
        totalizar()
    End Sub


    Private Sub DventasProductosDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DvDeudasDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.DeudaTableAdapter.FillBy(Me.Bd_sigacDataSet.Deuda)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class