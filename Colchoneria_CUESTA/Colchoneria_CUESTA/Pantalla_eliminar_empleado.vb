Public Class Pantalla_eliminar_empleado
    Private Sub Pantalla_eliminar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El primer elemento del formulario tiene el foco
        comboBox_elegirEmpleado.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Por defecto el boton viene desactivado
        'Para activarlo se tiene que elegir un empleado
        boton_guardar.Enabled = False

        panel_elementosEmpleado.Enabled = False

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

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

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")



    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de articulos
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de articulos sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de articulos y se cierra la de baja de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de ventas
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de ventas sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de ventas y se cierra la de baja de empleado

            Me.Close()

        End If

    End Sub

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")

    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        'Se abre el manual de usuario

    End Sub

    Private Sub comboBox_elegirEmpleado_Leave(sender As Object, e As EventArgs) Handles comboBox_elegirEmpleado.Leave

        'Si se ha elegido un empleado de los de la lista se activa el boton eliminar
        If comboBox_elegirEmpleado.SelectedIndex <> -1 Then

            'Se coge el objeto elegido y sus datos se introducen en los campos de texto
            'en modo visualizar (ReadOnly)

            'Introducir los datos del empleado
            textBox_nombre.Text = ""
            textBox_apellidos.Text = ""
            textBox_direccion.Text = ""
            textBox_codigoPostal.Text = ""
            textBox_nombreUsuario.Text = ""
            textBox_telefono.Text = ""

            'Se habilita el boton eliminar
            boton_guardar.Enabled = True

        Else

            'Se vacian los campos de texto
            textBox_nombre.Text = ""
            textBox_apellidos.Text = ""
            textBox_direccion.Text = ""
            textBox_codigoPostal.Text = ""
            textBox_nombreUsuario.Text = ""
            textBox_telefono.Text = ""

        End If

    End Sub

    Private Sub boton_guardar_Click(sender As Object, e As EventArgs) Handles boton_guardar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea eliminar el empleado
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea eliminar el empleado?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Baja de empleado")

        If opcion = MsgBoxResult.Yes Then

            'Se elimina el empleado del arraylist y se sobreescribe el fichero 
            'utilizando el arraylist modificado


            'Se vuelve a la pantalla de gestion de empleados
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub boton_cancelar_Click(sender As Object, e As EventArgs) Handles boton_cancelar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de alta de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click

        'La opcion elegida por el usuario a cerca de si desea cerrar caja
        Dim opcion As Integer

        'Esta variable va a almacenar el informe del cierre de caja 
        'que se va a visualizar en un message box
        Dim informe As String


        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Esta seguro que desea cerrar caja?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar caja")

        If opcion = MsgBoxResult.Yes Then

            informe = "Informe de venta de: " & vbCrLf &
            Now & vbCrLf &
            "Total: " & venta & "€" & vbCrLf &
            "Cierre de caja hecha por: " & vbCrLf &
            "Usuario"

            'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario

            'Se visualiza la informacon del cierre de caja en un Message box
            MsgBox(informe, 0 + MsgBoxStyle.Information, "Informe de cierre de caja")

            'Se cambia el valor de la variable venta a 0
            venta = 0

            'Se le pasa el valor true a la variable cajaCerrada 
            cajaCerrada = True

        End If

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

End Class