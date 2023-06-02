CREATE PROCEDURE [dbo].[GetAlunoById]
	@id int
AS
	Select * from Aluno where Id= @id
RETURN 0
