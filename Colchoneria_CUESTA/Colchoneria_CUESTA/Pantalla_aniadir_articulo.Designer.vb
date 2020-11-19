<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_aniadir_articulo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox_categorias = New System.Windows.Forms.ComboBox()
        Me.ListBox_tamanioprecios = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Button_aniadir = New System.Windows.Forms.Button()
        Me.TextBox_precio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox_precios = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_descripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_nombre = New System.Windows.Forms.TextBox()
        Me.TimerHoraReal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta de un artículo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox_categorias)
        Me.Panel1.Controls.Add(Me.ListBox_tamanioprecios)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button_eliminar)
        Me.Panel1.Controls.Add(Me.Button_cancelar)
        Me.Panel1.Controls.Add(Me.Button_guardar)
        Me.Panel1.Controls.Add(Me.Button_aniadir)
        Me.Panel1.Controls.Add(Me.TextBox_precio)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ListBox_precios)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox_descripcion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox_nombre)
        Me.Panel1.Location = New System.Drawing.Point(16, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 397)
        Me.Panel1.TabIndex = 1
        '
        'ComboBox_categorias
        '
        Me.ComboBox_categorias.FormattingEnabled = True
        Me.ComboBox_categorias.Items.AddRange(New Object() {"Somier", "Colchón", "Canapé", "Tabla"})
        Me.ComboBox_categorias.Location = New System.Drawing.Point(150, 110)
        Me.ComboBox_categorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox_categorias.Name = "ComboBox_categorias"
        Me.ComboBox_categorias.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_categorias.TabIndex = 19
        '
        'ListBox_tamanioprecios
        '
        Me.ListBox_tamanioprecios.FormattingEnabled = True
        Me.ListBox_tamanioprecios.Location = New System.Drawing.Point(372, 180)
        Me.ListBox_tamanioprecios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox_tamanioprecios.Name = "ListBox_tamanioprecios"
        Me.ListBox_tamanioprecios.Size = New System.Drawing.Size(168, 134)
        Me.ListBox_tamanioprecios.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tamaños y precios seleccionados:"
        '
        'Button_eliminar
        '
        Me.Button_eliminar.Location = New System.Drawing.Point(295, 261)
        Me.Button_eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(56, 19)
        Me.Button_eliminar.TabIndex = 16
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.UseVisualStyleBackColor = True
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Location = New System.Drawing.Point(688, 366)
        Me.Button_cancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(56, 19)
        Me.Button_cancelar.TabIndex = 15
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = True
        '
        'Button_guardar
        '
        Me.Button_guardar.Location = New System.Drawing.Point(620, 366)
        Me.Button_guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(56, 19)
        Me.Button_guardar.TabIndex = 14
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.UseVisualStyleBackColor = True
        '
        'Button_aniadir
        '
        Me.Button_aniadir.Location = New System.Drawing.Point(295, 237)
        Me.Button_aniadir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_aniadir.Name = "Button_aniadir"
        Me.Button_aniadir.Size = New System.Drawing.Size(56, 19)
        Me.Button_aniadir.TabIndex = 12
        Me.Button_aniadir.Text = "Añadir"
        Me.Button_aniadir.UseVisualStyleBackColor = True
        '
        'TextBox_precio
        '
        Me.TextBox_precio.Location = New System.Drawing.Point(150, 299)
        Me.TextBox_precio.Name = "TextBox_precio"
        Me.TextBox_precio.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_precio.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio (en €)*:"
        '
        'ListBox_precios
        '
        Me.ListBox_precios.FormattingEnabled = True
        Me.ListBox_precios.Items.AddRange(New Object() {"80", "90", "105", "135", "150", "160", "180"})
        Me.ListBox_precios.Location = New System.Drawing.Point(150, 180)
        Me.ListBox_precios.Name = "ListBox_precios"
        Me.ListBox_precios.Size = New System.Drawing.Size(120, 95)
        Me.ListBox_precios.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tamaño (en CM)*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Categoría*:"
        '
        'TextBox_descripcion
        '
        Me.TextBox_descripcion.Location = New System.Drawing.Point(150, 62)
        Me.TextBox_descripcion.MaxLength = 40
        Me.TextBox_descripcion.Name = "TextBox_descripcion"
        Me.TextBox_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_descripcion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre completo*:"
        '
        'TextBox_nombre
        '
        Me.TextBox_nombre.Location = New System.Drawing.Point(150, 18)
        Me.TextBox_nombre.MaxLength = 20
        Me.TextBox_nombre.Name = "TextBox_nombre"
        Me.TextBox_nombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_nombre.TabIndex = 0
        '
        'TimerHoraReal
        '
        Me.TimerHoraReal.Enabled = True
        Me.TimerHoraReal.Interval = 1000
        '
        'Pantalla_aniadir_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pantalla_aniadir_articulo"
        Me.Text = "Añadir artículo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_nombre As TextBox
    Friend WithEvents TextBox_precio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox_precios As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_cancelar As Button
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Button_aniadir As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents ListBox_tamanioprecios As ListBox
    Friend WithEvents ComboBox_categorias As ComboBox
    Friend WithEvents TimerHoraReal As Timer
End Class
