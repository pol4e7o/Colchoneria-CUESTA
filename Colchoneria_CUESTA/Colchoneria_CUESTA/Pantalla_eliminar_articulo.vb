Public Class Pantalla_eliminar_articulo
    'Este es el formulario creado para eliminar artículos
    Private Sub Pantalla_eliminar_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'El foco lo colocamos sobre el comboBox
        ComboBox_eliminar.Focus()

        'Se indica la fecha actual
        label_fecha.Text = "Fecha: " & DateString

        'Se indica la hora actual
        label_hora.Text = "Hora: " & TimeString

        'Comprobamos si el comoBox tiene algo seleccionado
        If (ComboBox_eliminar.SelectedItem = 0) Then
            Button_eliminar.Enabled = False
        Else
            Button_eliminar.Enabled = True
        End If
    End Sub

    'Programamos el botón cancelar
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        Pantalla_admin_articulos.Show()
        Me.Hide()
    End Sub

    'Programamos el botón eliminar
    Private Sub Button_eliminar_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        'Elimina articulo del fichero
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