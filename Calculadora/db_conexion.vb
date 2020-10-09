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
                sql = "INSERT INTO proveedores (codigo,nombreempresa,nombrepropietario,direccion,telefono,email,website,fechaproveedor,pais,departamento,municipio) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "','" + datos(8) + "','" + datos(9) + "','" + datos(10) + datos(11) + "')"
            Case "modificar"
                sql = "UPDATE clientes SET codigo='" + datos(1) + "',nombreempresa='" + datos(2) + "',nombrepropietario='" + datos(3) + "',direccion='" + datos(4) + "',telefono='" + datos(5) + "',email='" + datos(6) + "',website='" + datos(7) + "',fechaproveedor='" + datos(8) + "',pais='" + datos(9) + "',departamento='" + datos(10) + "',municipio='" + datos(11) + "' WHERE idProveedor='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM proveedores WHERE idProveedor='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
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