Public Class Pantalla_eliminar_articulo

    'El objeto que se va a eliminar
    Public articulo As New GestionComercial.Articulo()

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
        Pantalla_admin_articulos.Show()
        Me.Hide()
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

                    " & ElementosComunes.venta & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")
    End Sub


    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de ventas
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de ventas sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Gestion de ventas")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de ventas y se cierra la de eliminacion de articulo
            Gestion_de_ventas.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de articulos
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de articulos sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Gestion de articulos")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de articulos y se cierra la de eliminacion de articulo
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If

    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Gestion de empleados")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de eliminacion de articulo
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If


    End Sub

    Private Sub GestionDeErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeErroresToolStripMenuItem.Click

        'La opcion elegida por el usuario a la hora de decidir si desea ir a gestion de errores
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea ir a la pantalla de gestion de errores sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Gestion de errores")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de errores y se cierra la de eliminacion de articulo
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

    'LOAD---------------------------------------------------------------------------------------------------------------------------------------
    'Este es el formulario creado para eliminar artículos
    Private Sub Pantalla_eliminar_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El foco lo colocamos sobre el comboBox
        ComboBox_eliminar.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Desabilitamos el boton eliminar
        Button_eliminar.Enabled = False

        Panel_datosArticulo.Enabled = False

        'si no hay ningun elemento àra modificar se le indica al usuario
        If articulos.Count = 0 Then

            MsgBox("No hay ningun articulo para modificar. Para crear uno elija añadir dentro de gestion de articulo",
                    0 + MsgBoxStyle.Information, "Modificar articulos")

            Pantalla_admin_articulos.Show()
            Me.Hide()

        Else

            'Si hay articulos se alamcenan sus nombres dentro del combobox modificar
            For i = 0 To articulos.Count - 1

                ComboBox_eliminar.Items.Add(articulos.Item(i).getNombreArticulo)

            Next

        End If

    End Sub

    'Programamos el botón cancelar
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click

        Select Case MsgBox("Está seguro de que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Salir")
            Case MsgBoxResult.Yes
                Pantalla_admin_articulos.Show()
                Me.Close()
            Case MsgBoxResult.No
        End Select

    End Sub

    'Programamos el botón eliminar
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click

        'Elimina articulo del fichero
        'La opcion elegida por el usuario a la hora de decidir si desea eliminar el articulo
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea eliminar el artículo?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Baja de articulo")

        If opcion = MsgBoxResult.Yes Then


            'Se elimina el articukolo de la lista y se elimina del fichero de articulos
            Try

                'Se abre el fichero
                FileOpen(2, "Articulos.txt", OpenMode.Random, OpenAccess.Write, , Len(articuloRegistro))

                'Se pasan los datos del articulo al registro
                articuloRegistro.categoria = ""
                articuloRegistro.codigoArticulo = articulo.getCodigoArticulo
                articuloRegistro.nombre = ""
                articuloRegistro.descripcion = ""
                articuloRegistro.precios = (New List(Of Double)).ToArray
                articuloRegistro.tamanios = (New List(Of Integer)).ToArray

                'Se sobreescribe el articulo en el fichero
                FilePut(2, articuloRegistro, articuloRegistro.codigoArticulo)

                'Se elimina el articulo de la lista
                articulos.Remove(articulo)

                'Se le indica al usuario que se ha añadido el articulo correctamente
                MsgBox("El articulo ha sido eliminado correctamente", 0 + MsgBoxStyle.Information, "Baja de articulo")

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""Articulos.txt"" donde se tiene que eliminar el articulo no se encuentra. " & vbCrLf &
                      "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                      "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Articulos.txt",
                      0 + MsgBoxStyle.Exclamation, "Baja de articulo")

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

                MsgBox("Se ha producido un error a la hora de eliminar el articulo",
                       0 + MsgBoxStyle.Exclamation, "Baja de articulo")

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

    End Sub

    'HORA
    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub ComboBox_eliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_eliminar.SelectedIndexChanged

        'Si se ha elegido un articulo de los de la lista se activa el boton eliminar
        If ComboBox_eliminar.SelectedIndex >= 0 Then

            'Se vacian los campos de texto
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            TextBox_categoria.Text = ""
            ListBox_tamanios.Items.Clear()
            ListBox_precios.Items.Clear()

            'Se habilita el boton guardar
            Button_eliminar.Enabled = False

            'Se coge el objeto elegido y sus datos se introducen en los campos de texto
            For i = 0 To articulos.Count - 1

                'Cuando se encuentra el articulo que tiene el mismo nombre que este el objeto se asigna a la variable articulo
                If articulos.Item(i).getNombreArticulo.Replace(" ", "").Equals(ComboBox_eliminar.SelectedItem.ToString.Replace(" ", "")) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            'Introducir los datos del articulo
            TextBox_nombre.Text = articulo.getNombreArticulo
            TextBox_descripcion.Text = articulo.getDescripcionArticulo
            TextBox_categoria.Text = articulo.getCategoriaArticulo

            'Se colocan en el listbox todos los tamanios con sus precios que ya tiene el articulo
            If articulo.getTamaniosArticulo.Count > 0 Then

                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    'Se añaden los tamaños con sus precios a las listas
                    ListBox_precios.Items.Add("   precio: " & articulo.getPreciosTamaniosArticulo.Item(i) & "€")
                    ListBox_tamanios.Items.Add("   tamaño: " & articulo.getTamaniosArticulo.Item(i))

                Next i

                'Se habilita el boton guardar
                Button_eliminar.Enabled = True

            End If


        Else

            'Se sesactiva el panel con los datos de articulo
            Panel_datosArticulo.Enabled = False

            'Se vacian los campos de texto
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            TextBox_categoria.Text = ""
            ListBox_tamanios.Items.Clear()
            ListBox_precios.Items.Clear()

            'Se habilita el boton guardar
            Button_eliminar.Enabled = False

        End If

    End Sub

    Private Sub ListBox_tamanios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_tamanios.SelectedIndexChanged
        ListBox_tamanios.SelectedIndex = -1
    End Sub

    Private Sub ListBox_precios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_precios.SelectedIndexChanged
        ListBox_precios.SelectedIndex = -1
    End Sub

End Class