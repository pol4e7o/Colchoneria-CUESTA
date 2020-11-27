Public Class Pantalla_aniadir_articulo

    'El articulo que se va a añadir
    Public articulo As New GestionComercial.Articulo()


    'LOAD
    Private Sub Pantalla_aniadir_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Colocamos el foco sobre el primer comboBox
        TextBox_nombre.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Todos los botones empiezas desactivados, menos cancelar que se puede pulsar en cualquier momento
        Button_aniadir.Enabled = False
        Button_eliminar.Enabled = False
        Button_guardar.Enabled = False


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

    'VENTA
    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click
        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: " &
               Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")
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
            Gestion_de_ventas.Show()
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

        'Esta variable indicara si el tamaño introducido por teclado es incorrecto 
        '(si no se ha elegido uno de los predefinidos)
        Dim tamanioIncorrecto As Boolean = False

        'La cadena con el precio y el tamaño que se va a añadir a la lista
        Dim precioTamanio As String

        'Auyda para comprobar si el tamaño ha sido repetido
        Dim tamanioRepetido As Boolean = False

        If ListBox_tamanioprecios.Items.Count > 14 Then

            'Si los elementos de la lista sobrepasan 14 no se pueden añadir mas tamaños
            MsgBox("No puede añadir mas tamaños. Si desea puede eliminar uno de los existentes para añadir otro",
                    0 + MsgBoxStyle.Information, "Añadir tamaño")

        Else

            'si el articulo ya tiene tamaños añadidos y el que se va a añadir coincide con el del articulo se le indica al usuario que no lopuede agregar
            If articulo.getTamaniosArticulo.Count > 0 And (articulo.getTamaniosArticulo.Contains(ComboBox_tamanio.Text) Or
                    articulo.getTamaniosArticulo.Contains(ComboBox_tamanio.SelectedItem)) Then

                MsgBox("El tamaño que desea añadir ya existe. Por favor introduzca otro tamaño",
                    0 + MsgBoxStyle.Information, "Añadir tamaño")

                'Se vacia la caja de texto dentro del combobox y se deja sin elemento seleccionado
                ComboBox_tamanio.Text = ""
                ComboBox_tamanio.SelectedIndex = -1

            Else

                'Si para el tamaño se ha escrito uno nuevo (no uno de los predefinidos)
                'y este no es un numero mayor a 0 se le indica al usuario que el tamaño no es correto
                If ComboBox_tamanio.SelectedIndex < 0 And ComboBox_tamanio.Text.Equals("") = False Then

                    If validacion.numeroMayorACero(ComboBox_tamanio.Text) = False Then

                        MsgBox("El tamaño introducido no es correcto. El tamaño tiene que ser un numero mayor a 0",
                                0 + MsgBoxStyle.Information, "Tamaño incorrecto")

                    Else

                        tamanioIncorrecto = True

                    End If

                End If

                'Si el tamaño es correcto se añade junto con el precio a la lista 
                If tamanioIncorrecto = True Or ComboBox_tamanio.SelectedIndex >= 0 Then

                    If ComboBox_tamanio.SelectedIndex >= 0 Then

                        'Si se ha elegido uno de los tamaños predefinidos se utiliza para añaddir a la lista
                        articulo.setTamanioPrecio(CInt(ComboBox_tamanio.SelectedItem), CDbl(TextBox_precio.Text))

                    Else
                        'Sino se utiliza el texto introducido dentro del combobox 
                        articulo.setTamanioPrecio(CInt(ComboBox_tamanio.Text), CDbl(TextBox_precio.Text))

                    End If

                    'Se le asigna a la cadena precioTamanio los que se van a añadir a la lista
                    precioTamanio = "   precio: " & articulo.getPreciosTamaniosArticulo.Item(articulo.getPreciosTamaniosArticulo.Count - 1) & "€" &
                        "        tamaño: " & articulo.getTamaniosArticulo.Item(articulo.getTamaniosArticulo.Count - 1)

                    ListBox_tamanioprecios.Items.Add(precioTamanio)

                    'Se vacian los elementos
                    TextBox_precio.Text = ""
                    ComboBox_tamanio.SelectedIndex = -1

                    'Se desactiva el boton añadir
                    Button_aniadir.Enabled = False

                    activarBotonGuardarAlta()

                End If

            End If

        End If

    End Sub

    'BOTON ELIMINAR
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click

        'Eliminamos el precio y tamaño seleccionados del articulo
        articulo.eliminarTamanioPrecio(ListBox_tamanioprecios.SelectedIndex)

        'Despues se elimina de la lista
        ListBox_tamanioprecios.Items.RemoveAt(ListBox_tamanioprecios.SelectedIndex)

        activarBotonGuardarAlta()

    End Sub

    'BOTON GUARDAR
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea guardar el nuevo cliente 
        Dim opcion As Integer

        'Indica si se ha repetido el nombre de articulo
        Dim nombreRepetido As Boolean = False

        opcion = MsgBox("Esta seguro que desea crear el nuevo artículo?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de artículo")

        If opcion = MsgBoxResult.Yes Then

            'se combrueba si hay otro articulo con el mismo nombre
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(TextBox_nombre.Text) Then

                    nombreRepetido = True

                End If

            Next i

            'si el nombre es igual que a uno de los demas articulos se le indica al usuario
            'y se vacia la caja de texto del nombre y se desactiva el boton de guardar
            If nombreRepetido Then

                MsgBox("El nombre del articulo no puede coincidir con el del resto de articulos. Por favor indique otro nombre",
                        0 + MsgBoxStyle.Information, "Nombre de articulo repetido")

                TextBox_nombre.Text = ""
                Button_guardar.Enabled = False

            Else

                'Se guarda el artículo dentro del fichero de artículos
                Try

                    'Primero se pasan al objeto de tipo articulo que se va a añadir a la lista de articulos
                    articulo.setNombreArticulo(TextBox_nombre.Text)
                    articulo.setCategoriaArticulo(ComboBox_categorias.SelectedItem)
                    articulo.setDescripcionArticulo(TextBox_descripcion.Text)
                    articulo.setCodigoArticulo(articulos.Item(articulos.Count - 1).getCodigoArticulo + 1)

                    'Se abre el fichero
                    FileOpen(2, "Articulos.txt", OpenMode.Random, OpenAccess.Write, , Len(articuloRegistro))

                    'Se pasan los datos del articulo al registro
                    articuloRegistro.categoria = articulo.getCategoriaArticulo
                    articuloRegistro.codigoArticulo = articulo.getCodigoArticulo
                    articuloRegistro.nombre = articulo.getNombreArticulo
                    articuloRegistro.descripcion = articulo.getDescripcionArticulo
                    articuloRegistro.precios = articulo.getPreciosTamaniosArticulo.ToArray
                    articuloRegistro.tamanios = articulo.getTamaniosArticulo.ToArray

                    'Se añade el nuevo articulo al fichero
                    FilePut(2, articuloRegistro, articuloRegistro.codigoArticulo)

                    'Se añade el articulo creado a la lista
                    articulos.Add(articulo)

                    'Se le indica al usuario que se ha añadido el articulo correctamente
                    MsgBox("El articulo ha sido añadido correctamente", 0 + MsgBoxStyle.Information, "Alta de articulo")

                Catch ex As System.IO.FileNotFoundException

                    MsgBox("El fichero ""Articulos.txt"" donde se tiene que almacenar el articulo no se encuentra. " & vbCrLf &
                      "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                      "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Articulos.txt",
                      0 + MsgBoxStyle.Exclamation, "Añadir articulo")

                    Try

                        'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                        FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                        errorRegistro.fecha = DateString
                        errorRegistro.informacionError = Now & " - El fichero ""Articulos.txt"" no se ha encontrado" &
                        vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                        Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                    Catch ex1 As Exception

                        MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                        0 + MsgBoxStyle.Information, "Error no grabado")

                    End Try

                Catch

                    MsgBox("Se ha producido un error a la hora de almacenar el nuevo articulo",
                       0 + MsgBoxStyle.Exclamation, "Añadir articulo")

                    Try

                        'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                        FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                        errorRegistro.fecha = DateString
                        errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""Articulos.txt""" &
                        vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                        Write(3, errorRegistro.fecha, errorRegistro.informacionError)


                    Catch ex1 As Exception

                        MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                                0 + MsgBoxStyle.Information, "Error no grabado")

                    End Try

                End Try

                FileClose()


                'Se vuelve a la pantalla de gestion de artículos
                Pantalla_admin_articulos.Show()
                Me.Close()

            End If


        End If
    End Sub

    'BOTON CANCELAR
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de artículos
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If
    End Sub

    'CATEGORIA
    Private Sub ComboBox_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_categorias.SelectedIndexChanged

        activarBotonGuardarAlta()

    End Sub

    'NOMBRE 
    Private Sub TextBox_nombre_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_nombre.TextChanged

        activarBotonGuardarAlta()

    End Sub

    'COMBOBOX TAMAÑOS CAMBIO DE INDICE
    Private Sub ComboBox_tamanio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tamanio.SelectedIndexChanged
        activarBotonAniadir()
    End Sub

    'COMBOBOX TAMAÑOS CAMBIO DE TEXTO
    Private Sub ComboBox_tamanio_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_tamanio.TextChanged
        activarBotonAniadir()
    End Sub

    'PRECIO VÁLIDO
    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precio.TextChanged

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

        'Se comprueba que todos los campos necesarios están rellenos
        If ListBox_tamanioprecios.SelectedIndex >= 0 Then
            Button_eliminar.Enabled = True
        End If

        activarBotonGuardarAlta()

    End Sub


    '------------------------------------------------------------------------------------------------------------------------------------------
    'ACTIVAR BOTON ANIADIR
    Private Sub activarBotonAniadir()
        Button_aniadir.Enabled = False

        'Se comprueba que todos los campos necesarios están rellenos
        If (ComboBox_tamanio.SelectedIndex >= 0 Or ComboBox_tamanio.Text.Equals("") = False) And TextBox_precio.Text.Length <> 0 Then
            Button_aniadir.Enabled = True
        End If

    End Sub

    'ACTIVAR BOTON GUARDAR
    Private Sub activarBotonGuardarAlta()

        Button_guardar.Enabled = False

        'Se comprueba que todos los campos tienen el tamaño minimo 
        'Si son correctos se activa el boton
        If TextBox_nombre.Text.Length <> 0 Then

            If ComboBox_categorias.SelectedIndex >= 0 Then

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