Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

'Clase Test que valida un telefono
<TestClass()> Public Class ValidacionTelefono

    'Estas variable booleanas se utilizaran para comprobar si el resultado
    'obtenido es el esperado (true o false)
    Private resultadoTrue As Boolean = True
    Private resultadoFalse As Boolean = False

    <TestMethod()> Public Sub TestValidarTelefonoV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono correcto
        resultadoReal = validacion.validarNumeroTelefono("123123456")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono correcto
        resultadoReal = validacion.validarNumeroTelefono("123 123 456")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoV3()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono correcto
        resultadoReal = validacion.validarNumeroTelefono("(+123) 123 123 456")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoV4()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono correcto
        resultadoReal = validacion.validarNumeroTelefono("+34 123 123 456")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoNV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono incorrecto
        resultadoReal = validacion.validarNumeroTelefono("p123 123 456")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoNV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono incorrecto
        resultadoReal = validacion.validarNumeroTelefono(" 123 123 456")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoNV3()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono incorrecto
        resultadoReal = validacion.validarNumeroTelefono("123 123 (456)")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoNV4()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono incorrecto
        resultadoReal = validacion.validarNumeroTelefono("21231234")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarTelefonoNV5()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar 
        'si el numero de telefono es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un numero de telefono incorrecto
        resultadoReal = validacion.validarNumeroTelefono("(123 123 456")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub


End Class