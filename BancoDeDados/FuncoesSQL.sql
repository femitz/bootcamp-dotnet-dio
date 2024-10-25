-- SELECT *
-- FROM Produtos

-- SELECT COUNT(*) QuantidadeProdutos
-- FROM Produtos

-- SELECT *
-- FROM Produtos
-- WHERE Cor = 'Branco'
-- SELECT COUNT(*) QuantidadeProdutosBrancos
-- FROM Produtos
-- WHERE Cor = 'Branco'

-- SELECT SUM(Preco) PrecoTotal
-- FROM Produtos
-- WHERE Cor = 'Branco'

-- SELECT Max(Preco) ProdutoMaisCaro
-- FROM Produtos
-- SELECT Max(Preco) ProdutoMaisCaroBranco
-- FROM Produtos
-- WHERE Cor = 'Branco'

-- SELECT Min(Preco) ProdutoMaisBarato
-- FROM Produtos
-- SELECT Min(Preco) ProdutoMaisBaratoPreto
-- FROM Produtos
-- WHERE Cor = 'Preto'

-- SELECT AVG(Preco) ValorMedioDosProdutos
-- FROM Produtos
-- SELECT AVG(Preco) ValorMedioDosProdutosBrancos
-- FROM Produtos
-- WHERE Cor = 'Branco'

-- SELECT 
--     UPPER(Nome)  + ', ' + Cor + ', ' + Tamanho
-- NomeProdutos FROM Produtos

-- 
-- ADICIONAR COLUNAS 
-- 
-- ALTER TABLE Produtos 
-- ADD DataCadastro DATETIME2

-- ADICIONANDO A DATA ATUAL.
-- UPDATE Produtos SET DataCadastro = GETDATE()
-- SELECT *
-- FROM Produtos

-- 
-- REMOVER COLUNAS 
-- 
-- ALTER TABLE Produtos
-- DROP COLUMN DataCadastro 

-- 
-- FORMATANDO DATAS 
-- 
-- SELECT
--     Nome
--     + ', Cor: ' + Cor 
--     + ' - ' + Genero NomeProdutoCompleto,
--     UPPER(Nome) Nome,
--     LOWER(Cor) Cor,
--     FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') Data
-- FROM Produtos 


-- 
-- GROUP BY
-- 
-- SELECT Tamanho, COUNT(*) Quantidade
-- FROM Produtos
-- GROUP BY Tamanho

-- SELECT Tamanho, COUNT(*) Quantidade
-- FROM Produtos
-- WHERE Tamanho <> ''
-- GROUP BY Tamanho
-- ORDER BY Quantidade DESC


-- 
-- CRIANDO TABELA DE ENDEREÇO
-- 
-- SELECT *
-- FROM Clientes

-- CREATE TABLE Enderecos
-- (
--     Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--     IdCliente INT NULL,
--     Rua VARCHAR(255) NULL,
--     Bairro VARCHAR(255) NULL,
--     Cidade VARCHAR(255) NULL,
--     Estado CHAR(2) NULL,
--     CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente) 
--     REFERENCES Clientes(Id)
-- )

-- INSERT INTO Enderecos
-- VALUES
--     (
--         4, 'Rua Teste' , 'Bairro Teste'
-- , 'Cidade Teste', 'SP')

-- SELECT *
-- FROM Enderecos
-- SELECT *
-- FROM Clientes
-- WHERE Id = 4


-- 
-- REALIZANDO O JOIN
-- 
-- SELECT *
-- FROM Clientes
--     INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
-- WHERE Clientes.Id = 4

-- SELECT
--     C.Nome,
--     C.Sobrenome,
--     C.Email,
--     E.Rua,
--     E.Bairro,
--     E.Cidade,
--     E.Estado
-- FROM Clientes C
--     INNER JOIN Enderecos E ON C.Id = E.IdCliente
-- WHERE C.Id = 4
