Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Validacion.Validacion

'Clase Test que valida un nombre
<TestClass()> Public Class ValidacionNombre

    'Estas variable booleanas se utilizaran para comprobar si el resultado
    'obtenido es el esperado (true o false)
    Private resultadoTrue As Boolean = True
    Private resultadoFalse As Boolean = False

    <TestMethod()> Public Sub TestValidarNombreV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar si el nombre es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un nombre correcto
        resultadoReal = validacion.validarNombres("Anna Martinez")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNombreV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar si el nombre es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un nombre correcto
        resultadoReal = validacion.validarNombres("Anna-Muñoz")

        'Se comprueban el resultado esperado (true) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoTrue, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNombreNV1()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar si el nombre es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un nombre incorrecto
        resultadoReal = validacion.validarNombres("Anna Martinez ")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNombreNV2()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar si el nombre es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un nombre incorrecto
        resultadoReal = validacion.validarNombres(" Anna Martinez")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNombreNV3()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar si el nombre es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un nombre incorrecto
        resultadoReal = validacion.validarNombres("Anna_Martinez")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

    <TestMethod()> Public Sub TestValidarNombreNV4()

        'La variable que alamacenaré el resultado real 
        Dim resultadoReal As Boolean

        'Se utiliza la clase validacion para comprobar si el nombre es correcto o no
        Dim validacion As New Validacion.Validacion()

        'Se comprueba pasandole al metodo un nombre incorrecto
        resultadoReal = validacion.validarNombres("Anna4 Martinez")

        'Se comprueban el resultado esperado (false) con el resultado real
        'Si el metodo funciona correctamente el test se ejecutará sin errores
        Assert.AreEqual(resultadoFalse, resultadoReal)

    End Sub

End Class