Public Class Form1

    Dim objdirecciones = New direcciones()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDep.Items.AddRange(objdirecciones.depto)
    End Sub

    Private Sub cboDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDep.SelectedIndexChanged
        cboMun.Items.Clear()
        cboMun.Text = ""
        cboMun.Items.AddRange(objdirecciones.mun(cboDep.SelectedIndex))
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        cboCantón.Items.Clear()
        cboCantón.Text = ""
        cboCantón.Items.AddRange(objdirecciones.cant(cboMun.SelectedIndex))
    End Sub

End Class

Class direcciones

    Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan", "San Salvador", "La Libertad", "Chalatenango", "San Vicente", "Cabañas"}
    Public mun()() As String = {
        New String() {"Seleccione un depto."},
        New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria", "Concepción Batres"},  '0->Usulutan
        New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},'1->San Miguel
        New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},                  '2->La Union
        New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},              '3->Morazan
        New String() {"Seleccione un municipio", "San Salvador", "Apopa", "Aguilares", "Ilopango", "El Paisnal"}, '4->San Salvador
        New String() {"Seleccione un municipio", "Santa Tecla", "Antiguo Cuscatlan", "Cuidad Arce", "Colón", "Comasagua"}, '5->La libertad
        New String() {"Seleccione un municipio", "Agua Caliente", "Arcatao", "Chalatenango", "Dulce Nombre de Maria", "Concepción Quezaltepeque"}, '6->Chalatenango
        New String() {"Seleccione un municipio", "San Vicente", "Apastepeque", "Guadalupe", "San Sebastián", "Santo Domingo"} '7->San Vicente
        }
    Public cant()() As String = {
      New String() {"Selecione un mun."},
      New String() {"selecione un cantón"},
      New String() {"selecione un cantón"},
      New String() {"selecione un cantón"},
       New String() {"selecione un cantón"},
      New String() {"selecione un cantón", "El Cañal", "El paraisal", "El Porvenir", "Hacienda Nueva", "San Ildefonso", "La Anchila", "La Danta", "San Antonio", "San Felipe", "B.º. La Parroquia", "B.º. Candelaria", "B.º. San Antonio", "El Calvario", "Col. Amaya", "Col. El Progeso"} '4>-Concepción Batres
      }
End Class