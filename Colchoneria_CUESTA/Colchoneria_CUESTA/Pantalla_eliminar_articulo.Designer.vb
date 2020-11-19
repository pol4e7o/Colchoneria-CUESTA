<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_eliminar_articulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_eliminar = New System.Windows.Forms.ComboBox()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eliminar artículo:"
        '
        'ComboBox_eliminar
        '
        Me.ComboBox_eliminar.FormattingEnabled = True
        Me.ComboBox_eliminar.Location = New System.Drawing.Point(21, 54)
        Me.ComboBox_eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox_eliminar.Name = "ComboBox_eliminar"
        Me.ComboBox_eliminar.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox_eliminar.TabIndex = 1
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Location = New System.Drawing.Point(224, 54)
        Me.Button_eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(100, 28)
        Me.Button_eliminar.TabIndex = 2
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.UseVisualStyleBackColor = True
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Location = New System.Drawing.Point(951, 511)
        Me.Button_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(100, 28)
        Me.Button_cancelar.TabIndex = 3
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = True
        '
        'Pantalla_eliminar_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button_cancelar)
        Me.Controls.Add(Me.Button_eliminar)
        Me.Controls.Add(Me.ComboBox_eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Pantalla_eliminar_articulo"
        Me.Text = "Pantalla_eliminar_articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_eliminar As ComboBox
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents Button_cancelar As Button
End Class
