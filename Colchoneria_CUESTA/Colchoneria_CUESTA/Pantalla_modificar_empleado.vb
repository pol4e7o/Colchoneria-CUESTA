Public Class Pantalla_modificar_empleado

    'El objeto que se va a modificar
    Private empleado As New GestionComercial.Empleado()

    Private Sub Pantalla_modificar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El primer elemento del formulario tiene el foco
        comboBox_elegirEmpleado.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Por defecto el boton guardar viene desactivado
        'Para activarlo todos los campos tienen que tener valores correctos
        boton_guardar.Enabled = False

        'Por defecto el panel estara desactivado
        panel_elementosEmpleado.Enabled = False

        'Si no hay ningun elemento para modificar se le indica al usuario
        If articulos.Count = 0 Then

            MsgBox("No hay ningun empleado para modificar. Para crear uno elija añadir dentro de gestion de empleados",
                    0 + MsgBoxStyle.Information, "Modificar articulos")

            Pantalla_admin_empleados.Show()
            Me.Close()

        Else

            'Se cargan todos los nombres de usuarios de los empleados en el comboBox_elegirEmpleado
            For i = 0 To empleados.Count - 1

                comboBox_elegirEmpleado.Items.Add(empleados.Item(i).getNombreUsuario)

            Next i

        End If

    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click

        'La opcion elegida por el usuario a cerca de si desea cerrar caja
        Dim opcion As Integer

        'Esta variable va a almacenar el informe del cierre de caja 
        'que se va a guardar en el fichero de ventas y se va a 
        'visualizar en un message box
        Dim informe As String

        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Esta seguro que desea cerrar caja?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar caja")

        If opcion = MsgBoxResult.Yes Then

            informe = "Informe de venta de: " & vbCrLf & Now & vbCrLf & "Total: " & venta & "€" &
                    vbCrLf & "Cierre de caja hecha por: " & vbCrLf & usuario.getNombreUsuario


            'Se visualiza la informacon del cierre de caja en un Message box
            MsgBox(informe, 0 + MsgBoxStyle.Information, "Informe de cierre de caja")

            'Se cambia el valor de la variable venta a 0
            venta = 0

            'Se le pasa el valor true a la variable cajaCerrada 
            cajaCerrada = True




            'Se guarda el valor de venta en el fichero
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


                Catch ex1 As Exception

                    MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                End Try

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.",
                           0 + MsgBoxStyle.Information, "Guardar venta actual")

                Try

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt""" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)


                Catch ex1 As Exception

                    MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                End Try

            End Try

            'Se cierran todos los ficheros abiertos
            FileClose()





            Try

                'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario
                FileOpen(4, "VentasDiarias.txt", OpenMode.Append)

                ventaRegistro.fecha = DateString
                ventaRegistro.informacionVenta = informe

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentasDiarias.txt"" no se encuentra por lo tanto no se ha podido guadrar el informe de cierre de caja" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentasDiarias.txt",
                            0 + MsgBoxStyle.Exclamation, "Guardar informe de cierre de caja")

                Try

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - El fichero ""VentasDiarias.txt"" no se ha encontrado" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)


                Catch ex1 As Exception

                    MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                End Try

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar el informe de cierre de caja.",
                           0 + MsgBoxStyle.Information, "Guardar informe de cierre de caja")

                Try

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentasDiarias.txt""" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)


                Catch ex1 As Exception

                    MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                End Try

            End Try

            'Se cierran todos los ficheros abiertos
            FileClose()

        End If

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de empleados sin terminar la operacion?",
                        4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de modificacion de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

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

                        FileClose()

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

                        FileClose()

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

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: " &
               Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")


    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de empleados sin terminar la operacion?",
                        4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de modificacion de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de articulos
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de articulos sin terminar la operacion?",
                        4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de articulos y se cierra la de modificacion de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de ventas
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de ventas sin terminar la operacion?",
                        4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de ventas y se cierra la de modificacion de empleado
            Gestion_de_ventas.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeErroresToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de ventas
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de errores sin terminar la operacion?",
                        4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de errores y se cierra la de modificacion de empleado
            Gestion_de_errores.Show()
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

    Private Sub boton_guardar_Click(sender As Object, e As EventArgs) Handles boton_guardar.Click

        'Indica si el nombre de usuario se ha repetido
        Dim nombreUsuarioRepetido As Boolean = False

        'Contador de for
        Dim i As Integer

        'La opcion elegida por el usuario a la hora de decidir si desea guardar el cliente modificado
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea modificar el empleado?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de empleado")

        If opcion = MsgBoxResult.Yes Then

            'Se le asignan los nuevos datos personales al empleado seleccionado
            empleado.setNombreEmpleado(textBox_nombre.Text)
            empleado.setApellidos(textBox_apellidos.Text)
            empleado.setDireccion(textBox_direccion.Text)
            empleado.setCodigoPostal(textBox_codigoPostal.Text)
            empleado.setTelefono(textBox_telefono.Text)
            empleado.setNombreUsuario(textBox_nombreUsuario.Text)
            empleado.setContraseniaEmpleado(textBox_contrasenia.Text)

            If comboBox_roles.SelectedIndex = 0 Then

                empleado.setEsAdministrador(True)

            Else

                empleado.setEsAdministrador(False)

            End If

            'Se comprueba si existe otro empleado con el mismo nombre de usuario pero diferente codigo
            For i = 0 To empleados.Count - 1

                If empleados.Item(i).getNombreUsuario.Equals(empleado.getNombreUsuario) And empleados.Item(i).getCodigoEmpleado <> empleado.getCodigoEmpleado Then

                    nombreUsuarioRepetido = True

                End If

            Next i

            'Si se ha repetido se le avisa al usuario y se borra el campo del nombre del usuario
            If nombreUsuarioRepetido Then

                MsgBox("Ya existe otro empleado con el mismo nombre de usuario. Por favor indique de nuevo el nombre de usuario", 0 + MsgBoxStyle.Information, "Nombre de usuario repetido")

                textBox_nombreUsuario.Text = ""
                textBox_nombreUsuario.Focus()

            Else

                'Se modifica dentro del arraylist y despues se sobrescribe el fichero de empleados
                For i = 0 To empleados.Count - 1

                    'Si los dos codigos son iguales se modifica en el arraylist y en el fichero
                    If empleados.Item(i).getCodigoEmpleado = empleado.getCodigoEmpleado Then

                        Try

                            'Se abre el fichero Empleados.txt para modificar el empleado
                            FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Write, , Len(empleadoRegistro))

                            'se pasan todos los datos del empleado al registro
                            empleadoRegistro.codigoEmpleado = empleado.getCodigoEmpleado
                            empleadoRegistro.nombre = empleado.getNombreEmpleado
                            empleadoRegistro.apellidos = empleado.getApellidos
                            empleadoRegistro.direccion = empleado.getDireccion
                            empleadoRegistro.codigoPostal = empleado.getCodigoPostal
                            empleadoRegistro.telefono = empleado.getTelefono
                            empleadoRegistro.nombreUsuario = empleado.getNombreUsuario
                            empleadoRegistro.contrasenia = empleado.getContraseniaEmpleado
                            empleadoRegistro.esAdministrador = empleado.getEsAdministrador

                            'Se almacena el nuevo empleado en la posicion igual que el codigo de empleado
                            FilePut(1, empleadoRegistro, empleadoRegistro.codigoEmpleado)

                            'Se almacena el nuevo objeto en la posicion del antiguo
                            empleados.Item(i) = empleado

                            'Se notifica al usuario que la operacion se ha realiado con exito
                            MsgBox("El empleado se ha modificado correctamente", 0 + MsgBoxStyle.Information, "Modificacion de empleado")


                        Catch ex As System.IO.FileNotFoundException

                            MsgBox("El fichero ""Empleados.txt"" no se ha posido encontrar por lo tanto no se ha podido modificar el empleado. " & vbCrLf &
                                    "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                                    "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Empleados.txt",
                                   0 + MsgBoxStyle.Exclamation, "Modificar empleado")
                            Try

                                'Se crea de nuevo un empleado vacio
                                empleado = New GestionComercial.Empleado()

                                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                                errorRegistro.fecha = DateString
                                errorRegistro.informacionError = Now & " - El fichero ""Empleados.txt"" no se ha encontrado" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                            Catch ex1 As Exception

                                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                            End Try

                        Catch

                            MsgBox("Se ha producido un error a la hora de modificar al empleado. Por favor intentelo de nuevo",
                                   0 + MsgBoxStyle.Information, "Modificar empleado")

                            Try

                                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                                errorRegistro.fecha = DateString
                                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de domificar un empleado del fichero ""Empleados.txt""" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                                'Se crea de nuevo un empleado vacio
                                empleado = New GestionComercial.Empleado()

                            Catch ex1 As Exception

                                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

                            End Try

                        End Try

                        'Se cierra los ficheros
                        FileClose()

                    End If

                Next i

                'Se vuelve a la pantalla de gestion de empleados
                Pantalla_admin_empleados.Show()
                Me.Close()

            End If

        End If

    End Sub

    Private Sub boton_cancelar_Click(sender As Object, e As EventArgs) Handles boton_cancelar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?",
                        4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub textBox_codigoPostal_TextChanged(sender As Object, e As EventArgs) Handles textBox_codigoPostal.TextChanged

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.esNumero(textBox_codigoPostal.Text) And textBox_codigoPostal.Text.Length = 5 Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de codigo postal
            MsgBox("El codigo postal puede contener solo 5 numeros. Por favor intente introducir el valor del codigo postal de nuevo.",
                   0 + MsgBoxStyle.Information, "Codigo postal incorrecto")
            textBox_codigoPostal.Focus()

        End If

    End Sub

    Private Sub textBox_apellidos_TextChanged(sender As Object, e As EventArgs) Handles textBox_apellidos.TextChanged

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_apellidos.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de apellido/s
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo apellido/s de nuevo.",
                   0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_apellidos.Focus()

        End If

    End Sub

    Private Sub textBox_contrasenia_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.esNumero(textBox_contrasenia.Text) And textBox_contrasenia.Text.Length = 4 Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonGuardarAlta()

            End If


        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de contraseña
            MsgBox("La contraseña debe contener exactamente 4 numeros. Por favor intente introducir la contraseña de nuevo.",
                   0 + MsgBoxStyle.Information, "Contraseña incorrecta")
            textBox_contrasenia.Text = ""

        End If

    End Sub

    Private Sub textBox_contrasenia2_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia2.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.esNumero(textBox_contrasenia.Text) And textBox_contrasenia.Text.Length = 4 Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonGuardarAlta()

            Else

                'Se le indica al usuario que las dos contraseñas no son iguales
                MsgBox("Las dos contraseñas no coinciden. Por favor introducelas de nuevo.",
                       0 + MsgBoxStyle.Information, "Contraseñas incorrectas")

                'Se borran los datos de los dos campos y se pasa el foco a la primera contraseña (original)
                textBox_contrasenia2.Text = ""
                textBox_contrasenia.Text = ""
                textBox_contrasenia.Focus()


            End If


        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de repetir contraseña
            MsgBox("La contraseña debe contener exactamente 4 numeros. Por favor intente introducir la contraseña de nuevo.",
                   0 + MsgBoxStyle.Information, "Contraseña incorrecta")
            textBox_contrasenia2.Text = ""

        End If

    End Sub

    Private Sub textBox_direccion_TextChanged(sender As Object, e As EventArgs) Handles textBox_direccion.TextChanged

        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()

    End Sub

    Private Sub textBox_nombre_TextChanged(sender As Object, e As EventArgs) Handles textBox_nombre.TextChanged

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_nombre.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo apellido/s de nuevo.",
                   0 + MsgBoxStyle.Information, "Valor de nombre incorrecto")
            textBox_nombre.Focus()

        End If

    End Sub

    Private Sub textBox_nombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles textBox_nombreUsuario.TextChanged

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_nombreUsuario.Text) And textBox_nombreUsuario.Text.Contains(" ") = False And textBox_nombreUsuario.Text.Contains("-") = False And textBox_nombreUsuario.Text.Length >= 3 Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre de usuario
            MsgBox("El nombre de usuario puede contener solo letras con un minimo de 3 caracteres. Por favor intente introducir el valor del campo nombre de usuario de nuevo.",
                   0 + MsgBoxStyle.Information, "Valor de nombre de usuario incorrecto")
            textBox_nombreUsuario.Focus()

        End If

    End Sub



    Private Sub textBox_telefono_TextChanged(sender As Object, e As EventArgs) Handles textBox_telefono.TextChanged

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNumeroTelefono(textBox_telefono.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de telefono
            MsgBox("El telefono puede contener solo numeros, espacion en blanco y como primeros caractres ""(+  )"" o ""+"". Por favor intente introducir el valor del campo telefono de nuevo.",
                   0 + MsgBoxStyle.Information, "Valor de telefono incorrecto")
            textBox_telefono.Focus()

        End If

    End Sub

    Private Sub comboBox_roles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_roles.SelectedIndexChanged

        'Si se ha elegido un elemento se intenta activar el boton guardar
        If comboBox_roles.SelectedIndex <> -1 Then

            'Si el que se esta modificando es el administrador principal (AdminCuesta)
            'no se permite que se le pase rol de administrador
            If empleado.getCodigoEmpleado = 1 And comboBox_roles.SelectedItem.Equals("Empleado") Then

                MsgBox("El administrador general no puede tener rol de empleado",
                       0 + MsgBoxStyle.Information, "Administrador")

                comboBox_roles.SelectedIndex = 0

            End If

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        End If

    End Sub

    Private Sub activarBotonGuardarAlta()

        boton_guardar.Enabled = False

        'Se comprueba que todos los campos tienen el tamaño minimo 
        'Si son correctos se activa el boton
        If textBox_nombre.Text.Length <> 0 And textBox_apellidos.Text.Length <> 0 Then

            If textBox_direccion.Text.Length <> 0 And textBox_codigoPostal.Text.Length = 5 Then

                If textBox_telefono.Text.Length <> 0 And textBox_nombreUsuario.Text.Length >= 3 Then

                    If textBox_contrasenia.Text.Length = 4 And textBox_contrasenia2.Text.Length = 4 Then

                        If comboBox_roles.SelectedIndex <> -1 And textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                            boton_guardar.Enabled = True

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub comboBox_elegirEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_elegirEmpleado.SelectedIndexChanged

        'Si se ha elegido un empleado de los de la lista se activa el boton guardar
        If comboBox_elegirEmpleado.SelectedIndex >= 0 Then

            panel_elementosEmpleado.Enabled = True

            'Se busca el empleado elegido
            For i = 0 To empleados.Count - 1

                'Si los nombres de usuario son iguales se pasan todos los datos de este empleado al las cajas de texto
                If comboBox_elegirEmpleado.SelectedItem.Equals(empleados.Item(i).getNombreUsuario) Then

                    'Se hace una capia de todos los datos del articulo seleccionado
                    empleado.setCodigoEmpleado(empleados.Item(i).getCodigoEmpleado)
                    empleado.setNombreEmpleado(empleados.Item(i).getNombreEmpleado)
                    empleado.setApellidos(empleados.Item(i).getApellidos)
                    empleado.setDireccion(empleados.Item(i).getDireccion)
                    empleado.setCodigoPostal(empleados.Item(i).getCodigoPostal)
                    empleado.setTelefono(empleados.Item(i).getTelefono)
                    empleado.setNombreUsuario(empleados.Item(i).getNombreUsuario)
                    empleado.setContraseniaEmpleado(empleados.Item(i).getContraseniaEmpleado)
                    empleado.setEsAdministrador(empleados.Item(i).getEsAdministrador)

                    textBox_nombre.Text = empleado.getNombreEmpleado
                    textBox_apellidos.Text = empleado.getApellidos
                    textBox_direccion.Text = empleado.getDireccion
                    textBox_codigoPostal.Text = empleado.getCodigoPostal
                    textBox_telefono.Text = empleado.getTelefono
                    textBox_nombreUsuario.Text = empleado.getNombreUsuario.Replace(" ", "")
                    textBox_contrasenia.Text = empleado.getContraseniaEmpleado
                    textBox_contrasenia2.Text = empleado.getContraseniaEmpleado

                    'Si esAdinistrador es true se selecciona en el combobox el elemento con posicion 0
                    If empleado.getEsAdministrador Then

                        comboBox_roles.SelectedIndex = 0

                    Else

                        'Sino se le asigna 1
                        comboBox_roles.SelectedIndex = 1

                    End If

                End If

            Next i

            'Se habilita el boton guardar
            boton_guardar.Enabled = True

        Else

            panel_elementosEmpleado.Enabled = False

            'Se vacian los campos de texto
            textBox_nombre.Text = ""
            textBox_apellidos.Text = ""
            textBox_direccion.Text = ""
            textBox_codigoPostal.Text = ""
            textBox_nombreUsuario.Text = ""
            textBox_telefono.Text = ""

        End If

    End Sub

End Class