CREATE VIEW ConsumoE
 AS SELECT IdUsuario,IdEmpleado,NombreArticulo, FechaSalida
 FROM Electronico

 CREATE VIEW PrestadosR
 AS SELECT IdUsuario,IdEmpleado,NombreArticulo,FechaSalida, FechaEntrega
 FROM Recibos

 CREATE VIEW SinArticulos
 AS SELECT IdArticulo, NombreArticulo, categoria
 FROM Articulos
 WHERE CantidadAlmacen = 0