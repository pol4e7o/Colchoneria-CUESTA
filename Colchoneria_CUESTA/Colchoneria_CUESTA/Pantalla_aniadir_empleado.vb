Public Class Pantalla_aniadir_empleado

    'El empleado que se va a manejar
    Public empleado As GestionComercial.Empleado

    Private Sub Pantalla_aniadir_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El primer elemento del formulario tiene el foco
        textBox_nombre.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Por defecto el boton guardar viene desactivado
        'Para activarlo todos los campos tienen que tener valores correctos
        boton_guardar.Enabled = False


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

                End

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto no se ha podido guadrar el valor de la venta hasta este momento" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentaActual.txt",
                            0 + MsgBoxStyle.Exclamation, "Guardar venta")

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado"

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.", 0 + MsgBoxStyle.Information, "Guardar venta")


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt"""

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)


            Finally

                FileClose()

            End Try





            Try

                'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario
                FileOpen(4, "VentasDiarias.txt", OpenMode.Append)

                ventaRegistro.fecha = DateString
                ventaRegistro.informacionVenta = informe


            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentasDiarias.txt"" no se encuentra por lo tanto no se ha podido guadrar el informe de cierre de caja" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentasDiarias.txt",
                            0 + MsgBoxStyle.Exclamation, "Guardar informa de cierre de caja")


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentasDiarias.txt"" no se ha encontrado"

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar el informe de cierre de caja.", 0 + MsgBoxStyle.Information, "Guardar informa de cierre de caja")


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentasDiarias.txt"""

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            Finally

                FileClose()

            End Try


        End If

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de alta de empleado
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

                End

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto no se ha podido guadrar el valor de la venta hasta este momento" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentaActual.txt",
                            0 + MsgBoxStyle.Exclamation, "Guardar venta")

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado"

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                'Se le pregunta al usuario si desea salir igualmente
                opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

                If MsgBoxResult.Yes = opcion Then
                    End
                End If

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.", 0 + MsgBoxStyle.Information, "Guardar venta")


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt"""

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                'Se le pregunta al usuario si desea salir igualmente
                opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

                If MsgBoxResult.Yes = opcion Then
                    End
                End If

            Finally

                FileClose()

            End Try

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

            'Se abre la pantalla de gestion de empleados y se cierra la de alta de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de articulos
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de articulos sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de articulos y se cierra la de alta de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de ventas
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de ventas sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de ventas y se cierra la de alta de empleado
            Gestion_de_ventas.Show()
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

        'La opcion elegida por el usuario a la hora de decidir si desea guardar el nuevo cliente 
        Dim opcion As Integer

        'Indica si el nombre de usuario se ha repetido
        Dim nombreUsuarioRepetido As Boolean = False

        opcion = MsgBox("Esta seguro que desea crear el nuevo empleado?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de empleado")

        If opcion = MsgBoxResult.Yes Then

            'Si no se ha podido crear el objeto se le indica al usuario que no se ha podido crear el empleado
            If IsNothing(empleado) Then

                MsgBox("El empleado no se ha podido crear correctamente", 0 + MsgBoxStyle.Information, "Alta de empleado")

            Else

                'Se comprueba si existe otro empleado con el mismo nombre de usuario
                For i = 0 To empleados.Count - 1

                    If empleados.Item(i).getNombreUsuario.Equals(empleado.getNombreUsuario) Then

                        nombreUsuarioRepetido = True

                    End If

                Next i

                'Si se ha repetido se le avisa al usuario y se borra el campo del nombre del usuario
                If nombreUsuarioRepetido Then

                    MsgBox("Ya existe otro empleado con el mismo nombre de usuario. Por favor indique de nuevo el nombre de usuario", 0 + MsgBoxStyle.Information, "Nombre de usuario repetido")

                    textBox_nombreUsuario.Text = ""
                    textBox_nombreUsuario.Focus()

                Else

                    'Se le asigna el codigo del ultimo empleado mas 1 que es lo que devuelve la funcion count
                    empleado.setCodigoEmpleado(empleados.Count)

                    'Se guarda el empleado dentro del fichero de empleados
                    empleados.Add(empleado)

                    Try

                        'Se abre el fichero Empleados.txt para añadir el nuevo empleado
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



                    Catch ex As System.IO.FileNotFoundException

                        MsgBox("El fichero ""Empleados.txt"" no se ha posido encontrar por lo tanto no se ha podido agregar el empleado nuevo. " & vbCrLf &
                                "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                                "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Empleados.txt", 0 + MsgBoxStyle.Exclamation)

                        'Se elimina el objeto añadido de la lista
                        empleados.RemoveAt(empleados.Count - 1)

                        'Se le asigna nothing(null) a la variable empleado
                        empleado = Nothing

                        'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                        FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                        errorRegistro.fecha = DateString
                        errorRegistro.informacionError = Now & " - El fichero ""Empleados.txt"" no se ha encontrado"

                        Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                    Catch

                        MsgBox("Se ha producido un error a la hora de dar de alta al empleado. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir empleado")

                        'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                        FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                        errorRegistro.fecha = DateString
                        errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de almacenar un empleado nuevo en el fichero ""Empleados.txt"""

                        Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                        'Se elimina el objeto añadido de la lista
                        empleados.RemoveAt(empleados.Count - 1)

                        'Se le asigna nothing(null) a la variable empleado
                        empleado = Nothing

                    Finally

                        'Se cierra los ficheros
                        FileClose()

                    End Try

                    'Se vuelve a la pantalla de gestion de empleados
                    Pantalla_admin_empleados.Show()
                    Me.Close()

                End If

            End If

        End If

    End Sub

    Private Sub boton_cancelar_Click(sender As Object, e As EventArgs) Handles boton_cancelar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub textBox_codigoPostal_Leave(sender As Object, e As EventArgs) Handles textBox_codigoPostal.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.numeroMayorACero(textBox_codigoPostal.Text) And textBox_codigoPostal.Text.Length = 5 Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de codigo postal
            MsgBox("El codigo postal puede contener solo 5 numeros. Por favor intente introducir el valor del codigo postal de nuevo.", 0 + MsgBoxStyle.Information, "Codigo postal incorrecto")
            textBox_codigoPostal.Focus()

        End If



    End Sub

    Private Sub textBox_apellidos_Leave(sender As Object, e As EventArgs) Handles textBox_apellidos.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_apellidos.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de apellido/s
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo apellido/s de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
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
            MsgBox("La contraseña debe contener exactamente 4 numeros. Por favor intente introducir la contraseña de nuevo.", 0 + MsgBoxStyle.Information, "Contraseña incorrecta")
            textBox_contrasenia.Focus()

        End If

    End Sub

    Private Sub textBox_contrasenia2_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia2.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.numeroMayorACero(textBox_contrasenia.Text) And textBox_contrasenia.Text.Length = 4 Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonGuardarAlta()

            Else

                'Se le indica al usuario que las dos contraseñas no son iguales
                MsgBox("Las dos contraseñas no coinciden. Por favor introducelas de nuevo.", 0 + MsgBoxStyle.Information, "Contraseñas incorrectas")

                'Se borran los datos de los dos campos y se pasa el foco a la primera contraseña (original)
                textBox_contrasenia2.Text = ""
                textBox_contrasenia.Text = ""
                textBox_contrasenia.Focus()


            End If


        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de repetir contraseña
            MsgBox("La contraseña debe contener exactamente 4 numeros. Por favor intente introducir la contraseña de nuevo.", 0 + MsgBoxStyle.Information, "Contraseña incorrecta")
            textBox_contrasenia2.Focus()

        End If

    End Sub

    Private Sub textBox_direccion_Leave(sender As Object, e As EventArgs) Handles textBox_direccion.Leave

        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()

    End Sub

    Private Sub textBox_nombre_Leave(sender As Object, e As EventArgs) Handles textBox_nombre.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_nombre.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo nombre de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_nombre.Focus()

        End If

    End Sub

    Private Sub textBox_nombreUsuario_Leave(sender As Object, e As EventArgs) Handles textBox_nombreUsuario.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_nombreUsuario.Text) And textBox_nombreUsuario.Text.Length >= 3 And textBox_nombreUsuario.Text.Contains(" ") = False And textBox_nombreUsuario.Text.Contains("-") = False Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre de usuario
            MsgBox("El nombres de usuario puede contener solo letras con un minimo de 3 caracteres. Por favor intente introducir el valor del campo nombre de usuario de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_nombreUsuario.Focus()

        End If

    End Sub

    Private Sub textBox_telefono_Leave(sender As Object, e As EventArgs) Handles textBox_telefono.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNumeroTelefono(textBox_telefono.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de telefono
            MsgBox("El telefono puede contener solo numeros, espacion en blanco y como primeros caractres ""(+  )"" o ""+"". Por favor intente introducir el valor del campo telefono de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_telefono.Focus()

        End If

    End Sub

    Private Sub comboBox_roles_Leave(sender As Object, e As EventArgs) Handles comboBox_roles.Leave

        'Si se ha elegido un elemento se intenta activar el boton guardar
        If comboBox_roles.SelectedIndex <> -1 Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

            'Se seleccionado de nuevo Administrador
            comboBox_roles.SelectedIndex = 0

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

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub
End Class