--Exercicio 1

Use BD044987
go

--CREATE SCHEMA Robinho
--go
CREATE TABLE Robinho.Endereco(
	EnderecoId int primary key IDENTITY(1,1),
	CEP int,
	Estado varchar(100),
	Cidade varchar(100)
)
CREATE TABLE Robinho.Pessoa(
	PessoaId int primary key IDENTITY(1,1),
	Nome varchar(200),
	Endereco varchar(500),
	CPF char(11),
	EnderecoId int,
	FOREIGN KEY (EnderecoId) REFERENCES Robinho.Endereco(EnderecoId)
)
CREATE TABLE Robinho.Equino(
	EquinoId int primary key IDENTITY(1,1),
	Raca varchar(50),
	Nome varchar(200),
	DataNascimento date
)
CREATE TABLE Robinho.Proprietario(
	PessoaId int,
	EquinoId int,
	PRIMARY KEY (PessoaId,EquinoId),
	FOREIGN KEY (PessoaId) REFERENCES Robinho.Pessoa(PessoaId),
	FOREIGN KEY (EquinoId) REFERENCES Robinho.Equino(EquinoId)
)

--DROP TABLE Robinho.Pessoa
--DROP TABLE Robinho.Equino
--DROP TABLE Robinho.Proprietario
--DROP TABLE Robinho.Endereco

--Ativ 2

ALTER TABLE Robinho.Equino
	ADD Sexo char CHECK(Sexo like 'M' or Sexo like 'F')
go
Update Robinho.Equino 
	SET Sexo = 'F'
go

--Ativ 3

ALTER TABLE Robinho.Equino
	ADD CriadoEm date, AtualizadoEm date
ALTER TABLE Robinho.Pessoa
	ADD CriadoEm date, AtualizadoEm date
ALTER TABLE Robinho.Proprietario
	ADD CriadoEm date, AtualizadoEm date
go

Update Robinho.Equino 
	SET CriadoEm  = GETDATE(), AtualizadoEm = GETDATE()
Update Robinho.Pessoa 
	SET CriadoEm  = GETDATE(), AtualizadoEm = GETDATE()
Update Robinho.Proprietario 
	SET CriadoEm  = GETDATE(), AtualizadoEm = GETDATE()
go

--ativ 4
Begin tran
DECLARE @i int = 0;
DECLARE @s char(2) = 'MF';
WHILE @i < 10
BEGIN
	INSERT INTO Robinho.Equino(Raca, Nome, Sexo, DataNascimento)
		Values(
			'Raca' + CAST(@i+1 as CHAR(2)),
			'Nome' + CAST(@i+1 as CHAR(2)),
			SUBSTRING(@s,(CASE WHEN @i % 2 = 0 THEN 1 ELSE 2 END),1),
			GETDATE() 
		)
SET @i += 1;
END

--ROLLBACK CCOMMITT
--select * from Robinho.Equino 

--Exerc 5

BEGIN TRAN
DELETE FROM Robinho.Equino
--ROLLBACK CCOMMITT


-- Este delete apaga todos os dados da tabela e é o famoso delete sem where que se fosse em uma empresa daria BO pos ele limpa a tabela
-- O begin tran ajuda a ter um backup para se algo der errado você possa dar um rollback e se tiver tudo okay mandar o commit
-- Commit esta escrito de forma errada propositalmente para ter que selecionar-lo para fazer a alteração

--Exec 6

BEGIN TRAN
Update Robinho.Equino 
	SET Sexo = 'F'
go
--ROLLBACK CCOMMITT

-- Este update atualiza todo registro da coluna sexo para F

--Exec 7

SELECT * FROM Robinho.Pessoa

--EXEC 8

DECLARE @cpf char(11) = ''/* CPF */
SELECT * FROM Robinho.Pessoa WHERE CPF = @cpf
-- Substitua o campo da variavel para utilizar o select

--Exec 9
