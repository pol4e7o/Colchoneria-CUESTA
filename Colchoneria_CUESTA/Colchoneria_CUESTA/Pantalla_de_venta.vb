Imports System.IO

Public Class Pantalla_de_venta

    Public ventaArticulos As Double

    'Es el articulo elegido para vender
    Public articulo As GestionComercial.Articulo

    'Este arraylist representa todos los articulos seleccionados para ser comprados por el cliente
    'Dentro de cada objeto se almacenaran el nombre del articulo (dentro del nombre se añade el tamaño),
    'la cantidad que se desea comprar de este articulo y el precio por unidad
    Public articulosVendidos As New List(Of GestionComercial.Venta)

    Private Sub Pantalla_de_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El foco lo tiene el combobox de base
        comboBox_base.Focus()

        'Se asigna 0 a la variable ventaArticulos
        ventaArticulos = 0

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString


        'Se desactivan todos los elementos que no se deben utilizar a la hora de iniciar el formulario
        desactivarElementos()

        'Se pasan los articulos a los comboboxs por categorias
        For i = 0 To articulos.Count - 1

            Select Case articulos.Item(i).getCategoriaArticulo.Replace(" ", "")

                Case "Base"

                    'Base
                    'Se añade el nombre del articulo al combobox de base
                    comboBox_base.Items.Add(articulos.Item(i).getNombreArticulo)

                Case "Somier"

                    'Somier
                    'Se añade el nombre del articulo al combobox de somier
                    comboBox_somier.Items.Add(articulos.Item(i).getNombreArticulo)

                Case "Canape"

                    'Canape
                    'Se añade el nombre del articulo al combobox de canape
                    comboBox_canape.Items.Add(articulos.Item(i).getNombreArticulo)

                Case "Colchon"

                    'Colchon
                    'Se añade el nombre del articulo al combobox de colchon
                    comboBox_colchon.Items.Add(articulos.Item(i).getNombreArticulo)

                Case "Oferta"

                    'Ofertas
                    'Se añade el nombre del articulo al combobox de ofertas
                    comboBox_ofertas.Items.Add(articulos.Item(i).getNombreArticulo)

                Case "Otros"

                    'Otros
                    'Se añade el nombre del articulo al combobox de otros
                    comboBox_otros.Items.Add(articulos.Item(i).getCategoriaArticulo)

            End Select

        Next i

    End Sub

    'OPCION MENU CERRAR CAJA
    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click

        'La opcion elegida por el usuario a cerca de si desea cerrar caja
        Dim opcion As Integer

        'Esta variable va a almacenar el informe del cierre de caja 
        'que se va a guardar en el fichero de ventas y se va a 
        'visualizar en un message box
        Dim informe As String

        'Si no se ha añadido ningun articulo al pedido se puede realizar el cierre de caja
        If ventaArticulos = 0 Then

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
                            0 + MsgBoxStyle.Exclamation)

                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - El fichero ""VentaActual.txt"" no se ha encontrado"

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                Catch

                    MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.", 0 + MsgBoxStyle.Information)


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
                            0 + MsgBoxStyle.Exclamation)


                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - El fichero ""VentasDiarias.txt"" no se ha encontrado"

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                Catch

                    MsgBox("Se ha producido un error a la hora de guadrar el informe de cierre de caja.", 0 + MsgBoxStyle.Information)


                    'Se guarda la informacion sobre el error ocurrido en el fichero de errores
                    FileOpen(3, "ErroresSucedidos.txt", OpenMode.Append)

                    errorRegistro.fecha = DateString
                    errorRegistro.informacionError = Now & " - Se ha producido un error a la hora de escribir en el fichero ""VentasDiarias.txt"""

                    Write(3, errorRegistro.fecha, errorRegistro.informacionError)

                Finally

                    FileClose()

                End Try 

            End If


        Else

            'Se le indica al usuario que para cerrar la caja tiene que terminar el pedido o anularlo
            opcion = MsgBox("Para poder realizar el cierre de caja el pedido actual se tiene que anular o cobrar.", 0 + MsgBoxStyle.Information, "Cerrar caja")

        End If



    End Sub

    'OPCION MENU VOLVER
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        If ventaArticulos <> 0 Then

            'No se puede salir de la pantalla de venta sin terminar o anular la compra
            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'El empleado que inicio la secion se elimina de la variable usuario
            usuario = Nothing

            'Se abre la pantalla de inicio y se cierra la pantalla de venta
            Pantalla_de_inicio.Show()

            Me.Close()

        End If

    End Sub

    'OPCION MENU SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        'La variable que va a almacenar la opcion elegida del message box
        Dim opcion As Integer

        If ventaArticulos = 0 Then

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
                                0 + MsgBoxStyle.Exclamation)

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

                    MsgBox("Se ha producido un error a la hora de guadrar la venta hasta este momento.", 0 + MsgBoxStyle.Information)


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

        Else

            'No se puede salir de la pantalla de venta sin terminar o anular la compra
            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")


        End If



    End Sub

    'OPCION MENU VISUALIZAR VENTA
    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")


    End Sub

    'OPCION MENU GESTION DE EMPLEADOS
    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click

        'No se puede salir de la pantalla de venta sin terminar o anular la compra
        If ventaArticulos <> 0 Then

            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'Se abre la pantalla de gestion de empleados y se cierra la pantalla de venta
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    'OPCION MENU GESTION DE ARTICULOS
    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

        'No se puede salir de la pantalla de venta sin terminar o anular la compra
        If ventaArticulos <> 0 Then

            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'Se abre la pantalla de gestion de articulos y se cierra la pantalla de venta
            Pantalla_admin_articulos.Show()
            Me.Close()

        End If

    End Sub

    'OPCION MENU GESTION DE VENTAS
    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

        'No se puede salir de la pantalla de venta sin terminar o anular la compra
        If ventaArticulos <> 0 Then

            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'Se abre la pantalla de gestion de ventas y se cierra la pantalla de venta

            Me.Close()

        End If

    End Sub

    'OPCION MENU COLCHONERIA CUESTA
    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")


    End Sub

    'OPCION MENU MANUAL DE USUARIO
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        'Se abre el manual de usuario

    End Sub

    'OBJETO TIMER
    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub




    'COMBOBOX BASE
    Private Sub comboBox_base_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_base.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_base.SelectedIndex < 0 Then

            panel_base.Enabled = False

        Else


            'Se elimina el objeto almacenado en esta referencia
            articulo = Nothing

            'Se hace una busqueda dentro del arraylist de articulos
            'para encontrar el seleccionado y se le asigna a la
            'variable articulo el seleccionado
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(comboBox_base.SelectedText) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            Try

                'Se asignan los tamaños del articulo seleccionado 
                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    comboBox_tamanio_base.Items.Add(articulo.getTamaniosArticulo.Item(i))

                Next i

                'De lo contrario se activa
                panel_base.Enabled = True

                'Se desactiva el combobox de cantidad hasta que no se elija un tamaño
                comboBox_cantidad_base.Enabled = False

                'Se desactiva el boton de añadir hasta que no se seleccione una cantidad
                button_aniadir_base.Enabled = False

            Catch ex As System.NullReferenceException

                'Si el articulo no ha sido encontrado en el arraylist se informa al usuario del problema
                MsgBox("No se ha podido encontrar el articulo seleccionado. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un articulo. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        End If

    End Sub

    'COMBOBOX SOMIER
    Private Sub comboBox_somier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_somier.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_somier.SelectedIndex < 0 Then

            panel_somier.Enabled = False

        Else

            'Se elimina el objeto almacenado en este referencia
            articulo = Nothing

            'Se hace una busqueda dentro del arraylist de articulos
            'para encontrar el seleccionado y se le asigna a la
            'variable articulo el seleccionado
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(comboBox_somier.SelectedText) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            Try

                'Se asignan los tamaños del articulo seleccionado 
                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    comboBox_tamanio_somier.Items.Add(articulo.getTamaniosArticulo.Item(i))

                Next i

                'De lo contrario se activa
                panel_somier.Enabled = True

                'Se desactiva el combobox de cantidad hasta que no se elija un tamaño
                comboBox_cantidad_somier.Enabled = False

                'Se desactiva el boton de añadir hasta que no se seleccione una cantidad
                button_aniadir_somier.Enabled = False

            Catch ex As System.NullReferenceException

                'Si el articulo no ha sido encontrado en el arraylist se informa al usuario del problema
                MsgBox("No se ha podido encontrar el articulo seleccionado. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un articulo. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        End If

    End Sub

    'COMBOBOX COLCHON
    Private Sub comboBox_colchon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_colchon.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_colchon.SelectedIndex < 0 Then

            panel_colchon.Enabled = False

        Else


            'Se elimina el objeto almacenado en este referencia
            articulo = Nothing

            'Se hace una busqueda dentro del arraylist de articulos
            'para encontrar el seleccionado y se le asigna a la
            'variable articulo el seleccionado
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(comboBox_colchon.SelectedText) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            Try

                'Se asignan los tamaños del articulo seleccionado 
                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    comboBox_tamanio_canape.Items.Add(articulo.getTamaniosArticulo.Item(i))

                Next i

                'De lo contrario se activa
                panel_colchon.Enabled = True

                'Se desactiva el combobox de cantidad hasta que no se elija un tamaño
                comboBox_cantidad_colchon.Enabled = False

                'Se desactiva el boton de añadir hasta que no se seleccione una cantidad
                button_aniadir_colchon.Enabled = False

            Catch ex As System.NullReferenceException

                'Si el articulo no ha sido encontrado en el arraylist se informa al usuario del problema
                MsgBox("No se ha podido encontrar el articulo seleccionado. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un articulo. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        End If

    End Sub


    'COMBO BOX CANAPE 
    Private Sub comboBox_canape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_canape.SelectedIndexChanged

        'Contador de for
        Dim i As Integer

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_canape.SelectedIndex < 0 Then

            panel_canape.Enabled = False

        Else

            'Se hace una busqueda dentro del arraylist de articulos
            'para encontrar el seleccionado y se le asigna a la
            'variable articulo el seleccionado
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(comboBox_canape.SelectedText) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            Try

                'Se asignan los tamaños del articulo seleccionado 
                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    comboBox_tamanio_canape.Items.Add(articulo.getTamaniosArticulo.Item(i))

                Next i

                'De lo contrario se activa
                panel_canape.Enabled = True

                'Se desactiva el combobox de cantidad hasta que no se elija un tamaño
                comboBox_cantidad_canape.Enabled = False

                'Se desactiva el boton de añadir hasta que no se seleccione una cantidad
                button_aniadir_canape.Enabled = False

            Catch ex As System.NullReferenceException

                'Si el articulo no ha sido encontrado en el arraylist se informa al usuario del problema
                MsgBox("No se ha podido encontrar el articulo seleccionado. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un articulo. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            End Try

        End If

    End Sub


    'COMBOBOX OFERTAS
    Private Sub comboBox_ofertas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_ofertas.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_base.SelectedIndex < 0 Then

            panel_ofertas.Enabled = False

        Else

            'Se elimina el objeto almacenado en este referencia
            articulo = Nothing

            'Se hace una busqueda dentro del arraylist de articulos
            'para encontrar el seleccionado y se le asigna a la
            'variable articulo el seleccionado
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(comboBox_ofertas.SelectedText) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            Try

                'Se asignan los tamaños del articulo seleccionado 
                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    comboBox_tamanios_ofertas.Items.Add(articulo.getTamaniosArticulo.Item(i))

                Next i

                'De lo contrario se activa
                panel_ofertas.Enabled = True

                'Se desactiva el combobox de cantidad hasta que no se elija un tamaño
                comboBox_cantidad_ofertas.Enabled = False

                'Se desactiva el boton de añadir hasta que no se seleccione una cantidad
                button_aniadir_ofertas.Enabled = False

            Catch ex As System.NullReferenceException

                'Si el articulo no ha sido encontrado en el arraylist se informa al usuario del problema
                MsgBox("No se ha podido encontrar el articulo seleccionado. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un articulo. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        End If

    End Sub

    'COMBOBOX OTROS
    Private Sub comboBox_otros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_otros.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_otros.SelectedIndex < 0 Then

            panel_otros.Enabled = False

        Else


            'Se elimina el objeto almacenado en este referencia
            articulo = Nothing

            'Se hace una busqueda dentro del arraylist de articulos
            'para encontrar el seleccionado y se le asigna a la
            'variable articulo el seleccionado
            For i = 0 To articulos.Count - 1

                If articulos.Item(i).getNombreArticulo.Equals(comboBox_otros.SelectedText) Then

                    articulo = articulos.Item(i)

                End If

            Next i

            Try

                'Se asignan los tamaños del articulo seleccionado 
                For i = 0 To articulo.getTamaniosArticulo.Count - 1

                    comboBox_tamanio_otros.Items.Add(articulo.getTamaniosArticulo.Item(i))

                Next i

                'De lo contrario se activa
                panel_otros.Enabled = True

                'Se desactiva el combobox de cantidad hasta que no se elija un tamaño
                comboBox_cantidad_otros.Enabled = False

                'Se desactiva el boton de añadir hasta que no se seleccione una cantidad
                button_aniadir_otros.Enabled = False

            Catch ex As System.NullReferenceException

                'Si el articulo no ha sido encontrado en el arraylist se informa al usuario del problema
                MsgBox("No se ha podido encontrar el articulo seleccionado. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un articulo. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Articulo seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        End If

    End Sub



    'COMBOBOX TAMANIO BASE
    Private Sub comboBox_tamanio_base_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tamanio_base.SelectedIndexChanged

        If comboBox_tamanio_base.SelectedIndex >= 0 Then

            Try

                'Si hay un elemento seleccionado se le asigna al label precio_base el precio correspondiente al tamaño
                label_precio_base.Text = articulo.getPreciosTamaniosArticulo.Item(comboBox_tamanio_base.SelectedIndex)

                'Se altiva el combobox con las cantidades de 1 a 10
                comboBox_cantidad_base.Enabled = True

            Catch ex As System.IndexOutOfRangeException

                'Si no hay precio indicado por este articulo se le indica al usuario
                MsgBox("El tamaño seleccionado no tiene precio asignado por lo tanto no se puede vender. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena la informacion sobre el error ocurrido en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un tamaño. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        Else

            'Si no hay ningun elemento seleccionado el combobox se desactiva
            comboBox_cantidad_base.Enabled = False

        End If

    End Sub

    'COMBOBOX TAMANIO SOMIER
    Private Sub comboBox_tamanio_somier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tamanio_somier.SelectedIndexChanged

        If comboBox_tamanio_somier.SelectedIndex >= 0 Then

            Try

                'Si hay un elemento seleccionado se le asigna al label precio_base el precio correspondiente al tamaño
                label_precio_somier.Text = articulo.getPreciosTamaniosArticulo.Item(comboBox_tamanio_somier.SelectedIndex)

                'Se altiva el combobox con las cantidades de 1 a 10
                comboBox_cantidad_somier.Enabled = True

            Catch ex As System.IndexOutOfRangeException

                'Si no hay precio indicado por este articulo se le indica al usuario
                MsgBox("El tamaño seleccionado no tiene precio asignado por lo tanto no se puede vender. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena la informacion sobre el error ocurrido en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un tamaño. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        Else

            'Si no hay ningun elemento seleccionado el combobox se desactiva
            comboBox_cantidad_somier.Enabled = False

        End If

    End Sub

    'COMBOBOX TAMANIO COLCHON
    Private Sub comboBox_tamanio_colchon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tamanio_colchon.SelectedIndexChanged

        If comboBox_tamanio_colchon.SelectedIndex >= 0 Then

            Try

                'Si hay un elemento seleccionado se le asigna al label precio_base el precio correspondiente al tamaño
                label_precio_colchon.Text = articulo.getPreciosTamaniosArticulo.Item(comboBox_tamanio_colchon.SelectedIndex)

                'Se altiva el combobox con las cantidades de 1 a 10
                comboBox_cantidad_colchon.Enabled = True

            Catch ex As System.IndexOutOfRangeException

                'Si no hay precio indicado por este articulo se le indica al usuario
                MsgBox("El tamaño seleccionado no tiene precio asignado por lo tanto no se puede vender. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena la informacion sobre el error ocurrido en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un tamaño. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        Else

            'Si no hay ningun elemento seleccionado el combobox se desactiva
            comboBox_cantidad_colchon.Enabled = False

        End If

    End Sub

    'COMBOBOX TAMANIO CANAPE
    Private Sub comboBox_tamanio_canape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tamanio_canape.SelectedIndexChanged

        If comboBox_tamanio_canape.SelectedIndex >= 0 Then

            Try

                'Si hay un elemento seleccionado se le asigna al label precio_base el precio correspondiente al tamaño
                label_precio_canape.Text = articulo.getPreciosTamaniosArticulo.Item(comboBox_tamanio_canape.SelectedIndex)

                'Se altiva el combobox con las cantidades de 1 a 10
                comboBox_cantidad_canape.Enabled = True

            Catch ex As System.IndexOutOfRangeException

                'Si no hay precio indicado por este articulo se le indica al usuario
                MsgBox("El tamaño seleccionado no tiene precio asignado por lo tanto no se puede vender. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena la informacion sobre el error ocurrido en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un tamaño. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        Else

            'Si no hay ningun elemento seleccionado el combobox se desactiva
            comboBox_cantidad_canape.Enabled = False

        End If

    End Sub

    'COMBOBOX TAMANIO OFERTAS
    Private Sub comboBox_tamanios_ofertas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tamanios_ofertas.SelectedIndexChanged

        If comboBox_tamanios_ofertas.SelectedIndex >= 0 Then

            Try

                'Si hay un elemento seleccionado se le asigna al label precio_base el precio correspondiente al tamaño
                label_precio_ofertas.Text = articulo.getPreciosTamaniosArticulo.Item(comboBox_tamanios_ofertas.SelectedIndex)

                'Se altiva el combobox con las cantidades de 1 a 10
                comboBox_cantidad_ofertas.Enabled = True

            Catch ex As System.IndexOutOfRangeException

                'Si no hay precio indicado por este articulo se le indica al usuario
                MsgBox("El tamaño seleccionado no tiene precio asignado por lo tanto no se puede vender. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena la informacion sobre el error ocurrido en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un tamaño. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        Else

            'Si no hay ningun elemento seleccionado el combobox se desactiva
            comboBox_cantidad_ofertas.Enabled = False

        End If

    End Sub

    'COMBOBOX TAMANIO OTROS
    Private Sub comboBox_tamanio_otros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tamanio_otros.SelectedIndexChanged

        If comboBox_tamanio_otros.SelectedIndex >= 0 Then

            Try

                'Si hay un elemento seleccionado se le asigna al label precio_base el precio correspondiente al tamaño
                label_precio_otros.Text = articulo.getPreciosTamaniosArticulo.Item(comboBox_tamanio_otros.SelectedIndex)

                'Se altiva el combobox con las cantidades de 1 a 10
                comboBox_cantidad_otros.Enabled = True

            Catch ex As System.IndexOutOfRangeException

                'Si no hay precio indicado por este articulo se le indica al usuario
                MsgBox("El tamaño seleccionado no tiene precio asignado por lo tanto no se puede vender. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena la informacion sobre el error ocurrido en el fichero de errores

            Catch ex As Exception

                'Si se produce un error general
                MsgBox("Se ha producido un error a la hora de seleccionar un tamaño. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Tamaño seleccionado")

                'Se almacena el error en el fichero de errores


            End Try

        Else

            'Si no hay ningun elemento seleccionado el combobox se desactiva
            comboBox_cantidad_otros.Enabled = False

        End If

    End Sub



    'COMBOBOX CANTIDAD BASE
    Private Sub comboBox_cantidad_base_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_cantidad_base.SelectedIndexChanged

        If comboBox_cantidad_base.SelectedIndex >= 0 Then

            'Si se ha seleccionado una cantidad se activa el boton añadir
            button_aniadir_base.Enabled = True

        Else

            'Sino el boton añadir se desactiva
            button_aniadir_base.Enabled = False

        End If

    End Sub

    'COMBOBOX CANTIDAD SOMIER
    Private Sub comboBox_cantidad_somier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_cantidad_somier.SelectedIndexChanged

        If comboBox_cantidad_somier.SelectedIndex >= 0 Then

            'Si se ha seleccionado una cantidad se activa el boton añadir
            button_aniadir_somier.Enabled = True

        Else

            'Sino el boton añadir se desactiva
            button_aniadir_somier.Enabled = False

        End If

    End Sub

    'COMBOBOX CANTIDAD COLCHON
    Private Sub comboBox_cantidad_colchon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_cantidad_colchon.SelectedIndexChanged

        If comboBox_cantidad_colchon.SelectedIndex >= 0 Then

            'Si se ha seleccionado una cantidad se activa el boton añadir
            button_aniadir_colchon.Enabled = True

        Else

            'Sino el boton añadir se desactiva
            button_aniadir_colchon.Enabled = False

        End If

    End Sub

    'COMBOBOX CANTIDAD CANAPE
    Private Sub comboBox_cantidad_canape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_cantidad_canape.SelectedIndexChanged

        If comboBox_cantidad_colchon.SelectedIndex >= 0 Then

            'Si se ha seleccionado una cantidad se activa el boton añadir
            button_aniadir_canape.Enabled = True

        Else

            'Sino el boton añadir se desactiva
            button_aniadir_canape.Enabled = False

        End If

    End Sub

    'COMBOBOX CANTIDAD OFERTAS
    Private Sub comboBox_cantidad_ofertas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_cantidad_ofertas.SelectedIndexChanged

        If comboBox_cantidad_ofertas.SelectedIndex >= 0 Then

            'Si se ha seleccionado una cantidad se activa el boton añadir
            button_aniadir_ofertas.Enabled = True

        Else

            'Sino el boton añadir se desactiva
            button_aniadir_ofertas.Enabled = False

        End If

    End Sub

    'COMBOBOX CANTIDAD OTROS
    Private Sub comboBox_cantidad_otros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_cantidad_otros.SelectedIndexChanged

        If comboBox_cantidad_otros.SelectedIndex >= 0 Then

            'Si se ha seleccionado una cantidad se activa el boton añadir
            button_aniadir_otros.Enabled = True

        Else

            'Sino el boton añadir se desactiva
            button_aniadir_otros.Enabled = False

        End If

    End Sub



    'BOTON AÑADIR BASE
    Private Sub button_aniadir_base_Click(sender As Object, e As EventArgs) Handles button_aniadir_base.Click

        'Se crea un objeto de tipo venta y se añade al arraylist de articulos vendidos
        articulosVendidos.Add(New GestionComercial.Venta(articulo.getNombreArticulo & "-" & comboBox_tamanio_base.SelectedText, comboBox_cantidad_base.SelectedText, label_precio_base.Text))

        Try

            'Se añade el producto seleccionado a la lista de articulos elegidos
            listBox_articulosElegidos.Items.Add(articulosVendidos.Item(articulosVendidos.Count - 1).getCantidad &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getNombreArticulo &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getPrecioCantidad & "€" &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).precioTotal & "€")

        Catch ex As System.IndexOutOfRangeException

            'Salta una exception si se intenta acceder a un elemento del arraylist y este esta vacio
            MsgBox("No se ha podido agregar el articulo seleccionado a la lista. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error dentro del fichero de errores

        Catch ex As Exception

            'Si se produce un error general
            MsgBox("Se ha producido un error a la hora de agregar el articulo a la lista. Por favor revise los datos del articulo en gestion de articulos", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error en el fichero de errores


        End Try


        'Se desactivan todos los elementos de la categoria menos el combobox para seleccionar articulo
        button_aniadir_base.Enabled = False
        comboBox_cantidad_base.Enabled = False
        label_precio_base.Text = ""
        comboBox_tamanio_base.Enabled = False
        panel_base.Enabled = False

        'Se actualiza el subtotal, total y iva de la venta
        calcularTotalSubtotalIVA()

    End Sub

    'BOTON AÑADIR SOMIER
    Private Sub button_aniadir_somier_Click(sender As Object, e As EventArgs) Handles button_aniadir_somier.Click

        'Se crea un objeto de tipo venta y se añade al arraylist de articulos vendidos
        articulosVendidos.Add(New GestionComercial.Venta(articulo.getNombreArticulo & "-" & comboBox_tamanio_somier.SelectedText, comboBox_cantidad_somier.SelectedText, label_precio_somier.Text))

        Try

            'Se añade el producto seleccionado a la lista de articulos elegidos
            listBox_articulosElegidos.Items.Add(articulosVendidos.Item(articulosVendidos.Count - 1).getCantidad &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getNombreArticulo &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getPrecioCantidad & "€" &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).precioTotal & "€")

        Catch ex As System.IndexOutOfRangeException

            'Salta una exception si se intenta acceder a un elemento del arraylist y este esta vacio
            MsgBox("No se ha podido agregar el articulo seleccionado a la lista. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error dentro del fichero de errores


        End Try


        'Se desactivan todos los elementos de la categoria menos el combobox para seleccionar articulo
        button_aniadir_somier.Enabled = False
        comboBox_cantidad_somier.Enabled = False
        label_precio_somier.Text = ""
        comboBox_tamanio_somier.Enabled = False
        panel_somier.Enabled = False

        'Se actualiza el subtotal, total y iva de la venta
        calcularTotalSubtotalIVA()

    End Sub

    'BOTON AÑADIR COLCHON
    Private Sub button_aniadir_colchon_Click(sender As Object, e As EventArgs) Handles button_aniadir_colchon.Click

        'Se crea un objeto de tipo venta y se añade al arraylist de articulos vendidos
        articulosVendidos.Add(New GestionComercial.Venta(articulo.getNombreArticulo & "-" & comboBox_tamanio_colchon.SelectedText, comboBox_cantidad_colchon.SelectedText, label_precio_colchon.Text))

        Try

            'Se añade el producto seleccionado a la lista de articulos elegidos
            listBox_articulosElegidos.Items.Add(articulosVendidos.Item(articulosVendidos.Count - 1).getCantidad &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getNombreArticulo &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getPrecioCantidad & "€" &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).precioTotal & "€")

        Catch ex As System.IndexOutOfRangeException

            'Salta una exception si se intenta acceder a un elemento del arraylist y este esta vacio
            MsgBox("No se ha podido agregar el articulo seleccionado a la lista. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error dentro del fichero de errores


        End Try


        'Se desactivan todos los elementos de la categoria menos el combobox para seleccionar articulo
        button_aniadir_colchon.Enabled = False
        comboBox_cantidad_colchon.Enabled = False
        label_precio_colchon.Text = ""
        comboBox_tamanio_colchon.Enabled = False
        panel_colchon.Enabled = False

        'Se actualiza el subtotal, total y iva de la venta
        calcularTotalSubtotalIVA()

    End Sub

    'BOTON AÑADIR CANAPE
    Private Sub button_aniadir_canape_Click(sender As Object, e As EventArgs) Handles button_aniadir_canape.Click

        'Se crea un objeto de tipo venta y se añade al arraylist de articulos vendidos
        articulosVendidos.Add(New GestionComercial.Venta(articulo.getNombreArticulo & "-" & comboBox_tamanio_canape.SelectedText, comboBox_cantidad_canape.SelectedText, label_precio_canape.Text))

        Try

            'Se añade el producto seleccionado a la lista de articulos elegidos
            listBox_articulosElegidos.Items.Add(articulosVendidos.Item(articulosVendidos.Count - 1).getCantidad &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getNombreArticulo &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getPrecioCantidad & "€" &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).precioTotal & "€")

        Catch ex As System.IndexOutOfRangeException

            'Salta una exception si se intenta acceder a un elemento del arraylist y este esta vacio
            MsgBox("No se ha podido agregar el articulo seleccionado a la lista. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error dentro del fichero de errores


        End Try

            'Se desactivan todos los elementos de la categoria menos el combobox para seleccionar articulo
            button_aniadir_canape.Enabled = False
            comboBox_cantidad_canape.Enabled = False
            label_precio_canape.Text = ""
            comboBox_tamanio_canape.Enabled = False
            panel_canape.Enabled = False

            'Se actualiza el subtotal, total y iva de la venta
            calcularTotalSubtotalIVA()

    End Sub

    'BOTON AÑADIR OFERTAS
    Private Sub button_aniadir_ofertas_Click(sender As Object, e As EventArgs) Handles button_aniadir_ofertas.Click

        'Se crea un objeto de tipo venta y se añade al arraylist de articulos vendidos
        articulosVendidos.Add(New GestionComercial.Venta(articulo.getNombreArticulo & "-" & comboBox_tamanios_ofertas.SelectedText, comboBox_cantidad_ofertas.SelectedText, label_precio_ofertas.Text))

        Try

            'Se añade el producto seleccionado a la lista de articulos elegidos
            listBox_articulosElegidos.Items.Add(articulosVendidos.Item(articulosVendidos.Count - 1).getCantidad &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getNombreArticulo &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getPrecioCantidad & "€" &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).precioTotal & "€")

        Catch ex As System.IndexOutOfRangeException

            'Salta una exception si se intenta acceder a un elemento del arraylist y este esta vacio
            MsgBox("No se ha podido agregar el articulo seleccionado a la lista. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error dentro del fichero de errores


        End Try

        'Se desactivan todos los elementos de la categoria menos el combobox para seleccionar articulo
        button_aniadir_ofertas.Enabled = False
        comboBox_cantidad_ofertas.Enabled = False
        label_precio_ofertas.Text = ""
        comboBox_tamanios_ofertas.Enabled = False
        panel_ofertas.Enabled = False

        'Se actualiza el subtotal, total y iva de la venta
        calcularTotalSubtotalIVA()

    End Sub

    'BOTON AÑADIR OTROS
    Private Sub button_aniadir_otros_Click(sender As Object, e As EventArgs) Handles button_aniadir_otros.Click

        'Se crea un objeto de tipo venta y se añade al arraylist de articulos vendidos
        articulosVendidos.Add(New GestionComercial.Venta(articulo.getNombreArticulo & "-" & comboBox_tamanio_otros.SelectedText, comboBox_cantidad_otros.SelectedText, label_precio_otros.Text))

        Try

            'Se añade el producto seleccionado a la lista de articulos elegidos
            listBox_articulosElegidos.Items.Add(articulosVendidos.Item(articulosVendidos.Count - 1).getCantidad &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getNombreArticulo &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).getPrecioCantidad & "€" &
                                                articulosVendidos.Item(articulosVendidos.Count - 1).precioTotal & "€")

        Catch ex As System.IndexOutOfRangeException

            'Salta una exception si se intenta acceder a un elemento del arraylist y este esta vacio
            MsgBox("No se ha podido agregar el articulo seleccionado a la lista. Por favor intentelo de nuevo", 0 + MsgBoxStyle.Information, "Añadir articulo")

            'Se almacena el error dentro del fichero de errores


        End Try

        'Se desactivan todos los elementos de la categoria menos el combobox para seleccionar articulo
        button_aniadir_otros.Enabled = False
        comboBox_cantidad_otros.Enabled = False
        label_precio_otros.Text = ""
        comboBox_tamanio_otros.Enabled = False
        panel_otros.Enabled = False

        'Se actualiza el subtotal, total y iva de la venta
        calcularTotalSubtotalIVA()

    End Sub




    'BOTON INFORMACION BASE
    Private Sub button_informacion_base_Click(sender As Object, e As EventArgs) Handles button_informacion_base.Click

        'Se indica toda la descripcion disponible de este articulo en un message box
        MsgBox(articulo.getDescripcionArticulo, 0 + MsgBoxStyle.Information, "Informacion sobre el articulo seleccionado")

    End Sub

    'BOTON INFORMACION SOMIER
    Private Sub button_informacion_somier_Click(sender As Object, e As EventArgs) Handles button_informacion_somier.Click

        'Se indica toda la descripcion disponible de este articulo en un message box
        MsgBox(articulo.getDescripcionArticulo, 0 + MsgBoxStyle.Information, "Informacion sobre el articulo seleccionado")

    End Sub

    'BOTON INFORMACION COLCHON
    Private Sub button_informacion_colchon_Click(sender As Object, e As EventArgs) Handles button_informacion_colchon.Click

        'Se indica toda la descripcion disponible de este articulo en un message box
        MsgBox(articulo.getDescripcionArticulo, 0 + MsgBoxStyle.Information, "Informacion sobre el articulo seleccionado")

    End Sub

    'BOTON INFORMACION CANAPE
    Private Sub button_informacion_canape_Click(sender As Object, e As EventArgs) Handles button_informacion_canape.Click

        'Se indica toda la descripcion disponible de este articulo en un message box
        MsgBox(articulo.getDescripcionArticulo, 0 + MsgBoxStyle.Information, "Informacion sobre el articulo seleccionado")

    End Sub

    ''BOTON INFORMACION OFERTAS
    Private Sub button_informacion_ofertas_Click(sender As Object, e As EventArgs) Handles button_informacion_ofertas.Click

        'Se indica toda la descripcion disponible de este articulo en un message box
        MsgBox(articulo.getDescripcionArticulo, 0 + MsgBoxStyle.Information, "Informacion sobre el articulo seleccionado")

    End Sub

    'BOTON INFORMACION OTROS
    Private Sub button_informacion_otros_Click(sender As Object, e As EventArgs) Handles button_informacion_otros.Click

        'Se indica toda la descripcion disponible de este articulo en un message box
        MsgBox(articulo.getDescripcionArticulo, 0 + MsgBoxStyle.Information, "Informacion sobre el articulo seleccionado")

    End Sub



    'LISTBOX ARTICULOS ELEGIDOS CAMBIO DE INDICE SELECCIONADO
    Private Sub listBox_articulosElegidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_articulosElegidos.SelectedIndexChanged

        'si no hay ningun elemento elegido se desactivan los botones de añadir una cantidad, 
        'restar una cantidad (eliminar_1) y eliminar el articulo de la lista(eliminar_articulo)
        If listBox_articulosElegidos.SelectedIndex < 0 Then

            button_aniadir_1.Enabled = False
            button_eliminar_1.Enabled = False
            button_eliminar_articulo.Enabled = False

        Else

            button_aniadir_1.Enabled = True
            button_eliminar_1.Enabled = True
            button_eliminar_articulo.Enabled = True

        End If

    End Sub

    'LISTBOX ARTICULOS ELEGIDOS CAMBIO DE NUMERO DE ELEMENTOS
    Private Sub listBox_articulosElegidos_SizeChanged(sender As Object, e As EventArgs) Handles listBox_articulosElegidos.SizeChanged

        If listBox_articulosElegidos.Items.Count = 0 Then

            'Si el listbox no contiene ningun elemento los botones anular y cobrar se desabilitan
            button_anular.Enabled = False
            button_cobrar.Enabled = False

            'Se calcula de nuevo el subtotal, total y iva
            calcularTotalSubtotalIVA()

        Else

            'Si el listbox contiene elementos se activan los botones cobrar y anular
            button_anular.Enabled = True
            button_cobrar.Enabled = True

            'Se calcula de nuevo el subtotal, total y iva
            calcularTotalSubtotalIVA()

        End If

    End Sub




    'BOTON AÑADIR UNA CANTIDAD
    Private Sub button_aniadir_1_Click(sender As Object, e As EventArgs) Handles button_aniadir_1.Click

        'Se le suma 1 a la cantidad del objeto elegido teniendo en cuenta que cuando se elije un articulo que añade al arraylist
        'de articulosVendidos y al listbox por lo tanto tienen que tener el mismo numero de elementos
        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).setCantidad(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getCantidad + 1)

        'Se le pasa el nuevo valor al elemento elegido del listbox
        listBox_articulosElegidos.SelectedItem = articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getCantidad &
                        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getNombreArticulo &
                        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getPrecioCantidad & "€" &
                        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).precioTotal & "€"

        'Se calcula de nuevo el subtotal, total y iva
        calcularTotalSubtotalIVA()

    End Sub

    'BOTON ELIMINAR UNA CANTIDAD
    Private Sub button_eliminar_1_Click(sender As Object, e As EventArgs) Handles button_eliminar_1.Click

        'Se le resta 1 a la cantidad del objeto elegido teniendo en cuenta que cuando se elije un articulo que añade al arraylist
        'de articulosVendidos y al listbox por lo tanto tienen que tener el mismo numero de elementos
        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).setCantidad(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getCantidad - 1)

        'Se le pasa el nuevo valor al elemento elegido del listbox
        listBox_articulosElegidos.SelectedItem = articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getCantidad &
                        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getNombreArticulo &
                        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).getPrecioCantidad & "€" &
                        articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex).precioTotal & "€"

        'Se calcula de nuevo el subtotal, total y iva
        calcularTotalSubtotalIVA()

    End Sub

    'BOTON ELIMINAR UN ARTICULO
    Private Sub button_eliminar_articulo_Click(sender As Object, e As EventArgs) Handles button_eliminar_articulo.Click

        'Se elimina el articulo elegido del arraylist articulosVendidos
        articulosVendidos.RemoveAt(listBox_articulosElegidos.SelectedIndex)

        'Se elimina el articulo elegido del listbox
        listBox_articulosElegidos.Items.RemoveAt(listBox_articulosElegidos.SelectedIndex)

        'Se calcula de nuevo el subtotal, total y iva
        calcularTotalSubtotalIVA()

    End Sub



    'BOTON ANULAR
    Private Sub button_anular_Click(sender As Object, e As EventArgs) Handles button_anular.Click

        'Representa la opcion elegido por el usuario
        Dim opcion As Integer

        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Esta seguro que desea anular el pedido?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Anular venta")

        If opcion = MsgBoxResult.Yes Then

            'Se le asigna a la variable ventaArticulos 0 
            ventaArticulos = 0

            'Se desactivan todos los elementos graficos
            desactivarElementos()

        End If


    End Sub

    'BOTON COBRAR
    Private Sub button_cobrar_Click(sender As Object, e As EventArgs) Handles button_cobrar.Click

        'Representa la opcion elegido por el usuario
        Dim opcion As Integer

        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Confimar pago", 4 + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Pago")

        If opcion = MsgBoxResult.Yes Then

            'Se imprime el ticket

            'Se le suma a la variable global venta el valor de ventaArticulos
            'que es el total de venta de este pedido
            venta = venta + ventaArticulos

            'Despues se le asigna a la variable ventaArticulos 0
            ventaArticulos = 0

            'Se desactivan los elementos graficos
            desactivarElementos()


            Try

                'Se guadra el nuevo valor de venta en el vichero VentaActual
                FileOpen(5, "VentaActual.txt", OpenMode.Output)

                Write(5, ElementosComunes.venta)

                'Se cierra el fichero
                FileClose(5)

                End

            Catch ex As System.IO.FileNotFoundException

                MsgBox("El fichero ""VentaActual.txt"" no se encuentra por lo tanto no se ha podido guadrar el valor de la venta en este momento" &
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


        End If

    End Sub

    Private Sub button_desconectar_Click(sender As Object, e As EventArgs) Handles button_desconectar.Click

        'Recoje la opcion elegida por el usuario
        Dim opcion As Integer

        If venta > 0 Then

            'No se puede salir de la pantalla de venta sin terminar o anular la compra
            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")


        Else

            'Se pregunta al usuario si desea desconectar y volver a la pantalla de inicio
            opcion = MsgBox("Esta seguro que desea desconectar? Será dirigido a la pantalla de inicio.", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Descontectar")

            If opcion = MsgBoxResult.Yes Then

                'El empleado que inicio la secion se elimina de la variable usuario
                usuario = Nothing

                'Se pasa a la pantalla de inicio y se cierra la pantalla de venta
                Pantalla_de_inicio.Show()
                Me.Close()

            End If

        End If

    End Sub




    'METODO CALCULAR IVA, TOTAL Y SUBTOTAL
    Private Sub calcularTotalSubtotalIVA()

        'se le asigna 0 a ventaArticulos para poder sumar todos los totales de cada articulo seleccionado
        ventaArticulos = 0

        Try

            'Se calcula el total de este pedido
            For i = 0 To articulosVendidos.Count - 1

                ventaArticulos = ventaArticulos + CType(articulosVendidos.Item(i), GestionComercial.Venta).precioTotal

            Next i

        Catch ex As System.NullReferenceException


        End Try

        'Se actualiza el total
        label_totalPrecio.Text = ventaArticulos

        'Se actualiza el campo de IVA segun el subtotal
        label_ivaPrecio.Text = Math.Round(ventaArticulos * 15 / 100, 2)

        'Se calcula el subtotal
        label_subtotalPrecio.Text = label_totalPrecio.Text - label_ivaPrecio.Text


    End Sub

    'METODO DESACTIVAR ELEMENTOS
    Private Sub desactivarElementos()

        'Todos los panels de los articulos se desactivan
        'Para activarlos se tiene que elegir un articulo
        panel_base.Enabled = False
        panel_somier.Enabled = False
        panel_colchon.Enabled = False
        panel_canape.Enabled = False
        panel_ofertas.Enabled = False
        panel_otros.Enabled = False

        'Los botones de anular compra y cobrar se desactivan
        'Se activan si existen productos seleccionados visualizados en el listbox
        button_anular.Enabled = False
        button_cobrar.Enabled = False

        'Se desactivan los botones de añadir una cantidad, eliminar 1 cantidad y eliminar producto de la lista
        button_aniadir_1.Enabled = False
        button_eliminar_1.Enabled = False
        button_eliminar_articulo.Enabled = False

        'Por ultimo se eliminan todos los articulos elegidos
        articulosVendidos.Clear()
        listBox_articulosElegidos.Items.Clear()

        'Se vacian las etiquetas
        label_subtotalPrecio.Text = ""
        label_ivaPrecio.Text = ""
        label_totalPrecio.Text = ""
        label_resto.Text = ""
        textBox_importe.Text = ""


    End Sub

    'TEXTBOX IMPORTE
    Private Sub textBox_importe_Leave(sender As Object, e As EventArgs) Handles textBox_importe.Leave

        'Si el texto introducido en la caja de texto es un numero mayor a 0
        If validacion.numeroMayorACero(textBox_importe.Text) Then

            'Se comprueba que el importe es mayor o igual que el total de la venta
            If textBox_importe.Text >= venta Then

                'Se introduce en el label_resto la cantidad a devolver al cliente
                label_resto.Text = textBox_importe.Text - venta

                'Se activa el boton cobrar
                button_cobrar.Enabled = True

            Else
                'Se le indica al usuario que el importe tiene que ser mayor o igual al total de venta
                MsgBox("El importe introducido tiene que ser mayor o igual al total de la venta", 0 + MsgBoxStyle.Information, "Importe incorrecto")

                'Se desactiva el boton cobrar
                button_cobrar.Enabled = False

                'Se limpia la caja de texto
                textBox_importe.Text = ""

                label_totalPrecio.Focus()

            End If

        Else

            'Se le indica al usuario que el importe tiene que ser un numero mayor a 0
            MsgBox("Por favor introduzca un numero mayor a 0 para el importe de la venta", 0 + MsgBoxStyle.Information, "Importe incorrecto")

            'Se desactiva el boton cobrar
            button_cobrar.Enabled = False

            'Se limpia la caja de texto
            textBox_importe.Text = ""

            label_totalPrecio.Focus()

        End If

    End Sub

End Class