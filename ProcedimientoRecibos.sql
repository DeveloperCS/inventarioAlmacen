 CREATE PROC AGIDRe
AS
BEGIN
Select
LEFT(MAX(IdRecibo),6+1),
RIGHT('/'+
convert(Varchar(11), RIGHT(MAX(IdRecibo),4)+1),4) from Recibos
END

CREATE PROC Contador
as
begin
select count (IdRecibo) from Recibos
end