CREATE PROCEDURE [dbo].[InativarTurma]
	@id int
AS
	update Turmas set Status=0 where Id=@id
RETURN 0
