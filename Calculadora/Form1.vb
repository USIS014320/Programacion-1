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
End Class

Class direcciones

    Public depto() As String = {"Selccione un departamento", "Usulután",
        "San Miguel", "La Unión", "Morazán", “Ahuachapán”, “Cabañas”, “Chalatenango”, “Cuscatlán”,
        “La Libertad”, “La Paz”, “San Salvador”, “San Vicente”, “Santa Ana”, “Sonsonate”}

    Public mun()() As String = {
        New String() {"Selccione un departamento"},
        New String() {"Seleccione un municipio", "Usulután", "Jiquilisco", "Santa Ana", "Santa Maria"}, '0->Usulutan
        New String() {"Seleccione un municipio", "San Miguel", "El Tránsito", "San Rafael", "San Jorge"},'0->San Miguel
        New String() {"Seleccione un municipio", "La Unión", "SRL", "Anamoros", "Bolivar"}, '0->La Unión
        New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"} '0->Morazán
        }
End Class