Imports System.IO

Public Class Pantalla_principal

    Private Sub Pantalla_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Este boton no es disponible porque no hay mas pantallas
        'antes de esta
        VolverToolStripMenuItem.Visible = False



        'Se lee del fichero VentaActual la venta 
        FileOpen(5, "VentaActual.txt", OpenMode.Input)

        'Se guarda el valor del fichero en la varibale venta
        Input(5, ElementosComunes.venta)

        'Se cierra el fichero
        FileClose(5)


        'Cuando se carga la aplicacion se comprueba si el valor de la variable leida del fichero
        'VentaActual es diferente a 0. Si lo es se le pasa a la variable cajaCerrada false, sino true
        If venta = 0 Then
            ElementosComunes.cajaCerrada = True

        Else
            ElementosComunes.cajaCerrada = False

        End If





        'Se cargan todos los empleados del fichero de empleados
        FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Read, , Len(empleadoRegistro))

        'Se lee todo su contenido hasta que no se llegue al final del fichero
        While Not EOF(1)

            'Se recoge el siguente empleado
            FileGet(1, empleadoRegistro, )

            'Utilizando el registro recogido se crea un objeto de tipo Empleado y se añade al arraylist
            empleados.Add(New GestionComercial.Empleado(empleadoRegistro.codigoEmpleado, empleadoRegistro.nombre, empleadoRegistro.apellidos, empleadoRegistro.direccion, empleadoRegistro.codigoPostal,
                            empleadoRegistro.telefono, empleadoRegistro.nombreUsuario, empleadoRegistro.contrasenia, empleadoRegistro.esAdministrador))

        End While

        'Se cierra el fichero de empleados
        FileClose(1)



        'Se cargan todos los articulos del fichero de articulos
        FileOpen(2, "Articulos.txt", OpenMode.Random, OpenAccess.Read, , Len(articuloRegistro))

        'Se lee todo su contenido hasta que no se llegue al final del fichero
        While Not EOF(2)

            'Se recoge el siguente articulo
            FileGet(2, articuloRegistro, )

            'Utilizando el registro recogido se crea un objeto de tipo Articulo y se añade al arraylist
            articulos.Add(New GestionComercial.Articulo(articuloRegistro.codigoArticulo, articuloRegistro.nombre, articuloRegistro.descripcion,
                            articuloRegistro.categoria))

            articulos.Item(articulos.Count - 1).setTamaniosPrecios(articuloRegistro.tamanios.ToList, articuloRegistro.precios.ToList)

        End While

        'Se cierra el acceso al fichero de articulos
        FileClose(2)

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
        opcion = MsgBox("Para poder realizar el cierre de caja primero tiene que identificarse. Desea ser dirigido a la pantalla de inicio de secion?", 4 + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Cierre de caja")

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
