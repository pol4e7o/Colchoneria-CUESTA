Module ElementosComunes

    'Se define el registro que se va a utilizar para el fichero de articulos 
    Public Structure articuloRegistroTipo

        Dim codigoArticulo As Integer
        <VBFixedString(20)> Dim nombre As String
        <VBFixedString(40)> Dim descripcion As String
        <VBFixedString(10)> Dim categoria As String
        <VBFixedArray(14)> Dim tamanios() As Integer
        <VBFixedArray(14)> Dim precios() As Double

    End Structure

    'La variable de tipo articuloRegistroTipo que se va a utilizar para manejar el fichero de articulos
    Public articuloRegistro As articuloRegistroTipo

    'Se define el registro que se va a utilizar para el fichero de empleados
    Public Structure empleadoRegistroTipo

        Dim codigoEmpleado As Integer
        <VBFixedString(25)> Dim nombre As String
        <VBFixedString(30)> Dim apellidos As String
        <VBFixedString(40)> Dim direccion As String
        <VBFixedString(5)> Dim codigoPostal As String
        <VBFixedString(20)> Dim telefono As String
        <VBFixedString(10)> Dim nombreUsuario As String
        Dim contrasenia As Integer
        Dim esAdministrador As Boolean

    End Structure

    'La variable de tipo empleadoRegistroTipo que se va a utilizar para manejar el fichero de empleados
    Public empleadoRegistro As empleadoRegistroTipo

    'Se define el registro que se va a utilizar para el fichero de ventas
    Public Structure ventasRegistroTipo

        'Primero se almacena solo la fecha para utilizarla para las busquedas
        <VBFixedString(10)> Dim fecha As String

        'Despues va a toda la informacion sobre el cierre de caja
        <VBFixedString(110)> Dim informacionVenta As String

    End Structure

    'La variable de tipo ventasRegistroTipo que se va a utilizar para manejar el fichero de ventas
    Public ventaRegistro As ventasRegistroTipo

    'Se define el registro que se va a utilizar para el fichero de errores
    Public Structure errorRegistroTipo

        'Primero se almacena solo la fecha para utilizarla para las busquedas
        <VBFixedString(10)> Dim fecha As String

        'Despues va a toda la informacion sobre el error ocurrido
        <VBFixedString(110)> Dim informacionError As String

    End Structure

    'La variable de tipo errorRegistroTipo que se va a utilizar para manejar el fichero de errores
    Public errorRegistro As errorRegistroTipo




    'Esta variable guarda la venta diaria
    'sumandose cada vez que se vende producto
    Public venta As Double

    'Indica si se ha hecho cierre de caja
    'Cuando se haga el cierre el valor de la variable pasa a 0
    'No se puede salir de la aplicacion si el valor 
    'de la variable cajaCerrada es false
    Public cajaCerrada As Boolean

    'La informacion sobre la empresa
    Public informacionEmpresa As String = "
               Colchoneria CUESTA 
             Calle Vallehermoso, 42 
                   28015 Madrid 
                                               
             Telefono: 91 593 22 15 
             Telefono: 605 68 91 66 

 http://colchoneriacuestavallehermoso.com"

    'El usuario que ha iniciado secion si hay uno
    Public usuario As GestionComercial.Empleado

    'Objeto que se va a utilizar para validar campos 
    Public validacion As New Validacion.Validacion()

    'La variable global que va a almacenar todos los empleados recogidos del fichero de empleados
    Public empleados As New List(Of GestionComercial.Empleado)

    'La variable global que va a almacenar todos los articulos recogidos del fichero de articulos
    Public articulos As New List(Of GestionComercial.Articulo)

End Module
