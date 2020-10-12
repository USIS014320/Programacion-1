Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
Imports System.Data.SqlClient 'Biblioteca de clases para SQl server y ado.net
Public Class db_conexion
    Dim miConexion As New SqlConnection 'Conectarse a la BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria
    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sigac.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion
        miConexion.Open()

        parametrizacion()
    End Sub

    Private Sub parametrizacion()
        miCommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@cod", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nomem", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nompro", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@tel", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@ema", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@web", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@fecha", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@pais", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@dep", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@mun", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@cant", SqlDbType.Char).Value = ""
    End Sub


    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion
        miCommand.CommandText = "select * from proveedores"
        miAdapter.SelectCommand = miCommand

        miAdapter.Fill(ds, "proveedores")

        Return ds
    End Function

    Public Function mantenimientoDatosProveedor(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO proveedores (codigo,nombreempresa,nombrepropietario,telefono,email,website,fechaproveedor,pais,departamento,muninicpio,canton) VALUES (@cod,@nomem,@nompro,@tel,@ema,@web,@fecha,@pais,@dep,@mun,@cant)"
            Case "modificar"
                sql = "UPDATE proveedores SET codigo=@cod,nombreempresa=@nomem,nombrepropietario=@nompro,telefono=@tel,email=@ema,website=@web,fechaproveedor=@fecha,pais=@pais,departamento=@dep,muninicpio=@mun,canton=@cant WHERE idProveedor=@id"
            Case "eliminar"
                sql = "DELETE FROM proveedoress WHERE idProveedor=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@cod").Value = datos(1)
            miCommand.Parameters("@nomem").Value = datos(2)
            miCommand.Parameters("@nompro").Value = datos(3)
            miCommand.Parameters("@tel").Value = datos(4)
            miCommand.Parameters("@ema").Value = datos(5)
            miCommand.Parameters("@web").Value = datos(6)
            miCommand.Parameters("@fecha").Value = datos(7)
            miCommand.Parameters("@pais").Value = datos(8)
            miCommand.Parameters("@dep").Value = datos(9)
            miCommand.Parameters("@mun").Value = datos(10)
            miCommand.Parameters("@cant").Value = datos(11)
        Else 'Accion es eliminar
            mantenimientoDatosProveedor(datos, accion)
        End If
        If executeSql(sql) > 0 Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosProveedor(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class