CREATE PROCEDURE [dbo].[RelacionarAlunoComTurma]
	@idAluno int,
	@idTurma int
AS
	INSERT INTO Aluno_Turma(AlunoId, TurmaId) VALUES(@idAluno, @idTurma)	
RETURN 0
