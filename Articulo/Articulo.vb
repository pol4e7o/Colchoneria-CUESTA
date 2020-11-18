Public Class Articulo
    'Variables de cada atributo
    Private nombreArticulo As String
    Private descripcionArticulo As String
    Private categoriaArticulo As String
    Private tamanioArticulo As ArrayList
    Private precioArticulo As ArrayList
    Private categoriasArticulo As ArrayList

    'Funciones getters para obtener los valores del objeto
    Function getnombreArticulo() As String
        Return nombreArticulo
    End Function

    Function getdescripcionArticulo() As String
        Return descripcionArticulo
    End Function

    Function getcategoriaArticulo() As String
        Return categoriaArticulo
    End Function

    Function gettamanioArticulo() As ArrayList
        Return tamanioArticulo
    End Function

    Function getprecioArticulo() As ArrayList
        Return precioArticulo
    End Function

    Function getcategoriasArticulo() As ArrayList
        Return categoriasArticulo
    End Function

    'Funciones setter para modificar el valor de las variables del objeto
    Function setnombreArticulo(nombre As String) As String
        nombreArticulo = nombre
    End Function

    Function setdescripcionArticulo(descripcion As String) As String
        descripcionArticulo = descripcion
    End Function

    Function setcategoriaArticulo(categoria As String) As String
        categoriaArticulo = categoria
    End Function

    Function settamanioArticulo(tamanio As ArrayList) As ArrayList
        tamanioArticulo = tamanio
    End Function

    Function getprecioArticulo(precio As ArrayList) As ArrayList
        precioArticulo = precio
    End Function

    Function setcategoriasArticulo(categorias As ArrayList) As ArrayList
        categoriasArticulo = categorias
    End Function



End Class
