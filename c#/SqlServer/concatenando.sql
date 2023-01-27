USE ExemploDB;

SELECT
    Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProdutoCompleto,
    UPPER(Nome),
    LOWER(Cor),
    FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM Produtos