CREATE PROC AGIDD
AS
BEGIN
Select
LEFT(MAX(IdDevolucion),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdDevolucion),4)+1),4) from Devolucion
end

exec AGIDD
select * from MostrarDevolucion
CREATE VIEW MostrarDevolucion
AS SELECT IdDevolucion AS [Clave Devolucion],IdRecibo AS [CLave Recibo],IdUsuario AS [Clave Usuario],IdEmpleado AS [CLave Empleado],IdArticulo AS [Folio], NombreArticulo AS [Articulo],CantidadArticulo AS [Cantidad],FechaSalida AS [Fecha Salida], 
 FechaEntrega AS [Fecha Entrada], Descripcion AS [Descripcion]
 FROM Devolucion