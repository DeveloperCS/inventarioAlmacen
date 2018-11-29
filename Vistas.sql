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

  CREATE VIEW ArticulosCategoriaHL
  AS SELECT * FROM Articulos WHERE Categoria= 'Higiene y Limpieza'

  CREATE VIEW ArticulosCategoriaHO
  AS SELECT* FROM Articulo where Categoria='Herramientas y Otros'