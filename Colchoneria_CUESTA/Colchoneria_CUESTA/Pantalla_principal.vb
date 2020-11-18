﻿Public Class Pantalla_principal

    Private Sub Pantalla_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub Pantalla_principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        'Si se pulsa un boton del teclado se carga el siguente formulario
        Pantalla_de_inicio.Show()
        Me.Hide()

    End Sub
End Class
