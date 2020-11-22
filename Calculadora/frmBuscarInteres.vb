Public Class frmBuscarInteres
    Dim objConexion As New db_conexion
    Public _idI As Integer
    Private Sub frmBuscarInteres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarInteres.DataSource = objConexion.obtenerDatos().Tables("intereses").DefaultView
    End Sub
    Private Sub filtrarDatosInteres(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarInteres.DataSource
        bs.Filter = "interes like '%" + valor + "%'"
        grdBuscarInteres.DataSource = bs
    End Sub
    Private Sub seleccionarInteres()
        _idI = grdBuscarInteres.CurrentRow.Cells("idInteres").Value.ToString()
        Close()
    End Sub
    Private Sub txtBuscarInteres_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarInteres.KeyUp
        filtrarDatosInteres(txtBuscarInteres.Text)
        If e.KeyCode = 13 Then
            seleccionarInteres()
        End If
    End Sub

    Private Sub btnSeleccionarInteres_Click(sender As Object, e As EventArgs) Handles btnSeleccionarInteres.Click
        seleccionarInteres()
    End Sub

    Private Sub btnCancelarInteres_Click(sender As Object, e As EventArgs) Handles btnCancelarInteres.Click
        Close()
    End Sub
End Class