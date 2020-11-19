Public Class Pantalla_de_inicio
    Private Sub Pantalla_de_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Este boton ya esta disponible porque esta es la segunda pantalla
        VolverToolStripMenuItem.Enabled = True

        'Por defecto el boton entrar esta deshabilitado
        boton_entrar.Enabled = False

        'El primer elemento que tendra el foco es el textBox del usuario
        textBox_usuario.Focus()

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click

        'Se le indica al usuario que tiene que identificarse primero
        MsgBox("Para poder realizar el cierre de caja primero tiene que identificarse.", 0 + MsgBoxStyle.Information, "Cierre de caja")


    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        'Se llama al fichero que contiene el manual de usuario

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        'La variable que va a almacenar la opcion elegida del message box
        Dim opcion As Integer

        If ElementosComunes.cajaCerrada = False Then

            'Si la caja no esta cerrada no se podra salir del programa
            'Se le indica al usuario que tiene que cerrarla antes de salir
            MsgBox("    Para poder salir de la aplicacion se necesita realizar primero el cierre de caja. De lo contrario no se va a guardar la venta el dia", MsgBoxStyle.Information, "Salir")

        Else

            'Se le pregunta al usuario si desea salir
            opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

            If MsgBoxResult.Yes = opcion Then
                End
            End If

        End If

    End Sub

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")


    End Sub

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & ElementosComunes.venta & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        'Se abre la pantalla principal y se cierra la de inicio de secion
        Pantalla_principal.Show()
        Me.Close()

    End Sub

    Private Sub TimerVuelta_Tick(sender As Object, e As EventArgs) Handles TimerVuelta.Tick

        'Si pasado 5 minutos no se ha pulsado ningun boton se vuelve a la pantalla principal
        Pantalla_principal.Show()
        Me.Close()

    End Sub

    Private Sub Pantalla_de_inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        'Si se pulsa una tecla se apaga el timer y se inciende de nuevo
        TimerVuelta.Enabled = False
        TimerVuelta.Enabled = True

    End Sub

    Private Sub boton_entrar_Click(sender As Object, e As EventArgs) Handles boton_entrar.Click

        'Se comprueba que el usuario existe



    End Sub

    Private Sub textBox_contrasenia_TextChanged(sender As Object, e As EventArgs) Handles textBox_contrasenia.TextChanged

        'Si el numero de caracteres introducidos en la caja de texto de la contraseña es 4 y
        ' en la de usuario son minimo 3 se habilita el boton entrar
        If textBox_contrasenia.Text.Length = 4 And textBox_usuario.Text.Length >= 3 Then

            boton_entrar.Enabled = True

        End If

    End Sub

    Private Sub textBox_usuario_TextChanged(sender As Object, e As EventArgs) Handles textBox_usuario.TextChanged

        'Si el numero de caracteres introducidos en la caja de texto de la contraseña es 4 y
        ' en la de usuario son minimo 3 se habilita el boton entrar
        If textBox_contrasenia.Text.Length = 4 And textBox_usuario.Text.Length >= 3 Then

            boton_entrar.Enabled = True

        End If

    End Sub
End Class