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
        If (ComboBox_modificar.SelectedItem = 0) Then
            Button_modificar.Enabled = False
        Else
            Button_modificar.Enabled = True
        End If
    End Sub

    'PULSAMOS EL BOTÖN MODIFICAR
    Private Sub Button_modificar_Click(sender As Object, e As EventArgs) Handles Button_modificar.Click
        Subpantalla_modificar_articulo.Show()
        Me.Hide()
    End Sub

    'BOTON CANCELAR
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        Pantalla_admin_articulos.Show()
        Me.Hide()
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
End Class