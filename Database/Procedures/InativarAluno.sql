CREATE PROCEDURE [dbo].[InativarAluno]
	@Id int
AS
	UPDATE Alunos set Status=0 where Id=@Id
RETURN 0
