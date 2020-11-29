<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_de_ventas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_ventaElegida = New System.Windows.Forms.Label()
        Me.Label_venta = New System.Windows.Forms.Label()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.Button_visualizar = New System.Windows.Forms.Button()
        Me.ComboBox_dia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_gestionVenta = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label_ayuda = New System.Windows.Forms.Label()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.label_hora = New System.Windows.Forms.Label()
        Me.TimerHoraReal = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColchoneriaCUESTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label_ventaElegida)
        Me.Panel1.Controls.Add(Me.Label_venta)
        Me.Panel1.Controls.Add(Me.Button_cancelar)
        Me.Panel1.Controls.Add(Me.Button_visualizar)
        Me.Panel1.Controls.Add(Me.ComboBox_dia)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(100, 169)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 247)
        Me.Panel1.TabIndex = 0
        '
        'Label_ventaElegida
        '
        Me.Label_ventaElegida.AutoSize = True
        Me.Label_ventaElegida.Location = New System.Drawing.Point(495, 50)
        Me.Label_ventaElegida.Name = "Label_ventaElegida"
        Me.Label_ventaElegida.Size = New System.Drawing.Size(0, 17)
        Me.Label_ventaElegida.TabIndex = 7
        '
        'Label_venta
        '
        Me.Label_venta.AutoSize = True
        Me.Label_venta.Location = New System.Drawing.Point(495, 17)
        Me.Label_venta.Name = "Label_venta"
        Me.Label_venta.Size = New System.Drawing.Size(140, 17)
        Me.Label_venta.TabIndex = 6
        Me.Label_venta.Text = "Venta seleccionada: "
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Location = New System.Drawing.Point(804, 294)
        Me.Button_cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(101, 23)
        Me.Button_cancelar.TabIndex = 5
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = True
        '
        'Button_visualizar
        '
        Me.Button_visualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button_visualizar.Location = New System.Drawing.Point(39, 167)
        Me.Button_visualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_visualizar.Name = "Button_visualizar"
        Me.Button_visualizar.Size = New System.Drawing.Size(130, 44)
        Me.Button_visualizar.TabIndex = 4
        Me.Button_visualizar.Text = "Visualizar"
        Me.Button_visualizar.UseVisualStyleBackColor = False
        '
        'ComboBox_dia
        '
        Me.ComboBox_dia.FormattingEnabled = True
        Me.ComboBox_dia.Location = New System.Drawing.Point(39, 112)
        Me.ComboBox_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_dia.Name = "ComboBox_dia"
        Me.ComboBox_dia.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_dia.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seleccione el día de venta que desea visualizar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Venta en el día... a la hora...:0€"
        '
        'Label_gestionVenta
        '
        Me.Label_gestionVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_gestionVenta.AutoSize = True
        Me.Label_gestionVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_gestionVenta.Location = New System.Drawing.Point(446, 112)
        Me.Label_gestionVenta.Name = "Label_gestionVenta"
        Me.Label_gestionVenta.Size = New System.Drawing.Size(211, 29)
        Me.Label_gestionVenta.TabIndex = 0
        Me.Label_gestionVenta.Text = "Gestión de ventas:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.label_ayuda)
        Me.Panel2.Controls.Add(Me.label_fecha)
        Me.Panel2.Controls.Add(Me.label_hora)
        Me.Panel2.Location = New System.Drawing.Point(0, 512)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1135, 51)
        Me.Panel2.TabIndex = 8
        '
        'label_ayuda
        '
        Me.label_ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label_ayuda.AutoSize = True
        Me.label_ayuda.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label_ayuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_ayuda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_ayuda.Location = New System.Drawing.Point(13, 11)
        Me.label_ayuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_ayuda.Name = "label_ayuda"
        Me.label_ayuda.Size = New System.Drawing.Size(111, 27)
        Me.label_ayuda.TabIndex = 1
        Me.label_ayuda.Text = "F1 - Ayuda"
        Me.label_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_fecha
        '
        Me.label_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_fecha.AutoSize = True
        Me.label_fecha.BackColor = System.Drawing.Color.White
        Me.label_fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_fecha.Location = New System.Drawing.Point(677, 11)
        Me.label_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(80, 27)
        Me.label_fecha.TabIndex = 2
        Me.label_fecha.Text = "Fecha: "
        '
        'label_hora
        '
        Me.label_hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_hora.AutoSize = True
        Me.label_hora.BackColor = System.Drawing.Color.White
        Me.label_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_hora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_hora.Location = New System.Drawing.Point(931, 11)
        Me.label_hora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_hora.Name = "label_hora"
        Me.label_hora.Size = New System.Drawing.Size(67, 27)
        Me.label_hora.TabIndex = 3
        Me.label_hora.Text = "Hora: "
        '
        'TimerHoraReal
        '
        Me.TimerHoraReal.Enabled = True
        Me.TimerHoraReal.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1135, 74)
        Me.MenuStrip.TabIndex = 29
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.AutoSize = False
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarCajaToolStripMenuItem, Me.ToolStripSeparator2, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(150, 70)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarCajaToolStripMenuItem
        '
        Me.CerrarCajaToolStripMenuItem.Name = "CerrarCajaToolStripMenuItem"
        Me.CerrarCajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CerrarCajaToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.CerrarCajaToolStripMenuItem.Text = "Cerrar caja"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(202, 6)
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.AutoSize = False
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarVentaToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(150, 70)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'VisualizarVentaToolStripMenuItem
        '
        Me.VisualizarVentaToolStripMenuItem.Name = "VisualizarVentaToolStripMenuItem"
        Me.VisualizarVentaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.VisualizarVentaToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.VisualizarVentaToolStripMenuItem.Text = "Visualizar venta"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.AutoSize = False
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeArticulosToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(152, 70)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(338, 26)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados"
        '
        'GestionDeArticulosToolStripMenuItem
        '
        Me.GestionDeArticulosToolStripMenuItem.Name = "GestionDeArticulosToolStripMenuItem"
        Me.GestionDeArticulosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.GestionDeArticulosToolStripMenuItem.Size = New System.Drawing.Size(338, 26)
        Me.GestionDeArticulosToolStripMenuItem.Text = "Gestion de articulos"
        '
        'GestionDeVentasToolStripMenuItem
        '
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(338, 26)
        Me.GestionDeVentasToolStripMenuItem.Text = "Gestion de ventas"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.AutoSize = False
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColchoneriaCUESTAToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(150, 70)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'ColchoneriaCUESTAToolStripMenuItem
        '
        Me.ColchoneriaCUESTAToolStripMenuItem.Name = "ColchoneriaCUESTAToolStripMenuItem"
        Me.ColchoneriaCUESTAToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ColchoneriaCUESTAToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.ColchoneriaCUESTAToolStripMenuItem.Text = "Colchoneria CUESTA"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.AutoSize = False
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(150, 70)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'Gestion_de_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1135, 563)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label_gestionVenta)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Gestion_de_ventas"
        Me.Text = "Gestion de ventas - Colchonería CUESTA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents label_ayuda As Label
    Friend WithEvents label_fecha As Label
    Friend WithEvents label_hora As Label
    Friend WithEvents Button_cancelar As Button
    Friend WithEvents Button_visualizar As Button
    Friend WithEvents ComboBox_dia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_gestionVenta As Label
    Friend WithEvents TimerHoraReal As Timer
    Friend WithEvents Label_ventaElegida As Label
    Friend WithEvents Label_venta As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColchoneriaCUESTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
End Class
