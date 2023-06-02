CREATE PROCEDURE [dbo].[EditarTurma]
	@Id int,
	@CursoId int,
	@Nome VARCHAR(255),
	@Ano int,
	@Status bit
AS
	UPDATE Turmas Set CursoId= @CursoId,
	Nome=@Nome,
	Ano = @Ano,
	Status= @Status
	where Id = @Id
RETURN 0
