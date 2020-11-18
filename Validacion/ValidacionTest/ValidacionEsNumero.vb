Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

'Esta clase test valida un numero
<TestClass()> Public Class ValidacionEsNumero

    'Estas variable booleanas se utilizaran para comprobar si el resultado
    'obtenido es el esperado (true o false)
    Private resultadoTrue As Boolean = True
    Private resultadoFalse As Boolean = False

    <TestMethod()> Public Sub TestValidarNumeroV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero
        resultadoReal = validacion.esNumero("123123456")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNumeroV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero
        resultadoReal = validacion.esNumero("-23")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub


    <TestMethod()> Public Sub TestValidarNumeroNV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo una cadena que no es solo numeros
        resultadoReal = validacion.esNumero("-p23")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNumeroNV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo una cadena que no es solo numeros
        resultadoReal = validacion.esNumero("123?12")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

End Class