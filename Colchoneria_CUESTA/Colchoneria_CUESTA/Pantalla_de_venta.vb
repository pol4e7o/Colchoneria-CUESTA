Public Class Pantalla_de_venta

    Public ventaArticulos As Double

    'Va a contener todos los articulos de la tienda
    Public articulos As ArrayList

    'Se almacenan el nombre y el tamaño en una cadena de los articulos elegidos
    Public nombresArticulos As ArrayList

    'Se almacenan las cantidades por cada producto elegido
    Public cantidades As ArrayList

    'Se almacenan los precios por cada articulo elegido
    Public precios As ArrayList

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

        'Por defecto todos los panels de los articulos vienen desactivados
        'Para activarlos se tiene que elegir un articulo
        panel_base.Enabled = False
        panel_somier.Enabled = False
        panel_colchon.Enabled = False
        panel_canape.Enabled = False
        panel_ofertas.Enabled = False
        panel_otros.Enabled = False

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


        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Esta seguro que desea cerrar caja?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar caja")

        If opcion = MsgBoxResult.Yes Then

            informe = "Informe de venta de: " & vbCrLf &
            Now & vbCrLf &
            "Total: " & venta & "€" & vbCrLf &
            "Cierre de caja hecha por: " & vbCrLf &
            "Usuario"

            'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario

            'Se visualiza la informacon del cierre de caja en un Message box
            MsgBox(informe, 0 + MsgBoxStyle.Information, "Informe de cierre de caja")

            'Se cambia el valor de la variable venta a 0
            venta = 0

            'Se le pasa el valor true a la variable cajaCerrada 
            cajaCerrada = True

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

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_canape.SelectedIndexChanged

    End Sub



    Private Sub comboBox_base_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_base.SelectedIndexChanged

        'Si no hay ningun articulo elegido el panel esta desactivado
        If comboBox_base.SelectedIndex = -1 Then

            panel_base.Visible = False

        Else

            'De lo contrario se activa
            panel_base.Visible = True

            'Se asignan los tamaños del articulo seleccionado 

        End If

    End Sub
End Class