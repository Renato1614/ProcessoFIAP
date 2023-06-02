CREATE PROCEDURE [dbo].[BuscarTurmaPorNome]
	@nome varchar(255)
AS
	SELECT * FROM Turmas WHERE Nome=@nome and Status=1
RETURN 0
