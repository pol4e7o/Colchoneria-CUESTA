Public Class Pantalla_aniadir_articulo
    Private Sub Pantalla_aniadir_articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el foco sobre el primer comboBox
        TextBox_nombre.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        Pantalla_admin.Show()
        Me.Hide()
    End Sub
End Class