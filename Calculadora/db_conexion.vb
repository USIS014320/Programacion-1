Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
Imports System.Data.SqlClient 'Biblioteca de clases para SQl server y ado.net
Public Class db_conexion
    Dim myConexion As New SqlConnection 'Conectarse a la BD.
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente. 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria.
    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bd_sigac.mdf;Integrated Security=True"
        myConexion.ConnectionString = cadenaConexion
        myConexion.Open()
        parametrizacion()
    End Sub

    Private Sub parametrizacion()
        miCommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idCargo", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idCategoria", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idVarios", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@cod", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nom", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@mar", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@med", SqlDbType.Char).Value = ""

        miCommand.Parameters.Add("@codigo", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tipro", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nufa", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tides", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tican", SqlDbType.Char).Value = ""

        miCommand.Parameters.Add("@usis", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nomper", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tela", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@clav", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@directi", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@carg", SqlDbType.Char).Value = ""

    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = myConexion

        miCommand.CommandText = "select * from cargos"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "cargos")

        miCommand.CommandText = "
            select usuarios.idUsuario, usuarios.idCargo, usuarios.usuario, usuarios.nombre, usuarios.telefono,
                usuarios.clave, usuarios.direccion, cargos.cargo
            from usuarios
                inner join cargos on(cargos.idCargo=usuarios.idCargo)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "usuarios")

        miCommand.CommandText = "select * from categorias"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "categorias")

        miCommand.CommandText = "select * from empleados"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "empleados")

        miCommand.CommandText = "select * from proveedores"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "proveedores")


        miCommand.CommandText = "
            select productos.idProducto, productos.idCategoria, productos.codigo, productos.descripcion, productos.marca,
                productos.medidas, categorias.categoria 
            from productos
                inner join categorias on(categorias.idCategoria=productos.idCategoria)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "productos")


        miCommand.CommandText = "select * from pagosvarios"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "pagosvarios")

        Return ds
    End Function

    Public Function mantenimientoDatosProveedor(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO proveedores (codigo,nombreempresa,nombrepropietario,telefono,email,website,fechaproveedor) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "')"
            Case "modificar"
                sql = "UPDATE proveedores SET codigo='" + datos(1) + "',nombreempresa='" + datos(2) + "',nombrepropietario='" + datos(3) + "',telefono='" + datos(4) + "',email='" + datos(5) + "',website='" + datos(6) + "',fechaproveedor='" + datos(7) + "' WHERE idProveedor='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM proveedores WHERE idProveedor='" + datos(0) + "'"


        End Select
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosProductos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO productos (idCategoria,codigo,descripcion,marca,medidas) VALUES(@idCategoria,@cod,@nom,@mar,@med)"
            Case "modificar"
                sql = "UPDATE productos SET idCategoria=@idCategoria,codigo=@cod,descripcion=@nom,marca=@mar,medidas=@med WHERE idProducto=@id"
            Case "eliminar"
                sql = "DELETE FROM productos WHERE idProducto=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idCategoria").Value = datos(1)
            miCommand.Parameters("@cod").Value = datos(2)
            miCommand.Parameters("@nom").Value = datos(3)
            miCommand.Parameters("@mar").Value = datos(4)
            miCommand.Parameters("@med").Value = datos(5)

        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosEmpleados(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO empleados (nombre,usuario,clave,direccion,telefono) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE empleados SET nombre='" + datos(1) + "',usuario='" + datos(2) + "',clave='" + datos(3) + "',direccion='" + datos(4) + "',telefono='" + datos(5) + "' WHERE idEmpleado='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM empleados WHERE idEmpleado='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosUsuario(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO usuarios (idCargo,usuario,nombre,telefono,clave,direccion) VALUES(@idCargo,@usis,@nomper,@tela,@clav,@directi)"
            Case "modificar"
                sql = "UPDATE usuarios SET idCargo=@idCargo,usuario=@usis,nombre=@nomper,telefono=@tela,clave=@clav,direccion=@directi WHERE idUsuario=@id"
            Case "eliminar"
                sql = "DELETE FROM usuarios WHERE idUsuario=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idCargo").Value = datos(1)
            miCommand.Parameters("@usis").Value = datos(2)
            miCommand.Parameters("@nomper").Value = datos(3)
            miCommand.Parameters("@tela").Value = datos(4)
            miCommand.Parameters("@clav").Value = datos(5)
            miCommand.Parameters("@directi").Value = datos(6)

        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosCargo(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO cargos (cargo) VALUES(@carg)"
            Case "modificar"
                sql = "UPDATE cargos SET cargo=@carg WHERE idCargo=@id"
            Case "eliminar"
                sql = "DELETE FROM cargos WHERE idCargo=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@carg").Value = datos(1)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function


    Public Function mantenimientoPagosvarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO pagosvarios (codigo,tipoproducto,nfactura,descripcion,cantidad) VALUES(@codigo,@tipro,@nufa,@tides,@tican)"
            Case "modificar"
                sql = "UPDATE pagosvarios SET codigo=@codigo,tipoproducto=@tipro,nfactura=@nufa,descripcion=@tides,cantidad=@tican WHERE idVarios=@id"
            Case "eliminar"
                sql = "DELETE FROM pagosvarios WHERE idVarios=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@codigo").Value = datos(1)
            miCommand.Parameters("@tipro").Value = datos(2)
            miCommand.Parameters("@nufa").Value = datos(3)
            miCommand.Parameters("@tides").Value = datos(4)
            miCommand.Parameters("@tican").Value = datos(5)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Private Function executeSql(ByVal sql As String)
        Try
            miCommand.Connection = myConexion
            miCommand.CommandText = sql
            Return miCommand.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
