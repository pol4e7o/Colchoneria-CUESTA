
Imports GestionComercial

Module CreacionEmpleadosArticulos

    Sub Main()

        'Crear un ArrayList de tipo Empleado, creamos los emlpeados y por último añadimos los empleados.
        Dim empleados As New List(Of Empleado)

        Dim empleado1 As New Empleado("Rafael", "Cuesta", "C/Moscu 1ºA", "28022", "603239217", "AdminCusta", 1234, True)
        Dim empleado2 As New Empleado("Jorge", "Murcia", "C/Helsinki 2ºD", "28022", "603433762", "JorgeMurcia", 1234, False)
        Dim empleado3 As New Empleado("Marina", "Cuesta", "C/Moscu 1ºA", "28022", "603245329", "MarinaCuesta", 1234, False)

        empleados.Add(empleado1)
        empleados.Add(empleado2)
        empleados.Add(empleado3)

        'Crear un ArrayList de tipo Articulo, creamos los artículos y por último añadimos los artículos al listado
        Dim articulos As New List(Of Articulo)

        Dim arti1 As New Articulo("Colchon1", "Colchon viscoelástico celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti2 As New Articulo("Colchon2", "Colchon latex 100%, Certificado OKOTEX", "Colchon")
        Dim arti3 As New Articulo("Colchon3", "Viscoelástico HR, celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti4 As New Articulo("Colchon4", "VISCO, celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti5 As New Articulo("Colchon5", "Colchon visco grafeno, colchon firmeza media alta, gran confort", "Colchon")
        Dim arti6 As New Articulo("Colchon6", "Colchon active air, núcleo active air, memory foam 6cm, viscoelástica en cada cara", "Colchon")
        Dim arti7 As New Articulo("Colchon7", "Colchon visco-soja, línea super confort(termosoja)", "Colchon")
        Dim arti8 As New Articulo("Colchon8", "Colchon viscoelástica ecologico, con aceites naturales de soja y cítricos", "Colchon")
        Dim arti9 As New Articulo("Colchon9", "Vico serie plus, grafeno-viscolatex", "Colchon")
        Dim arti10 As New Articulo("Colchon10", "Muelles + viscoelástica", "Colchon")
        Dim arti23 As New Articulo("Colchon11", "Micro muelle ensacado, visco, gel, graffeno", "Colchon")
        Dim arti24 As New Articulo("Colchon12", "Micro muelle ensacado, lechos diferenciados, doble cara de viscoelástica y doble cara latex", "Colchon")
        Dim arti11 As New Articulo("Oferta1", "Linea super-visco, conjunto linea de gran firmeza o linea gran confort + base tapizada reforzada", "Oferta")
        Dim arti12 As New Articulo("Oferta2", "Colchon muelle acolchado refuerzo lateral, colchon + somier laminas anchas con patas a rosca", "Oferta")
        Dim arti13 As New Articulo("Base1", "Base tapizada, marco de hierro", "Base")
        Dim arti14 As New Articulo("Somier1", "Cama-nido con lámina ancha y refuerzo central", "Somier")
        Dim arti15 As New Articulo("Somier2", "Somier lamina super ancha con refuerzo central y soportes silenciosos", "Somier")
        Dim arti16 As New Articulo("Oferta3", "Somier electrico con colchon de viscoelástica o látex", "Oferta")
        Dim arti17 As New Articulo("Canape1", "Canapé abatible, madera vista", "Canape")
        Dim arti18 As New Articulo("Canape2", "Canapé abatible curve, arcon madera vista, tapa transpirable, esquinas redondas", "Canape")
        Dim arti19 As New Articulo("Canape3", "Canapé abatible máxima capacidad, arcon madera vista, tapa transpirable, esquinas de madera", "Canape")
        Dim arti20 As New Articulo("Canape4", "Cama articula con arcon, cama eléctrica articulable con arcon para almacenamiento", "Canape")
        Dim arti21 As New Articulo("Oferta4", "Canapé abatible madera vista, canapé + colchon muelles ensacado", "Oferta")
        Dim arti22 As New Articulo("Oferta5", "Canapé abatible esquinas reforzadas + colchon visco grafeno de 2 caras", "Oferta")

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
