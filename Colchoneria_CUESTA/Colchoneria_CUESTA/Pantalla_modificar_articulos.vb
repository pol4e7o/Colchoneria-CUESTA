Public Class Pantalla_modificar_articulos
    'ARRANCAMOS EL FORMULARIO
    Private Sub Pantalla_modificar_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el foco sobre el comboBox que nos interesa
        ComboBox_modificar.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Comprobar si se puede pulsar el botón modificar
        If (ComboBox_modificar.SelectedItem < 0) Then
            Button_modificar.Enabled = False
        Else
            Button_modificar.Enabled = True
        End If
        'Comprobar si se puede pulsar el botón aniadir
        Button_aniadir.Enabled = False
        'Comprobar si se puede pulsar el botón aniadir
        Button_eliminar.Enabled = False

    End Sub
    'MENU
    'CERRAR CAJA
    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click
        'La opcion elegida por el usuario a cerca de si desea cerrar caja
        Dim opcion As Integer

        'Esta variable va a almacenar el informe del cierre de caja 
        'que se va a visualizar en un message box
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

    'VOLVER
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

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

    Private Sub ComboBox_modificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_modificar.SelectedIndexChanged
        activarBotonModificar()
        'Si se ha elegido un empleado de los de la lista se activa el boton guardar
        If ComboBox_modificar.SelectedIndex <> -1 Then

            'Se coge el objeto elegido y sus datos se introducen en los campos de texto

            'Introducir los datos del empleado
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            ComboBox_categorias.SelectedItem = -1
            TextBox_precio.Text = ""
            TextBox_tamanio.Text = ""
            ListBox_tamaniosprecios.Items.Clear()

            'Se habilita el boton guardar
            Button_modificar.Enabled = True

        Else

            'Se vacian los campos de texto
            TextBox_nombre.Text = ""
            TextBox_descripcion.Text = ""
            ComboBox_categorias.SelectedItem = -1
            TextBox_precio.Text = ""
            TextBox_tamanio.Text = ""
            ListBox_tamaniosprecios.Items.Clear()

        End If
    End Sub


    'BOTONES--------------------------------------------------------------------------------------------------------------------------------------------
    'BOTON AÑADIR
    Private Sub Button_aniadir_Click(sender As Object, e As EventArgs) Handles Button_aniadir.Click
        Dim precio As String = TextBox_precio.Text.ToString
        Dim tamanio As String = TextBox_tamanio.Text.ToString
        Dim a As String = "precio: " + precio + " tamaño: " + tamanio
        ListBox_tamaniosprecios.Items.Add(a)
    End Sub
    'BOTON ELIMINAR
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        'Eliminamos el item seleccionado
        ListBox_tamanioprecios.ClearSelected()
    End Sub
    'BOTON MODIFICAR
    Private Sub Button_modificar_Click_1(sender As Object, e As EventArgs) Handles Button_modificar.Click
        'La opcion elegida por el usuario a la hora de decidir si desea guardar el cliente modificado
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea modificar el artículo?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de empleado")

        If opcion = MsgBoxResult.Yes Then

            'Se modifica dentro del arraylist y despues se sobrescribe el fichero de empleados


            'Se vuelve a la pantalla de gestion de empleados
            Pantalla_admin_articulos.Show()
            Me.Close()

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

            If ComboBox_categorias.SelectedItem < 0 Then

                If ListBox_tamaniosprecios.Items.Count <> 0 And TextBox_precio.Text.Length <> 0 Then

                    Button_guardar.Enabled = True

                End If

            End If

        End If
    End Sub
    'ACTIVAR BOTON ANIADIR
    Private Sub activarBotonAniadir()
        Button_aniadir.Enabled = False
        'Se comprueba que todos los campos necesarios están rellenos
        If TextBox_tamanio.Text.Length <> 0 And TextBox_precio.Text.Length <> 0 Then
            Button_aniadir.Enabled = True
        End If
    End Sub
    'ACTIVAR BOTON ELIMINAR
    Private Sub activarBotonEliminar()
        Button_eliminar.Enabled = False
        'Se comprueba que todos los campos necesarios están rellenos
        If ListBox_tamaniosprecios.SelectedItem Then
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
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(TextBox_nombre.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            'activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo nombre de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            TextBox_nombre.Focus()

        End If
    End Sub
    'DESCRIPCION
    Private Sub TextBox_descripcion_TextChanged(sender As Object, e As EventArgs) Handles TextBox_descripcion.Leave
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(TextBox_descripcion.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            'activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Las descripciones pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo nombre de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            TextBox_nombre.Focus()

        End If
    End Sub

    'CATEGORIA
    Private Sub ComboBox_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_categorias.SelectedIndexChanged
        activarBotonModificar()
    End Sub


    Private Sub TextBox_precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precio.Leave
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton añadir
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

    Private Sub TextBox_tamanio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_tamanio.TextChanged
        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton añadir
        If validacion.esNumero(TextBox_tamanio.Text) Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If validacion.numeroMayorACero(TextBox_tamanio.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonAniadir()
            Else
                MsgBox("Por favor introduzca de precio, que sea superior a 0€.", 0 + MsgBoxStyle.Information, "Precio incorrecto")
                TextBox_tamanio.Focus()

            End If

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de contraseña
            MsgBox("Por favor introduzca de precio, que solo sean números.", 0 + MsgBoxStyle.Information, "Precio incorrecto")
            TextBox_tamanio.Focus()

        End If
    End Sub

    'LISTBOX PRECIOTAMAÑO
    Private Sub ListBox_tamanioprecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_tamaniosprecios.SelectedIndexChanged
        activarBotonEliminar()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class