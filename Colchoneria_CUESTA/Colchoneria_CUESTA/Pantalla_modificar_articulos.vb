Public Class Pantalla_modificar_articulos

    'El articulo que se va a modificar
    Public articulo As New GestionComercial.Articulo()

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
        Button_modificar.Enabled = False

        'Comprobar si se puede pulsar el botón aniadir
        Button_aniadir.Enabled = False
        'Comprobar si se puede pulsar el botón aniadir
        Button_eliminar.Enabled = False

        'si no hay ningun elemento àra modificar se le indica al usuario
        If articulos.Count = 0 Then

            MsgBox("No hay ningun articulo para modificar. Para crear uno elija añadir dentro de gestion de articulo",
                    0 + MsgBoxStyle.Information, "Modificar articulos")

            Pantalla_admin_articulos.Show()
            Me.Close()

        Else

            'Si hay articulos se alamcenan sus nombres dentro del combobox modificar
            For i = 0 To articulos.Count - 1

                ComboBox_modificar.Items.Add(articulos.Item(i).getNombreArticulo)

            Next

            'Se habilita el boton guardar
            Button_modificar.Enabled = False


        End If

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

    'VOLVER
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de articulos
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de articulos sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

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
            Gestion_de_ventas.Show()
            Me.Close()

        End If
    End Sub

    Private Sub GestionDeErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeErroresToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de errores
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de errores sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de errores y se cierra la de alta de empleado
            Gestion_de_errores.Show()
            Me.Close()

        End If

    End Sub

    'ACERCA DE...
    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click
        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")
    End Sub

    'AYUDA
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        'Te reenviará a un fichero: Manual de usuario
    End Sub

    'COMBOBOX MODIFICAR CAMBIO DE INDICE
    Private Sub ComboBox_modificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_modificar.SelectedIndexChanged

        'Se utilizan para copiar los valores del articulo seleccionado
        Dim tamanios As New List(Of Integer)
        Dim precios As New List(Of Double)

        'Si se ha elegido un articulo de los de la lista se activa el boton guardar
        If ComboBox_modificar.SelectedIndex >= 0 Then

            'Se vacian los campos de texto
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            ComboBox_categorias.SelectedIndex = -1
            TextBox_precio.Text = ""
            ComboBox_tamanio.Text = ""
            ListBox_tamanios.Items.Clear()
            ListBox_precios.Items.Clear()

            'Se habilita el boton guardar
            Button_modificar.Enabled = False

            'Se activa el panel con los datos del articulo
            Panel_datosArticulo.Enabled = True


            'Se coge el objeto elegido y sus datos se introducen en los campos de texto
            For i = 0 To articulos.Count - 1

                'Cuando se encuentra el articulo que tiene el mismo nombre que este el objeto se asigna a la variable articulo
                If articulos.Item(i).getNombreArticulo.Replace(" ", "").Equals(ComboBox_modificar.SelectedItem.ToString.Replace(" ", "")) Then

                    'Se copian todos los tamanios y precios en otras listas que se van a pasar al objeto creado para ser modificado
                    For j = 0 To articulos.Item(i).getTamaniosArticulo.Count - 1

                        tamanios.Add(articulos.Item(i).getTamaniosArticulo(j))
                        precios.Add(articulos.Item(i).getPreciosTamaniosArticulo(j))

                    Next j

                    'Se hace la copia de los datos del articulo elegido
                    articulo.setCodigoArticulo(articulos.Item(i).getCodigoArticulo)
                    articulo.setCategoriaArticulo(articulos.Item(i).getCategoriaArticulo)
                    articulo.setDescripcionArticulo(articulos.Item(i).getDescripcionArticulo)
                    articulo.setNombreArticulo(articulos.Item(i).getNombreArticulo)
                    articulo.setTamaniosPrecios(tamanios, precios)

                End If

            Next i

            'Introducir los datos del articulo
            TextBox_nombre.Text = articulo.getNombreArticulo
            TextBox_descripcion.Text = articulo.getDescripcionArticulo

            'Se busca el valor que coincide con la categoria del articulo
            Select Case articulo.getCategoriaArticulo.Replace(" ", "")

                Case ComboBox_categorias.Items(0)

                    'Base
                    'Se selecciona la categoria correspondiente
                    ComboBox_categorias.SelectedIndex = 0

                Case ComboBox_categorias.Items(1)

                    'Somier
                    'Se selecciona la categoria correspondiente
                    ComboBox_categorias.SelectedIndex = 1

                Case ComboBox_categorias.Items(2)

                    'Colchon
                    'Se selecciona la categoria correspondiente
                    ComboBox_categorias.SelectedIndex = 2

                Case ComboBox_categorias.Items(3)

                    'Canape
                    'Se selecciona la categoria correspondiente
                    ComboBox_categorias.SelectedIndex = 3

                Case ComboBox_categorias.Items(4)

                    'Ofertas
                    'Se selecciona la categoria correspondiente
                    ComboBox_categorias.SelectedIndex = 4

                Case Else

                    'Otros
                    'Se selecciona la categoria correspondiente
                    ComboBox_categorias.SelectedIndex = 5

            End Select

            'Se colocan en el listbox todos los tamanios con sus precios que ya tiene el articulo
            If articulo.getTamaniosArticulo.Count > 0 Then

                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    'Se añaden el precio y el tamaño a la lista
                    ListBox_tamanios.Items.Add("    tamaño: " & articulo.getTamaniosArticulo.Item(i))
                    ListBox_precios.Items.Add("    precio: " & articulo.getPreciosTamaniosArticulo.Item(i) & "€")


                Next i

                'Se habilita el boton guardar
                Button_modificar.Enabled = True

            End If


        Else

            'Se sesactiva el panel con los datos de articulo
            Panel_datosArticulo.Enabled = False

            'Se vacian los campos de texto
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            ComboBox_categorias.SelectedIndex = -1
            TextBox_precio.Text = ""
            ComboBox_tamanio.Text = ""
            ListBox_tamanios.Items.Clear()
            ListBox_precios.Items.Clear()

            'Se habilita el boton guardar
            Button_modificar.Enabled = False

        End If
    End Sub


    'BOTONES--------------------------------------------------------------------------------------------------------------------------------------------
    'BOTON AÑADIR
    Private Sub Button_aniadir_Click(sender As Object, e As EventArgs) Handles Button_aniadir.Click

        'Esta variable indicara si el tamaño introducido por teclado es incorrecto 
        '(si no se ha elegido uno de los predefinidos)
        Dim tamanioCorrecto As Boolean = False

        Dim precioCorrecto As Boolean = False

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton añadir
        If validacion.esNumero(TextBox_precio.Text) Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If validacion.numeroMayorACero(TextBox_precio.Text) = False Then

                MsgBox("Por favor introduzca de precio, que sea superior a 0€.",
                       0 + MsgBoxStyle.Information, "Precio incorrecto")

                TextBox_precio.Text = ""
                TextBox_precio.Focus()

            Else

                precioCorrecto = True

            End If

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de contraseña
            MsgBox("Por favor introduzca de precio, que solo sean números.",
                   0 + MsgBoxStyle.Information, "Precio incorrecto")

            TextBox_precio.Text = ""
            TextBox_precio.Focus()

        End If

        If ListBox_tamanios.Items.Count > 14 Then

            'Si los elementos de la lista sobrepasan 14 no se pueden añadir mas tamaños
            MsgBox("No puede añadir mas tamaños. Si desea puede eliminar uno de los existentes para añadir otro",
                    0 + MsgBoxStyle.Information, "Añadir tamaño")

            'Se vacia la caja de texto dentro del combobox y se deja sin elemento seleccionado
            ComboBox_tamanio.Text = ""
            ComboBox_tamanio.SelectedIndex = -1
            TextBox_precio.Text = ""

        Else

            'Si para el tamaño se ha escrito uno nuevo (no uno de los predefinidos)
            'y este no es un numero mayor a 0 se le indica al usuario que el tamaño no es correto
            If ComboBox_tamanio.SelectedIndex < 0 And ComboBox_tamanio.Text.Equals("") = False Then

                If validacion.numeroMayorACero(ComboBox_tamanio.Text) = False Then

                    MsgBox("El tamaño introducido no es correcto. El tamaño tiene que ser un numero mayor a 0",
                                0 + MsgBoxStyle.Information, "Tamaño incorrecto")

                    'Se vacia la caja de texto dentro del combobox y se deja sin elemento seleccionado
                    ComboBox_tamanio.Text = ""
                    ComboBox_tamanio.SelectedIndex = -1
                    ComboBox_tamanio.Focus()

                Else

                    tamanioCorrecto = True

                    'si el articulo ya tiene tamaños añadidos y el que se va a añadir coincide con el del articulo se le indica al usuario que no lopuede agregar
                    If articulo.getTamaniosArticulo.Count > 0 And (articulo.getTamaniosArticulo.Contains(ComboBox_tamanio.Text) Or
                            articulo.getTamaniosArticulo.Contains(ComboBox_tamanio.SelectedItem)) Then

                        MsgBox("El tamaño que desea añadir ya existe. Por favor introduzca otro tamaño",
                            0 + MsgBoxStyle.Information, "Añadir tamaño")

                        'Se vacia la caja de texto dentro del combobox y se deja sin elemento seleccionado
                        ComboBox_tamanio.Text = ""
                        ComboBox_tamanio.SelectedIndex = -1
                        ComboBox_tamanio.Focus()

                        tamanioCorrecto = False

                    End If

                End If
            End If


            'Si el tamaño y el precio son correctos se añaden a la lista
            If precioCorrecto And (tamanioCorrecto = True Or ComboBox_tamanio.SelectedIndex >= 0) Then

                If ComboBox_tamanio.SelectedIndex >= 0 Then

                    'Si se ha elegido uno de los tamaños predefinidos se utiliza para añaddir a la lista
                    articulo.setTamanioPrecio(CInt(ComboBox_tamanio.SelectedItem), CDbl(TextBox_precio.Text))

                Else
                    'Sino se utiliza el texto introducido dentro del combobox 
                    articulo.setTamanioPrecio(CInt(ComboBox_tamanio.Text), CDbl(TextBox_precio.Text))

                End If

                'Se añaden el precio y el tamaño a la lista
                ListBox_tamanios.Items.Add("    tamaño: " & articulo.getTamaniosArticulo.Item(articulo.getTamaniosArticulo.Count - 1))
                ListBox_precios.Items.Add("    precio: " & articulo.getPreciosTamaniosArticulo.Item(articulo.getPreciosTamaniosArticulo.Count - 1) & "€")

                'Se vacian los elementos y se pasa el foco al precio
                TextBox_precio.Text = ""
                ComboBox_tamanio.Text = ""
                ComboBox_tamanio.SelectedIndex = -1
                TextBox_precio.Focus()

                'Se desactiva el boton añadir
                Button_aniadir.Enabled = False

                activarBotonModificar()

            End If

        End If

    End Sub

    'BOTON ELIMINAR
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click

        Dim index As Integer

        While ListBox_tamanios.SelectedIndex >= 0

            index = ListBox_tamanios.SelectedIndex

            'Eliminamos el precio y tamaño seleccionados del articulo
            articulo.eliminarTamanioPrecio(index)

            'Eliminamos el item seleccionado
            ListBox_precios.Items.RemoveAt(index)
            ListBox_tamanios.Items.RemoveAt(index)

        End While

    End Sub

    'BOTON MODIFICAR
    Private Sub Button_modificar_Click_1(sender As Object, e As EventArgs) Handles Button_modificar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea guardar el articulo modificado
        Dim opcion As Integer

        'Indica si se ha repetido el nombre de articulo
        Dim nombreRepetido As Boolean = False

        opcion = MsgBox("Esta seguro que desea modificar el artículo?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Modificacion de articulo")

        If opcion = MsgBoxResult.Yes Then

            'se combrueba si hay otro articulo con el mismo nombre
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(TextBox_nombre.Text) And articulo.getCodigoArticulo <> articulos.Item(i).getCodigoArticulo Then

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

                'Se modifica dentro del arraylist y despues se sobrescribe el fichero de articulos
                Try

                    'Primero se pasan al objeto de tipo articulo que se va a añadir a la lista de articulos
                    articulo.setNombreArticulo(TextBox_nombre.Text)
                    articulo.setCategoriaArticulo(ComboBox_categorias.SelectedItem)
                    articulo.setDescripcionArticulo(TextBox_descripcion.Text)

                    'Se abre el fichero
                    FileOpen(2, "Articulos.txt", OpenMode.Random, OpenAccess.Write, , Len(articuloRegistro))

                    'Se pasan los datos del articulo al registro
                    articuloRegistro.categoria = articulo.getCategoriaArticulo
                    articuloRegistro.codigoArticulo = articulo.getCodigoArticulo
                    articuloRegistro.nombre = articulo.getNombreArticulo
                    articuloRegistro.descripcion = articulo.getDescripcionArticulo
                    articuloRegistro.precios = articulo.getPreciosTamaniosArticulo.ToArray
                    articuloRegistro.tamanios = articulo.getTamaniosArticulo.ToArray

                    'Se modifica el articulo en el fichero
                    FilePut(2, articuloRegistro, articuloRegistro.codigoArticulo)

                    'Se modifica dentro de la lista y del el fichero de articulos
                    For i = 0 To articulos.Count - 1

                        'Si los dos codigos son iguales se modifica en la lista
                        If articulos.Item(i).getCodigoArticulo = articulo.getCodigoArticulo Then


                            'Se añade el articulo creado a la lista
                            articulos.Item(i) = articulo

                        End If

                    Next i


                    'Se le indica al usuario que se ha añadido el articulo correctamente
                    MsgBox("El articulo ha sido modificado correctamente", 0 + MsgBoxStyle.Information, "Modificacion de articulo")

                Catch ex As System.IO.FileNotFoundException

                    MsgBox("El fichero ""Articulos.txt"" donde se tiene que modificar el articulo no se encuentra. " & vbCrLf &
                      "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                      "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Articulos.txt",
                      0 + MsgBoxStyle.Exclamation, "Modificacion de articulo")

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

                    MsgBox("Se ha producido un error a la hora de modificar el articulo",
                       0 + MsgBoxStyle.Exclamation, "Modificar articulo")

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

                If ListBox_tamanios.Items.Count <> 0 Then

                    Button_modificar.Enabled = True

                End If

            End If

        End If
    End Sub

    'ACTIVAR BOTON ANIADIR
    Private Sub activarBotonAniadir()
        Button_aniadir.Enabled = False

        'Se comprueba que todos los campos necesarios están rellenos
        If (ComboBox_tamanio.SelectedItem >= 0 Or ComboBox_tamanio.Text.Equals("") = False) And TextBox_precio.Text.Length <> 0 Then
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

        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonModificar()


    End Sub

    'CATEGORIA
    Private Sub ComboBox_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_categorias.SelectedIndexChanged
        activarBotonModificar()
    End Sub



    'COMBOBOX TAMAÑOS
    Private Sub ComboBox_tamanio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tamanio.SelectedIndexChanged

        activarBotonAniadir()

    End Sub



    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precio.TextChanged

        activarBotonAniadir()

    End Sub

    Private Sub ComboBox_tamanio_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_tamanio.TextChanged

        activarBotonAniadir()

    End Sub

    'LISTBOX TAMANIOS
    Private Sub ListBox_tamanios_manejo(sender As Object, e As EventArgs) Handles ListBox_tamanios.MouseClick

        'Se comprueba que todos los campos necesarios están rellenos

        If ListBox_tamanios.SelectedIndex >= 0 Then
            Button_eliminar.Enabled = True
        End If



        'Se los indices de los dos listbox son diferentes se pasan los de listbox de tamanios al de precios
        If ListBox_precios.SelectedIndices.Equals(ListBox_tamanios.SelectedIndices) = False Then

            'Primero se eliminan todos los selecionados dentro de listbox de precios
            ListBox_precios.ClearSelected()

            'Se pasan por todos los indices de listbox de tamaños y se añaden al de listbox de precios
            For i = 0 To ListBox_tamanios.SelectedIndices.Count - 1

                ListBox_precios.SelectedIndex = ListBox_tamanios.SelectedIndices.Item(i)

            Next i

        End If

        activarBotonModificar()

    End Sub

    'LISTBOX PRECIOS
    Private Sub ListBox_precios_manejo(sender As Object, e As EventArgs) Handles ListBox_precios.MouseClick

        'Se comprueba que todos los campos necesarios están rellenos
        If ListBox_tamanios.SelectedIndex >= 0 Then
            Button_eliminar.Enabled = True
        End If

        'Se le pasa el mismo indice al otro listbox si no lo tiene ya
        If ListBox_precios.SelectedIndex <> ListBox_tamanios.SelectedIndex Then
            ListBox_tamanios.SelectedIndex = ListBox_precios.SelectedIndex

        End If

        activarBotonModificar()

    End Sub

    Private Sub ListBox_tamanios_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox_tamanios.KeyDown

        'esta es la posicion del listbox
        Dim posicionElegida As Integer = ListBox_tamanios.SelectedIndex

        'Se dejan los dos listbox sin elementos elegidos 
        ListBox_precios.ClearSelected()
        ListBox_tamanios.ClearSelected()

        If e.KeyCode = Keys.Up Then

            'Aqui se indica que tiene que elegir el elemento que va antes del elegido actualmente 
            'exepto que este es el primer elemento
            If ListBox_tamanios.SelectedIndex > 0 Then

                'A la posicion actual se le resta 1 y se asigna el resultado a la variable posicionElegida
                posicionElegida = posicionElegida - 1

                'Se les asigna la misma posicion que es la nueva
                ListBox_precios.SelectedIndex = posicionElegida
                ListBox_tamanios.SelectedIndex = posicionElegida

            End If

        ElseIf (e.KeyCode = Keys.Down) Then

            'Aqui se indica que tiene que elegir el siguiente elemento despues del elegido actualmente 
            'exepto que haya llegado al final de la lista
            If ListBox_tamanios.SelectedIndex < ListBox_tamanios.Items.Count - 1 Then

                'A la posicion actual se le suma 1 y se asigna el resultado a la variable posicionElegida
                posicionElegida = posicionElegida + 1

                'Se les asigna la misma posicion que es la nueva
                ListBox_precios.SelectedIndex = posicionElegida
                ListBox_tamanios.SelectedIndex = posicionElegida


            End If

        End If

    End Sub

    Private Sub ListBox_precios_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox_precios.KeyDown

        'esta es la posicion del listbox
        Dim posicionElegida As Integer = ListBox_precios.SelectedIndex

        'Se dejan los dos listbox sin elementos elegidos 
        ListBox_precios.ClearSelected()
        ListBox_tamanios.ClearSelected()

        If e.KeyCode = Keys.Up Then

            'Aqui se indica que tiene que elegir el elemento que va antes del elegido actualmente 
            'exepto que este es el primer elemento
            If ListBox_precios.SelectedIndex > 0 Then

                'A la posicion actual se le resta 1 y se asigna el resultado a la variable posicionElegida
                posicionElegida = posicionElegida - 1

                'Se les asigna la misma posicion que es la nueva
                ListBox_precios.SelectedIndex = posicionElegida
                ListBox_tamanios.SelectedIndex = posicionElegida

            End If

        ElseIf (e.KeyCode = Keys.Down) Then

            'Aqui se indica que tiene que elegir el siguiente elemento despues del elegido actualmente 
            'exepto que haya llegado al final de la lista
            If ListBox_precios.SelectedIndex < ListBox_precios.Items.Count - 1 Then

                'A la posicion actual se le suma 1 y se asigna el resultado a la variable posicionElegida
                posicionElegida = posicionElegida + 1

                'Se les asigna la misma posicion que es la nueva
                ListBox_precios.SelectedIndex = posicionElegida
                ListBox_tamanios.SelectedIndex = posicionElegida


            End If

        End If

    End Sub


End Class