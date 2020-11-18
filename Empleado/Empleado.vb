Public Class Empleado
    Private nombreEmpleado As String
    Private contraseniaEmpleado As Single
    Private administradorEmpleado As Boolean


    'Funciones getters para obtener los valores del objeto
    Function getnombreEmpleado() As String
        Return nombreEmpleado
    End Function

    Function getcontraseniaEmpleado() As String
        Return contraseniaEmpleado
    End Function

    Function getadministradorEmpleado() As String
        Return administradorEmpleado
    End Function



    'Funciones setter para modificar el valor de las variables del objeto
    Function setnombreEmpleadoo(nombre As String) As String
        nombreEmpleado = nombre
    End Function

    Function setcontraseniaEmpleado(contrasenia As Single) As String
        contraseniaEmpleado = contrasenia
    End Function

    Function setadministradorEmpleado(admin As Boolean) As Boolean
        administradorEmpleado = admin
    End Function


    'Una posibilidad de optimizar el codigo
    'Public Property nombreEmpleado As String
    '    Get
    '        Return nombreEmpleado
    '    End Get
    '    Set(ByVal value As String)
    '        nombreEmpleado = value
    '    End Set
    'End Property

    'Public Property contraseniaEmpleado As Integer
    '    Get
    '        Return contraseniaEmpleado
    '    End Get
    '    Set(ByVal value As Integer)
    '        contraseniaEmpleado = value
    '    End Set
    'End Property

    'Public Property administradorEmpleado As Integer
    '    Get
    '        Return administradorEmpleado
    '    End Get
    '    Set(ByVal value As Integer)
    '        administradorEmpleado = value
    '    End Set
    'End Property
End Class
