Prueba Técnica – Programador
Tiempo estimado de Prueba : 1hr
 
La compañía de seguros “Seguros ABC” nos ha contratado para hacerle un módulo de consulta al call center de la empresa.  
-          Algunos clientes llaman al callcenter para conocer el historial de sus pagos y esta información no se encuentra fácilmente en su sistema actual.
-          Lo único que requiere el callcenter en este momento, es tener una consulta interna en donde todo el personal pueda acceder y ver el historial de pago luego de ingresar el número de cédula del cliente.
-          A futuro se desea que esta consulta esté disponible desde su celular, de forma que puedan escribir un chat o acceder a una página web para ver esta información

  Requerimientos Técnicos
-          Crear 2 tablas relacionadas con sus respectivos contraints simulando la data de Clientes
o   Tabla Cliente
   Nombre Completo
   Cédula
   PIN

o   Tabla Pagos
   Cédula
   Fecha de pago
   Monto

-          Cargar datos para simulación
o   Juan Perez, 8-75-584, 1478
   4/4/17, 200.00
   1/5/17, 198.22
   1/6/17, 210.00

-          Crear SP
o   ConsultaPagosCliente 
   Debe devolver Nombre Completo, Fecha de Pago, Monto

-          Crear un WebService
o   Debe llamar al SP creado
o   Evidencia que el WebService está llamando al SP y retornando los valores

-          Crear una página Web Simple
o   Ingresar Cédula
o   Mostrar los pagos en pantalla, siendo consumidos desde el webservice.

