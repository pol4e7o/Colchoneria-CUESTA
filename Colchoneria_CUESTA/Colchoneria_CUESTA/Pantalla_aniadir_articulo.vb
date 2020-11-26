Public Class Pantalla_aniadir_articulo
    'El arraylist donde se van a guardar temporalmente los articulos
    Public articulos As ArrayList


    'LOAD
    Private Sub Pantalla_aniadir_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el foco sobre el primer comboBox
        TextBox_nombre.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Si no hay nada seleccionado en precio y tamaño no puede pulsarse
        If (ListBox_tamanios.SelectedItem < 0 & TextBox_precio.Text.CompareTo("")) Then
            Button_aniadir.Enabled = False
        Else
            Button_aniadir.Enabled = True
        End If

        'Si no hay nada seleccionado en tamaños y precios añadidos, no puede eliminarse nada
        If (ListBox_tamanioprecios.SelectedItem < 0) Then
            Button_aniadir.Enabled = False
        Else
            Button_aniadir.Enabled = True
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------------
    'MENU
    'CERRAR CAJA
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

                'Se cierra el fichero
                FileClose(5)

                End

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto no se ha podido guadrar el valor de la venta hasta este momento" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentaActual.txt",
                            0 + MsgBoxStyle.Exclamation)

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado"

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose(3)

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.", 0 + MsgBoxStyle.Information)


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt"""

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose(3)

            End Try





            Try

                'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario
                FileOpen(4, "VentasDiarias.txt", OpenMode.Append)

                ventaRegistro.fecha = DateString
                ventaRegistro.informacionVenta = informe

                'Se cierra el fichero
                FileClose(4)

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentasDiarias.txt"" no se encuentra por lo tanto no se ha podido guadrar el informe de cierre de caja" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentasDiarias.txt",
                            0 + MsgBoxStyle.Exclamation)


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentasDiarias.txt"" no se ha encontrado"

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose(3)

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar el informe de cierre de caja.", 0 + MsgBoxStyle.Information)


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentasDiarias.txt"""

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose(3)

            End Try

        End If



    End Sub

    'VOLVER
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de alta de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If


    End Sub

    'SALIR
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

                'Se cierra el fichero
                FileClose(5)

                End

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto no se ha podido guadrar el valor de la venta hasta este momento" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentaActual.txt",
                            0 + MsgBoxStyle.Exclamation)

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado"

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose(3)

                'Se le pregunta al usuario si desea salir igualmente
                opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

                If MsgBoxResult.Yes = opcion Then
                    End
                End If

            Catch

                MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.", 0 + MsgBoxStyle.Information)


                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentaActual.txt"""

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose(3)

                'Se le pregunta al usuario si desea salir igualmente
                opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

                If MsgBoxResult.Yes = opcion Then
                    End
                End If

            End Try

        End If

    End Sub

    'VENTA
    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")
    End Sub
    'OPCIONES
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

            Me.Close()

        End If
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




    'BOTON AÑADIR
    Private Sub Button_aniadir_Click(sender As Object, e As EventArgs) Handles Button_aniadir.Click
        Dim precio As String
        precio = TextBox_precio.Text.ToString
        Dim tamanio As String
        tamanio = ListBox_tamanios.SelectedItem.ToString
        Dim a As String = "precio: " + precio + " tamaño: " + tamanio
        ListBox_tamanioprecios.Items.Add(a)

    End Sub
    'BOTON ELIMINAR
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        'Eliminamos el item seleccionado
        ListBox_tamanioprecios.ClearSelected()

    End Sub
    'BOTON GUARDAR
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        'La opcion elegida por el usuario a la hora de decidir si desea guardar el nuevo cliente 
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea crear el nuevo artículo?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de artículo")

        If opcion = MsgBoxResult.Yes Then

            'Se guarda el artículo dentro del fichero de empleados


            'Se vuelve a la pantalla de gestion de empleados
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If
    End Sub
    'BOTON CANCELAR
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If
    End Sub

    'CATEGORIA
    Private Sub ComboBox_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_categorias.SelectedIndexChanged
        activarBotonGuardarAlta()
    End Sub

    'NOMBRE VALIDADO
    Private Sub TextBox_nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nombre.Leave


        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(TextBox_nombre.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            'activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo nombre de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            TextBox_nombre.Focus()

        End If



    End Sub


    'LISTBOX TAMAÑOS
    Private Sub ListBox_precios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_tamanios.SelectedIndexChanged
        activarBotonAniadir()
    End Sub
    'PRECIO VÁLIDO
    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precio.Leave
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.esNumero(TextBox_precio.Text) Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If validacion.numeroMayorACero(TextBox_precio.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonAniadir()
            Else
                MsgBox("Por favor introduzca de precio, que sea superior a 0€.", 0 + MsgBoxStyle.Information, "Precio incorrecto")
                TextBox_precio.Focus()

            End If

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de contraseña
            MsgBox("Por favor introduzca de precio, que solo sean números.", 0 + MsgBoxStyle.Information, "Precio incorrecto")
            TextBox_precio.Focus()

        End If
    End Sub

    'LISTBOX PRECIOTAMAÑO
    Private Sub ListBox_tamanioprecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_tamanioprecios.SelectedIndexChanged
        activarBotonEliminar()
    End Sub


    '------------------------------------------------------------------------------------------------------------------------------------------
    'ACTIVAR BOTON ANIADIR
    Private Sub activarBotonAniadir()
        Button_aniadir.Enabled = False
        'Se comprueba que todos los campos necesarios están rellenos
        If ListBox_tamanios.SelectedItem And TextBox_precio.Text.Length <> 0 Then
            Button_aniadir.Enabled = True
        End If
    End Sub
    'ACTIVAR BOTON ELIMINAR
    Private Sub activarBotonEliminar()
        Button_eliminar.Enabled = False
        'Se comprueba que todos los campos necesarios están rellenos
        If ListBox_tamanioprecios.SelectedItem Then
            Button_aniadir.Enabled = True
        End If

    End Sub

    'ACTIVAR BOTON GUARDAR
    Private Sub activarBotonGuardarAlta()

        Button_guardar.Enabled = False

        'Se comprueba que todos los campos tienen el tamaño minimo 
        'Si son correctos se activa el boton
        If TextBox_nombre.Text.Length <> 0 Then

            If ComboBox_categorias.SelectedItem < 0 Then

                If ListBox_tamanioprecios.Items.Count <> 0 Then

                    Button_guardar.Enabled = True

                End If

            End If

        End If

    End Sub



    'HORA
    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub


End Class