Public Class Venta

    'Esta clase se utiliza para representar un articulo vendido
    'Este ariculo tiene un nombre, la cantidad vendida y el precio por cantidad
    'Tambien contiene un metodo que calcula el precio total

    'El nombre del articulo vendido
    Private nombreArticulo As String

    'La cantidad vendida de este articulo
    Private cantidad As Integer

    'El precio por unidad
    Private precioUnidad As Double

    'Constructor que recibe los datos iniciales del objeto
    Sub New(nombreArticulo As String, cantidad As Integer, precioUnidad As Double)

        Me.nombreArticulo = nombreArticulo
        Me.cantidad = cantidad
        Me.precioUnidad = precioUnidad

    End Sub

    'Constructor vacio
    Sub New()

    End Sub

    'Los getters de los atributos
    Public Function getNombreArticulo() As String
        Return Me.nombreArticulo
    End Function

    Public Function getCantidad() As Integer
        Return Me.cantidad
    End Function

    Public Function getPrecioCantidad() As Double
        Return Math.Round(Me.precioUnidad, 2)
    End Function

    'Los setters de los articulos
    Public Sub setNombreArticulo(nombre As String)
        Me.nombreArticulo = nombre
    End Sub

    Public Sub setCantidad(cantidad As Integer)
        Me.cantidad = cantidad
    End Sub

    Public Sub setPrecioCantidad(precio As Double)
        Me.precioUnidad = precio
    End Sub

    'Metodo que calcula el precio total (la cantidad por el precio por cantidad)
    'El valor devuelto tiene dos decimales
    Public Function precioTotal() As Double
        Return Math.Round((precioUnidad * cantidad), 2)
    End Function

End Class
