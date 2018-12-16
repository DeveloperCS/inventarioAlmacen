CREATE VIEW MostrarUsuario
 AS SELECT IdUsuario AS [Clave Usuario], NombreUsuario+' '+ApellidoPaterno+' '+ApellidoMaterno AS [Nombre],Usuario AS [Usuario], TipoUsuario AS [Tipo],  Contraseña AS [Contraseña]
 FROM Usuario

 Select * from usuario
