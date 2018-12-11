CREATE PROC AGIDRe
AS
BEGIN
Select
LEFT(MAX(IdRecibo),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdRecibo),4)+1),4) from Recibos
end

exec AGIDR

CREATE PROC AGIDEl
AS
BEGIN
Select
LEFT(MAX(IdElectronico),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdElectronico),4)+1),4) from Electronico
end

exec AGIDEl


CREATE TABLE [dbo].[Electronico]
(
	[IdElectronico] NVARCHAR(11) NOT NULL PRIMARY KEY, 
	[IdUsuario] NVARCHAR(7) NOT NULL,
	[IdArticulo] NVARCHAR(7) NOT NULL,
	[IdEmpleado] NVARCHAR(7) NOT NULL,
	[NombreArticulo] NVARCHAR(50) NOT NULL,
	[CantidadArticulo] INT NOT NULL,
    [FechaSalida] DATE NOT NULL
)


CREATE TABLE [dbo].[Recibos]
(
	[IdRecibo] NVARCHAR(11) NOT NULL PRIMARY KEY, 
	[IdUsuario] NVARCHAR(7) NOT NULL,
	[IdArticulo] NVARCHAR(7) NOT NULL,
	[IdEmpleado] NVARCHAR(7) NOT NULL,
	[NombreArticulo] NVARCHAR(50) NOT NULL,
	[CantidadArticulo] INT NOT NULL,
    [FechaSalida] DATE NOT NULL, 
    [FechaEntrega] DATE NOT NULL, 
    [Descripcion] NVARCHAR(500) NOT NULL,
)

---LLaves foraneas
ALTER TABLE Electronico
ADD FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario);
ALTER TABLE Electronico
ADD FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado);

ALTER TABLE Electronico
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);

ALTER TABLE Recibos
ADD FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario);
ALTER TABLE Recibos
ADD FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado);

ALTER TABLE Recibos
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);