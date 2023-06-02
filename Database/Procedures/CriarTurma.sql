CREATE PROCEDURE [dbo].[CriarTurma]
	@CursoId int,
	@Nome varchar(255),
	@Ano int
AS
	INSERT INTO Turmas(CursoId,Nome,Ano,Status) 
	values (@CursoId,@Nome,@Ano,1)
RETURN 0
