CREATE PROCEDURE [dbo].[BuscarTodasAsTurmasAtivas]
AS
	Select * from Turmas where Status=1
RETURN 0
