
Imports System.IO

Public Class Gestion_de_ventas

    'Esta lista representa la fecha en la que se han hecho los cierres de caja 
    Public informesFechas As New List(Of String)

    'Esta lista guardara la informacion sobre el cierre de caja
    Public informesInformacion As New List(Of String)

    'LOAD
    Private Sub Gestion_de_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Indica si se ha repetido alguna fecha a la hora de leer el cotenido del fichero de ventas
        Dim fechaRepetida As Boolean = False

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'El primer elemento que tendra el foco es el textBox del usuario
        ComboBox_dia.Focus()

        'Se desabilita la opcion que corresponde a la pantalla actual
        GestionDeVentasToolStripMenuItem.Enabled = False

        'El boton de visualizar por defecto se deja desactivado. Se activa si se selecciona una fecha en el combobox
        Button_visualizar.Enabled = False

        'En el label indicamos la fecha y la hora actual con la venta en este momento
        Label_ventaActual.Text = "Venta en el dia " & DateString & " a las " & TimeString & " es: " & venta & "€"

        Try

            'Se carga la lista de informes del fichero de ventas
            FileOpen(4, "VentasDiarias.txt", OpenMode.Input)

            'Se lee todo el contenido del fichero se guarda en las dos listas
            While EOF(4)

                Input(4, ventaRegistro.fecha)
                Input(4, ventaRegistro.informacionVenta)

                'Se añade al combobox la fecha nuevo (solo si no esta en la lista ya)
                'Para eso se comprueba primero si esta fecha ya existe
                'Si no existe se añade al combobox
                For i = 0 To informesFechas.Count - 1

                    If informesFechas.Item(i).Equals(ventaRegistro.fecha) Then

                        fechaRepetida = True

                    End If

                Next i

                If fechaRepetida = False Then

                    ComboBox_dia.Items.Add(ventaRegistro.fecha)

                End If

                informesFechas.Add(ventaRegistro.fecha)
                informesInformacion.Add(ventaRegistro.informacionVenta)

                'Se asigna false a la variable para poder comprobar la siguiente fecha leida
                fechaRepetida = False

            End While

        Catch ex As System.IO.FileNotFoundException

            MsgBox("El fichero ""VentasDiarias.txt"" no se encuentra por lo tanto no se ha podido leer los informes de cierre de caja" &
           vbCrLf & "Por favor compruebe que el fichero esta en la carpeta de la aplicacion Colchoneria CUESTA. " & vbCrLf &
                    "Ejemplo: Carpeta que contiene la carpeta del programa\Colchoneria-CUESTA\Colchoneria_CUESTA\Colchoneria_CUESTA\bin\Debug\VentasDiarias.txt",
                    0 + MsgBoxStyle.Exclamation, "Leer los informes de cierre de caja")

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

            MsgBox("Se ha producido un error a la hora de leer los informes de cierre de caja guardados en el fichero.",
                   0 + MsgBoxStyle.Information, "Leer  los informes de cierre de caja")


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

        'Se cierran los ficheros abiertos
        FileClose()



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

        Pantalla_de_venta.Show()
        Me.Close()

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

    'AYUDA
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        'Te reenviará a un fichero: Manual de usuario
    End Sub

    'HORA
    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    'COMBOBOX
    Private Sub ComboBox_dia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_dia.SelectedIndexChanged

        'Si no se ha seleccionado nada el boton visualzar estará desactivado
        If (ComboBox_dia.SelectedItem < 0) Then
            Button_visualizar.Enabled = False


        Else
            'El boton visualizar se activa
            Button_visualizar.Enabled = True


        End If

    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click

        'Se vuelve a la pantalla de venta
        Pantalla_de_venta.Show()
        Me.Close()

    End Sub

    'VISUALIZAR
    Private Sub Button_visualizar_Click(sender As Object, e As EventArgs) Handles Button_visualizar.Click

        'Coloca en el label Label_ventaElegida toda la informacion sobre venta seleccionada

        'Se pasa por las dos lista buscando los informes que tienen esta fecha
        For i = 0 To informesFechas.Count - 1

            If informesFechas.Item(i).Equals(ComboBox_dia.SelectedItem) Then

                TextBox_ventas.Text = TextBox_ventas.Text & informesInformacion.Item(i) & vbCrLf & vbCrLf

            End If

        Next i


    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click

        'Se dirige a la pantalla seleccionada
        Pantalla_admin_empleados.Show()
        Me.Close()

    End Sub

    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

        'Se dirige a la pantalla seleccionada
        Pantalla_admin_articulos.Show()
        Me.Close()

    End Sub

    Private Sub GestionDeErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeErroresToolStripMenuItem.Click

        'Se dirige a la pantalla seleccionada
        Gestion_de_errores.Show()
        Me.Close()

    End Sub

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: " &
               Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")

    End Sub

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")

    End Sub

    Private Sub Button_volver_Click_1(sender As Object, e As EventArgs) Handles Button_volver.Click

        'Se vuelve a la pantalla de ventas
        Pantalla_de_venta.Show()
        Me.Close()

    End Sub
End Class