Public Class Pantalla_principal

    Private Sub Pantalla_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Este boton no es disponible porque no hay mas pantallas
        'antes de esta
        VolverToolStripMenuItem.Enabled = False

        'Cuando se carga por primera vez el formulario se asigna a la variable venta 0
        'Teniendo en cuenta que no se puede salir de la aplicacion sin cerrar caja antes
        ElementosComunes.venta = 0

        'Cuando se carga la aplicacion cajaCerrada será true
        'Cuando se haga una venta este valor pasará a false
        ' y esta que no se haga el cierre de caja no se podra salir de la aplicacion
        ElementosComunes.cajaCerrada = False

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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If ElementosComunes.cajaCerrada = False Then

            'Si la caja no esta cerrada no se podra salir del programa
            'Se le indica al usuario que tiene que cerrarla antes de salir
            MsgBox("    Para poder salir de la aplicacion se necesita realizar primero el cierre de caja. De lo contrario no se va a guardar la venta el dia", MsgBoxStyle.Information, "Salir")

        Else

            'Se le pregunta al usuario si desea salir
            MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

            If MsgBoxResult.Yes Then
                End
            End If

        End If

    End Sub
End Class
