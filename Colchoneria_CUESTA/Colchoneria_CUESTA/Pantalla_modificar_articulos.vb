Public Class Pantalla_modificar_articulos

    'ARRANCAMOS EL FORMULARIO
    Private Sub Pantalla_modificar_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el foco sobre el comboBox que nos interesa
        ComboBox_modificar.Focus()

        ComboBox_tamanio.Text = ""

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Se desactiva el panel con los datos de articulo hasta que no se elija el articulo que se va a modificar
        Panel_datosArticulo.Enabled = False

        'Comprobar si se puede pulsar el botón modificar
        If (ComboBox_modificar.SelectedIndex < 0) Then
            Button_modificar.Enabled = False
        Else
            Button_modificar.Enabled = True
        End If

        'Comprobar si se puede pulsar el botón aniadir
        Button_aniadir.Enabled = False
        'Comprobar si se puede pulsar el botón aniadir
        Button_eliminar.Enabled = False

    End Sub
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

    Private Sub ComboBox_modificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_modificar.SelectedIndexChanged

        'Si se ha elegido un articulo de los de la lista se activa el boton guardar
        If ComboBox_modificar.SelectedIndex >= 0 Then

            'Se activa el panel con los datos del articulo
            Panel_datosArticulo.Enabled = True

            'Se coge el objeto elegido y sus datos se introducen en los campos de texto

            'Introducir los datos del articulo
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            ComboBox_categorias.SelectedItem = -1
            TextBox_precio.Text = ""
            ComboBox_tamanio.Text = ""
            ListBox_tamaniosprecios.Items.Clear()

            'Se habilita el boton guardar
            Button_modificar.Enabled = True

        Else

            'Se sesactiva el panel con los datos de articulo
            Panel_datosArticulo.Enabled = False

            'Se vacian los campos de texto
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            ComboBox_categorias.SelectedItem = -1
            TextBox_precio.Text = ""
            ComboBox_tamanio.Text = ""
            ListBox_tamaniosprecios.Items.Clear()

            'Se habilita el boton guardar
            Button_modificar.Enabled = False

        End If
    End Sub


    'BOTONES--------------------------------------------------------------------------------------------------------------------------------------------
    'BOTON AÑADIR
    Private Sub Button_aniadir_Click(sender As Object, e As EventArgs) Handles Button_aniadir.Click

        Dim precio As String = TextBox_precio.Text.ToString
        Dim tamanio As String
        Dim a As String

        If ComboBox_tamanio.Text <> "" Then

            tamanio = ComboBox_tamanio.Text

        Else

            tamanio = ComboBox_tamanio.SelectedItem.ToString

        End If

        a = "precio: " + precio + " tamaño: " + tamanio
        ListBox_tamaniosprecios.Items.Add(a)

    End Sub

    'BOTON ELIMINAR
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs)

        'Eliminamos el item seleccionado
        ListBox_tamaniosprecios.Items.RemoveAt(ListBox_tamaniosprecios.SelectedIndex)

        'Se elemina del objeto articulos

    End Sub

    'BOTON MODIFICAR
    Private Sub Button_modificar_Click_1(sender As Object, e As EventArgs) Handles Button_modificar.Click
        'La opcion elegida por el usuario a la hora de decidir si desea guardar el articulo modificado
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea modificar el artículo?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de empleado")

        If opcion = MsgBoxResult.Yes Then

            'Se modifica dentro del arraylist y despues se sobrescribe el fichero de articulos


            'Se vuelve a la pantalla de gestion de empleados
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If
    End Sub
    'BOTON CANCELAR
    Private Sub Button_cancelar_Click_1(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If
    End Sub

    'ACTIVAR MODIFICAR
    Private Sub activarBotonModificar()
        'Se puede modificar siempre aunque no se haya tocado nada
        'Se comprueba que todos los campos tienen el tamaño minimo 
        'Si son correctos se activa el boton
        If TextBox_nombre.Text.Length <> 0 Then

            If ComboBox_categorias.SelectedIndex >= 0 Then

                If ListBox_tamaniosprecios.Items.Count <> 0 Then

                    Button_guardar.Enabled = True

                End If

            End If

        End If
    End Sub

    'ACTIVAR BOTON ANIADIR
    Private Sub activarBotonAniadir()
        Button_aniadir.Enabled = False
        'Se comprueba que todos los campos necesarios están rellenos
        If (ComboBox_tamanio.SelectedItem > 0 Or ComboBox_tamanio.Text <> "") And TextBox_precio.Text.Length <> 0 Then
            Button_aniadir.Enabled = True
        End If
    End Sub

    'HORA
    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub
    '-----------------------------------------------------------------------------------------------------------------
    Private Sub TextBox_nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nombre.Leave
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(TextBox_nombre.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonModificar()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo nombre de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            TextBox_nombre.Focus()

        End If
    End Sub

    'CATEGORIA
    Private Sub ComboBox_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_categorias.SelectedIndexChanged
        activarBotonModificar()
    End Sub


    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precio.Leave
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton añadir
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
    Private Sub ListBox_tamaniosprecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_tamaniosprecios.SelectedIndexChanged
        activarBotonModificar()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    'COMBOBOX TAMAÑOS
    Private Sub ComboBox_tamanio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tamanio.SelectedIndexChanged
        activarBotonModificar()
        activarBotonAniadir()
    End Sub



    Private Sub TextBox_precio_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_precio.TextChanged
        activarBotonModificar()
        activarBotonAniadir()
    End Sub

    Private Sub ComboBox_tamanio_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_tamanio.TextChanged

        'Si se introduce un tamaño nuevo para el articulo este tiene que ser mayor a 0
        'Si no lo es se le indica al usuario mediante un message box y se limpia la caja de texto del combobox
        'Tambien se dactiva el boton añadir
        If validacion.numeroMayorACero(ComboBox_tamanio.Text) = False Then

            MsgBox("El tamaño del articulo no puede ser mneor o igual a 0. Por favor indique un tamaño correcto o elija uno de los ya definidos de la lista", 0 + MsgBoxStyle.Information, "Tamaño incorrecto")

            ComboBox_tamanio.Text = ""

            Button_aniadir.Enabled = False

        End If
    End Sub
End Class