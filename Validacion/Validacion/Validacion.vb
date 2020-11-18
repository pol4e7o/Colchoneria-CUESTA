Imports System.Text.RegularExpressions

Public Class Validacion

    'El proposito de esta clase es validar diferentes cadena
    'por lo tanto no contiene atributos

    'La clase maneja varias funciones con valor de retorno de tipo booleano

    'Metodo para validar cadenas con uno o mas nombres
    'comprobando si tienen solo letras, espacios en blanco y guion
    'En definitiva indica si el nombre o los nombres son validos
    Public Function validarNombres(cadena As String) As Boolean

        validarNombres = Regex.IsMatch(cadena, "^[a-zA-ZñÑíÍóÓéÉáÁúÚüÜ]+([ -][a-zA-ZñÑíÍóÓéÉáÁúÚüÜ]+)*$")

        'Se devuelve el valor de la variable que indicará 
        'si la cadena contiene solo letras y espacios en blanco
        'en caso de devolver true y sino false
        Return validarNombres

    End Function

    'Funcion que valida numeros de telefono
    Public Function validarNumeroTelefono(numero As String) As Boolean

        'El numero es valido si empieza por parentesis, "+" o numeros, si conteniene espacios en blanco
        ' entre los numeros y su numero de caracteres es mayor a 8
        validarNumeroTelefono = (Regex.IsMatch(numero, "^([(][+][0-9]+[)])([ ]?[0-9]+)+$") Or
            Regex.IsMatch(numero, "^([+]?[0-9]+)([ ]?[0-9]+)+$")) And numero.Length > 8

        Return validarNumeroTelefono

    End Function

    'Esta funcion comprueba que la cadena pasada como parametro
    'es numero mayor a 0
    Public Function numeroMayorACero(numeroCadena As String) As Boolean

        'Se guarda en la variable numero el valor de la cadena
        'Si se encuentra un caracter que no es digito
        'la funcion devuelve 0
        Dim numero As Double = Val(numeroCadena)

        'Si el numero es mayor a 0 la funcion 
        'devuelve true sino false
        If numero > 0 Then

            numeroMayorACero = True

        Else

            numeroMayorACero = False

        End If

        Return numeroMayorACero

    End Function

    'Esta funcion comprueba si la cadena pasado como parametro
    'esta compuesta de solo numeros
    Public Function esNumero(cadena As String) As Boolean

        'Se guarda en la variable numero el valor de la cadena
        'Si se encuentra un caracter que no es digito
        'la funcion devuelve 0
        Dim numero As Double = Val(cadena)

        'Si el numero es 0 se comprueba que el numero que contiene la cadena
        'tambien es 0 o sino tiene que ser diferente a 0 para que sea un numero
        'correcto porque el metodo Val devuelve 0 si encuentra un caracter
        'que no es un digito
        esNumero = (numero = 0 And Regex.IsMatch(cadena, "[0]+")) Or numero <> 0


        Return esNumero

    End Function

End Class
