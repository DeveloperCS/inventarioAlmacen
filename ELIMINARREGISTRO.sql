CREATE PROC   EliminarRegistro
AS
BEGIN
delete from Recibos where  FechaEntrega=DATEADD(mm, -1, getdate());
END
