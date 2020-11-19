<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_modificar_articulos
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_modificar = New System.Windows.Forms.ComboBox()
        Me.Button_modificar = New System.Windows.Forms.Button()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.TimerHoraReal = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículos:"
        '
        'ComboBox_modificar
        '
        Me.ComboBox_modificar.FormattingEnabled = True
        Me.ComboBox_modificar.Location = New System.Drawing.Point(16, 45)
        Me.ComboBox_modificar.Name = "ComboBox_modificar"
        Me.ComboBox_modificar.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_modificar.TabIndex = 1
        '
        'Button_modificar
        '
        Me.Button_modificar.Location = New System.Drawing.Point(186, 45)
        Me.Button_modificar.Name = "Button_modificar"
        Me.Button_modificar.Size = New System.Drawing.Size(75, 23)
        Me.Button_modificar.TabIndex = 2
        Me.Button_modificar.Text = "Modificar"
        Me.Button_modificar.UseVisualStyleBackColor = True
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Location = New System.Drawing.Point(713, 415)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_cancelar.TabIndex = 3
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = True
        '
        'TimerHoraReal
        '
        Me.TimerHoraReal.Enabled = True
        Me.TimerHoraReal.Interval = 1000
        '
        'Pantalla_modificar_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_cancelar)
        Me.Controls.Add(Me.Button_modificar)
        Me.Controls.Add(Me.ComboBox_modificar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pantalla_modificar_articulos"
        Me.Text = "Pantalla_modificar_articulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_modificar As ComboBox
    Friend WithEvents Button_modificar As Button
    Friend WithEvents Button_cancelar As Button
    Friend WithEvents TimerHoraReal As Timer
End Class
