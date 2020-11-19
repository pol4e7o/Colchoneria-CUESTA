Public Class Pantalla_aniadir_empleado
    Private Sub Pantalla_aniadir_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub
End Class