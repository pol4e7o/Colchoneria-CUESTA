Public Class Articulo
    'Nombre de cada artículo
    Private nombreArticulo As String
    'Descripción de cada artículo
    Private descripcionArticulo As String
    'Categoria de cada artículo
    Private categoriaArticulo As String
    'Tamaño del artículo
    Private tamanioArticulo As ArrayList
    'Precio del artículo
    Private precioArticulo As ArrayList
    'Posibles categorias del artículo
    Public categoriasArticulo As ArrayList

    'Creamos un constructor para la clase artículo.
    'Este constructor crea los objetos de artículo con el ArrayList de categorias lleno de las
    'posibles categorias que todo artículo va a poder tener, ya que van a ser un listado que no va a variar.
    'Para crear un Articulo debemos introducir el nombre, la descripción, la categoria, un arraylist con todos los posibles precios,
    'otro ArrayList con todos los posibles tamaños y por último el ArrayList de categorías lleno de las posibles categorías.
    Public Sub New(nombre As String, desc As String, cat As String, tamanios As ArrayList, precios As ArrayList)
        Me.nombreArticulo = nombre
        Me.descripcionArticulo = desc
        Me.categoriaArticulo = cat
        Me.tamanioArticulo = tamanios
        Me.precioArticulo = precios

        'Llenado del ArrayList categoriasArticulo
        Me.categoriasArticulo.Add("Base")
        Me.categoriasArticulo.Add("Somier")
        Me.categoriasArticulo.Add("Canape")
        Me.categoriasArticulo.Add("Colchon")

        'Llenamos el ArrayList de tamaniosArticulo
        Me.tamanioArticulo.Add(80)
        Me.tamanioArticulo.Add(90)
        Me.tamanioArticulo.Add(105)
        Me.tamanioArticulo.Add(135)
        Me.tamanioArticulo.Add(150)
        Me.tamanioArticulo.Add(160)
        Me.tamanioArticulo.Add(180)

    End Sub

    'Creamos otro constructor pero vacio, solo con la lista de posibles categorias llena
    Public Sub New()
        'Llenado del ArrayList categoriasArticulo
        Me.categoriasArticulo.Add("Base")
        Me.categoriasArticulo.Add("Somier")
        Me.categoriasArticulo.Add("Canape")
        Me.categoriasArticulo.Add("Colchon")
        Me.categoriasArticulo.Add("Otros")

        'Llenamos el ArrayList de tamaniosArticulo
        Me.tamanioArticulo.Add(80)
        Me.tamanioArticulo.Add(90)
        Me.tamanioArticulo.Add(105)
        Me.tamanioArticulo.Add(135)
        Me.tamanioArticulo.Add(150)
        Me.tamanioArticulo.Add(160)
        Me.tamanioArticulo.Add(180)
    End Sub

    'Funciones getters para obtener los valores del objeto
    Function getNombreArticulo() As String
        Return nombreArticulo
    End Function

    Function getDescripcionArticulo() As String
        Return descripcionArticulo
    End Function

    Function getCategoriaArticulo() As String
        Return categoriaArticulo
    End Function

    Function getTamanioArticulo() As ArrayList
        Return tamanioArticulo
    End Function

    Function getPrecioArticulo() As ArrayList
        Return precioArticulo
    End Function

    Function getCategoriasArticulo() As ArrayList
        Return categoriasArticulo
    End Function

    'Funciones setter para modificar el valor de las variables del objeto
    Function setNombreArticulo(nombre As String) As String
        nombreArticulo = nombre
    End Function

    Function setDescripcionArticulo(descripcion As String) As String
        descripcionArticulo = descripcion
    End Function

    Function setCategoriaArticulo(categoria As String) As String
        categoriaArticulo = categoria
    End Function

    Function setTamanioArticulo(tamanio As ArrayList) As ArrayList
        tamanioArticulo = tamanio
    End Function

    Function getPrecioArticulo(precio As ArrayList) As ArrayList
        precioArticulo = precio
    End Function

    Function setCategoriasArticulo(categorias As ArrayList) As ArrayList
        categoriasArticulo = categorias
    End Function



End Class
