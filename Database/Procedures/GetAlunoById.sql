CREATE PROCEDURE [dbo].[GetAlunoById]
	@id int
AS
	Select * from Alunos where Id= @id
RETURN 0
