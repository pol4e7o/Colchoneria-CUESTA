﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_de_venta))
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
        Me.GestionDeErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.pictureBox_base = New System.Windows.Forms.PictureBox()
        Me.pictureBox_somier = New System.Windows.Forms.PictureBox()
        Me.pictureBox_colchon = New System.Windows.Forms.PictureBox()
        Me.pictureBox_canape = New System.Windows.Forms.PictureBox()
        Me.pictureBox_otros = New System.Windows.Forms.PictureBox()
        Me.comboBox_base = New System.Windows.Forms.ComboBox()
        Me.comboBox_somier = New System.Windows.Forms.ComboBox()
        Me.comboBox_colchon = New System.Windows.Forms.ComboBox()
        Me.comboBox_otros = New System.Windows.Forms.ComboBox()
        Me.comboBox_canape = New System.Windows.Forms.ComboBox()
        Me.label_base = New System.Windows.Forms.Label()
        Me.label_otros = New System.Windows.Forms.Label()
        Me.label_canape = New System.Windows.Forms.Label()
        Me.label_colchon = New System.Windows.Forms.Label()
        Me.label_somier = New System.Windows.Forms.Label()
        Me.pictureBox_ofertas = New System.Windows.Forms.PictureBox()
        Me.comboBox_ofertas = New System.Windows.Forms.ComboBox()
        Me.label_ofertas = New System.Windows.Forms.Label()
        Me.panel_base = New System.Windows.Forms.Panel()
        Me.label_euro5 = New System.Windows.Forms.Label()
        Me.button_informacion_base = New System.Windows.Forms.Button()
        Me.button_aniadir_base = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_base = New System.Windows.Forms.ComboBox()
        Me.label_precio_base = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_base = New System.Windows.Forms.ComboBox()
        Me.panel_somier = New System.Windows.Forms.Panel()
        Me.label_euro4 = New System.Windows.Forms.Label()
        Me.button_informacion_somier = New System.Windows.Forms.Button()
        Me.button_aniadir_somier = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_somier = New System.Windows.Forms.ComboBox()
        Me.comboBox_tamanio_somier = New System.Windows.Forms.ComboBox()
        Me.label_precio_somier = New System.Windows.Forms.Label()
        Me.panel_colchon = New System.Windows.Forms.Panel()
        Me.label_euro1 = New System.Windows.Forms.Label()
        Me.button_informacion_colchon = New System.Windows.Forms.Button()
        Me.button_aniadir_colchon = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_colchon = New System.Windows.Forms.ComboBox()
        Me.label_precio_colchon = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_colchon = New System.Windows.Forms.ComboBox()
        Me.panel_canape = New System.Windows.Forms.Panel()
        Me.label_euro6 = New System.Windows.Forms.Label()
        Me.button_informacion_canape = New System.Windows.Forms.Button()
        Me.button_aniadir_canape = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_canape = New System.Windows.Forms.ComboBox()
        Me.label_precio_canape = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_canape = New System.Windows.Forms.ComboBox()
        Me.panel_ofertas = New System.Windows.Forms.Panel()
        Me.label_euro3 = New System.Windows.Forms.Label()
        Me.button_informacion_ofertas = New System.Windows.Forms.Button()
        Me.button_aniadir_ofertas = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_ofertas = New System.Windows.Forms.ComboBox()
        Me.label_precio_ofertas = New System.Windows.Forms.Label()
        Me.comboBox_tamanios_ofertas = New System.Windows.Forms.ComboBox()
        Me.panel_otros = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.button_informacion_otros = New System.Windows.Forms.Button()
        Me.button_aniadir_otros = New System.Windows.Forms.Button()
        Me.comboBox_cantidad_otros = New System.Windows.Forms.ComboBox()
        Me.label_precio_otros = New System.Windows.Forms.Label()
        Me.comboBox_tamanio_otros = New System.Windows.Forms.ComboBox()
        Me.panel_acticulos = New System.Windows.Forms.Panel()
        Me.listBox_cantidad = New System.Windows.Forms.ListBox()
        Me.button_eliminar_1 = New System.Windows.Forms.Button()
        Me.button_aniadir_1 = New System.Windows.Forms.Button()
        Me.button_eliminar_articulo = New System.Windows.Forms.Button()
        Me.label_total = New System.Windows.Forms.Label()
        Me.label_totalPrecio = New System.Windows.Forms.Label()
        Me.textBox_importe = New System.Windows.Forms.TextBox()
        Me.label_importe = New System.Windows.Forms.Label()
        Me.label_resto = New System.Windows.Forms.Label()
        Me.label_totalDevolver = New System.Windows.Forms.Label()
        Me.label_euro = New System.Windows.Forms.Label()
        Me.label_euro8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_subtotal = New System.Windows.Forms.Label()
        Me.label_subtotalPrecio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label_ivaPrecio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.button_cobrar = New System.Windows.Forms.Button()
        Me.button_desconectar = New System.Windows.Forms.Button()
        Me.button_anular = New System.Windows.Forms.Button()
        Me.ListBox_nombre = New System.Windows.Forms.ListBox()
        Me.ListBox_precioUnidad = New System.Windows.Forms.ListBox()
        Me.ListBox_precioTotal = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PrintDocument_ticket = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox_ticket = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox_base, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_somier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_colchon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_canape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_otros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_ofertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_base.SuspendLayout()
        Me.panel_somier.SuspendLayout()
        Me.panel_colchon.SuspendLayout()
        Me.panel_canape.SuspendLayout()
        Me.panel_ofertas.SuspendLayout()
        Me.panel_otros.SuspendLayout()
        Me.panel_acticulos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1228, 50)
        Me.MenuStrip.TabIndex = 27
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.AutoSize = False
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarCajaToolStripMenuItem, Me.ToolStripSeparator2, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(150, 70)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarCajaToolStripMenuItem
        '
        Me.CerrarCajaToolStripMenuItem.Name = "CerrarCajaToolStripMenuItem"
        Me.CerrarCajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CerrarCajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarCajaToolStripMenuItem.Text = "Cerrar caja"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(122, 70)
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
        'GestionDeErroresToolStripMenuItem
        '
        Me.GestionDeErroresToolStripMenuItem.Name = "GestionDeErroresToolStripMenuItem"
        Me.GestionDeErroresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.GestionDeErroresToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.GestionDeErroresToolStripMenuItem.Text = "Gestion de errores"
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.label_ayuda)
        Me.Panel1.Controls.Add(Me.label_fecha)
        Me.Panel1.Controls.Add(Me.label_hora)
        Me.Panel1.Location = New System.Drawing.Point(0, 803)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1242, 42)
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
        Me.label_fecha.BackColor = System.Drawing.Color.White
        Me.label_fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label_fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_fecha.Location = New System.Drawing.Point(897, 9)
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
        Me.label_hora.Location = New System.Drawing.Point(1088, 9)
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
        Me.label_venta.Location = New System.Drawing.Point(365, 124)
        Me.label_venta.Name = "label_venta"
        Me.label_venta.Size = New System.Drawing.Size(185, 25)
        Me.label_venta.TabIndex = 29
        Me.label_venta.Text = "Venta de articulos"
        '
        'pictureBox_base
        '
        Me.pictureBox_base.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox_base.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox_base.Image = CType(resources.GetObject("pictureBox_base.Image"), System.Drawing.Image)
        Me.pictureBox_base.Location = New System.Drawing.Point(57, 35)
        Me.pictureBox_base.Name = "pictureBox_base"
        Me.pictureBox_base.Size = New System.Drawing.Size(121, 61)
        Me.pictureBox_base.TabIndex = 0
        Me.pictureBox_base.TabStop = False
        '
        'pictureBox_somier
        '
        Me.pictureBox_somier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox_somier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox_somier.Image = CType(resources.GetObject("pictureBox_somier.Image"), System.Drawing.Image)
        Me.pictureBox_somier.Location = New System.Drawing.Point(313, 35)
        Me.pictureBox_somier.Name = "pictureBox_somier"
        Me.pictureBox_somier.Size = New System.Drawing.Size(122, 61)
        Me.pictureBox_somier.TabIndex = 1
        Me.pictureBox_somier.TabStop = False
        '
        'pictureBox_colchon
        '
        Me.pictureBox_colchon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox_colchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox_colchon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox_colchon.Image = CType(resources.GetObject("pictureBox_colchon.Image"), System.Drawing.Image)
        Me.pictureBox_colchon.Location = New System.Drawing.Point(557, 35)
        Me.pictureBox_colchon.Name = "pictureBox_colchon"
        Me.pictureBox_colchon.Size = New System.Drawing.Size(121, 61)
        Me.pictureBox_colchon.TabIndex = 2
        Me.pictureBox_colchon.TabStop = False
        '
        'pictureBox_canape
        '
        Me.pictureBox_canape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox_canape.Image = CType(resources.GetObject("pictureBox_canape.Image"), System.Drawing.Image)
        Me.pictureBox_canape.Location = New System.Drawing.Point(59, 251)
        Me.pictureBox_canape.Name = "pictureBox_canape"
        Me.pictureBox_canape.Size = New System.Drawing.Size(123, 64)
        Me.pictureBox_canape.TabIndex = 3
        Me.pictureBox_canape.TabStop = False
        '
        'pictureBox_otros
        '
        Me.pictureBox_otros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox_otros.Image = CType(resources.GetObject("pictureBox_otros.Image"), System.Drawing.Image)
        Me.pictureBox_otros.Location = New System.Drawing.Point(557, 251)
        Me.pictureBox_otros.Name = "pictureBox_otros"
        Me.pictureBox_otros.Size = New System.Drawing.Size(121, 64)
        Me.pictureBox_otros.TabIndex = 4
        Me.pictureBox_otros.TabStop = False
        '
        'comboBox_base
        '
        Me.comboBox_base.FormattingEnabled = True
        Me.comboBox_base.Location = New System.Drawing.Point(33, 98)
        Me.comboBox_base.Name = "comboBox_base"
        Me.comboBox_base.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_base.TabIndex = 1
        '
        'comboBox_somier
        '
        Me.comboBox_somier.FormattingEnabled = True
        Me.comboBox_somier.Location = New System.Drawing.Point(282, 98)
        Me.comboBox_somier.Name = "comboBox_somier"
        Me.comboBox_somier.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_somier.TabIndex = 6
        '
        'comboBox_colchon
        '
        Me.comboBox_colchon.FormattingEnabled = True
        Me.comboBox_colchon.Location = New System.Drawing.Point(532, 98)
        Me.comboBox_colchon.Name = "comboBox_colchon"
        Me.comboBox_colchon.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_colchon.TabIndex = 11
        '
        'comboBox_otros
        '
        Me.comboBox_otros.FormattingEnabled = True
        Me.comboBox_otros.Location = New System.Drawing.Point(532, 321)
        Me.comboBox_otros.Name = "comboBox_otros"
        Me.comboBox_otros.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_otros.TabIndex = 26
        '
        'comboBox_canape
        '
        Me.comboBox_canape.FormattingEnabled = True
        Me.comboBox_canape.Location = New System.Drawing.Point(33, 321)
        Me.comboBox_canape.Name = "comboBox_canape"
        Me.comboBox_canape.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_canape.TabIndex = 16
        '
        'label_base
        '
        Me.label_base.AutoSize = True
        Me.label_base.Location = New System.Drawing.Point(104, 9)
        Me.label_base.Name = "label_base"
        Me.label_base.Size = New System.Drawing.Size(36, 13)
        Me.label_base.TabIndex = 10
        Me.label_base.Text = "Bases"
        '
        'label_otros
        '
        Me.label_otros.AutoSize = True
        Me.label_otros.Location = New System.Drawing.Point(603, 233)
        Me.label_otros.Name = "label_otros"
        Me.label_otros.Size = New System.Drawing.Size(32, 13)
        Me.label_otros.TabIndex = 11
        Me.label_otros.Text = "Otros"
        '
        'label_canape
        '
        Me.label_canape.AutoSize = True
        Me.label_canape.Location = New System.Drawing.Point(104, 233)
        Me.label_canape.Name = "label_canape"
        Me.label_canape.Size = New System.Drawing.Size(49, 13)
        Me.label_canape.TabIndex = 12
        Me.label_canape.Text = "Canapes"
        '
        'label_colchon
        '
        Me.label_colchon.AutoSize = True
        Me.label_colchon.Location = New System.Drawing.Point(591, 9)
        Me.label_colchon.Name = "label_colchon"
        Me.label_colchon.Size = New System.Drawing.Size(57, 13)
        Me.label_colchon.TabIndex = 13
        Me.label_colchon.Text = "Colchones"
        '
        'label_somier
        '
        Me.label_somier.AutoSize = True
        Me.label_somier.Location = New System.Drawing.Point(352, 9)
        Me.label_somier.Name = "label_somier"
        Me.label_somier.Size = New System.Drawing.Size(44, 13)
        Me.label_somier.TabIndex = 14
        Me.label_somier.Text = "Somiers"
        '
        'pictureBox_ofertas
        '
        Me.pictureBox_ofertas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox_ofertas.Image = CType(resources.GetObject("pictureBox_ofertas.Image"), System.Drawing.Image)
        Me.pictureBox_ofertas.Location = New System.Drawing.Point(316, 251)
        Me.pictureBox_ofertas.Name = "pictureBox_ofertas"
        Me.pictureBox_ofertas.Size = New System.Drawing.Size(121, 64)
        Me.pictureBox_ofertas.TabIndex = 15
        Me.pictureBox_ofertas.TabStop = False
        '
        'comboBox_ofertas
        '
        Me.comboBox_ofertas.FormattingEnabled = True
        Me.comboBox_ofertas.Location = New System.Drawing.Point(282, 321)
        Me.comboBox_ofertas.Name = "comboBox_ofertas"
        Me.comboBox_ofertas.Size = New System.Drawing.Size(180, 21)
        Me.comboBox_ofertas.TabIndex = 21
        '
        'label_ofertas
        '
        Me.label_ofertas.AutoSize = True
        Me.label_ofertas.Location = New System.Drawing.Point(352, 233)
        Me.label_ofertas.Name = "label_ofertas"
        Me.label_ofertas.Size = New System.Drawing.Size(41, 13)
        Me.label_ofertas.TabIndex = 18
        Me.label_ofertas.Text = "Ofertas"
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
        Me.label_euro5.Location = New System.Drawing.Point(117, 22)
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
        Me.button_informacion_base.TabIndex = 5
        Me.button_informacion_base.Text = "Informacion"
        Me.button_informacion_base.UseVisualStyleBackColor = True
        '
        'button_aniadir_base
        '
        Me.button_aniadir_base.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_base.Name = "button_aniadir_base"
        Me.button_aniadir_base.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_base.TabIndex = 4
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
        Me.comboBox_cantidad_base.TabIndex = 3
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
        Me.comboBox_tamanio_base.TabIndex = 2
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
        Me.label_euro4.Location = New System.Drawing.Point(117, 22)
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
        Me.button_informacion_somier.TabIndex = 10
        Me.button_informacion_somier.Text = "Informacion"
        Me.button_informacion_somier.UseVisualStyleBackColor = True
        '
        'button_aniadir_somier
        '
        Me.button_aniadir_somier.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_somier.Name = "button_aniadir_somier"
        Me.button_aniadir_somier.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_somier.TabIndex = 9
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
        Me.comboBox_cantidad_somier.TabIndex = 8
        '
        'comboBox_tamanio_somier
        '
        Me.comboBox_tamanio_somier.FormattingEnabled = True
        Me.comboBox_tamanio_somier.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_somier.Name = "comboBox_tamanio_somier"
        Me.comboBox_tamanio_somier.Size = New System.Drawing.Size(57, 21)
        Me.comboBox_tamanio_somier.TabIndex = 7
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
        Me.label_euro1.Location = New System.Drawing.Point(117, 22)
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
        Me.button_informacion_colchon.TabIndex = 15
        Me.button_informacion_colchon.Text = "Informacion"
        Me.button_informacion_colchon.UseVisualStyleBackColor = True
        '
        'button_aniadir_colchon
        '
        Me.button_aniadir_colchon.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_colchon.Name = "button_aniadir_colchon"
        Me.button_aniadir_colchon.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_colchon.TabIndex = 14
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
        Me.comboBox_cantidad_colchon.TabIndex = 13
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
        Me.comboBox_tamanio_colchon.TabIndex = 12
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
        Me.label_euro6.Location = New System.Drawing.Point(117, 22)
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
        Me.button_informacion_canape.TabIndex = 20
        Me.button_informacion_canape.Text = "Informacion"
        Me.button_informacion_canape.UseVisualStyleBackColor = True
        '
        'button_aniadir_canape
        '
        Me.button_aniadir_canape.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_canape.Name = "button_aniadir_canape"
        Me.button_aniadir_canape.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_canape.TabIndex = 19
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
        Me.comboBox_cantidad_canape.TabIndex = 18
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
        Me.comboBox_tamanio_canape.TabIndex = 17
        '
        'panel_ofertas
        '
        Me.panel_ofertas.Controls.Add(Me.label_euro3)
        Me.panel_ofertas.Controls.Add(Me.button_informacion_ofertas)
        Me.panel_ofertas.Controls.Add(Me.button_aniadir_ofertas)
        Me.panel_ofertas.Controls.Add(Me.comboBox_cantidad_ofertas)
        Me.panel_ofertas.Controls.Add(Me.label_precio_ofertas)
        Me.panel_ofertas.Controls.Add(Me.comboBox_tamanios_ofertas)
        Me.panel_ofertas.Location = New System.Drawing.Point(268, 348)
        Me.panel_ofertas.Name = "panel_ofertas"
        Me.panel_ofertas.Size = New System.Drawing.Size(211, 94)
        Me.panel_ofertas.TabIndex = 29
        '
        'label_euro3
        '
        Me.label_euro3.AutoSize = True
        Me.label_euro3.Location = New System.Drawing.Point(117, 22)
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
        Me.button_informacion_ofertas.TabIndex = 25
        Me.button_informacion_ofertas.Text = "Informacion"
        Me.button_informacion_ofertas.UseVisualStyleBackColor = True
        '
        'button_aniadir_ofertas
        '
        Me.button_aniadir_ofertas.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_ofertas.Name = "button_aniadir_ofertas"
        Me.button_aniadir_ofertas.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_ofertas.TabIndex = 24
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
        Me.comboBox_cantidad_ofertas.TabIndex = 23
        '
        'label_precio_ofertas
        '
        Me.label_precio_ofertas.AutoSize = True
        Me.label_precio_ofertas.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_ofertas.Name = "label_precio_ofertas"
        Me.label_precio_ofertas.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_ofertas.TabIndex = 20
        Me.label_precio_ofertas.Text = ": "
        '
        'comboBox_tamanios_ofertas
        '
        Me.comboBox_tamanios_ofertas.FormattingEnabled = True
        Me.comboBox_tamanios_ofertas.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanios_ofertas.Name = "comboBox_tamanios_ofertas"
        Me.comboBox_tamanios_ofertas.Size = New System.Drawing.Size(57, 21)
        Me.comboBox_tamanios_ofertas.TabIndex = 22
        '
        'panel_otros
        '
        Me.panel_otros.Controls.Add(Me.Label3)
        Me.panel_otros.Controls.Add(Me.button_informacion_otros)
        Me.panel_otros.Controls.Add(Me.button_aniadir_otros)
        Me.panel_otros.Controls.Add(Me.comboBox_cantidad_otros)
        Me.panel_otros.Controls.Add(Me.label_precio_otros)
        Me.panel_otros.Controls.Add(Me.comboBox_tamanio_otros)
        Me.panel_otros.Location = New System.Drawing.Point(518, 348)
        Me.panel_otros.Name = "panel_otros"
        Me.panel_otros.Size = New System.Drawing.Size(211, 94)
        Me.panel_otros.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 22)
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
        Me.button_informacion_otros.TabIndex = 30
        Me.button_informacion_otros.Text = "Informacion"
        Me.button_informacion_otros.UseVisualStyleBackColor = True
        '
        'button_aniadir_otros
        '
        Me.button_aniadir_otros.Location = New System.Drawing.Point(14, 56)
        Me.button_aniadir_otros.Name = "button_aniadir_otros"
        Me.button_aniadir_otros.Size = New System.Drawing.Size(75, 23)
        Me.button_aniadir_otros.TabIndex = 29
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
        Me.comboBox_cantidad_otros.TabIndex = 28
        '
        'label_precio_otros
        '
        Me.label_precio_otros.AutoSize = True
        Me.label_precio_otros.Location = New System.Drawing.Point(85, 22)
        Me.label_precio_otros.Name = "label_precio_otros"
        Me.label_precio_otros.Size = New System.Drawing.Size(13, 13)
        Me.label_precio_otros.TabIndex = 20
        Me.label_precio_otros.Text = ": "
        '
        'comboBox_tamanio_otros
        '
        Me.comboBox_tamanio_otros.FormattingEnabled = True
        Me.comboBox_tamanio_otros.Location = New System.Drawing.Point(14, 19)
        Me.comboBox_tamanio_otros.Name = "comboBox_tamanio_otros"
        Me.comboBox_tamanio_otros.Size = New System.Drawing.Size(55, 21)
        Me.comboBox_tamanio_otros.TabIndex = 27
        '
        'panel_acticulos
        '
        Me.panel_acticulos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel_acticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panel_acticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.panel_acticulos.Location = New System.Drawing.Point(87, 174)
        Me.panel_acticulos.Name = "panel_acticulos"
        Me.panel_acticulos.Size = New System.Drawing.Size(750, 482)
        Me.panel_acticulos.TabIndex = 30
        '
        'listBox_cantidad
        '
        Me.listBox_cantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listBox_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listBox_cantidad.FormattingEnabled = True
        Me.listBox_cantidad.Location = New System.Drawing.Point(9, 1)
        Me.listBox_cantidad.Name = "listBox_cantidad"
        Me.listBox_cantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.listBox_cantidad.Size = New System.Drawing.Size(18, 195)
        Me.listBox_cantidad.TabIndex = 31
        '
        'button_eliminar_1
        '
        Me.button_eliminar_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_eliminar_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button_eliminar_1.Location = New System.Drawing.Point(1118, 232)
        Me.button_eliminar_1.Name = "button_eliminar_1"
        Me.button_eliminar_1.Size = New System.Drawing.Size(46, 43)
        Me.button_eliminar_1.TabIndex = 36
        Me.button_eliminar_1.Text = "-"
        Me.button_eliminar_1.UseVisualStyleBackColor = False
        '
        'button_aniadir_1
        '
        Me.button_aniadir_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_aniadir_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button_aniadir_1.Location = New System.Drawing.Point(1118, 174)
        Me.button_aniadir_1.Name = "button_aniadir_1"
        Me.button_aniadir_1.Size = New System.Drawing.Size(46, 43)
        Me.button_aniadir_1.TabIndex = 35
        Me.button_aniadir_1.Text = "+"
        Me.button_aniadir_1.UseVisualStyleBackColor = False
        '
        'button_eliminar_articulo
        '
        Me.button_eliminar_articulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_eliminar_articulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button_eliminar_articulo.Location = New System.Drawing.Point(1118, 292)
        Me.button_eliminar_articulo.Name = "button_eliminar_articulo"
        Me.button_eliminar_articulo.Size = New System.Drawing.Size(46, 43)
        Me.button_eliminar_articulo.TabIndex = 37
        Me.button_eliminar_articulo.Text = "x"
        Me.button_eliminar_articulo.UseVisualStyleBackColor = False
        '
        'label_total
        '
        Me.label_total.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_total.AutoSize = True
        Me.label_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total.Location = New System.Drawing.Point(864, 458)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(52, 20)
        Me.label_total.TabIndex = 54
        Me.label_total.Text = "Total: "
        '
        'label_totalPrecio
        '
        Me.label_totalPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_totalPrecio.AutoSize = True
        Me.label_totalPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_totalPrecio.Location = New System.Drawing.Point(1001, 460)
        Me.label_totalPrecio.Name = "label_totalPrecio"
        Me.label_totalPrecio.Size = New System.Drawing.Size(0, 18)
        Me.label_totalPrecio.TabIndex = 55
        '
        'textBox_importe
        '
        Me.textBox_importe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textBox_importe.Location = New System.Drawing.Point(947, 513)
        Me.textBox_importe.Name = "textBox_importe"
        Me.textBox_importe.Size = New System.Drawing.Size(100, 20)
        Me.textBox_importe.TabIndex = 38
        '
        'label_importe
        '
        Me.label_importe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_importe.AutoSize = True
        Me.label_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_importe.Location = New System.Drawing.Point(864, 511)
        Me.label_importe.Name = "label_importe"
        Me.label_importe.Size = New System.Drawing.Size(72, 20)
        Me.label_importe.TabIndex = 57
        Me.label_importe.Text = "Importe: "
        '
        'label_resto
        '
        Me.label_resto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_resto.AutoSize = True
        Me.label_resto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_resto.Location = New System.Drawing.Point(866, 545)
        Me.label_resto.Name = "label_resto"
        Me.label_resto.Size = New System.Drawing.Size(60, 20)
        Me.label_resto.TabIndex = 58
        Me.label_resto.Text = "Resto: "
        '
        'label_totalDevolver
        '
        Me.label_totalDevolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_totalDevolver.AutoSize = True
        Me.label_totalDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_totalDevolver.Location = New System.Drawing.Point(1001, 545)
        Me.label_totalDevolver.Name = "label_totalDevolver"
        Me.label_totalDevolver.Size = New System.Drawing.Size(0, 18)
        Me.label_totalDevolver.TabIndex = 59
        '
        'label_euro
        '
        Me.label_euro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_euro.AutoSize = True
        Me.label_euro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_euro.Location = New System.Drawing.Point(1066, 458)
        Me.label_euro.Name = "label_euro"
        Me.label_euro.Size = New System.Drawing.Size(18, 20)
        Me.label_euro.TabIndex = 60
        Me.label_euro.Text = "€"
        '
        'label_euro8
        '
        Me.label_euro8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_euro8.AutoSize = True
        Me.label_euro8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_euro8.Location = New System.Drawing.Point(1066, 545)
        Me.label_euro8.Name = "label_euro8"
        Me.label_euro8.Size = New System.Drawing.Size(18, 20)
        Me.label_euro8.TabIndex = 61
        Me.label_euro8.Text = "€"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1066, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "€"
        '
        'Label_subtotal
        '
        Me.Label_subtotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_subtotal.AutoSize = True
        Me.Label_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_subtotal.Location = New System.Drawing.Point(867, 396)
        Me.Label_subtotal.Name = "Label_subtotal"
        Me.Label_subtotal.Size = New System.Drawing.Size(77, 20)
        Me.Label_subtotal.TabIndex = 63
        Me.Label_subtotal.Text = "Subtotal: "
        '
        'label_subtotalPrecio
        '
        Me.label_subtotalPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_subtotalPrecio.AutoSize = True
        Me.label_subtotalPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_subtotalPrecio.Location = New System.Drawing.Point(1001, 393)
        Me.label_subtotalPrecio.Name = "label_subtotalPrecio"
        Me.label_subtotalPrecio.Size = New System.Drawing.Size(0, 18)
        Me.label_subtotalPrecio.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1066, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "€"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(864, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "IVA 15%: "
        '
        'label_ivaPrecio
        '
        Me.label_ivaPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_ivaPrecio.AutoSize = True
        Me.label_ivaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ivaPrecio.Location = New System.Drawing.Point(1001, 430)
        Me.label_ivaPrecio.Name = "label_ivaPrecio"
        Me.label_ivaPrecio.Size = New System.Drawing.Size(0, 18)
        Me.label_ivaPrecio.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1066, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "€"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(0, 714)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1237, 38)
        Me.Panel2.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(10, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "F1 - Ayuda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(893, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha: "
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(1083, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Hora: "
        '
        'button_cobrar
        '
        Me.button_cobrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_cobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button_cobrar.Image = CType(resources.GetObject("button_cobrar.Image"), System.Drawing.Image)
        Me.button_cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_cobrar.Location = New System.Drawing.Point(859, 580)
        Me.button_cobrar.Name = "button_cobrar"
        Me.button_cobrar.Size = New System.Drawing.Size(146, 35)
        Me.button_cobrar.TabIndex = 39
        Me.button_cobrar.Text = "Cobrar"
        Me.button_cobrar.UseVisualStyleBackColor = False
        '
        'button_desconectar
        '
        Me.button_desconectar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_desconectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button_desconectar.Image = CType(resources.GetObject("button_desconectar.Image"), System.Drawing.Image)
        Me.button_desconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_desconectar.Location = New System.Drawing.Point(859, 620)
        Me.button_desconectar.Name = "button_desconectar"
        Me.button_desconectar.Size = New System.Drawing.Size(146, 36)
        Me.button_desconectar.TabIndex = 41
        Me.button_desconectar.Text = "Desconectar"
        Me.button_desconectar.UseVisualStyleBackColor = False
        '
        'button_anular
        '
        Me.button_anular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button_anular.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.button_anular.Image = CType(resources.GetObject("button_anular.Image"), System.Drawing.Image)
        Me.button_anular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_anular.Location = New System.Drawing.Point(1018, 580)
        Me.button_anular.Name = "button_anular"
        Me.button_anular.Size = New System.Drawing.Size(146, 35)
        Me.button_anular.TabIndex = 40
        Me.button_anular.Text = "Anular compra"
        Me.button_anular.UseVisualStyleBackColor = False
        '
        'ListBox_nombre
        '
        Me.ListBox_nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_nombre.FormattingEnabled = True
        Me.ListBox_nombre.Location = New System.Drawing.Point(26, 1)
        Me.ListBox_nombre.Name = "ListBox_nombre"
        Me.ListBox_nombre.Size = New System.Drawing.Size(138, 195)
        Me.ListBox_nombre.TabIndex = 32
        '
        'ListBox_precioUnidad
        '
        Me.ListBox_precioUnidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBox_precioUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_precioUnidad.FormattingEnabled = True
        Me.ListBox_precioUnidad.Location = New System.Drawing.Point(166, 1)
        Me.ListBox_precioUnidad.Name = "ListBox_precioUnidad"
        Me.ListBox_precioUnidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox_precioUnidad.Size = New System.Drawing.Size(33, 195)
        Me.ListBox_precioUnidad.TabIndex = 33
        '
        'ListBox_precioTotal
        '
        Me.ListBox_precioTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBox_precioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_precioTotal.FormattingEnabled = True
        Me.ListBox_precioTotal.Location = New System.Drawing.Point(201, 1)
        Me.ListBox_precioTotal.Name = "ListBox_precioTotal"
        Me.ListBox_precioTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox_precioTotal.Size = New System.Drawing.Size(51, 195)
        Me.ListBox_precioTotal.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.ListBox_nombre)
        Me.Panel3.Controls.Add(Me.ListBox_precioTotal)
        Me.Panel3.Controls.Add(Me.listBox_cantidad)
        Me.Panel3.Controls.Add(Me.ListBox_precioUnidad)
        Me.Panel3.Location = New System.Drawing.Point(843, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 205)
        Me.Panel3.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(845, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Cantidad"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(900, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1015, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1067, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Total"
        '
        'PictureBox_ticket
        '
        Me.PictureBox_ticket.Image = CType(resources.GetObject("PictureBox_ticket.Image"), System.Drawing.Image)
        Me.PictureBox_ticket.Location = New System.Drawing.Point(87, 79)
        Me.PictureBox_ticket.Name = "PictureBox_ticket"
        Me.PictureBox_ticket.Size = New System.Drawing.Size(118, 70)
        Me.PictureBox_ticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ticket.TabIndex = 80
        Me.PictureBox_ticket.TabStop = False
        Me.PictureBox_ticket.Visible = False
        '
        'Pantalla_de_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1228, 749)
        Me.Controls.Add(Me.PictureBox_ticket)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.button_desconectar)
        Me.Controls.Add(Me.button_anular)
        Me.Controls.Add(Me.button_cobrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label_ivaPrecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_subtotalPrecio)
        Me.Controls.Add(Me.Label_subtotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_euro8)
        Me.Controls.Add(Me.label_euro)
        Me.Controls.Add(Me.label_totalDevolver)
        Me.Controls.Add(Me.label_resto)
        Me.Controls.Add(Me.label_importe)
        Me.Controls.Add(Me.textBox_importe)
        Me.Controls.Add(Me.label_totalPrecio)
        Me.Controls.Add(Me.label_total)
        Me.Controls.Add(Me.button_eliminar_articulo)
        Me.Controls.Add(Me.button_aniadir_1)
        Me.Controls.Add(Me.button_eliminar_1)
        Me.Controls.Add(Me.panel_acticulos)
        Me.Controls.Add(Me.label_venta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_de_venta"
        Me.Text = "Colchoneria CUESTA - Venta de articulos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox_base, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_somier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_colchon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_canape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_otros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_ofertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_base.ResumeLayout(False)
        Me.panel_base.PerformLayout()
        Me.panel_somier.ResumeLayout(False)
        Me.panel_somier.PerformLayout()
        Me.panel_colchon.ResumeLayout(False)
        Me.panel_colchon.PerformLayout()
        Me.panel_canape.ResumeLayout(False)
        Me.panel_canape.PerformLayout()
        Me.panel_ofertas.ResumeLayout(False)
        Me.panel_ofertas.PerformLayout()
        Me.panel_otros.ResumeLayout(False)
        Me.panel_otros.PerformLayout()
        Me.panel_acticulos.ResumeLayout(False)
        Me.panel_acticulos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox_ticket, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents button_tarjeta As Button
    Friend WithEvents label_venta As Label
    Friend WithEvents pictureBox_base As PictureBox
    Friend WithEvents pictureBox_somier As PictureBox
    Friend WithEvents pictureBox_colchon As PictureBox
    Friend WithEvents pictureBox_canape As PictureBox
    Friend WithEvents pictureBox_otros As PictureBox
    Friend WithEvents comboBox_base As ComboBox
    Friend WithEvents comboBox_somier As ComboBox
    Friend WithEvents comboBox_colchon As ComboBox
    Friend WithEvents comboBox_otros As ComboBox
    Friend WithEvents comboBox_canape As ComboBox
    Friend WithEvents label_base As Label
    Friend WithEvents label_otros As Label
    Friend WithEvents label_canape As Label
    Friend WithEvents label_colchon As Label
    Friend WithEvents label_somier As Label
    Friend WithEvents pictureBox_ofertas As PictureBox
    Friend WithEvents comboBox_ofertas As ComboBox
    Friend WithEvents label_ofertas As Label
    Friend WithEvents panel_base As Panel
    Friend WithEvents label_euro5 As Label
    Friend WithEvents button_informacion_base As Button
    Friend WithEvents button_aniadir_base As Button
    Friend WithEvents comboBox_cantidad_base As ComboBox
    Friend WithEvents label_precio_base As Label
    Friend WithEvents comboBox_tamanio_base As ComboBox
    Friend WithEvents panel_somier As Panel
    Friend WithEvents label_euro4 As Label
    Friend WithEvents button_informacion_somier As Button
    Friend WithEvents button_aniadir_somier As Button
    Friend WithEvents comboBox_cantidad_somier As ComboBox
    Friend WithEvents comboBox_tamanio_somier As ComboBox
    Friend WithEvents label_precio_somier As Label
    Friend WithEvents panel_colchon As Panel
    Friend WithEvents label_euro1 As Label
    Friend WithEvents button_informacion_colchon As Button
    Friend WithEvents button_aniadir_colchon As Button
    Friend WithEvents comboBox_cantidad_colchon As ComboBox
    Friend WithEvents label_precio_colchon As Label
    Friend WithEvents comboBox_tamanio_colchon As ComboBox
    Friend WithEvents panel_canape As Panel
    Friend WithEvents label_euro6 As Label
    Friend WithEvents button_informacion_canape As Button
    Friend WithEvents button_aniadir_canape As Button
    Friend WithEvents comboBox_cantidad_canape As ComboBox
    Friend WithEvents label_precio_canape As Label
    Friend WithEvents comboBox_tamanio_canape As ComboBox
    Friend WithEvents panel_ofertas As Panel
    Friend WithEvents label_euro3 As Label
    Friend WithEvents button_informacion_ofertas As Button
    Friend WithEvents button_aniadir_ofertas As Button
    Friend WithEvents comboBox_cantidad_ofertas As ComboBox
    Friend WithEvents label_precio_ofertas As Label
    Friend WithEvents comboBox_tamanios_ofertas As ComboBox
    Friend WithEvents panel_otros As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents button_informacion_otros As Button
    Friend WithEvents button_aniadir_otros As Button
    Friend WithEvents comboBox_cantidad_otros As ComboBox
    Friend WithEvents label_precio_otros As Label
    Friend WithEvents comboBox_tamanio_otros As ComboBox
    Friend WithEvents panel_acticulos As Panel
    Friend WithEvents listBox_cantidad As ListBox
    Friend WithEvents button_eliminar_1 As Button
    Friend WithEvents button_aniadir_1 As Button
    Friend WithEvents button_eliminar_articulo As Button
    Friend WithEvents label_total As Label
    Friend WithEvents label_totalPrecio As Label
    Friend WithEvents textBox_importe As TextBox
    Friend WithEvents label_importe As Label
    Friend WithEvents label_resto As Label
    Friend WithEvents label_totalDevolver As Label
    Friend WithEvents label_euro As Label
    Friend WithEvents label_euro8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_subtotal As Label
    Friend WithEvents label_subtotalPrecio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents label_ivaPrecio As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GestionDeErroresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents button_cobrar As Button
    Friend WithEvents button_desconectar As Button
    Friend WithEvents button_anular As Button
    Friend WithEvents ListBox_nombre As ListBox
    Friend WithEvents ListBox_precioUnidad As ListBox
    Friend WithEvents ListBox_precioTotal As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PrintDocument_ticket As Printing.PrintDocument
    Friend WithEvents PictureBox_ticket As PictureBox
End Class
