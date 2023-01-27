USE ExemploDB;

ALTER TABLE Produtos
ADD CONSTRAINT CHK_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F')