CREATE TABLE [dbo].[Articulos]
(
	[IdArticulo] NVARCHAR(7) NOT NULL PRIMARY KEY, 
    [NombreArticulo] NVARCHAR(50) NOT NULL, 
    [Categoria] NVARCHAR(25) NOT NULL, 
    [CantidadInicial] FLOAT NOT NULL, 
    [CantidadAlmacen] FLOAT NOT NULL, 
    [TipoMedida] nVarchar (6) NOT NULL, 
    [Estado] nVarchar (25) NOT NULL
)
