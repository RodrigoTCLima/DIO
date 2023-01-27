USE ExemploDB;

-- CREATE PROCEDURE InserirNovoProduto
-- @Nome varchar(255), 
-- @Cor varchar(50),
-- @Preco decimal,
-- @Tamanho varchar(5),
-- @Genero char(1)

-- AS INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
-- VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)

-- EXEC InserirNovoProduto 
-- 'NOVO PRODUTO PROCEDURE',
-- 'COLORIDO',
-- 50,
-- 'G',
-- 'U'
-- ----------

-- CREATE PROCEDURE ObterProdutosPorTamanho
-- @TamanhoProduto VARCHAR(5)
-- AS 
-- SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto

-- EXEC ObterProdutosPorTamanho 'P'
--  ------------


-- CREATE PROCEDURE ObterTodosProdutos
-- AS
-- SELECT * FROM Produtos

EXEC ObterTodosProdutos