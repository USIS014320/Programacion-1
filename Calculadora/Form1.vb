Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim objEmpleados As New frmEmpleados
        objEmpleados.MdiParent = Me
        objEmpleados.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim objProveedores As New frmProveedores
        objProveedores.MdiParent = Me
        objProveedores.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim objProductos As New frmProductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim objUsuario As New frmUsuario
        objUsuario.MdiParent = Me
        objUsuario.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim objPagosVarios As New frmPagosVarios
        objPagosVarios.MdiParent = Me
        objPagosVarios.Show()
    End Sub

    Private Sub RegistroDeCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeCargosToolStripMenuItem.Click
        Dim objCargos As New frmCargos
        objCargos.MdiParent = Me
        objCargos.Show()
    End Sub

    Private Sub ProductosDeudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosDeudaToolStripMenuItem.Click
        Dim objProductosDeuda As New frmProductosDeuda
        objProductosDeuda.MdiParent = Me
        objProductosDeuda.Show()
    End Sub

    Private Sub ToolStripMenuItem3_click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim objSalarios As New frmSalario
        objSalarios.MdiParent = Me
        objSalarios.Show()
    End Sub

    Private Sub ProductosExsitentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosExsitentesToolStripMenuItem.Click
        Dim objProductos As New frmProductos
        objProductos.MdiParent = Me
        objProductos.Show()
    End Sub

    Private Sub ProductosFaltantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosFaltantesToolStripMenuItem.Click
        Dim objProductofaltante As New frmProductosfaltantes
        objProductofaltante.MdiParent = Me
        objProductofaltante.Show()
    End Sub

    Private Sub ResgistrosDePrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResgistrosDePrestamosToolStripMenuItem.Click
        Dim objPrestamo As New frmPrestamo
        objPrestamo.MdiParent = Me
        objPrestamo.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Dim objCompra As New frmComprasproducto
        objCompra.MdiParent = Me
        objCompra.Show()
    End Sub
End Class
