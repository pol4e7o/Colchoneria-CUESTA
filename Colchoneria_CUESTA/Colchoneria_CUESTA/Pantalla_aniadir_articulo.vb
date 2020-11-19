Public Class Pantalla_aniadir_articulo
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
End Class