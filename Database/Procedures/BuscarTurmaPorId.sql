CREATE PROCEDURE [dbo].[BuscarTurmaPorId]
	@id int
AS
	SELECT * FROM Turmas WHERE Id=@id
RETURN 0
