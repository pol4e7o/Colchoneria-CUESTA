Public Class Pantalla_aniadir_articulo
    '---------------------------------------------------------------------------------------------------------------------------------------------
    'MENU
    'CERRAR CAJA
    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cerrar caja?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar caja")

        If opcion = MsgBoxResult.Yes Then

            'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario


            'Se cambia el valor de la variable venta a 0
            venta = 0

        End If
    End Sub

    'VOLVER
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Select Case MsgBox("¿Está seguro de que desea salir?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Pantalla_admin.Show()
                Me.Close()
            Case MsgBoxResult.No
                MessageBox.Show("Volverá a la pantalla")
        End Select


    End Sub

    'SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'La variable que va a almacenar la opcion elegida del message box
        Dim opcion As Integer

        If ElementosComunes.cajaCerrada = False Then

            'Si la caja no esta cerrada no se podra salir del programa
            'Se le indica al usuario que tiene que cerrarla antes de salir
            MsgBox("    Para poder salir de la aplicacion se necesita realizar primero el cierre de caja. De lo contrario no se va a guardar la venta el dia", MsgBoxStyle.Information, "Salir")

        Else

            'Se le pregunta al usuario si desea salir
            opcion = MsgBox("Desea salir de la aplicacion?", 4 + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Salir")

            If MsgBoxResult.Yes = opcion Then
                End
            End If

        End If
    End Sub

    'VENTA
    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & ElementosComunes.venta & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")
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

    'INICIO DEL PROGRAMA
    Private Sub Pantalla_aniadir_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el foco sobre el primer comboBox
        TextBox_nombre.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Si no hay nada seleccionado en precio y tamaño no puede pulsarse
        If (ListBox_precios.SelectedItem = 0 & TextBox_precio.Text.CompareTo("")) Then
            Button_aniadir.Enabled = False
        Else
            Button_aniadir.Enabled = True
        End If

        'Si no hay nada seleccionado en tamaños y precios añadidos, no puede eliminarse nada
        If (ListBox_tamanioprecios.SelectedItem = 0) Then
            Button_aniadir.Enabled = False
        Else
            Button_aniadir.Enabled = True
        End If
    End Sub



    'BOTON AÑADIR
    Private Sub Button_aniadir_Click(sender As Object, e As EventArgs) Handles Button_aniadir.Click
        Dim precio As Integer
        precio = ListBox_precios.SelectedItem

    End Sub
    'BOTON ELIMINAR
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        'Eliminamos el item seleccionado
        ListBox_tamanioprecios.ClearSelected()

    End Sub
    'BOTON GUARDAR
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        'Guarda en el fichero
    End Sub
    'BOTON CANCELAR
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        'Volvemos a la pantalla de gestión de artículos
        Pantalla_admin_articulos.Show()
        Me.Hide()
    End Sub

    'NOMBRE VALIDADO
    Private Sub TextBox_nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nombre.TextChanged
        If (validacion.validarNombres(TextBox_nombre.Text) = False) Then
            MsgBox("El nombre solo puede contener caracteres.")
        End If
    End Sub

    'DESCRIPCIÓN VALIDA
    Private Sub TextBox_descripcion_TextChanged(sender As Object, e As EventArgs) Handles TextBox_descripcion.TextChanged

    End Sub

    'PRECIO VÁLIDO
    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precio.TextChanged
        Dim num1, num2 As Integer
        num1 = Integer.Parse(TextBox_precio.Text)
        num2 = Integer.Parse(TextBox_precio.Text)
        If (validacion.esNumero(num1) = False Or validacion.numeroMayorACero(num2) = False) Then
            MsgBox("En el precio solo pueden introducirse números")
        End If
    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub VisualizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentaToolStripMenuItem.Click

        'Se visualiza la venta actual del dia mediante un message box
        MsgBox("La venta actual del dia " & DateString & " a la hora " & TimeString & " es: 

                    " & Math.Round(ElementosComunes.venta, 2) & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")



    End Sub

    'FECHA Y HORA
    Private Sub Pantalla_eliminar_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Este boton no es disponible porque no hay mas pantallas
        'antes de esta
        VolverToolStripMenuItem.Enabled = False

        'Cuando se carga por primera vez el formulario se asigna a la variable venta 0
        'Teniendo en cuenta que no se puede salir de la aplicacion sin cerrar caja antes
        ElementosComunes.venta = 0

        'Cuando se carga la aplicacion cajaCerrada será true
        'Cuando se haga una venta este valor pasará a false
        ' y esta que no se haga el cierre de caja no se podra salir de la aplicacion
        ElementosComunes.cajaCerrada = True

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub


End Class