CREATE PROCEDURE [dbo].[BuscarAlunosDaTurma]
	@idTurma int
AS
	SELECT a.Id,a.Nome ,t.Id ,t.Nome FROM Aluno_Turma at 
	inner join Alunos a on a.id = at.AlunoId
	inner join Turmas t on t.id = at.TurmaId
	where TurmaId = @idTurma
	order by t.Nome
RETURN 0
