Module ElementosComunes

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

    'Indica si el usuario que se ha entrado en la TPV tiene derechos de administrador
    Public administrador As Boolean = False

End Module
