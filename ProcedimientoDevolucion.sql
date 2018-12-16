CREATE PROC AGIDD
AS
BEGIN
Select
LEFT(MAX(IdDevolucion),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdDevolucion),4)+1),4) from Devolucion
end

exec AGIDD