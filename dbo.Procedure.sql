CREATE PROC AGIDRe
AS
BEGIN
Select
LEFT(MAX(IdRecibo),3),RIGHT('000'+
convert(Varchar(7), RIGHT(MAX(IdRecibo),4)+1),4) from Recibos
end