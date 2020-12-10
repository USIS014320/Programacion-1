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

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim objClientes As New frmClientes
        objClientes.MdiParent = Me
        objClientes.Show()
    End Sub

    Private Sub CrearPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearPrestamoToolStripMenuItem.Click
        Dim objcrearprestamo As New frmcrearprestamo
        objcrearprestamo.MdiParent = Me
        objcrearprestamo.Show()
    End Sub
    Private Sub DeudasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudasToolStripMenuItem.Click
        Dim objDeudas As New frmDeuda
        objDeudas.MdiParent = Me
        objDeudas.Show()
    End Sub

    Private Sub ReportesDePrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDePrestamosToolStripMenuItem.Click
        Dim objPrestamosPorCliente As New frmImprimirPrestamo
        objPrestamosPorCliente.MdiParent = Me
        objPrestamosPorCliente.Show()
    End Sub

    Private Sub ReporteDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProveedoresToolStripMenuItem.Click
        Dim objImprimirProveedores As New frmImprimirProveedores
        objImprimirProveedores.MdiParent = Me
        objImprimirProveedores.Show()
    End Sub

    Private Sub ReporteDeUsariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeUsariosToolStripMenuItem.Click
        Dim objImprimirUsuarios As New frmImprimirUsuarios
        objImprimirUsuarios.MdiParent = Me
        objImprimirUsuarios.Show()
    End Sub
End Class
