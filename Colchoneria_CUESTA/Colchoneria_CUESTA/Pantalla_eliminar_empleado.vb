Public Class Pantalla_eliminar_empleado

    'El objeto que se va a eliminar
    Private empleado As New GestionComercial.Empleado()

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

        'Por defecto el panel con los datos personales esta desactivado
        panel_elementosEmpleado.Enabled = False

        'Se cargan todos los nombres de usuarios de los empleados en el comboBox_elegirEmpleado
        For i = 0 To empleados.Count - 1

            comboBox_elegirEmpleado.Items.Add(empleados.Item(i).getNombreUsuario)

        Next i

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

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.",
                       0 + MsgBoxStyle.Information, "Guadrar venta actual")


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

    Private Sub comboBox_elegirEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_elegirEmpleado.SelectedIndexChanged

        'Si se ha elegido un empleado de los de la lista se activa el boton eliminar
        If comboBox_elegirEmpleado.SelectedIndex <> -1 Then

            'Se coge el objeto elegido y sus datos se introducen en los campos de texto
            'en modo visualizar (ReadOnly)

            panel_elementosEmpleado.Enabled = True

            'Se busca el empleado elegido
            For i = 0 To empleados.Count - 1

                'Si los nombres de usuario son iguales se pasan todos los datos de este empleado al las cajas de texto
                If comboBox_elegirEmpleado.SelectedItem.Equals(empleados.Item(i).getNombreUsuario) Then

                    empleado = empleados.Item(i)

                    textBox_nombre.Text = empleado.getNombreEmpleado
                    textBox_apellidos.Text = empleado.getApellidos
                    textBox_direccion.Text = empleado.getDireccion
                    textBox_codigoPostal.Text = empleado.getCodigoPostal
                    textBox_telefono.Text = empleado.getTelefono
                    textBox_nombreUsuario.Text = empleado.getTelefono.Replace(" ", "")
                    textBox_nombreUsuario.Text = empleado.getNombreUsuario

                    'Si esAdinistrador es true se selecciona en el combobox el elemento con posicion 0
                    If empleado.getEsAdministrador Then

                        comboBox_roles.SelectedIndex = 0

                    Else

                        'Sino se le asigna 1
                        comboBox_roles.SelectedIndex = 1

                    End If

                End If

            Next i


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

        If empleado.getCodigoEmpleado = 1 Then

            'Es el administrador general. El no se puede eliminar
            MsgBox("El administrador general no se puede eliminar", 0 + MsgBoxStyle.Information, "Eliminar empleado")

        Else

            opcion = MsgBox("Esta seguro que desea eliminar el empleado?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Baja de empleado")

            If opcion = MsgBoxResult.Yes Then

                'Se elimina el empleado de la lista y del fichero de empleados
                empleadoRegistro.nombre = ""
                empleadoRegistro.apellidos = ""
                empleadoRegistro.direccion = ""
                empleadoRegistro.codigoPostal = ""
                empleadoRegistro.telefono = ""
                empleadoRegistro.nombreUsuario = ""
                empleadoRegistro.contrasenia = 0
                empleadoRegistro.esAdministrador = False

                Try

                    'Se abre el fichero Empleados.txt para eliminar el empleado
                    FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Write, , Len(empleadoRegistro))

                    'Se almacena el nuevo empleado en la posicion igual que el codigo de empleado
                    FilePut(1, empleadoRegistro, empleadoRegistro.codigoEmpleado)

                    'Se notifica al usuario que la operacion se ha realiado con exito
                    MsgBox("El empleado se ha eliminado correctamente", 0 + MsgBoxStyle.Information, "Baja de empleado")

                    'Se elimina de la lista
                    empleados.Remove(empleado)

                Catch ex As System.IO.FileNotFoundException

                    MsgBox("El fichero ""Empleados.txt"" no se ha posido encontrar por lo tanto no se ha podido eliminar el empleado. " & vbCrLf &
                                        "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                                        "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Empleados.txt",
                                       0 + MsgBoxStyle.Exclamation, "Eliminar empleado")

                    'Se elimina de la lista
                    empleados.Remove(empleado)

                    'Se le asigna nothing(null) a la variable empleado
                    empleado = Nothing


                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - El fichero ""Empleados.txt"" no se ha encontrado" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                Catch

                    MsgBox("Se ha producido un error a la hora de eliminar al empleado. Por favor intentelo de nuevo",
                                       0 + MsgBoxStyle.Information, "Eliminar empleado")

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de eliminar un empleado del fichero ""Empleados.txt""" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                    'Se elimina de la lista
                    empleados.Remove(empleado)

                    'Se le asigna nothing(null) a la variable empleado
                    empleado = Nothing

                End Try

                'Se cierra los ficheros
                FileClose()

                'Se vuelve a la pantalla de gestion de empleados
                Pantalla_admin_empleados.Show()
                Me.Close()

            End If

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
                            0 + MsgBoxStyle.Exclamation, "Guardar venta actual")

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.",
                           0 + MsgBoxStyle.Information, "Guardar venta actual")


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt""" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

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


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentasDiarias.txt"" no se ha encontrado" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar el informe de cierre de caja.",
                           0 + MsgBoxStyle.Information, "Guardar informe de cierre de caja")


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentasDiarias.txt""" &
                vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            End Try

            'Se cierran todos los ficheros abiertos
            FileClose()

        End If

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

End Class