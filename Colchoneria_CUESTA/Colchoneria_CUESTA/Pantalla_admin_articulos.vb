Public Class Pantalla_admin_articulos



    'CERRAR CAJA
    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) 

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
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) 

        Pantalla_de_venta.Show()
        Me.Hide()

    End Sub

    'SALIR
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
    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: " &
               ElementosComunes.venta & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")
    End Sub

    'ACERCA DE...
    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")
    End Sub

    'AYUDA
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) 

        'Te reenviará a un fichero: Manual de usuario

    End Sub

    'GESTIÓN EMPLEADOS
    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) 

        Pantalla_admin_empleados.Show()
        Me.Hide()

    End Sub

    'GESTIÓN VENTAS
    Private Sub GestiónDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) 

        Pantalla_de_venta.Show()
        Me.Hide()

    End Sub

    'LOAD
    Private Sub Pantalla_admin_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        Button_aniadir.Focus()

        'Se deabilita la opcion gestion de artículos porque es este mismo formulario
        GestiónDeArtículosToolStripMenuItem.Enabled = False

    End Sub

    'BOTONES------------------------------------------------------------------------------------------------------------
    Private Sub Button_aniadir_Click(sender As Object, e As EventArgs)
        'Se llama al formulario de añadir articulo
        Pantalla_aniadir_articulo.Show()
        Me.Hide()
    End Sub

    Private Sub Button_modificar_Click(sender As Object, e As EventArgs)
        'Se llama al formulario de modificar articulo
        Pantalla_modificar_articulos.Show()
        Me.Hide()
    End Sub

    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs)
        'Se llama al formulario de eliminar articulo
        Pantalla_eliminar_articulo.Show()
        Me.Hide()
    End Sub

    'HORA
    Private Sub TimerHoraReal_Tick_1(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub


End Class