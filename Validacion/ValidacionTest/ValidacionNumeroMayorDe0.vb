Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

'Esta clase Test valida si el numero pasado es mayor a 0
<TestClass()> Public Class ValidacionNumeroMayorDe0


    'Estas variable booleanas se utilizaran para comprobar si el resultado
    'obtenido es el esperado (true o false)
    Private resultadoTrue As Boolean = True
    Private resultadoFalse As Boolean = False

    <TestMethod()> Public Sub TestValidarNumeroMayorDe0_V1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero mayor a 0
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero mayor a 0
        resultadoReal = validacion.numeroMayorACero("23456")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNumeroMayorDe0_V2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero mayor a 0
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero mayor a 0
        resultadoReal = validacion.numeroMayorACero("1")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNumeroMayorDe0_NV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero mayor a 0
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero que no es mayor a 0
        resultadoReal = validacion.numeroMayorACero("0")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNumeroMayorDe0_NV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero mayor a 0
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero que no es mayor a 0
        resultadoReal = validacion.numeroMayorACero("-12")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNumeroMayorDe0_NV3()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el string pasado como parametro al metodo es numero mayor a 0
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un string que no es un numero
        resultadoReal = validacion.numeroMayorACero("hola2")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

End Class