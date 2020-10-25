Public Class frmBuscarProductofaltante

    Dim objConexion As New db_conexion
    Public _idPF As Integer
    Private Sub frmBuscarProductofaltante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarfaltante.DataSource = objConexion.obtenerDatos().Tables("faltanteproducto").DefaultView
    End Sub
    Private Sub filtrarDatosProductos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarfaltante.DataSource
        bs.Filter = "categoria like '%" + valor + "%' or codigo like '%" & valor & "%' or  descripcion like '%" & valor & "%'"
        grdBuscarfaltante.DataSource = bs
    End Sub
    Private Sub seleccionarProducto()
        _idPF = grdBuscarfaltante.CurrentRow.Cells("idFaltanteproducto").Value.ToString()
        Close()
    End Sub
    Private Sub btnSeleccionarfaltante_Click(sender As Object, e As EventArgs) Handles btnSeleccionarfaltante.Click
        seleccionarProducto()
    End Sub

    Private Sub txtBuscarfaltante_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarfaltante.KeyUp
        filtrarDatosProductos(txtBuscarfaltante.Text)
        If e.KeyCode = 13 Then
            seleccionarProducto()
        End If
    End Sub

    Private Sub btnCancelarfaltante_Click(sender As Object, e As EventArgs) Handles btnCancelarfaltante.Click
        Close()
    End Sub
End Class