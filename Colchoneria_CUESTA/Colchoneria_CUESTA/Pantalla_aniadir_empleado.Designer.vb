<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_aniadir_empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_aniadir_empleado))
        Me.label_elijaOpcion = New System.Windows.Forms.Label()
        Me.label_Gestion_empleados = New System.Windows.Forms.Label()
        Me.panel_elementosEmpleado = New System.Windows.Forms.Panel()
        Me.comboBox_roles = New System.Windows.Forms.ComboBox()
        Me.label_contraseniaInformacion = New System.Windows.Forms.Label()
        Me.label_camposObligatorios = New System.Windows.Forms.Label()
        Me.textBox_contrasenia2 = New System.Windows.Forms.TextBox()
        Me.textBox_telefono = New System.Windows.Forms.TextBox()
        Me.textBox_apellidos = New System.Windows.Forms.TextBox()
        Me.textBox_contrasenia = New System.Windows.Forms.TextBox()
        Me.textBox_nombreUsuario = New System.Windows.Forms.TextBox()
        Me.textBox_codigoPostal = New System.Windows.Forms.TextBox()
        Me.textBox_direccion = New System.Windows.Forms.TextBox()
        Me.textBox_nombre = New System.Windows.Forms.TextBox()
        Me.boton_cancelar = New System.Windows.Forms.Button()
        Me.boton_guardar = New System.Windows.Forms.Button()
        Me.label_contrasenia2 = New System.Windows.Forms.Label()
        Me.label_rol = New System.Windows.Forms.Label()
        Me.label_contrasenia = New System.Windows.Forms.Label()
        Me.label_nombreUsuario = New System.Windows.Forms.Label()
        Me.label_telefono = New System.Windows.Forms.Label()
        Me.label_codigoPostal = New System.Windows.Forms.Label()
        Me.label_nombre = New System.Windows.Forms.Label()
        Me.label_direccion = New System.Windows.Forms.Label()
        Me.label_apellidos = New System.Windows.Forms.Label()
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
        Me.panel_elementosEmpleado.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_elijaOpcion
        '
        Me.label_elijaOpcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_elijaOpcion.AutoSize = True
        Me.label_elijaOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_elijaOpcion.Location = New System.Drawing.Point(364, 94)
        Me.label_elijaOpcion.Name = "label_elijaOpcion"
        Me.label_elijaOpcion.Size = New System.Drawing.Size(155, 20)
        Me.label_elijaOpcion.TabIndex = 25
        Me.label_elijaOpcion.Text = "Alta de un empleado"
        '
        'label_Gestion_empleados
        '
        Me.label_Gestion_empleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_Gestion_empleados.AutoSize = True
        Me.label_Gestion_empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Gestion_empleados.Location = New System.Drawing.Point(328, 58)
        Me.label_Gestion_empleados.Name = "label_Gestion_empleados"
        Me.label_Gestion_empleados.Size = New System.Drawing.Size(227, 25)
        Me.label_Gestion_empleados.TabIndex = 24
        Me.label_Gestion_empleados.Text = "Gestion de empleados"
        '
        'panel_elementosEmpleado
        '
        Me.panel_elementosEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel_elementosEmpleado.Controls.Add(Me.comboBox_roles)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_contraseniaInformacion)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_camposObligatorios)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_contrasenia2)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_telefono)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_apellidos)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_contrasenia)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_nombreUsuario)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_codigoPostal)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_direccion)
        Me.panel_elementosEmpleado.Controls.Add(Me.textBox_nombre)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_contrasenia2)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_rol)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_contrasenia)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_nombreUsuario)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_telefono)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_codigoPostal)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_nombre)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_direccion)
        Me.panel_elementosEmpleado.Controls.Add(Me.label_apellidos)
        Me.panel_elementosEmpleado.Location = New System.Drawing.Point(129, 141)
        Me.panel_elementosEmpleado.Name = "panel_elementosEmpleado"
        Me.panel_elementosEmpleado.Size = New System.Drawing.Size(635, 260)
        Me.panel_elementosEmpleado.TabIndex = 23
        '
        'comboBox_roles
        '
        Me.comboBox_roles.FormattingEnabled = True
        Me.comboBox_roles.Items.AddRange(New Object() {"Administrador", "Empleado"})
        Me.comboBox_roles.Location = New System.Drawing.Point(453, 162)
        Me.comboBox_roles.Name = "comboBox_roles"
        Me.comboBox_roles.Size = New System.Drawing.Size(136, 21)
        Me.comboBox_roles.TabIndex = 35
        '
        'label_contraseniaInformacion
        '
        Me.label_contraseniaInformacion.AutoSize = True
        Me.label_contraseniaInformacion.Location = New System.Drawing.Point(19, 226)
        Me.label_contraseniaInformacion.Name = "label_contraseniaInformacion"
        Me.label_contraseniaInformacion.Size = New System.Drawing.Size(219, 13)
        Me.label_contraseniaInformacion.TabIndex = 34
        Me.label_contraseniaInformacion.Text = "(Tiene que contener 4 caracteres numericos)"
        '
        'label_camposObligatorios
        '
        Me.label_camposObligatorios.AutoSize = True
        Me.label_camposObligatorios.Location = New System.Drawing.Point(43, 14)
        Me.label_camposObligatorios.Name = "label_camposObligatorios"
        Me.label_camposObligatorios.Size = New System.Drawing.Size(111, 13)
        Me.label_camposObligatorios.TabIndex = 33
        Me.label_camposObligatorios.Text = "Campos obligatorios*: "
        '
        'textBox_contrasenia2
        '
        Me.textBox_contrasenia2.Location = New System.Drawing.Point(453, 203)
        Me.textBox_contrasenia2.MaxLength = 4
        Me.textBox_contrasenia2.Name = "textBox_contrasenia2"
        Me.textBox_contrasenia2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBox_contrasenia2.Size = New System.Drawing.Size(54, 20)
        Me.textBox_contrasenia2.TabIndex = 32
        '
        'textBox_telefono
        '
        Me.textBox_telefono.Location = New System.Drawing.Point(453, 119)
        Me.textBox_telefono.MaxLength = 20
        Me.textBox_telefono.Name = "textBox_telefono"
        Me.textBox_telefono.Size = New System.Drawing.Size(100, 20)
        Me.textBox_telefono.TabIndex = 30
        '
        'textBox_apellidos
        '
        Me.textBox_apellidos.Location = New System.Drawing.Point(453, 43)
        Me.textBox_apellidos.MaxLength = 30
        Me.textBox_apellidos.Name = "textBox_apellidos"
        Me.textBox_apellidos.Size = New System.Drawing.Size(159, 20)
        Me.textBox_apellidos.TabIndex = 29
        '
        'textBox_contrasenia
        '
        Me.textBox_contrasenia.Location = New System.Drawing.Point(130, 203)
        Me.textBox_contrasenia.MaxLength = 4
        Me.textBox_contrasenia.Name = "textBox_contrasenia"
        Me.textBox_contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBox_contrasenia.Size = New System.Drawing.Size(60, 20)
        Me.textBox_contrasenia.TabIndex = 28
        '
        'textBox_nombreUsuario
        '
        Me.textBox_nombreUsuario.Location = New System.Drawing.Point(130, 162)
        Me.textBox_nombreUsuario.MaxLength = 10
        Me.textBox_nombreUsuario.Name = "textBox_nombreUsuario"
        Me.textBox_nombreUsuario.Size = New System.Drawing.Size(100, 20)
        Me.textBox_nombreUsuario.TabIndex = 27
        '
        'textBox_codigoPostal
        '
        Me.textBox_codigoPostal.Location = New System.Drawing.Point(130, 119)
        Me.textBox_codigoPostal.MaxLength = 5
        Me.textBox_codigoPostal.Name = "textBox_codigoPostal"
        Me.textBox_codigoPostal.Size = New System.Drawing.Size(100, 20)
        Me.textBox_codigoPostal.TabIndex = 26
        '
        'textBox_direccion
        '
        Me.textBox_direccion.Location = New System.Drawing.Point(130, 79)
        Me.textBox_direccion.MaxLength = 40
        Me.textBox_direccion.Name = "textBox_direccion"
        Me.textBox_direccion.Size = New System.Drawing.Size(278, 20)
        Me.textBox_direccion.TabIndex = 25
        '
        'textBox_nombre
        '
        Me.textBox_nombre.Location = New System.Drawing.Point(130, 43)
        Me.textBox_nombre.MaxLength = 25
        Me.textBox_nombre.Name = "textBox_nombre"
        Me.textBox_nombre.Size = New System.Drawing.Size(162, 20)
        Me.textBox_nombre.TabIndex = 24
        '
        'boton_cancelar
        '
        Me.boton_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.boton_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_cancelar.Location = New System.Drawing.Point(325, 420)
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(134, 31)
        Me.boton_cancelar.TabIndex = 20
        Me.boton_cancelar.Text = "Cancelar"
        Me.boton_cancelar.UseVisualStyleBackColor = True
        '
        'boton_guardar
        '
        Me.boton_guardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.boton_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_guardar.Location = New System.Drawing.Point(129, 420)
        Me.boton_guardar.Name = "boton_guardar"
        Me.boton_guardar.Size = New System.Drawing.Size(134, 31)
        Me.boton_guardar.TabIndex = 21
        Me.boton_guardar.Text = "Guardar"
        Me.boton_guardar.UseVisualStyleBackColor = True
        '
        'label_contrasenia2
        '
        Me.label_contrasenia2.AutoSize = True
        Me.label_contrasenia2.Location = New System.Drawing.Point(344, 206)
        Me.label_contrasenia2.Name = "label_contrasenia2"
        Me.label_contrasenia2.Size = New System.Drawing.Size(107, 13)
        Me.label_contrasenia2.TabIndex = 23
        Me.label_contrasenia2.Text = "Repetir contraseña*: "
        '
        'label_rol
        '
        Me.label_rol.AutoSize = True
        Me.label_rol.Location = New System.Drawing.Point(344, 165)
        Me.label_rol.Name = "label_rol"
        Me.label_rol.Size = New System.Drawing.Size(33, 13)
        Me.label_rol.TabIndex = 22
        Me.label_rol.Text = "Rol*: "
        '
        'label_contrasenia
        '
        Me.label_contrasenia.AutoSize = True
        Me.label_contrasenia.Location = New System.Drawing.Point(19, 206)
        Me.label_contrasenia.Name = "label_contrasenia"
        Me.label_contrasenia.Size = New System.Drawing.Size(71, 13)
        Me.label_contrasenia.TabIndex = 21
        Me.label_contrasenia.Text = "Contraseña*: "
        '
        'label_nombreUsuario
        '
        Me.label_nombreUsuario.AutoSize = True
        Me.label_nombreUsuario.Location = New System.Drawing.Point(19, 165)
        Me.label_nombreUsuario.Name = "label_nombreUsuario"
        Me.label_nombreUsuario.Size = New System.Drawing.Size(103, 13)
        Me.label_nombreUsuario.TabIndex = 20
        Me.label_nombreUsuario.Text = "Nombre de usuario*:"
        '
        'label_telefono
        '
        Me.label_telefono.AutoSize = True
        Me.label_telefono.Location = New System.Drawing.Point(344, 122)
        Me.label_telefono.Name = "label_telefono"
        Me.label_telefono.Size = New System.Drawing.Size(59, 13)
        Me.label_telefono.TabIndex = 19
        Me.label_telefono.Text = "Telefono*: "
        '
        'label_codigoPostal
        '
        Me.label_codigoPostal.AutoSize = True
        Me.label_codigoPostal.Location = New System.Drawing.Point(19, 122)
        Me.label_codigoPostal.Name = "label_codigoPostal"
        Me.label_codigoPostal.Size = New System.Drawing.Size(78, 13)
        Me.label_codigoPostal.TabIndex = 18
        Me.label_codigoPostal.Text = "Codigo postal*:"
        '
        'label_nombre
        '
        Me.label_nombre.AutoSize = True
        Me.label_nombre.Location = New System.Drawing.Point(19, 46)
        Me.label_nombre.Name = "label_nombre"
        Me.label_nombre.Size = New System.Drawing.Size(54, 13)
        Me.label_nombre.TabIndex = 15
        Me.label_nombre.Text = "Nombre*: "
        '
        'label_direccion
        '
        Me.label_direccion.AutoSize = True
        Me.label_direccion.Location = New System.Drawing.Point(19, 82)
        Me.label_direccion.Name = "label_direccion"
        Me.label_direccion.Size = New System.Drawing.Size(62, 13)
        Me.label_direccion.TabIndex = 17
        Me.label_direccion.Text = "Direccion*: "
        '
        'label_apellidos
        '
        Me.label_apellidos.AutoSize = True
        Me.label_apellidos.Location = New System.Drawing.Point(344, 46)
        Me.label_apellidos.Name = "label_apellidos"
        Me.label_apellidos.Size = New System.Drawing.Size(64, 13)
        Me.label_apellidos.TabIndex = 16
        Me.label_apellidos.Text = "Apellido/s*: "
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(882, 24)
        Me.MenuStrip.TabIndex = 26
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
        Me.Panel1.Location = New System.Drawing.Point(0, 467)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 42)
        Me.Panel1.TabIndex = 27
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
        Me.label_fecha.Location = New System.Drawing.Point(537, 9)
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
        Me.label_hora.Location = New System.Drawing.Point(728, 9)
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
        'Pantalla_aniadir_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.label_elijaOpcion)
        Me.Controls.Add(Me.label_Gestion_empleados)
        Me.Controls.Add(Me.panel_elementosEmpleado)
        Me.Controls.Add(Me.boton_cancelar)
        Me.Controls.Add(Me.boton_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_aniadir_empleado"
        Me.Text = "Colchoneria CUESTA - Gesion de empleados - Alta de empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_elementosEmpleado.ResumeLayout(False)
        Me.panel_elementosEmpleado.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_elijaOpcion As Label
    Friend WithEvents label_Gestion_empleados As Label
    Friend WithEvents panel_elementosEmpleado As Panel
    Friend WithEvents comboBox_roles As ComboBox
    Friend WithEvents label_contraseniaInformacion As Label
    Friend WithEvents label_camposObligatorios As Label
    Friend WithEvents textBox_contrasenia2 As TextBox
    Friend WithEvents textBox_telefono As TextBox
    Friend WithEvents textBox_apellidos As TextBox
    Friend WithEvents textBox_contrasenia As TextBox
    Friend WithEvents textBox_nombreUsuario As TextBox
    Friend WithEvents textBox_codigoPostal As TextBox
    Friend WithEvents textBox_direccion As TextBox
    Friend WithEvents textBox_nombre As TextBox
    Friend WithEvents boton_cancelar As Button
    Friend WithEvents boton_guardar As Button
    Friend WithEvents label_contrasenia2 As Label
    Friend WithEvents label_rol As Label
    Friend WithEvents label_contrasenia As Label
    Friend WithEvents label_nombreUsuario As Label
    Friend WithEvents label_telefono As Label
    Friend WithEvents label_codigoPostal As Label
    Friend WithEvents label_nombre As Label
    Friend WithEvents label_direccion As Label
    Friend WithEvents label_apellidos As Label
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
End Class
