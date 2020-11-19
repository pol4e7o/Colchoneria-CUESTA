Public Class Gestión_de_empleados

    'Estas variables van a controlar el modo en que esta la pantalla
    Public alta As Boolean = False
    Public modificacion As Boolean = False
    Public baja As Boolean = False

    'El arraylist donde se van a guardar temporalmente los empleados
    Public empleados As ArrayList

    Private Sub Gestión_de_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Se deabilita la opcion gestion de empleados porque es este mismo formulario
        GestionDeEmpleadosToolStripMenuItem.Enabled = False

        'Se carga el arraylist de empleados del fichero


    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click

        Dim opcion As Integer

        'Se pregunta al usuario si esta seguro que desea cerrar caja
        opcion = MsgBox("Esta seguro que desea cerrar caja?", 4 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar caja")

        If opcion = MsgBoxResult.Yes Then

            'Se guarda en el fichero de ventas el dia, la hora, la venta y el usuario


            'Se cambia el valor de la variable venta a 0
            venta = 0

        End If

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

        Dim opcion As Integer

        If alta = True Or modificacion = True Or baja = True Then

            opcion = MsgBox("Esta seguro que desea volver a la pantalla de venta sin terminar la operacion?", 0 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

            If opcion = MsgBoxResult.Yes Then

                'Se abre la pantalla de venta y se cierra la de gestion de empleados


                Me.Close()

            End If

        Else

            'Se abre la pantalla de venta y se cierra la de gestion de empleados


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

    Private Sub GestionDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeArticulosToolStripMenuItem.Click

    End Sub

    Private Sub GestionDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeVentasToolStripMenuItem.Click

    End Sub

    Private Sub ColchoneriaCUESTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColchoneriaCUESTAToolStripMenuItem.Click

        'Se visualiza toda la informacion sobre la empresa
        MsgBox(ElementosComunes.informacionEmpresa, 0 + MsgBoxStyle.Information, "Informacion sobre Colchoneria CUESTA")


    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

        'Se abre el manual de usuario

    End Sub

    Private Sub boton_alta_Click(sender As Object, e As EventArgs) Handles boton_alta.Click

        'Se pasa el modo alta de contacto
        alta = True
        modificacion = False
        baja = False

        'Se cambia el texto del label indicando Alta de un empleado 
        label_elijaOpcion.Text = "Alta de un empleado"

    End Sub

    Private Sub TimerHoraReal_Tick(sender As Object, e As EventArgs) Handles TimerHoraReal.Tick

        'Por cada segundo que pasa se cambia el reloj
        label_hora.Text = "Hora: " & TimeString

    End Sub

    Private Sub activarBotonGuardarAlta()

        boton_guardar.Enabled = False

        'Se comprueba que todos los campos tienen el tamaño minimo 
        'Se devuelve true si los correctos y false sino
        If textBox_nombre.Text.Length <> 0 And textBox_apellidos.Text.Length <> 0 Then

            If textBox_direccion.Text.Length <> 0 And textBox_codigoPostal.Text.Length = 5 Then

                If textBox_telefono.Text.Length <> 0 And textBox_nombreUsuario.Text.Length >= 3 Then

                    If textBox_contrasenia.Text.Length = 4 And textBox_contrasenia2.Text.Length = 4 Then

                        If comboBox_roles.SelectedIndex <> -1 Then

                            boton_guardar.Enabled = True

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub textBox_codigoPostal_Leave(sender As Object, e As EventArgs) Handles textBox_codigoPostal.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()

    End Sub

    Private Sub textBox_apellidos_Leave(sender As Object, e As EventArgs) Handles textBox_apellidos.Leave

        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()

    End Sub

    Private Sub textBox_contrasenia_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub textBox_contrasenia2_Leave(sender As Object, e As EventArgs) Handles textBox_contrasenia2.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub textBox_direccion_Leave(sender As Object, e As EventArgs) Handles textBox_direccion.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub textBox_nombre_Leave(sender As Object, e As EventArgs) Handles textBox_nombre.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub textBox_nombreUsuario_Leave(sender As Object, e As EventArgs) Handles textBox_nombreUsuario.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub textBox_telefono_Leave(sender As Object, e As EventArgs) Handles textBox_telefono.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub comboBox_roles_Leave(sender As Object, e As EventArgs) Handles comboBox_roles.Leave
        'Si todos los campos tienen los caracteres minimos el boton guardar se activa
        activarBotonGuardarAlta()
    End Sub

    Private Sub boton_volver_Click(sender As Object, e As EventArgs) Handles boton_volver.Click

        Dim opcion As Integer

        'Se pregunta al usuario si desea volver sin terminar la operacion
        'El mensaje varia dependiendo del modo en el que esta el formulario (modo alta,
        'modo modificacion y modo baja)
        If alta = True Then

            opcion = MsgBox("Esta usted seguro que desea volver sin dar de alta al empleado?", 0 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        ElseIf modificacion = True Then

            opcion = MsgBox("Esta usted seguro que desea volver sin modificar los datos del empleado?", 0 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")

        Else

            opcion = MsgBox("Esta usted seguro que desea volver sin eliminar a un empleado?", 0 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Volver")


        End If

        If opcion = MsgBoxResult.Yes Then

            'El panel que contiene los datos de un empleado se hace invisible
            panel_elementosEmpleado.Visible = False

            'Se vacian todos los campos
            textBox_apellidos.Text = ""
            textBox_codigoPostal.Text = ""
            textBox_contrasenia.Text = ""
            textBox_contrasenia2.Text = ""
            textBox_direccion.Text = ""
            textBox_nombre.Text = ""
            textBox_nombreUsuario.Text = ""
            textBox_telefono.Text = ""

            alta = False
            modificacion = False
            baja = False

            label_elijaOpcion.Text = "Elija la opción que desea realizar pulsando el botón correspondiente"


        End If

    End Sub

    'Maneja guardar nuevo empleado, modificaciones de un empleado y eliminacion de un empleado
    Private Sub boton_guardar_Click(sender As Object, e As EventArgs) Handles boton_guardar.Click

        'Va a guardar la opcion elegido por el usuario en el message box
        Dim opcion As Integer

        If alta Then

            'Si se ha dado a guardar en modo alta de empleado
            opcion = MsgBox("¿Esta seguro que desea añadir el empleado?", 0 + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Dar de alta al empleado")

            If opcion = MsgBoxResult.Yes Then

                'Se crea un objeto de tipo empleado asignandole los datos personales
                Dim empleado As New Empleado.Empleado()

                'Se asigna el nombre del empleado
                empleado.setNombreEmpleado(textBox_nombre.Text)

                'Se asigna el/los apellido/s del empleado
                empleado.setNombreEmpleado(textBox_apellidos.Text)

                'Se asigna el direccion del empleado
                empleado.setNombreEmpleado(textBox_nombre.Text)


            End If
        ElseIf modificacion Then

        Else


        End If

    End Sub
End Class