
Public Class Gestion_de_ventas
    'LOAD
    Private Sub Gestion_de_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'El primer elemento que tendra el foco es el textBox del usuario
        ComboBox_dia.Focus()
    End Sub
    'MENU
    'CERRAR CAJA
    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cerrar caja?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar caja")

        If opcion = MsgBoxResult.Yes Then

            'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario


            'Se cambia el valor de la variable venta a 0
            venta = 0

        End If



    End Sub

    'VOLVER
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Pantalla_admin_articulos.Show()
        Me.Close()
    End Sub

    'SALIR
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

    'VENTA
    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & ElementosComunes.venta & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")
    End Sub

    'ACERCA DE...
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")
    End Sub

    'AYUDA
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        'Te reenviará a un fichero: Manual de usuario
    End Sub

    'HORA
    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    'COMBOBOX
    Private Sub ComboBox_dia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dia.SelectedIndexChanged
        activarBotonVisualizar()
    End Sub

    'ACTIVAR BOTON VISUALIZAR
    Private Sub activarBotonVisualizar()
        If (ComboBox_dia.SelectedItem < 0) Then
            Button_visualizar.Enabled = False
        Else
            Button_visualizar.Enabled = True
        End If
    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If
    End Sub
    'VISUALIZAR
    Private Sub Button_visualizar_Click(sender As Object, e As EventArgs) Handles Button_visualizar.Click
        'Coloca en el label la fecha la hora y el total de venta
    End Sub
End Class