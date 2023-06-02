CREATE PROCEDURE [dbo].[GetAllAlunos]
AS
	SELECT * from Alunos WHERE Status=1
RETURN 0
