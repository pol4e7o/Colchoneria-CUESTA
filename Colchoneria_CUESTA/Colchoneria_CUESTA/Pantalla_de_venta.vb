Public Class Pantalla_de_venta

    Public ventaArticulos As Double

    'Va a contener todos los articulos de la tienda
    Public articulos As ArrayList

    'Este arraylist representa todos los articulos seleccionados para ser comprados por el cliente
    'Dentro de cada objeto se almacenaran el nombre del articulo (dentro del nombre se añade el tamaño),
    'la cantidad que se desea comprar de este articulo y el precio por unidad
    Public articulosVendidos As ArrayList

    Private Sub Pantalla_de_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El foco lo tiene el combobox de base
        comboBox_base.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Si el usuario no es administrador se desactivan las opciones del menu
        'de gestion y se hacen invisibles
        If administrador = False Then

            OpcionesToolStripMenuItem.Enabled = False
            OpcionesToolStripMenuItem.Visible = False

        End If

        'Se desactivan todos los elementos que no se deben utilizar a la hora de iniciar el formulario
        desactivarElementos()

        'Se cargan todos los articulos del fichero de articulos

        'Se pasan los articulos a los comboboxs por categorias

    End Sub

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
                    vbCrLf & "Cierre de caja hecha por: " & vbCrLf & "Usuario"

                'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario

                'Se visualiza la informacon del cierre de caja en un Message box
                MsgBox(informe, 0 + MsgBoxStyle.Information, "Informe de cierre de caja")

                'Se cambia el valor de la variable venta a 0
                venta = 0

                'Se le pasa el valor true a la variable cajaCerrada 
                cajaCerrada = True

            End If


        Else

            'Se pregunta al usuario si esta seguro que desea cerrar caja
            opcion = MsgBox("Para poder realizar el cierre de caja el pedido actual se tiene que anular o cobrar.", 0 + MsgBoxStyle.Information, "Cerrar caja")

        End If



    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        If ventaArticulos <> 0 Then

            'No se puede salir de la pantalla de venta sin terminar o anular la compra
            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'Se abre la pantalla de inicio y se cierra la pantalla de venta
            Pantalla_de_inicio.Show()

            Me.Close()

        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        'La variable que va a almacenar la opcion elegida del message box
        Dim opcion As Integer

        If ElementosComunes.cajaCerrada = False Then

            'Si la caja no esta cerrada no se podra salir del programa
            'Se le indica al usuario que tiene que cerrarla antes de salir
            MsgBox("    Para poder salir de la aplicacion se necesita realizar primero el cierre de caja. De lo contrario no se va a guardar la venta el dia", MsgBoxStyle.Information, "Salir")


        ElseIf ventaArticulos <> 0 Then

            'No se puede salir de la pantalla de venta sin terminar o anular la compra
            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'Se le pregunta al usuario si desea salir
            opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

            If MsgBoxResult.Yes = opcion Then
                End
            End If

        End If

    End Sub

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")


    End Sub

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

    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

        'No se puede salir de la pantalla de venta sin terminar o anular la compra
        If ventaArticulos <> 0 Then

            MsgBox("No puede abandonar la pantalla de venta sin terminar o anular la compra primero.", 0 + MsgBoxStyle.Information, "Abandonar pantalla de venta")

        Else

            'Se abre la pantalla de gestion de ventas y se cierra la pantalla de venta

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

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub comboBox_canape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_canape.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_canape.SelectedIndex < 0 Then

            panel_canape.Enabled = False

        Else

            'De lo contrario se activa
            panel_canape.Enabled = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub



    Private Sub comboBox_base_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_base.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_base.SelectedIndex < 0 Then

            panel_base.Enabled = False

        Else

            'De lo contrario se activa
            panel_base.Enabled = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub

    Private Sub comboBox_somier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_somier.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_somier.SelectedIndex < 0 Then

            panel_somier.Enabled = False

        Else

            'De lo contrario se activa
            panel_somier.Enabled = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub

    Private Sub comboBox_colchon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_colchon.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_colchon.SelectedIndex < 0 Then

            panel_colchon.Enabled = False

        Else

            'De lo contrario se activa
            panel_colchon.Enabled = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub

    Private Sub comboBox_ofertas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_ofertas.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_base.SelectedIndex < 0 Then

            panel_ofertas.Enabled = False

        Else

            'De lo contrario se activa
            panel_ofertas.Enabled = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub

    Private Sub comboBox_otros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_otros.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_otros.SelectedIndex < 0 Then

            panel_otros.Enabled = False

        Else

            'De lo contrario se activa
            panel_otros.Enabled = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub

    Private Sub button_anular_Click(sender As Object, e As EventArgs) Handles button_anular.Click

        'Representa la opcion elegido por el usuario
        Dim opcion As Integer

        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Esta seguro que desea anular el pedido?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Anular venta")

        If opcion = MsgBoxResult.Yes Then

            'Se le asigna a la variable ventaArticulos 0 
            ventaArticulos = 0

            desactivarElementos()

        End If


    End Sub

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

        'Por ultimo se eliminan todos los articulos elegidos
        articulosVendidos.Clear()
        listBox_articulosElegidos.Items.Clear()


    End Sub

    Private Sub listBox_articulosElegidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_articulosElegidos.SelectedIndexChanged

        'si no hay ningun elemento elegido se desactivan los botones de añadir una cantidad, 
        'restar una cantidad (eliminar_1) y eliminar el articulo de la lista(eliminar_articulo)
        If listBox_articulosElegidos.SelectedIndex = -1 Then

            button_aniadir_1.Enabled = False
            button_eliminar_1.Enabled = False
            button_eliminar_articulo.Enabled = False

        Else

            button_aniadir_1.Enabled = True
            button_eliminar_1.Enabled = True
            button_eliminar_articulo.Enabled = True

        End If

    End Sub

    Private Sub listBox_articulosElegidos_SizeChanged(sender As Object, e As EventArgs) Handles listBox_articulosElegidos.SizeChanged

        If listBox_articulosElegidos.Items.Count = 0 Then

            'Si el listbox no contiene ningun elemento los botones anular y cobrar se desabilitan
            button_anular.Enabled = False
            button_cobrar.Enabled = False

        Else

            'Si el listbox contiene elementos se activan los botones cobrar y anular
            button_anular.Enabled = True
            button_cobrar.Enabled = True

        End If

    End Sub

    Private Sub button_aniadir_1_Click(sender As Object, e As EventArgs) Handles button_aniadir_1.Click

        'Se le suma 1 a la cantidad del objeto elegido teniendo en cuenta que cuando se elije un articulo que añade al arraylist
        'de articulosVendidos y al listbox por lo tanto tienen que tener el mismo numero de elementos
        CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).setCantidad(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getCantidad + 1)

        'Se le pasa el nuevo valor al elemento elegido del listbox
        listBox_articulosElegidos.SelectedItem = LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getCantidad, 4) &
        LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getNombreArticulo, 12) &
        LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getPrecioCantidad & "€", 9) &
        LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getCantidad & "€", 10)


    End Sub

    Private Sub button_eliminar_1_Click(sender As Object, e As EventArgs) Handles button_eliminar_1.Click

        'Se le resta 1 a la cantidad del objeto elegido teniendo en cuenta que cuando se elije un articulo que añade al arraylist
        'de articulosVendidos y al listbox por lo tanto tienen que tener el mismo numero de elementos
        CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).setCantidad(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getCantidad - 1)

        'Se le pasa el nuevo valor al elemento elegido del listbox
        listBox_articulosElegidos.SelectedItem = LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getCantidad, 4) &
        LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getNombreArticulo, 12) &
        LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getPrecioCantidad & "€", 9) &
        LSet(CType(articulosVendidos.Item(listBox_articulosElegidos.SelectedIndex), GestionComercial.Venta).getCantidad & "€", 10)

    End Sub

    Private Sub button_eliminar_articulo_Click(sender As Object, e As EventArgs) Handles button_eliminar_articulo.Click

        'Se elimina el articulo elegido del arraylist articulosVendidos
        articulosVendidos.RemoveAt(listBox_articulosElegidos.SelectedIndex)

        'Se elimina el articulo elegido del listbox
        listBox_articulosElegidos.Items.RemoveAt(listBox_articulosElegidos.SelectedIndex)

    End Sub

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

            desactivarElementos()





        Else



        End If

        '

    End Sub

    Private Sub button_desconectar_Click(sender As Object, e As EventArgs) Handles button_desconectar.Click

    End Sub

    Private Sub calcularTotalSubtotalIVA()

    End Sub

End Class