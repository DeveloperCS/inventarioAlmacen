CREATE PROC AGIDD
AS
BEGIN
Select
LEFT(MAX(IdDevolucion),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdDevolucion),4)+1),4) from Devolucion
end


select * from MostrarDevolucion
CREATE VIEW MostrarDevolucion
AS SELECT IdDevolucion AS [Clave Devolucion],IdRecibo AS [CLave Recibo],IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado],IdArticulo AS [Folio], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada], Descripcion AS [Descripcion]
 FROM Devolucion

 exec AGIDU


 CREATE PROC AGIDRec
AS
BEGIN
Select
LEFT(MAX(IdRecibo),6+1),
RIGHT('/'+
convert(Varchar(11), RIGHT(MAX(IdRecibo),4)+1),4) from Recibos
END

CREATE VIEW PrestadosR
 AS SELECT IdRecibo AS [Clave Recibo],IdUsuario AS [Clave Usuario],IdArticulo AS [Folio],IdEmpleado AS [CLave Empleado], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada], Descripcion AS [Descripcion]
 FROM Recibos

select * from PrestadosR