 CREATE VIEW MostrarUsuario
 AS SELECT IdUsuario AS [Clave Usuario], NombreUsuario+' '+ ApellidoPaterno+' '+ApellidoMaterno AS [Nombre Usuario], Usuario AS [Usuario], 
 TipoUsuario As [Tipo Usuario], Contraseña AS[Contraseña]
 FROM Usuario

 Create trigger actualizarUsuario
on Usuario 
for insert, update
as 
select * from MostrarUsuario
go