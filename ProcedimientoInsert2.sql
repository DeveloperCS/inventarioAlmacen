CREATE PROC InsertRecibo
@IdRecibo varchar (11), @IdUsuario varchar (7), 
@IdArticulo varchar (7),@IdEmpleado nvarchar (7), @NombreArticulo nvarchar (50),
@FechaSalida date, @FechaEntrega date, @Descripcion nVarchar(500)
as 
begin
insert into Recibos values (@IdRecibo, @IdUsuario, 
@IdArticulo, @NombreArticulo,@FechaSalida, @FechaEntrega, @Descripcion,@IdEmpleado)
end
go

CREATE PROC InsertElectronico
@IdElectronico varchar (11), @IdUsuario varchar (7), 
@IdArticulo varchar (7), @idEmpleado Varchar(7), @NombreArticulo nvarchar (250),
@CantidadArticulo int, @FechaSalida date
as 
begin
insert into Electronico values (@IdElectronico, @IdUsuario, @IdArticulo, @idEmpleado, @NombreArticulo, @CantidadArticulo, @FechaSalida)
end
go


CREATE PROC InsertArticulos
@IdArticulo varchar (7), @NombreArticulo nvarchar (250),@Categoria nVarchar (25), @CantidadInicial float,
@CantidadAlmacen float, @TipoMedida nVarchar(6), @Estado nVarchar (25)
as 
begin
insert into Articulos values (@IdArticulo, @NombreArticulo,@Categoria, @CantidadInicial, @CantidadAlmacen, @TipoMedida, @Estado)
end
go


CREATE PROC InsertarEmpleados
  @IdEmpleado nVarchar(7),@NombreEmpleado nvarchar(20), @ApellidoPaterno nVarchar(20),@ApellidosMaterno nVarchar(20), @ClaveEmpleado nVarchar(4),@Puesto nVarchar(50) 
as 
begin
insert into Empleados values (@IdEmpleado,@NombreEmpleado, @ApellidoPaterno,@ApellidosMaterno, @ClaveEmpleado,@Puesto)
end
go


CREATE PROC InsertarUsuario
  @IdUsuario nVarchar(7), @NombreUsuario nvarchar(30), @ApellidoPaterno nVarchar(20),@ApellidosMaterno nVarchar(20), @Usuario nVarchar(50),@TipoUsuario nVarchar(50), @Contrseña nVarchar(15)
as 
begin
insert into Usuario values (@IdUsuario,@NombreUsuario, @ApellidoPaterno,@ApellidosMaterno, @Usuario,@TipoUsuario, @Contrseña)
end
go