Public Class Pantalla_eliminar_articulo
    'Este es el formulario creado para eliminar artículos
    Private Sub Pantalla_eliminar_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'El foco lo colocamos sobre el comboBox
        ComboBox_eliminar.Focus()
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
End Class