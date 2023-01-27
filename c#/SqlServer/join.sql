USE ExemploDB;

SELECT
    C.Nome,
    C.Sobrenome,
    C.Email,
    E.Rua,
    E.Bairro,
    E.Cidade,
    E.Estado
FROM 
    Clientes C
INNER JOIN Enderecos E ON C.Id = E.IdCliente
WHERE C.Id = 4