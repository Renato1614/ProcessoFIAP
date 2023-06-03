CREATE PROCEDURE [dbo].[BuscarAlunoTurmaComIdDoAlunoEIdDaTurma]
	@idAluno int ,
	@idTurma int
AS
	SELECT * FROM Aluno_Turma where AlunoId= @idAluno and TurmaId=@idTurma
RETURN 0
