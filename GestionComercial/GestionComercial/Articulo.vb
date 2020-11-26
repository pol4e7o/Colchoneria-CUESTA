
Public Class Articulo

    'Codigo del articulo
    Private codigoArticulo As Integer
    'Nombre de cada artículo
    Private nombreArticulo As String
    'Descripción de cada artículo
    Private descripcionArticulo As String
    'Categoria de cada artículo
    Private categoriaArticulo As String
    'Tamaño del artículo
    Private tamaniosArticulo As New List(Of Integer)
    'Precio del artículo
    Private preciosTamaniosArticulo As New List(Of Double)

    'Posibles precios del articulo
    Public posiblesTamaniosArticulo As New ArrayList()
    'Posibles categorias del artículo
    Public posiblesCategoriasArticulo As New ArrayList()

    'Creamos un constructor para la clase artículo.
    'Este constructor crea los objetos de artículo con el ArrayList de categorias lleno de las
    'posibles categorias que todo artículo va a poder tener, ya que van a ser un listado que no va a variar.
    'Tambien se indican todos los tamaños posibles para articulo.
    'Para crear un Articulo debemos introducir el nombre y la descripción.
    Public Sub New(codigo As Integer, nombre As String, desc As String, cat As String)

        Me.codigoArticulo = codigo
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

    'Creamos otro constructor pero vacio, solo con la lista de posibles categorias llena
    Public Sub New()

        'Llenado del ArrayList posiblesCategoriasArticulo
        Me.posiblesCategoriasArticulo.Add("Base")
        Me.posiblesCategoriasArticulo.Add("Somier")
        Me.posiblesCategoriasArticulo.Add("Canape")
        Me.posiblesCategoriasArticulo.Add("Colchon")
        Me.posiblesCategoriasArticulo.Add("Oferta")
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

    'Funciones getters para obtener los valores del objeto
    Function getCodigoArticulo() As String
        Return codigoArticulo
    End Function

    Function getNombreArticulo() As String
        Return nombreArticulo
    End Function

    Function getDescripcionArticulo() As String
        Return descripcionArticulo
    End Function

    Function getCategoriaArticulo() As String
        Return categoriaArticulo
    End Function

    Function getPreciosTamaniosArticulo() As List(Of Double)
        Return preciosTamaniosArticulo
    End Function

    Function getTamaniosArticulo() As List(Of Integer)
        Return tamaniosArticulo
    End Function

    'Funciones setter para modificar el valor de las variables del objeto
    'Si se ha relizado la modificacion se devuelve true sino false
    Sub setCodigoArticulo(codigo As Integer)
        Me.codigoArticulo = codigo
    End Sub

    Sub setNombreArticulo(nombre As String)
        nombreArticulo = nombre
    End Sub

    Sub setDescripcionArticulo(descripcion As String)
        descripcionArticulo = descripcion
    End Sub

    Sub setCategoriaArticulo(categoria As String)
        categoriaArticulo = categoria
    End Sub

    'El tamaño y su precio se asignan utilizando solo un metodo
    Sub setTamanioPrecio(tamanio As Integer, precio As Double)
        tamaniosArticulo.Add(tamanio)
        preciosTamaniosArticulo.Add(Math.Round(precio, 2))

    End Sub

    'El tamaño y su precio se eliminan utilizando solo un metodo
    Sub eliminarTamanioPrecio(posicion As Integer)
        tamaniosArticulo.RemoveAt(posicion)
        preciosTamaniosArticulo.RemoveAt(posicion)

    End Sub

    'Este metodo se utiliza para crear los dos arraylist paralelos con los tamanios y precios reales
    'del articulo. Si los arraylist no tienen el mismo tamaño no se asignan
    Function setTamaniosPrecios(tamanios As List(Of Integer), precios As List(Of Double)) As Boolean

        'El contador que utiliza el for
        Dim i As Integer

        setTamaniosPrecios = False

        'Los dos arraylist tienen que tener el mismo numero de elementos
        If tamanios.Count = precios.Count Then

            'Se pasa por todos los elementos del parametro arraylist de precios
            'convertiendole en un numero de tipo double con dos decimales
            For i = 0 To precios.Count - 1
                precios.Item(i) = Math.Round(precios.Item(i), 2)
            Next i

            preciosTamaniosArticulo = precios
            tamaniosArticulo = tamanios

            'Se le pasa a la variable setTamaniosPrecios el valor true
            'indicando que se ha realizado la asignacion con exito
            setTamaniosPrecios = True

        End If

        Return setTamaniosPrecios
    End Function



End Class
