CREATE PROCEDURE [dbo].[BuscarTurmaPorNome]
	@nome varchar(255),
	@id int
AS
	SELECT * FROM Turmas WHERE Nome=@nome and Id <> @id and Status=1
RETURN 0
