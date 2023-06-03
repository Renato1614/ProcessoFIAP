CREATE PROCEDURE [dbo].[InativarRelacionamento]
	@Id int
AS
	DELETE FROM Aluno_Turma WHERE Id= @Id
RETURN 0
