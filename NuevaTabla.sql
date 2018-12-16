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

CREATE VIEW ConsumoE
 AS SELECT IdElectronico AS [ClaveElectronico],IdUsuario AS [Clave Usuario],IdEmpleado AS [ Clave Empleado],NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad], FechaSalida AS [Fecha Salida]
 FROM Electronico

 CREATE VIEW PrestadosR
 AS SELECT IdRecibo AS [Clave Recibo],IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada], Descripcion AS [Descripcion]
 FROM Recibos

CREATE VIEW MostrarDevolucion
AS SELECT IdDevolucion AS [Clave Devolucion],IdRecibo AS [CLave Recibo],IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada], Descripcion AS [Descripcion]
 FROM Devolucion

ALTER TABLE Devolucion
ADD FOREIGN KEY (IdRecibo) REFERENCES Recibos(IdRecibo);

ALTER TABLE Devolucion
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);

ALTER TABLE Devolucion
ADD FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario);

ALTER TABLE Devolucion
ADD FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado);