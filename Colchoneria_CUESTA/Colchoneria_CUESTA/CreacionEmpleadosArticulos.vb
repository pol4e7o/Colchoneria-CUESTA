Imports Empleado
Imports Articulo


Module CreacionEmpleadosArticulos

    Sub Main()
        Dim empleado1 As New Empleado("Rafael", "Cuesta", "C/Moscu 1ºA", "28022", "603239217", "AdminCusta", 1234, True)
        Dim empleado2 As New Empleado("Jorge", "Murcia", "C/Helsinki 2ºD", "28022", "603433762", "JorgeMurcia", 1234, False)
        Dim empleado3 As New Empleado("Marina", "Cuesta", "C/Moscu 1ºA", "28022", "603245329", "MarinaCuesta", 1234, False)

        Dim arti1 As New Articulos("Colchon viscoelástico", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti2 As New Articulos("Colchon latex 100%", "Certificado OKOTEX", "Colchon")
        Dim arti3 As New Articulos("Viscoelástico HR", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti4 As New Articulos("VISCO", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")
        Dim arti5 As New Articulos("Colchon visco grafeno", "Colchon firmeza media alta, gran confort", "Colchon")
        Dim arti6 As New Articulos("Colchon active air", "Nucleo active air, memory foam 6cm, viscoelástica en cada cara", "Colchon")
        Dim arti7 As New Articulos("Colchon visco-soja", "Linea super confort(termosoja)", "Colchon")
        Dim arti8 As New Articulos("Colchon viscoelástica ecologico", "Con aceites naturales de soja y cítricos", "Colchon")
        Dim arti9 As New Articulos("Colchon viscoelástico", "Celula abierta, adaptable, termosensible, nucleo HR", "Colchon")

        Public Sub New(nombre As String, desc As String, cat As String)
        Me.nombreArticulo = nombre
        Me.descripcionArticulo = desc
        Me.categoriaArticulo = cat

        'Llenado del ArrayList posiblesCategoriasArticulo
        Me.posiblesCategoriasArticulo.Add("Base")
        Me.posiblesCategoriasArticulo.Add("Somier")
        Me.posiblesCategoriasArticulo.Add("Canape")
        Me.posiblesCategoriasArticulo.Add("Colchon")
        Me.posiblesCategoriasArticulo.Add("Ofertas")
        Me.posiblesCategoriasArticulo.Add("Otros")

        'Llenamos el ArrayList de posiblesTamaniosArticulo
        Me.posiblesTamaniosArticulo.Add(80)
        Me.posiblesTamaniosArticulo.Add(90)
        Me.posiblesTamaniosArticulo.Add(105)
        Me.posiblesTamaniosArticulo.Add(135)
        Me.posiblesTamaniosArticulo.Add(150)
        Me.posiblesTamaniosArticulo.Add(160)
        Me.posiblesTamaniosArticulo.Add(180)

    End Sub

    End Sub


End Module
