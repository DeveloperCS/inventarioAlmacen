Create trigger Actualizar
on Articulos
for insert, update
as 
select * from inventarioArticulo
go