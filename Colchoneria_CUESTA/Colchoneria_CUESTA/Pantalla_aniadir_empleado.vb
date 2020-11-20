Public Class Pantalla_aniadir_empleado

    'El arraylist donde se van a guardar temporalmente los empleados
    Public empleados As ArrayList

    Private Sub Pantalla_aniadir_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'El primer elemento del formulario tiene el foco
        textBox_nombre.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Por defecto el boton guardar viene desactivado
        'Para activarlo todos los campos tienen que tener valores correctos
        boton_guardar.Enabled = False

        'Se carga el arraylist de empleados del fichero


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

            informe = "Informe de venta de: " & vbNewLine &
            Now & vbNewLine &
            "Total: " & venta & "€" & vbNewLine &
            "Cierre de caja hecha por: " & vbNewLine &
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

        'La opcion elegida por el usuario a la hora de decidir si desea volver a gestion de empleados
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea volver a la pantalla de gestion de empleados sin terminar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de alta de empleado
            Pantalla_admin_empleados.Show()
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

                    " & ElementosComunes.venta & "€", 0 + MsgBoxStyle.Information, "Visualizar venta")


    End Sub

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

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")


    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        'Se abre el manual de usuario

    End Sub

    Private Sub boton_guardar_Click(sender As Object, e As EventArgs) Handles boton_guardar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea guardar el nuevo cliente 
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea crear el nuevo empleado?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Alta de empleado")

        If opcion = MsgBoxResult.Yes Then

            'Se guarda el empleado dentro del fichero de empleados


            'Se vuelve a la pantalla de gestion de empleados
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub boton_cancelar_Click(sender As Object, e As EventArgs) Handles boton_cancelar.Click

        'La opcion elegida por el usuario a la hora de decidir si desea cancelar la operacion
        Dim opcion As Integer

        opcion = MsgBox("Esta seguro que desea cancelar la operacion?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cancelar")

        If opcion = MsgBoxResult.Yes Then

            'Se abre la pantalla de gestion de empleados y se cierra la de baja de empleado
            Pantalla_admin_empleados.Show()
            Me.Close()

        End If

    End Sub

    Private Sub textBox_codigoPostal_Leave(sender As Object, e As EventArgs) Handles textBox_codigoPostal.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.numeroMayorACero(textBox_codigoPostal.Text) And textBox_codigoPostal.Text.Length = 5 Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de codigo postal
            MsgBox("El codigo postal puede contener solo 5 numeros. Por favor intente introducir el valor del codigo postal de nuevo.", 0 + MsgBoxStyle.Information, "Codigo postal incorrecto")
            textBox_codigoPostal.Focus()

        End If



    End Sub

    Private Sub textBox_apellidos_Leave(sender As Object, e As EventArgs) Handles textBox_apellidos.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_apellidos.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de apellido/s
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo apellido/s de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_apellidos.Focus()

        End If

    End Sub

    Private Sub textBox_contrasenia_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.esNumero(textBox_contrasenia.Text) And textBox_contrasenia.Text.Length = 4 Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonGuardarAlta()

            End If

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de contraseña
            MsgBox("La contraseña debe contener exactamente 4 numeros. Por favor intente introducir la contraseña de nuevo.", 0 + MsgBoxStyle.Information, "Contraseña incorrecta")
            textBox_contrasenia.Focus()

        End If

    End Sub

    Private Sub textBox_contrasenia2_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia2.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.numeroMayorACero(textBox_contrasenia.Text) And textBox_contrasenia.Text.Length = 4 Then

            'Para activar el boton las dos contraseñas tienen que coincidir
            If textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                'Si todos los campos tienen los caracteres minimos el boton guardar se activa
                activarBotonGuardarAlta()

            Else

                'Se le indica al usuario que las dos contraseñas no son iguales
                MsgBox("Las dos contraseñas no coinciden. Por favor introducelas de nuevo.", 0 + MsgBoxStyle.Information, "Contraseñas incorrectas")

                'Se borran los datos de los dos campos y se pasa el foco a la primera contraseña (original)
                textBox_contrasenia2.Text = ""
                textBox_contrasenia.Text = ""
                textBox_contrasenia.Focus()


            End If


        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de repetir contraseña
            MsgBox("La contraseña debe contener exactamente 4 numeros. Por favor intente introducir la contraseña de nuevo.", 0 + MsgBoxStyle.Information, "Contraseña incorrecta")
            textBox_contrasenia2.Focus()

        End If

    End Sub

    Private Sub textBox_direccion_Leave(sender As Object, e As EventArgs) Handles textBox_direccion.Leave

        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()

    End Sub

    Private Sub textBox_nombre_Leave(sender As Object, e As EventArgs) Handles textBox_nombre.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_nombre.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre
            MsgBox("Los nombres y apellidos pueden contener solo letras, espacios en blanco y guiones. Por favor intente introducir el valor del campo nombre de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_nombre.Focus()

        End If

    End Sub

    Private Sub textBox_nombreUsuario_Leave(sender As Object, e As EventArgs) Handles textBox_nombreUsuario.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNombres(textBox_nombreUsuario.Text) And textBox_nombreUsuario.Text.Length >= 3 And textBox_nombreUsuario.Text.Contains(" ") = False And textBox_nombreUsuario.Text.Contains("-") = False Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de nombre de usuario
            MsgBox("El nombres de usuario puede contener solo letras con un minimo de 3 caracteres. Por favor intente introducir el valor del campo nombre de usuario de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_nombreUsuario.Focus()

        End If

    End Sub

    Private Sub textBox_telefono_Leave(sender As Object, e As EventArgs) Handles textBox_telefono.Leave

        'Si los datos introducidos en el campo son correctos se comprueba si se puede activar el boton guardar
        If validacion.validarNumeroTelefono(textBox_telefono.Text) Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        Else

            'Se le indica al usuario que el dato es incorreto y el foco vuelve al campo de telefono
            MsgBox("El telefono puede contener solo numeros, espacion en blanco y como primeros caractres ""(+  )"" o ""+"". Por favor intente introducir el valor del campo telefono de nuevo.", 0 + MsgBoxStyle.Information, "Valor de apellidos incorrecto")
            textBox_telefono.Focus()

        End If

    End Sub

    Private Sub comboBox_roles_Leave(sender As Object, e As EventArgs) Handles comboBox_roles.Leave

        'Si se ha elegido un elemento se intenta activar el boton guardar
        If comboBox_roles.SelectedIndex <> -1 Then

            'Si todos los campos tienen los caracteres minimos el boton guardar se activa
            activarBotonGuardarAlta()

        End If

    End Sub

    Private Sub activarBotonGuardarAlta()

        boton_guardar.Enabled = False

        'Se comprueba que todos los campos tienen el tamaño minimo 
        'Si son correctos se activa el boton
        If textBox_nombre.Text.Length <> 0 And textBox_apellidos.Text.Length <> 0 Then

            If textBox_direccion.Text.Length <> 0 And textBox_codigoPostal.Text.Length = 5 Then

                If textBox_telefono.Text.Length <> 0 And textBox_nombreUsuario.Text.Length >= 3 Then

                    If textBox_contrasenia.Text.Length = 4 And textBox_contrasenia2.Text.Length = 4 Then

                        If comboBox_roles.SelectedIndex <> -1 And textBox_contrasenia.Text.Equals(textBox_contrasenia2.Text) Then

                            boton_guardar.Enabled = True

                        End If

                    End If

                End If

            End If

        End If

    End Sub

End Class