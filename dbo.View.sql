CREATE VIEW PrestadosR
 AS SELECT IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada]
 FROM Recibos
