CREATE TABLE [dbo].[Devolucion]
(
	[IdDevolucion] NVARCHAR(11) NOT NULL PRIMARY KEY, 
	[IdRecibo] NVARCHAR(11) NOT NULL, 
	[IdUsuario] NVARCHAR(7) NOT NULL,
	[IdArticulo] NVARCHAR(7) NOT NULL,
	[IdEmpleado] NVARCHAR(7) NOT NULL,
	[NombreArticulo] NVARCHAR(50) NOT NULL,
	[CantidadArticulo] INT NOT NULL,
    [FechaSalida] DATE NOT NULL, 
    [FechaEntrega] DATE NOT NULL, 
    [Descripcion] NVARCHAR(500) NOT NULL,
)

select * from ConsumoE
CREATE VIEW ConsumoE
 AS SELECT IdUsuario AS [Clave Usuario],IdEmpleado AS [ Clave Empleado],NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad], FechaSalida AS [Fecha Salida]
 FROM Electronico

  CREATE VIEW PrestadosR
 AS SELECT IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada], Descripcion AS [Descripcion]
 FROM Recibos

 ALTER TABLE Devolucion
ADD FOREIGN KEY (IdRecibo) REFERENCES Recibos(IdRecibo);