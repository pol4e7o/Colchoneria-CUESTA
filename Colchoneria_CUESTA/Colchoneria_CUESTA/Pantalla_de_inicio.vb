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

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'Se le indica al usuario que tiene que identificarse primero
        MsgBox("Para poder realizar el cierre de caja primero tiene que identificarse.", 0 + MsgBoxStyle.Information, "Cierre de caja")


    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'Se llama al fichero que contiene el manual de usuario

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'La variable que va a almacenar la opcion elegida del message box
        Dim opcion As Integer

        'Se le pregunta al usuario si desea salir
        opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

        If MsgBoxResult.Yes = opcion Then

            Try

                'Se guarda el valor de venta en el fichero de ventas
                FileOpen(5, "VentaActual.txt", OpenMode.Output)

                Write(5, ElementosComunes.venta)

                FileClose()

                End

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto no se ha podido guadrar el valor de la venta hasta este momento" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                   "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentaActual.txt",
                   0 + MsgBoxStyle.Exclamation, "Guardar venta actual")

                Try

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                    'Se le pregunta al usuario si desea salir igualmente
                    opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

                    If MsgBoxResult.Yes = opcion Then
                        End
                    End If

                Catch ex1 As Exception

                    MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                End Try

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.",
                       0 + MsgBoxStyle.Information, "Guadrar venta actual")


                Try

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt""" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                    'Se le pregunta al usuario si desea salir igualmente
                    opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

                    If MsgBoxResult.Yes = opcion Then
                        End
                    End If


                Catch ex1 As Exception

                    MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                End Try

            End Try

            'Se cierran todos los ficheros abiertos
            FileClose()

        End If


    End Sub

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")


    End Sub

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: " &
               Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")


    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs)

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
        TimerVuelta.Stop()
        TimerVuelta.Start()


    End Sub

    Private Sub boton_entrar_Click(sender As Object, e As EventArgs) Handles boton_entrar.Click

        'Contador de for
        Dim i As Integer

        'Se utiliza para indicar si el usuario es correcto o no
        Dim empleadoCorrecto = False

        'Se comprueba que el usuario existe
        For i = 0 To empleados.Count - 1

            'Se comprueba si el nombre de usuario pertenece a alguno de los empleados registrados
            If textBox_usuario.Text.Equals(empleados.Item(i).getNombreUsuario) Then

                'Si tambien coincide la contraseña se asigna a la variable usuario el que ha iniciado la secion
                If textBox_contrasenia.Text.Equals(CStr(empleados.Item(i).getContraseniaEmpleado)) Then

                    usuario = empleados.Item(i)

                    i = empleados.Count

                    empleadoCorrecto = True

                    'Se limpian las cajas de texto 
                    textBox_usuario.Text = ""
                    textBox_contrasenia.Text = ""

                    'Se le dirige al usuario a la pantalla de ventas
                    Pantalla_de_venta.Show()
                    Me.Hide()

                End If

            End If

        Next i

        'Si es usuario no es correcto sale un mensaje
        If empleadoCorrecto = False Then

            'Se le indica al usuario que el nombre o la contraseña no son correctas sin espesificar cual es el erroneo
            MsgBox("El usuario o la contraseña no son correctos. Por favor intentelo de nuevo",
                       0 + MsgBoxStyle.Information, "Usuario o contraseña incorrecta")

            'Se limpian las cajas de texto y se pasa el foco al nombre de usuario
            textBox_usuario.Text = ""
            textBox_contrasenia.Text = ""
            textBox_usuario.Focus()

        End If

    End Sub

    Private Sub textBox_contrasenia_TextChanged(sender As Object, e As EventArgs) Handles textBox_contrasenia.TextChanged

        'Si el numero de caracteres introducidos en la caja de texto de la contraseña es 4 y
        ' en la de usuario son minimo 3 se habilita el boton entrar
        If textBox_contrasenia.Text.Length = 4 And textBox_usuario.Text.Length >= 3 Then

            boton_entrar.Enabled = True
            boton_entrar.Focus()

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