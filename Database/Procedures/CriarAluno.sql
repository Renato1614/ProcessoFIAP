CREATE PROCEDURE [dbo].[CriarAluno]
	@Nome varchar(255),
	@Usuario varchar(255),
	@Senha char(60),
	@Status bit
AS
	INSERT INTO Alunos(Nome,Usuario,Senha,Status) VALUES (@Nome,@Usuario,@Senha,@Status)
RETURN 0
