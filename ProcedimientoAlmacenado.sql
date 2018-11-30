CREATE PROC AGIDE
AS
BEGIN
Select
LEFT(MAX(IdEmpleado),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdEmpleado),4)+1),4) from Empleados
end

exec AGIDE


CREATE PROC AGIDU
AS
BEGIN
Select
LEFT(MAX(IdUsuario),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdUsuario),4)+1),4) from Usuario
end

exec AGIDU

CREATE PROC AGIDA
AS
BEGIN
Select
LEFT(MAX(IdArticulo),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdArticulo),4)+1),4) from Articulos
end

exec AGIDE

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



 CREATE VIEW ArticulosCategoriaHL
  AS SELECT * FROM Articulos WHERE Categoria= 'Higiene y Limpieza'

  CREATE VIEW ArticulosCategoriaHO
  AS SELECT * FROM Articulos WHERE Categoria='Herramientas y Otros'