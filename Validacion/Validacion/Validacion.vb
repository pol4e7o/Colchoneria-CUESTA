
Public Class Validacion

    'El proposito de esta clase es validar diferentes cadena
    'por lo tanto contiene solo constantes

    'La clase maneja varias funciones con valor de retorno de tipo booleano

    'Esta constante indica las letras permitidas o no en una cadena
    Public Const LETRAS As String = "qwertyuioplkjhgfdsazxcvbnméúíóáñ"

    'Constructor vacio
    Public Sub New()

    End Sub

    'Metodo para validar cadenas comprobando si tienen solo letras y espacios en blanco
    Public Function contieneLetrasYEspaciosEnBlanco(cadena As String) As Boolean

        'Las variables contadoras que van a utilizar los dos for
        Dim i As Integer
        Dim j As Integer

        'La cadena se pasa a letras minusculas
        'De esta manera no hace falta tener guardadas 
        'las letras en mayuscula para la comprobacion
        cadena = cadena.ToLower()


        'Mediante este for se pasa por todos los caracteres de la cadena uno por uno
        For i = 0 To (cadena.Length - 1)

            'Si el caracter es espacio en blanco se le asigna a la 
            'variable contieneLetrasYEspaciosEnBlanco el valor true
            If cadena.Chars(i).Equals(" ") Then
                contieneLetrasYEspaciosEnBlanco = True

            Else

                'De lo contrario se le asigna false y se comprueba 
                'si coincide con alguna de las letras permitidas.

                'Si coincide el valor de la variable contieneLetrasYEspaciosEnBlanco
                'se cambia a true.

                'Sino el valor se quedara false
                contieneLetrasYEspaciosEnBlanco = False

                'Se pasa por todas las letras de la constante LETRAS
                For j = 0 To (LETRAS.Length - 1)

                    If cadena.Chars(i).Equals(LETRAS.Chars(j)) Then

                        contieneLetrasYEspaciosEnBlanco = True

                    End If

                Next j

                'Si el valor de contieneLetrasYEspaciosEnBlanco es false 
                'despues de comparar el caracter con la cadena LETRAS
                'Se sale del bucle for
                If contieneLetrasYEspaciosEnBlanco = False Then

                    i = cadena.Length

                End If

            End If

        Next i

        'Se devuelve el valor de la variable que indicará 
        'si la cadena contiene solo letras y espacios en blanco
        'en caso de devolver true y sino false
        Return contieneLetrasYEspaciosEnBlanco

    End Function

    'Funcion que valida numeros de telefono
    Public Function validarNumeroTelefono(numero As String) As Boolean

        'Variable contador para el for
        Dim i As Integer

        'Si el primer caracter es un parentesis abierto se le 
        'asigna a la variable parentesisAbierto true
        Dim parentesisAbierto As Boolean = False

        'Si el caracter es un parentesis cerrado y 
        'la variable parentesisAbierto es igual a true
        'se le asigna a la variable parentesisCerrado true
        Dim parentesisCerrado As Boolean = False


        For i = 0 To (numero.Length - 1)

            'Cada vez que se ejecuta el bucle for se le asigna a la variable
            'validarNumeroTelefono false. Si despues de pasar por todas las comprobaciones
            'su valor sigue false se sale del bucle y se devuelve este valor
            validarNumeroTelefono = False

            'Comprueba si el caracter es numerico
            If IsNumeric(numero.Chars(i)) Then

                validarNumeroTelefono = True

            End If

            'Comprueba si el caracter es el primero y es un + o
            'si el parentesis ha sido abierto y no cerrado y encuentra el +
            If (i = 0 Or (parentesisAbierto And parentesisCerrado = False)) And numero.Chars(i).Equals("+") Then

                validarNumeroTelefono = True

            End If

            'Comprueba si el caracter no es ni el primero
            'ni el ultimo y es un espacio en blanco
            If i <> 0 And i <> numero.Length - 1 And numero.Chars(i).Equals(" ") Then

                validarNumeroTelefono = True

            End If

            'Comprueba si es el primer elemento de la cadena
            'y es un parentesis abierto
            If i = 0 And numero.Chars(i).Equals("(") Then

                parentesisAbierto = True

            End If

            'Comprueba si el caracter es parentesis cerrado y hay ya un parentesis abierto
            If numero.Chars(i).Equals(")") And parentesisAbierto Then

                parentesisCerrado = True

            End If

            'Si despues de las validacion el valor de validarNumeroTelefono
            'sigue siendo false y no hay ningun parentesis abierto
            'se sale del bucle indicando que el numero de telefono no es 
            'correcto mediante el valor false
            If validarNumeroTelefono = False Or parentesisCerrado = False Then

                i = numero.Length

            End If

        Next i

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

        'La variable contador del for
        Dim i As Integer

        'Se pasa mediante el for por todos los caracteres de la cadena
        For i = 0 To (cadena.Length - 1)

            'Si el caracter es un numero
            'se el asigna a la variable esNumero true
            If IsNumeric(cadena.Chars(i)) Then

                esNumero = True

            Else
                'Sino se le asigna false
                esNumero = False

                'Se sale del bucle pasandole un valor a la variable i
                'que esta fuera del rango de la condicion del for
                i = cadena.Length

            End If

        Next i

        Return esNumero

    End Function

End Class
