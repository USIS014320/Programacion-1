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
        miCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = 0

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

        miCommand.Parameters.Add("@idfaltante", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@codfal", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@descrip", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@marca", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@medid", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@canfal", SqlDbType.Char).Value = ""

        miCommand.Parameters.Add("@nb", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@usua", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@cl", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@dr", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tell", SqlDbType.Char).Value = ""

        miCommand.Parameters.Add("@es", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@pag", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@dc", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@cap", SqlDbType.Char).Value = ""

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

        miCommand.CommandText = "select * from ProductosDeuda"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "ProductosDeuda")

        miCommand.CommandText = "select * from Descuentos"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Descuentos")

        miCommand.CommandText = "select * from categoriafaltante "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "categoriafaltante")

        miCommand.CommandText = "select * from faltanteproducto "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "faltanteproducto")

        miCommand.CommandText = "
            select prestamos.idPrestamo, prestamos.idEmpleado, prestamos.mes, prestamos.pago, prestamos.descuento,
                prestamos.capital, empleados.nombre 
            from prestamos
                inner join empleados on(empleados.idEmpleado=prestamos.idEmpleado)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "prestamos")

        miCommand.CommandText = "
            select clientes.idCliente, clientes.codigo, clientes.nombre, clientes.direccion, contactos.telefono, contactos.email 
            from clientes 
                inner join contactos on(contactos.idPersona=clientes.idCliente)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "clientes")

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
                sql = "INSERT INTO empleados (nombre,usuario,clave,direccion,telefono) VALUES(@nb,@usua,@cl,@dr,@tell)"
            Case "modificar"
                sql = "UPDATE empleados SET nombre=@nb,usuario=@usua,clave=@cl,direccion=@dr,telefono=@tell WHERE idEmpleado=@id"
            Case "eliminar"
                sql = "DELETE FROM empleados WHERE idEmpleado=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nb").Value = datos(1)
            miCommand.Parameters("@usua").Value = datos(2)
            miCommand.Parameters("@cl").Value = datos(3)
            miCommand.Parameters("@dr").Value = datos(4)
            miCommand.Parameters("@tell").Value = datos(5)

        End If
        If executeSql(sql) > 0 Then
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
    Public Function mantenimientoDatosProductosDeuda(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO ProductosDeuda (nombre, direccion, codigo, telefono, departamento, municipio ) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE ProductosDeuda SET nombre='" + datos(1) + "',direccion='" + datos(2) + "',codigo='" + datos(3) + "',telefono='" + datos(4) + "',departamento='" + datos(5) + "',municipio='" + datos(6) + "' WHERE idProductoDeuda='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM ProductosDeuda WHERE idProductoDeuda='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosDescuentos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Descuentos (Descuento) VALUES('" + datos(1) + "')"
            Case "modificar"
                sql = "UPDATE Descuentos SET Descuento='" + datos(1) + "' WHERE idDescuento='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Descuentos WHERE idDescuento='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosSalarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Salarios (Salarios) VALUES('" + datos(1) + "')"
            Case "modificar"
                sql = "UPDATE Descuentos SET salarios='" + datos(1) + "' WHERE idsalarios='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Descuentos WHERE idsalarios='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosfaltantes(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO faltanteproducto (idFaltante,codigofalta,descripcionfalta,marcafalta,medidasfalta,cantidadfalta) VALUES(@idFaltante,@codfal,@descrip,@marca,@medid,@canfal)"
            Case "modificar"
                sql = "UPDATE faltanteproducto SET idFaltante=@idfaltante,codigofalta=@codfal,descripcionfalta=@descrip,marcafalta=@marca,medidasfalta=@medid,cantidadfalta=@canfal WHERE idFaltanteproducto=@id"
            Case "eliminar",
                sql = "DELETE FROM faltanteproducto WHERE idFaltanteproducto=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idfaltante").Value = datos(1)
            miCommand.Parameters("@codfal").Value = datos(2)
            miCommand.Parameters("@descrip").Value = datos(3)
            miCommand.Parameters("@marca").Value = datos(4)
            miCommand.Parameters("@medid").Value = datos(5)
            miCommand.Parameters("@canfal").Value = datos(6)


        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosPrestamo(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO prestamos (idEmpleado,mes,pago,descuento,capital) VALUES(@idEmpleado,@es,@pag,@dc,@cap)"
            Case "modificar"
                sql = "UPDATE prestamos SET idEmpleado=@idEmpleado,mes=@es,pago=@pag,descuento=@dc,capital=@cap WHERE idPrestamo=@id"
            Case "eliminar"
                sql = "DELETE FROM prestamos WHERE idPrestamo=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idEmpleado").Value = datos(1)
            miCommand.Parameters("@es").Value = datos(2)
            miCommand.Parameters("@pag").Value = datos(3)
            miCommand.Parameters("@dc").Value = datos(4)
            miCommand.Parameters("@cap").Value = datos(5)
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

    Public Function mantenimientoDatosCliente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes (codigo,nombre,direccion) VALUES(@cod,@nom,@dir)"
            Case "modificar"
                sql = "UPDATE clientes SET codigo=@cod,nombre=@nom,direccion=@dir WHERE idCliente=@id"
            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idCliente=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@cod").Value = datos(1)
            miCommand.Parameters("@nom").Value = datos(2)
            miCommand.Parameters("@dir").Value = datos(3)
            miCommand.Parameters("@tel").Value = datos(4)
            miCommand.Parameters("@ema").Value = datos(5)
        Else 'Accion es eliminar
            mantenimientoDatosContacto(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosContacto(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Sub mantenimientoDatosContacto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                miCommand.CommandText = "select MAX(idCliente) AS idCliente from clientes"
                datos(0) = miCommand.ExecuteScalar().ToString()

                sql = "INSERT INTO contactos (idPersona,telefono,email) VALUES(@id,@tel,@ema)"
            Case "modificar"
                sql = "UPDATE contactos SET telefono=@tel,email=@ema WHERE idPersona=@id"
            Case "eliminar"
                sql = "DELETE FROM contactos WHERE idPersona=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@tel").Value = datos(4)
            miCommand.Parameters("@ema").Value = datos(5)
        End If
        executeSql(sql)
    End Sub

    Public Function mantenimientoDatosInteres(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO interes (interes VALUES(@inters)"
            Case "modificar"
                sql = "UPDATE cargos SET interes=@inters WHERE idInteres=@id"
            Case "eliminar"
                sql = "DELETE FROM cargos WHERE idInteres=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@inters").Value = datos(1)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function
End Class
