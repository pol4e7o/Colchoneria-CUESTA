Public Class Empleado

    'Codigo del empleado
    Private codigoEmpleado As Integer

    'Nombre del empleado
    Private nombreEmpleado As String

    'Apellidos del empleado
    Private apellidos As String

    'La direccion del empleado
    Private direccionEmpleado As String

    'El codigo postal de esta direccion
    Private codigoPostalDireccion As String

    'El numero de telefono del empleado
    Private telefono As String

    'El nombre de usuario del empleado para inciar secion en la TPV
    Private nombreUsuario As String

    'La contraseña que este empleado va a utilizar para manejar la TPV
    Private contraseniaEmpleado As Integer

    'Esta variable indica si el empleado tiene permisos de administrador
    Private esAdministrador As Boolean

    'Creamos un constructor vacio
    Public Sub New()

    End Sub

    'Creamos un constructor para poder instanciar la clase Empleado con los datos deseados
    Public Sub New(codigo As Integer, nombre As String, apellidos As String, direccion As String, codigoPostal As String,
                                telefono As String, nombreUsuario As String, contrasenia As Integer, esAdmin As Boolean)
        Me.codigoEmpleado = codigo
        Me.nombreEmpleado = nombre
        Me.apellidos = apellidos
        Me.direccionEmpleado = direccion
        Me.codigoPostalDireccion = codigoPostal
        Me.telefono = telefono
        Me.nombreUsuario = nombreUsuario
        Me.contraseniaEmpleado = contrasenia
        Me.esAdministrador = esAdmin

    End Sub


    'Funciones getters para obtener los valores del objeto
    Function getCodigoEmpleado() As String
        Return codigoEmpleado
    End Function

    Function getNombreEmpleado() As String
        Return nombreEmpleado
    End Function

    Function getApellidos() As String
        Return apellidos
    End Function

    Function getDireccion() As String
        Return direccionEmpleado
    End Function

    Function getCodigoPostal() As Integer
        Return codigoPostalDireccion
    End Function

    Function getTelefono() As String
        Return telefono
    End Function

    Function getNombreUsuario() As String
        Return nombreUsuario
    End Function

    Function getContraseniaEmpleado() As Integer
        Return contraseniaEmpleado
    End Function

    Function getEsAdministrador() As Boolean
        Return esAdministrador
    End Function

    'Procedimientos setter para modificar el valor de las variables del objeto
    'Se utiliza Me en casos donde el parametro y el atributo 
    'tienen el mismo nombre. La varible con Me. adelante es atributo de la clase
    Sub setCodigoEmpleado(codigoEmpleado As Integer)
        Me.codigoEmpleado = codigoEmpleado
    End Sub

    Sub setNombreEmpleado(nombre As String)
        nombreEmpleado = nombre
    End Sub

    Sub setApellidos(apellidos As String)
        Me.apellidos = apellidos
    End Sub

    Sub setDireccion(direccion As String)
        direccionEmpleado = direccion
    End Sub

    Sub setCodigoPostal(codigoPostal As Integer)
        codigoPostalDireccion = codigoPostal
    End Sub

    Sub setTelefono(numeroTelefono As String)
        telefono = numeroTelefono
    End Sub

    Sub setNombreUsuario(nombreUsuario As String)
        Me.nombreUsuario = nombreUsuario
    End Sub

    Sub setContraseniaEmpleado(contrasenia As Integer)
        contraseniaEmpleado = contrasenia
    End Sub

    Sub setEsAdministrador(admin As Boolean)
        esAdministrador = admin
    End Sub

End Class
