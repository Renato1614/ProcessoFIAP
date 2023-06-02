CREATE PROCEDURE [dbo].[EditarAluno]
	@Id int,
	@Nome varchar(255),
	@Usuario varchar(255),
	@Senha char(60),
	@Status bit
AS
	UPDATE Alunos SET 
	Nome= @Nome,
	Usuario=@Usuario,
	Senha=@Senha,
	Status=@Status where Id=@Id
RETURN 0
