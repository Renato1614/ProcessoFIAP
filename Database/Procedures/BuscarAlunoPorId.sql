CREATE PROCEDURE [dbo].[BuscarAlunoPorId]
	@id int
AS
	Select * from Alunos where Id= @id
RETURN 0
