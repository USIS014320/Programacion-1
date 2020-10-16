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

    Public Function obtenerDatos()
        ds.Clear()
        miCommand.Connection = myConexion
        miCommand.CommandText = "select * from proveedores"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "proveedores")

        miCommand.CommandText = "select * from categorias"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "categorias")

        miCommand.CommandText = "
            select productos.idProducto, productos.idCategoria, productos.codigo, productos.descripcion, productos.marca,
                productos.medidas, categorias.categoria 
            from productos
                inner join categorias on(categorias.idCategoria=productos.idCategoria)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "productos")

        Return ds
    End Function
    Private Sub parametrizacion()
        miCommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idCategoria", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@cod", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nom", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@mar", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@med", SqlDbType.Char).Value = ""
    End Sub
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

    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = myConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class