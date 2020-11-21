
Module CreacionEmpleadosArticulos

    Sub Main()

        'Crear y añadir empleados
        Dim empleados As New List(Of Empleado.Empleado)

        Dim empleado1 As New Empleado.Empleado("Rafael", "Cuesta", "C/Moscu 1ºA", "28022", "603239217", "AdminCusta", 1234, True)
        Dim empleado2 As New Empleado.Empleado("Jorge", "Murcia", "C/Helsinki 2ºD", "28022", "603433762", "JorgeMurcia", 1234, False)
        Dim empleado3 As New Empleado.Empleado("Marina", "Cuesta", "C/Moscu 1ºA", "28022", "603245329", "MarinaCuesta", 1234, False)

        empleados.Add(empleado1)
        empleados.Add(empleado2)
        empleados.Add(empleado3)

        'Crear y añadir artículos
        Dim articulos As New List(Of Articulo.Articulo)

        Dim arti1 As New Articulo.Articulo("Colchon1", "Colchon viscoelástico celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti2 As New Articulo.Articulo("Colchon2""Colchon latex 100%, Certificado OKOTEX", "Colchon")
        Dim arti3 As New Articulo.Articulo("Viscoelástico HR", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti4 As New Articulo.Articulo("VISCO", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti5 As New Articulo.Articulo("Colchon visco grafeno", "Colchon firmeza media alta, gran confort", "Colchon")
        Dim arti6 As New Articulo.Articulo("Colchon active air", "Nucleo active air, memory foam 6cm, viscoelástica en cada cara", "Colchon")
        Dim arti7 As New Articulo.Articulo("Colchon visco-soja", "Linea super confort(termosoja)", "Colchon")
        Dim arti8 As New Articulo.Articulo("Colchon viscoelástica ecologico", "Con aceites naturales de soja y cítricos", "Colchon")
        Dim arti9 As New Articulo.Articulo("Vico serie plus", "Grafeno-viscolatex", "Colchon")
        Dim arti10 As New Articulo.Articulo("Colchon", "Muelles + viscoelástica", "Colchon")
        Dim arti11 As New Articulo.Articulo("Linea super-visco", "Conjunto linea de gran firmeza o linea gran confort + base tapizada reforzada", "Colchon")
        Dim arti12 As New Articulo.Articulo("Colchon muelle acolchado refuerzo lateral", "colchon + somier laminas anchas con patas a rosca", "Colchon")
        Dim arti13 As New Articulo.Articulo("Base tapizada", "Marco de hierro", "Base")
        Dim arti14 As New Articulo.Articulo("Cama-nido", "Con lámina ancha y refuerzo central", "Somier")
        Dim arti15 As New Articulo.Articulo("Somier lamina super ancha", "Somier con refuerzo central y soportes silenciosos", "Somier")
        Dim arti16 As New Articulo.Articulo("Cama electrica", "Somier electrico con colchon de viscoelástica o látex", "Somier")
        Dim arti17 As New Articulo.Articulo("Canapé abatible", "Madera vista", "Canape")
        Dim arti18 As New Articulo.Articulo("Canapé abatible curve", "Arcon madera vista, tapa transpirable, esquinas redondas", "Canape")
        Dim arti19 As New Articulo.Articulo("Canapé abatible máxima capacidad", "Arcon madera vista, tapa transpirable, esquinas de madera", "Canape")
        Dim arti20 As New Articulo.Articulo("Cama articula con arcon", "Cama eléctrica articulable con arcon para almacenamiento", "Canape")
        Dim arti21 As New Articulo.Articulo("Canapé abatible madera vista", "Canapé más colchon muelles ensacado", "Canape")
        Dim arti22 As New Articulo.Articulo("Canapé abatible esquinas reforzadas", "Canape más colchon visco grafeno de 2 caras", "Canape")

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
