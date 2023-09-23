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

CREATE SCHEMA FunClube
GO

CREATE TABLE FunClube.Endereco(
	EnderecoID int primary key IDENTITY(1,1),
	Cidade varchar(50),
	CEP varchar(50)
)
CREATE TABLE FunClube.Organizadores(
	OrganizadorID int primary key IDENTITY(1,1),
	Nome varchar(100)
)
CREATE TABLE FunClube.Associado(
	SocioID int primary key IDENTITY(1,1),
	Nome varchar(100),
	RG char(10),
	CPF char(11),
	EnderecoID int,
	TipoSocioID int,
	FOREIGN KEY (EnderecoID) REFERENCES FunClube.Endereco(EnderecoID),
	FOREIGN KEY (TipoSocioID) REFERENCES FunClube.TipoSocio(TipoSocioID)
)
CREATE TABLE FunClube.Show(
	ShowID int primary key IDENTITY(1,1),
	PrecoEngreco int,
	EnderecoID int,
	OrganizadorID int,
	ArtistaID int,
	FOREIGN KEY (EnderecoID) REFERENCES FunClube.Endereco(EnderecoID),
	FOREIGN KEY (OrganizadorID) REFERENCES FunClube.Organizadores(OrganizadorID),
	FOREIGN KEY (ArtistaID) REFERENCES FunClube.Artista(ArtistaID)
)
CREATE TABLE FunClube.Artista(
	ArtistaID int primary key IDENTITY(1,1),
	Nome varchar(100)
)
CREATE TABLE FunClube.TipoSocio(
	TipoSocioID int primary key IDENTITY(1,1),
	Tipo varchar(50)
)
CREATE TABLE FunClube.ShowsAssistidos(
	SocioID int,
	ShowID int,
	DataAssistido date,
	PRIMARY KEY(SocioID, ShowID),
	FOREIGN KEY (SocioID) REFERENCES FunClube.Associado(SocioID),
	FOREIGN KEY (ShowID) REFERENCES FunClube.Show(ShowID)
)
