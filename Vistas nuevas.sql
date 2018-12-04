﻿CREATE VIEW ArticulosCategoriaHL
  AS SELECT IdArticulo as [Folio], NombreArticulo as [Articulo], Categoria AS [Categoria], CantidadInicial AS [Stock Inicial],
   CantidadAlmacen AS [Stock Disponible], TipoMedida AS [Medida]
   FROM Articulos WHERE Categoria= 'Higiene y Limpieza';

  CREATE VIEW ArticulosCategoriaHO
  AS SELECT IdArticulo as [Folio], NombreArticulo as [Articulo], Categoria AS [Categoria], CantidadInicial AS [Stock Inicial],
   CantidadAlmacen AS [Stock Disponible], TipoMedida AS [Medida], Estado [Estado]
   FROM Articulos where Categoria='Herramientas y Otros'

   CREATE VIEW [dbo].[InventarioArticulo]
	AS SELECT IdArticulo as [Folio], NombreArticulo as [Articulo], Categoria AS [Categoria], CantidadInicial AS [Stock Inicial],
   CantidadAlmacen AS [Stock Disponible], TipoMedida AS [Medida], Estado [Estado]
   FROM [Articulos]

 CREATE VIEW ConsumoE
 AS SELECT IdUsuario AS [Clave Usuario],IdEmpleado AS [ Clave Empleado],NombreArticulo AS [Articulo], FechaSalida AS [Fecha Salida]
 FROM Electronico

 CREATE VIEW PrestadosR
 AS SELECT IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado],NombreArticulo AS [Articulo],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada]
 FROM Recibos


 CREATE VIEW SinArticulos
 AS SELECT IdArticulo AS [Clave Articulo], NombreArticulo AS [Articulo], Categoria [Categoria]
 FROM Articulos
 WHERE CantidadAlmacen = 0

