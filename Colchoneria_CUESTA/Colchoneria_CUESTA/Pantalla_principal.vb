﻿Imports System.IO

Public Class Pantalla_principal

    Private Sub Pantalla_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Este boton no es disponible porque no hay mas pantallas
        'antes de esta
        VolverToolStripMenuItem.Visible = False

        'Se utiliza para leer los tamaños de los articulos
        Dim tamanios As New List(Of Integer)

        'Se utiliza para leer los precios de los articulos
        Dim precios As New List(Of Double)

        'LEER VENTA ACTUAL
        Try

            'Se lee del fichero VentaActual la venta 
            FileOpen(5, "VentaActual.txt", OpenMode.Input)

            'Se guarda el valor del fichero en la varibale venta
            Input(5, ElementosComunes.venta)

        Catch ex As System.IO.FileNotFoundException

            MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto el valor de la venta actual es 0" &
                   vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                    "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentaActual.txt",
                    0 + MsgBoxStyle.Exclamation, "Obtener venta")

            ElementosComunes.venta = 0

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

            MsgBox("Se ha producido un error a la hora de obtener la venta hasta este momento. Su valor se establece a 0",
                   0 + MsgBoxStyle.Information, "Obtener venta")

            ElementosComunes.venta = 0

            Try

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de leer el fichero ""VentaActual.txt""" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

            Catch ex1 As Exception

                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

            End Try

        End Try

        'Se cierran todos los ficheros abiertos
        FileClose()

        'Cuando se carga la aplicacion se comprueba si el valor de la variable leida del fichero
        'VentaActual es diferente a 0. Si lo es se le pasa a la variable cajaCerrada false, sino true
        If venta = 0 Then
            ElementosComunes.cajaCerrada = True

        Else
            ElementosComunes.cajaCerrada = False

        End If



        'LEER EMPLEADOS
        Try

            If File.Exists("Empleados.txt") Then

                'Se cargan todos los empleados del fichero de empleados
                FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Read, , Len(empleadoRegistro))

                'Se lee todo su contenido hasta que no se llegue al final del fichero
                While Not EOF(1)

                    'Se recoge el siguente empleado
                    FileGet(1, empleadoRegistro, )

                    'Solo se añaden los que tienen nombre asignado (si se ha eliminado no tendra)
                    If validacion.validarNombres(empleadoRegistro.nombreUsuario) Then

                        'Utilizando el registro recogido se crea un objeto de tipo Empleado y se añade al arraylist
                        empleados.Add(New GestionComercial.Empleado(empleadoRegistro.codigoEmpleado, empleadoRegistro.nombre, empleadoRegistro.apellidos, empleadoRegistro.direccion, empleadoRegistro.codigoPostal,
                                    empleadoRegistro.telefono, empleadoRegistro.nombreUsuario, empleadoRegistro.contrasenia, empleadoRegistro.esAdministrador))


                    End If

                End While

            Else

                'Salta la excepcion de FileNotFoundException si no se ha encontrado el fichero Empleados.txt
                Err.Raise(53)

            End If


        Catch ex As FileNotFoundException

            MsgBox("El fichero ""Empleados.txt"" que contiene los empleados no se encuentra. " & vbCrLf &
                            "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                            "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Empleados.txt",
                             0 + MsgBoxStyle.Exclamation, "Leer empleados")

            Try

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""Empleados.txt"" no se ha encontrado" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose()

                End

            Catch ex1 As Exception

                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

            End Try

        Catch

            MsgBox("Se ha producido un error a la hora de leer los empleados de la empresa. Por favor intente ejecutar el programa de nuevo",
                   0 + MsgBoxStyle.Information, "Leer empleados")

            Try

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de leer el fichero ""Empleados.txt""" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose()

                End

            Catch ex1 As Exception

                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

            End Try

        End Try

        'Se cierran todos los ficheros abiertos
        FileClose()



        'LEER ARTICULOS
        Try

            'Se cargan todos los articulos del fichero de articulos
            FileOpen(2, "Articulos.txt", OpenMode.Random, OpenAccess.Read, , Len(articuloRegistro))

            'Se lee todo su contenido hasta que no se llegue al final del fichero
            While Not EOF(2)

                'Se recoge el siguente articulo
                FileGet(2, articuloRegistro, )

                'Solo se añaden los que tienen nombre asignado (si se ha eliminado no tendra)
                If New GestionComercial.Articulo().posiblesCategoriasArticulo.Contains(articuloRegistro.categoria.Replace(" ", "")) Then

                    'Utilizando el registro recogido se crea un objeto de tipo Articulo y se añade al arraylist
                    articulos.Add(New GestionComercial.Articulo(articuloRegistro.codigoArticulo, articuloRegistro.nombre, articuloRegistro.descripcion,
                                articuloRegistro.categoria))

                    tamanios = articuloRegistro.tamanios.ToList
                    precios = articuloRegistro.precios.ToList

                    If tamanios.Count > precios.Count Then

                        'Se quitan todos los campos que tienen el valor 0 que se le pasa a un campo vacio cuando se guarda en un fichero
                        For i = tamanios.Count - 1 To 0 Step -1

                            If tamanios.Item(i) > 0 Then

                                articulos.Item(articulos.Count - 1).setTamanioPrecio(tamanios.Item(i), precios.Item(i))

                            End If

                        Next i

                    Else

                        'Se quitan todos los campos que tienen el valor 0 que se le pasa a un campo vacio cuando se guarda en un fichero
                        For i = precios.Count - 1 To 0 Step -1

                            If tamanios.Item(i) > 0 Then

                                articulos.Item(articulos.Count - 1).setTamanioPrecio(tamanios.Item(i), precios.Item(i))

                            End If

                        Next i

                    End If



                End If

            End While

        Catch ex As FileNotFoundException

            MsgBox("El fichero ""Articulos.txt"" que contiene los articulos que ofrece la empresa no se encuentra. " & vbCrLf &
                   "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                   "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\Articulos.txt",
                   0 + MsgBoxStyle.Exclamation, "Leer articulos")

            Try

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - El fichero ""Articulos.txt"" no se ha encontrado" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose()

                End

            Catch ex1 As Exception

                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                            0 + MsgBoxStyle.Information, "Error no grabado")

            End Try

        Catch

            MsgBox("Se ha producido un error a la hora de leer los articulos de la empresa. Por favor intente ejecutar el programa de nuevo",
                   0 + MsgBoxStyle.Exclamation, "Leer articulos")

            Try

                'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                errorRegistro.fecha = DateString
                errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de leer el fichero ""Articulos.txt""" &
                    vbCrLf & "Descripcion: " & Err.Description & vbCrLf & "Form: " & Me.Text

                Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                FileClose()

                End

            Catch ex1 As Exception

                MsgBox("El error ocurrido no se ha podido grabar en el fichero de errores",
                        0 + MsgBoxStyle.Information, "Error no grabado")


            End Try

        End Try

        'Se cierran todos los ficheros abiertos
        FileClose()

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub Pantalla_principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        'Si se pulsa un boton del teclado se carga el siguente formulario
        Pantalla_de_inicio.Show()
        Me.Hide()

    End Sub

    Private Sub Pantalla_principal_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        'Si se hace un click con el raton se carga el siguente formulario
        Pantalla_de_inicio.Show()
        Me.Hide()

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
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")


    End Sub

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")

    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click

        'La variable que va a almacenar la opcion elegida del message box
        Dim opcion As Integer

        'Para hacer el cuerre de caja el usuario se tiene que identificar primero.
        'Por lo tanto si el usuario desea cerrar caja se debe llamar a la pantalla de inicio 
        'para poder identificarse 
        opcion = MsgBox("Para poder realizar el cierre de caja primero tiene que identificarse. Desea ser dirigido a la pantalla de inicio de secion?",
                        4 + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Cierre de caja")

        If MsgBoxResult.Yes = opcion Then

            'Se abre la pantalla de inicio y se oculta la principal
            Pantalla_de_inicio.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        'Se llama al fichero que contiene el manual de usuario

    End Sub

End Class
