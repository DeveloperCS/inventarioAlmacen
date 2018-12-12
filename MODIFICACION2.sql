ALTER TABLE Electronico
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);


ALTER TABLE Recibos
ADD FOREIGN KEY (IdArticulo) REFERENCES Articulos(IdArticulo);
