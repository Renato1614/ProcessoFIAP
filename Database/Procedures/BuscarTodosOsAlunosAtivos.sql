CREATE PROCEDURE [dbo].[BuscarTodosOsAlunosAtivos]
AS
	SELECT * from Alunos WHERE Status=1
RETURN 0
