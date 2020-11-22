<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_de_venta
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label_ayuda = New System.Windows.Forms.Label()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.label_hora = New System.Windows.Forms.Label()
        Me.TimerHoraReal = New System.Windows.Forms.Timer(Me.components)
        Me.label_venta = New System.Windows.Forms.Label()
        Me.panel_acticulos = New System.Windows.Forms.Panel()
        Me.panel_otros = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.button_informacion_otros = New System.Windows.Forms.Button()
        Me.button_aniadir_otros = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_otros = New System.Windows.Forms.ComboBox()
        Me.label_precio_otro = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_otros = New System.Windows.Forms.ComboBox()
        Me.panel_ofertas = New System.Windows.Forms.Panel()
        Me.label_euro3 = New System.Windows.Forms.Label()
        Me.button_informacion_ofertas = New System.Windows.Forms.Button()
        Me.button_aniadir_ofertas = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_ofertas = New System.Windows.Forms.ComboBox()
        Me.label_precio_oferta = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.panel_canape = New System.Windows.Forms.Panel()
        Me.label_euro6 = New System.Windows.Forms.Label()
        Me.button_informacion_canape = New System.Windows.Forms.Button()
        Me.button_aniadir_canape = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_canape = New System.Windows.Forms.ComboBox()
        Me.label_precio_canape = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_canape = New System.Windows.Forms.ComboBox()
        Me.panel_colchon = New System.Windows.Forms.Panel()
        Me.label_euro1 = New System.Windows.Forms.Label()
        Me.button_informacion_colchon = New System.Windows.Forms.Button()
        Me.button_aniadir_colchon = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_colchon = New System.Windows.Forms.ComboBox()
        Me.label_precio_colchon = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_colchon = New System.Windows.Forms.ComboBox()
        Me.panel_somier = New System.Windows.Forms.Panel()
        Me.label_euro4 = New System.Windows.Forms.Label()
        Me.button_informacion_somier = New System.Windows.Forms.Button()
        Me.button_aniadir_somier = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_somier = New System.Windows.Forms.ComboBox()
        Me.comboBox_tamanio_somier = New System.Windows.Forms.ComboBox()
        Me.label_precio_somier = New System.Windows.Forms.Label()
        Me.panel_base = New System.Windows.Forms.Panel()
        Me.label_euro5 = New System.Windows.Forms.Label()
        Me.button_informacion_base = New System.Windows.Forms.Button()
        Me.button_aniadir_base = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_base = New System.Windows.Forms.ComboBox()
        Me.label_precio_base = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_base = New System.Windows.Forms.ComboBox()
        Me.label_ofertas = New System.Windows.Forms.Label()
        Me.comboBox_ofertas = New System.Windows.Forms.ComboBox()
        Me.pictureBox_ofertas = New System.Windows.Forms.PictureBox()
        Me.label_somier = New System.Windows.Forms.Label()
        Me.label_colchon = New System.Windows.Forms.Label()
        Me.label_canape = New System.Windows.Forms.Label()
        Me.label_otros = New System.Windows.Forms.Label()
        Me.label_base = New System.Windows.Forms.Label()
        Me.comboBox_canape = New System.Windows.Forms.ComboBox()
        Me.comboBox_otros = New System.Windows.Forms.ComboBox()
        Me.comboBox_colchon = New System.Windows.Forms.ComboBox()
        Me.comboBox_somier = New System.Windows.Forms.ComboBox()
        Me.comboBox_base = New System.Windows.Forms.ComboBox()
        Me.pictureBox_otros = New System.Windows.Forms.PictureBox()
        Me.pictureBox_canape = New System.Windows.Forms.PictureBox()
        Me.pictureBox_colchon = New System.Windows.Forms.PictureBox()
        Me.pictureBox_somier = New System.Windows.Forms.PictureBox()
        Me.pictureBox_base = New System.Windows.Forms.PictureBox()
        Me.listBox_articulosElegidos = New System.Windows.Forms.ListBox()
        Me.button_eliminar_1 = New System.Windows.Forms.Button()
        Me.button_aniadir_1 = New System.Windows.Forms.Button()
        Me.button_eliminar_articulo = New System.Windows.Forms.Button()
        Me.label_total = New System.Windows.Forms.Label()
        Me.label_totalPrecio = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label_importe = New System.Windows.Forms.Label()
        Me.button_cobrar = New System.Windows.Forms.Button()
        Me.button_anular = New System.Windows.Forms.Button()
        Me.label_resto = New System.Windows.Forms.Label()
        Me.label_totalDevolver = New System.Windows.Forms.Label()
        Me.label_euro = New System.Windows.Forms.Label()
        Me.label_euro8 = New System.Windows.Forms.Label()
        Me.label_euro7 = New System.Windows.Forms.Label()
        Me.button_desconectar = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel_acticulos.SuspendLayout()
        Me.panel_otros.SuspendLayout()
        Me.panel_ofertas.SuspendLayout()
        Me.panel_canape.SuspendLayout()
        Me.panel_colchon.SuspendLayout()
        Me.panel_somier.SuspendLayout()
        Me.panel_base.SuspendLayout()
        CType(Me.pictureBox_ofertas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_otros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_canape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_colchon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_somier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_base, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1042, 24)
        Me.MenuStrip.TabIndex = 27
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarCajaToolStripMenuItem, Me.ToolStripSeparator2, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarCajaToolStripMenuItem
        '
        Me.CerrarCajaToolStripMenuItem.Name = "CerrarCajaToolStripMenuItem"
        Me.CerrarCajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CerrarCajaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CerrarCajaToolStripMenuItem.Text = "Cerrar caja"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarVentaToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
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
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeArticulosToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
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
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColchoneriaCUESTAToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
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
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.label_ayuda)
        Me.Panel1.Controls.Add(Me.label_fecha)
        Me.Panel1.Controls.Add(Me.label_hora)
        Me.Panel1.Location = New System.Drawing.Point(0, 663)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1042, 42)
        Me.Panel1.TabIndex = 28
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
        Me.label_fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_fecha.Location = New System.Drawing.Point(697, 9)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(64, 22)
        Me.label_fecha.TabIndex = 2
        Me.label_fecha.Text = "Fecha: "
        '
        'label_hora
        '
        Me.label_hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_hora.AutoSize = True
        Me.label_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_hora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_hora.Location = New System.Drawing.Point(888, 9)
        Me.label_hora.Name = "label_hora"
        Me.label_hora.Size = New System.Drawing.Size(54, 22)
        Me.label_hora.TabIndex = 3
        Me.label_hora.Text = "Hora: "
        '
        'TimerHoraReal
        '
        Me.TimerHoraReal.Enabled = True
        Me.TimerHoraReal.Interval = 1000
        '
        'label_venta
        '
        Me.label_venta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_venta.AutoSize = True
        Me.label_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_venta.Location = New System.Drawing.Point(374, 82)
        Me.label_venta.Name = "label_venta"
        Me.label_venta.Size = New System.Drawing.Size(185, 25)
        Me.label_venta.TabIndex = 29
        Me.label_venta.Text = "Venta de articulos"
        '
        'panel_acticulos
        '
        Me.panel_acticulos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel_acticulos.Controls.Add(Me.panel_otros)
        Me.panel_acticulos.Controls.Add(Me.panel_ofertas)
        Me.panel_acticulos.Controls.Add(Me.panel_canape)
        Me.panel_acticulos.Controls.Add(Me.panel_colchon)
        Me.panel_acticulos.Controls.Add(Me.panel_somier)
        Me.panel_acticulos.Controls.Add(Me.panel_base)
        Me.panel_acticulos.Controls.Add(Me.label_ofertas)
        Me.panel_acticulos.Controls.Add(Me.comboBox_ofertas)
        Me.panel_acticulos.Controls.Add(Me.pictureBox_ofertas)
        Me.panel_acticulos.Controls.Add(Me.label_somier)
        Me.panel_acticulos.Controls.Add(Me.label_colchon)
        Me.panel_acticulos.Controls.Add(Me.label_canape)
        Me.panel_acticulos.Controls.Add(Me.label_otros)
        Me.panel_acticulos.Controls.Add(Me.label_base)
        Me.panel_acticulos.Controls.Add(Me.comboBox_canape)
        Me.panel_acticulos.Controls.Add(Me.comboBox_otros)
        Me.panel_acticulos.Controls.Add(Me.comboBox_colchon)
        Me.panel_acticulos.Controls.Add(Me.comboBox_somier)
        Me.panel_acticulos.Controls.Add(Me.comboBox_base)
        Me.panel_acticulos.Controls.Add(Me.pictureBox_otros)
        Me.panel_acticulos.Controls.Add(Me.pictureBox_canape)
        Me.panel_acticulos.Controls.Add(Me.pictureBox_colchon)
        Me.panel_acticulos.Controls.Add(Me.pictureBox_somier)
        Me.panel_acticulos.Controls.Add(Me.pictureBox_base)
        Me.panel_acticulos.Location = New System.Drawing.Point(13, 125)
        Me.panel_acticulos.Name = "panel_acticulos"
        Me.panel_acticulos.Size = New System.Drawing.Size(754, 472)
        Me.panel_acticulos.TabIndex = 30
        '
        'panel_otros
        '
        Me.panel_otros.Controls.Add(Me.Label3)
        Me.panel_otros.Controls.Add(Me.button_informacion_otros)
        Me.panel_otros.Controls.Add(Me.button_aniadir_otros)
        Me.panel_otros.Controls.Add(Me.comboBox_cantidad_otros)
        Me.panel_otros.Controls.Add(Me.label_precio_otro)
        Me.panel_otros.Controls.Add(Me.comboBox_tamanio_otros)
        Me.panel_otros.Location = New System.Drawing.Point(518, 348)
        Me.panel_otros.Name = "panel_otros"
        Me.panel_otros.Size = New System.Drawing.Size(211, 94)
        Me.panel_otros.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "€"
        '
        'button_informacion_otros
        '
        Me.button_informacion_otros.Location = New System.Drawing.Point(125, 56)
        Me.button_informacion_otros.Name = "button_informacion_otros"
        Me.button_informacion_otros.Size = New System.Drawing.Size(75, 23)
        Me.button_informacion_otros.TabIndex = 23
        Me.button_informacion_otros.Text = "Informacion"
        Me.button_informacion_otros.UseVisualStyleBackColor = True
        '
        'button_aniadir_otros
        '
        Me.button_aniadir_otros.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_otros.Name = "button_aniadir_otros"
        Me.button_aniadir_otros.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_otros.TabIndex = 22
        Me.button_aniadir_otros.Text = "Añadir"
        Me.button_aniadir_otros.UseVisualStyleBackColor = True
        '
        'comboBox_cantidad_otros
        '
        Me.comboBox_cantidad_otros.FormattingEnabled = True
        Me.comboBox_cantidad_otros.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboBox_cantidad_otros.Location = New System.Drawing.Point(136, 19)
        Me.comboBox_cantidad_otros.Name = "comboBox_cantidad_otros"
        Me.comboBox_cantidad_otros.Size = New System.Drawing.Size(58, 21)
        Me.comboBox_cantidad_otros.TabIndex = 21
        '
        'label_precio_otro
        '
        Me.label_precio_otro.AutoSize = True
        Me.label_precio_otro.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_otro.Name = "label_precio_otro"
        Me.label_precio_otro.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_otro.TabIndex = 20
        Me.label_precio_otro.Text = ": "
        '
        'comboBox_tamanio_otros
        '
        Me.comboBox_tamanio_otros.FormattingEnabled = True
        Me.comboBox_tamanio_otros.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_otros.Name = "comboBox_tamanio_otros"
        Me.comboBox_tamanio_otros.Size = New System.Drawing.Size(55, 21)
        Me.comboBox_tamanio_otros.TabIndex = 24
        '
        'panel_ofertas
        '
        Me.panel_ofertas.Controls.Add(Me.label_euro3)
        Me.panel_ofertas.Controls.Add(Me.button_informacion_ofertas)
        Me.panel_ofertas.Controls.Add(Me.button_aniadir_ofertas)
        Me.panel_ofertas.Controls.Add(Me.comboBox_cantidad_ofertas)
        Me.panel_ofertas.Controls.Add(Me.label_precio_oferta)
        Me.panel_ofertas.Controls.Add(Me.ComboBox1)
        Me.panel_ofertas.Location = New System.Drawing.Point(268, 348)
        Me.panel_ofertas.Name = "panel_ofertas"
        Me.panel_ofertas.Size = New System.Drawing.Size(211, 94)
        Me.panel_ofertas.TabIndex = 29
        '
        'label_euro3
        '
        Me.label_euro3.AutoSize = True
        Me.label_euro3.Location = New System.Drawing.Point(104, 22)
        Me.label_euro3.Name = "label_euro3"
        Me.label_euro3.Size = New System.Drawing.Size(13, 13)
        Me.label_euro3.TabIndex = 29
        Me.label_euro3.Text = "€"
        '
        'button_informacion_ofertas
        '
        Me.button_informacion_ofertas.Location = New System.Drawing.Point(125, 56)
        Me.button_informacion_ofertas.Name = "button_informacion_ofertas"
        Me.button_informacion_ofertas.Size = New System.Drawing.Size(75, 23)
        Me.button_informacion_ofertas.TabIndex = 23
        Me.button_informacion_ofertas.Text = "Informacion"
        Me.button_informacion_ofertas.UseVisualStyleBackColor = True
        '
        'button_aniadir_ofertas
        '
        Me.button_aniadir_ofertas.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_ofertas.Name = "button_aniadir_ofertas"
        Me.button_aniadir_ofertas.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_ofertas.TabIndex = 22
        Me.button_aniadir_ofertas.Text = "Añadir"
        Me.button_aniadir_ofertas.UseVisualStyleBackColor = True
        '
        'comboBox_cantidad_ofertas
        '
        Me.comboBox_cantidad_ofertas.FormattingEnabled = True
        Me.comboBox_cantidad_ofertas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboBox_cantidad_ofertas.Location = New System.Drawing.Point(136, 19)
        Me.comboBox_cantidad_ofertas.Name = "comboBox_cantidad_ofertas"
        Me.comboBox_cantidad_ofertas.Size = New System.Drawing.Size(58, 21)
        Me.comboBox_cantidad_ofertas.TabIndex = 21
        '
        'label_precio_oferta
        '
        Me.label_precio_oferta.AutoSize = True
        Me.label_precio_oferta.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_oferta.Name = "label_precio_oferta"
        Me.label_precio_oferta.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_oferta.TabIndex = 20
        Me.label_precio_oferta.Text = ": "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox1.TabIndex = 20
        '
        'panel_canape
        '
        Me.panel_canape.Controls.Add(Me.label_euro6)
        Me.panel_canape.Controls.Add(Me.button_informacion_canape)
        Me.panel_canape.Controls.Add(Me.button_aniadir_canape)
        Me.panel_canape.Controls.Add(Me.comboBox_cantidad_canape)
        Me.panel_canape.Controls.Add(Me.label_precio_canape)
        Me.panel_canape.Controls.Add(Me.comboBox_tamanio_canape)
        Me.panel_canape.Location = New System.Drawing.Point(19, 348)
        Me.panel_canape.Name = "panel_canape"
        Me.panel_canape.Size = New System.Drawing.Size(211, 94)
        Me.panel_canape.TabIndex = 28
        '
        'label_euro6
        '
        Me.label_euro6.AutoSize = True
        Me.label_euro6.Location = New System.Drawing.Point(104, 22)
        Me.label_euro6.Name = "label_euro6"
        Me.label_euro6.Size = New System.Drawing.Size(13, 13)
        Me.label_euro6.TabIndex = 26
        Me.label_euro6.Text = "€"
        '
        'button_informacion_canape
        '
        Me.button_informacion_canape.Location = New System.Drawing.Point(125, 56)
        Me.button_informacion_canape.Name = "button_informacion_canape"
        Me.button_informacion_canape.Size = New System.Drawing.Size(75, 23)
        Me.button_informacion_canape.TabIndex = 23
        Me.button_informacion_canape.Text = "Informacion"
        Me.button_informacion_canape.UseVisualStyleBackColor = True
        '
        'button_aniadir_canape
        '
        Me.button_aniadir_canape.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_canape.Name = "button_aniadir_canape"
        Me.button_aniadir_canape.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_canape.TabIndex = 22
        Me.button_aniadir_canape.Text = "Añadir"
        Me.button_aniadir_canape.UseVisualStyleBackColor = True
        '
        'comboBox_cantidad_canape
        '
        Me.comboBox_cantidad_canape.FormattingEnabled = True
        Me.comboBox_cantidad_canape.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboBox_cantidad_canape.Location = New System.Drawing.Point(136, 19)
        Me.comboBox_cantidad_canape.Name = "comboBox_cantidad_canape"
        Me.comboBox_cantidad_canape.Size = New System.Drawing.Size(58, 21)
        Me.comboBox_cantidad_canape.TabIndex = 21
        '
        'label_precio_canape
        '
        Me.label_precio_canape.AutoSize = True
        Me.label_precio_canape.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_canape.Name = "label_precio_canape"
        Me.label_precio_canape.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_canape.TabIndex = 20
        Me.label_precio_canape.Text = ": "
        '
        'comboBox_tamanio_canape
        '
        Me.comboBox_tamanio_canape.FormattingEnabled = True
        Me.comboBox_tamanio_canape.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_canape.Name = "comboBox_tamanio_canape"
        Me.comboBox_tamanio_canape.Size = New System.Drawing.Size(57, 21)
        Me.comboBox_tamanio_canape.TabIndex = 21
        '
        'panel_colchon
        '
        Me.panel_colchon.Controls.Add(Me.label_euro1)
        Me.panel_colchon.Controls.Add(Me.button_informacion_colchon)
        Me.panel_colchon.Controls.Add(Me.button_aniadir_colchon)
        Me.panel_colchon.Controls.Add(Me.comboBox_cantidad_colchon)
        Me.panel_colchon.Controls.Add(Me.label_precio_colchon)
        Me.panel_colchon.Controls.Add(Me.comboBox_tamanio_colchon)
        Me.panel_colchon.Location = New System.Drawing.Point(518, 125)
        Me.panel_colchon.Name = "panel_colchon"
        Me.panel_colchon.Size = New System.Drawing.Size(211, 94)
        Me.panel_colchon.TabIndex = 27
        '
        'label_euro1
        '
        Me.label_euro1.AutoSize = True
        Me.label_euro1.Location = New System.Drawing.Point(104, 22)
        Me.label_euro1.Name = "label_euro1"
        Me.label_euro1.Size = New System.Drawing.Size(13, 13)
        Me.label_euro1.TabIndex = 24
        Me.label_euro1.Text = "€"
        '
        'button_informacion_colchon
        '
        Me.button_informacion_colchon.Location = New System.Drawing.Point(125, 56)
        Me.button_informacion_colchon.Name = "button_informacion_colchon"
        Me.button_informacion_colchon.Size = New System.Drawing.Size(75, 23)
        Me.button_informacion_colchon.TabIndex = 23
        Me.button_informacion_colchon.Text = "Informacion"
        Me.button_informacion_colchon.UseVisualStyleBackColor = True
        '
        'button_aniadir_colchon
        '
        Me.button_aniadir_colchon.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_colchon.Name = "button_aniadir_colchon"
        Me.button_aniadir_colchon.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_colchon.TabIndex = 22
        Me.button_aniadir_colchon.Text = "Añadir"
        Me.button_aniadir_colchon.UseVisualStyleBackColor = True
        '
        'comboBox_cantidad_colchon
        '
        Me.comboBox_cantidad_colchon.FormattingEnabled = True
        Me.comboBox_cantidad_colchon.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboBox_cantidad_colchon.Location = New System.Drawing.Point(136, 19)
        Me.comboBox_cantidad_colchon.Name = "comboBox_cantidad_colchon"
        Me.comboBox_cantidad_colchon.Size = New System.Drawing.Size(58, 21)
        Me.comboBox_cantidad_colchon.TabIndex = 21
        '
        'label_precio_colchon
        '
        Me.label_precio_colchon.AutoSize = True
        Me.label_precio_colchon.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_colchon.Name = "label_precio_colchon"
        Me.label_precio_colchon.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_colchon.TabIndex = 20
        Me.label_precio_colchon.Text = ": "
        '
        'comboBox_tamanio_colchon
        '
        Me.comboBox_tamanio_colchon.FormattingEnabled = True
        Me.comboBox_tamanio_colchon.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_colchon.Name = "comboBox_tamanio_colchon"
        Me.comboBox_tamanio_colchon.Size = New System.Drawing.Size(55, 21)
        Me.comboBox_tamanio_colchon.TabIndex = 22
        '
        'panel_somier
        '
        Me.panel_somier.Controls.Add(Me.label_euro4)
        Me.panel_somier.Controls.Add(Me.button_informacion_somier)
        Me.panel_somier.Controls.Add(Me.button_aniadir_somier)
        Me.panel_somier.Controls.Add(Me.comboBox_cantidad_somier)
        Me.panel_somier.Controls.Add(Me.comboBox_tamanio_somier)
        Me.panel_somier.Controls.Add(Me.label_precio_somier)
        Me.panel_somier.Location = New System.Drawing.Point(268, 125)
        Me.panel_somier.Name = "panel_somier"
        Me.panel_somier.Size = New System.Drawing.Size(211, 94)
        Me.panel_somier.TabIndex = 26
        '
        'label_euro4
        '
        Me.label_euro4.AutoSize = True
        Me.label_euro4.Location = New System.Drawing.Point(104, 22)
        Me.label_euro4.Name = "label_euro4"
        Me.label_euro4.Size = New System.Drawing.Size(13, 13)
        Me.label_euro4.TabIndex = 28
        Me.label_euro4.Text = "€"
        '
        'button_informacion_somier
        '
        Me.button_informacion_somier.Location = New System.Drawing.Point(125, 56)
        Me.button_informacion_somier.Name = "button_informacion_somier"
        Me.button_informacion_somier.Size = New System.Drawing.Size(75, 23)
        Me.button_informacion_somier.TabIndex = 23
        Me.button_informacion_somier.Text = "Informacion"
        Me.button_informacion_somier.UseVisualStyleBackColor = True
        '
        'button_aniadir_somier
        '
        Me.button_aniadir_somier.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_somier.Name = "button_aniadir_somier"
        Me.button_aniadir_somier.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_somier.TabIndex = 22
        Me.button_aniadir_somier.Text = "Añadir"
        Me.button_aniadir_somier.UseVisualStyleBackColor = True
        '
        'comboBox_cantidad_somier
        '
        Me.comboBox_cantidad_somier.FormattingEnabled = True
        Me.comboBox_cantidad_somier.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboBox_cantidad_somier.Location = New System.Drawing.Point(136, 19)
        Me.comboBox_cantidad_somier.Name = "comboBox_cantidad_somier"
        Me.comboBox_cantidad_somier.Size = New System.Drawing.Size(58, 21)
        Me.comboBox_cantidad_somier.TabIndex = 21
        '
        'comboBox_tamanio_somier
        '
        Me.comboBox_tamanio_somier.FormattingEnabled = True
        Me.comboBox_tamanio_somier.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_somier.Name = "comboBox_tamanio_somier"
        Me.comboBox_tamanio_somier.Size = New System.Drawing.Size(57, 21)
        Me.comboBox_tamanio_somier.TabIndex = 23
        '
        'label_precio_somier
        '
        Me.label_precio_somier.AutoSize = True
        Me.label_precio_somier.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_somier.Name = "label_precio_somier"
        Me.label_precio_somier.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_somier.TabIndex = 20
        Me.label_precio_somier.Text = ": "
        '
        'panel_base
        '
        Me.panel_base.Controls.Add(Me.label_euro5)
        Me.panel_base.Controls.Add(Me.button_informacion_base)
        Me.panel_base.Controls.Add(Me.button_aniadir_base)
        Me.panel_base.Controls.Add(Me.comboBox_cantidad_base)
        Me.panel_base.Controls.Add(Me.label_precio_base)
        Me.panel_base.Controls.Add(Me.comboBox_tamanio_base)
        Me.panel_base.Location = New System.Drawing.Point(19, 125)
        Me.panel_base.Name = "panel_base"
        Me.panel_base.Size = New System.Drawing.Size(211, 94)
        Me.panel_base.TabIndex = 25
        '
        'label_euro5
        '
        Me.label_euro5.AutoSize = True
        Me.label_euro5.Location = New System.Drawing.Point(104, 22)
        Me.label_euro5.Name = "label_euro5"
        Me.label_euro5.Size = New System.Drawing.Size(13, 13)
        Me.label_euro5.TabIndex = 27
        Me.label_euro5.Text = "€"
        '
        'button_informacion_base
        '
        Me.button_informacion_base.Location = New System.Drawing.Point(125, 56)
        Me.button_informacion_base.Name = "button_informacion_base"
        Me.button_informacion_base.Size = New System.Drawing.Size(75, 23)
        Me.button_informacion_base.TabIndex = 23
        Me.button_informacion_base.Text = "Informacion"
        Me.button_informacion_base.UseVisualStyleBackColor = True
        '
        'button_aniadir_base
        '
        Me.button_aniadir_base.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_base.Name = "button_aniadir_base"
        Me.button_aniadir_base.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_base.TabIndex = 22
        Me.button_aniadir_base.Text = "Añadir"
        Me.button_aniadir_base.UseVisualStyleBackColor = True
        '
        'comboBox_cantidad_base
        '
        Me.comboBox_cantidad_base.FormattingEnabled = True
        Me.comboBox_cantidad_base.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboBox_cantidad_base.Location = New System.Drawing.Point(136, 19)
        Me.comboBox_cantidad_base.Name = "comboBox_cantidad_base"
        Me.comboBox_cantidad_base.Size = New System.Drawing.Size(58, 21)
        Me.comboBox_cantidad_base.TabIndex = 21
        '
        'label_precio_base
        '
        Me.label_precio_base.AutoSize = True
        Me.label_precio_base.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_base.Name = "label_precio_base"
        Me.label_precio_base.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_base.TabIndex = 20
        Me.label_precio_base.Text = ": "
        '
        'comboBox_tamanio_base
        '
        Me.comboBox_tamanio_base.FormattingEnabled = True
        Me.comboBox_tamanio_base.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_base.Name = "comboBox_tamanio_base"
        Me.comboBox_tamanio_base.Size = New System.Drawing.Size(57, 21)
        Me.comboBox_tamanio_base.TabIndex = 19
        '
        'label_ofertas
        '
        Me.label_ofertas.AutoSize = True
        Me.label_ofertas.Location = New System.Drawing.Point(352, 235)
        Me.label_ofertas.Name = "label_ofertas"
        Me.label_ofertas.Size = New System.Drawing.Size(41, 13)
        Me.label_ofertas.TabIndex = 18
        Me.label_ofertas.Text = "Ofertas"
        '
        'comboBox_ofertas
        '
        Me.comboBox_ofertas.FormattingEnabled = True
        Me.comboBox_ofertas.Location = New System.Drawing.Point(282, 321)
        Me.comboBox_ofertas.Name = "comboBox_ofertas"
        Me.comboBox_ofertas.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_ofertas.TabIndex = 16
        '
        'pictureBox_ofertas
        '
        Me.pictureBox_ofertas.Location = New System.Drawing.Point(327, 265)
        Me.pictureBox_ofertas.Name = "pictureBox_ofertas"
        Me.pictureBox_ofertas.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox_ofertas.TabIndex = 15
        Me.pictureBox_ofertas.TabStop = False
        '
        'label_somier
        '
        Me.label_somier.AutoSize = True
        Me.label_somier.Location = New System.Drawing.Point(352, 15)
        Me.label_somier.Name = "label_somier"
        Me.label_somier.Size = New System.Drawing.Size(44, 13)
        Me.label_somier.TabIndex = 14
        Me.label_somier.Text = "Somiers"
        '
        'label_colchon
        '
        Me.label_colchon.AutoSize = True
        Me.label_colchon.Location = New System.Drawing.Point(589, 15)
        Me.label_colchon.Name = "label_colchon"
        Me.label_colchon.Size = New System.Drawing.Size(57, 13)
        Me.label_colchon.TabIndex = 13
        Me.label_colchon.Text = "Colchones"
        '
        'label_canape
        '
        Me.label_canape.AutoSize = True
        Me.label_canape.Location = New System.Drawing.Point(94, 235)
        Me.label_canape.Name = "label_canape"
        Me.label_canape.Size = New System.Drawing.Size(49, 13)
        Me.label_canape.TabIndex = 12
        Me.label_canape.Text = "Canapes"
        '
        'label_otros
        '
        Me.label_otros.AutoSize = True
        Me.label_otros.Location = New System.Drawing.Point(600, 235)
        Me.label_otros.Name = "label_otros"
        Me.label_otros.Size = New System.Drawing.Size(32, 13)
        Me.label_otros.TabIndex = 11
        Me.label_otros.Text = "Otros"
        '
        'label_base
        '
        Me.label_base.AutoSize = True
        Me.label_base.Location = New System.Drawing.Point(94, 15)
        Me.label_base.Name = "label_base"
        Me.label_base.Size = New System.Drawing.Size(36, 13)
        Me.label_base.TabIndex = 10
        Me.label_base.Text = "Bases"
        '
        'comboBox_canape
        '
        Me.comboBox_canape.FormattingEnabled = True
        Me.comboBox_canape.Location = New System.Drawing.Point(33, 321)
        Me.comboBox_canape.Name = "comboBox_canape"
        Me.comboBox_canape.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_canape.TabIndex = 9
        '
        'comboBox_otros
        '
        Me.comboBox_otros.FormattingEnabled = True
        Me.comboBox_otros.Location = New System.Drawing.Point(532, 321)
        Me.comboBox_otros.Name = "comboBox_otros"
        Me.comboBox_otros.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_otros.TabIndex = 8
        '
        'comboBox_colchon
        '
        Me.comboBox_colchon.FormattingEnabled = True
        Me.comboBox_colchon.Location = New System.Drawing.Point(532, 98)
        Me.comboBox_colchon.Name = "comboBox_colchon"
        Me.comboBox_colchon.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_colchon.TabIndex = 7
        '
        'comboBox_somier
        '
        Me.comboBox_somier.FormattingEnabled = True
        Me.comboBox_somier.Location = New System.Drawing.Point(282, 98)
        Me.comboBox_somier.Name = "comboBox_somier"
        Me.comboBox_somier.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_somier.TabIndex = 6
        '
        'comboBox_base
        '
        Me.comboBox_base.FormattingEnabled = True
        Me.comboBox_base.Items.AddRange(New Object() {"1", "2"})
        Me.comboBox_base.Location = New System.Drawing.Point(33, 98)
        Me.comboBox_base.Name = "comboBox_base"
        Me.comboBox_base.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_base.TabIndex = 5
        '
        'pictureBox_otros
        '
        Me.pictureBox_otros.Location = New System.Drawing.Point(572, 265)
        Me.pictureBox_otros.Name = "pictureBox_otros"
        Me.pictureBox_otros.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox_otros.TabIndex = 4
        Me.pictureBox_otros.TabStop = False
        '
        'pictureBox_canape
        '
        Me.pictureBox_canape.Location = New System.Drawing.Point(70, 265)
        Me.pictureBox_canape.Name = "pictureBox_canape"
        Me.pictureBox_canape.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox_canape.TabIndex = 3
        Me.pictureBox_canape.TabStop = False
        '
        'pictureBox_colchon
        '
        Me.pictureBox_colchon.Location = New System.Drawing.Point(573, 42)
        Me.pictureBox_colchon.Name = "pictureBox_colchon"
        Me.pictureBox_colchon.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox_colchon.TabIndex = 2
        Me.pictureBox_colchon.TabStop = False
        '
        'pictureBox_somier
        '
        Me.pictureBox_somier.Location = New System.Drawing.Point(327, 42)
        Me.pictureBox_somier.Name = "pictureBox_somier"
        Me.pictureBox_somier.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox_somier.TabIndex = 1
        Me.pictureBox_somier.TabStop = False
        '
        'pictureBox_base
        '
        Me.pictureBox_base.Location = New System.Drawing.Point(70, 42)
        Me.pictureBox_base.Name = "pictureBox_base"
        Me.pictureBox_base.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox_base.TabIndex = 0
        Me.pictureBox_base.TabStop = False
        '
        'listBox_articulosElegidos
        '
        Me.listBox_articulosElegidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listBox_articulosElegidos.FormattingEnabled = True
        Me.listBox_articulosElegidos.Location = New System.Drawing.Point(787, 167)
        Me.listBox_articulosElegidos.Name = "listBox_articulosElegidos"
        Me.listBox_articulosElegidos.Size = New System.Drawing.Size(232, 212)
        Me.listBox_articulosElegidos.TabIndex = 31
        '
        'button_eliminar_1
        '
        Me.button_eliminar_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_eliminar_1.Location = New System.Drawing.Point(869, 127)
        Me.button_eliminar_1.Name = "button_eliminar_1"
        Me.button_eliminar_1.Size = New System.Drawing.Size(28, 27)
        Me.button_eliminar_1.TabIndex = 24
        Me.button_eliminar_1.Text = "-"
        Me.button_eliminar_1.UseVisualStyleBackColor = True
        '
        'button_aniadir_1
        '
        Me.button_aniadir_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_aniadir_1.Location = New System.Drawing.Point(806, 127)
        Me.button_aniadir_1.Name = "button_aniadir_1"
        Me.button_aniadir_1.Size = New System.Drawing.Size(28, 26)
        Me.button_aniadir_1.TabIndex = 32
        Me.button_aniadir_1.Text = "+"
        Me.button_aniadir_1.UseVisualStyleBackColor = True
        '
        'button_eliminar_articulo
        '
        Me.button_eliminar_articulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_eliminar_articulo.Location = New System.Drawing.Point(931, 127)
        Me.button_eliminar_articulo.Name = "button_eliminar_articulo"
        Me.button_eliminar_articulo.Size = New System.Drawing.Size(28, 27)
        Me.button_eliminar_articulo.TabIndex = 33
        Me.button_eliminar_articulo.Text = "x"
        Me.button_eliminar_articulo.UseVisualStyleBackColor = True
        '
        'label_total
        '
        Me.label_total.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_total.AutoSize = True
        Me.label_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total.Location = New System.Drawing.Point(802, 441)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(52, 20)
        Me.label_total.TabIndex = 34
        Me.label_total.Text = "Total: "
        '
        'label_totalPrecio
        '
        Me.label_totalPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_totalPrecio.AutoSize = True
        Me.label_totalPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_totalPrecio.Location = New System.Drawing.Point(882, 441)
        Me.label_totalPrecio.Name = "label_totalPrecio"
        Me.label_totalPrecio.Size = New System.Drawing.Size(0, 20)
        Me.label_totalPrecio.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(886, 481)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 36
        '
        'label_importe
        '
        Me.label_importe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_importe.AutoSize = True
        Me.label_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_importe.Location = New System.Drawing.Point(802, 481)
        Me.label_importe.Name = "label_importe"
        Me.label_importe.Size = New System.Drawing.Size(72, 20)
        Me.label_importe.TabIndex = 37
        Me.label_importe.Text = "Importe: "
        '
        'button_cobrar
        '
        Me.button_cobrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_cobrar.Location = New System.Drawing.Point(787, 554)
        Me.button_cobrar.Name = "button_cobrar"
        Me.button_cobrar.Size = New System.Drawing.Size(127, 23)
        Me.button_cobrar.TabIndex = 38
        Me.button_cobrar.Text = "Cobrar"
        Me.button_cobrar.UseVisualStyleBackColor = True
        '
        'button_anular
        '
        Me.button_anular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_anular.Location = New System.Drawing.Point(770, 603)
        Me.button_anular.Name = "button_anular"
        Me.button_anular.Size = New System.Drawing.Size(127, 23)
        Me.button_anular.TabIndex = 39
        Me.button_anular.Text = "Anular compra"
        Me.button_anular.UseVisualStyleBackColor = True
        '
        'label_resto
        '
        Me.label_resto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_resto.AutoSize = True
        Me.label_resto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_resto.Location = New System.Drawing.Point(802, 517)
        Me.label_resto.Name = "label_resto"
        Me.label_resto.Size = New System.Drawing.Size(60, 20)
        Me.label_resto.TabIndex = 42
        Me.label_resto.Text = "Resto: "
        '
        'label_totalDevolver
        '
        Me.label_totalDevolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_totalDevolver.AutoSize = True
        Me.label_totalDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_totalDevolver.Location = New System.Drawing.Point(887, 517)
        Me.label_totalDevolver.Name = "label_totalDevolver"
        Me.label_totalDevolver.Size = New System.Drawing.Size(0, 20)
        Me.label_totalDevolver.TabIndex = 43
        '
        'label_euro
        '
        Me.label_euro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_euro.AutoSize = True
        Me.label_euro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_euro.Location = New System.Drawing.Point(888, 441)
        Me.label_euro.Name = "label_euro"
        Me.label_euro.Size = New System.Drawing.Size(18, 20)
        Me.label_euro.TabIndex = 44
        Me.label_euro.Text = "€"
        '
        'label_euro8
        '
        Me.label_euro8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_euro8.AutoSize = True
        Me.label_euro8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_euro8.Location = New System.Drawing.Point(893, 517)
        Me.label_euro8.Name = "label_euro8"
        Me.label_euro8.Size = New System.Drawing.Size(18, 20)
        Me.label_euro8.TabIndex = 45
        Me.label_euro8.Text = "€"
        '
        'label_euro7
        '
        Me.label_euro7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_euro7.AutoSize = True
        Me.label_euro7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_euro7.Location = New System.Drawing.Point(992, 481)
        Me.label_euro7.Name = "label_euro7"
        Me.label_euro7.Size = New System.Drawing.Size(18, 20)
        Me.label_euro7.TabIndex = 46
        Me.label_euro7.Text = "€"
        '
        'button_desconectar
        '
        Me.button_desconectar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_desconectar.Location = New System.Drawing.Point(903, 604)
        Me.button_desconectar.Name = "button_desconectar"
        Me.button_desconectar.Size = New System.Drawing.Size(127, 23)
        Me.button_desconectar.TabIndex = 47
        Me.button_desconectar.Text = "Desconectar"
        Me.button_desconectar.UseVisualStyleBackColor = True
        '
        'Pantalla_de_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 704)
        Me.Controls.Add(Me.button_desconectar)
        Me.Controls.Add(Me.label_euro7)
        Me.Controls.Add(Me.label_euro8)
        Me.Controls.Add(Me.label_euro)
        Me.Controls.Add(Me.label_totalDevolver)
        Me.Controls.Add(Me.label_resto)
        Me.Controls.Add(Me.button_anular)
        Me.Controls.Add(Me.button_cobrar)
        Me.Controls.Add(Me.label_importe)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label_totalPrecio)
        Me.Controls.Add(Me.label_total)
        Me.Controls.Add(Me.button_eliminar_articulo)
        Me.Controls.Add(Me.button_aniadir_1)
        Me.Controls.Add(Me.button_eliminar_1)
        Me.Controls.Add(Me.listBox_articulosElegidos)
        Me.Controls.Add(Me.panel_acticulos)
        Me.Controls.Add(Me.label_venta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "Pantalla_de_venta"
        Me.Text = "Colchoneria CUESTA - Venta de articulos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_acticulos.ResumeLayout(False)
        Me.panel_acticulos.PerformLayout()
        Me.panel_otros.ResumeLayout(False)
        Me.panel_otros.PerformLayout()
        Me.panel_ofertas.ResumeLayout(False)
        Me.panel_ofertas.PerformLayout()
        Me.panel_canape.ResumeLayout(False)
        Me.panel_canape.PerformLayout()
        Me.panel_colchon.ResumeLayout(False)
        Me.panel_colchon.PerformLayout()
        Me.panel_somier.ResumeLayout(False)
        Me.panel_somier.PerformLayout()
        Me.panel_base.ResumeLayout(False)
        Me.panel_base.PerformLayout()
        CType(Me.pictureBox_ofertas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_otros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_canape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_colchon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_somier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_base, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label_ayuda As Label
    Friend WithEvents label_fecha As Label
    Friend WithEvents label_hora As Label
    Friend WithEvents TimerHoraReal As Timer
    Friend WithEvents label_venta As Label
    Friend WithEvents panel_acticulos As Panel
    Friend WithEvents comboBox_canape As ComboBox
    Friend WithEvents comboBox_otros As ComboBox
    Friend WithEvents comboBox_colchon As ComboBox
    Friend WithEvents comboBox_somier As ComboBox
    Friend WithEvents comboBox_base As ComboBox
    Friend WithEvents pictureBox_otros As PictureBox
    Friend WithEvents pictureBox_canape As PictureBox
    Friend WithEvents pictureBox_colchon As PictureBox
    Friend WithEvents pictureBox_somier As PictureBox
    Friend WithEvents pictureBox_base As PictureBox
    Friend WithEvents listBox_articulosElegidos As ListBox
    Friend WithEvents label_ofertas As Label
    Friend WithEvents comboBox_ofertas As ComboBox
    Friend WithEvents pictureBox_ofertas As PictureBox
    Friend WithEvents label_somier As Label
    Friend WithEvents label_colchon As Label
    Friend WithEvents label_canape As Label
    Friend WithEvents label_otros As Label
    Friend WithEvents label_base As Label
    Friend WithEvents comboBox_tamanio_somier As ComboBox
    Friend WithEvents comboBox_tamanio_colchon As ComboBox
    Friend WithEvents comboBox_tamanio_canape As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents comboBox_tamanio_base As ComboBox
    Friend WithEvents comboBox_tamanio_otros As ComboBox
    Friend WithEvents panel_base As Panel
    Friend WithEvents button_informacion_base As Button
    Friend WithEvents button_aniadir_base As Button
    Friend WithEvents comboBox_cantidad_base As ComboBox
    Friend WithEvents label_precio_base As Label
    Friend WithEvents button_eliminar_1 As Button
    Friend WithEvents button_aniadir_1 As Button
    Friend WithEvents panel_otros As Panel
    Friend WithEvents button_informacion_otros As Button
    Friend WithEvents button_aniadir_otros As Button
    Friend WithEvents comboBox_cantidad_otros As ComboBox
    Friend WithEvents label_precio_otro As Label
    Friend WithEvents panel_ofertas As Panel
    Friend WithEvents button_informacion_ofertas As Button
    Friend WithEvents button_aniadir_ofertas As Button
    Friend WithEvents comboBox_cantidad_ofertas As ComboBox
    Friend WithEvents label_precio_oferta As Label
    Friend WithEvents panel_canape As Panel
    Friend WithEvents button_informacion_canape As Button
    Friend WithEvents button_aniadir_canape As Button
    Friend WithEvents comboBox_cantidad_canape As ComboBox
    Friend WithEvents label_precio_canape As Label
    Friend WithEvents panel_colchon As Panel
    Friend WithEvents button_informacion_colchon As Button
    Friend WithEvents button_aniadir_colchon As Button
    Friend WithEvents comboBox_cantidad_colchon As ComboBox
    Friend WithEvents label_precio_colchon As Label
    Friend WithEvents panel_somier As Panel
    Friend WithEvents button_informacion_somier As Button
    Friend WithEvents button_aniadir_somier As Button
    Friend WithEvents comboBox_cantidad_somier As ComboBox
    Friend WithEvents label_precio_somier As Label
    Friend WithEvents button_eliminar_articulo As Button
    Friend WithEvents label_total As Label
    Friend WithEvents label_totalPrecio As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents label_importe As Label
    Friend WithEvents button_cobrar As Button
    Friend WithEvents button_tarjeta As Button
    Friend WithEvents button_anular As Button
    Friend WithEvents label_resto As Label
    Friend WithEvents label_totalDevolver As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label_euro3 As Label
    Friend WithEvents label_euro6 As Label
    Friend WithEvents label_euro1 As Label
    Friend WithEvents label_euro4 As Label
    Friend WithEvents label_euro5 As Label
    Friend WithEvents label_euro As Label
    Friend WithEvents label_euro8 As Label
    Friend WithEvents label_euro7 As Label
    Friend WithEvents button_desconectar As Button
End Class
