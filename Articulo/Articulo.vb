Imports Validacion.Validacion


Public Class Articulo
    'Nombre de cada artículo
    Private nombreArticulo As String
    'Descripción de cada artículo
    Private descripcionArticulo As String
    'Categoria de cada artículo
    Private categoriaArticulo As String
    'Precio del articulo en cado de no tener ningun tamaño espesificado
    Private precioArticulo As Double
    'Tamaño del artículo
    Private tamaniosArticulo As ArrayList
    'Precio del artículo
    Private preciosTamaniosArticulo As ArrayList

    'Este objeto se utiliza para validar los datos
    Private validacion As New Validacion.Validacion()

    'Posibles precios del articulo
    Public posiblesTamaniosArticulo As ArrayList
    'Posibles categorias del artículo
    Public posiblesCategoriasArticulo As ArrayList

    'Creamos un constructor para la clase artículo.
    'Este constructor crea los objetos de artículo con el ArrayList de categorias lleno de las
    'posibles categorias que todo artículo va a poder tener, ya que van a ser un listado que no va a variar.
    'Tambien se indican todos los tamaños posibles para articulo.
    'Para crear un Articulo debemos introducir el nombre y la descripción.
    Public Sub New(nombre As String, desc As String, cat As String)
        Me.nombreArticulo = nombre
        Me.descripcionArticulo = desc
        Me.categoriaArticulo = cat

        'Llenado del ArrayList posiblesCategoriasArticulo
        Me.posiblesCategoriasArticulo.Add("Base")
        Me.posiblesCategoriasArticulo.Add("Somier")
        Me.posiblesCategoriasArticulo.Add("Canape")
        Me.posiblesCategoriasArticulo.Add("Colchon")
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
        Return tamaniosArticulo
    End Function

    Function getPrecioArticulo() As ArrayList
        Return preciosTamaniosArticulo
    End Function

    'Funciones setter para modificar el valor de las variables del objeto
    'Si se ha relizado la modificacion se devuelve true sino false
    Function setNombreArticulo(nombre As String) As Boolean
        nombreArticulo = nombre

        Return setNombreArticulo
    End Function

    Function setDescripcionArticulo(descripcion As String) As Boolean
        descripcionArticulo = descripcion

        Return setDescripcionArticulo
    End Function

    Function setCategoriaArticulo(categoria As String) As Boolean
        categoriaArticulo = categoria

        Return setCategoriaArticulo
    End Function

    'El tamaño y su precio se asignan utilizando solo un metodo
    Function setTamanioPrecio(tamanio As Integer, precio As Double) As Boolean
        tamaniosArticulo.Add(tamanio)
        preciosTamaniosArticulo.Add(precio)

        Return setTamanioPrecio
    End Function

    'El tamaño y su precio se eliminan utilizando solo un metodo
    Function eliminarTamanioPrecio(posicion As Integer) As Boolean

        Return eliminarTamanioPrecio
    End Function

    'Este metodo se utiliza para crear los dos arraylist paralelos con los tamanios y precios reales
    'del articulo. Si los arraylist no tienen el mismo tamaño o alguno de los tamaños
    'no existe en la lista de tamanios predifinidos
    Function setTamaniosPrecios(tamanios As ArrayList, precios As ArrayList) As Boolean

        setTamaniosPrecios = False

        'Los dos arraylist tienen que tener el mismo numero de elementos
        If tamanios.Count = precios.Count Then

            For i = 0 To tamanios.Count

                'Cada tamanio del arraylist pasado por parametro tiene que existir dentro de los posibles tamaños
                If posiblesTamaniosArticulo.Contains(tamanios.Item(i)) Then
                    setTamaniosPrecios = True

                Else
                    setTamaniosPrecios = False
                    i = tamanios.Count
                End If

            Next i

            'Todos los precios tienen que ser mayores a 0
            If setTamaniosPrecios = True Then

                For i = 0 To precios.Count

                    If validacion.numeroMayorACero(precios.Item(i)) = False Then

                        setTamaniosPrecios = False
                        i = precios.Count

                    End If

                Next

            End If

            'Solo si los datos son correctos se pueden asignar los valores a los atributos de la clase
            If setTamaniosPrecios Then

                preciosTamaniosArticulo = precios
                tamaniosArticulo = tamanios

            End If


        End If

        Return setTamaniosPrecios
    End Function



End Class
