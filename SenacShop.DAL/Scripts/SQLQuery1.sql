/* 
SQL - Structured Query Language
DDL - Definition Data Language
DML - Data Manipulation Language
*/

-- Criando o Banco de Dados
CREATE DATABASE SenacShop
GO
-- Selecionando o banco criado para uso
USE SenacShop
GO

-- Criar a Tabela
CREATE TABLE Categoria
(
   idCategoria INT PRIMARY KEY IDENTITY,
   nome varchar(20) NOT NULL
)
GO

CREATE TABLE Produto
(
	idProduto INT PRIMARY KEY IDENTITY,
	nome varchar(50) NOT NULL,
	descricao varchar(1000),
	preco decimal(10,2) NOT NULL,
	estoque INT NOT NULL,
	idCategoria INT FOREIGN KEY REFERENCES Categoria(idCategoria)
)
GO

-- INSERE DADOS NA TABELA
INSERT Categoria (nome) VALUES ('Eletrônicos')
INSERT Categoria (nome) VALUES ('Livros')
INSERT Categoria (nome) VALUES ('SmartPhones')
INSERT Categoria (nome) VALUES ('Games')
INSERT Categoria (nome) VALUES ('Vestuario')

--SELECIONANDO DADOS DA TABELA
SELECT * FROM Categoria

--DELETANDO DADOS DA TABELA
DELETE FROM Categoria WHERE idCategoria >= 5

--ATUALIZANDO DADOS DA TABELA
UPDATE Categoria SET nome = 'Celulares' WHERE idCategoria = 3