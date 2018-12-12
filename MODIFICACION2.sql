ALTER TABLE Electronico
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);


ALTER TABLE Recibos
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);

Create trigger actualizarArticulos
on Articulos
for insert, update
as 
select * from MostrarUsuario
go

select* from recibos