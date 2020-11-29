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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_aniadir_articulo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox_precios = New System.Windows.Forms.ListBox()
        Me.Label_camposObligatorios = New System.Windows.Forms.Label()
        Me.Panel_precioYTamanio = New System.Windows.Forms.Panel()
        Me.ComboBox_tamanio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_precio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button_aniadir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_categorias = New System.Windows.Forms.ComboBox()
        Me.ListBox_tamanios = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_eliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_descripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_nombre = New System.Windows.Forms.TextBox()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.TimerHoraReal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label_ayuda = New System.Windows.Forms.Label()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.label_hora = New System.Windows.Forms.Label()
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
        Me.GestionDeErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel_precioYTamanio.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta de un artículo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ListBox_precios)
        Me.Panel1.Controls.Add(Me.Label_camposObligatorios)
        Me.Panel1.Controls.Add(Me.Panel_precioYTamanio)
        Me.Panel1.Controls.Add(Me.ComboBox_categorias)
        Me.Panel1.Controls.Add(Me.ListBox_tamanios)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button_eliminar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox_descripcion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox_nombre)
        Me.Panel1.Location = New System.Drawing.Point(171, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 325)
        Me.Panel1.TabIndex = 1
        '
        'ListBox_precios
        '
        Me.ListBox_precios.FormattingEnabled = True
        Me.ListBox_precios.Location = New System.Drawing.Point(505, 61)
        Me.ListBox_precios.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_precios.Name = "ListBox_precios"
        Me.ListBox_precios.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox_precios.Size = New System.Drawing.Size(86, 199)
        Me.ListBox_precios.TabIndex = 27
        '
        'Label_camposObligatorios
        '
        Me.Label_camposObligatorios.AutoSize = True
        Me.Label_camposObligatorios.Location = New System.Drawing.Point(39, 24)
        Me.Label_camposObligatorios.Name = "Label_camposObligatorios"
        Me.Label_camposObligatorios.Size = New System.Drawing.Size(111, 13)
        Me.Label_camposObligatorios.TabIndex = 26
        Me.Label_camposObligatorios.Text = "Campos obligatorios *:"
        '
        'Panel_precioYTamanio
        '
        Me.Panel_precioYTamanio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_precioYTamanio.Controls.Add(Me.ComboBox_tamanio)
        Me.Panel_precioYTamanio.Controls.Add(Me.Label3)
        Me.Panel_precioYTamanio.Controls.Add(Me.TextBox_precio)
        Me.Panel_precioYTamanio.Controls.Add(Me.Label7)
        Me.Panel_precioYTamanio.Controls.Add(Me.Button_aniadir)
        Me.Panel_precioYTamanio.Controls.Add(Me.Label6)
        Me.Panel_precioYTamanio.Location = New System.Drawing.Point(16, 180)
        Me.Panel_precioYTamanio.Name = "Panel_precioYTamanio"
        Me.Panel_precioYTamanio.Size = New System.Drawing.Size(351, 126)
        Me.Panel_precioYTamanio.TabIndex = 25
        '
        'ComboBox_tamanio
        '
        Me.ComboBox_tamanio.FormattingEnabled = True
        Me.ComboBox_tamanio.Items.AddRange(New Object() {"80", "90", "105", "120", "135", "150", "160", "180"})
        Me.ComboBox_tamanio.Location = New System.Drawing.Point(126, 84)
        Me.ComboBox_tamanio.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox_tamanio.Name = "ComboBox_tamanio"
        Me.ComboBox_tamanio.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox_tamanio.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Introducir tamaño y precio "
        '
        'TextBox_precio
        '
        Me.TextBox_precio.Location = New System.Drawing.Point(126, 48)
        Me.TextBox_precio.Name = "TextBox_precio"
        Me.TextBox_precio.Size = New System.Drawing.Size(92, 20)
        Me.TextBox_precio.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio (en €):"
        '
        'Button_aniadir
        '
        Me.Button_aniadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button_aniadir.Location = New System.Drawing.Point(248, 52)
        Me.Button_aniadir.Name = "Button_aniadir"
        Me.Button_aniadir.Size = New System.Drawing.Size(83, 53)
        Me.Button_aniadir.TabIndex = 21
        Me.Button_aniadir.Text = "Añadir"
        Me.Button_aniadir.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tamaño (en CM):"
        '
        'ComboBox_categorias
        '
        Me.ComboBox_categorias.FormattingEnabled = True
        Me.ComboBox_categorias.Items.AddRange(New Object() {"Somier", "Colchon", "Canape", "Base", "Ofertas", "Otros"})
        Me.ComboBox_categorias.Location = New System.Drawing.Point(143, 138)
        Me.ComboBox_categorias.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox_categorias.Name = "ComboBox_categorias"
        Me.ComboBox_categorias.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_categorias.TabIndex = 19
        '
        'ListBox_tamanios
        '
        Me.ListBox_tamanios.FormattingEnabled = True
        Me.ListBox_tamanios.Location = New System.Drawing.Point(415, 61)
        Me.ListBox_tamanios.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_tamanios.Name = "ListBox_tamanios"
        Me.ListBox_tamanios.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox_tamanios.Size = New System.Drawing.Size(93, 199)
        Me.ListBox_tamanios.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(412, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tamaños y precios seleccionados*:"
        '
        'Button_eliminar
        '
        Me.Button_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button_eliminar.Location = New System.Drawing.Point(473, 265)
        Me.Button_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_eliminar.Name = "Button_eliminar"
        Me.Button_eliminar.Size = New System.Drawing.Size(73, 48)
        Me.Button_eliminar.TabIndex = 16
        Me.Button_eliminar.Text = "Eliminar"
        Me.Button_eliminar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Categoría*:"
        '
        'TextBox_descripcion
        '
        Me.TextBox_descripcion.Location = New System.Drawing.Point(143, 100)
        Me.TextBox_descripcion.MaxLength = 40
        Me.TextBox_descripcion.Name = "TextBox_descripcion"
        Me.TextBox_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_descripcion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre*:"
        '
        'TextBox_nombre
        '
        Me.TextBox_nombre.Location = New System.Drawing.Point(143, 61)
        Me.TextBox_nombre.MaxLength = 20
        Me.TextBox_nombre.Name = "TextBox_nombre"
        Me.TextBox_nombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_nombre.TabIndex = 0
        '
        'Button_cancelar
        '
        Me.Button_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button_cancelar.Location = New System.Drawing.Point(301, 468)
        Me.Button_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(105, 45)
        Me.Button_cancelar.TabIndex = 15
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = False
        '
        'Button_guardar
        '
        Me.Button_guardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button_guardar.Location = New System.Drawing.Point(172, 468)
        Me.Button_guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(106, 45)
        Me.Button_guardar.TabIndex = 14
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'TimerHoraReal
        '
        Me.TimerHoraReal.Enabled = True
        Me.TimerHoraReal.Interval = 1000
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
        Me.Panel2.Location = New System.Drawing.Point(2, 538)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(956, 42)
        Me.Panel2.TabIndex = 28
        '
        'label_ayuda
        '
        Me.label_ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label_ayuda.AutoSize = True
        Me.label_ayuda.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label_ayuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_ayuda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_ayuda.Location = New System.Drawing.Point(10, 9)
        Me.label_ayuda.Name = "label_ayuda"
        Me.label_ayuda.Size = New System.Drawing.Size(88, 22)
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
        Me.label_fecha.Location = New System.Drawing.Point(611, 9)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(64, 22)
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
        Me.label_hora.Location = New System.Drawing.Point(802, 9)
        Me.label_hora.Name = "label_hora"
        Me.label_hora.Size = New System.Drawing.Size(54, 22)
        Me.label_hora.TabIndex = 3
        Me.label_hora.Text = "Hora: "
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(958, 54)
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
        Me.CerrarCajaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CerrarCajaToolStripMenuItem.Text = "Cerrar caja"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
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
        Me.VisualizarVentaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.VisualizarVentaToolStripMenuItem.Text = "Visualizar venta"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.AutoSize = False
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeArticulosToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem, Me.GestionDeErroresToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(150, 70)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados"
        '
        'GestionDeArticulosToolStripMenuItem
        '
        Me.GestionDeArticulosToolStripMenuItem.Name = "GestionDeArticulosToolStripMenuItem"
        Me.GestionDeArticulosToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.GestionDeArticulosToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.GestionDeArticulosToolStripMenuItem.Text = "Gestion de articulos"
        '
        'GestionDeVentasToolStripMenuItem
        '
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
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
        Me.ColchoneriaCUESTAToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
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
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'GestionDeErroresToolStripMenuItem
        '
        Me.GestionDeErroresToolStripMenuItem.Name = "GestionDeErroresToolStripMenuItem"
        Me.GestionDeErroresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.GestionDeErroresToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.GestionDeErroresToolStripMenuItem.Text = "Gestion de errores"
        '
        'Pantalla_aniadir_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 579)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_cancelar)
        Me.Controls.Add(Me.Button_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_aniadir_articulo"
        Me.Text = "Colchoneria CUESTA - Gesion de articulos - Añadir artículo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_precioYTamanio.ResumeLayout(False)
        Me.Panel_precioYTamanio.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_cancelar As Button
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_eliminar As Button
    Friend WithEvents ListBox_tamanios As ListBox
    Friend WithEvents ComboBox_categorias As ComboBox
    Friend WithEvents TimerHoraReal As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents label_ayuda As Label
    Friend WithEvents label_fecha As Label
    Friend WithEvents label_hora As Label
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
    Friend WithEvents Label_camposObligatorios As Label
    Friend WithEvents Panel_precioYTamanio As Panel
    Friend WithEvents ComboBox_tamanio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_precio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button_aniadir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox_precios As ListBox
    Friend WithEvents GestionDeErroresToolStripMenuItem As ToolStripMenuItem
End Class
