Imports Empleado
Imports Articulo


Module CreacionEmpleadosArticulos

    Sub Main()

        'Crear y añadir empleados
        Dim empleados As New List(Of Empleado)
    Dim empleado1 As New Empleado("Rafael", "Cuesta", "C/Moscu 1ºA", "28022", "603239217", "AdminCusta", 1234, True)
        Dim empleado2 As New Empleado("Jorge", "Murcia", "C/Helsinki 2ºD", "28022", "603433762", "JorgeMurcia", 1234, False)
    Dim empleado3 As New Empleado("Marina", "Cuesta", "C/Moscu 1ºA", "28022", "603245329", "MarinaCuesta", 1234, False)
    empleados.Add(empleado1)
    empleados.Add(empleado2)
        empleados.Add(empleado3)
        'Crear y añadir artículos
        Dim articulos As New List(Of Articulo)
    Dim arti1 As New Articulos("Colchon viscoelástico", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti2 As New Articulos("Colchon latex 100%", "Certificado OKOTEX", "Colchon")
        Dim arti3 As New Articulos("Viscoelástico HR", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti4 As New Articulos("VISCO", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti5 As New Articulos("Colchon visco grafeno", "Colchon firmeza media alta, gran confort", "Colchon")
        Dim arti6 As New Articulos("Colchon active air", "Nucleo active air, memory foam 6cm, viscoelástica en cada cara", "Colchon")
        Dim arti7 As New Articulos("Colchon visco-soja", "Linea super confort(termosoja)", "Colchon")
        Dim arti8 As New Articulos("Colchon viscoelástica ecologico", "Con aceites naturales de soja y cítricos", "Colchon")
        Dim arti9 As New Articulos("Vico serie plus", "Grafeno-viscolatex", "Colchon")
        Dim arti10 As New Articulos("Colchon", "Muelles + viscoelástica", "Colchon")
        Dim arti11 As New Articulos("Linea super-visco", "Conjunto linea de gran firmeza o linea gran confort + base tapizada reforzada", "Colchon")
        Dim arti12 As New Articulos("Colchon muelle acolchado refuerzo lateral", "colchon + somier laminas anchas con patas a rosca", "Colchon")
    Dim arti13 As New Articulos("Base tapizada", "Marco de hierro", "Base")
    Dim arti14 As New Articulos("Cama-nido", "Con lámina ancha y refuerzo central", "Somier")
    Dim arti15 As New Articulos("Somier lamina super ancha", "Somier con refuerzo central y soportes silenciosos", "Somier")
    Dim arti16 As New Articulos("Cama electrica", "Somier electrico con colchon de viscoelástica o látex", "Somier")
    Dim arti17 As New Articulos("Canapé abatible", "Madera vista", "Canape")
    Dim arti18 As New Articulos("Canapé abatible curve", "Arcon madera vista, tapa transpirable, esquinas redondas", "Canape")
    Dim arti19 As New Articulos("Canapé abatible máxima capacidad", "Arcon madera vista, tapa transpirable, esquinas de madera", "Canape")
    Dim arti20 As New Articulos("Cama articula con arcon", "Cama eléctrica articulable con arcon para almacenamiento", "Canape")
    Dim arti21 As New Articulos("Canapé abatible madera vista", "Canapé más colchon muelles ensacado", "Canape")
    Dim arti22 As New Articulos("Canapé abatible esquinas reforzadas", "Canape más colchon visco grafeno de 2 caras", "Canape")
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
