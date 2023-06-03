CREATE PROCEDURE [dbo].[BuscarTodosAlunosDeTurmas]
AS
	SELECT at.Id,a.Id as IdAluno, a.Nome as NomeAluno, t.Id as IdTurma,t.Nome as NomeTurma FROM Aluno_Turma at
	inner join Alunos a on a.Id = at.AlunoId
	inner join Turmas t on t.Id = at.TurmaId

RETURN 0
