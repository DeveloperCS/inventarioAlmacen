CREATE PROC InsertRecibo
@IdRecibo varchar (7), @IdUsuario varchar (7), 
@IdArticulo varchar (7),@IdEmpleado nvarchar (7), @NombreArticulo nvarchar (50),
@FechaSalida date, @FechaEntrega date, @Descripcion nVarchar(500)
as 
begin
insert into Recibos values (@IdRecibo, @IdUsuario, 
@IdArticulo, @NombreArticulo,
@FechaSalida, @FechaEntrega, @Descripcion,
@IdEmpleado)
end
go

CREATE PROC InsertElectronico
@IdElectronico varchar (7), @IdUsuario varchar (7), 
@IdArticulo varchar (7), @idEmpleado Varchar(7), @NombreArticulo nvarchar (250),
@CantidadArticulo int, @FechaSalida date
as 
begin
insert into Electronico values (@IdElectronico, @IdUsuario, @IdArticulo, @idEmpleado, @NombreArticulo, @CantidadArticulo, @FechaSalida)
end
go
