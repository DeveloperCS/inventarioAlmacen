select * from Usuario


Select  * from information_schema.columns WHERE TABLE_NAME='Recibos'




ALTER TABLE Electronico
DROP CONSTRAINT PK__Electron__CD86368607C32166;

ALTER TABLE Electronico
ALTER COLUMN IdElectronico nvarchar(11) not null

ALTER TABLE Electronico
ADD PRIMARY KEY (IdElectronico)