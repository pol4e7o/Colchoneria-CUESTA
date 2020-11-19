Public Class Pantalla_eliminar_empleado
    Private Sub Pantalla_eliminar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub
End Class