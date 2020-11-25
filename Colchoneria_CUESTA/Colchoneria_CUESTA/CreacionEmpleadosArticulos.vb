
Imports GestionComercial

Module CreacionEmpleadosArticulos

    Sub Main()

        'Crear un ArrayList de tipo Empleado, creamos los emlpeados y por último añadimos los empleados.
        Dim empleados As New List(Of Empleado)

        Dim empleado1 As New Empleado(1, "Rafael", "Cuesta", "C/Moscu 1ºA", "28022", "603239217", "AdminCusta", 1234, True)
        Dim empleado2 As New Empleado(2, "Jorge", "Murcia", "C/Helsinki 2ºD", "28022", "603433762", "JorgeMurcia", 1234, False)
        Dim empleado3 As New Empleado(3, "Marina", "Cuesta", "C/Moscu 1ºA", "28022", "603245329", "MarinaCuesta", 1234, False)

        empleados.Add(empleado1)
        empleados.Add(empleado2)
        empleados.Add(empleado3)

        FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Write, , Len(empleadoRegistro))

        For i = 0 To empleados.Count - 1

            empleadoRegistro.codigoEmpleado = empleados.Item(i).getCodigoEmpleado
            empleadoRegistro.nombre = empleados.Item(i).getNombreEmpleado
            empleadoRegistro.apellidos = empleados.Item(i).getApellidos
            empleadoRegistro.direccion = empleados.Item(i).getDireccion
            empleadoRegistro.codigoPostal = empleados.Item(i).getCodigoPostal
            empleadoRegistro.telefono = empleados.Item(i).getTelefono
            empleadoRegistro.nombreUsuario = empleados.Item(i).getNombreUsuario
            empleadoRegistro.contrasenia = empleados.Item(i).getContraseniaEmpleado
            empleadoRegistro.esAdministrador = empleados.Item(i).getEsAdministrador


            FilePut(1, empleadoRegistro, (i + 1))
        Next i


        FileClose(1)

        'Crear un ArrayList de tipo Articulo, creamos los artículos y por último añadimos los artículos al listado
        Dim articulos As New List(Of Articulo)

        Dim arti1 As New Articulo(1, "Colch. viscoel.", "Colchon viscoelástico celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti2 As New Articulo(2, "Colch. latex 100%", "Colchon latex 100%, Certificado OKOTEX", "Colchon")
        Dim arti3 As New Articulo(3, "Colch. viscoel. HR", "Viscoelástico HR, celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti4 As New Articulo(4, "Colch. visco nucleoHR", "VISCO, celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti5 As New Articulo(5, "Colch. visco grafeno", "Colchon visco grafeno, colchon firmeza media alta, gran confort", "Colchon")
        Dim arti6 As New Articulo(6, "Colch. active air", "Colchon active air, núcleo active air, memory foam 6cm, viscoelástica en cada cara", "Colchon")
        Dim arti7 As New Articulo(7, "Colch. visco-soja", "Colchon visco-soja, línea super confort(termosoja)", "Colchon")
        Dim arti8 As New Articulo(8, "Colch. viscoel. eco", "Colchon viscoelástica ecologico, con aceites naturales de soja y cítricos", "Colchon")
        Dim arti9 As New Articulo(9, "Colch. serie plus", "Vico serie plus, grafeno-viscolatex", "Colchon")
        Dim arti10 As New Articulo(10, "Colch. visco+muelle", "Muelles + viscoelástica", "Colchon")
        Dim arti23 As New Articulo(11, "Colch. MM visco gel", "Micro muelle ensacado, visco, gel, graffeno", "Colchon")
        Dim arti24 As New Articulo(12, "Colch. MM doble cara", "Micro muelle ensacado, lechos diferenciados, doble cara de viscoelástica y doble cara latex", "Colchon")
        Dim arti11 As New Articulo(13, "Oft. linea super-vsc", "Linea super-visco, conjunto linea de gran firmeza o linea gran confort + base tapizada reforzada", "Oferta")
        Dim arti12 As New Articulo(14, "Oft. colch. y somr", "Colchon muelle acolchado refuerzo lateral, colchon + somier laminas anchas con patas a rosca", "Oferta")
        Dim arti13 As New Articulo(15, "Bs. tapizada-hierro", "Base tapizada, marco de hierro", "Base")
        Dim arti14 As New Articulo(16, "Somr. cama-nido", "Cama-nido con lámina ancha y refuerzo central", "Somier")
        Dim arti15 As New Articulo(17, "Somr. super ancho", "Somier lamina super ancha con refuerzo central y soportes silenciosos", "Somier")
        Dim arti16 As New Articulo(18, "Oft. somr+colch. elc", "Somier electrico con colchon de viscoelástica o látex", "Oferta")
        Dim arti17 As New Articulo(19, "Canp. madera vista", "Canapé abatible, madera vista", "Canape")
        Dim arti18 As New Articulo(20, "Canp. abt. curve", "Canapé abatible curve, arcon madera vista, tapa transpirable, esquinas redondas", "Canape")
        Dim arti19 As New Articulo(21, "Canp. abt. max capac", "Canapé abatible máxima capacidad, arcon madera vista, tapa transpirable, esquinas de madera", "Canape")
        Dim arti20 As New Articulo(22, "Canp. con arcon, elc", "Cama articula con arcon, cama eléctrica articulable con arcon para almacenamiento", "Canape")
        Dim arti21 As New Articulo(23, "Oft. canp.mad.+colch.", "Canapé abatible madera vista, canapé + colchon muelles ensacado", "Oferta")
        Dim arti22 As New Articulo(24, "Oft. canp.ref.+colch.", "Canapé abatible esquinas reforzadas + colchon visco grafeno de 2 caras", "Oferta")

        articulos.Add(arti1)
        articulos.Add(arti2)
        articulos.Add(arti3)
        articulos.Add(arti4)
        articulos.Add(arti5)
        articulos.Add(arti6)
        articulos.Add(arti7)
        articulos.Add(arti8)
        articulos.Add(arti9)
        articulos.Add(arti10)
        articulos.Add(arti12)
        articulos.Add(arti13)
        articulos.Add(arti14)
        articulos.Add(arti15)
        articulos.Add(arti16)
        articulos.Add(arti17)
        articulos.Add(arti18)
        articulos.Add(arti19)
        articulos.Add(arti20)
        articulos.Add(arti21)
        articulos.Add(arti22)
        articulos.Add(arti23)
        articulos.Add(arti24)

        FileOpen(2, "Articulos.txt", OpenMode.Random, OpenAccess.Write, , Len(articuloRegistro))

        For i = 0 To articulos.Count - 1
            articuloRegistro.codigoArticulo = articulos.Item(i).getCodigoArticulo
            articuloRegistro.nombre = articulos.Item(i).getNombreArticulo
            articuloRegistro.descripcion = articulos.Item(i).getDescripcionArticulo
            articuloRegistro.categoria = articulos.Item(i).getCategoriaArticulo
            articuloRegistro.tamanios = articulos.Item(i).getTamaniosArticulo
            articuloRegistro.precios = articulos.Item(i).getPreciosTamaniosArticulo

            FilePut(2, articuloRegistro, (i + 1))
        Next i


        FileClose(2)


        'Public Sub New(nombre As String, desc As String, cat As String)
        '    Me.nombreArticulo = nombre
        '    Me.descripcionArticulo = desc
        '    Me.categoriaArticulo = cat

        '    'Llenado del ArrayList posiblesCategoriasArticulo
        '    Me.posiblesCategoriasArticulo.Add("Base")
        '    Me.posiblesCategoriasArticulo.Add("Somier")
        '    Me.posiblesCategoriasArticulo.Add("Canape")
        '    Me.posiblesCategoriasArticulo.Add("Colchon")
        '    Me.posiblesCategoriasArticulo.Add("Ofertas")
        '    Me.posiblesCategoriasArticulo.Add("Otros")

        '    'Llenamos el ArrayList de posiblesTamaniosArticulo
        '    Me.posiblesTamaniosArticulo.Add(80)
        '    Me.posiblesTamaniosArticulo.Add(90)
        '    Me.posiblesTamaniosArticulo.Add(105)
        '    Me.posiblesTamaniosArticulo.Add(135)
        '    Me.posiblesTamaniosArticulo.Add(150)
        '    Me.posiblesTamaniosArticulo.Add(160)
        '    Me.posiblesTamaniosArticulo.Add(180)

        'End Sub

    End Sub


End Module
