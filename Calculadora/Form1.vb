﻿Public Class Form1
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
    Private Sub ProductosDeudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosDeudaToolStripMenuItem.Click
        Dim objProductosDeuda As New frmProductosDeudas
        objProductosDeuda.MdiParent = Me
        objProductosDeuda.Show()
    End Sub
    Private Sub SalariosToolStripMenuItem_click(sender As Object, e As EventArgs) Handles SalariosToolStripMenuItem.Click
        Dim objSalarios As New frmSalariosvb
        objSalarios.MdiParent = Me
        objSalarios.Show()
    End Sub
End Class

